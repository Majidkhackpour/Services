using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace WindowsSerivces.Waiter
{
    public partial class WaiterForm : Form, IWaiterUi
    {
        private bool _isDisposed;
        private bool _isClosed;
        private readonly Form _parent;
        public event Func<object, EventArgs, Task> OnAutoClose;
        public new bool IsDisposed => base.IsDisposed || _isDisposed;
        public WaiterForm(Form parent = null, string labelProgress = "در حال پردازش", Task task = null)
        {
            _parent = parent;
            InitializeComponent();
            label1.Text = labelProgress;
            BringToFront();
            StartPosition = FormStartPosition.CenterScreen;

            if (task != null) Task.Run(() => CheckAutoStopAsync(task));
        }
        private async Task CheckAutoStopAsync(Task task)
        {
            try
            {
                await task;
                if (OnAutoClose != null)
                    OnAutoClose?.Invoke(this, EventArgs.Empty);
                else if (!IsDisposed && IsHandleCreated)
                    BeginInvoke(new MethodInvoker(() =>
                    {
                        try
                        {
                            if (!IsDisposed)
                                Dispose(true);
                        }
                        catch (Exception ex)
                        {
                            WebErrorLog.ErrorInstence.StartErrorLog(ex);
                        }
                    }));
            }
            catch (OperationCanceledException) { }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (_isDisposed) return;
                _isDisposed = true;

                if (!_isClosed)
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                }

                if (disposing) components?.Dispose();
                base.Dispose(disposing);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public async Task HideAsync()
        {
            try
            {
                while (!IsHandleCreated)
                    await Task.Delay(100);
                BeginInvoke(new ThreadStart(CloseLoadingForm));
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public new void Show()=>Show(_parent);
        private void CloseLoadingForm()
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void WaiterForm_FormClosing(object sender, FormClosingEventArgs e) => _isClosed = true;
    }
}
