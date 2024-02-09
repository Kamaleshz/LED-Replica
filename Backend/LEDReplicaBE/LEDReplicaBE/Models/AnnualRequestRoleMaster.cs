using System;
using System.Collections.Generic;

namespace LEDReplicaBE.Models;

public partial class AnnualRequestRoleMaster
{
    public int AnnualRequestRoleMasterId { get; set; }

    public string? AnnualRequestRoleMasterName { get; set; }

    public virtual ICollection<AnnualRequestRole> AnnualRequestRoles { get; } = new List<AnnualRequestRole>();
}
