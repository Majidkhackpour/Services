using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IBankSegest : IHasGuid
    {
        string BankName { get; set; }
    }
}
