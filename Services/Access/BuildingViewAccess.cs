namespace Services.Access
{
    public class BuildingViewAccess
    {
        [PersianNameAttribute.PersianName("افزودن نمای ساختمان جدید")]
        public bool? Building_View_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش نمای ساختمان")]
        public bool? Building_View_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف نمای ساختمان")]
        public bool? Building_View_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده نمای ساختمان")]
        public bool? Building_View_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن نمای ساختمان")]
        public bool? Building_View_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست نمای ساختمان")]
        public bool? Building_View_ShowForm { get; set; } = true;
    }
}
