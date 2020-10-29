namespace Services.Access
{
    public class BuildingSearchAccess
    {
        [PersianNameAttribute.PersianName("دریافت فایل از سایت")]
        public bool? Building_Search_Site { get; set; } = true;
        [PersianNameAttribute.PersianName("دریافت فایل از دیوار")]
        public bool? Building_Search_Divar { get; set; } = true;
        [PersianNameAttribute.PersianName("دریافت فایل از شیپور")]
        public bool? Building_Search_Sheypoor { get; set; } = true;
        [PersianNameAttribute.PersianName("دریافت فایل از سیستم")]
        public bool? Building_Search_System { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش فرم جستجوی پیشرفته")]
        public bool? Building_Search_ShowForm { get; set; } = true;
    }
}
