using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IBank : IHasGuid
    {
        string Code { get; set; }
        string Name { get; set; }
        string Shobe { get; set; }
        string CodeShobe { get; set; }
        string HesabNumber { get; set; }
        string Description { get; set; }
        DateTime DateM { get; set; }
    }
}
