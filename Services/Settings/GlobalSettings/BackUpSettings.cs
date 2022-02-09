namespace Services.Settings.GlobalSettings
{
    public class BackUpSettings
    {
        public string BackUpPath { get; set; }
        public int BackUpDuration { get; set; }
        public bool IsAutoBackUp { get; set; }
        public bool BackUpOpen { get; set; }
        public bool BackUpSms { get; set; }
    }
}
