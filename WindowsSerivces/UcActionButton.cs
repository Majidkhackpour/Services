using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace WindowsSerivces
{
    public partial class UcActionButton : UserControl
    {
        private ButtonType _type = ButtonType.None;
        public event Func<object, EventArgs, Task> OnClick;
        public string Title { get => btnFinish.Text; set => btnFinish.Text = value; }
        public ButtonType Type
        {
            get => _type;
            set
            {
                _type = value;
                switch (_type)
                {
                    case ButtonType.AcceptButton:
                        btnFinish.Image = Properties.Resources.tab_checkbox__;
                        break;
                    case ButtonType.CancelButton:
                        btnFinish.Image = Properties.Resources.tab_close_;
                        break;
                }
            }
        }
        public UcActionButton() => InitializeComponent();
        private void RaiseOnClickEvent(object sender, EventArgs e)
        {
            try
            {
                var handler = OnClick;
                if (handler != null) OnClick?.Invoke(sender, e);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void btnFinish_Click(object sender, EventArgs e) => RaiseOnClickEvent(sender, e);
        public void PerformClick() => btnFinish.PerformClick();
    }
}
