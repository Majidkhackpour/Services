namespace Servicess.Interfaces.Building
{
    public interface INaqz : IHasGuid
    {
        string Message { get; set; }
        int UseCount { get; set; }
    }
}
