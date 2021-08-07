namespace Servicess.Interfaces.Building
{
    public interface IStates : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
    }
}
