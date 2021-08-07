namespace Services.Access
{
    public class AdvisorAccess
    {
        [PersianNameAttribute.PersianName("افزودن مشاور جدید")]
        public bool? Advisor_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش مشاور")]
        public bool? Advisor_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف مشاور")]
        public bool? Advisor_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده مشاور")]
        public bool? Advisor_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن مشاور")]
        public bool? Advisor_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست مشاوران")]
        public bool? Advisor_ShowForm { get; set; } = true;
    }
}
