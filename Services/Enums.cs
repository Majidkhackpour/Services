using System;

namespace Services
{
    public enum EnPartDate
    {
        [PersianNameAttribute.PersianName("سال")] Year = 1,
        [PersianNameAttribute.PersianName("ماه")] Mounth = 2,
        [PersianNameAttribute.PersianName("روز")] Day = 3
    }
    public enum ButtonType
    {
        None = 0,
        AcceptButton = 1,
        CancelButton = 2
    }
    public enum EnForms
    {
        [PersianNameAttribute.PersianName("مدیریت اشخاص")] Peoples = 1,
        [PersianNameAttribute.PersianName("مدیریت شهرها")] Cities = 2,
        [PersianNameAttribute.PersianName("مدیریت مناطق")] Regions = 3,
        [PersianNameAttribute.PersianName("امکانات املاک")] BuildingOptions = 4,
        [PersianNameAttribute.PersianName("نوع کاربری ملک")] BuildingAccountType = 5,
        [PersianNameAttribute.PersianName("کفپوش")] FloorCover = 6,
        [PersianNameAttribute.PersianName("سرویس آشپزخانه")] KitchenService = 7,
        [PersianNameAttribute.PersianName("انواع سند")] DocumentType = 8,
        [PersianNameAttribute.PersianName("ارجحیت اجاره")] RentalAouthority = 9,
        [PersianNameAttribute.PersianName("نمای ساختمان")] BuildingView = 10,
        [PersianNameAttribute.PersianName("نوع بنا")] BuildingCondition = 11,
        [PersianNameAttribute.PersianName("نوع ملک")] BuildingType = 12,
        [PersianNameAttribute.PersianName("مدیریت املاک")] Building = 13,
        [PersianNameAttribute.PersianName("ثبت سریع ملک")] BuildingFast = 14,
        [PersianNameAttribute.PersianName("جستجوی پیشرفته ملک")] AdvancedSearch = 15,
        [PersianNameAttribute.PersianName("بایگانی املاک")] BuildingArchive = 16,
        [PersianNameAttribute.PersianName("تطبیق ملک و درخواست")] BuildingMatch = 17,
        [PersianNameAttribute.PersianName("مدیریت قراردادها")] Contract = 18,
        [PersianNameAttribute.PersianName("مدیریت درخواست ها")] Request = 19,
        [PersianNameAttribute.PersianName("مدیریت کاربران")] Users = 20,
        [PersianNameAttribute.PersianName("سطوح دسترسی")] UserAccess = 21,
        [PersianNameAttribute.PersianName("مدیریت مشاوران")] Advisor = 22,
        [PersianNameAttribute.PersianName("هزینه ها")] Hazine = 23,
        [PersianNameAttribute.PersianName("دریافت")] Daryaft = 24,
        [PersianNameAttribute.PersianName("پرداخت")] Pardakht = 25,
        [PersianNameAttribute.PersianName("اسناد")] Sanad = 26,
        [PersianNameAttribute.PersianName("گزارشات حسابداری")] AccountingReport = 27,
        [PersianNameAttribute.PersianName("حساب های کل و معین")] KolMoein = 28,
        [PersianNameAttribute.PersianName("حساب های تفصیلی")] Tafsil = 29,
        [PersianNameAttribute.PersianName("مدیریت صندوق ها")] Sandouq = 30,
        [PersianNameAttribute.PersianName("مدیریت حساب های بانکی")] Bank = 31,
        [PersianNameAttribute.PersianName("مدیریت دسته چک ها")] CheckBook = 32,
        [PersianNameAttribute.PersianName("چک های دریافتنی")] ReceptionCheck = 33,
        [PersianNameAttribute.PersianName("چک های پرداختنی")] PardakhtCheck = 34,
        [PersianNameAttribute.PersianName("تنظیمات برنامه")] Setting = 35,
        [PersianNameAttribute.PersianName("دفترچه تلفن")] Phonebook = 36,
        [PersianNameAttribute.PersianName("دفترچه یادداشت")] Note = 37,
        [PersianNameAttribute.PersianName("مدیریت پنل ارسال پیامک")] SmsPanel = 38,
        [PersianNameAttribute.PersianName("ارسال پیامک")] SendSms = 39,
        [PersianNameAttribute.PersianName("آگهی تبلیغاتی")] Advertise = 40,
        [PersianNameAttribute.PersianName("پشتیبان گیری")] BackUp = 41,
        [PersianNameAttribute.PersianName("بازگردانی فایل پشتیبان")] Restore = 42,
        [PersianNameAttribute.PersianName("مدیریت ویژه")] Advance = 43,
        [PersianNameAttribute.PersianName("مدیریت انواع پنجره")] BuildingWindow = 44
    }
    public enum EnDivarCategory
    {
        [PersianNameAttribute.PersianName("اجاره آپارتمان")] RentAppartment = 1,
        [PersianNameAttribute.PersianName("اجاره خانه و ویلا")] RentVilla = 2,
        [PersianNameAttribute.PersianName("فروش آپارتمان")] BuyAppartment = 3,
        [PersianNameAttribute.PersianName("فروش خانه و ویلا")] BuyVilla = 4,
        [PersianNameAttribute.PersianName("فروش زمین و کلنگی")] BuyOldHouse = 5,
        [PersianNameAttribute.PersianName("فروش دفترکار")] BuyOffice = 6,
        [PersianNameAttribute.PersianName("فروش مغازه")] BuyStore = 7,
        [PersianNameAttribute.PersianName("فروش زمین")] BuyGuard = 8,
        [PersianNameAttribute.PersianName("اجاره دفترکار")] RentOffice = 9,
        [PersianNameAttribute.PersianName("اجاره مغازه")] RentStore = 10,
        [PersianNameAttribute.PersianName("اجاره زمین")] RentGuard = 11,
        [PersianNameAttribute.PersianName("مشارکت در ساخت")] ContributionConstruction = 12,
        [PersianNameAttribute.PersianName("پیش فروش")] PreBuy = 13
    }
    public enum EnTelegramType
    {
        [PersianNameAttribute.PersianName("کانال")] Channel = 1,
        [PersianNameAttribute.PersianName("شماره")] Number = 2,
        [PersianNameAttribute.PersianName("گروه")] Group = 3
    }
    public enum ServerStatus : short
    {
        [PersianNameAttribute.PersianName("نامشخص")] None = 0,
        [PersianNameAttribute.PersianName("ارسال شده")] Sent = 1,
        [PersianNameAttribute.PersianName("تحویل شده")] Delivered = 2,
        [PersianNameAttribute.PersianName("خطا در ارسال")] SendError = 3,
        [PersianNameAttribute.PersianName("خطا در تحویل")] DeliveryError = 4,
        [PersianNameAttribute.PersianName("تحویل مستقیم")] DirectDelivery = 5

    }
    public enum EnSanadStatus : short
    {
        [PersianNameAttribute.PersianName("دائمی")] Permament = 0,
        [PersianNameAttribute.PersianName("موقت")] Temporary = 1
    }
    public enum EnHesabGroup
    {
        [PersianNameAttribute.PersianName("دارایی های جاری")] CurrentAssets = 1,
        [PersianNameAttribute.PersianName("دارایی های غیرجاری")] NonCurrentAssets = 2,
        [PersianNameAttribute.PersianName("بدهی های جاری")] CurrentDebits = 3,
        [PersianNameAttribute.PersianName("بدهی های غیرجاری")] NonCurrentDebits = 4,
        [PersianNameAttribute.PersianName("حقوق صاحبان سهام")] HoghooghSahebaneSaham = 5,
        [PersianNameAttribute.PersianName("درآمدها")] Income = 6,
        [PersianNameAttribute.PersianName("بهای تمام شده کالا")] BahayeTamamShode = 7,
        [PersianNameAttribute.PersianName("هزینه ها")] Hazine = 8,
        [PersianNameAttribute.PersianName("سایر حساب ها")] OtherHesabs = 9
    }
    public enum EnCheckSh
    {
        [PersianNameAttribute.PersianName("همه")] All = 0,
        [PersianNameAttribute.PersianName("موجود")] Mojoud = 1,
        [PersianNameAttribute.PersianName("پاس شده")] Pass = 2,
        [PersianNameAttribute.PersianName("برگشتی")] Bargashti = 3,
        [PersianNameAttribute.PersianName("عودت شده")] OudatShode = 4,
        [PersianNameAttribute.PersianName("ابطال شده")] BatelShode = 5,
        [PersianNameAttribute.PersianName("امانت داده شده")] Amanati = 6,
        [PersianNameAttribute.PersianName("خرج شده")] KharjShode = 7
    }
    public enum EnCheckM
    {
        [PersianNameAttribute.PersianName("همه")] All = 0,
        [PersianNameAttribute.PersianName("موجود")] Mojoud = 1,
        [PersianNameAttribute.PersianName("خرج شده")] Kharj = 2,
        [PersianNameAttribute.PersianName("برگشتی")] Bargashti = 3,
        [PersianNameAttribute.PersianName("واگذار شده")] Vagozar = 4,
        [PersianNameAttribute.PersianName("نقد شده")] Naqd = 5,
        [PersianNameAttribute.PersianName("باطل شده")] Batel = 6
    }
    public enum EnOperation
    {
        [PersianNameAttribute.PersianName("نقد")] Naqd = 1,
        [PersianNameAttribute.PersianName("حواله")] Havale = 2,
        [PersianNameAttribute.PersianName("چک شخصی")] CheckSh = 3,
        [PersianNameAttribute.PersianName("چک مشتری")] CheckM = 4,
    }
    public enum HesabType
    {
        [PersianNameAttribute.PersianName("همه")] All = 1,
        [PersianNameAttribute.PersianName("شخص")] Customer = 2,
        [PersianNameAttribute.PersianName("هزینه")] Hazine = 3,
        [PersianNameAttribute.PersianName("بانک")] Bank = 4,
        [PersianNameAttribute.PersianName("صندوق")] Sandouq = 5,
        [PersianNameAttribute.PersianName("حساب تفصیلی")] Tafsil = 6
    }
    public enum EnGroup : short
    {
        [PersianNameAttribute.PersianName("None")] None = 1,
        [PersianNameAttribute.PersianName("Connection")] Connection = 0,
        [PersianNameAttribute.PersianName("Exception")] Exception = 2
    }
    public enum EnTemp : short
    {
        States = 1,
        Cities = 2,
        Region = 3,
        Users = 4,
        PeopleGroups = 5,
        Peoples = 6,
        BuildingAccountType = 8,
        BuildingCondition = 9,
        BuildingType = 10,
        BuildingView = 11,
        DocumentType = 12,
        FloorCover = 13,
        KitchenService = 14,
        RentalAuthority = 15,
        Building = 16,
        Requests = 17,
        Contract = 18,
        Reception = 19,
        Pardakht = 20,
        BuildingOptions = 22,
        BuildingRelatedOptions = 23,
        RequestRegions = 24,
        PhoneBook = 25,
        Advisor = 26,
        Bank = 27,
        Kol = 28,
        Moein = 29,
        Tafsil = 30,
        Sanad = 31,
        SanadDetail = 32,
        BuildingNote = 33,
        BuildingWindow = 34,
        BuildingZoncan = 35,
        BuildingReview = 36
    }
    public enum ResponseStatus
    {
        [PersianNameAttribute.PersianName("موفق")]
        Success,
        [PersianNameAttribute.PersianName("فایل پیدا نشد")]
        FileNotFound,
        [PersianNameAttribute.PersianName("نام کاربری یا رمز عبور اشتباه است")]
        InvalidUserOrPassword,
        [PersianNameAttribute.PersianName("خطا در سرور")]
        ErrorInServer,
        [PersianNameAttribute.PersianName("خطا در پارامترها")]
        ErrorInParameters,
        [PersianNameAttribute.PersianName("خطا در کلاینت")]
        ErrorInClient,
        [PersianNameAttribute.PersianName("خطا در دسترسی")]
        ErrorInAccess
    }
    public enum PagingPosition
    {
        GotoStartPage = 0,
        GotoEndPage = 1
    }
    public enum EnPrintType
    {
        [PersianNameAttribute.PersianName("A4")] Pdf_A4 = 0,
        [PersianNameAttribute.PersianName("A5")] Pdf_A5 = 1,
        [PersianNameAttribute.PersianName("Excel")] Excel = 2,
        [PersianNameAttribute.PersianName("ترازو 2 ستونه")] Taraz2 = 3,
        [PersianNameAttribute.PersianName("تراز 4 ستونه")] Taraz4 = 4,
        [PersianNameAttribute.PersianName("تراز 6 ستونه")] Taraz6 = 5,
        [PersianNameAttribute.PersianName("تراز 8 ستونه")] Taraz8 = 6,
        [PersianNameAttribute.PersianName("None")] None = 7
    }
    public enum EnCustomerLogType
    {
        [PersianNameAttribute.PersianName("تلفن")] Tell = 0,
        [PersianNameAttribute.PersianName("پیامک")] Sms = 1,
        [PersianNameAttribute.PersianName("دریافت")] Receptipn = 2,
        [PersianNameAttribute.PersianName("پرداخت")] Pardakht = 3,
        [PersianNameAttribute.PersianName("فاکتور")] Order = 4
    }
    public enum EnFrmPrint
    {
        None = 1,
        NotShow = 2,
        DisplayForAll = 3
    }
    public enum EnLogAction : short
    {
        [PersianNameAttribute.PersianName("افزودن")] Insert = 0,
        [PersianNameAttribute.PersianName("ویرایش")] Update = 1,
        [PersianNameAttribute.PersianName("حذف")] Delete = 2,
        [PersianNameAttribute.PersianName("فعال کردن")] Enable = 3,
        [PersianNameAttribute.PersianName("ورود به سیستم")] Login = 4,
        [PersianNameAttribute.PersianName("خروج از سیستم")] Logout = 5,
        [PersianNameAttribute.PersianName("مشاهده اطلاعات کامل")] ManagerView = 6,
        [PersianNameAttribute.PersianName("مشاهده اطلاعات محدود")] CustomerView = 7,
        [PersianNameAttribute.PersianName("افزودن به بایگانی")] AddToArchive = 8,
        [PersianNameAttribute.PersianName("خارج کردن از بایگانی")] RemoveFromArchive = 9,
        [PersianNameAttribute.PersianName("افزودن به فایلهای شخصی")] AddToPersonalFiles = 10,
        [PersianNameAttribute.PersianName("نمایش اسلایدشو")] ShowSlideShow = 11,
        [PersianNameAttribute.PersianName("نمایش مدیا")] ShowMedia = 12,
        [PersianNameAttribute.PersianName("ارسال پیامک به مالک")] SendSmsToOwner = 13,
        [PersianNameAttribute.PersianName("ارسال به دیوار")] SendToDivar = 14,
        [PersianNameAttribute.PersianName("ارسال به تلگرام")] SendToTelegram = 15,
        [PersianNameAttribute.PersianName("ارسال به واتساپ")] SendToWhatsApp = 16,
        [PersianNameAttribute.PersianName("چاپ اطلاعات کامل")] FullPrint = 17,
        [PersianNameAttribute.PersianName("چاپ اطلاعات محدود")] CustomPrint = 18,
        [PersianNameAttribute.PersianName("عقد قرارداد")] Contract = 19,
        [PersianNameAttribute.PersianName("تغییر زونکن")] ChangeZoncan = 20,
        [PersianNameAttribute.PersianName("None")] None = 100
    }
    public enum EnLogPart : short
    {
        [PersianNameAttribute.PersianName("کاربران")] Users = 0,
        [PersianNameAttribute.PersianName("اشخاص")] Peoples = 1,
        [PersianNameAttribute.PersianName("ورود به سیستم")] Login = 2,
        [PersianNameAttribute.PersianName("خروج از سیستم")] Logout = 3,
        [PersianNameAttribute.PersianName("شهرها")] Cities = 4,
        [PersianNameAttribute.PersianName("مناطق")] Regions = 5,
        [PersianNameAttribute.PersianName("امکانات ملک")] BuildingOptions = 6,
        [PersianNameAttribute.PersianName("نوع کاربری ملک")] BuildingAccountType = 7,
        [PersianNameAttribute.PersianName("نوع کفپوش")] FloorCover = 8,
        [PersianNameAttribute.PersianName("سرویس آشپزخانه")] KitchenService = 9,
        [PersianNameAttribute.PersianName("انواع سند")] DocumentType = 10,
        [PersianNameAttribute.PersianName("ارجحیت اجاره")] RentalAuthority = 11,
        [PersianNameAttribute.PersianName("نمای ساختمان")] BuildingView = 12,
        [PersianNameAttribute.PersianName("وضعیت بنا")] BuildingCondition = 13,
        [PersianNameAttribute.PersianName("نوع ملک")] BuildingType = 14,
        [PersianNameAttribute.PersianName("املاک")] Building = 15,
        [PersianNameAttribute.PersianName("درخواست ها")] BuildingRequest = 16,
        [PersianNameAttribute.PersianName("قولنامه ها")] Contracts = 17,
        [PersianNameAttribute.PersianName("دریافت")] Reception = 18,
        [PersianNameAttribute.PersianName("پرداخت")] Pardakht = 19,
        [PersianNameAttribute.PersianName("پنجره")] Window = 20,
        [PersianNameAttribute.PersianName("زونکن")] Zoncan = 21
    }
    public enum StatusCode
    {
        InPublishQueue = 1, //  در صف انتشار,
        Published = 2,//  منتشر شده,
        EditNeeded = 3,// "نیاز به اصلاح"
        WaitForPayment = 4,//  "منتظر پرداخت"
        Failed = 5,//  "رد شده"
        Deleted = 6,//  "حذف شده"
        Expired = 7,//  "منقضی شده"
        InsertError = 10,//  "خطای درج"
        Unknown = 0//  "نامشخص"
    }
    public enum EnEconomyType : int
    {
        [PersianNameAttribute.PersianName("مشاور املاک")] Amlak = 0,
        [PersianNameAttribute.PersianName("انبوه ساز")] AnbouhSaz = 1,
        [PersianNameAttribute.PersianName("سایر")] Sayer = 2
    }
    public enum EnMetr : int
    {
        [PersianNameAttribute.PersianName("متر مربع")] Metr = 0,
        [PersianNameAttribute.PersianName("هکتار")] Hektar = 1
    }
    public enum EnBackUpType : short
    {
        [PersianNameAttribute.PersianName("دستی")] Manual = 0,
        [PersianNameAttribute.PersianName("خودکار")] Auto = 1
    }
    public enum EnBackUpStatus : short
    {
        [PersianNameAttribute.PersianName("موفق")] Success = 0,
        [PersianNameAttribute.PersianName("درحال انجام")] Pending = 1,
        [PersianNameAttribute.PersianName("خطا")] Error = 2
    }
    public enum EnBuildingPriority : short
    {
        [PersianNameAttribute.PersianName("فوق العاده بالا")] SoHigh = 0,
        [PersianNameAttribute.PersianName("بالا")] High = 1,
        [PersianNameAttribute.PersianName("معمولی")] Medium = 2,
        [PersianNameAttribute.PersianName("پایین")] Low = 3
    }
    public enum EnPrice : short
    {
        [PersianNameAttribute.PersianName("هزارتومان")] Hezar = 0,
        [PersianNameAttribute.PersianName("میلیون تومان")] Miliun = 1,
        [PersianNameAttribute.PersianName("میلیارد تومان")] Miliard = 2
    }
    public enum EnBuildingSide : int
    {
        [PersianNameAttribute.PersianName("شمالی")] One = 0,
        [PersianNameAttribute.PersianName("جنوبی")] Tow = 1,
        [PersianNameAttribute.PersianName("شرقی")] Three = 2,
        [PersianNameAttribute.PersianName("غربی")] Four = 3,
        [PersianNameAttribute.PersianName("شمالی شرقی")] Five = 4,
        [PersianNameAttribute.PersianName("شمالی غربی")] Six = 5,
        [PersianNameAttribute.PersianName("جنوبی شرقی")] Seven = 6,
        [PersianNameAttribute.PersianName("جنوبی غربی")] Eight = 7,
        [PersianNameAttribute.PersianName("شمالی جنوبی دوکله")] Nine = 8,
        [PersianNameAttribute.PersianName("شرقی غربی دوکله")] Ten = 9,
        [PersianNameAttribute.PersianName("شمالی شرقی غربی")] Eleven = 10,
        [PersianNameAttribute.PersianName("جنوبی شرقی غربی")] Towelve = 11,
        [PersianNameAttribute.PersianName("شرقی شمالی جنوبی")] Thirteen = 12,
        [PersianNameAttribute.PersianName("غربی شمالی جنوبی")] Fourteen = 13,
        [PersianNameAttribute.PersianName("تعیین نشده")] None = 100,
    }
    public enum EnContractBabat : short
    {
        [PersianNameAttribute.PersianName("اجاره")] Ejare = 0,
        [PersianNameAttribute.PersianName("اجاره به شرط تملیک")] EjareTamlik = 1,
        [PersianNameAttribute.PersianName("فروش")] Foroush = 2,
        [PersianNameAttribute.PersianName("پیش فروش")] PishForoush = 3,
        [PersianNameAttribute.PersianName("مشارکت در ساخت")] Mosharekat = 4,
        [PersianNameAttribute.PersianName("معاوضه")] Moaveze = 5
    }

