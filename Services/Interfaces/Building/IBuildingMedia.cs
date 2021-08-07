using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IBuildingMedia : IHasGuid
    {
        Guid BuildingGuid { get; set; }
        string MediaName { get; set; }
    }
}
