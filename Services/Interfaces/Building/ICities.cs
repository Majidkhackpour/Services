using System;

namespace Servicess.Interfaces.Building
{
    public interface ICities : IHasGuid
    {
        string Name { get; set; }
        Guid StateGuid { get; set; }
    }
}
