using System;

namespace Servicess.Interfaces.Building
{
    public interface IBuildingRequestRegion : IHasGuid
    {
        Guid RequestGuid { get; set; }
        Guid RegionGuid { get; set; }
    }
}
