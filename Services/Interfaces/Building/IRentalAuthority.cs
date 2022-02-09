using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IRentalAuthority : IHasGuid, IHasModified, IHasStatus
    {
        string Name { get; set; }
        ServerStatus ServerStatus { get; set; }
        DateTime ServerDeliveryDate { get; set; }
    }
}
