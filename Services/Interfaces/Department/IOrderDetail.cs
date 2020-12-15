using System;

namespace Servicess.Interfaces.Department
{
    public interface IOrderDetail : IHasGuid
    {
        Guid OrderGuid { get; set; }
        Guid PrdGuid { get; set; }
        decimal Price { get; set; }
        decimal Discount { get; set; }
        decimal Total { get; set; }
    }
}
