using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Department
{
    public interface IAndroids : IHasGuid
    {
        Guid CustomerGuid { get; set; }
        string IMEI { get; set; }
        string Name { get; set; }
    }
}
