using System;

namespace Servicess.Interfaces.Department
{
    public interface ICustomers : IHasGuid
    {
        DateTime CreateDate { get; set; }
        string Name { get; set; }
        string CompanyName { get; set; }
        string NationalCode { get; set; }
        string AppSerial { get; set; }
        string Address { get; set; }
        string PostalCode { get; set; }
        string Tell1 { get; set; }
        string Tell2 { get; set; }
        string Tell3 { get; set; }
        string Tell4 { get; set; }
        string Email { get; set; }
        string Description { get; set; }
        DateTime ExpireDate { get; set; }
        Guid UserGuid { get; set; }
        decimal Account { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string SiteUrl { get; set; }
        string HardSerial { get; set; }
    }
}
