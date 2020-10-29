namespace Services.Access
{
    public class BuildingConditionAccess
    {
        [PersianNameAttribute.PersianName("افزودن نوع بنا جدید")]
        public bool? Building_Condition_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش نوع بنا")]
        public bool? Building_Condition_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف نوع بنا")]
        public bool? Building_Condition_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده نوع بنا")]
        public bool? Building_Condition_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن نوع بنا")]
        public bool? Building_Condition_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست نوع بنا")]
        public bool? Building_Condition_ShowForm { get; set; } = true;
    }
}
