namespace Services.Access
{
    public class FloorCoverAccess
    {
        [PersianNameAttribute.PersianName("افزودن کفپوش جدید")]
        public bool? Floor_Cover_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش کفپوش")]
        public bool? Floor_Cover_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف کفپوش")]
        public bool? Floor_Cover_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده کفپوش")]
        public bool? Floor_Cover_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن کفپوش")]
        public bool? Floor_Cover_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست کفپوش")]
        public bool? Floor_Cover_ShowForm { get; set; } = true;
    }
}
