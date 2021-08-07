using System;

namespace Servicess.Interfaces.Building
{
    public interface ICities : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
        Guid StateGuid { get; set; }
    }
}
