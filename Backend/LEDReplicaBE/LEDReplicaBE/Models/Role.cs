using System;
using System.Collections.Generic;

namespace LEDReplicaBE.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public int? UserId { get; set; }

    public int? RoleMasterId { get; set; }

    public bool? IsActive { get; set; }

    public virtual RoleMaster? RoleMaster { get; set; }

    public virtual User? User { get; set; }
}
