using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class PettyCashHeader
{
    public string? TipoRegistro { get; set; }

    public string? Cia { get; set; }

    public DateTime? Fecha { get; set; }

    public double? TotalImpuesto { get; set; }

    public double? TotalFactura { get; set; }

    public double? TasaCambio { get; set; }

    public string? Periodo { get; set; }

    public string? TipoPoliza { get; set; }

    public double? NoPoliza { get; set; }

    public string? CentroCosto { get; set; }

    public bool CierreContable { get; set; }

    public string? AñoPeriodo { get; set; }

    public string? Sucursal { get; set; }

    public double? NoCheque { get; set; }

    public string? NoCajaChica { get; set; }

    public string? FechaGrabacion { get; set; }

    public string? HoraGrabacion { get; set; }

    public bool CierreAnual { get; set; }
}
