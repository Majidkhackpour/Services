using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IKol : IHasGuid
    {
        string Name { get; set; }
        Guid GroupGuid { get; set; }
        string Code { get; set; }
        decimal Account { get; set; }
    }
}