    public enum EnRequestType : short
    {
        [PersianNameAttribute.PersianName("اجاره نامه")] Rahn = 0,
        [PersianNameAttribute.PersianName("مبایعه نامه")] Forush = 1,
        [PersianNameAttribute.PersianName("پیش فروش")] PishForush = 2,
        [PersianNameAttribute.PersianName("معاوضه")] Moavezeh = 3,
        [PersianNameAttribute.PersianName("مشارکت در ساخت")] Mosharekat = 4,
        [PersianNameAttribute.PersianName("اجاره به شرط تملیک")] EjareTamlik = 5,
        [PersianNameAttribute.PersianName("انتقال سرقفلی")] Sarqofli = 6,
        [PersianNameAttribute.PersianName("None")] None = 100
    }
    public enum EnContractType : short
    {
        [PersianNameAttribute.PersianName("فروش")] Forush = 1,
        [PersianNameAttribute.PersianName("رهن و اجاره")] RahnEjare = 2,
        [PersianNameAttribute.PersianName("رهن کامل")] FullRahn = 3,
        [PersianNameAttribute.PersianName("پیش فروش")] PishForush = 4,
        [PersianNameAttribute.PersianName("معاوضه")] Moavezeh = 5,
        [PersianNameAttribute.PersianName("مشارکت در ساخت")] Mosharekat = 6,
        [PersianNameAttribute.PersianName("None")] None = 100
    }
    public enum EnContractType_ : short
    {
        [PersianNameAttribute.PersianName("آپارتمان")] Appartment = 1,
        [PersianNameAttribute.PersianName("ویلایی")] Home = 2,
        [PersianNameAttribute.PersianName("زمین")] Land = 3,
        [PersianNameAttribute.PersianName("ویلا")] Villa = 4,
        [PersianNameAttribute.PersianName("مغازه و تجاری")] Store = 5,
        [PersianNameAttribute.PersianName("دفترکار اداری")] Office = 6,
        [PersianNameAttribute.PersianName("باغ")] Garden = 7,
        [PersianNameAttribute.PersianName("کلنگی")] OldHouse = 8
    }
    public enum EnEconomyCodeStatus
    {
        [PersianNameAttribute.PersianName("نام کاربری دارم")] HasUserName = 0,
        [PersianNameAttribute.PersianName("کد رهگیری دارم")] HasCode = 1,
        [PersianNameAttribute.PersianName("پیش ثبت نام کد اقتصادی نکرده ام")] DontHave = 2
    }
    public enum EnLogType : short
    {
        [PersianNameAttribute.PersianName("اشخاص")] Customers = 0,
        [PersianNameAttribute.PersianName("فاکتورها")] Orders = 1,
        [PersianNameAttribute.PersianName("پرداخت")] Pardakht = 2,
        [PersianNameAttribute.PersianName("دریافت")] Reception = 3,
        [PersianNameAttribute.PersianName("SafeBox ها")] SafeBox = 4,
        [PersianNameAttribute.PersianName("پنل پیامکی")] SmsPanel = 5,
        [PersianNameAttribute.PersianName("کاربران")] Users = 6
    }

