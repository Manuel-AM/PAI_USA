using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class ItemMaster
{
    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public double? PrecioMinimo { get; set; }

    public double? PrecioMaximo { get; set; }

    public string? Estatus { get; set; }

    public string? FormaEmpaque { get; set; }

    public string? UnidadesXempaque { get; set; }

    public double? ExistenciaActualConsolidada { get; set; }

    public double? CostoActualCif { get; set; }

    public double? CostoActualFob { get; set; }

    public string? Linea { get; set; }

    public double? PesoGramos { get; set; }

    public double? Altura { get; set; }

    public double? Longitud { get; set; }

    public double? Ancho { get; set; }

    public double? Precio1 { get; set; }

    public double? Precio2 { get; set; }

    public double? Precio3 { get; set; }

    public double? Precio4 { get; set; }

    public double? Precio5 { get; set; }

    public string? TipoDeInventario { get; set; }

    public bool TieneSerie { get; set; }

    public string? Temp { get; set; }

    public double? ExistenciaMinima { get; set; }

    public double? ExistenciaMaxima { get; set; }

    public double? CostoBodega { get; set; }

    public string? Medida { get; set; }

    public string? Cia { get; set; }

    public string? Descargar { get; set; }

    public string? Moneda { get; set; }

    public string? Casa { get; set; }

    public bool Protegido { get; set; }

    public bool PrecioVp { get; set; }

    public bool Gravado { get; set; }

    public string? FechaD { get; set; }

    public string? FechaH { get; set; }

    public string? HoraD { get; set; }

    public string? HoraH { get; set; }

    public double? MaximoV { get; set; }

    public double? Ventasa { get; set; }

    public bool Valdes { get; set; }

    public double? PrecioP { get; set; }

    public bool OfertaE { get; set; }

    public string? Laboratorio { get; set; }

    public bool Lote { get; set; }

    public double? CostoProveedor { get; set; }

    public bool ImprimirDetalleFormula { get; set; }

    public bool CierreAnual { get; set; }

    public string? CuentaVentas { get; set; }

    public string? CuentaCompras { get; set; }

    public string? DiasVencimiento { get; set; }

    public string? UbicacionF { get; set; }
}
