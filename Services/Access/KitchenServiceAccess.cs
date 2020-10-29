namespace Services.Access
{
    public class KitchenServiceAccess
    {
        [PersianNameAttribute.PersianName("افزودن سرویس آشپزخانه جدید")]
        public bool? Kitchen_Service_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش سرویس آشپزخانه")]
        public bool? Kitchen_Service_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف سرویس آشپزخانه")]
        public bool? Kitchen_Service_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده سرویس آشپزخانه")]
        public bool? Kitchen_Service_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن سرویس آشپزخانه")]
        public bool? Kitchen_Service_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست سرویس آشپزخانه")]
        public bool? Kitchen_Service_ShowForm { get; set; } = true;
    }
}
