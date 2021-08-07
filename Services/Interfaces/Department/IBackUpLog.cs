using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Department
{
    public interface IBackUpLog : IHasGuid
    {
        DateTime CreateDate { get; set; }
        Guid CustomerGuid { get; set; }
        string FileName { get; set; }
        double FileLength { get; set; }
        string URL { get; set; }
    }
}
