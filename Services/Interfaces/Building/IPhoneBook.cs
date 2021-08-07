using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IPhoneBook : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
        string Tell { get; set; }
        string Title { get; set; }
        EnPhoneBookGroup Group { get; set; }
        Guid ParentGuid { get; set; }
    }
}
