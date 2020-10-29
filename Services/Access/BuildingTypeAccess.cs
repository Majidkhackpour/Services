namespace Services.Access
{
    public class BuildingTypeAccess
    {
        [PersianNameAttribute.PersianName("افزودن نوع ملک جدید")]
        public bool? Building_Type_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش نوع ملک")]
        public bool? Building_Type_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف نوع ملک")]
        public bool? Building_Type_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده نوع ملک")]
        public bool? Building_Type_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن نوع ملک")]
        public bool? Building_Type_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست نوع ملک")]
        public bool? Building_Type_ShowForm { get; set; } = true;
    }
}
