using System;

namespace Servicess.Interfaces.Building
{
    public interface IPeopleGroup : IHasGuid
    {
        string Name { get; set; }
        Guid ParentGuid { get; set; }
    }
}
