using System;

namespace Servicess.Interfaces.Department
{
    public interface IOrder : IHasGuid
    {
        DateTime Date { get; set; }
        Guid CustomerGuid { get; set; }
        Guid UserGuid { get; set; }
        string ContractCode { get; set; }
        string Version { get; set; }
        int LearningCount { get; set; }
        decimal Sum { get; set; }
        decimal Discount { get; set; }
        decimal Total { get; set; }
    }
}
