using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface ISanadDetails : IHasGuid
    {
        Guid MasterGuid { get; set; }
        Guid MoeinGuid { get; set; }
        Guid TafsilGuid { get; set; }
        decimal Debit { get; set; }
        decimal Credit { get; set; }
        string Description { get; set; }
    }
}
