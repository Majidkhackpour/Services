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
                OnTextChanged();
        }
        public decimal TextDecimal { get => txtNumber.Text.ParseToDecimal(); set => txtNumber.Text = value.ToString(); }

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