    public enum EnSafeBox : short
    {
        [PersianNameAttribute.PersianName("بانک")] Bank = 0,
        [PersianNameAttribute.PersianName("صندوق")] Sandouq = 1
    }
    public enum EnAccountingType : short
    {
        [PersianNameAttribute.PersianName("اشخاص")] Peoples = 0
    }
    public enum EnUserType : short
    {
        [PersianNameAttribute.PersianName("اپراتور")] Operator = 0,
        [PersianNameAttribute.PersianName("ویزیتور")] Visitor = 1,
        [PersianNameAttribute.PersianName("مدیر")] Manager = 2
    }
    public enum EnKhadamati : short
    {
        [PersianNameAttribute.PersianName("مستقل")] Mostaqel = 0,
        [PersianNameAttribute.PersianName("مشترک")] Moshtarek = 1,
        [PersianNameAttribute.PersianName("ندارد")] Nadarad = 2,
        [PersianNameAttribute.PersianName("تعیین نشده")] None = 3
    }
    public enum EnPhoneBookGroup : short
    {
        [PersianNameAttribute.PersianName("[همه گروه ها]")] All = 0,
        [PersianNameAttribute.PersianName("اشخاص")] Peoples = 1,
        [PersianNameAttribute.PersianName("کاربران")] Users = 2,
        [PersianNameAttribute.PersianName("دریافت شده از دیوار")] Divar = 3,
        [PersianNameAttribute.PersianName("مشاوران")] Advisor = 4
    }
    public enum EnSecurityQuestion : short
    {
        [PersianNameAttribute.PersianName("فامیل معلم کلاس سوم شما چه بود؟")] One = 0,
        [PersianNameAttribute.PersianName("نام دومین حیوان خانگی که داشتید چه بود؟")] Tow = 1,
        [PersianNameAttribute.PersianName("وقتی بچه بودبد، دوست داشتید در آینده چه کاره شوید؟")] Three = 2,
        [PersianNameAttribute.PersianName("زمان تحویل سال 1395 کجا بودید؟")] Four = 3,
        [PersianNameAttribute.PersianName("زمانی که خبر زلزله کرمانشاه را شنیدید، کجا بودید؟")] Five = 4,
        [PersianNameAttribute.PersianName("قهرمان دوران کودکی شما که بود؟")] Six = 5,
    }
    public enum EnAccountType : short
    {
        [PersianNameAttribute.PersianName("[همه]")] All = 0,
        [PersianNameAttribute.PersianName("بی حساب")] BiHesab = 1,
        [PersianNameAttribute.PersianName("بدهکار")] Bed = 2,
        [PersianNameAttribute.PersianName("بستانکار")] Bes = 3
    }
    public enum EnAccountBabat : short
    {
        [PersianNameAttribute.PersianName("[همه]")] All = 0,
        [PersianNameAttribute.PersianName("ثبت حساب")] Ins = 1,
        [PersianNameAttribute.PersianName("ثبت قولنامه")] InsContract = 2,
        [PersianNameAttribute.PersianName("ثبت سند دریافت")] Reception = 3,
        [PersianNameAttribute.PersianName("ثبت سند پرداخت")] Payement = 4,
        [PersianNameAttribute.PersianName("ثبت سند دستی")] Sanad = 5
    }
    public enum EnSanadType : short
    {
        [PersianNameAttribute.PersianName("سند دستی")] Dasti = 0,
        [PersianNameAttribute.PersianName("سند افتتاحیه")] Eftetahiye = 1,
        [PersianNameAttribute.PersianName("سند اختتامیه")] Ekhtetamiye = 2,
        [PersianNameAttribute.PersianName("سند اتومات")] Auto = 3,
        [PersianNameAttribute.PersianName("سند یادداشت")] Note = 4
    }
    public enum ENSource
    {
        [PersianNameAttribute.PersianName("None")] None = 0,
        [PersianNameAttribute.PersianName("دپارتمان")] Department = 1,
        [PersianNameAttribute.PersianName("املاک")] Building = 2,
        [PersianNameAttribute.PersianName("Server")] Server = 3,
        [PersianNameAttribute.PersianName("Scrapper")] Scrapper = 4
    }
    public enum ReturnedState : short
    {
        Information = 1,
        Error = 2,
        Warning = 3
    }
    public enum EnTarakom : short
    {
        [PersianNameAttribute.PersianName("کم")] Low = 0,
        [PersianNameAttribute.PersianName("متوسط")] Min = 1,
        [PersianNameAttribute.PersianName("زیاد")] High = 2,
        [PersianNameAttribute.PersianName("نامحدود")] PerHigh = 3,
        [PersianNameAttribute.PersianName("سایر")] Other = 4
    }
    public enum AdvertiseType : short
    {
        [PersianNameAttribute.PersianName("دیوار")] Divar = 0,
        [PersianNameAttribute.PersianName("شیپور")] Sheypoor = 1,
        [PersianNameAttribute.PersianName("چت دیوار")] DivarChat = 2,
        [PersianNameAttribute.PersianName("هردو")] Both = 3,
        [PersianNameAttribute.PersianName("None")] None = 100,
    }
    public enum EnVillaType : short
    {
        [PersianNameAttribute.PersianName("ساحلی")] Beatch = 1,
        [PersianNameAttribute.PersianName("جنگلی")] Forest = 2,
        [PersianNameAttribute.PersianName("شهرکی")] City = 3
    }
    public enum EnCommericallLicense : short
    {
        [PersianNameAttribute.PersianName("ندارد")] HasNot = 1,
        [PersianNameAttribute.PersianName("دائمی")] Permament = 2,
        [PersianNameAttribute.PersianName("موقت")] Temporary = 3
    }
    public enum EnNoteStatus : short
    {
        [PersianNameAttribute.PersianName("همه")] All = 0,
        [PersianNameAttribute.PersianName("خوانده نشده")] Unread = 1,
        [PersianNameAttribute.PersianName("خوانده شده")] Read = 2,
        [PersianNameAttribute.PersianName("حذف شده")] Deleted = 3
    }
    public enum EnConstructionStage : short
    {
        [PersianNameAttribute.PersianName("نصبیات")] Nasbiat = 1,
        [PersianNameAttribute.PersianName("نازک کاری")] NazokKari = 2,
        [PersianNameAttribute.PersianName("سفت کاری")] SeftKari = 3,
        [PersianNameAttribute.PersianName("اسکلت")] Eskelet = 4,
        [PersianNameAttribute.PersianName("فونداسیون")] Fundation = 5,
        [PersianNameAttribute.PersianName("خاک برداری")] KhakBardari = 6,
        [PersianNameAttribute.PersianName("تخریب")] Takhrib = 7
    }
    public enum EnBuildingParent : short
    {
        [PersianNameAttribute.PersianName("تعیین نشده")] None = 0,
        [PersianNameAttribute.PersianName("فروش آپارتمان")] SellAprtment = 101,
        [PersianNameAttribute.PersianName("فروش ویلایی")] SellHome = 102,
        [PersianNameAttribute.PersianName("فروش زمین")] SellLand = 103,
        [PersianNameAttribute.PersianName("فروش ویلا")] SellVilla = 104,
        [PersianNameAttribute.PersianName("فروش واحد تجاری")] SellStore = 105,
        [PersianNameAttribute.PersianName("فروش واحد اداری")] SellOffice = 106,
        [PersianNameAttribute.PersianName("فروش باغ")] SellGarden = 107,
        [PersianNameAttribute.PersianName("فروش کلنگی")] SellOldHouse = 108,
        [PersianNameAttribute.PersianName("رهن و اجاره آپارتمان")] RentAprtment = 109,
        [PersianNameAttribute.PersianName("رهن و اجاره ویلایی")] RentHome = 110,
        [PersianNameAttribute.PersianName("رهن و اجاره واحد تجاری")] RentStore = 111,
        [PersianNameAttribute.PersianName("رهن و اجاره واحد اداری")] RentOffice = 112,
        [PersianNameAttribute.PersianName("رهن کامل آپارتمان")] FullRentAprtment = 113,
        [PersianNameAttribute.PersianName("رهن کامل ویلایی")] FullRentHome = 114,
        [PersianNameAttribute.PersianName("رهن کامل واحد تجاری")] FullRentStore = 115,
        [PersianNameAttribute.PersianName("رهن کامل واحد اداری")] FullRentOffice = 116,
        [PersianNameAttribute.PersianName("پیش فروش آپارتمان")] PreSellAprtment = 117,
        [PersianNameAttribute.PersianName("پیش فروش ویلایی")] PreSellHome = 118,
        [PersianNameAttribute.PersianName("پیش فروش واحد تجاری")] PreSellStore = 119,
        [PersianNameAttribute.PersianName("پیش فروش واحد اداری")] PreSellOffice = 120,
        [PersianNameAttribute.PersianName("معاوضه آپارتمان")] MoavezeAprtment = 121,
        [PersianNameAttribute.PersianName("معاوضه ویلایی")] MoavezeHome = 122,
        [PersianNameAttribute.PersianName("معاوضه واحد تجاری")] MoavezeStore = 123,
        [PersianNameAttribute.PersianName("معاوضه واحد اداری")] MoavezeOffice = 124,
        [PersianNameAttribute.PersianName("مشارکت در ساخت آپارتمان")] MosharekatAprtment = 125,
        [PersianNameAttribute.PersianName("مشارکت در ساخت ویلایی")] MosharekatHome = 126
    }
    public enum EnNotePriority : short
    {
        [PersianNameAttribute.PersianName("همه")] All = 0,
        [PersianNameAttribute.PersianName("معمولی")] Mamoli = 1,
        [PersianNameAttribute.PersianName("مهم")] Mohem = 2,
        [PersianNameAttribute.PersianName("ضروری")] Zarori = 3
    }
    public enum EnAppSerial : int
    {
        [PersianNameAttribute.PersianName("نرم افزار املاک آراد")] Building = 36,
        [PersianNameAttribute.PersianName("زیربسته ارسال پیامک")] Sms = 97,
        [PersianNameAttribute.PersianName("زیربسته ارسال آگهی های تبلیغاتی")] Advertise = 72,
        [PersianNameAttribute.PersianName("زیربسته ارتباط با تلگرام")] Telegram = 44,
        [PersianNameAttribute.PersianName("زیربسته ارتباط با واتساپ")] WhatsApp = 32,
        [PersianNameAttribute.PersianName("زیربسته پشتیبان گیری خودکار")] AutoBackUp = 87,
        [PersianNameAttribute.PersianName("زیربسته ارتباط با اکسل")] Excel = 25,
        [PersianNameAttribute.PersianName("زیربسته ارتباط با وب سایت")] WebSite = 68,
        [PersianNameAttribute.PersianName("زیربسته ارتباط با اپلیکیشن موبایل")] MobileApp = 53,
        [PersianNameAttribute.PersianName("زیربسته راه اندازی تحت شبکه")] Network = 62,
        [PersianNameAttribute.PersianName("زیربسته حسابداری")] Accounting = 50,
        [PersianNameAttribute.PersianName("وب سرویس ارتباط با سرور")] WebService = 91
    }
    public enum ServiceState
    {
        Unknown = -1,
        NotFound = 0,
        Stopped = 1,
        StartPending = 2,
        StopPending = 3,
        Running = 4,
        ContinuePending = 5,
        PausePending = 6,
        Paused = 7
    }

