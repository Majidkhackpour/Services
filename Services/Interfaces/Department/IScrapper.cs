using Servicess.Interfaces;

namespace Services.Interfaces.Department
{
    public interface IScrapper : IHasGuid
    {
        string Title { get; set; }
        string Number { get; set; }
        string State { get; set; }
        string City { get; set; }
        string Region { get; set; }
        string BuildingType { get; set; }
        int Masahat { get; set; }
        string SaleSakht { get; set; }
        int RoomCount { get; set; }
        bool Evelator { get; set; }
        bool Parking { get; set; }
        bool Store { get; set; }
        bool Balcony { get; set; }
        decimal RahnPrice { get; set; }
        decimal EjarePrice { get; set; }
        decimal SellPrice { get; set; }
        string RentalAuthority { get; set; }
        int TabaqeCount { get; set; }
        int TabaqeNo { get; set; }
        string Description { get; set; }
        int VahedPerTabaqe { get; set; }
        string BuildingSide { get; set; }
        string ImagesList { get; set; }
    }
}
