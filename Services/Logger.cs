using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Services
{
    public class Logger
    {
        private static bool initialized = false;
        private static SemaphoreSlim _WriteFileSemaphore = new SemaphoreSlim(1, 1);
        public static string StartUpPath { get; private set; }
        public static string FileName { get; private set; }

        public static void init(string startUpPath, string fileName = "BuidlingEventLog.txt", bool archive = false)
        {
            try
            {
                if (!Directory.Exists(startUpPath))
                    Directory.CreateDirectory(startUpPath);
                startUpPath = Path.Combine(startUpPath, "Log");
                if (!Directory.Exists(startUpPath))
                    Directory.CreateDirectory(startUpPath);
                var d = DateTime.Now;
                if (archive)
                    fileName = $"{d.Year}_{d.Month}_{d.Day} {d.Hour}_{d.Minute}_{d.Second} {fileName}";
                StartUpPath = startUpPath;
                FileName = fileName;
                //حذف فایل های آرشیو قدیمی و حفظ فایل ها فقط تا 7 روز
                var files = Directory.GetFiles(StartUpPath);
                if (files != null && files.Any())
                    foreach (var file in files)
                    {
                        FileInfo inf = new FileInfo(file);
                        if (inf.CreationTime.AddDays(7) < DateTime.Now)
                            try { File.Delete(file); }
                            catch { }
                    }
                var FullFileName = Path.Combine(StartUpPath, FileName);
                try { if (File.Exists(FullFileName)) File.Delete(FullFileName); }
                catch { }
                try { if (Directory.Exists(FullFileName)) Directory.Delete(FullFileName); }
                catch { }
                initialized = true;
            }
            catch (Exception ex) { WebErrorLog.ErrorInstence.StartErrorLog(ex); }
        }

        public void SaveLog(string message, EnGroup group = EnGroup.None, DateTime? date = null, short trycount = 10, [System.Runtime.CompilerServices.CallerMemberName]
            string memberName = "",
            [System.Runtime.CompilerServices.CallerFilePath]
            string sourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber]
            int sourceLineNumber = 0)
        => Task.Run(() => SaveLog_(message, group, date, trycount, memberName, sourceFilePath, sourceLineNumber));

        private async Task SaveLog_(string message, EnGroup group, DateTime? date, short trycount,
                       string memberName,
                     string sourceFilePath,
                       int sourceLineNumber)
        {
            if (!initialized) return;
            await _WriteFileSemaphore.WaitAsync();
            try
            {
                date = date ?? DateTime.Now;
                if (!string.IsNullOrEmpty(sourceFilePath))
                {
                    var info = new FileInfo(sourceFilePath);
                    var splited = sourceFilePath.SplitString();
                    sourceFilePath = splited[splited.Count - 2];
                }
                var msg = $"\r\n{date}:\t{sourceFilePath}.{memberName} Line:{sourceLineNumber}\r\n {message}\r\n______________________________";
                string filePath = StartUpPath;
                if (group != EnGroup.None)
                    filePath = Path.Combine(filePath, group.GetDisplay());
                if (!Directory.Exists(filePath))
                    Directory.CreateDirectory(filePath);

                filePath = Path.Combine(filePath, FileName);
                if (File.Exists(filePath))
                    File.AppendAllLines(filePath, new List<string>() { msg });
                else
                    File.WriteAllText(filePath, msg);
            }
            catch (Exception ex)
            {
                if (trycount > 0)
                {
                    await Task.Delay(100);
                    await SaveLog_(message, group, date, --trycount, memberName, sourceFilePath, sourceLineNumber);
                    return;
                }
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
            finally { _WriteFileSemaphore.Release(); }
        }

        private class NestedLogger
        {
            internal static readonly Logger instance = new Logger();
            static NestedLogger() { }
        }
        public static Logger LoggerInstance => NestedLogger.instance;

    }
}