    [Flags]
    public enum ScmAccessRights
    {
        Connect = 0x0001,
        CreateService = 0x0002,
        EnumerateService = 0x0004,
        Lock = 0x0008,
        QueryLockStatus = 0x0010,
        ModifyBootConfig = 0x0020,
        StandardRightsRequired = 0xF0000,
        AllAccess = (StandardRightsRequired | Connect | CreateService |
                     EnumerateService | Lock | QueryLockStatus | ModifyBootConfig)
    }

    [Flags]
    public enum ServiceAccessRights
    {
        QueryConfig = 0x1,
        ChangeConfig = 0x2,
        QueryStatus = 0x4,
        EnumerateDependants = 0x8,
        Start = 0x10,
        Stop = 0x20,
        PauseContinue = 0x40,
        Interrogate = 0x80,
        UserDefinedControl = 0x100,
        Delete = 0x00010000,
        StandardRightsRequired = 0xF0000,
        AllAccess = (StandardRightsRequired | QueryConfig | ChangeConfig |
                     QueryStatus | EnumerateDependants | Start | Stop | PauseContinue |
                     Interrogate | UserDefinedControl)
    }
    public enum ServiceBootFlag
    {
        Start = 0x00000000,
        SystemStart = 0x00000001,
        AutoStart = 0x00000002,
        DemandStart = 0x00000003,
        Disabled = 0x00000004
    }
    public enum ServiceControl
    {
        Stop = 0x00000001,
        Pause = 0x00000002,
        Continue = 0x00000003,
        Interrogate = 0x00000004,
        Shutdown = 0x00000005,
        ParamChange = 0x00000006,
        NetBindAdd = 0x00000007,
        NetBindRemove = 0x00000008,
        NetBindEnable = 0x00000009,
        NetBindDisable = 0x0000000A
    }
    public enum ServiceError
    {
        Ignore = 0x00000000,
        Normal = 0x00000001,
        Severe = 0x00000002,
        Critical = 0x00000003
    }
    public enum EnCreateDataBase
    {
        Unknown = 0,
        ServerConnectionStringError = 1,
        DatabaseNameEmpty = 2,
        DatabaseExists = 3,
        Success = 4
    }
    public enum MessageStatus
    {
        Queued = 1,
        Schulded = 2,
        SentToCenter = 4,
        Delivered = 10,
        Undelivered = 11,
        Canceled = 13,
        Filtered = 14,
        Received = 50,
        Incorrect = 100
    }
    public enum MessageType
    {
        Flash = 0,
        MobileMemory = 1,
        SimMemory = 2,
        AppMemory = 3
    }
    public enum MetaCode
    {

