using System;

namespace Services
{
    public static class NumberToString
    {
        private static string[] yakan = new string[10] { "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه" };
        private static string[] dahgan = new string[10] { "", "", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };
        private static string[] dahyek = new string[10] { "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده" };
        private static string[] sadgan = new string[10] { "", "یکصد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" };
        private static string[] basex = new string[5] { "", "هزار", "میلیون", "میلیارد", "تریلیون" };
        private static string Getnum3(int num3)
        {
            var s = "";

            try
            {
                var d12 = num3 % 100;
                var d3 = num3 / 100;
                if (d3 != 0) s = sadgan[d3] + " و ";
                if ((d12 >= 10) && (d12 <= 19)) s += dahyek[d12 - 10];
                else
                {
                    var d2 = d12 / 10;
                    if (d2 != 0) s = s + dahgan[d2] + " و ";
                    var d1 = d12 % 10;
                    if (d1 != 0) s = s + yakan[d1] + " و ";
                    s = s.Substring(0, s.Length - 3);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }

            return s;
        }
        public static string Num2Str(string snum)
        {
            try
            {
                var stotal = "";
                if (snum == "") return "صفر";
                if (snum == "0") return yakan[0];
                snum = snum.PadLeft(((snum.Length - 1) / 3 + 1) * 3, '0');
                var l = snum.Length / 3 - 1;
                for (var i = 0; i <= l; i++)
                {
                    var b = snum.Substring(i * 3, 3).ParseToInt();
                    if (b != 0)
                        stotal = stotal + Getnum3(b) + " " + basex[l - i] + " و ";
                }
                stotal = stotal.Substring(0, stotal.Length - 3);
                return stotal;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "";
            }
        }
    }
}
