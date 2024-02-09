using System;
using System.Collections.Generic;

namespace LEDReplicaBE.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<AnnualRequestRole> AnnualRequestRoles { get; } = new List<AnnualRequestRole>();

    public virtual ICollection<Country> Countries { get; } = new List<Country>();

    public virtual ICollection<Role> Roles { get; } = new List<Role>();

    public virtual ICollection<UserType> UserTypes { get; } = new List<UserType>();
}
