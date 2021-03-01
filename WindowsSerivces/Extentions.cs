using System;
using System.Windows.Forms;
using Notification;
using Services;

namespace WindowsSerivces
{
    public static class Extentions
    {
        public static void ShowError(this Form frm, ReturnedSaveFuncInfo res, string title = "")
        {
            try
            {
                var frmError = new FrmShowErrorMessage(res, title);
                frmError.ShowDialog();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