        NotChecked = 99,
        Approved = 100,
        InvalidApiKey = 101,
        ExpiredApiKey = 102,
        AccountDisabled = 103,
        NotEnoughCredit = 104,
        ServerisBusy = 105,
        UndefinedCommand = 106,
        RequestFailed = 107,
        ParametersBroken = 108,
        InvalidRecp = 110,
        InvalidSenderNumber = 111,
        EmptyMessage = 112,
        RecpIsTooLarge = 113,
        InvalidDate = 114,
        MsgIsTooLarge = 115,
        RecpNotEqualWithMessage = 116
    }
    public enum VerifyLookupType
    {
        Sms = 0,
        Call = 1,
    }
    public enum AccessPart : int
    {
        Peoples = 10,
        Cities = 11,
        Regions = 12,
        BuildingOptions = 13,
        BuildingAccountType = 14,
        FloorCover = 15,
        KitchenService = 16,
        DocumentType = 17,
        RentalAuthotity = 18,
        BuildingView = 19,
        BuildingCondition = 20,
        BuildingType = 21,
        Building = 22,
        BuildingSearch = 23,
        BuildingRequest = 24,
        Contract = 25,
        Users = 26,
        AccessLevel = 27,
        Hazine = 28,
        AccountPerformence = 29,
        Reception = 30,
        Pardakht = 31,
        Sanad = 32,
        PhoneBook = 33,
        SmsPanels = 34,
        SendSms = 35,
        Simcards = 36,
        Reports = 37
    }
    public enum State : int
    {
        People_Insert = 1001,
        People_Update = 1002,
        People_Delete = 1003,
        People_View = 1004,
        People_Disable = 1005,
        People_ShowForm = 1006,
        People_Group_Insert = 1007,
        People_Group_Update = 1008,
        People_Group_Delete = 1009,
        People_Show_Tell = 1010,
        People_Show_BankHesab = 1011,
        People_SendSms = 1012,
        People_Import_Excel = 1013,

