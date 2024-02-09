using System;
using System.Collections.Generic;

namespace LEDReplicaBE.Models;

public partial class UserType
{
    public int UserTypeId { get; set; }

    public int? UserTypeMasterId { get; set; }

    public int? UserId { get; set; }

    public bool? IsActive { get; set; }

    public virtual User? User { get; set; }

    public virtual UserTypeMaster? UserTypeMaster { get; set; }
}
