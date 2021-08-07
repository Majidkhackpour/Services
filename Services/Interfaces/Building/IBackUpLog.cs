using System;
using Servicess.Interfaces;

namespace Services.Interfaces.Building
{
    public interface IBackUpLog : IHasGuid
    {
        DateTime InsertedDate { get; set; }
        string Path { get; set; }
        EnBackUpType Type { get; set; }
        EnBackUpStatus BackUpStatus { get; set; }
        string StatusDesc { get; set; }
        short Size { get; set; }
    }
}
