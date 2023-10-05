using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class CrmLogIn
{
    public string UserCode { get; set; } = null!;

    public string UserPass { get; set; } = null!;

    public string? Name { get; set; }

    public string? Level { get; set; }

    public string? CiasAccess { get; set; }

    public bool? FullAccess { get; set; }

    public string? VendorCode { get; set; }

    public bool? YearClose { get; set; }

    public int Id { get; set; }
}
