using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IFileInfo : IHasGuid, IHasModified
    {
        string FileName { get; set; }
    }
}
