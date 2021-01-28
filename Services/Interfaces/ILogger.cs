using System;

namespace Services.Interfaces
{
    public interface ILogger
    {
        void SaveLog(string message, EnGroup group = EnGroup.None, DateTime? date = null, short trycount = 10, [System.Runtime.CompilerServices.CallerMemberName]
            string memberName = "",
    [System.Runtime.CompilerServices.CallerFilePath]
            string sourceFilePath = "",
    [System.Runtime.CompilerServices.CallerLineNumber]
            int sourceLineNumber = 0);
    }
}
