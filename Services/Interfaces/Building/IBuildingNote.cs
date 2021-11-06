using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IBuildingNote : IHasGuid, IHasModified
    {
        Guid BuildingGuid { get; set; }
        string Note { get; set; }
    }
}
