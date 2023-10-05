using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class PettyCashDetail
{
    public string? TipoRegistro { get; set; }

    public string? Serie { get; set; }

    public double? NumeroFactura { get; set; }

    public string? CodigoProveedor { get; set; }

    public string? CorrelLinea { get; set; }

    public double? Total { get; set; }

    public double? Impuesto { get; set; }

    public bool ServicioBien { get; set; }

    public DateTime? Fecha { get; set; }

    public string? CentroCosto { get; set; }

    public bool IvanoDeducible { get; set; }

    public string? CuentaDb { get; set; }

    public string? CuentaCr { get; set; }

    public string? TipoPoliza { get; set; }

    public double? NoPoliza { get; set; }

    public string? Sucursal { get; set; }

    public string? NoCajaChica { get; set; }

    public string? Cia { get; set; }

    public double? Saldo { get; set; }

    public double? Iva { get; set; }

    public double? ValorImpuesto { get; set; }

    public double? Cantidad { get; set; }

    public double? CalculoIva { get; set; }

    public double? BaseTotal { get; set; }

    public bool CierreAnual { get; set; }
}
