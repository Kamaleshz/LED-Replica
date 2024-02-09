using System;
using System.Collections.Generic;

namespace LEDReplicaBE.Models;

public partial class AnnualRequestRole
{
    public int AnnualRequestRoleId { get; set; }

    public int? RequestLevelId { get; set; }

    public int? AnnualRequestRoleMasterId { get; set; }

    public int? UserId { get; set; }

    public bool? IsActive { get; set; }

    public virtual AnnualRequestRoleMaster? AnnualRequestRoleMaster { get; set; }

    public virtual RequestLevel? RequestLevel { get; set; }

    public virtual User? User { get; set; }
}
