using System;

namespace Servicess.Interfaces.Building
{
    public interface IPeopleGroup : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
        Guid ParentGuid { get; set; }
    }
}
