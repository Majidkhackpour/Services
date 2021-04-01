using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IAdvisor : IHasGuid
    {
        string Name { get; set; }
        string Address { get; set; }
    }
}
