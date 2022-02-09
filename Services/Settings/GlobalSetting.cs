using Services.Settings.GlobalSettings;

namespace Services.Settings
{
    public class GlobalSetting
    {
        public static string Key = "GlobalSettings";
        public BackUpSettings BackUp { get; set; } = new BackUpSettings();
        public CompanyInfo CompanyInfo { get; set; } = new CompanyInfo();
        public Global Global { get; set; } = new Global();
        public PrintSetting Print { get; set; } = new PrintSetting();
        public SafeBoxSettings SafeBox { get; set; } = new SafeBoxSettings();
        public TelegramSettings Telegram { get; set; } = new TelegramSettings();
        public WhatsappSettings Whatsapp { get; set; } = new WhatsappSettings();
        public SmsSettings Sms { get; set; } = new SmsSettings();
    }
}
