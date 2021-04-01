using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IPardakhtNaqd : IHasGuid
    {
        string Description { get; set; }
        decimal Price { get; set; }
        Guid SandouqTafsilGuid { get; set; }
        Guid SandouqMoeinGuid { get; set; }
        Guid MasterGuid { get; set; }
    }
}
