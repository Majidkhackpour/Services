using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IPeopleGroup : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
        Guid ParentGuid { get; set; }
        ServerStatus ServerStatus { get; set; }
        DateTime ServerDeliveryDate { get; set; }
    }
}
