using Services;
using Services.Interfaces.Sync;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsSerivces.Error;

namespace WindowsSerivces.Sync
{
    public partial class UcSyncStatus : UserControl, ISendData2Server, IDisposable
    {
        private CancellationTokenSource _statusToken = new CancellationTokenSource();
        private CancellationTokenSource _totalCountToken = new CancellationTokenSource();
        private CancellationTokenSource _shortMessageToken = new CancellationTokenSource();
        private CancellationTokenSource _groupToken = new CancellationTokenSource();
        private SyncStatus _status = SyncStatus.SyncNotStarted;
        private decimal _percent = 0;
        private int _totalCount = 0, _count = 0;
        private string _title = "", _shortMessage = "";


        public string Title
        {
            get => _title;
            set
            {
                try
                {
                    _title = value;
                    lblTitle.Text = value;
                }
                catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
            }
        }
        public SyncStatus Status
        {
            get => _status;
            set
            {
                try
                {
                    _statusToken?.Cancel();
                    _statusToken = new CancellationTokenSource();
                    var token = _statusToken.Token;
                    _status = value;
                    _ = ChangeStatusAsync(token);
                }
                catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
            }
        }
        public ReturnedSaveFuncInfo FinalStatus { get; set; }
        public string ShortMessage
        {
            get => _shortMessage;
            set
            {
                try
                {
                    if (IsDisposed) return;
                    _shortMessage = value;
                    _shortMessageToken?.Cancel();
                    _shortMessageToken = new CancellationTokenSource();
                    var token = _shortMessageToken.Token;
                    _ = ChangeShortMessageAsync(token);
                }
                catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
            }
        }
        public int TotalCount
        {
            get => _totalCount;
            set
            {
                try
                {
                    _totalCountToken?.Cancel();
                    _totalCountToken = new CancellationTokenSource();
                    var token = _totalCountToken.Token;
                    _totalCount = value;
                    _ = ChangePercentAsync(token);
                }
                catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
            }
        }
        public int Count
        {
            get => _count;
            set
            {
                try
                {
                    _totalCountToken?.Cancel();
                    _totalCountToken = new CancellationTokenSource();
                    var token = _totalCountToken.Token;
                    _count = value;
                    _ = ChangePercentAsync(token);
                }
                catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
            }
        }



        public void Reset()
        {
            try
            {
                if (FinalStatus == null)
                    FinalStatus = new ReturnedSaveFuncInfo();
                FinalStatus?.ResetWarningList();
                FinalStatus?.ResetInformationList();
                FinalStatus?.ResetErrorList();
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
        private async Task ChangeStatusAsync(CancellationToken token)
        {
            try
            {
                if (IsDisposed || token.IsCancellationRequested) return;
                while (!IsHandleCreated)
                {
                    if (IsDisposed || token.IsCancellationRequested) return;
                    await Task.Delay(1000);
                }

                if (IsDisposed || token.IsCancellationRequested) return;
                BeginInvoke(new MethodInvoker(() =>
                {
                    try
                    {
                        if (IsDisposed || token.IsCancellationRequested) return;
                        switch (_status)
                        {
                            case SyncStatus.SyncNotStarted:
                                pictureBox1.Image = Properties.Resources.Info;
                                break;
                            case SyncStatus.Syncing:
                                pictureBox1.Image = Properties.Resources.wait_Small_JPG;
                                break;
                            case SyncStatus.SyncedOk:
                                pictureBox1.Image = Properties.Resources.accept;
                                break;
                            case SyncStatus.SyncFailed:
                                pictureBox1.Image = Properties.Resources.Error;
                                break;
                            default:
                                pictureBox1.Image = Properties.Resources.icons8_warning_50;
                                WebErrorLog.ErrorInstence.StartErrorLog($"status({_status}) is not defined!");
                                break;
                        }
                    }
                    catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
                }));
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
        private async Task ChangeShortMessageAsync(CancellationToken token)
        {
            try
            {
                if (IsDisposed || token.IsCancellationRequested) return;
                while (!IsHandleCreated)
                {
                    await Task.Delay(500);
                    if (IsDisposed || token.IsCancellationRequested) return;
                }
                if (IsDisposed || token.IsCancellationRequested) return;
                BeginInvoke(new MethodInvoker(() =>
                {
                    try
                    {
                        if (IsDisposed || token.IsCancellationRequested) return;
                        lblShortMessage.Text = _shortMessage;
                    }
                    catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
                }));
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
        private async Task ChangePercentAsync(CancellationToken token)
        {
            try
            {
                while (!IsHandleCreated)
                {
                    await Task.Delay(100);
                    if (IsDisposed || token.IsCancellationRequested) return;
                }

                if (IsDisposed || token.IsCancellationRequested) return;
                BeginInvoke(new MethodInvoker(() =>
                {
                    try
                    {
                        if (IsDisposed || token.IsCancellationRequested) return;
                        if (Count != 0 && TotalCount != 0)
                            _percent = Math.Round(100 * (decimal)Count / TotalCount, 2);
                        else _percent = 0;
                        lblPercent.Text = $@"{_percent:N0}%";
                        if (_percent < 100 && _percent > 0)
                        {
                            if (!lblPercent.Visible)
                                lblPercent.Visible = true;
                            toolTip1.SetToolTip(lblPercent, $"ارسال {Count} از {TotalCount}");
                        }
                        else
                            lblPercent.Visible = false;
                    }
                    catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
                }));
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }

        public UcSyncStatus() => InitializeComponent();

        private void controls_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmShowErrorMessage(FinalStatus, $"نتیجه سینک {Title}");
                frm.ShowDialog(FindForm());
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }
    }
}
