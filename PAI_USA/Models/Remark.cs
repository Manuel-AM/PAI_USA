using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class Remark
{
    public string? Cia { get; set; }

    public string? Proveedor { get; set; }

    public string? Serie { get; set; }

    public double? Documento { get; set; }

    public string? Observacion { get; set; }

    public bool CierreAnual { get; set; }

    public string? Observacion1 { get; set; }

    public string? Sucursal { get; set; }
}
