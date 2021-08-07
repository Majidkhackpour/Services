using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IKol : IHasGuid, IHasModified
    {
        string Name { get; set; }
        EnHesabGroup HesabGroup { get; set; }
        string Code { get; set; }
        decimal Account { get; set; }
    }
}
