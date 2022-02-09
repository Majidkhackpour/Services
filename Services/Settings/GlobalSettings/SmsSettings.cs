using System;

namespace Services.Settings.GlobalSettings
{
    public class SmsSettings
    {
        public Guid DefaultPanelGuid { get; set; }
        public bool IsSendToOwner { get; set; }
        public string OwnerText { get; set; }
        public bool IsSendToSayer { get; set; }
        public string SayerText { get; set; }
        public bool IsSendAfterMatch { get; set; }
        public string SendMatchTextRahn { get; set; }
        public string SendMatchTextKharid { get; set; }
    }
}