        Cities_Insert = 1101,
        Cities_Update = 1102,
        Cities_Delete = 1103,
        Cities_View = 1104,
        Cities_Disable = 1105,
        Cities_ShowForm = 1106,

        Regions_Insert = 1201,
        Regions_Update = 1202,
        Regions_Delete = 1203,
        Regions_View = 1204,
        Regions_Disable = 1205,
        Regions_ShowForm = 1206,

        Building_Options_Insert = 1301,
        Building_Options_Update = 1302,
        Building_Options_Delete = 1303,
        Building_Options_View = 1304,
        Building_Options_Disable = 1305,
        Building_Options_ShowForm = 1306,

        Building_Account_Type_Insert = 1401,
        Building_Account_Type_Update = 1402,
        Building_Account_Type_Delete = 1403,
        Building_Account_Type_View = 1404,
        Building_Account_Type_Disable = 1405,
        Building_Account_Type_ShowForm = 1406,

        Floor_Cover_Insert = 1501,
        Floor_Cover_Update = 1502,
        Floor_Cover_Delete = 1503,
        Floor_Cover_View = 1504,
        Floor_Cover_Disable = 1505,
        Floor_Cover_ShowForm = 1506,

        Kitchen_Service_Insert = 1601,
        Kitchen_Service_Update = 1602,
        Kitchen_Service_Delete = 1603,
        Kitchen_Service_View = 1604,
        Kitchen_Service_Disable = 1605,
        Kitchen_Service_ShowForm = 1606,

