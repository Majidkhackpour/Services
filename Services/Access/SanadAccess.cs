namespace Services.Access
{
    public class SanadAccess
    {
        [PersianNameAttribute.PersianName("افزودن سند حسابداری")]
        public bool? Sanad_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش سند حسابداری")]
        public bool? Sanad_Edit { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده سند حسابداری")]
        public bool? Sanad_View { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف سند حسابداری")]
        public bool? Sanad_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("چاپ سند حسابداری")]
        public bool? Sanad_Print { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده ترازنامه")]
        public bool? Sanad_Taraz { get; set; } = true;
    }
}
