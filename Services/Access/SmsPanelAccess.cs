namespace Services.Access
{
    public class SmsPanelAccess
    {
        [PersianNameAttribute.PersianName("افزودن پنل ارسال پیامک جدید")]
        public bool? Panel_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش پنل ارسال پیامک")]
        public bool? Panel_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف پنل ارسال پیامک")]
        public bool? Panel_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده پنل ارسال پیامک")]
        public bool? Panel_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن پنل ارسال پیامک")]
        public bool? Panel_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست پنل ارسال پیامک")]
        public bool? Panel_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("تغییر پنل پیش فرض")]
        public bool? Panel_Default { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده مانده اعتبار پنل")]
        public bool? Panel_Etebar { get; set; } = true;
    }
}
