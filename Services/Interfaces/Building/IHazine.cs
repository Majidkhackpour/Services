namespace Servicess.Interfaces.Building
{
    public interface IHazine : IHasGuid
    {
        string Name { get; set; }
        decimal Account { get; set; }
        decimal AccountFirst { get; set; }
    }
}
