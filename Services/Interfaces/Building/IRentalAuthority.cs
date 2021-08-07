namespace Servicess.Interfaces.Building
{
    public interface IRentalAuthority : IHasGuid, IHasModified, IHasStatus
    {
        string Name { get; set; }
    }
}
