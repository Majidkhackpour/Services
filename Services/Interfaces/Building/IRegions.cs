using System;

namespace Servicess.Interfaces.Building
{
    public interface IRegions : IHasGuid
    {
        string Name { get; set; }
        Guid CityGuid { get; set; }
    }
}
