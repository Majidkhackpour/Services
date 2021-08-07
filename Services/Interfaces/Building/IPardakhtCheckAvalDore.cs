using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IPardakhtCheckAvalDore : IHasGuid, IHasModified
    {
        string DasteCheckName { get; set; }
        Guid CheckPageGuid { get; set; }
        Guid TafsilGuid { get; set; }
        Guid UserGuid { get; set; }
    }
}
