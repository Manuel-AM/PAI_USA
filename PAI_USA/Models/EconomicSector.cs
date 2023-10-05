using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class EconomicSector
{
    public string? Codigo { get; set; }

    public string? Concepto { get; set; }

    public bool CierreAnual { get; set; }
}
