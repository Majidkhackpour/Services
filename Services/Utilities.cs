using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Services
{
    public class Utilities
    {
        public static async Task<ReturnedSaveFuncInfo> PingHostAsync()
        {
            Ping pinger = null;
            var res = new ReturnedSaveFuncInfo();
            try
            {
                pinger = new Ping(); 
                pinger.Send("www.google.com");
            }
            catch (PingException)
            {
                res.AddReturnedValue(ReturnedState.Error, "لطفا اتصال سیستم به اینترنت را بررسی نمایید");
            }
            finally
            {
                pinger?.Dispose();
            }

            return res;
        }
    }
}
