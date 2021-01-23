using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface ITemp : IHasGuid
    {
        EnTemp Type { get; set; }
        Guid ObjectGuid { get; set; }
    }
}
