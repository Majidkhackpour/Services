namespace Services.Access
{
    public class UserAccess
    {
        [PersianNameAttribute.PersianName("افزودن کاربر جدید")]
        public bool? User_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش کاربر")]
        public bool? User_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف کاربر")]
        public bool? User_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده کاربر")]
        public bool? User_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن کاربر")]
        public bool? User_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست کاربر")]
        public bool? User_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش گردش حساب کاربر")]
        public bool? User_Gardesh { get; set; } = true;
    }
}
