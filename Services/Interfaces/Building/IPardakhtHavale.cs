using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IPardakhtHavale : IHasGuid
    {
        string Description { get; set; }
        string Number { get; set; }
        decimal Price { get; set; }
        Guid BankTafsilGuid { get; set; }
        Guid BankMoeinGuid { get; set; }
        Guid MasterGuid { get; set; }
    }
}
