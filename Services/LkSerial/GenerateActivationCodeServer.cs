using System;

namespace Services.LkSerial
{
    public class GenerateActivationCodeServer
    {
        public static string ActivationCode(int term, string hddSerial)
        {
            var code = "";
            try
            {
                var sum = hddSerial.ParseToLong();


                sum += 13992598;

                var date = DateTime.Now.AddMonths(term);
                var mounth = "";
                var day = "";
                if (date.Month < 10) mounth = "0" + date.Month;
                else mounth = date.Month.ToString();

                if (date.Day < 10) day = "0" + date.Day;
                else day = date.Day.ToString();

                code = sum.ToString() + date.Year + mounth + day;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }

            return code;
        }
    }
}
