using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class CoinsBill
{
    public string? Cia { get; set; }

    public string? Codigo { get; set; }

    public string? Concepto { get; set; }

    public bool BilleteMoneda { get; set; }

    public double? Valor { get; set; }

    public bool CierreAnual { get; set; }
}
