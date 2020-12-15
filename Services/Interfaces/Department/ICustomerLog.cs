using System;
using Services;

namespace Servicess.Interfaces.Department
{
    public interface ICustomerLog : IHasGuid
    {
        DateTime Date { get; set; }
        Guid CustomerGuid { get; set; }
        EnCustomerLogType Side { get; set; }
        string Description { get; set; }
        Guid Parent { get; set; }
        decimal Price { get; set; }
    }
}
