using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IHesabGroup : IHasGuid
    {
        string Name { get; set; }
        string Code { get; set; }
    }
}
