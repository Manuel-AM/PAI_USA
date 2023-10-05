using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class TaxesMaster
{
    public string? Cia { get; set; }

    public string? Tipo { get; set; }

    public string? Sector { get; set; }

    public string? Codigo { get; set; }

    public string? Concepto { get; set; }

    public double? ValorImpuesto { get; set; }

    public double? Impuesto { get; set; }

    public string? CuentaCompra { get; set; }

    public string? CuentaImpuesto { get; set; }

    public double? ValorMercado { get; set; }

    public bool CierreAnual { get; set; }

    public string? FacAu { get; set; }

    public bool ConMen { get; set; }

    public string? Mensaje { get; set; }
}
