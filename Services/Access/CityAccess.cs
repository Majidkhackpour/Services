namespace Services.Access
{
    public class CityAccess
    {
        [PersianNameAttribute.PersianName("افزودن شهر جدید")]
        public bool? City_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش شهر")]
        public bool? City_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف شهر")]
        public bool? City_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده شهر")]
        public bool? City_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن شهر")]
        public bool? City_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست شهر")]
        public bool? City_ShowForm { get; set; } = true;
    }
}