        Document_Type_Insert = 1701,
        Document_Type_Update = 1702,
        Document_Type_Delete = 1703,
        Document_Type_View = 1704,
        Document_Type_Disable = 1705,
        Document_Type_ShowForm = 1706,

        Rental_Authority_Insert = 1801,
        Rental_Authority_Update = 1802,
        Rental_Authority_Delete = 1803,
        Rental_Authority_View = 1804,
        Rental_Authority_Disable = 1805,
        Rental_Authority_ShowForm = 1806,

        Building_View_Insert = 1901,
        Building_View_Update = 1902,
        Building_View_Delete = 1903,
        Building_View_View = 1904,
        Building_View_Disable = 1905,
        Building_View_ShowForm = 1906,

        Building_Condition_Insert = 2001,
        Building_Condition_Update = 2002,
        Building_Condition_Delete = 2003,
        Building_Condition_View = 2004,
        Building_Condition_Disable = 2005,
        Building_Condition_ShowForm = 2006,

        Building_Type_Insert = 2101,
        Building_Type_Update = 2102,
        Building_Type_Delete = 2103,
        Building_Type_View = 2104,
        Building_Type_Disable = 2105,
        Building_Type_ShowForm = 2106,

        Building_Insert = 2201,
        Building_Update = 2202,
        Building_Delete = 2203,
        Building_View = 2204,
        Building_Disable = 2205,
        Building_ShowForm = 2206,
        Building_Mojod = 2207,
        Building_Vagozar = 2208,
        Building_Send_Sms = 2209,
        Building_Send_Divar = 2210,
        Building_Send_Sheypoor = 2211,
        Building_Send_Telegram = 2212,
        Building_Request_Match = 2213,

