using System;

namespace Services
{
    public static class NumberToString
    {
        private static string[] yakan = { "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه" };
        private static string[] dahgan = { "", "", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };
        private static string[] dahyek = { "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده" };
        private static string[] sadgan = { "", "یکصد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" };
        private static string[] basex = { "", "هزار", "میلیون", "میلیارد", "تریلیون", "کادریلیون", "کنتلیون", "سیکستیلیون", "سپتیلیون", "اکتیلیون" };

        private static string Adad3RaghamiToStr(int num3Digit)
        {
            string s = "";
            var line = 0;
            try
            {
                int sadgan, yakanDahgan;
                yakanDahgan = num3Digit % 100;
                line = 1;
                sadgan = num3Digit / 100;
                line = 1;
                if (sadgan != 0)
                    s = NumberToString.sadgan[sadgan] + " و ";
                line = 2;
                if ((yakanDahgan >= 10) && (yakanDahgan <= 19))
                {
                    line = 3;
                    s += dahyek[yakanDahgan - 10];
                }
                else
                {
                    line = 4;
                    var d2 = yakanDahgan / 10;
                    line = 5;
                    if (d2 != 0)
                        s = s + dahgan[d2] + " و ";
                    line = 6;
                    var d1 = yakanDahgan % 10;
                    line = 7;
                    if (d1 != 0)
                        s = s + yakan[d1] + " و ";
                    line = 8;
                    s = s.Substring(0, s.Length - 3);
                }
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex, $"line={line}, num3digit={num3Digit}"); }
            return s;
        }
        static string AdadToStr(long num)
        {
            var stotal = "";
            var line = 0;
            try
            {
                if (num == 0) return yakan[0];
                var snum = num.ToString();
                line = 1;
                snum = snum.PadLeft(((snum.Length - 1) / 3 + 1) * 3, '0');
                line = 2;
                var L = snum.Length / 3 - 1;
                line = 3;
                for (var i = 0; i <= L; i++)
                {
                    var b = int.Parse(snum.Substring(i * 3, 3));
                    line = 4;
                    if (b != 0)
                    {
                        line = 5;
                        stotal = stotal + Adad3RaghamiToStr(b) + " " + basex[L - i] + " و ";
                    }
                }
                line = 6;
                stotal = stotal.Substring(0, stotal.Length - 3);
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex, $"line={line}, num={num}"); }
            return stotal;
        }
        private static string AdadToHoroof(this string numberStr)
        {
            var line = 0;
            try
            {
                var flag = "";
                var sNumber = numberStr.Trim();
                if (string.IsNullOrEmpty(sNumber))
                    return "";
                line = 1;
                if (sNumber.Length > 0 && sNumber.Substring(0, 1) == "-")
                {
                    line = 2;
                    flag = "منفی ";
                    sNumber = sNumber.Substring(1, sNumber.Length - 1);
                }
                line = 3;
                if (!sNumber.Contains(CurrencyText.DecimalPoint))
                    return flag + AdadToStr(long.Parse(sNumber));
                line = 4;
                var str = sNumber.Split(CurrencyText.DecimalPoint.ToCharArray());
                line = 5;
                var result = flag + AdadToStr(long.Parse(str[0]));
                line = 6;
                var ashar = str[1].TrimEnd('0');
                line = 7;
                if (ashar.Length > 0)
                    result += " ممیز ";
                line = 8;
                if (!string.IsNullOrEmpty(ashar))
                    result += AdadToStr(long.Parse(ashar));
                line = 9;
                switch (ashar.Length)
                {
                    case 1:
                        result += " دهم ";
                        break;
                    case 2:
                        result += " صدم ";
                        break;
                    case 3:
                        result += " هزارم ";
                        break;
                    case 4:
                        result += " ده هزارم ";
                        break;
                    case 5:
                        result += " صد هزارم ";
                        break;
                }
                return result;
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex, $"line={line},numberstr={numberStr}"); }
            return "";
        }
        public static string AdadToHoroof(this decimal number)
        {
            try
            {
                return AdadToHoroof(number.ToString());
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
            return "";
        }
        public static string AdadToHoroof(this int number)
        {
            try
            {
                return AdadToHoroof(number.ToString());
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
            return "";
        }
        public static string AdadToHoroof(this long number)
        {
            try
            {
                return AdadToHoroof(number.ToString());
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
            return "";
        }
        public static string AdadToHoroof(this double number)
        {
            try
            {
                return AdadToHoroof(number.ToString());
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
            return "";
        }
        public static string CurrencyToHoroof(this decimal number)
        {
            var res = "";
            try
            {
                var str = number.ToString("N0").Split(CurrencyText.DecimalPoint.ToCharArray());
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            return res;
        }
    }
}
