using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface ICities : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
        Guid StateGuid { get; set; }
        ServerStatus ServerStatus { get; set; }
        DateTime ServerDeliveryDate { get; set; }
    }
}
