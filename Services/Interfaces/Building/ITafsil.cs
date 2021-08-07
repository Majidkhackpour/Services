using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface ITafsil : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
        string Code { get; set; }
        string Description { get; set; }
        HesabType HesabType { get; set; }
        DateTime DateM { get; set; }
        decimal Account { get; set; }
        decimal AccountFirst { get; set; }
        bool isSystem { get; set; }
    }
}
