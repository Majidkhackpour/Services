namespace Servicess.Interfaces.Building
{
    public interface IKitchenService : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
    }
}
