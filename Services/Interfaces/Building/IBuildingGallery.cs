using System;

namespace Servicess.Interfaces.Building
{
    public interface IBuildingGallery : IHasGuid
    {
        Guid BuildingGuid { get; set; }
        string ImageName { get; set; }
    }
}
