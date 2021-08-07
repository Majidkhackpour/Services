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
        [PersianNameAttribute.PersianName("نمایش صفحه لیست دریافت")]
        public bool? Reception_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("چاپ برگه دریافت")]
        public bool? Reception_PrintOne { get; set; } = true;
        [PersianNameAttribute.PersianName("چاپ لیست دریافت")]
        public bool? Reception_PrintList { get; set; } = true;
        [PersianNameAttribute.PersianName("افزودن دریافت نقدی")]
        public bool? Reception_InsertNaqd { get; set; } = true;
        [PersianNameAttribute.PersianName("افزودن دریافت حواله")]
        public bool? Reception_InsertHavale { get; set; } = true;
        [PersianNameAttribute.PersianName("افزودن دریافت چک ")]
        public bool? Reception_InsertCheck { get; set; } = true;
    }
}
