﻿using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IReception : IHasGuid
    {
        long Number { get; set; }
        DateTime DateM { get; set; }
        string Description { get; set; }
        Guid TafsilGuid { get; set; }
        Guid MoeinGuid { get; set; }
        Guid UserGuid { get; set; }
        long SanadNumber { get; set; }
    }
}
