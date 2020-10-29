namespace Services.Access
{
    public class RegionAccess
    {
        [PersianNameAttribute.PersianName("افزودن منطقه جدید")]
        public bool? Region_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش منطقه")]
        public bool? Region_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف منطقه")]
        public bool? Region_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده منطقه")]
        public bool? Region_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن منطقه")]
        public bool? Region_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست مناطق")]
        public bool? Region_ShowForm { get; set; } = true;
    }
}
