namespace Services.Access
{
    public class PardakhtAccess
    {
        [PersianNameAttribute.PersianName("افزودن پرداخت جدید")]
        public bool? Pardakht_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش پرداخت")]
        public bool? Pardakht_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف پرداخت")]
        public bool? Pardakht_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده پرداخت")]
        public bool? Pardakht_View { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست پرداخت")]
        public bool? Pardakht_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("چاپ برگه پرداخت")]
        public bool? Pardakht_PrintOne { get; set; } = true;
        [PersianNameAttribute.PersianName("چاپ لیست پرداخت")]
        public bool? Pardakht_PrintList { get; set; } = true;
        [PersianNameAttribute.PersianName("افزودن پرداخت نقدی")]
        public bool? Pardakht_InsertNaqd { get; set; } = true;
        [PersianNameAttribute.PersianName("افزودن پرداخت حواله")]
        public bool? Pardakht_InsertHavale { get; set; } = true;
        [PersianNameAttribute.PersianName("افزودن پرداخت چک دریافت شده از مشتری")]
        public bool? Pardakht_InsertCheckM { get; set; } = true;
        [PersianNameAttribute.PersianName("افزودن پرداخت چک شخصی")]
        public bool? Pardakht_InsertCheckSh { get; set; } = true;
    }
}
