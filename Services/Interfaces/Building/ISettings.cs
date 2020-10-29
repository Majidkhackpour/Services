namespace Servicess.Interfaces.Building
{
    public interface ISettings : IHasGuid
    {
        string Name { get; set; }
        string Value { get; set; }
    }
}
