using System;

namespace Services.Settings
{
    public class AdvertiseSetting
    {
        public static string Key = "AdvertiseSettings";
        public string Sender { get; set; }
        public bool IsGiveChat { get; set; }
        public int Divar_DayCountForUpdateState { get; set; }
        public int Divar_PicCountInPerAdv { get; set; } = 5;
        public int Divar_AdvCountInDay { get; set; } = 3;
        public int Divar_AdvCountInMounth { get; set; } = 5;
        public int Sheypoor_DayCountForUpdateState { get; set; }
        public int Sheypoor_PicCountInPerAdv { get; set; } = 10;
        public int Sheypoor_AdvCountInDay { get; set; } = 5;
        public int Sheypoor_AdvCountInMounth { get; set; } = 30;
        public bool IsSilent { get; set; }
        public int MaxFileCount { get; set; } = 50;
        public bool IsGiveFile { get; set; }
        public DateTime? GetFileDate { get; set; }
    }
}
