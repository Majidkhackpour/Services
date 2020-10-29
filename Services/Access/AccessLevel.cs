namespace Services.Access
{
    public class AccessLevel
    {
        [PersianNameAttribute.PersianName("اشخاص")]
        public PeopleAccess Peoples { get; set; } = new PeopleAccess();
        [PersianNameAttribute.PersianName("شهرها")]
        public CityAccess Cities { get; set; } = new CityAccess();
        [PersianNameAttribute.PersianName("مناطق")]
        public RegionAccess Regions { get; set; } = new RegionAccess();
        [PersianNameAttribute.PersianName("امکانات ملک")]
        public BuildingOptionAccess BuildingOption { get; set; } = new BuildingOptionAccess();
        [PersianNameAttribute.PersianName("نوع کاربری ملک")]
        public BuildingAccountTypeAccess BuildingAccountType { get; set; } = new BuildingAccountTypeAccess();
        [PersianNameAttribute.PersianName("کفپوش")]
        public FloorCoverAccess FloorCover { get; set; } = new FloorCoverAccess();
        [PersianNameAttribute.PersianName("سرویس آشپزخانه")]
        public KitchenServiceAccess KitchenService { get; set; } = new KitchenServiceAccess();
        [PersianNameAttribute.PersianName("انواع سند")]
        public DocumentTypeAccess DocumentType { get; set; } = new DocumentTypeAccess();
        [PersianNameAttribute.PersianName("ارجحیت اجاره")]
        public RentalAuthorityAccess RentalAuthority { get; set; } = new RentalAuthorityAccess();
        [PersianNameAttribute.PersianName("نمای ساختمان")]
        public BuildingViewAccess BuildingView { get; set; } = new BuildingViewAccess();
        [PersianNameAttribute.PersianName("نوع بنا")]
        public BuildingConditionAccess BuildingCondition { get; set; } = new BuildingConditionAccess();
        [PersianNameAttribute.PersianName("نوع ملک")]
        public BuildingTypeAccess BuildingType { get; set; } = new BuildingTypeAccess();
        [PersianNameAttribute.PersianName("املاک")]
        public BuildingAccess Building { get; set; } = new BuildingAccess();
        [PersianNameAttribute.PersianName("جستجوی پیشرفته املاک")]
        public BuildingSearchAccess BuildingSearch { get; set; } = new BuildingSearchAccess();
        [PersianNameAttribute.PersianName("تقاضا")]
        public BuildingRequestAccess BuildingRequest { get; set; } = new BuildingRequestAccess();
        [PersianNameAttribute.PersianName("قولنامه")]
        public ContractAccess Contract { get; set; } = new ContractAccess();
        [PersianNameAttribute.PersianName("کاربران")]
        public UserAccess User { get; set; } = new UserAccess();
        [PersianNameAttribute.PersianName("سطوح دسترسی کاربران")]
        public UserAccLevelAccess UserAccLevel { get; set; } = new UserAccLevelAccess();
        [PersianNameAttribute.PersianName("هزینه ها")]
        public HazineAccess Hazine { get; set; } = new HazineAccess();
        [PersianNameAttribute.PersianName("عملکرد حساب")]
        public AccountPerformenceAccess AccountPerformence { get; set; } = new AccountPerformenceAccess();
        [PersianNameAttribute.PersianName("دریافت")]
        public ReceptionAccess Reception { get; set; } = new ReceptionAccess();
        [PersianNameAttribute.PersianName("پرداخت")]
        public PardakhtAccess Pardakht { get; set; } = new PardakhtAccess();
        [PersianNameAttribute.PersianName("سند حسابداری")]
        public SanadAccess Sanad { get; set; } = new SanadAccess();
        [PersianNameAttribute.PersianName("دفترچه تلفن")]
        public PhoneBookAccess PhoneBook { get; set; } = new PhoneBookAccess();
        [PersianNameAttribute.PersianName("پنل ارسال پیامک")]
        public SmsPanelAccess SmsPanel { get; set; } = new SmsPanelAccess();
        [PersianNameAttribute.PersianName("ارسال پیامک")]
        public SendSmsAccess SendSms { get; set; } = new SendSmsAccess();
        [PersianNameAttribute.PersianName("سیمکارت ها")]
        public SimcardAccess Simcard { get; set; } = new SimcardAccess();
        [PersianNameAttribute.PersianName("گزارشات")]
        public ReportAccess Report { get; set; } = new ReportAccess();
    }
}
