using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Department
{
    public interface ISyncedData : IHasGuid
    {
        Guid ObjectGuid { get; set; }
        Guid CustomerGuid { get; set; }
        EnTemp Type { get; set; }
    }
}
