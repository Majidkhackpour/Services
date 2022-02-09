using System;

namespace Services.FilterObjects
{
    public class ContractFilter
    {
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public EnRequestType? Type { get; set; } = null;
        public Guid? TafsilGuid { get; set; } = null;
        public bool? Status { get; set; }
    }
}
