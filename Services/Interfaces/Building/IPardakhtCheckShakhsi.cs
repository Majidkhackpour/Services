using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IPardakhtCheckShakhsi : IHasGuid, IHasModified
    {
        DateTime DateSarResid { get; set; }
        string Description { get; set; }
        string Number { get; set; }
        decimal Price { get; set; }
        DateTime DateM { get; set; }
        Guid CheckPageGuid { get; set; }
        Guid MasterGuid { get; set; }
    }
}
