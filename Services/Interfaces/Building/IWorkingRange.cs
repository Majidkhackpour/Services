using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IWorkingRange : IHasGuid
    {
        Guid RegionGuid { get; set; }
    }
}
