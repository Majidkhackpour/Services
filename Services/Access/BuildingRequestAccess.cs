namespace Services.Access
{
    public class BuildingRequestAccess
    {
        [PersianNameAttribute.PersianName("افزودن تقاضا جدید")]
        public bool? Building_Request_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش تقاضا")]
        public bool? Building_Request_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف تقاضا")]
        public bool? Building_Request_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده تقاضا")]
        public bool? Building_Request_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن تقاضا")]
        public bool? Building_Request_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست تقاضا")]
        public bool? Building_Request_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("ارسال پیامک به متقاضی")]
        public bool? Building_Request_Send_Sms { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش فایل های مطابق با تقاضا")]
        public bool? Building_Request_ShowMatches { get; set; } = true;
        [PersianNameAttribute.PersianName("چاپ لیست تقاضاها")]
        public bool? Building_Request_Print { get; set; } = true;
    }
}
