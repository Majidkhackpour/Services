using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IReceptionCheck : IHasGuid, IHasModified
    {
        string BankName { get; set; }
        DateTime DateM { get; set; }
        DateTime DateSarResid { get; set; }
        Guid? MasterGuid { get; set; }
        bool isAvalDore { get; set; }
        string Description { get; set; }
        string CheckNumber { get; set; }
        string PoshtNomre { get; set; }
        decimal Price { get; set; }
        EnCheckM CheckStatus { get; set; }
        Guid SandouqTafsilGuid { get; set; }
        Guid SandouqMoeinGuid { get; set; }
    }
}
