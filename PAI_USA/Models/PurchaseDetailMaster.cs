using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class PurchaseDetailMaster
{
    public string? TipoRegistro { get; set; }

    public string? Serie { get; set; }

    public double? NumeroFactura { get; set; }

    public string? CodigoProveedor { get; set; }

    public string? CorrelLinea { get; set; }

    public string? Codigo { get; set; }

    public string? Bodega { get; set; }

    public double? Cantidad { get; set; }

    public double? CantidadBonificacion { get; set; }

    public double? CostoUnitarioProducto { get; set; }

    public double? CostoEstaLinea { get; set; }

    public double? PrecioUnitario { get; set; }

    public double? PrecioLinea { get; set; }

    public double? Impuesto { get; set; }

    public string? Cia { get; set; }

    public string? Sucursal { get; set; }

    public double? CostoUnitarioFob { get; set; }

    public double? CostoUnitarioFoba { get; set; }

    public double? CostoUnitarioCif { get; set; }

    public double? CostoUnitarioCifl { get; set; }

    public bool CierreAnual { get; set; }

    public string? Lote { get; set; }

    public string? FechaFabricacion { get; set; }

    public string? FechaVencimiento { get; set; }

    public string? CuentaVentas { get; set; }

    public string? CuentaCompras { get; set; }
}
