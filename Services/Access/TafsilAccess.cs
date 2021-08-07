namespace Services.Access
{
    public class TafsilAccess
    {
        [PersianNameAttribute.PersianName("افزودن حساب تفصیلی جدید")]
        public bool? Tafsil_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش حساب تفصیلی")]
        public bool? Tafsil_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف حساب تفصیلی")]
        public bool? Tafsil_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده حساب تفصیلی")]
        public bool? Tafsil_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن حساب تفصیلی")]
        public bool? Tafsil_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست حساب تفصیلی")]
        public bool? Tafsil_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش گردش حساب حساب تفصیلی")]
        public bool? Tafsil_Gardesh { get; set; } = true;
    }
}
