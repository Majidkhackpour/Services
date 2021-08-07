using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IAdvisor : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
        string Address { get; set; }
    }
}
