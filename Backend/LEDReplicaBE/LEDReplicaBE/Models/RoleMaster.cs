using System;
using System.Collections.Generic;

namespace LEDReplicaBE.Models;

public partial class RoleMaster
{
    public int RoleMasterId { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<Role> Roles { get; } = new List<Role>();
}
