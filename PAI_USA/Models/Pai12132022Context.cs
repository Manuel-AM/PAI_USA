using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PAI_USA.Models;

public partial class Pai12132022Context : DbContext
{
    public Pai12132022Context()
    {
    }

    public Pai12132022Context(DbContextOptions<Pai12132022Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountCatalogBranch> AccountCatalogBranches { get; set; }

    public virtual DbSet<AccountCatalogEnterprise> AccountCatalogEnterprises { get; set; }

    public virtual DbSet<AccountCatalogGeneral> AccountCatalogGenerals { get; set; }

    public virtual DbSet<AccountPolicyType> AccountPolicyTypes { get; set; }

    public virtual DbSet<AccountsComent> AccountsComents { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<CiasMaster> CiasMasters { get; set; }

    public virtual DbSet<ClientsMaster> ClientsMasters { get; set; }

    public virtual DbSet<CoinsBill> CoinsBills { get; set; }

    public virtual DbSet<Control> Controls { get; set; }

    public virtual DbSet<CrmLogIn> CrmLogIns { get; set; }

    public virtual DbSet<EconomicSector> EconomicSectors { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<InvloiceHeaderMaster> InvloiceHeaderMasters { get; set; }

    public virtual DbSet<InvoiceDetailMaster> InvoiceDetailMasters { get; set; }

    public virtual DbSet<ItemMaster> ItemMasters { get; set; }

    public virtual DbSet<ItemsInternalConcept> ItemsInternalConcepts { get; set; }

    public virtual DbSet<ManagersLink> ManagersLinks { get; set; }

    public virtual DbSet<PayGovernance> PayGovernances { get; set; }

    public virtual DbSet<PettyCashDetail> PettyCashDetails { get; set; }

    public virtual DbSet<PettyCashHeader> PettyCashHeaders { get; set; }

    public virtual DbSet<PurchaseDetailMaster> PurchaseDetailMasters { get; set; }

    public virtual DbSet<PurchaseHeaderMaster> PurchaseHeaderMasters { get; set; }

    public virtual DbSet<Remark> Remarks { get; set; }

    public virtual DbSet<Scale> Scales { get; set; }

    public virtual DbSet<SearchWordFileLocal> SearchWordFileLocals { get; set; }

    public virtual DbSet<Substitute> Substitutes { get; set; }

    public virtual DbSet<SuppliersMaster> SuppliersMasters { get; set; }

    public virtual DbSet<TaxesMaster> TaxesMasters { get; set; }

    public virtual DbSet<VendorsMaster> VendorsMasters { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SOFGRA-DELL-LAP\\SQLEXPRESS;Database=PAI 12/13/2022;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountCatalogBranch>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Concepto).HasMaxLength(255);
            entity.Property(e => e.CuentaResultadoAnual).HasMaxLength(255);
            entity.Property(e => e.FechaI).HasMaxLength(255);
            entity.Property(e => e.FlujoE).HasMaxLength(255);
            entity.Property(e => e.NumeroCuenta).HasMaxLength(255);
            entity.Property(e => e.Sucursal).HasMaxLength(255);
        });

        modelBuilder.Entity<AccountCatalogEnterprise>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AccountCatalogEnterprise");

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Concepto).HasMaxLength(255);
            entity.Property(e => e.CuentaResultadoAnual).HasMaxLength(255);
            entity.Property(e => e.FechaI).HasMaxLength(255);
            entity.Property(e => e.FlujoE).HasMaxLength(255);
            entity.Property(e => e.NumeroCuenta).HasMaxLength(255);
        });

        modelBuilder.Entity<AccountCatalogGeneral>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AccountCatalogGeneral");

            entity.Property(e => e.Concepto).HasMaxLength(255);
            entity.Property(e => e.CuentaResultadoAnual).HasMaxLength(255);
            entity.Property(e => e.FechaI).HasMaxLength(255);
            entity.Property(e => e.FlujoE).HasMaxLength(255);
            entity.Property(e => e.NumeroCuenta).HasMaxLength(255);
        });

        modelBuilder.Entity<AccountPolicyType>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.Concepto).HasMaxLength(255);
        });

        modelBuilder.Entity<AccountsComent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AccountsComent");

            entity.Property(e => e.Cia)
                .HasMaxLength(255)
                .HasColumnName("cia");
            entity.Property(e => e.Comentario).HasMaxLength(255);
            entity.Property(e => e.Sucursal).HasMaxLength(255);
            entity.Property(e => e.TipoPoliza).HasMaxLength(255);
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BankCode).HasMaxLength(3);
            entity.Property(e => e.BankName).HasMaxLength(128);
            entity.Property(e => e.LiteralConstant).HasMaxLength(32);
            entity.Property(e => e.PayCode).HasMaxLength(255);
            entity.Property(e => e.TaxAssociate).HasMaxLength(32);
            entity.Property(e => e.TaxType).HasMaxLength(32);
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.Comentario).HasMaxLength(255);
            entity.Property(e => e.Comentario1).HasMaxLength(255);
            entity.Property(e => e.Concepto).HasMaxLength(255);
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.CierreAnual).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.Concepto).HasMaxLength(255);
        });

        modelBuilder.Entity<CiasMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CiasMaster");

            entity.Property(e => e.AcumuladoIva).HasColumnName("AcumuladoIVA");
            entity.Property(e => e.Bodega).HasMaxLength(255);
            entity.Property(e => e.CentroCostoCompras).HasMaxLength(255);
            entity.Property(e => e.CentroCostoVentas).HasMaxLength(255);
            entity.Property(e => e.CodigoPostal).HasMaxLength(255);
            entity.Property(e => e.Colonia).HasMaxLength(255);
            entity.Property(e => e.ContabilidadXproducto).HasColumnName("ContabilidadXProducto");
            entity.Property(e => e.Contador).HasMaxLength(255);
            entity.Property(e => e.ControlPminimo).HasColumnName("ControlPMinimo");
            entity.Property(e => e.CorrelRet).HasMaxLength(255);
            entity.Property(e => e.CorrelativoCheques).HasColumnName("correlativoCheques");
            entity.Property(e => e.CorrelativoCompras).HasColumnName("correlativoCompras");
            entity.Property(e => e.CorrelativoNotas).HasColumnName("correlativoNotas");
            entity.Property(e => e.Correlativoclientes).HasColumnName("correlativoclientes");
            entity.Property(e => e.Correlativoenvios).HasColumnName("correlativoenvios");
            entity.Property(e => e.Correlativoproveedores).HasColumnName("correlativoproveedores");
            entity.Property(e => e.Correlativovendedores).HasColumnName("correlativovendedores");
            entity.Property(e => e.CuentaAplicarCompras).HasMaxLength(255);
            entity.Property(e => e.CuentaAplicarventas).HasMaxLength(255);
            entity.Property(e => e.CuentaCajaChica).HasMaxLength(255);
            entity.Property(e => e.CuentaCompras).HasMaxLength(255);
            entity.Property(e => e.CuentaComprasIe)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasIE");
            entity.Property(e => e.CuentaComprasIl)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasIL");
            entity.Property(e => e.CuentaComprasOe)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasOE");
            entity.Property(e => e.CuentaComprasOl)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasOL");
            entity.Property(e => e.CuentaComprasSe)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasSE");
            entity.Property(e => e.CuentaComprasSl)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasSL");
            entity.Property(e => e.CuentaComprasTe)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasTE");
            entity.Property(e => e.CuentaComprasTl)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasTL");
            entity.Property(e => e.CuentaCostoVentas).HasMaxLength(255);
            entity.Property(e => e.CuentaCostoVentasExportacion).HasMaxLength(255);
            entity.Property(e => e.CuentaDevolucionCompras).HasMaxLength(255);
            entity.Property(e => e.CuentaDevolucionVentas).HasMaxLength(255);
            entity.Property(e => e.CuentaDppcompras)
                .HasMaxLength(255)
                .HasColumnName("CuentaDPPCompras");
            entity.Property(e => e.CuentaDppventas)
                .HasMaxLength(255)
                .HasColumnName("CuentaDPPventas");
            entity.Property(e => e.CuentaExentas).HasMaxLength(255);
            entity.Property(e => e.CuentaExentasCr).HasMaxLength(255);
            entity.Property(e => e.CuentaGasto).HasMaxLength(255);
            entity.Property(e => e.CuentaHonorarios).HasMaxLength(255);
            entity.Property(e => e.CuentaInventario).HasMaxLength(255);
            entity.Property(e => e.CuentaIsr)
                .HasMaxLength(255)
                .HasColumnName("CuentaISR");
            entity.Property(e => e.CuentaIva).HasMaxLength(255);
            entity.Property(e => e.CuentaIvaCompras).HasMaxLength(255);
            entity.Property(e => e.CuentaIvaComprasExportacion).HasMaxLength(255);
            entity.Property(e => e.CuentaIvaVentasExportacion).HasMaxLength(255);
            entity.Property(e => e.CuentaPerdidasoGanancias).HasMaxLength(255);
            entity.Property(e => e.CuentaProveedores).HasMaxLength(255);
            entity.Property(e => e.CuentaVentas).HasMaxLength(255);
            entity.Property(e => e.CuentaVentasContado).HasMaxLength(255);
            entity.Property(e => e.CuentasPolizaBancos).HasMaxLength(255);
            entity.Property(e => e.DigitosScta).HasColumnName("DigitosSCta");
            entity.Property(e => e.DigitosSscta).HasColumnName("DigitosSSCta");
            entity.Property(e => e.DigitosSsscta).HasColumnName("DigitosSSSCta");
            entity.Property(e => e.DigitosSssscta).HasColumnName("DigitosSSSSCta");
            entity.Property(e => e.DigitosSsssscta).HasColumnName("DigitosSSSSSCta");
            entity.Property(e => e.DigitosSssssscta).HasColumnName("DigitosSSSSSSCta");
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Disponible).HasMaxLength(255);
            entity.Property(e => e.Disponible1).HasMaxLength(255);
            entity.Property(e => e.Efdecimales).HasColumnName("EFDecimales");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMail");
            entity.Property(e => e.Empaque).HasMaxLength(255);
            entity.Property(e => e.Exactos).HasMaxLength(255);
            entity.Property(e => e.FacEmn).HasColumnName("FacEMn");
            entity.Property(e => e.FactorGfabricacion).HasColumnName("FactorGFabricacion");
            entity.Property(e => e.FactorMobra).HasColumnName("FactorMObra");
            entity.Property(e => e.FactorOgastos).HasColumnName("FactorOGastos");
            entity.Property(e => e.FacturarSe).HasColumnName("FacturarSE");
            entity.Property(e => e.Fax).HasMaxLength(255);
            entity.Property(e => e.FechaInventarioFisico).HasMaxLength(255);
            entity.Property(e => e.FechaIr)
                .HasMaxLength(255)
                .HasColumnName("FechaIR");
            entity.Property(e => e.FechaLote).HasMaxLength(255);
            entity.Property(e => e.FechaProduccion).HasColumnType("datetime");
            entity.Property(e => e.FormatoAjustesMas).HasMaxLength(255);
            entity.Property(e => e.FormatoAjustesMenos).HasMaxLength(255);
            entity.Property(e => e.FormatoAnulaciones).HasMaxLength(255);
            entity.Property(e => e.FormatoCheques).HasMaxLength(255);
            entity.Property(e => e.FormatoCotiz).HasMaxLength(255);
            entity.Property(e => e.FormatoDevoluciones).HasMaxLength(255);
            entity.Property(e => e.FormatoEliminaciones).HasMaxLength(255);
            entity.Property(e => e.FormatoEnvio).HasMaxLength(255);
            entity.Property(e => e.FormatoEstadoCuenta).HasMaxLength(255);
            entity.Property(e => e.FormatoEstadoCuenta1).HasMaxLength(255);
            entity.Property(e => e.FormatoFactura).HasMaxLength(255);
            entity.Property(e => e.FormatoFacturasE).HasMaxLength(255);
            entity.Property(e => e.FormatoOc)
                .HasMaxLength(255)
                .HasColumnName("FormatoOC");
            entity.Property(e => e.FormatoOrdenProduccion).HasMaxLength(255);
            entity.Property(e => e.FormatoRecibos).HasMaxLength(255);
            entity.Property(e => e.Grupo).HasMaxLength(255);
            entity.Property(e => e.ImpresoraAj).HasMaxLength(255);
            entity.Property(e => e.ImpresoraAn).HasMaxLength(255);
            entity.Property(e => e.ImpresoraCh).HasMaxLength(255);
            entity.Property(e => e.ImpresoraCo).HasMaxLength(255);
            entity.Property(e => e.ImpresoraDe).HasMaxLength(255);
            entity.Property(e => e.ImpresoraEc)
                .HasMaxLength(255)
                .HasColumnName("ImpresoraEC");
            entity.Property(e => e.ImpresoraEc1)
                .HasMaxLength(255)
                .HasColumnName("ImpresoraEC1");
            entity.Property(e => e.ImpresoraEl).HasMaxLength(255);
            entity.Property(e => e.ImpresoraEn).HasMaxLength(255);
            entity.Property(e => e.ImpresoraFe)
                .HasMaxLength(255)
                .HasColumnName("ImpresoraFE");
            entity.Property(e => e.ImpresoraFn)
                .HasMaxLength(255)
                .HasColumnName("ImpresoraFN");
            entity.Property(e => e.ImpresoraOc)
                .HasMaxLength(255)
                .HasColumnName("ImpresoraOC");
            entity.Property(e => e.ImpresoraOp)
                .HasMaxLength(255)
                .HasColumnName("ImpresoraOP");
            entity.Property(e => e.ImpresoraRc)
                .HasMaxLength(255)
                .HasColumnName("ImpresoraRC");
            entity.Property(e => e.Iva).HasColumnName("IVA");
            entity.Property(e => e.Linea)
                .HasMaxLength(255)
                .HasColumnName("linea");
            entity.Property(e => e.LogoEmpresa).HasMaxLength(255);
            entity.Property(e => e.Medida).HasMaxLength(255);
            entity.Property(e => e.MesAñoUltimoCierre).HasMaxLength(255);
            entity.Property(e => e.Moneda).HasMaxLength(255);
            entity.Property(e => e.Nit).HasMaxLength(255);
            entity.Property(e => e.NivelPrecio).HasMaxLength(255);
            entity.Property(e => e.NivelPrecioProduccion).HasMaxLength(255);
            entity.Property(e => e.NombreComercial).HasMaxLength(255);
            entity.Property(e => e.NombreMoneda).HasMaxLength(255);
            entity.Property(e => e.NumeroCia).HasMaxLength(255);
            entity.Property(e => e.PeriodoFiscalF).HasMaxLength(255);
            entity.Property(e => e.PeriodoFiscalI).HasMaxLength(255);
            entity.Property(e => e.PolizaAcF).HasMaxLength(255);
            entity.Property(e => e.PolizaBan).HasMaxLength(255);
            entity.Property(e => e.PolizaCac).HasMaxLength(255);
            entity.Property(e => e.PolizaCpas).HasMaxLength(255);
            entity.Property(e => e.PolizaCxc).HasMaxLength(255);
            entity.Property(e => e.PolizaCxp).HasMaxLength(255);
            entity.Property(e => e.PolizaInv).HasMaxLength(255);
            entity.Property(e => e.PolizaPla).HasMaxLength(255);
            entity.Property(e => e.PolizaPro).HasMaxLength(255);
            entity.Property(e => e.PolizaVtas).HasMaxLength(255);
            entity.Property(e => e.PonerUlaj).HasColumnName("PonerULAj");
            entity.Property(e => e.PonerUlan).HasColumnName("PonerULAn");
            entity.Property(e => e.PonerUlch).HasColumnName("PonerULCh");
            entity.Property(e => e.PonerUlco).HasColumnName("PonerULCo");
            entity.Property(e => e.PonerUlde).HasColumnName("PonerULDe");
            entity.Property(e => e.PonerUlec).HasColumnName("PonerULEC");
            entity.Property(e => e.PonerUlec1).HasColumnName("PonerULEC1");
            entity.Property(e => e.PonerUlel).HasColumnName("PonerULEl");
            entity.Property(e => e.PonerUlen).HasColumnName("PonerULEn");
            entity.Property(e => e.PonerUlfe).HasColumnName("PonerULFE");
            entity.Property(e => e.PonerUlfn).HasColumnName("PonerULFN");
            entity.Property(e => e.PonerUloc).HasColumnName("PonerULOC");
            entity.Property(e => e.PonerUlop).HasColumnName("PonerULOP");
            entity.Property(e => e.PonerUlrc).HasColumnName("PonerULRC");
            entity.Property(e => e.PorcIsr)
                .HasMaxLength(255)
                .HasColumnName("PorcISR");
            entity.Property(e => e.Propietario).HasMaxLength(255);
            entity.Property(e => e.RazonSocial).HasMaxLength(255);
            entity.Property(e => e.RegistroContador).HasMaxLength(255);
            entity.Property(e => e.RegistroPagos).HasMaxLength(255);
            entity.Property(e => e.SerieAjustesMas).HasMaxLength(255);
            entity.Property(e => e.SerieAjustesMenos).HasMaxLength(255);
            entity.Property(e => e.SerieAnulaciones).HasMaxLength(255);
            entity.Property(e => e.SerieDevoluciones).HasMaxLength(255);
            entity.Property(e => e.SerieEliminaciones).HasMaxLength(255);
            entity.Property(e => e.SinocorrelativoAjustesMas).HasColumnName("sinocorrelativoAjustesMas");
            entity.Property(e => e.SinocorrelativoAjustesMenos).HasColumnName("sinocorrelativoAjustesMenos");
            entity.Property(e => e.SinocorrelativoAnulaciones).HasColumnName("sinocorrelativoAnulaciones");
            entity.Property(e => e.SinocorrelativoCheques).HasColumnName("sinocorrelativoCheques");
            entity.Property(e => e.SinocorrelativoCompras).HasColumnName("sinocorrelativoCompras");
            entity.Property(e => e.SinocorrelativoCotizaciones).HasColumnName("sinocorrelativoCotizaciones");
            entity.Property(e => e.SinocorrelativoDevoluciones).HasColumnName("sinocorrelativoDevoluciones");
            entity.Property(e => e.SinocorrelativoEliminaciones).HasColumnName("sinocorrelativoEliminaciones");
            entity.Property(e => e.SinocorrelativoNotas).HasColumnName("sinocorrelativoNotas");
            entity.Property(e => e.Sinocorrelativoclientes).HasColumnName("sinocorrelativoclientes");
            entity.Property(e => e.Sinocorrelativoenvios).HasColumnName("sinocorrelativoenvios");
            entity.Property(e => e.Sinocorrelativoproveedores).HasColumnName("sinocorrelativoproveedores");
            entity.Property(e => e.Sinocorrelativovendedores).HasColumnName("sinocorrelativovendedores");
            entity.Property(e => e.Telefono).HasMaxLength(255);
            entity.Property(e => e.Tipo).HasMaxLength(255);
            entity.Property(e => e.Tipo1Fac).HasMaxLength(255);
            entity.Property(e => e.Tipo2Fac).HasMaxLength(255);
            entity.Property(e => e.Tipo3Fac).HasMaxLength(255);
            entity.Property(e => e.Tipo4Fac).HasMaxLength(255);
            entity.Property(e => e.Tipo5Fac).HasMaxLength(255);
            entity.Property(e => e.TipoCostoProduccion).HasMaxLength(255);
            entity.Property(e => e.Ubicacion).HasMaxLength(255);
            entity.Property(e => e.ValorRetP).HasMaxLength(255);
            entity.Property(e => e.ValorRetU).HasMaxLength(255);
        });

        modelBuilder.Entity<ClientsMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ClientsMaster");

            entity.Property(e => e.Apellidos).HasMaxLength(255);
            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.CiaAldea).HasMaxLength(255);
            entity.Property(e => e.CiaDepartamento).HasMaxLength(255);
            entity.Property(e => e.CiaMunicipio).HasMaxLength(255);
            entity.Property(e => e.ClasificacionCliente).HasMaxLength(255);
            entity.Property(e => e.CodigoPostal).HasMaxLength(255);
            entity.Property(e => e.Colonia).HasMaxLength(255);
            entity.Property(e => e.ComercioExpediente).HasMaxLength(255);
            entity.Property(e => e.ComercioFechaEmision).HasMaxLength(255);
            entity.Property(e => e.ComercioFechaInscripcionDefinitiva).HasMaxLength(255);
            entity.Property(e => e.ComercioFolio).HasMaxLength(255);
            entity.Property(e => e.ComercioLibro).HasMaxLength(255);
            entity.Property(e => e.ComercioRegistro).HasMaxLength(255);
            entity.Property(e => e.Correlativo).HasMaxLength(255);
            entity.Property(e => e.Cuenta).HasMaxLength(255);
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMail");
            entity.Property(e => e.Estatus).HasMaxLength(255);
            entity.Property(e => e.Facturara1).HasMaxLength(255);
            entity.Property(e => e.Facturara2).HasMaxLength(255);
            entity.Property(e => e.Facturara3).HasMaxLength(255);
            entity.Property(e => e.Facturara4).HasMaxLength(255);
            entity.Property(e => e.Facturara5).HasMaxLength(255);
            entity.Property(e => e.Facturara6).HasMaxLength(255);
            entity.Property(e => e.Fax).HasMaxLength(255);
            entity.Property(e => e.FechaBaja).HasMaxLength(255);
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaUltimaCompra).HasColumnType("datetime");
            entity.Property(e => e.FechaUltimoChequeRechazado).HasMaxLength(255);
            entity.Property(e => e.FechaUltimoPago).HasColumnType("datetime");
            entity.Property(e => e.ListaDePrecios).HasMaxLength(255);
            entity.Property(e => e.Moneda).HasMaxLength(255);
            entity.Property(e => e.Nit).HasMaxLength(255);
            entity.Property(e => e.Nit1).HasMaxLength(255);
            entity.Property(e => e.Nit2).HasMaxLength(255);
            entity.Property(e => e.Nit3).HasMaxLength(255);
            entity.Property(e => e.Nit4).HasMaxLength(255);
            entity.Property(e => e.Nit5).HasMaxLength(255);
            entity.Property(e => e.Nit6).HasMaxLength(255);
            entity.Property(e => e.NombreContacto).HasMaxLength(255);
            entity.Property(e => e.Nombres).HasMaxLength(255);
            entity.Property(e => e.Numero).HasMaxLength(255);
            entity.Property(e => e.NumeroAlterno).HasMaxLength(255);
            entity.Property(e => e.NumeroDeCliente).HasMaxLength(255);
            entity.Property(e => e.NumeroProyecto).HasMaxLength(255);
            entity.Property(e => e.Observaciones).HasMaxLength(255);
            entity.Property(e => e.OfertaEpv).HasColumnName("OfertaEPV");
            entity.Property(e => e.PatenteComercioNo).HasMaxLength(255);
            entity.Property(e => e.PatenteSociedadNo).HasMaxLength(255);
            entity.Property(e => e.PorcRetIva).HasColumnName("PorcRetIVA");
            entity.Property(e => e.RazonSocial).HasMaxLength(255);
            entity.Property(e => e.Registro).HasMaxLength(255);
            entity.Property(e => e.RepresLegalProp).HasMaxLength(255);
            entity.Property(e => e.RepresentanteAldea).HasMaxLength(255);
            entity.Property(e => e.RepresentanteApellidos).HasMaxLength(255);
            entity.Property(e => e.RepresentanteCedula).HasMaxLength(255);
            entity.Property(e => e.RepresentanteCodPostal).HasMaxLength(255);
            entity.Property(e => e.RepresentanteColonia).HasMaxLength(255);
            entity.Property(e => e.RepresentanteDepartamento).HasMaxLength(255);
            entity.Property(e => e.RepresentanteDireccion).HasMaxLength(255);
            entity.Property(e => e.RepresentanteEmail)
                .HasMaxLength(255)
                .HasColumnName("RepresentanteEMail");
            entity.Property(e => e.RepresentanteFax).HasMaxLength(255);
            entity.Property(e => e.RepresentanteFechaNacimiento).HasMaxLength(255);
            entity.Property(e => e.RepresentanteMunicipio).HasMaxLength(255);
            entity.Property(e => e.RepresentanteNit).HasMaxLength(255);
            entity.Property(e => e.RepresentanteNombres).HasMaxLength(255);
            entity.Property(e => e.RepresentanteRegistro).HasMaxLength(255);
            entity.Property(e => e.RepresentanteTelefonos).HasMaxLength(255);
            entity.Property(e => e.RepresentanteZona).HasMaxLength(255);
            entity.Property(e => e.SectorPp).HasColumnName("SectorPP");
            entity.Property(e => e.SociedadExpediente).HasMaxLength(255);
            entity.Property(e => e.SociedadFechaEmision).HasMaxLength(255);
            entity.Property(e => e.SociedadFechaInscripcionDefinitiva).HasMaxLength(255);
            entity.Property(e => e.SociedadFolio).HasMaxLength(255);
            entity.Property(e => e.SociedadLibro).HasMaxLength(255);
            entity.Property(e => e.SociedadRegistro).HasMaxLength(255);
            entity.Property(e => e.Telefono).HasMaxLength(255);
            entity.Property(e => e.TieneAnulaciones).HasMaxLength(255);
            entity.Property(e => e.TieneCotizaciones).HasMaxLength(255);
            entity.Property(e => e.TieneDevoluciones).HasMaxLength(255);
            entity.Property(e => e.TieneEnvios).HasMaxLength(255);
            entity.Property(e => e.TieneOrdenesServicio).HasMaxLength(255);
            entity.Property(e => e.TipoPago).HasMaxLength(255);
            entity.Property(e => e.TipoRepresentacion).HasMaxLength(255);
            entity.Property(e => e.TipodeCliente).HasMaxLength(255);
            entity.Property(e => e.Ubicacion).HasMaxLength(255);
            entity.Property(e => e.UbicacionF).HasMaxLength(255);
            entity.Property(e => e.Vendedor).HasMaxLength(255);
            entity.Property(e => e.Vendedor1).HasMaxLength(255);
            entity.Property(e => e.Zona).HasMaxLength(255);
        });

        modelBuilder.Entity<CoinsBill>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.Concepto).HasMaxLength(255);
        });

        modelBuilder.Entity<Control>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("control");

            entity.Property(e => e.AñoProceso).HasMaxLength(255);
            entity.Property(e => e.Certificacion)
                .HasMaxLength(255)
                .HasColumnName("certificacion");
            entity.Property(e => e.Correlativocarreras).HasColumnName("correlativocarreras");
            entity.Property(e => e.Correlativoestudiantes).HasColumnName("correlativoestudiantes");
            entity.Property(e => e.Decano).HasMaxLength(255);
            entity.Property(e => e.Entidad).HasMaxLength(255);
            entity.Property(e => e.Evento).HasMaxLength(255);
            entity.Property(e => e.FechaInscripcion).HasColumnType("datetime");
            entity.Property(e => e.FechaPban)
                .HasMaxLength(255)
                .HasColumnName("FechaPBan");
            entity.Property(e => e.FechaPcam)
                .HasMaxLength(255)
                .HasColumnName("FechaPCam");
            entity.Property(e => e.FechaPcxp)
                .HasMaxLength(255)
                .HasColumnName("FechaPCxp");
            entity.Property(e => e.FechaPfaE)
                .HasMaxLength(255)
                .HasColumnName("FechaPFaE");
            entity.Property(e => e.FechaPnom)
                .HasMaxLength(255)
                .HasColumnName("FechaPNom");
            entity.Property(e => e.FechaPpai)
                .HasMaxLength(255)
                .HasColumnName("FechaPPai");
            entity.Property(e => e.FechaPprod)
                .HasMaxLength(255)
                .HasColumnName("FechaPProd");
            entity.Property(e => e.FechaProceso).HasMaxLength(255);
            entity.Property(e => e.JefeControlAcademico).HasMaxLength(255);
            entity.Property(e => e.Nombre1).HasMaxLength(255);
            entity.Property(e => e.Nombre2).HasMaxLength(255);
            entity.Property(e => e.Periodo1).HasColumnName("periodo1");
            entity.Property(e => e.Periodo10)
                .HasMaxLength(255)
                .HasColumnName("periodo10");
            entity.Property(e => e.Periodo11)
                .HasMaxLength(255)
                .HasColumnName("periodo11");
            entity.Property(e => e.Periodo12)
                .HasMaxLength(255)
                .HasColumnName("periodo12");
            entity.Property(e => e.Periodo2).HasColumnName("periodo2");
            entity.Property(e => e.Periodo3)
                .HasMaxLength(255)
                .HasColumnName("periodo3");
            entity.Property(e => e.Periodo4)
                .HasMaxLength(255)
                .HasColumnName("periodo4");
            entity.Property(e => e.Periodo5)
                .HasMaxLength(255)
                .HasColumnName("periodo5");
            entity.Property(e => e.Periodo6)
                .HasMaxLength(255)
                .HasColumnName("periodo6");
            entity.Property(e => e.Periodo7)
                .HasMaxLength(255)
                .HasColumnName("periodo7");
            entity.Property(e => e.Periodo8)
                .HasMaxLength(255)
                .HasColumnName("periodo8");
            entity.Property(e => e.Periodo9)
                .HasMaxLength(255)
                .HasColumnName("periodo9");
            entity.Property(e => e.Secretario).HasMaxLength(255);
            entity.Property(e => e.Sincronizar).HasMaxLength(255);
            entity.Property(e => e.Sincronizar1).HasMaxLength(255);
            entity.Property(e => e.Sincronizar2).HasMaxLength(255);
            entity.Property(e => e.Sincronizar3).HasMaxLength(255);
            entity.Property(e => e.Sincronizar4).HasMaxLength(255);
            entity.Property(e => e.Sincronizar5).HasMaxLength(255);
            entity.Property(e => e.Sincronizar6).HasMaxLength(255);
            entity.Property(e => e.Sincronizar7).HasMaxLength(255);
        });

        modelBuilder.Entity<CrmLogIn>(entity =>
        {
            entity.HasKey(e => new { e.UserCode, e.UserPass }).HasName("PK__CrmLogIn__458C24BC3B75D760");

            entity.ToTable("CrmLogIn");

            entity.Property(e => e.UserCode).HasMaxLength(32);
            entity.Property(e => e.UserPass).HasMaxLength(64);
            entity.Property(e => e.CiasAccess)
                .HasMaxLength(60)
                .HasColumnName("Cias_Access");
            entity.Property(e => e.FullAccess).HasColumnName("Full_Access");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Level).HasMaxLength(1);
            entity.Property(e => e.Name).HasMaxLength(64);
            entity.Property(e => e.VendorCode).HasMaxLength(32);
        });

        modelBuilder.Entity<EconomicSector>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EconomicSector");

            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.Concepto).HasMaxLength(255);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<InvloiceHeaderMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InvloiceHeaderMaster");

            entity.Property(e => e.AñoPeriodo).HasMaxLength(255);
            entity.Property(e => e.Camion).HasMaxLength(255);
            entity.Property(e => e.CentroCosto).HasMaxLength(255);
            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.CodigoCliente).HasMaxLength(255);
            entity.Property(e => e.CuentaCr).HasMaxLength(255);
            entity.Property(e => e.CuentaDb).HasMaxLength(255);
            entity.Property(e => e.CuentaRet).HasMaxLength(255);
            entity.Property(e => e.FactorGfabricacion).HasColumnName("FactorGFabricacion");
            entity.Property(e => e.FactorMobra).HasColumnName("FactorMObra");
            entity.Property(e => e.FactorOgastos).HasColumnName("FactorOGastos");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaG).HasColumnType("datetime");
            entity.Property(e => e.FechaRet).HasMaxLength(255);
            entity.Property(e => e.HoraGrabacion).HasMaxLength(255);
            entity.Property(e => e.NoBatch).HasMaxLength(255);
            entity.Property(e => e.NoRecibo).HasMaxLength(255);
            entity.Property(e => e.Periodo).HasMaxLength(255);
            entity.Property(e => e.Repartidor).HasMaxLength(255);
            entity.Property(e => e.Serie).HasMaxLength(255);
            entity.Property(e => e.Sucursal).HasMaxLength(255);
            entity.Property(e => e.TipoPoliza).HasMaxLength(255);
            entity.Property(e => e.TipoRegistro).HasMaxLength(255);
            entity.Property(e => e.ValorRetIva).HasColumnName("ValorRetIVA");
            entity.Property(e => e.Vendedor).HasMaxLength(255);
        });

        modelBuilder.Entity<InvoiceDetailMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InvoiceDetailMaster");

            entity.Property(e => e.Bodega).HasMaxLength(255);
            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.CodigoCliente).HasMaxLength(255);
            entity.Property(e => e.CorrelLinea).HasMaxLength(255);
            entity.Property(e => e.CuentaCompras).HasMaxLength(255);
            entity.Property(e => e.CuentaVentas).HasMaxLength(255);
            entity.Property(e => e.FechaFabricacion).HasMaxLength(255);
            entity.Property(e => e.FechaVencimiento).HasMaxLength(255);
            entity.Property(e => e.Lote).HasMaxLength(255);
            entity.Property(e => e.NoBatch).HasMaxLength(255);
            entity.Property(e => e.Serie).HasMaxLength(255);
            entity.Property(e => e.Sucursal).HasMaxLength(255);
            entity.Property(e => e.TipoRegistro).HasMaxLength(255);
        });

        modelBuilder.Entity<ItemMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemMaster");

            entity.Property(e => e.Casa).HasMaxLength(255);
            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.CostoActualCif).HasColumnName("CostoActualCIF");
            entity.Property(e => e.CostoActualFob).HasColumnName("CostoActualFOB");
            entity.Property(e => e.CuentaCompras).HasMaxLength(255);
            entity.Property(e => e.CuentaVentas).HasMaxLength(255);
            entity.Property(e => e.Descargar).HasMaxLength(255);
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.DiasVencimiento).HasMaxLength(255);
            entity.Property(e => e.Estatus).HasMaxLength(255);
            entity.Property(e => e.FechaD).HasMaxLength(255);
            entity.Property(e => e.FechaH).HasMaxLength(255);
            entity.Property(e => e.FormaEmpaque).HasMaxLength(255);
            entity.Property(e => e.HoraD).HasMaxLength(255);
            entity.Property(e => e.HoraH).HasMaxLength(255);
            entity.Property(e => e.Laboratorio).HasMaxLength(255);
            entity.Property(e => e.Linea).HasMaxLength(255);
            entity.Property(e => e.Medida).HasMaxLength(255);
            entity.Property(e => e.Moneda).HasMaxLength(255);
            entity.Property(e => e.PrecioVp).HasColumnName("PrecioVP");
            entity.Property(e => e.Temp).HasMaxLength(255);
            entity.Property(e => e.TipoDeInventario).HasMaxLength(255);
            entity.Property(e => e.UbicacionF).HasMaxLength(255);
            entity.Property(e => e.UnidadesXempaque)
                .HasMaxLength(255)
                .HasColumnName("UnidadesXEmpaque");
        });

        modelBuilder.Entity<ItemsInternalConcept>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemsInternalConcept");

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.ConceptoInterno).HasMaxLength(255);
        });

        modelBuilder.Entity<ManagersLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ManagersLink");

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMail");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.HoraFinalizacion).HasMaxLength(255);
            entity.Property(e => e.NoEventoMovil).HasMaxLength(255);
        });

        modelBuilder.Entity<PayGovernance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PayGovernance");

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.Concepto).HasMaxLength(255);
        });

        modelBuilder.Entity<PettyCashDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PettyCashDetail");

            entity.Property(e => e.CalculoIva).HasColumnName("CalculoIVA");
            entity.Property(e => e.CentroCosto).HasMaxLength(255);
            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.CodigoProveedor).HasMaxLength(255);
            entity.Property(e => e.CorrelLinea).HasMaxLength(255);
            entity.Property(e => e.CuentaCr).HasMaxLength(255);
            entity.Property(e => e.CuentaDb).HasMaxLength(255);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Iva).HasColumnName("IVA");
            entity.Property(e => e.IvanoDeducible).HasColumnName("IVANoDeducible");
            entity.Property(e => e.NoCajaChica).HasMaxLength(255);
            entity.Property(e => e.Serie).HasMaxLength(255);
            entity.Property(e => e.Sucursal).HasMaxLength(255);
            entity.Property(e => e.TipoPoliza).HasMaxLength(255);
            entity.Property(e => e.TipoRegistro).HasMaxLength(255);
        });

        modelBuilder.Entity<PettyCashHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PettyCashHeader");

            entity.Property(e => e.AñoPeriodo).HasMaxLength(255);
            entity.Property(e => e.CentroCosto).HasMaxLength(255);
            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaGrabacion).HasMaxLength(255);
            entity.Property(e => e.HoraGrabacion).HasMaxLength(255);
            entity.Property(e => e.NoCajaChica).HasMaxLength(255);
            entity.Property(e => e.Periodo).HasMaxLength(255);
            entity.Property(e => e.Sucursal).HasMaxLength(255);
            entity.Property(e => e.TipoPoliza).HasMaxLength(255);
            entity.Property(e => e.TipoRegistro).HasMaxLength(255);
        });

        modelBuilder.Entity<PurchaseDetailMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PurchaseDetailMaster");

            entity.Property(e => e.Bodega).HasMaxLength(255);
            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.CodigoProveedor).HasMaxLength(255);
            entity.Property(e => e.CorrelLinea).HasMaxLength(255);
            entity.Property(e => e.CostoUnitarioCif).HasColumnName("CostoUnitarioCIF");
            entity.Property(e => e.CostoUnitarioCifl).HasColumnName("CostoUnitarioCIFL");
            entity.Property(e => e.CostoUnitarioFob).HasColumnName("CostoUnitarioFOB");
            entity.Property(e => e.CostoUnitarioFoba).HasColumnName("CostoUnitarioFOBA");
            entity.Property(e => e.CuentaCompras).HasMaxLength(255);
            entity.Property(e => e.CuentaVentas).HasMaxLength(255);
            entity.Property(e => e.FechaFabricacion).HasMaxLength(255);
            entity.Property(e => e.FechaVencimiento).HasMaxLength(255);
            entity.Property(e => e.Lote).HasMaxLength(255);
            entity.Property(e => e.Serie).HasMaxLength(255);
            entity.Property(e => e.Sucursal).HasMaxLength(255);
            entity.Property(e => e.TipoRegistro).HasMaxLength(255);
        });

        modelBuilder.Entity<PurchaseHeaderMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PurchaseHeaderMaster");

            entity.Property(e => e.AñoPeriodo).HasMaxLength(255);
            entity.Property(e => e.Bodega).HasMaxLength(255);
            entity.Property(e => e.CentroCosto).HasMaxLength(255);
            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.CodigoProveedor).HasMaxLength(255);
            entity.Property(e => e.ComprasIe).HasColumnName("ComprasIE");
            entity.Property(e => e.ComprasIl).HasColumnName("ComprasIL");
            entity.Property(e => e.ComprasOe).HasColumnName("ComprasOE");
            entity.Property(e => e.ComprasOl).HasColumnName("ComprasOL");
            entity.Property(e => e.ComprasSe).HasColumnName("ComprasSE");
            entity.Property(e => e.ComprasSl).HasColumnName("ComprasSL");
            entity.Property(e => e.ComprasTe).HasColumnName("ComprasTE");
            entity.Property(e => e.ComprasTl).HasColumnName("ComprasTL");
            entity.Property(e => e.CtaAjusteCcr)
                .HasMaxLength(255)
                .HasColumnName("CtaAjusteCCr");
            entity.Property(e => e.CtaAjusteCdb)
                .HasMaxLength(255)
                .HasColumnName("CtaAjusteCDb");
            entity.Property(e => e.Cuenta).HasMaxLength(255);
            entity.Property(e => e.CuentaComprasIe)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasIE");
            entity.Property(e => e.CuentaComprasIl)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasIL");
            entity.Property(e => e.CuentaComprasOe)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasOE");
            entity.Property(e => e.CuentaComprasOl)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasOL");
            entity.Property(e => e.CuentaComprasSe)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasSE");
            entity.Property(e => e.CuentaComprasSl)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasSL");
            entity.Property(e => e.CuentaComprasTe)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasTE");
            entity.Property(e => e.CuentaComprasTl)
                .HasMaxLength(255)
                .HasColumnName("CuentaComprasTL");
            entity.Property(e => e.CuentaCr).HasMaxLength(255);
            entity.Property(e => e.Cuentaret).HasMaxLength(255);
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaG).HasColumnType("datetime");
            entity.Property(e => e.FechaRet).HasMaxLength(255);
            entity.Property(e => e.HoraGrabacion).HasMaxLength(255);
            entity.Property(e => e.IvanoDeducible).HasColumnName("IVANoDeducible");
            entity.Property(e => e.NoContraseña).HasMaxLength(255);
            entity.Property(e => e.Periodo).HasMaxLength(255);
            entity.Property(e => e.Serie).HasMaxLength(255);
            entity.Property(e => e.Sucursal).HasMaxLength(255);
            entity.Property(e => e.TcostoUnitarioCif).HasColumnName("TCostoUnitarioCIF");
            entity.Property(e => e.TcostoUnitarioCifl).HasColumnName("TCostoUnitarioCIFL");
            entity.Property(e => e.TcostoUnitarioFob).HasColumnName("TCostoUnitarioFOB");
            entity.Property(e => e.TcostoUnitarioFoba).HasColumnName("TCostoUnitarioFOBA");
            entity.Property(e => e.TipoCompra).HasMaxLength(255);
            entity.Property(e => e.TipoPoliza).HasMaxLength(255);
            entity.Property(e => e.TipoRegistro).HasMaxLength(255);
            entity.Property(e => e.ValorDifCam).HasMaxLength(255);
            entity.Property(e => e.ValorRetIva).HasColumnName("ValorRetIVA");
        });

        modelBuilder.Entity<Remark>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Observacion).HasMaxLength(255);
            entity.Property(e => e.Observacion1).HasMaxLength(255);
            entity.Property(e => e.Proveedor).HasMaxLength(255);
            entity.Property(e => e.Serie).HasMaxLength(255);
            entity.Property(e => e.Sucursal).HasMaxLength(255);
        });

        modelBuilder.Entity<Scale>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<SearchWordFileLocal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SearchWordFile_local");

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Sdate)
                .HasColumnType("datetime")
                .HasColumnName("SDate");
            entity.Property(e => e.SearchWord).HasMaxLength(255);
        });

        modelBuilder.Entity<Substitute>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Alternate).HasMaxLength(21);
            entity.Property(e => e.Alternate1).HasMaxLength(21);
            entity.Property(e => e.Branch).HasMaxLength(3);
            entity.Property(e => e.Cia).HasMaxLength(3);
            entity.Property(e => e.MainItem).HasMaxLength(21);
            entity.Property(e => e.WareHouse).HasMaxLength(3);
        });

        modelBuilder.Entity<SuppliersMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SuppliersMaster");

            entity.Property(e => e.Apellidos).HasMaxLength(255);
            entity.Property(e => e.CiaAldea).HasMaxLength(255);
            entity.Property(e => e.CiaDepartamento).HasMaxLength(255);
            entity.Property(e => e.CiaMunicipio).HasMaxLength(255);
            entity.Property(e => e.CodigoPostal).HasMaxLength(255);
            entity.Property(e => e.Colonia).HasMaxLength(255);
            entity.Property(e => e.ComercioExpediente).HasMaxLength(255);
            entity.Property(e => e.ComercioFechaEmision).HasMaxLength(255);
            entity.Property(e => e.ComercioFechaInscripcionDefinitiva).HasMaxLength(255);
            entity.Property(e => e.ComercioFolio).HasMaxLength(255);
            entity.Property(e => e.ComercioLibro).HasMaxLength(255);
            entity.Property(e => e.ComercioRegistro).HasMaxLength(255);
            entity.Property(e => e.CuentaGasto).HasMaxLength(255);
            entity.Property(e => e.CuentaHonorarios).HasMaxLength(255);
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMail");
            entity.Property(e => e.Fax).HasMaxLength(255);
            entity.Property(e => e.FechaUltimaCompra).HasMaxLength(255);
            entity.Property(e => e.FechaUltimoChequeRechazado).HasMaxLength(255);
            entity.Property(e => e.FechaUltimoPago).HasMaxLength(255);
            entity.Property(e => e.Naturaleza).HasMaxLength(255);
            entity.Property(e => e.Nit).HasMaxLength(255);
            entity.Property(e => e.NombreContacto).HasMaxLength(255);
            entity.Property(e => e.Nombres).HasMaxLength(255);
            entity.Property(e => e.NumeroAlterno).HasMaxLength(255);
            entity.Property(e => e.NumeroProyecto).HasMaxLength(255);
            entity.Property(e => e.Observaciones).HasMaxLength(255);
            entity.Property(e => e.Origen).HasMaxLength(255);
            entity.Property(e => e.PatenteComercioNo).HasMaxLength(255);
            entity.Property(e => e.PatenteSociedadNo).HasMaxLength(255);
            entity.Property(e => e.PorcRetIva).HasColumnName("PorcRetIVA");
            entity.Property(e => e.Proveedor).HasMaxLength(255);
            entity.Property(e => e.RazonSocial).HasMaxLength(255);
            entity.Property(e => e.RepresentanteAldea).HasMaxLength(255);
            entity.Property(e => e.RepresentanteApellidos).HasMaxLength(255);
            entity.Property(e => e.RepresentanteCedula).HasMaxLength(255);
            entity.Property(e => e.RepresentanteCodPostal).HasMaxLength(255);
            entity.Property(e => e.RepresentanteColonia).HasMaxLength(255);
            entity.Property(e => e.RepresentanteDepartamento).HasMaxLength(255);
            entity.Property(e => e.RepresentanteDireccion).HasMaxLength(255);
            entity.Property(e => e.RepresentanteEmail)
                .HasMaxLength(255)
                .HasColumnName("RepresentanteEMail");
            entity.Property(e => e.RepresentanteFax).HasMaxLength(255);
            entity.Property(e => e.RepresentanteFechaNacimiento).HasMaxLength(255);
            entity.Property(e => e.RepresentanteMunicipio).HasMaxLength(255);
            entity.Property(e => e.RepresentanteNit).HasMaxLength(255);
            entity.Property(e => e.RepresentanteNombres).HasMaxLength(255);
            entity.Property(e => e.RepresentanteRegistro).HasMaxLength(255);
            entity.Property(e => e.RepresentanteTelefonos).HasMaxLength(255);
            entity.Property(e => e.RepresentanteZona).HasMaxLength(255);
            entity.Property(e => e.SectorDefault).HasMaxLength(255);
            entity.Property(e => e.SectorEconomico1).HasMaxLength(255);
            entity.Property(e => e.SectorEconomico2).HasMaxLength(255);
            entity.Property(e => e.SectorEconomico3).HasMaxLength(255);
            entity.Property(e => e.SectorEconomico4).HasMaxLength(255);
            entity.Property(e => e.SectorEconomico5).HasMaxLength(255);
            entity.Property(e => e.SectorEconomico6).HasMaxLength(255);
            entity.Property(e => e.SectorEconomico7).HasMaxLength(255);
            entity.Property(e => e.SectorEconomico8).HasMaxLength(255);
            entity.Property(e => e.SectorEconomico9).HasMaxLength(255);
            entity.Property(e => e.SectorPp).HasColumnName("SectorPP");
            entity.Property(e => e.SociedadExpediente).HasMaxLength(255);
            entity.Property(e => e.SociedadFechaEmision).HasMaxLength(255);
            entity.Property(e => e.SociedadFechaInscripcionDefinitiva).HasMaxLength(255);
            entity.Property(e => e.SociedadFolio).HasMaxLength(255);
            entity.Property(e => e.SociedadLibro).HasMaxLength(255);
            entity.Property(e => e.SociedadRegistro).HasMaxLength(255);
            entity.Property(e => e.Telefono).HasMaxLength(255);
            entity.Property(e => e.TipoEmpresa).HasMaxLength(255);
            entity.Property(e => e.TipoPago).HasMaxLength(255);
            entity.Property(e => e.TipoRepresentacion).HasMaxLength(255);
            entity.Property(e => e.Ubicacion).HasMaxLength(255);
            entity.Property(e => e.ValorUltimaCompra).HasMaxLength(255);
            entity.Property(e => e.ValorUltimoPago).HasMaxLength(255);
            entity.Property(e => e.VecesChequesRechazados).HasMaxLength(255);
            entity.Property(e => e.Zona).HasMaxLength(255);
        });

        modelBuilder.Entity<TaxesMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TaxesMaster");

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.Concepto).HasMaxLength(255);
            entity.Property(e => e.CuentaCompra).HasMaxLength(255);
            entity.Property(e => e.CuentaImpuesto).HasMaxLength(255);
            entity.Property(e => e.FacAu).HasMaxLength(255);
            entity.Property(e => e.Impuesto).HasColumnName("%Impuesto");
            entity.Property(e => e.Mensaje).HasMaxLength(255);
            entity.Property(e => e.Sector).HasMaxLength(255);
            entity.Property(e => e.Tipo).HasMaxLength(255);
        });

        modelBuilder.Entity<VendorsMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VendorsMaster");

            entity.Property(e => e.Apellidos).HasMaxLength(255);
            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.Codigo).HasMaxLength(255);
            entity.Property(e => e.CodigoNomina).HasMaxLength(255);
            entity.Property(e => e.CodigoPostal).HasMaxLength(255);
            entity.Property(e => e.Colonia).HasMaxLength(255);
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMail");
            entity.Property(e => e.Fax).HasMaxLength(255);
            entity.Property(e => e.Nit).HasMaxLength(255);
            entity.Property(e => e.Nombres).HasMaxLength(255);
            entity.Property(e => e.Telefono).HasMaxLength(255);
            entity.Property(e => e.Tipo).HasMaxLength(255);
            entity.Property(e => e.Ubicacion).HasMaxLength(255);
            entity.Property(e => e.Zona).HasMaxLength(255);
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Warehouse");

            entity.Property(e => e.Cia).HasMaxLength(255);
            entity.Property(e => e.NombreBodega).HasMaxLength(255);
            entity.Property(e => e.NumeroBodega).HasMaxLength(255);
            entity.Property(e => e.Sucursal).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
