using Services;

namespace Servicess.Interfaces.Department
{
    public interface ISafeBox : IHasGuid
    {
        string Name { get; set; }
        EnSafeBox Type { get; set; }
    }
}
