namespace Servicess.Interfaces.Building
{
    public interface IBuildingView : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
    }
}
