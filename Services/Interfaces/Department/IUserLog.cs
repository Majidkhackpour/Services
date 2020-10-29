using System;
using Services;

namespace Servicess.Interfaces.Department
{
    public interface IUserLog : IHasGuid
    {
        DateTime Date { get; set; }
        Guid UserGuid { get; set; }
        EnLogType Type { get; set; }
        string Description { get; set; }
    }
}
