namespace Services.Access
{
    public class SanadAccess
    {
        [PersianNameAttribute.PersianName("افزودن سند حسابداری")]
        public bool? Sanad_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده ترازنامه")]
        public bool? Sanad_Taraz { get; set; } = true;
    }
}
