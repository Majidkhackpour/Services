using System;

namespace Servicess.Interfaces.Building
{
    public interface IRegions : IHasGuid, IHasModified, IHasStatus
    {
        string Name { get; set; }
        Guid CityGuid { get; set; }
    }
}
