using System;
using System.Collections.Generic;

namespace LEDReplicaBE.Models;

public partial class RequestLevel
{
    public int RequestLevelId { get; set; }

    public string? RequestLevelName { get; set; }

    public int? MemberFirmId { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<AnnualRequestRole> AnnualRequestRoles { get; } = new List<AnnualRequestRole>();

    public virtual MemberFirm? MemberFirm { get; set; }
}
