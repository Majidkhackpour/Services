namespace Services.Access
{
    public class SimcardAccess
    {
        [PersianNameAttribute.PersianName("افزودن سیمکارت جدید")]
        public bool? Simcard_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش سیمکارت")]
        public bool? Simcard_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف سیمکارت")]
        public bool? Simcard_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده سیمکارت")]
        public bool? Simcard_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن سیمکارت")]
        public bool? Simcard_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست سیمکارت")]
        public bool? Simcard_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("توکن دیوار")]
        public bool? Simcard_Divar_Token { get; set; } = true;
        [PersianNameAttribute.PersianName("توکن شیپور")]
        public bool? Simcard_Shepoor_Token { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف توکن ها")]
        public bool? Simcard_Delete_Token { get; set; } = true;
        [PersianNameAttribute.PersianName("ارسال آگهی")]
        public bool? Simcard_Send_Adv { get; set; } = true;
    }
}
