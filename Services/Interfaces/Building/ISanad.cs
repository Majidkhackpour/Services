using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface ISanad : IHasGuid
    {
        DateTime DateM { get; set; }
        string Description { get; set; }
        long Number { get; set; }
        EnSanadStatus SanadStatus { get; set; }
        Guid UserGuid { get; set; }
        EnSanadType SanadType { get; set; }
    }
}
