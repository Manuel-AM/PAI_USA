using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class Warehouse
{
    public string? Cia { get; set; }

    public string? NumeroBodega { get; set; }

    public string? NombreBodega { get; set; }

    public string? Sucursal { get; set; }

    public bool CierreAnual { get; set; }
}
