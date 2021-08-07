namespace Services.Access
{
    public class BankAccess
    {
        [PersianNameAttribute.PersianName("افزودن حساب بانکی جدید")]
        public bool? Bank_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش حساب بانکی")]
        public bool? Bank_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف حساب بانکی")]
        public bool? Bank_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده حساب بانکی")]
        public bool? Bank_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن حساب بانکی")]
        public bool? Bank_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست حساب های بانکی")]
        public bool? Bank_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش گردش حساب")]
        public bool? Bank_ShowGardesh { get; set; } = true;
    }
}
