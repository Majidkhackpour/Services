using System;

namespace Services.FilterObjects
{
    public class BuildingReviewFilter
    {
        public Guid? BuildingGuid { get; set; } = null;
        public Guid? CustomerGuid { get; set; } = null;
        public Guid? UserGuid { get; set; } = null;
        public DateTime? Date1 { get; set; } = null;
        public DateTime? Date2 { get; set; } = null;
    }
}
