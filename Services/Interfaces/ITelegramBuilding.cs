using System;

namespace Services.Interfaces
{
    public interface ITelegramBuilding
    {
        Guid BuildingGuid { get; set; }
        string BotApi { get; set; }
        string Channel { get; set; }
        string Content { get; set; }
    }
}
