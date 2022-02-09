using System;
using Services;

namespace Servicess.Interfaces
{
    public interface IHasGuid
    {
        Guid Guid { get; set; }
    }
    public interface IHasStatus
    {
        bool Status { get; set; }
    }
    public interface IHasModified
    {
        DateTime Modified { get; set; }
    }
}
