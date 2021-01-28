using System;

namespace Services
{
    public interface IErrorHandler
    {
        Guid Guid { get; set; }
        DateTime Modified { get; set; }
        string AndroidIme { get; set; }
        string ClassName { get; set; }
        string CpuSerial { get; set; }
        DateTime Date { get; set; }
        string Description { get; set; }
        string ExceptionError { get; set; }
        string ExceptionMessage { get; set; }
        string ExceptionType { get; set; }
        bool Fatal { get; set; }
        string FuncName { get; set; }
        int GroupingID { get; set; }
        string HardSerial { get; set; }
        long LKSerial { get; set; }
        int RefrencedID { get; set; }
        string ScreenShot { get; set; }
        ENSource Source { get; set; }
        string StackTrace { get; set; }
        string FlowStackTrace { get; set; }
        string Time { get; set; }
        string Version { get; set; }
        string Ip { get; set; }
        string Path { get; set; }
        string LoggerVersion { get; set; }
        void StartErrorLog(Exception ex, string description = "", string memberName = "", string sourceFilePath = "",
            int sourceLineNumber = 0);
    }
}
