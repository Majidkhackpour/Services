using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IBuildingZoncan : IHasGuid, IHasModified, IHasStatus
    {
        string Name { get; set; }
        string Description { get; set; }
        ServerStatus ServerStatus { get; set; }
        DateTime ServerDeliveryDate { get; set; }
    }
}
