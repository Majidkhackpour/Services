using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IContract : IHasGuid, IHasStatus, IHasModified
    {
        DateTime DateM { get; set; }
        long Code { get; set; }
        string CodeInArchive { get; set; }
        string RealStateCode { get; set; }
        string HologramCode { get; set; }
        bool IsTemp { get; set; }
        Guid FirstSideGuid { get; set; }
        Guid SecondSideGuid { get; set; }
        Guid BuildingGuid { get; set; }
        Guid UserGuid { get; set; }
        int? Term { get; set; }
        DateTime? FromDate { get; set; }
        decimal TotalPrice { get; set; }
        decimal MinorPrice { get; set; }
        string CheckNoTo { get; set; }
        string CheckNo { get; set; }
        string BankName { get; set; }
        string BankNameEjare { get; set; }
        string Shobe { get; set; }
        string ShobeEjare { get; set; }
        DateTime? SarResidTo { get; set; }
        DateTime? SarResid { get; set; }
        decimal CheckPrice1 { get; set; }
        decimal CheckPrice2 { get; set; }
        DateTime? DischargeDate { get; set; }
        DateTime? SetDocDate { get; set; }
        string SetDocPlace { get; set; }
        int SetDocNo { get; set; }
        decimal SarQofli { get; set; }
        decimal FirstSideDelay { get; set; }
        decimal SecondSideDelay { get; set; }
        string Description { get; set; }
        EnRequestType Type { get; set; }
        Guid? BazaryabGuid { get; set; }
        decimal BazaryabPrice { get; set; }
        Guid? Bazaryab2Guid { get; set; }
        decimal Bazaryab2Price { get; set; }
        long SanadNumber { get; set; }
        EnContractBabat fBabat { get; set; }
        EnContractBabat sBabat { get; set; }
        decimal FirstDiscount { get; set; }
        decimal SecondDiscount { get; set; }
        decimal FirstTax { get; set; }
        decimal FirstAvarez { get; set; }
        decimal SecondTax { get; set; }
        decimal SecondAvarez { get; set; }
        decimal FirstTotalPrice { get; set; }
        decimal SecondTotalPrice { get; set; }
        string BuildingPlack { get; set; }
        string BuildingZip { get; set; }
        string SanadSerial { get; set; }
        int PartNo { get; set; }
        int Page { get; set; }
        string Office { get; set; }
        string BuildingNumber { get; set; }
        int ParkingNo { get; set; }
        float ParkingMasahat { get; set; }
        int StoreNo { get; set; }
        float StoreMasahat { get; set; }
        int PhoneLineCount { get; set; }
        string BuildingPhoneNumber { get; set; }
        int PeopleCount { get; set; }
        string PayankarNo { get; set; }
        DateTime? PayankarDate { get; set; }
        decimal PishPrice { get; set; }
        string Witness1 { get; set; }
        string Witness2 { get; set; }
        string BuildingRegistrationNo { get; set; }
        string BuildingRegistrationNoSub { get; set; }
        string BuildingRegistrationNoOrigin { get; set; }
        string BuildingCosumable { get; set; }
        string ManufacturingLicensePlace { get; set; }
        DateTime? ManufacturingLicenseDate { get; set; }
        DateTime? SettlementDate { get; set; }
        decimal AmountOfRent { get; set; }
        string GulidType { get; set; }
        string DocumentAdjust { get; set; }
    }
}
