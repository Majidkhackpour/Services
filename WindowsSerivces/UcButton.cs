using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace WindowsSerivces
{
    public partial class UcButton : UserControl
    {
        public new event Func<UcButton, Task> OnClick;
        private bool _isSelect = false;
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public bool IsSelect
        {
            get => _isSelect;
            set
            {
                _isSelect = value;
                if (_isSelect)
                {
                    var c = Color.Red;
                    groupPanel67.BackColor = c;
                    groupPanel67.Style.BackColor = c;
                    groupPanel67.Style.BackColor2 = c;
                }
                else
                {
                    var c = Color.FromArgb(98, 115, 231);
                    groupPanel67.BackColor = c;
                    groupPanel67.Style.BackColor = c;
                    groupPanel67.Style.BackColor2 = c;
                }
            }
        }
        public EnContractType_ Type { get; set; } = EnContractType_.None;
        public UcButton() => InitializeComponent();
        private void RaiseOnClickEvent(UcButton btn)
        {
            try
            {
                var handler = OnClick;
                if (handler != null) OnClick?.Invoke(btn);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void lblTitle_Click(object sender, EventArgs e) => RaiseOnClickEvent(this);
    }
}
