using System;

namespace Services.FilterObjects
{
    public class RequestMatchFilter
    {
        public EnRequestType Type { get; set; } = EnRequestType.None;
        public decimal Price1 { get; set; } = 0;
        public decimal Price2 { get; set; } = 0;
        public int Masahat { get; set; } = 0;
        public int RoomCount { get; set; } = 0;
        public Guid BuildingAccountTypeGuid { get; set; } = Guid.Empty;
        public Guid RegionGuid { get; set; } = Guid.Empty;
    }
}
