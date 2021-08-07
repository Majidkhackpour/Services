namespace Servicess.Interfaces.Building
{
    public interface IBuildingOptions : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
    }
}
