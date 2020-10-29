using System;
using Services;

namespace Servicess.Interfaces.Department
{
    public interface IReception : IHasGuid
    {
        DateTime Date { get; set; }
        Guid CustomerGuid { get; set; }
        Guid UserGuid { get; set; }
        decimal Price { get; set; }
        EnReceptionType Type { get; set; }
        string ResidNo { get; set; }
        string PeygiriNo { get; set; }
        Guid SafeBoxGuid { get; set; }
        string Description { get; set; }
    }
}
