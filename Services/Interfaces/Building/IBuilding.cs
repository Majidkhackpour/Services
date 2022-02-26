using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IBuilding : IHasGuid, IHasStatus, IHasModified
    {
        DateTime CreateDate { get; set; }
        string Code { get; set; }
        Guid OwnerGuid { get; set; }
        Guid UserGuid { get; set; }
        decimal SellPrice { get; set; }
        decimal VamPrice { get; set; }
        decimal QestPrice { get; set; }
        int Dang { get; set; }
        Guid? DocumentType { get; set; }
        EnTarakom? Tarakom { get; set; }
        decimal RahnPrice1 { get; set; }
        decimal EjarePrice1 { get; set; }
        Guid? RentalAutorityGuid { get; set; }
        bool? Tabdil { get; set; }
        bool? IsShortTime { get; set; }
        bool? IsOwnerHere { get; set; }
        decimal PishTotalPrice { get; set; }
        decimal PishPrice { get; set; }
        DateTime? DeliveryDate { get; set; }
        int Masahat { get; set; }
        int ZirBana { get; set; }
        Guid CityGuid { get; set; }
        Guid RegionGuid { get; set; }
        string Address { get; set; }
        Guid? BuildingConditionGuid { get; set; }
        EnBuildingSide? Side { get; set; }
        Guid BuildingTypeGuid { get; set; }
        string ShortDesc { get; set; }
        Guid BuildingAccountTypeGuid { get; set; }
        float MetrazhTejari { get; set; }
        Guid? BuildingViewGuid { get; set; }
        Guid? FloorCoverGuid { get; set; }
        Guid? KitchenServiceGuid { get; set; }
        EnKhadamati? Water { get; set; }
        EnKhadamati? Barq { get; set; }
        EnKhadamati? Gas { get; set; }
        EnKhadamati? Tell { get; set; }
        int TedadTabaqe { get; set; }
        int TabaqeNo { get; set; }
        int VahedPerTabaqe { get; set; }
        int VahedNo { get; set; }
        float ErtefaSaqf { get; set; }
        float Hashie { get; set; }
        float Lenght { get; set; }
        float ReformArea { get; set; }
        bool? BuildingPermits { get; set; }
        float WidthOfPassage { get; set; }
        string SaleSakht { get; set; }
        int RoomCount { get; set; }
        EnBuildingPriority Priority { get; set; }
        bool IsArchive { get; set; }
        string Image { get; set; }
        AdvertiseType? AdvertiseType { get; set; }
        string DivarTitle { get; set; }
        string Hiting { get; set; }
        string Colling { get; set; }
        EnVillaType? VillaType { get; set; }
        EnCommericallLicense? CommericallLicense { get; set; }
        string SuitableFor { get; set; }
        string WallCovering { get; set; }
        int TreeCount { get; set; }
        EnConstructionStage? ConstructionStage { get; set; }
        EnBuildingParent? Parent { get; set; }
        ServerStatus ServerStatus { get; set; }
        DateTime ServerDeliveryDate { get; set; }
        Guid? ZoncanGuid { get; set; }
        Guid? WindowGuid { get; set; }
    }
}
