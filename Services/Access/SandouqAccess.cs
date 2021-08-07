namespace Services.Access
{
    public class SandouqAccess
    {
        [PersianNameAttribute.PersianName("افزودن صندوق جدید")]
        public bool? Sandouq_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش صندوق")]
        public bool? Sandouq_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف صندوق")]
        public bool? Sandouq_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده صندوق")]
        public bool? Sandouq_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن صندوق")]
        public bool? Sandouq_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست صندوق ها")]
        public bool? Sandouq_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش گردش حساب")]
        public bool? Sandouq_ShowGardesh { get; set; } = true;
    }
}
