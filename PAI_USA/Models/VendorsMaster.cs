using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class VendorsMaster
{
    public string? Codigo { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Direccion { get; set; }

    public string? Zona { get; set; }

    public string? Colonia { get; set; }

    public string? Ubicacion { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Nit { get; set; }

    public double? Porcentaje { get; set; }

    public string? Cia { get; set; }

    public string? Tipo { get; set; }

    public string? CodigoNomina { get; set; }

    public bool CierreAnual { get; set; }
}
