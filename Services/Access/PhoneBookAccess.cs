namespace Services.Access
{
    public class PhoneBookAccess
    {
        [PersianNameAttribute.PersianName("افزودن مخاطب جدید")]
        public bool? PhoneBook_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش مخاطب")]
        public bool? PhoneBook_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف مخاطب")]
        public bool? PhoneBook_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده مخاطب")]
        public bool? PhoneBook_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن مخاطب")]
        public bool? PhoneBook_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست مخاطبین")]
        public bool? PhoneBook_ShowForm { get; set; } = true;
    }
}
