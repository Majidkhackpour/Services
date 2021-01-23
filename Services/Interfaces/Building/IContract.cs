using System;
using Services;

namespace Servicess.Interfaces.Building
{
    public interface IContract : IHasGuid
    {
        DateTime DateM { get; set; }
        long Code { get; set; }
        bool IsTemp { get; set; }
        Guid FirstSideGuid { get; set; }
        Guid SecondSideGuid { get; set; }
        Guid BuildingGuid { get; set; }
        Guid UserGuid { get; set; }
        int? Term { get; set; }
        DateTime? FromDate { get; set; }
        decimal TotalPrice { get; set; }
        decimal MinorPrice { get; set; }
        string CheckNo { get; set; }
        string BankName { get; set; }
        string Shobe { get; set; }
        string SarResid { get; set; }
        DateTime DischargeDate { get; set; }
        DateTime? SetDocDate { get; set; }
        string SetDocPlace { get; set; }
        decimal SarQofli { get; set; }
        decimal Delay { get; set; }
        string Description { get; set; }
        EnRequestType Type { get; set; }
        Guid BazaryabGuid { get; set; }
        decimal BazaryabPrice { get; set; }
    }
}
