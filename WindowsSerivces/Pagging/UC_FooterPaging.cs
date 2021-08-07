using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace WindowsSerivces.Pagging
{
    public partial class UC_FooterPaging : UserControl
    {
        public delegate void OnBindDataReadyEventHandler<TSender, TEventArgs>(object sender, FooterBindingDataReadyEventArg e);
        public event OnBindDataReadyEventHandler<object, List<object>> OnBindDataReady;


        private bool _isDisposed = false;
        private CancellationTokenSource _token_cus = new CancellationTokenSource();
        public List<object> list { get; private set; }
        public List<object> Pagelist { get; private set; }

        private int CurrentPage { get; set; }
        private int _pageIdx = 1;
        private int TotalCount = 0;
        public int PageIdx
        {
            get
            {
                try
                {
                    return _pageIdx <= 0 ? 1 : _pageIdx;
                }
                catch (Exception ex)
                {
                    WebErrorLog.ErrorInstence.StartErrorLog(ex);
                    return 0;
                }
            }
            set
            {
                try
                {
                    if (list == null) return;
                    if (value >= 1 && value <= TotalCount)
                    {
                        _pageIdx = value;
                        if ((txtFromPage.Text?.ParseToInt() ?? 0) != value)
                            txtFromPage.Text = value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    WebErrorLog.ErrorInstence.StartErrorLog(ex);
                }
            }
        }
        public new bool IsDisposed => _isDisposed || base.IsDisposed;

        public UC_FooterPaging() => InitializeComponent();

        private void TxtTopCount_ValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                TxtTopCount.Focus();
                CurrentPage = (int)TxtTopCount.Value;
                _token_cus?.Cancel();
                _token_cus = new CancellationTokenSource();
                Task.Run(() => PaggerAsync(_token_cus.Token, list));
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public async Task<List<object>> PagingAsync(CancellationToken token, IEnumerable<object> objList, int countPerPage, PagingPosition position)
        {
            try
            {
                while (!IsHandleCreated)
                {
                    if (token.IsCancellationRequested || IsDisposed) return null;
                    await Task.Delay(100);
                }

                if (countPerPage <= 0) countPerPage = int.MaxValue;
                if (IsDisposed || token.IsCancellationRequested) return null;
                BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            TxtTopCount.ValueChanged -= TxtTopCount_ValueChanged;
                            TxtTopCount.Maximum = int.MaxValue;
                            TxtTopCount.Minimum = 1;
                            TxtTopCount.Value = countPerPage;
                            TxtTopCount.ValueChanged += TxtTopCount_ValueChanged;
                        }
                        catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
                    }));
                CurrentPage = countPerPage;
                list = objList?.ToList();
                _ = Task.Run(() => PaggerAsync(token, objList, position));
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            return null;
        }
        private async Task PaggerAsync(CancellationToken token, IEnumerable<object> objList, PagingPosition? position = null)
        {
            var ea = new FooterBindingDataReadyEventArg() { Token = token };
            try
            {
                await Task.Delay(300);
                if (token.IsCancellationRequested) return;
                list = objList?.ToList();
                if (token.IsCancellationRequested) return;
                var proccessedPagedList = list?.ProgressPages(CurrentPage, PageIdx);
                if (token.IsCancellationRequested) return;
                TotalCount = proccessedPagedList?.TotalPages ?? 0;
                if (PageIdx > TotalCount) PageIdx = TotalCount;
                if (token.IsCancellationRequested) return;
                await SetLabelAsync(token);
                if (token.IsCancellationRequested) return;
                if (position != null && position == PagingPosition.GotoEndPage)
                    Invoke(new Action(() => PageIdx = proccessedPagedList.TotalPages));
                ea.ListData = proccessedPagedList?.Items?.Select(p => p.Item)?.ToList();
                if (token.IsCancellationRequested) return;
                Pagelist = list;
            }
            catch (OperationCanceledException) { }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
            finally { OnBindDataReady?.Invoke(this, ea); }
        }
        public List<object> NextItemsInPage(int start, int count)
        {
            try
            {
                List<object> o;
                if (start + count > Pagelist.Count)
                {
                    o = Pagelist.GetRange(start, Pagelist.Count - start);
                    return o;
                }
                o = Pagelist.GetRange(start, count);
                return o;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        private async Task SetLabelAsync(CancellationToken token)
        {
            try
            {
                var maxDelay = 100;
                if (IsDisposed) return;
                while (!IsHandleCreated)
                {
                    if (IsDisposed || token.IsCancellationRequested) return;
                    await Task.Delay(100);
                    maxDelay--;
                    if (maxDelay <= 0) return;
                }
                if (IsDisposed || token.IsCancellationRequested) return;
                Invoke(new Action(() =>
                {
                    try
                    {
                        if (IsDisposed || token.IsCancellationRequested) return;
                        if (TotalCount > 999) LblPage.Font = new Font(LblPage.Font.FontFamily, 8);
                        LblPage.Text = list?.Count() > 0 ? $"از {TotalCount}" : "";
                        txtFromPage.Text = PageIdx.ToString();
                    }
                    catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
                }));
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (PageIdx > 1)
                {
                    PageIdx = PageIdx - 1;
                    _token_cus?.Cancel();
                    _token_cus = new CancellationTokenSource();
                    Task.Run(() => PaggerAsync(_token_cus.Token, list));
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (PageIdx < TotalCount)
                {
                    PageIdx = PageIdx + 1;
                    _token_cus?.Cancel();
                    _token_cus = new CancellationTokenSource();
                    Task.Run(() => PaggerAsync(_token_cus.Token, list));
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void txtFromPage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PageIdx = txtFromPage.Text.ParseToInt();
                if (PageIdx > 0 && PageIdx <= TotalCount)
                {
                    _token_cus?.Cancel();
                    _token_cus = new CancellationTokenSource();
                    Task.Run(() => PaggerAsync(_token_cus.Token, list));
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        protected override void Dispose(bool isDisposing)
        {
            try
            {
                if (_isDisposed) return;
                _isDisposed = true;

                components?.Dispose();
                components = null;
                _token_cus?.Cancel();
                _token_cus?.Dispose();
                _token_cus = null;
                list = null;
                Pagelist = null;
                base.Dispose(isDisposing);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}