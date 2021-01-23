using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Services
{
    public class ErrorHandler
    {
        public static ENSource Source;
        public static string Version;
        public static bool TakeScreenShot;
        public static string Path;
        public static string Username;
        public static string Password;
        public static short MaxCountPerTime { get; set; }
        public static string HardSerial { get; set; }

        public static long AndroidIme { get; set; }
        private static bool inited = false;

        private static readonly string _fileSavePath =
            System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "ErrorHandler");

        private static Task _retryThread = null;

        public static void AddHandler(string version,
            ENSource source, string path,string hardSerial, string username = "accountingerrorlog",
            string password = "accountingerrorlog",
            int minutes = 10, int minSecendsBetweenExeptions = 30)
        {
            if (minSecendsBetweenExeptions <= 60)
                WebErrorLog.MinMinutsBetweenExeptions = 1;
            else
                WebErrorLog.MinMinutsBetweenExeptions = minSecendsBetweenExeptions / 60;
            Username = username;
            Password = password;
            if (inited) return;
            inited = true;
            if (string.IsNullOrEmpty(version))
                new ArgumentNullException(nameof(version), "The version can not be null or empty");
            if (path == null)
                new ArgumentNullException(nameof(path), "The path can not be null");
            if (string.IsNullOrEmpty(username))
                new ArgumentNullException(nameof(username), "The username can not be null or empty");
            if (string.IsNullOrEmpty(password))
                new ArgumentNullException(nameof(password), "The password can not be null or empty");

            WebErrorLog.SetMinute(minutes);
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(WebErrorLog.ErrorInstence.UnhandledExceptionLog);
            Source = source;
            TakeScreenShot = false; 
            Path = path;
            Version = version;
            Username = username;
            Password = password;
            HardSerial = hardSerial;
            if (_retryThread == null)
                _retryThread = Task.Run(async () => { await retrySend(); });
        }

        private static async Task retrySend()
        {
            while (true)
            {
                try
                {
                    var d = new DirectoryInfo(_fileSavePath);
                    if (!d.Exists)
                    {
                        await Task.Delay(60 * 1000);
                        continue;
                    }
                    var files = d.GetFiles("*.txt");
                    if (files?.Length < 1)
                    {
                        await Task.Delay(60 * 1000);
                        continue;
                    }
                    foreach (var fileInfo in files)
                    {
                        try
                        {
                            if (!File.Exists(fileInfo.FullName)) return;
                            var x = JsonConvert.DeserializeObject<WebErrorLog>(File.ReadAllText(fileInfo.FullName));
                            await SaveWebErrorLog(x);
                            File.Delete(fileInfo.FullName);
                        }
                        catch { }
                    }
                }
                catch (Exception)
                { }
            }
        }
        public static async Task OnExceptionHandle(WebErrorLog e)
        {
            var fileSplited = e.ClassName.Split(@"/\".ToCharArray());
            e.ClassName = fileSplited[fileSplited.Length - 1];
            e.Source = Source;
            e.Version = Version;
            e.Path = Path;
            await SaveWebErrorLog(e);
        }

        private static async Task SaveWebErrorLog(WebErrorLog webErrorLog)
        {
            if (!await SendToServer(webErrorLog))
                SaveToFile(webErrorLog, _fileSavePath);
        }

        private static async Task<bool> SendToServer(WebErrorLog cls)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Utilities.WebApi + "/api/ErrorHandler/SaveAsync", content);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static void SaveToFile(WebErrorLog webErrorLog, string localSavePath)
        {
            try
            {
                if (localSavePath?.Length < 1)  return;
                if (!Directory.Exists(localSavePath))
                    Directory.CreateDirectory(localSavePath);
                var filepath = System.IO.Path.Combine(localSavePath, webErrorLog.Guid + ".txt");
                File.WriteAllText(filepath, JsonConvert.SerializeObject(webErrorLog));
            }
            catch
            {
            }
        }
    }
}
