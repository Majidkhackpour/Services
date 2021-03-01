using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface ICheckPage : IHasGuid
    {
        Guid CheckGuid { get; set; }
        DateTime? DatePardakht { get; set; }
        long Number { get; set; }
        Guid? ReceptorGuid { get; set; }
        DateTime? DateSarresid { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        EnCheckSh CheckStatus { get; set; }
    }
}
