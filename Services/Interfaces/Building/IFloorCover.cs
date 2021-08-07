namespace Servicess.Interfaces.Building
{
    public interface IFloorCover : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
    }
}
