﻿using System;
using Services;
using Services.Access;

namespace Servicess.Interfaces.Building
{
    public interface IUsers : IHasGuid, IHasStatus, IHasModified
    {
        string Name { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Access { get; set; }
        EnSecurityQuestion SecurityQuestion { get; set; }
        string AnswerQuestion { get; set; }
        string Email { get; set; }
        string Mobile { get; set; }
        ServerStatus ServerStatus { get; set; }
        DateTime ServerDeliveryDate { get; set; }
    }
}
