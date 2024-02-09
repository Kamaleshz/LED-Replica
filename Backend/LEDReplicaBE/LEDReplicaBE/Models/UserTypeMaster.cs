using System;
using System.Collections.Generic;

namespace LEDReplicaBE.Models;

public partial class UserTypeMaster
{
    public int UserTypeMasterId { get; set; }

    public string? UserTypeName { get; set; }

    public virtual ICollection<UserType> UserTypes { get; } = new List<UserType>();
}
