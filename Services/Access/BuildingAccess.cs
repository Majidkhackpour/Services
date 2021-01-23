namespace Services.Access
{
    public class BuildingAccess
    {
        [PersianNameAttribute.PersianName("افزودن ملک جدید")]
        public bool? Building_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش ملک")]
        public bool? Building_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف ملک")]
        public bool? Building_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده ملک")]
        public bool? Building_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن ملک")]
        public bool? Building_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست ملک")]
        public bool? Building_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("ارسال پیامک به مالک")]
        public bool? Building_Send_Sms { get; set; } = true;
        [PersianNameAttribute.PersianName("ارسال ملک به دیوار")]
        public bool? Building_Send_Divar { get; set; } = true;
        [PersianNameAttribute.PersianName("ارسال ملک به شیپور")]
        public bool? Building_Send_Sheypoor { get; set; } = true;
        [PersianNameAttribute.PersianName("ارسال ملک به تلگرام")]
        public bool? Building_Send_Telegram { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش تقاضاهای مطابق با ملک")]
        public bool? Building_Show_request { get; set; } = true;
        [PersianNameAttribute.PersianName("چاپ املاک")]
        public bool? Building_Print { get; set; } = true;
    }
}
