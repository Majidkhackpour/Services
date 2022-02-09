using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
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
                await pinger.SendPingAsync("www.google.com");
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
        public static string GetLocalIpAddress()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://ifconfig.me");

                request.UserAgent = "curl";

                string publicIpAddress;

                request.Method = "GET";
                using (var response = request.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                    publicIpAddress = reader.ReadToEnd();

                return publicIpAddress.Replace("\n", "");
            }
            catch { return null; }
        }
        public static string GetNetworkIpAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                    if (ip.AddressFamily == AddressFamily.InterNetwork) return ip.ToString();
                throw new Exception("No network adapters with an IPv4 address in the system!");
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        //public static string GetIp() => AsyncContext.Run(GetNetworkIpAddress);
        public static string WebApi = "https://aarad.ir";
        //public static string WebApi = "https://localhost:44358";
        public static void NEVER_EAT_POISON_Disable_CertificateValidation()
        {
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (
                    object s,
                    X509Certificate certificate,
                    X509Chain chain,
                    SslPolicyErrors sslPolicyErrors
                )
                {
                    return true;
                };
        }
    }
}
