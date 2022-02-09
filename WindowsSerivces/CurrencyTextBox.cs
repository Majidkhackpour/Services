using System;
using System.Windows.Forms;
using Services;

namespace WindowsSerivces
{
    public partial class CurrencyTextBox : UserControl
    {
        public event Action OnTextChanged;
        private void RaiseEvent()
        {
            var handler = OnTextChanged;
            if (handler != null)
                OnTextChanged?.Invoke();
        }
        public decimal TextDecimal
        {
            get
            {
                var de = txtNumber.Text.Replace(".", "");
                return de.ParseToDecimal();
            }
            set
            {
                var d = value.ToString();
                if (d.EndsWith(".00")) d = d.Replace(".00", "");
                if (d.EndsWith(".0")) d = d.Replace(".0", "");
                txtNumber.Text = d;
            }
        }

        public CurrencyTextBox() => InitializeComponent();

        private void txtNumber_Enter(object sender, System.EventArgs e) => txtSetter.Focus(txtNumber);
        private void txtNumber_Leave(object sender, System.EventArgs e) => txtSetter.Follow(txtNumber);
        private void txtNumber_TextChanged(object sender, System.EventArgs e)
        {
            txtSetter.Three_Ziro(txtNumber);
            RaiseEvent();
        }
    }
}
