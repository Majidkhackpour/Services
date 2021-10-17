using System;

namespace Services.Interfaces.Building
{
    public interface IBuildingRelatedNumber
    {
        Guid BuildingGuid { get; set; }
        string Number { get; set; }
    }
}
