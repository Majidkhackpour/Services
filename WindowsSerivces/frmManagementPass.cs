using System;
using System.Windows.Forms;
using Services;

namespace WindowsSerivces
{
    public partial class frmManagementPass : Form
    {
        private string password = "NP12001300";
        public frmManagementPass()=>InitializeComponent();
        private void btnFinish_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("رمز مدیریتی را وارد نمایید");
                    return;
                }
                if(txtPass.Text!=password)
                {
                    MessageBox.Show("رمز ورود صحیح نمی باشد");
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void frmManagementPass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter: btnFinish.PerformClick();
                        break;
                    case Keys.Escape:
                        DialogResult = DialogResult.Cancel;
                        Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
