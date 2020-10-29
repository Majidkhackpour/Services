namespace Services.Access
{
    public class ReceptionAccess
    {
        [PersianNameAttribute.PersianName("افزودن دریافت جدید")]
        public bool? Reception_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش دریافت")]
        public bool? Reception_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف دریافت")]
        public bool? Reception_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده دریافت")]
        public bool? Reception_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن دریافت")]
        public bool? Reception_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست دریافت")]
        public bool? Reception_ShowForm { get; set; } = true;
    }
}
