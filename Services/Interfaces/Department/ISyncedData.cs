using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Department
{
    public interface ISyncedData : IHasGuid
    {
        Guid ObjectGuid { get; set; }
        string HardSerial { get; set; }
        EnTemp Type { get; set; }
    }
}
