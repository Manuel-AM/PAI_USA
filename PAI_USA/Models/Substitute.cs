using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class Substitute
{
    public string Cia { get; set; } = null!;

    public string Alternate { get; set; } = null!;

    public string? Alternate1 { get; set; }

    public string MainItem { get; set; } = null!;

    public string WareHouse { get; set; } = null!;

    public string Branch { get; set; } = null!;

    public bool? YearClose { get; set; }
}
