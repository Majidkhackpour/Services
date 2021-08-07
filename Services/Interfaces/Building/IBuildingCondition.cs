namespace Servicess.Interfaces.Building
{
    public interface IBuildingCondition : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
    }
}
