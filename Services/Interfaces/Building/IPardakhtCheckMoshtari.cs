using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IPardakhtCheckMoshtari : IHasGuid
    {
        string Description { get; set; }
        Guid CheckGuid { get; set; }
        Guid MasterGuid { get; set; }
    }
}
