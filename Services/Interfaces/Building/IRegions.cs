using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IRegions : IHasGuid, IHasModified, IHasStatus
    {
        string Name { get; set; }
        Guid CityGuid { get; set; }
        ServerStatus ServerStatus { get; set; }
        DateTime ServerDeliveryDate { get; set; }
    }
}
