using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IPeoples : IHasGuid, IHasStatus, IHasModified
    {
        string Code { get; set; }
        string Name { get; set; }
        string NationalCode { get; set; }
        string IdCode { get; set; }
        string FatherName { get; set; }
        string PlaceBirth { get; set; }
        string DateBirth { get; set; }
        string Address { get; set; }
        ServerStatus ServerStatus { get; set; }
        DateTime ServerDeliveryDate { get; set; }
        string IssuedFrom { get; set; }
        string PostalCode { get; set; }
        Guid GroupGuid { get; set; }
    }
}
