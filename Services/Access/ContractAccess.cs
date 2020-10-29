namespace Services.Access
{
    public class ContractAccess
    {
        [PersianNameAttribute.PersianName("افزودن قولنامه جدید")]
        public bool? Contract_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش قولنامه")]
        public bool? Contract_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف قولنامه")]
        public bool? Contract_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده قولنامه")]
        public bool? Contract_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن قولنامه")]
        public bool? Contract_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست قولنامه")]
        public bool? Contract_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("نهایی کردن قولنامه")]
        public bool? Contract_Finish { get; set; } = true;
        [PersianNameAttribute.PersianName("چاپ قولنامه ها")]
        public bool? Contract_Print { get; set; } = true;
    }
}
