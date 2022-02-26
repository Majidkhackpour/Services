using Services;
using System;
using System.Windows.Forms;
using WindowsSerivces.Error;

namespace WindowsSerivces
{
    public static class Extentions
    {
        public static void ShowError(this Form frm, ReturnedSaveFuncInfo res, string title = "")
        {
            try
            {
                var frmError = new FrmShowErrorMessage(res, title);
                frmError.ShowDialog(frm);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public static void ShowMessage(this Form frm, string message, string title = "")
        {
            try
            {
                var res = new ReturnedSaveFuncInfo();
                res.AddInformation(message);
                var frmError = new FrmShowErrorMessage(res, title);
                frmError.ShowDialog(frm);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public static void ShowWarning(this Form frm, string message, string title = "")
        {
            try
            {
                var res = new ReturnedSaveFuncInfo();
                res.AddWarning(message);
                var frmError = new FrmShowErrorMessage(res, title);
                frmError.ShowDialog(frm);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public static void ShowMessage(this UserControl frm, string message, string title = "")
        {
            try
            {
                var res = new ReturnedSaveFuncInfo();
                res.AddInformation(message);
                var frmError = new FrmShowErrorMessage(res, title);
                frmError.ShowDialog(frm);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public static void ShowWarning(this UserControl frm, string message, string title = "")
        {
            try
            {
                var res = new ReturnedSaveFuncInfo();
                res.AddWarning(message);
                var frmError = new FrmShowErrorMessage(res, title);
                frmError.ShowDialog(frm);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
