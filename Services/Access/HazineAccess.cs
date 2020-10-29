namespace Services.Access
{
    public class HazineAccess
    {
        [PersianNameAttribute.PersianName("افزودن هزینه جدید")]
        public bool? Hazine_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش هزینه")]
        public bool? Hazine_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف هزینه")]
        public bool? Hazine_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده هزینه")]
        public bool? Hazine_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن هزینه")]
        public bool? Hazine_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست هزینه")]
        public bool? Hazine_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش گردش حساب هزینه")]
        public bool? Hazine_Gardesh { get; set; } = true;
    }
}
