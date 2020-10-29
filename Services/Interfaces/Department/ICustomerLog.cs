using System;

namespace Servicess.Interfaces.Department
{
    public interface ICustomerLog : IHasGuid
    {
        DateTime Date { get; set; }
        Guid CustomerGuid { get; set; }
        string SideName { get; set; }
        string Description { get; set; }
    }
}
