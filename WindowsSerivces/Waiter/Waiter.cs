using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace WindowsSerivces.Waiter
{
    public class Waiter : IDisposable
    {
        #region privateFields
        IWaiterUi _loadingForm;
        private Control _parent;
        private List<Control> _disabledItems = null;
        private bool _isDisposed;
        #endregion

        #region Properties
        public bool IsDisposed => _isDisposed;
        #endregion

        public Waiter(string labelProgress, Control parent, Task task = null, bool freezForm = false)
            => ctor(labelProgress, (parent is Panel || parent is Form || parent is UserControl)
                    ? parent
                    : parent.FindForm()
                , task, freezForm);
        public Waiter(string labelProgress = "در حال پردازش", Form parent = null, Task task = null, bool freezForm = false)
            => ctor(labelProgress, parent, task, freezForm);
        private void ctor(string labelProgress, Control parent, Task task, bool freezForm)
        {
            try
            {
                _parent = parent;
                if (parent == null)
                {
                    _loadingForm = new WaiterForm(null, labelProgress, task);
                    _loadingForm.OnAutoClose += _loadingForm_OnAutoClose;
                    _loadingForm.Show();
                }
                else
                {
                    if (parent is Form)
                    {
                        if (freezForm)
                            foreach (Control control in parent.Controls)
                            {
                                if (_disabledItems == null)
                                    _disabledItems = new List<Control>();
                                _disabledItems.Add(control);
                                control.Enabled = false;
                            }
                    }
                    _loadingForm = new WaiterUserControl(parent, labelProgress, task);
                    _loadingForm.OnAutoClose += _loadingForm_OnAutoClose;
                }
                Application.DoEvents();
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
        private Task _loadingForm_OnAutoClose(object sender, EventArgs e)
        {
            try
            {
                if (IsDisposed) return Task.CompletedTask;
                var temp_disabledItems = _disabledItems?.ToList();
                _disabledItems = null;
                if (temp_disabledItems?.Any() ?? false)
                {
                    if (IsDisposed || _parent.IsDisposed) return Task.CompletedTask;
                    _parent.BeginInvoke(new MethodInvoker(() =>
                    {
                        try
                        {
                            if (IsDisposed || _parent.IsDisposed) return;
                            foreach (Control control in temp_disabledItems)
                                control.Enabled = true;
                            Dispose();
                        }
                        catch (Exception ex)
                        {
                            WebErrorLog.ErrorInstence.StartErrorLog(ex, "Waiter.cs=>_loadingForm_OnAutoClose\r\n" +
                                          $"#ParentName:{_parent?.Name}\r\n" +
                                          $"_parentText:{_parent?.Text}");
                        }
                    }));
                }
                return _loadingForm.HideAsync();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return Task.CompletedTask;
            }
        }
        public void Dispose() => Dispose(true);
        public void Dispose(bool disposing)
        {
            try
            {
                if (_isDisposed) return;
                _isDisposed = true;

                var temp_disabledItems = _disabledItems?.ToList();
                _disabledItems = null;
                if ((temp_disabledItems?.Any() ?? false) && !_parent.IsDisposed)
                    _parent.BeginInvoke(new MethodInvoker(() =>
                    {
                        try
                        {
                            if (_parent.IsDisposed) return;
                            foreach (Control control in temp_disabledItems)
                                control.Enabled = true;
                            Dispose();
                        }
                        catch (Exception ex)
                        {
                            WebErrorLog.ErrorInstence.StartErrorLog(ex, "Waiter.cs=>_loadingForm_OnAutoClose\r\n" +
                                          $"#ParentName:{_parent?.Name}\r\n" +
                                          $"_parentText:{_parent?.Text}");
                        }
                    }));

                if (_loadingForm != null)
                {
                    _loadingForm.HideAsync();
                    _loadingForm.OnAutoClose -= _loadingForm_OnAutoClose;
                    _loadingForm.Dispose();
                    _loadingForm = null;
                }
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
    }
}
