using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IFileInfo : IHasGuid
    {
        string FileName { get; set; }
    }
}
