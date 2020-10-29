using System;

namespace Servicess.Interfaces.Building
{
    public interface IAdvertiseRelatedRegion : IHasGuid
    {
        string OnlineRegionName { get; set; }
        Guid LocalRegionGuid { get; set; }
    }
}
