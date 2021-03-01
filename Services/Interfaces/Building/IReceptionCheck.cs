using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IReceptionCheck : IHasGuid
    {
        string BankName { get; set; }
        DateTime DateM { get; set; }
        Guid MasterGuid { get; set; }
        string Description { get; set; }
        string CheckNumber { get; set; }
        string PoshtNomre { get; set; }
        decimal Price { get; set; }
        EnCheckM CheckStatus { get; set; }
    }
}
