using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IBuildingReview : IHasGuid, IHasModified, IHasStatus
    {
        Guid BuildingGuid { get; set; }
        Guid UserGuid { get; set; }
        Guid CustometGuid { get; set; }
        DateTime Date { get; set; }
        string Report { get; set; }
        ServerStatus ServerStatus { get; set; }
        DateTime ServerDeliveryDate { get; set; }
    }
}
