using System;

namespace Servicess.Interfaces.Department
{
    public interface IOrderDetail : IHasGuid
    {
        Guid PrdGuid { get; set; }
        decimal Price { get; set; }
    }
}
