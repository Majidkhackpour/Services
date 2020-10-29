namespace Services.Access
{
    public class BuildingOptionAccess
    {
        [PersianNameAttribute.PersianName("افزودن امکان جدید")]
        public bool? Building_Option_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش امکانات")]
        public bool? Building_Option_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف امکانات")]
        public bool? Building_Option_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده امکانات")]
        public bool? Building_Option_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن امکانات")]
        public bool? Building_Option_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست امکانات")]
        public bool? Building_Option_ShowForm { get; set; } = true;
    }
}
