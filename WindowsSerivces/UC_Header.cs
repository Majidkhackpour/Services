using System.Windows.Forms;

namespace WindowsSerivces
{
    public partial class UC_Header : UserControl
    {
        public new string Text { get => lblMessage.Text; set => lblMessage.Text = value; }
        private bool _isModified = false;
        public bool IsModified
        {
            get => _isModified;
            set
            {
                _isModified = value;
                if (_isModified) Text += "(*)";
                else Text = Text;
            }
        }

        public UC_Header() => InitializeComponent();
    }
}
