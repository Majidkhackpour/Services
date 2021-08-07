using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IReceptionHavale : IHasGuid, IHasModified
    {
        DateTime DateM { get; set; }
        Guid MasterGuid { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        string PeygiriNumber { get; set; }
        Guid BankTafsilGuid { get; set; }
        Guid BankMoeinGuid { get; set; }
    }
}
