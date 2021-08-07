namespace Services.Access
{
    public class CheckMAccess
    {
        [PersianNameAttribute.PersianName("افزودن چک دریافتی جدید")]
        public bool? CheckM_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("افزودن چک دریافتی اول دوره")]
        public bool? CheckM_InsertAvalDore { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش چک دریافتی")]
        public bool? CheckM_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده چک دریافتی")]
        public bool? CheckM_View { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست چک دیافتی")]
        public bool? CheckM_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("خرج کردن")]
        public bool? CheckM_Kharh { get; set; } = true;
        [PersianNameAttribute.PersianName("واگذار به صندوق")]
        public bool? CheckM_SandouqVagozar { get; set; } = true;
        [PersianNameAttribute.PersianName("واگذار به بانک")]
        public bool? CheckM_BankVagozar { get; set; } = true;
        [PersianNameAttribute.PersianName("برگشت زدن")]
        public bool? CheckM_Bargasht { get; set; } = true;
        [PersianNameAttribute.PersianName("نقد کردن")]
        public bool? CheckM_Naqd { get; set; } = true;
        [PersianNameAttribute.PersianName("باطل کردن")]
        public bool? CheckM_Ebtal { get; set; } = true;
    }
}
