namespace Servicess.Interfaces.Building
{
    public interface IBuildingType : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
    }
}
