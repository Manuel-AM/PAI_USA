using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class InvoiceDetailMaster
{
    public string? TipoRegistro { get; set; }

    public string? Serie { get; set; }

    public double? NumeroFactura { get; set; }

    public string? CodigoCliente { get; set; }

    public string? CorrelLinea { get; set; }

    public string? Codigo { get; set; }

    public string? Bodega { get; set; }

    public double? Cantidad { get; set; }

    public double? CostoUnitarioProducto { get; set; }

    public double? CostoEstaLinea { get; set; }

    public double? PrecioUnitario { get; set; }

    public double? PrecioLinea { get; set; }

    public double? Impuesto { get; set; }

    public double? DescValorCalculado { get; set; }

    public double? DescPorcentaje { get; set; }

    public double? DescValor { get; set; }

    public bool ComisionCalculada { get; set; }

    public string? Cia { get; set; }

    public string? Sucursal { get; set; }

    public double? Presentacion { get; set; }

    public string? NoBatch { get; set; }

    public bool CierreAnual { get; set; }

    public string? Lote { get; set; }

    public string? FechaFabricacion { get; set; }

    public string? FechaVencimiento { get; set; }

    public string? CuentaVentas { get; set; }

    public string? CuentaCompras { get; set; }
}
