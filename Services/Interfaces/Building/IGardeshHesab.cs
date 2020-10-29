﻿using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IGardeshHesab : IHasGuid
    {
        Guid PeopleGuid { get; set; }
        decimal Price { get; set; }
        EnAccountType Type { get; set; }
        EnAccountBabat Babat { get; set; }
        string Description { get; set; }
        Guid ParentGuid { get; set; }
    }
}
