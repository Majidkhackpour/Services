namespace Services.Access
{
    public class CheckShAccess
    {
        [PersianNameAttribute.PersianName("افزودن چک پرداختی جدید")]
        public bool? CheckSh_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("افزودن چک پرداختی اول دوره")]
        public bool? CheckSh_InsertAvalDore { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش چک پرداختی")]
        public bool? CheckSh_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف چک پرداختی")]
        public bool? CheckSh_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده چک پرداختی")]
        public bool? CheckSh_View { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست چک دیافتی")]
        public bool? CheckSh_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("اعلام پرداخت")]
        public bool? CheckSh_Kharh { get; set; } = true;
        [PersianNameAttribute.PersianName("اعلام برگشت")]
        public bool? CheckSh_Bargasht { get; set; } = true;
        [PersianNameAttribute.PersianName("باطل کردن")]
        public bool? CheckSh_Ebtal { get; set; } = true;
    }
}
