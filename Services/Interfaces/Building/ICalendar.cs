using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface ICalendar : IHasGuid
    {
        DateTime DateM { get; set; }
        string Monasebat { get; set; }
        string Description { get; set; }
        bool isTatil { get; set; }
    }
}
