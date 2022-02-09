using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace WindowsSerivces.Waiter
{
    public partial class WaiterUserControl : UserControl, IWaiterUi
    {
        private bool _isDisposed;
        private readonly Control _parent;
        public event Func<object, EventArgs, Task> OnAutoClose;
        public new bool IsDisposed => _isDisposed || base.IsDisposed;
        public new void Show() => base.Show();

        public WaiterUserControl(Control parent, string labelProgress, Task task)
        {
            try
            {
                _parent = parent;
                InitializeComponent();
                BackColor = System.Drawing.Color.White;
                label1.Text = labelProgress;

                double percentage = 1;

                if (Width > parent.Width || Height > parent.Height)
                {
                    var difW = parent.Width - Width;
                    var difH = parent.Height - Height;
                    if (difH >= difW)
                        percentage = (double)(parent.Width - 50) / Width;
                    else
                        percentage = (double)(parent.Height - 50) / Height;
                }
                Width = (int)(Width * percentage);
                Height = (int)(Height * percentage);
                AutoScaleDimensions = new System.Drawing.SizeF(0, 0);
                BackColor = System.Drawing.Color.White;
                Left = (parent.Width - Width) / 2;
                Top = (parent.Height - Height) / 2;

                parent.Controls.Add(this);

                BringToFront();

                if (task != null) Task.Run(() => CheckAutoStopAsync(task));
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }

        private async Task CheckAutoStopAsync(Task task)
        {
            try
            {
                await task;
                OnAutoClose?.Invoke(this, EventArgs.Empty);
            }
            catch (OperationCanceledException) { }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
        public async Task HideAsync()
        {
            try
            {
                while (!IsHandleCreated)
                {
                    await Task.Delay(100);
                    if (IsDisposed) return;
                }
                if (IsDisposed) return;
                BeginInvoke(new MethodInvoker(() =>
                {
                    try
                    {
                        if (IsDisposed) return;
                        Dispose(true);
                    }
                    catch (Exception ex)
                    {
                        WebErrorLog.ErrorInstence.StartErrorLog(ex);
                    }
                }));
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
        public new void Dispose()
        {
            try
            {
                if (_isDisposed) return;
                _isDisposed = true;

                pictureBox1.Image = null;

                Hide();
                _parent.Controls.Remove(this);

                base.Dispose();
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
    }
}
