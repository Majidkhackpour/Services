namespace Services.Access
{
    public class DasteCheckAccess
    {
        [PersianNameAttribute.PersianName("افزودن دسته چک جدید")]
        public bool? DasteCheck_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش دسته چک")]
        public bool? DasteCheck_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف دسته چک")]
        public bool? DasteCheck_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده دسته چک")]
        public bool? DasteCheck_View { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده برگه چک ها")]
        public bool? DasteCheck_ShowPages { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست حساب های بانکی")]
        public bool? DasteCheck_ShowForm { get; set; } = true;
    }
}
