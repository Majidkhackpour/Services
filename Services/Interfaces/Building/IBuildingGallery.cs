using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IBuildingGallery : IHasGuid, IHasModified
    {
        Guid BuildingGuid { get; set; }
        string ImageName { get; set; }
    }
}
