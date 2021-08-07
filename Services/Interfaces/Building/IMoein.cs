using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IMoein : IHasGuid, IHasModified
    {
        string Name { get; set; }
        string Code { get; set; }
        Guid KolGuid { get; set; }
        DateTime DateM { get; set; }
        decimal Account { get; set; }
    }
}
