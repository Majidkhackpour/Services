using System.ComponentModel;

namespace Services.Access
{
    public class PeopleAccess
    {
        [PersianNameAttribute.PersianName("افزودن شخص جدید")]
        public bool? People_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش اشخاص")]
        public bool? People_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف اشخاص")]
        public bool? People_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده اشخاص")]
        public bool? People_View { get; set; } = true;
        [PersianNameAttribute.PersianName("فعال کردن اشخاص")]
        public bool? People_Disable { get; set; } = true;
        [PersianNameAttribute.PersianName("نمایش صفحه لیست اشخاص")]
        public bool? People_ShowForm { get; set; } = true;
        [PersianNameAttribute.PersianName("افزودن گروه اشخاص جدید")]
        public bool? People_Group_Insert { get; set; } = true;
        [PersianNameAttribute.PersianName("ویرایش گروه اشخاص")]
        public bool? People_Group_Update { get; set; } = true;
        [PersianNameAttribute.PersianName("حذف گروه اشخاص")]
        public bool? People_Group_Delete { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده اطلاعات تماس اشخاص")]
        public bool? People_Show_Tell { get; set; } = true;
        [PersianNameAttribute.PersianName("مشاهده اطلاعات حساب های بانکی اشخاص")]
        public bool? People_Show_BankHesab { get; set; } = true;
        [PersianNameAttribute.PersianName("ارسال پیامک به اشخاص")]
        public bool? People_SendSms { get; set; } = true;
        [PersianNameAttribute.PersianName("افزودن اشخاص از فایل اکسل")]
        public bool? People_Import_Excel { get; set; } = true;
        [PersianNameAttribute.PersianName("چاپ لیست اشخاص")]
        public bool? People_Print { get; set; } = true;
    }
}
