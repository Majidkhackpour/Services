using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IDesc : IHasGuid
    {
        string Description { get; set; }
    }
}
