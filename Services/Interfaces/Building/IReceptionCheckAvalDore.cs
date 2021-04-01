using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IReceptionCheckAvalDore : IHasGuid
    {
        string BankName { get; set; }
        DateTime DateM { get; set; }
        DateTime DateSarResid { get; set; }
        string Description { get; set; }
        string CheckNumber { get; set; }
        string PoshtNomre { get; set; }
        decimal Price { get; set; }
        EnCheckM CheckStatus { get; set; }
        Guid SandouqTafsilGuid { get; set; }
        Guid SandouqMoeinGuid { get; set; }
        Guid TafsilGuid { get; set; }
        Guid UserGuid { get; set; }
    }
}
