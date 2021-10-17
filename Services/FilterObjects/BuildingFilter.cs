using System;
using System.Collections.Generic;

namespace Services.FilterObjects
{
    public class BuildingFilter
    {
        public bool? IsArchive { get; set; } = null;
        public bool Status { get; set; } = false;
        public Guid? BuildingTypeGuid { get; set; } = null;
        public Guid? UserGuid { get; set; } = null;
        public Guid? DocumentTypeGuid { get; set; } = null;
        public Guid? BuildingAccountTypeGuid { get; set; } = null;
        public Guid? OwnerGuid { get; set; } = null;
        public bool IsRahn { get; set; } = false;
        public bool IsFullRahn { get; set; } = false;
        public bool IsSell { get; set; } = false;
        public bool IsMosharekat { get; set; } = false;
        public bool IsPishForoush { get; set; } = false;
        public List<Guid> RegionList { get; set; } = null;
        public AdvertiseType? AdvertiseType { get; set; } = null;
        public int RoomCount1 { get; set; } = 0;
        public int RoomCount2 { get; set; } = 0;
        public int Masahat1 { get; set; } = 0;
        public int Masahat2 { get; set; } = 0;
        public int ZirBana1 { get; set; } = 0;
        public int ZirBana2 { get; set; } = 0;
        public decimal SellPrice1 { get; set; } = 0;
        public decimal SellPrice2 { get; set; } = 0;
        public decimal RahnPrice1 { get; set; } = 0;
        public decimal RahnPrice2 { get; set; } = 0;
        public decimal EjarePrice1 { get; set; } = 0;
        public decimal EjarePrice2 { get; set; } = 0;
        public int MaxTabaqeNo { get; set; } = 0;
    }
}
