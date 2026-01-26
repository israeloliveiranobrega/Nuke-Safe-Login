using System;
using System.Collections.Generic;
using System.Text;

namespace Nuke_Safe_Login.Domain.Models.Base.Enums
{
    public enum AccountStatus
    {
        Pending = 0,
        Active = 1,
        Inactive = 2,
        Suspended = 3,
        Deleted = 4
    }
}
