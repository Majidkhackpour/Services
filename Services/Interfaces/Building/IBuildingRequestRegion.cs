using System;

namespace Servicess.Interfaces.Building
{
    public interface IBuildingRequestRegion : IHasGuid, IHasModified
    {
        Guid RequestGuid { get; set; }
        Guid RegionGuid { get; set; }
    }
}
