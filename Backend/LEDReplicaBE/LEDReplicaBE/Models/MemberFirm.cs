using System;
using System.Collections.Generic;

namespace LEDReplicaBE.Models;

public partial class MemberFirm
{
    public int MemberFirmId { get; set; }

    public string? MemberFirmName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<RequestLevel> RequestLevels { get; } = new List<RequestLevel>();
}
