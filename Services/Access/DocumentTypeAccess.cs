namespace Services.Access
{
    public class DocumentTypeAccess
    {
        [PersianNameAttribute.PersianName("افزودن نوع سند جدید")]
        public bool? Document_Type_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش نوع سند")]
        public bool? Document_Type_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف نوع سند")]
        public bool? Document_Type_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده نوع سند")]
        public bool? Document_Type_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن نوع سند")]
        public bool? Document_Type_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست نوع سند")]
        public bool? Document_Type_ShowForm { get; set; } = true;
    }
}
