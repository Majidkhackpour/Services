using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WebTelegramReporter
    {
        public Guid CustomerGuid { get; set; }
        public string Message { get; set; }
        public ENSource Source { get; set; }
        public DateTime Date { get; set; }
        public string Time => Date.ToShortTimeString();

        public static async Task SendScrapperReportAsync(List<ScrapperReportViewModel> cls)
        {
            try
            {
                var str = new WebTelegramReporter()
                {
                    CustomerGuid = Guid.Empty,
                    Source = ENSource.Scrapper,
                    Message = GetTelegramMessage(cls),
                    Date = DateTime.Now
                };
                await SendAsync(str);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private static string GetTelegramMessage(List<ScrapperReportViewModel> cls)
        {
            var msg = "";
            try
            {
                msg = $"دریافت داده از دیوار \r\n" +
                      $"====================== \r\n \r\n";
                foreach (var item in cls)
                    msg += $"{item.Type.GetDisplay()} : {item.Count} \r\n";
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }

            return msg;
        }
        private static async Task SendAsync(WebTelegramReporter cls)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Utilities.WebApi + "/api/TelegramReporter/SendAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public static async Task SendBuildingReport(Guid cusGuid, string message)
        {
            try
            {
                var res = await Utilities.PingHostAsync();
                if (res.HasError) return;
                var str = new WebTelegramReporter()
                {
                    CustomerGuid = cusGuid,
                    Date = DateTime.Now,
                    Source = ENSource.Building,
                    Message = message
                };
                await SendAsync(str);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
