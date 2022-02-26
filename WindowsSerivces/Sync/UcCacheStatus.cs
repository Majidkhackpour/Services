using EntityCache.WebService;
using Services;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSerivces.Sync
{
    public partial class UcCacheStatus : UserControl
    {
        private ToolTip _tip = null;
        private bool _isEventHandlerCreate;
        private CancellationTokenSource _createMessageToken = new CancellationTokenSource();
        private string _contextGuid;

        public void Init(string contextGuid)
        {
            try
            {
                _contextGuid = contextGuid;
                _tip = new ToolTip();
                BindingSource();
                timer1.Start();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void BindingSource()
        {
            var line = 0;
            try
            {
                _createMessageToken?.Cancel();
                _createMessageToken = new CancellationTokenSource();
                var token = _createMessageToken.Token;

                if (IsDisposed || token.IsCancellationRequested) return;
                line = 10;
                _ = HandledCacheEventsAsync(token);
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex, $"Line:{line}"); }
        }
        private async Task HandledCacheEventsAsync(CancellationToken token)
        {
            while (!_isEventHandlerCreate)
                try
                {
                    await Task.Delay(new Random().Next(1000));
                    if (IsDisposed || token.IsCancellationRequested) return;

                    if (IsDisposed || token.IsCancellationRequested) return;
                    _isEventHandlerCreate = true;

                    var res = await Utilities.PingHostAsync();
                    var loginState = res.HasError;

                    _ = loginState
                        ? CreateMessageAsync("ارتباط با سرور برقرار نیست", Properties.Resources.connection_failed, token)
                        : CreateMessageAsync("ارتباط  با سرور برقرار است", Properties.Resources.connection_succsess, token);
                }
                catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
        private async Task CreateMessageAsync(string pMessage, Bitmap pRes, CancellationToken token)
        {
            try
            {
                if (IsDisposed || token.IsCancellationRequested) return;
                while (!IsHandleCreated)
                {
                    await Task.Delay(100);
                    if (IsDisposed || token.IsCancellationRequested) return;
                }
                if (IsDisposed || token.IsCancellationRequested) return;
                BeginInvoke(new Action(() =>
                {
                    try
                    {
                        if (IsDisposed || token.IsCancellationRequested) return;
                        _tip.SetToolTip(btnStatus, !string.IsNullOrEmpty(pMessage) ? pMessage : "ارتباط با سرور برقرار نیست");
                        btnStatus.Image = pRes;
                    }
                    catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
                }));
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }

        public UcCacheStatus() => InitializeComponent();


        private async void CmReConnect_click(object sender, EventArgs e)
        {
            try
            {
                _createMessageToken?.Cancel();
                _createMessageToken = new CancellationTokenSource();
                var token = _createMessageToken.Token;

                var res = await Utilities.PingHostAsync();
                if (res.HasError)
                {
                    _ = CreateMessageAsync("ارتباط با سرور برقرار نیست", Properties.Resources.connection_failed, token);
                    return;
                }

                if (IsDisposed || token.IsCancellationRequested) return;
                _ = CreateMessageAsync("درحال برقراری ارتباط با سرور...", Properties.Resources.connection_loading, token);
                _ = Task.Run(() => WebServiceHandlers.Instance.StartSendToServerAsync());
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
        private void CmDisplayStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (FrmConnectionSyncStatus.GetInstance(_contextGuid) == FindForm())
                    throw new Exception("FrmConnectionSyncStatus.GetInstance(ContextGuid) is parent of current!");
                FrmConnectionSyncStatus.GetInstance(_contextGuid).ShowDialog(this);
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
        private void timer1_Tick(object sender, EventArgs e) => BindingSource();
    }
}
