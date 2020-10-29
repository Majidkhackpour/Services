using Services;

namespace Servicess.Interfaces.Department
{
    public interface IProduct : IHasGuid
    {
        string Name { get; set; }
        string Code { get; set; }
        decimal Price { get; set; }
        decimal BckUpPrice { get; set; }
    }
}
