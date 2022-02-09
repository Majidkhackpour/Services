using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Services
{
    public class WebErrorLog : EventArgs, IErrorHandler
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;
        public string AndroidIme { get; set; }
        public string ClassName { get; set; }
        public string CpuSerial { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Description
        {
            get
            {
                if (string.IsNullOrEmpty(_description)) return "";

                _description.Replace("\r\n", "\n").Replace("\r", "\r\n").Replace("\n", "\r\n");
                return _description;
            }
            set => _description = value;
        }
        public string ExceptionError { get; set; }
        public string ExceptionMessage
        {
            get
            {
                if (string.IsNullOrEmpty(_exceptionMessage)) return "";
                _exceptionMessage.Replace("\r\n", "\n").Replace("\r", "\r\n").Replace("\n", "\r\n");
                return _exceptionMessage;
            }
            set => _exceptionMessage = value;
        }
        public string ExceptionType { get; set; }
        public bool Fatal { get; set; }
        public string FuncName { get; set; }
        public int GroupingID { get; set; }
        public string HardSerial { get; set; }
        public long LKSerial { get; set; }
        public int RefrencedID { get; set; }
        public string ScreenShot { get; set; }
        public ENSource Source { get; set; }
        public string StackTrace
        {
            get
            {
                if (string.IsNullOrEmpty(_stackTrace)) return "";
                _stackTrace = _stackTrace.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n");
                _stackTrace = _stackTrace.Replace(" at ", "\r\nat ");
                return _stackTrace;
            }
            set => _stackTrace = value;
        }
        public string FlowStackTrace
        {
            get
            {
                if (string.IsNullOrEmpty(_flowStackTrace)) return "";
                _flowStackTrace = _flowStackTrace.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n");
                _flowStackTrace = _flowStackTrace.Replace(" at ", "\r\nat ");
                return _flowStackTrace;
            }
            set => _flowStackTrace = value;
        }
        public string Time { get; set; }
        public string Version { get; set; }
        public string Ip { get; set; }
        public string Path { get; set; }
        public string LoggerVersion { get; set; }
        public string DateSh => Calendar.MiladiToShamsi(Date);

        private string _stackTrace = "";
        private string _description = "";
        private string _exceptionMessage = "";
        private static int _minutes = 30;
        private string _flowStackTrace = "";
        [JsonIgnore]
        public static int MinMinutsBetweenExeptions = 1;
        public short MaxCountPerTime { get; set; } = 5;
        public WebErrorLog() { }
        public static void SetMinute(int minute)
        {
            if (minute < 0) minute = 30;
            _minutes = minute;
        }
        [JsonIgnore]
        private static ConcurrentDictionary<string, DateTime> LastErrors { get; set; } =
            new ConcurrentDictionary<string, DateTime>();
        private static DateTime LastExeption = DateTime.Now.AddSeconds(-10000);
        private int CollectedErrors = 0;

        private class NestedCallInfo
        {
            internal static WebErrorLog _instence = new WebErrorLog();

            public NestedCallInfo()
            {
            }
        }

        public static WebErrorLog ErrorInstence => NestedCallInfo._instence;


        public void ThreadExceptionLog(object sender, ThreadExceptionEventArgs args)
        {
            try
            {
                if (args.Exception != null)
                    Console.WriteLine($"Thread exception: {args.Exception.Message}");

                var st = new StackTrace();
                var sf = st.GetFrame(0);
                var className = sf.GetMethod().ReflectedType.Name;
                if (string.IsNullOrEmpty(className))
                    className = sf.GetMethod().DeclaringType.Name;

                var functionName = sf.GetMethod().Name;
                var x = sf.GetFileName();
                if (string.IsNullOrEmpty(x)) x = "";
                var errorLog = new WebErrorLog
                {
                    Time = DateTime.Now.TimeOfDay.ToString(),
                    Path = AppDomain.CurrentDomain.BaseDirectory,
                    Guid = Guid.NewGuid(),
                    ExceptionType = "ThreadException",
                    StackTrace = st.ToString(),
                    ClassName = className,
                    FuncName = functionName
                };
                var errorname = errorLog.ClassName + errorLog.FuncName + st.GetHashCode();
                var errorexist = LastErrors.TryGetValue(errorname, out var lasttime);
                if (errorexist && (DateTime.Now - lasttime).TotalMinutes < _minutes)
                {
                    Debug.WriteLine("Lasterror cant get value in UnhandledExceptionEventArgs");
                    return;
                }
                if (errorexist)
                    LastErrors.TryRemove(errorname, out DateTime x1);
                LastErrors.TryAdd(errorname, DateTime.Now);
            }
            catch (Exception ex2)
            {
                InternalLogger.logException(ex2);
            }
        }
        public void UnhandledExceptionLog(object sender, UnhandledExceptionEventArgs ex)
        {
            try
            {
                var st = new StackTrace();
                StackFrame sf = null;
                if (st.FrameCount > 1) sf = st.GetFrame(1);
                var errorLog = new WebErrorLog
                {
                    Time = DateTime.Now.TimeOfDay.ToString(),
                    Path = AppDomain.CurrentDomain.BaseDirectory,
                    Guid = Guid.NewGuid(),
                    StackTrace = st.ToString(),
                    ExceptionType = "UnhandledException",
                    ClassName = "Is Unhandled Exception CantGet File Name",
                    FuncName = sf?.GetMethod().Name
                };
                var errorname = errorLog.ClassName + errorLog.FuncName;
                var errorexist = LastErrors.TryGetValue(errorname, out var lasttime);
                if (errorexist && (DateTime.Now - lasttime).TotalMinutes < _minutes)
                {
                    Debug.WriteLine("Lasterror cant get value in UnhandledExceptionEventArgs");
                    return;
                }
                if (errorexist)
                    LastErrors.TryRemove(errorname, out var x);
                LastErrors.TryAdd(errorname, DateTime.Now);
            }
            catch (Exception ex2)
            {
                InternalLogger.logException(ex2);
            }
        }


        public void StartErrorLog(string ex, string description = "",
            [System.Runtime.CompilerServices.CallerMemberName]
            string memberName = "",
            [System.Runtime.CompilerServices.CallerFilePath]
            string sourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber]
            int sourceLineNumber = 0) => StartErrorLog(new Exception(ex), description, memberName, sourceFilePath,
            sourceLineNumber);



        public void StartErrorLog(Exception ex, string description = "",
            [System.Runtime.CompilerServices.CallerMemberName]
            string memberName = "",
            [System.Runtime.CompilerServices.CallerFilePath]
            string sourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber]
            int sourceLineNumber = 0)
        {
            try
            {
                var exceptionMessage = $"{ex.Message}//InnerException:{ex?.InnerException?.Message ?? ""}//InnerInnerException:{ex?.InnerException?.InnerException?.Message ?? ""}";
                var stackTrace = ex.StackTrace;

                if (string.IsNullOrEmpty(sourceFilePath) || string.IsNullOrEmpty(memberName))
                {
                    var mth = new StackTrace().GetFrame(1).GetMethod();
                    if (string.IsNullOrEmpty(memberName))
                        memberName = "{Reflection}_" + mth.Name;
                    if (string.IsNullOrEmpty(sourceFilePath))
                        sourceFilePath = "{Reflection}_" + mth.ReflectedType.Name;
                }

                Console.WriteLine(
                    $"Exception MemberName:{memberName}\r\n//sourceFilePath:{sourceFilePath}\r\nExceptionType:{ex.GetType()}");
                if (DateTime.Now.Subtract(LastExeption).TotalMinutes > MinMinutsBetweenExeptions)
                {
                    LastExeption = DateTime.Now;
                    CollectedErrors = 0;
                }
                if (DateTime.Now.Subtract(LastExeption).TotalMinutes <= MinMinutsBetweenExeptions &&
                    CollectedErrors >= MaxCountPerTime)
                    return;
                CollectedErrors++;
                FileInfo fileInfo = null;
                if (!string.IsNullOrEmpty(sourceFilePath) && File.Exists(sourceFilePath))
                    fileInfo = new FileInfo(sourceFilePath);
                var errorname = fileInfo?.Name ?? "" + memberName + sourceLineNumber + ex.Message;
                var errorexist = LastErrors.TryGetValue(errorname, out DateTime lasttime);
                if (errorexist && (DateTime.Now - lasttime).TotalMinutes < _minutes)
                    return;
                if (errorexist)
                    LastErrors.TryRemove(errorname, out DateTime x);
                LastErrors.TryAdd(errorname, DateTime.Now);
                var st = new StackTrace();
                var errorLog = new WebErrorLog
                {
                    ClassName = fileInfo?.Name ?? "",
                    FuncName = memberName,
                    Time = DateTime.Now.TimeOfDay.ToString(),
                    Path = AppDomain.CurrentDomain.BaseDirectory,
                    Guid = Guid.NewGuid(),
                    ExceptionType = ex.GetType().ToString(),
                    ExceptionMessage = exceptionMessage,
                    StackTrace = stackTrace,
                    Description = description,
                    FlowStackTrace = st.ToString()
                };
                if (string.IsNullOrEmpty(errorLog.ClassName))
                    errorLog.ClassName = sourceFilePath;
                try
                {
                    errorLog.ExceptionType = ex.GetType().ToString();
                }
                catch
                {
                    errorLog.ExceptionType = "exception On get Type:" + ex.Message;
                }

                while (ex.InnerException != null)
                {
                    errorLog.ExceptionMessage += "\r\n" + "_______________________\r\nType:" + ex.GetType().ToString() + "\r\n" + ex.Message;
                    ex = ex.InnerException;
                }

                errorLog.Ip = Utilities.GetNetworkIpAddress() ?? "";
                Logger.LoggerInstance.SaveLog(errorLog.ToString(), EnGroup.Exception);
                Task.Run(() => ErrorHandler.OnExceptionHandle(errorLog));
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception ex2)
            {
                InternalLogger.logException(ex2);
            }
        }

        public override string ToString() => Json.ToStringJson(this);
    }
}
