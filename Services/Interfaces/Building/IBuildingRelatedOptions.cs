using System;

namespace Servicess.Interfaces.Building
{
    public interface IBuildingRelatedOptions : IHasGuid, IHasModified
    {
        Guid BuildinGuid { get; set; }
        Guid BuildingOptionGuid { get; set; }
    }
}
