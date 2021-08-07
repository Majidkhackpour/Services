using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IPardakht : IHasGuid, IHasModified
    {
        Guid TafsilGuid { get; set; }
        Guid MoeinGuid { get; set; }
        DateTime DateM { get; set; }
        string Description { get; set; }
        Guid UserGuid { get; set; }
        long Number { get; set; }
        long SanadNumber { get; set; }
        decimal SumCheckMoshtari { get; set; }
        decimal SumCheckShakhsi { get; set; }
        decimal SumHavale { get; set; }
        decimal SumNaqd { get; set; }
        decimal Sum { get; set; }
    }
}
