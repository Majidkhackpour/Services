using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IReceptionNaqd : IHasGuid, IHasModified
    {
        DateTime DateM { get; set; }
        Guid MasterGuid { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        Guid SandouqTafsilGuid { get; set; }
        Guid SandouqMoeinGuid { get; set; }
    }
}
