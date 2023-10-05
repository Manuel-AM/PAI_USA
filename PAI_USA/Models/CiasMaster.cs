using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class CiasMaster
{
    public string? NumeroCia { get; set; }

    public string? NombreComercial { get; set; }

    public string? RazonSocial { get; set; }

    public bool Auto1Fac { get; set; }

    public string? Tipo1Fac { get; set; }

    public double? Corre1Fac { get; set; }

    public bool Auto2Fac { get; set; }

    public string? Tipo2Fac { get; set; }

    public double? Corre2Fac { get; set; }

    public bool Auto3Fac { get; set; }

    public string? Tipo3Fac { get; set; }

    public double? Corre3Fac { get; set; }

    public bool Auto4Fac { get; set; }

    public string? Tipo4Fac { get; set; }

    public double? Corre4Fac { get; set; }

    public bool Auto5Fac { get; set; }

    public string? Tipo5Fac { get; set; }

    public double? Corre5Fac { get; set; }

    public double? CorrelRecibos { get; set; }

    public string? RegistroPagos { get; set; }

    public string? Bodega { get; set; }

    public bool InterfaseContable { get; set; }

    public double? DigitosCta { get; set; }

    public double? DigitosScta { get; set; }

    public double? DigitosSscta { get; set; }

    public double? DigitosSsscta { get; set; }

    public double? DigitosSssscta { get; set; }

    public double? DigitosSsssscta { get; set; }

    public double? DigitosSssssscta { get; set; }

    public double? LineasxFactura { get; set; }

    public string? Direccion { get; set; }

    public double? Zona { get; set; }

    public string? Colonia { get; set; }

    public string? Ubicacion { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Telefono { get; set; }

    public string? Nit { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public bool Sinocorrelativoclientes { get; set; }

    public double? Correlativoclientes { get; set; }

    public bool Sinocorrelativovendedores { get; set; }

    public double? Correlativovendedores { get; set; }

    public bool Sinocorrelativoenvios { get; set; }

    public double? Correlativoenvios { get; set; }

    public string? NivelPrecio { get; set; }

    public string? Medida { get; set; }

    public string? Tipo { get; set; }

    public string? Empaque { get; set; }

    public double? Tasa { get; set; }

    public double? Iva { get; set; }

    public bool Sinocorrelativoproveedores { get; set; }

    public double? Correlativoproveedores { get; set; }

    public string? Linea { get; set; }

    public string? CuentaProveedores { get; set; }

    public bool SinocorrelativoCompras { get; set; }

    public double? CorrelativoCompras { get; set; }

    public bool SoloPagoExactoFacturaContado { get; set; }

    public string? FechaInventarioFisico { get; set; }

    public string? CuentaCompras { get; set; }

    public double? PorcRetencion { get; set; }

    public string? CuentaIva { get; set; }

    public string? CuentaPerdidasoGanancias { get; set; }

    public string? CuentaDevolucionVentas { get; set; }

    public string? CuentaDevolucionCompras { get; set; }

    public string? CuentaGasto { get; set; }

    public string? CuentaHonorarios { get; set; }

    public double? DiaCierreMensual { get; set; }

    public string? CentroCostoCompras { get; set; }

    public string? Grupo { get; set; }

    public string? CentroCostoVentas { get; set; }

    public double? Factor1 { get; set; }

    public double? Factor2 { get; set; }

    public double? Factor3 { get; set; }

    public double? Factor4 { get; set; }

    public double? Factor5 { get; set; }

    public string? CuentaInventario { get; set; }

    public string? CuentaCostoVentas { get; set; }

    public string? CuentaIvaCompras { get; set; }

    public string? CuentaVentas { get; set; }

    public string? MesAñoUltimoCierre { get; set; }

    public bool PonerCuenta { get; set; }

    public bool Efdecimales { get; set; }

    public string? FechaLote { get; set; }

    public string? PeriodoFiscalI { get; set; }

    public string? PeriodoFiscalF { get; set; }

    public string? Disponible { get; set; }

    public string? Disponible1 { get; set; }

    public string? Propietario { get; set; }

    public string? Contador { get; set; }

    public bool Spr { get; set; }

    public bool TipoPr { get; set; }

    public string? PorcIsr { get; set; }

    public bool TablaImpuesto { get; set; }

    public string? FormatoFactura { get; set; }

    public string? RegistroContador { get; set; }

    public string? PolizaVtas { get; set; }

    public string? PolizaCpas { get; set; }

    public string? PolizaCxc { get; set; }

    public string? PolizaCxp { get; set; }

    public string? PolizaPla { get; set; }

    public string? PolizaAcF { get; set; }

    public string? PolizaBan { get; set; }

    public string? PolizaInv { get; set; }

    public string? PolizaPro { get; set; }

    public string? PolizaCac { get; set; }

    public string? CuentaExentas { get; set; }

    public string? CuentaExentasCr { get; set; }

    public double? Tasa1 { get; set; }

    public bool SiNoCorrelativoRecibos { get; set; }

    public string? CuentaIsr { get; set; }

    public string? CuentaVentasContado { get; set; }

    public bool ReportesProtegidos { get; set; }

    public bool ImpresionConsolidada { get; set; }

    public bool CobrarAlFacturar { get; set; }

    public string? CuentaDppventas { get; set; }

    public string? CuentaDppcompras { get; set; }

    public bool DescargarInventario { get; set; }

    public string? CuentaAplicarventas { get; set; }

    public string? CuentaAplicarCompras { get; set; }

    public bool SinocorrelativoNotas { get; set; }

    public double? CorrelativoNotas { get; set; }

    public string? FormatoEnvio { get; set; }

    public bool InterfaseBanco { get; set; }

    public bool SinocorrelativoCheques { get; set; }

    public double? CorrelativoCheques { get; set; }

    public bool InterfaseCxp { get; set; }

    public string? FormatoOc { get; set; }

    public double? AcumuladoIva { get; set; }

    public double? CorrelativoCotizaciones { get; set; }

    public string? FormatoCotiz { get; set; }

    public bool SinocorrelativoCotizaciones { get; set; }

    public string? Moneda { get; set; }

    public string? SerieDevoluciones { get; set; }

    public double? CorrelativoDevoluciones { get; set; }

    public string? FormatoDevoluciones { get; set; }

    public bool SinocorrelativoDevoluciones { get; set; }

    public bool OpcionImpresionEnvio { get; set; }

    public bool OpcionImpresionFactura { get; set; }

    public bool OpcionImpresionCotizacion { get; set; }

    public bool OpcionImpresionDevolucion { get; set; }

    public bool OpcionImpresionAnulacion { get; set; }

    public bool OpcionImpresionEliminacion { get; set; }

    public string? SerieAnulaciones { get; set; }

    public double? CorrelativoAnulaciones { get; set; }

    public string? FormatoAnulaciones { get; set; }

    public bool SinocorrelativoAnulaciones { get; set; }

    public string? SerieEliminaciones { get; set; }

    public double? CorrelativoEliminaciones { get; set; }

    public string? FormatoEliminaciones { get; set; }

    public bool SinocorrelativoEliminaciones { get; set; }

    public bool DescargarInvPedido { get; set; }

    public string? SerieAjustesMas { get; set; }

    public double? CorrelativoAjustesMas { get; set; }

    public string? FormatoAjustesMas { get; set; }

    public bool SinocorrelativoAjustesMas { get; set; }

    public string? SerieAjustesMenos { get; set; }

    public double? CorrelativoAjustesMenos { get; set; }

    public string? FormatoAjustesMenos { get; set; }

    public bool SinocorrelativoAjustesMenos { get; set; }

    public bool ProcesoFacturasPorRecuperar { get; set; }

    public bool FacturarSe { get; set; }

    public bool Lotes { get; set; }

    public bool EnviosCxC { get; set; }

    public bool OpcionFormatoDevolucion { get; set; }

    public bool OpcionFormatoAnulacion { get; set; }

    public bool OpcionFormatoEliminacion { get; set; }

    public string? ValorRetP { get; set; }

    public string? ValorRetU { get; set; }

    public string? CorrelRet { get; set; }

    public bool AgenteR { get; set; }

    public string? NombreMoneda { get; set; }

    public bool DocuEliEnv { get; set; }

    public bool ProcesoRetencion { get; set; }

    public string? FechaIr { get; set; }

    public double? CorrelProduccion { get; set; }

    public DateTime? FechaProduccion { get; set; }

    public string? LogoEmpresa { get; set; }

    public string? FormatoOrdenProduccion { get; set; }

    public string? FormatoFacturasE { get; set; }

    public string? FormatoRecibos { get; set; }

    public string? Exactos { get; set; }

    public bool OpcionImpresionOrdenesC { get; set; }

    public bool OpcionImpresionAjustesMas { get; set; }

    public bool OpcionImpresionFacturasE { get; set; }

    public bool OpcionImpresionOrdenesP { get; set; }

    public bool OpcionImpresionRecibosC { get; set; }

    public bool ImprimirRecibos { get; set; }

    public bool OpcionImpresionCheques { get; set; }

    public string? FormatoCheques { get; set; }

    public string? ImpresoraEn { get; set; }

    public string? ImpresoraFn { get; set; }

    public string? ImpresoraFe { get; set; }

    public string? ImpresoraAn { get; set; }

    public string? ImpresoraEl { get; set; }

    public string? ImpresoraDe { get; set; }

    public string? ImpresoraAj { get; set; }

    public string? ImpresoraOp { get; set; }

    public string? ImpresoraCo { get; set; }

    public string? ImpresoraOc { get; set; }

    public string? ImpresoraRc { get; set; }

    public string? ImpresoraCh { get; set; }

    public bool PonerUlen { get; set; }

    public bool PonerUlfn { get; set; }

    public bool PonerUlfe { get; set; }

    public bool PonerUlan { get; set; }

    public bool PonerUlel { get; set; }

    public bool PonerUlde { get; set; }

    public bool PonerUlaj { get; set; }

    public bool PonerUlop { get; set; }

    public bool PonerUlco { get; set; }

    public bool PonerUloc { get; set; }

    public bool PonerUlrc { get; set; }

    public bool PonerUlch { get; set; }

    public bool FacEmn { get; set; }

    public string? CuentaCajaChica { get; set; }

    public string? FormatoEstadoCuenta { get; set; }

    public string? FormatoEstadoCuenta1 { get; set; }

    public bool OpcionImpresionEstadoCuenta { get; set; }

    public bool OpcionImpresionEstadoCuenta1 { get; set; }

    public string? ImpresoraEc { get; set; }

    public string? ImpresoraEc1 { get; set; }

    public bool PonerUlec { get; set; }

    public bool PonerUlec1 { get; set; }

    public double? FactorMobra { get; set; }

    public double? FactorGfabricacion { get; set; }

    public double? FactorOgastos { get; set; }

    public string? TipoCostoProduccion { get; set; }

    public string? NivelPrecioProduccion { get; set; }

    public string? CuentaComprasTe { get; set; }

    public string? CuentaComprasSe { get; set; }

    public string? CuentaComprasIe { get; set; }

    public string? CuentaComprasOe { get; set; }

    public string? CuentaComprasTl { get; set; }

    public string? CuentaComprasSl { get; set; }

    public string? CuentaComprasIl { get; set; }

    public string? CuentaComprasOl { get; set; }

    public bool ControlPminimo { get; set; }

    public bool CierreAnual { get; set; }

    public bool InterfasePlanilla { get; set; }

    public bool InterfaseProduccion { get; set; }

    public string? CuentasPolizaBancos { get; set; }

    public bool ContabilidadXproducto { get; set; }

    public bool ActualizaCompras { get; set; }

    public string? CuentaIvaComprasExportacion { get; set; }

    public string? CuentaIvaVentasExportacion { get; set; }

    public string? CuentaCostoVentasExportacion { get; set; }
}
