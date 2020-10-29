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
        [PersianNameAttribute.PersianName("فعال کردن پرداخت")]
        public bool? Pardakht_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست پرداخت")]
        public bool? Pardakht_ShowForm { get; set; } = true;
    }
}
