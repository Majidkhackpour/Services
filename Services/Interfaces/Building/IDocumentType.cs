namespace Servicess.Interfaces.Building
{
    public interface IDocumentType : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
    }
}
