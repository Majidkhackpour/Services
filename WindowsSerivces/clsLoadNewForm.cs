using System;
using System.Windows.Forms;
using Services;

namespace WindowsSerivces
{
    public static class clsLoadNewForm
    {
        public static void LoadNewForm(Form frm, Panel pnlContent)
        {
            try
            {
                frm.TopLevel = false;
                frm.AutoScroll = true;
                frm.ControlBox = false;
                frm.Dock = DockStyle.Fill;
                pnlContent.Controls.Clear();
                pnlContent.BringToFront();
                pnlContent.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                //pnlContent.AutoScroll = true;
                frm.Show();
            }
            catch (Exception ex)
            {
                //WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