        Building_Search_Site = 2302,
        Building_Search_Sheypoor = 2303,
        Building_Search_Divar = 2304,
        Building_Search_System = 2305,
        Building_Search_ShowForm = 2306,

        Building_Request_Insert = 2401,
        Building_Request_Update = 2402,
        Building_Request_Delete = 2403,
        Building_Request_View = 2404,
        Building_Request_Disable = 2405,
        Building_Request_ShowForm = 2406,
        Building_Request_Send_Sms = 2407,
        Building_Request_Show_Match = 2408,

        Contract_Insert = 2501,
        Contract_Update = 2502,
        Contract_Delete = 2503,
        Contract_View = 2504,
        Contract_Disable = 2505,
        Contract_ShowForm = 2506,
        Contract_Finish = 2507,

        Users_Insert = 2601,
        Users_Update = 2602,
        Users_Delete = 2603,
        Users_View = 2604,
        Users_Disable = 2605,
        Users_ShowForm = 2606,
        Users_Gardesh = 2607,

        Users_AccessLevel_ShowForm = 2701,

        Hazine_Insert = 2801,
        Hazine_Update = 2802,
        Hazine_Delete = 2803,
        Hazine_View = 2804,
        Hazine_Disable = 2805,
        Hazine_ShowForm = 2806,
        Hazine_Gardesh = 2807,

        Account_Performence_ShowForm = 2901,

        Reception_Insert = 3001,
        Reception_Update = 3002,
        Reception_Delete = 3003,
        Reception_View = 3004,
        Reception_Disable = 3005,
        Reception_ShowForm = 3006,

        Pardakht_Insert = 3101,
        Pardakht_Update = 3102,
        Pardakht_Delete = 3103,
        Pardakht_View = 3104,
        Pardakht_Disable = 3105,
        Pardakht_ShowForm = 3106,

        Sanad_Insert = 3201,

        PhoneBook_Insert = 3301,
        PhoneBook_Update = 3302,
        PhoneBook_Delete = 3303,
        PhoneBook_View = 3304,
        PhoneBook_Disable = 3305,
        PhoneBook_ShowForm = 3306,

        Sms_Panels_Insert = 3401,
        Sms_Panels_Update = 3402,
        Sms_Panels_Delete = 3403,
        Sms_Panels_View = 3404,
        Sms_Panels_Disable = 3405,
        Sms_Panels_ShowForm = 3406,

        SendSms_ShowForm = 3501,

        Simcards_Insert = 3601,
        Simcards_Update = 3602,
        Simcards_Delete = 3603,
        Simcards_View = 3604,
        Simcards_Disable = 3605,
        Simcards_ShowForm = 3606,
        Simcards_Divar_Token = 3607,
        Simcards_Sheypoor_Token = 3608,
        Simcards_Delete_Token = 3609,
        Simcards_Send_Adv = 3610,

        Reports_User_Performence = 3701,
        Reports_Export_People_Excel = 3702,

    }
    public enum StiType : short
    {
        Building_One = 0,
        Building_List = 1,
        People_List = 2,
        Building_Request_One = 3,
        Building_Request_List = 4,
        Contract_One = 5,
        Contract_List = 6,
        User_Performence_List = 7,
        Account_Performence_One = 8,
        Account_Performence_List = 9,
        Reception_One = 10,
        Reception_List = 11,
        Pardakht_One = 12,
        Pardakht_List = 13,
        SmsSent_List = 14,
        AdvSent_List = 15,
        Sood_Zian = 16,
        Sanad = 17,
        Roozname = 18,
        TarazAzmayeshi = 19,
        TarazHesab = 20,
        DepartmentOrder = 21,
        Contract_Rasmi_One = 22
    }
}
