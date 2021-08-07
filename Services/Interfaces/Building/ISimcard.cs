using System;

namespace Servicess.Interfaces.Building
{
    public interface ISimcard : IHasGuid, IHasStatus
    {
        long Number { get; set; }
        string Owner { get; set; }
        string Operator { get; set; }
        bool isSheypoorBlocked { get; set; }
        DateTime NextUseSheypoor { get; set; }
        DateTime NextUseDivar { get; set; }
    }
}
