using System;
using System.Collections.Generic;

namespace LEDReplicaBE.Models;

public partial class CountryMaster
{
    public int CountryMasterId { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<Country> Countries { get; } = new List<Country>();
}
