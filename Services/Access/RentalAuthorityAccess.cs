namespace Services.Access
{
    public class RentalAuthorityAccess
    {
        [PersianNameAttribute.PersianName("افزودن ارجحیت اجاره جدید")]
        public bool? Rental_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش ارجحیت اجاره")]
        public bool? Rental_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف ارجحیت اجاره")]
        public bool? Rental_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده ارجحیت اجاره")]
        public bool? Rental_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن ارجحیت اجاره")]
        public bool? Rental_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست ارجحیت اجاره")]
        public bool? Rental_ShowForm { get; set; } = true;
    }
}
