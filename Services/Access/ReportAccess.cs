namespace Services.Access
{
    public class ReportAccess
    {
        [PersianNameAttribute.PersianName("گزارش عملکرد کاربران")]
        public bool? Reports_User_Performence { get; set; } = true;
        [PersianNameAttribute.PersianName("ارسال لیست اشخاص به فایل اکسل")]
        public bool? Reports_Export_People_Excel { get; set; } = true;
    }
}
