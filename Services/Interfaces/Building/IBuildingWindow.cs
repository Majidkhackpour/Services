using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IBuildingWindow : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
        ServerStatus ServerStatus { get; set; }
        DateTime ServerDeliveryDate { get; set; }
    }
}
