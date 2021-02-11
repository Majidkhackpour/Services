using System;

namespace Services.DefaultCoding
{
    public class HesabGroupDefualts
    {
        //1	دارايي هاي جاري
        public Guid CurrentAssets = Guid.Parse("1df5dcf8-c423-4810-8805-37a62520c313");
        //2	دارايي هاي غيرجاري	
        public Guid NonCurrentAssets = Guid.Parse("f18aad12-ac14-40b0-8d52-5593f133cb0c");
        //3	بدهي هاي جاري	
        public Guid CurrentDebits = Guid.Parse("121fdc26-d958-4ed2-8f7d-ad7be4ed40ed");
        //4	بدهي هاي غيرجاري	
        public Guid NonCurrentDebits = Guid.Parse("fb6fd963-2549-4350-a476-105a5d1120c4");
        //5	حقوق صاحبان سهام	
        public Guid HoghooghSahebaneSaham = Guid.Parse("1adee029-cb95-4c9f-9584-7e27c4dccb64");
        //6	درآمد ها
        public Guid Income = Guid.Parse("39219004-d326-49d3-947b-afe40f1f02a8");
        //7	بهای تمام شده کالا	
        public Guid BahayeTamamShode = Guid.Parse("86a80eef-aa35-4581-a3c3-9b6a76b2a978");
        //8	هزینه ها	
        public Guid Hazine = Guid.Parse("52fde6f0-fded-40d9-ac46-eeef91e37562");
        //9	ساير حساب ها	
        public Guid OtherHesabs = Guid.Parse("b3240a34-1618-427b-beaa-25482afba485");
    }
}
