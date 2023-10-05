using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class AccountPolicyType
{
    public string? Cia { get; set; }

    public string? Codigo { get; set; }

    public string? Concepto { get; set; }

    public double? Correlativo { get; set; }

    public bool Fijo { get; set; }

    public bool CierreAnual { get; set; }
}
