using System;

namespace Servicess.Interfaces
{
    public interface IHasGuid
    {
        Guid Guid { get; set; }
        DateTime Modified { get; set; }
        bool Status { get; set; }
    }
}
