using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IStates : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
        ServerStatus ServerStatus { get; set; }
        DateTime ServerDeliveryDate { get; set; }
    }
}
