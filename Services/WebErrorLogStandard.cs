using System;
using System.Collections.Generic;

namespace Services
{
    public class WebErrorLogStandard
    {
        public ENSource Source { get; set; } = ENSource.None;
        public Guid DbGuid { get; set; } = Guid.Empty;
        public string CpuSerial { get; set; } = "";
        public string HardSerial { get; set; } = "";
        public long AndroidIme { get; set; } = 0;
        public long LkSerial { get; set; } = 0;
        public string Username { get; set; }
        public string Password { get; set; }
        public string Version { get; set; }

        public List<WebErrorLog> ErrorLogs { get; set; }
    }
}
