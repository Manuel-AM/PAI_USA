using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class AccountsComent
{
    public string? Cia { get; set; }

    public string? TipoPoliza { get; set; }

    public double? NoPoliza { get; set; }

    public string? Comentario { get; set; }

    public string? Sucursal { get; set; }

    public bool CierreAnual { get; set; }
}
