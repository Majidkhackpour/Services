namespace Servicess.Interfaces.Building
{
    public interface IBuildingAccountType : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
    }
}
