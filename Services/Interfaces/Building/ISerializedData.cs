namespace Servicess.Interfaces.Building
{
    public interface ISerializedData : IHasGuid
    {
        string Name { get; set; }
        string Data { get; set; }
    }
}
