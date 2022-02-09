using System;

namespace Services.Settings.GlobalSettings
{
    public class CompanyInfo
    {
        public string EconomyName { get; set; }
        public string EconomyType { get; set; }
        public string ManagerMobile { get; set; }
        public string ManagerName { get; set; }
        public string ManagerTell { get; set; }
        public string ManagerFax { get; set; }
        public string ManagerEmail { get; set; }
        public Guid ManagerRegion { get; set; }
        public string ManagerAddress { get; set; }
        public Guid EconomyState { get; set; }
        public Guid EconomyCity { get; set; }
    }
}
