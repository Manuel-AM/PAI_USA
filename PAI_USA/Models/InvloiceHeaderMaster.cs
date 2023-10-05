using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class InvloiceHeaderMaster
{
    public string? TipoRegistro { get; set; }

    public string? Cia { get; set; }

    public string? CodigoCliente { get; set; }

    public double? NumeroEnvio { get; set; }

    public string? Serie { get; set; }

    public double? NumeroFactura { get; set; }

    public DateTime? Fecha { get; set; }

    public double? SubTotal { get; set; }

    public double? TotalDescuento { get; set; }

    public double? TotalImpuesto { get; set; }

    public double? TotalFactura { get; set; }

    public string? Vendedor { get; set; }

    public double? TotLineasDetalleDoc { get; set; }

    public double? TasaCambio { get; set; }

    public double? SaldoFactura { get; set; }

    public string? NoRecibo { get; set; }

    public bool ComisionCalculada { get; set; }

    public bool CalcularComision { get; set; }

    public double? DiasCr { get; set; }

    public bool CuentaCon { get; set; }

    public bool Anulada { get; set; }

    public string? Periodo { get; set; }

    public string? TipoPoliza { get; set; }

    public double? NoPoliza { get; set; }

    public string? CentroCosto { get; set; }

    public string? AñoPeriodo { get; set; }

    public double? CostoTotal { get; set; }

    public double? PorVen { get; set; }

    public bool Exenta { get; set; }

    public bool Exportacion { get; set; }

    public double? FacturarA { get; set; }

    public string? CuentaDb { get; set; }

    public string? CuentaCr { get; set; }

    public string? Repartidor { get; set; }

    public string? Sucursal { get; set; }

    public string? Camion { get; set; }

    public double? PorcReten { get; set; }

    public double? ValorRetIva { get; set; }

    public string? CuentaRet { get; set; }

    public double? Noreten { get; set; }

    public string? FechaRet { get; set; }

    public double? FactorMobra { get; set; }

    public double? FactorGfabricacion { get; set; }

    public double? FactorOgastos { get; set; }

    public string? NoBatch { get; set; }

    public DateTime? FechaG { get; set; }

    public string? HoraGrabacion { get; set; }

    public bool CierreAnual { get; set; }
}
