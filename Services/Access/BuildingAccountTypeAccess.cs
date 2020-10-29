namespace Services.Access
{
    public class BuildingAccountTypeAccess
    {
        [PersianNameAttribute.PersianName("افزودن نوع کاربری جدید")]
        public bool? Building_Acc_Type_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش نوع کاربری")]
        public bool? Building_Acc_Type_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف نوع کاربری")]
        public bool? Building_Acc_Type_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده نوع کاربری")]
        public bool? Building_Acc_Type_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن نوع کاربری")]
        public bool? Building_Acc_Type_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست نوع کاربری")]
        public bool? Building_Acc_Type_ShowForm { get; set; } = true;
    }
}
