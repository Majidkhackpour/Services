using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Services
{
    public static class txtSetter
    {
        public static void Focus(TextBox txt, bool isDep = false)
        {
            if (!isDep)
            {
                var colour = ColorTranslator.FromHtml("#50cbb0");
                txt.BackColor = colour;
            }
            else txt.BackColor = Color.Silver;
            txt.ForeColor = Color.Black;
        }
        public static void Focus(Label lbl, bool isDep = false)
        {
            if (isDep)
            {
                var colour = ColorTranslator.FromHtml("#50cbb0");
                lbl.ForeColor = colour;
            }
            else
                lbl.ForeColor = Color.Red;
        }
        public static void Follow(TextBox txt)
        {
            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
        }
        public static void Follow(Label lbl) => lbl.ForeColor = Color.Black;
        public static void FocusMsk(MaskedTextBox txt)
        {
            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
        }
        public static void FollowMsk(MaskedTextBox txt)
        {
            var colour = ColorTranslator.FromHtml("#17212b");
            txt.BackColor = colour;
            txt.ForeColor = Color.White;
        }
        public static void KeyPress_Whit_Dot(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) <= 57 & Convert.ToInt32(e.KeyChar) >= 45 || Convert.ToInt32(e.KeyChar) <= 1785 & Convert.ToInt32(e.KeyChar) >= 1776 || Convert.ToInt32(e.KeyChar) == 8)
            {
            }
            else
                e.KeyChar = Convert.ToChar(Keys.None);
        }
        public static void KeyPress_Whitout_Dot(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) <= 57 & Convert.ToInt32(e.KeyChar) >= 48 || Convert.ToInt32(e.KeyChar) <= 1785 & Convert.ToInt32(e.KeyChar) >= 1776 || Convert.ToInt32(e.KeyChar) == 8)
            {
            }
            else
                e.KeyChar = Convert.ToChar(Keys.None);
        }
        public static void Three_Ziro(TextBox txt)
        {
            try
            {
                var a = txt.Text;
                a = a.Replace("/", "")
                    .Replace("_", "").Replace("=", "").Replace(@"\", "")
                    .Replace("|", "").Replace(")", "").Replace("(", "")
                    .Replace("&", "").Replace("^", "").Replace("%", "")
                    .Replace("$", "").Replace("#", "").Replace("@", "")
                    .Replace("!", "").Replace("~", "").Replace(",", "");
                a = a.Replace("+", "00");
                a = a.Replace("*", "000000");
                a = a.Replace("-", "000");
                if (a.Contains("."))
                    a = a.Replace(".", "");
                a = a.ParseToDecimal().ThreeSeparator();
                txt.Text = a;
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public static void Switch_Language_To_English()
        {
            var lan = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(lan);
        }
        public static void Switch_Language_To_Persian()
        {
            var lan = new CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(lan);
        }
    }
}
