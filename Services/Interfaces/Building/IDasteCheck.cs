using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IDasteCheck : IHasGuid
    {
        string SerialNumber { get; set; }
        Guid BankGuid { get; set; }
        long FromNumber { get; set; }
        long ToNumber { get; set; }
        string Description { get; set; }
    }
}
