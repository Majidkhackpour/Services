using System;

namespace Services
{
    public class InternalLogger
    {

        private static DateTime _LastError = DateTime.Now.AddMinutes(-2000);

        public static void logException(Exception ex, string description = "",
            [System.Runtime.CompilerServices.CallerMemberName]
            string memberName = "",
            [System.Runtime.CompilerServices.CallerFilePath]
            string sourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber]
            int sourceLineNumber = 0)
        {
            try
            {
                if (DateTime.Now.Subtract(_LastError).TotalMinutes < 5)
                    return;
                _LastError = DateTime.Now;
                var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                if (!System.IO.Directory.Exists(path))
                    System.IO.Directory.CreateDirectory(path);
                path = System.IO.Path.Combine(path, Guid.NewGuid() + ".txt");
                System.IO.File.WriteAllText(path, ex.Message + "\r\n__________________\r\n" + ex.StackTrace);
            }
            catch (Exception e)
            {
                var msg = e.Message;
            }
        }
    }
}
