using System;

namespace Services
{
    public enum EnPartDate
    {
        [PersianNameAttribute.PersianName("سال")] Year = 1,
        [PersianNameAttribute.PersianName("ماه")] Mounth = 2,
        [PersianNameAttribute.PersianName("روز")] Day = 3
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
    public enum EnBuildingStatus : short
    {
        [PersianNameAttribute.PersianName("موجود")] Mojod = 0,
        [PersianNameAttribute.PersianName("واگذارشده")] Vagozar = 1,
        [PersianNameAttribute.PersianName("[همه]")] All = -1
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
        [PersianNameAttribute.PersianName("غربی شمالی جنوبی")] Fourteen = 13
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
        [PersianNameAttribute.PersianName("رهن و اجاره")] Rahn = 0,
        [PersianNameAttribute.PersianName("فروش")] Forush = 1,
        [PersianNameAttribute.PersianName("پیش فروش")] PishForush = 2,
        [PersianNameAttribute.PersianName("معاوضه")] Moavezeh = 3,
        [PersianNameAttribute.PersianName("مشارکت در ساخت")] Mosharekat = 4
    }

    public enum EnLogType : short
    {

    }

    public enum EnSafeBox : short
    {
        [PersianNameAttribute.PersianName("بانک")] Bank = 0,
        [PersianNameAttribute.PersianName("صندوق")] Sandouq = 1
    }
    public enum EnAccountingType : short
    {
        [PersianNameAttribute.PersianName("اشخاص")] Peoples = 0,
        [PersianNameAttribute.PersianName("هزینه ها")] Hazine = 1,
        [PersianNameAttribute.PersianName("کاربران")] Users = 2
    }
    public enum EnUserType : short
    {
        [PersianNameAttribute.PersianName("اپراتور")] Operator = 0,
        [PersianNameAttribute.PersianName("ویزیتور")] Visitor = 1,
        [PersianNameAttribute.PersianName("مدیر")] Manager = 2
    }
    public enum EnReceptionType : short
    {
        [PersianNameAttribute.PersianName("نقد")] Naqd = 0,
        [PersianNameAttribute.PersianName("کارتخوان")] Pos = 1,
        [PersianNameAttribute.PersianName("واریز به حساب")] Bank = 2,
        [PersianNameAttribute.PersianName("چک دریافتنی")] Cheque = 3
    }
    public enum EnKhadamati : short
    {
        [PersianNameAttribute.PersianName("مستقل")] Mostaqel = 0,
        [PersianNameAttribute.PersianName("مشترک")] Moshtarek = 1,
        [PersianNameAttribute.PersianName("ندارد")] Nadarad = 2
    }
    public enum EnPhoneBookGroup : short
    {
        [PersianNameAttribute.PersianName("[همه گروه ها]")] All = 0,
        [PersianNameAttribute.PersianName("اشخاص")] Peoples = 1,
        [PersianNameAttribute.PersianName("کاربران")] Users = 2,
        [PersianNameAttribute.PersianName("دریافت شده از دیوار")] Divar = 3
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
        [PersianNameAttribute.PersianName("سند اتومات")] Auto = 1
    }
    public enum ENSource
    {
        [PersianNameAttribute.PersianName("None")] None = 0,
        [PersianNameAttribute.PersianName("دپارتمان")] Department = 1,
        [PersianNameAttribute.PersianName("املاک")] Building = 2
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
        [PersianNameAttribute.PersianName("زیاد")] High = 2
    }

    public enum EnNoteStatus : short
    {
        [PersianNameAttribute.PersianName("همه")] All = 0,
        [PersianNameAttribute.PersianName("خوانده نشده")] Unread = 1,
        [PersianNameAttribute.PersianName("خوانده شده")] Read = 2,
        [PersianNameAttribute.PersianName("حذف شده")] Deleted = 3
    }

    public enum EnNotePriority : short
    {
        [PersianNameAttribute.PersianName("همه")] All = 0,
        [PersianNameAttribute.PersianName("معمولی")] Mamoli = 1,
        [PersianNameAttribute.PersianName("مهم")] Mohem = 2,
        [PersianNameAttribute.PersianName("ضروری")] Zarori = 3
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
}
