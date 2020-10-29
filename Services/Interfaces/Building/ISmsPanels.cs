namespace Servicess.Interfaces.Building
{
    public interface ISmsPanels : IHasGuid
    {
        string Name { get; set; }
        string Sender { get; set; }
        string API { get; set; }
    }
}
