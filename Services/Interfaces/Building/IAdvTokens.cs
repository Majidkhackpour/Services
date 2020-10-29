
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IAdvTokens : IHasGuid
    {
        string Token { get; set; }
        long Number { get; set; }
        AdvertiseType Type { get; set; }
    }
}
