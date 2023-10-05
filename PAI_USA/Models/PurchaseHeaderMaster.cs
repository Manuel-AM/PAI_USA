using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class PurchaseHeaderMaster
{
    public string? TipoRegistro { get; set; }

    public string? Cia { get; set; }

    public string? CodigoProveedor { get; set; }

    public double? NumeroOrdenCompra { get; set; }

    public string? Serie { get; set; }

    public double? NumeroFactura { get; set; }

    public DateTime? Fecha { get; set; }

    public double? SubTotal { get; set; }

    public double? TotalImpuesto { get; set; }

    public double? TotalFactura { get; set; }

    public double? TotLineasDetalleDoc { get; set; }

    public double? TasaCambio { get; set; }

    public double? Factor1 { get; set; }

    public double? Factor2 { get; set; }

    public double? Factor3 { get; set; }

    public double? Factor4 { get; set; }

    public double? Factor5 { get; set; }

    public string? TipoCompra { get; set; }

    public double? DiasCr { get; set; }

    public string? Direccion { get; set; }

    public bool ServicioBien { get; set; }

    public string? Periodo { get; set; }

    public string? TipoPoliza { get; set; }

    public double? NoPoliza { get; set; }

    public string? CentroCosto { get; set; }

    public bool CuentaCon { get; set; }

    public string? Bodega { get; set; }

    public string? AñoPeriodo { get; set; }

    public string? Cuenta { get; set; }

    public bool IvanoDeducible { get; set; }

    public double? BaseTotal { get; set; }

    public string? CuentaCr { get; set; }

    public double? Saldo { get; set; }

    public string? Sucursal { get; set; }

    public double? PorcReten { get; set; }

    public double? Noreten { get; set; }

    public string? FechaRet { get; set; }

    public double? ValorRetIva { get; set; }

    public string? Cuentaret { get; set; }

    public double? TcostoUnitarioFob { get; set; }

    public double? TcostoUnitarioFoba { get; set; }

    public double? TcostoUnitarioCif { get; set; }

    public double? TcostoUnitarioCifl { get; set; }

    public double? ComprasTe { get; set; }

    public double? ComprasSe { get; set; }

    public double? ComprasIe { get; set; }

    public double? ComprasOe { get; set; }

    public double? ComprasTl { get; set; }

    public double? ComprasSl { get; set; }

    public double? ComprasIl { get; set; }

    public double? ComprasOl { get; set; }

    public string? CuentaComprasTe { get; set; }

    public string? CuentaComprasSe { get; set; }

    public string? CuentaComprasIe { get; set; }

    public string? CuentaComprasOe { get; set; }

    public string? CuentaComprasTl { get; set; }

    public string? CuentaComprasSl { get; set; }

    public string? CuentaComprasIl { get; set; }

    public string? CuentaComprasOl { get; set; }

    public bool TipoMoneda { get; set; }

    public bool Importacion { get; set; }

    public DateTime? FechaG { get; set; }

    public string? HoraGrabacion { get; set; }

    public bool CierreAnual { get; set; }

    public string? ValorDifCam { get; set; }

    public string? CtaAjusteCdb { get; set; }

    public string? CtaAjusteCcr { get; set; }

    public string? NoContraseña { get; set; }
}
