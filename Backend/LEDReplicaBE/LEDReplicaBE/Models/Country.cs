using System;
using System.Collections.Generic;

namespace LEDReplicaBE.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public int? UserId { get; set; }

    public int? CountryMasterId { get; set; }

    public bool? IsActive { get; set; }

    public virtual CountryMaster? CountryMaster { get; set; }

    public virtual User? User { get; set; }
}
