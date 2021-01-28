﻿using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Services
{
    public static class txtSetter
    {
        public static void Focus(TextBox txt,bool isDep=false)
        {
            if (!isDep)
            {
                var colour = ColorTranslator.FromHtml("#50cbb0");
                txt.BackColor = colour;
            }
            else txt.BackColor = Color.Silver;
            txt.ForeColor = Color.Black;
        }
        public static void Focus(Label lbl)
        {
            var colour = ColorTranslator.FromHtml("#50cbb0");
            lbl.ForeColor = colour;
        }
        public static void Follow(TextBox txt)
        {
            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
        }
        public static void Follow(Label lbl)
        {
            lbl.ForeColor = Color.Black;
        }

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
                var str = txt.Text;
                str = txt.Text.Replace(".", "000");
                str = str.Replace("+", "00");
                txt.SelectionStart = str.Length;
                txt.Text = str;
            }
            catch (Exception e)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(e);
            }
        }
        public static void Switch_Language_To_English()
        {
            var LAN = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(LAN);
        }
        public static void Switch_Language_To_Persian()
        {
            var LAN = new CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(LAN);
        }

        public static string ChangeNumberToDigit()
        {
            var ret = "";
            try
            {

            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }

            return ret;
        }
    }
}
