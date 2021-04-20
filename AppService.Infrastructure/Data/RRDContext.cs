using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AppService.Core.Entities;


namespace AppService.Infrastructure.Data
{
    public partial class RRDContext : DbContext
    {
        public RRDContext()
        {
        }

        public RRDContext(DbContextOptions<RRDContext> options)
            : base(options)
        {
        }


        public virtual DbSet<AppCategory> AppCategory { get; set; }
        public virtual DbSet<AppConfigApp> AppConfigApp { get; set; }
        public virtual DbSet<AppDetailQuotes> AppDetailQuotes { get; set; }
        public virtual DbSet<AppDetailQuotesConversionUnit> AppDetailQuotesConversionUnit { get; set; }
        public virtual DbSet<AppEmbarques> AppEmbarques { get; set; }
        public virtual DbSet<AppGeneralQuotes> AppGeneralQuotes { get; set; }
        public virtual DbSet<AppIngredients> AppIngredients { get; set; }
        public virtual DbSet<AppProductVariableSearchText> AppProductVariableSearchText { get; set; }
        public virtual DbSet<AppProducts> AppProducts { get; set; }
        public virtual DbSet<AppRecipes> AppRecipes { get; set; }
        public virtual DbSet<AppStatusQuote> AppStatusQuote { get; set; }
        public virtual DbSet<AppSubCategory> AppSubCategory { get; set; }
        public virtual DbSet<AppTemplateConversionUnit> AppTemplateConversionUnit { get; set; }
        public virtual DbSet<AppUnits> AppUnits { get; set; }
        public virtual DbSet<AppUnitsofMeasureforIngredients> AppUnitsofMeasureforIngredients { get; set; }
        public virtual DbSet<AppUnitsofMeasureforMaterials> AppUnitsofMeasureforMaterials { get; set; }
        public virtual DbSet<AppVariables> AppVariables { get; set; }
        public virtual DbSet<AppVariableSearch> AppVariableSearch { get; set; }
        
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<AutoAudit> AutoAudit { get; set; }
        public virtual DbSet<Cary028> Cary028 { get; set; }
        public virtual DbSet<Cary029> Cary029 { get; set; }
        public virtual DbSet<CatAuditoriaCalculo> CatAuditoriaCalculo { get; set; }
        public virtual DbSet<CatCalibrePapel> CatCalibrePapel { get; set; }
        public virtual DbSet<CatCalibrePapelRollos> CatCalibrePapelRollos { get; set; }
        public virtual DbSet<CatCodigoMayorPartesBasica> CatCodigoMayorPartesBasica { get; set; }
        public virtual DbSet<CatLista> CatLista { get; set; }
        public virtual DbSet<CatMaterial> CatMaterial { get; set; }
        public virtual DbSet<CatMaterialDetalle> CatMaterialDetalle { get; set; }
        public virtual DbSet<CatMaterialDetalleTmp> CatMaterialDetalleTmp { get; set; }
        public virtual DbSet<CatMedidaBasica> CatMedidaBasica { get; set; }
        public virtual DbSet<CatMedidaBasica1> CatMedidaBasica1 { get; set; }
        public virtual DbSet<CatMedidaBasicaRollos> CatMedidaBasicaRollos { get; set; }
        public virtual DbSet<CatMedidaOpuesta> CatMedidaOpuesta { get; set; }
        public virtual DbSet<CatPapel> CatPapel { get; set; }
        public virtual DbSet<CatProductoMayor> CatProductoMayor { get; set; }
        public virtual DbSet<CatProductoMayorPartes> CatProductoMayorPartes { get; set; }
        public virtual DbSet<CatProductoMayorPartesTintas> CatProductoMayorPartesTintas { get; set; }
        public virtual DbSet<CatProductoMayorPartesTintasBasica> CatProductoMayorPartesTintasBasica { get; set; }
        public virtual DbSet<CatProductoMayorPartesTintasBasicaOpuesta> CatProductoMayorPartesTintasBasicaOpuesta { get; set; }
        public virtual DbSet<CatProductoMayorPartesTintasBasicaOpuestaPapeles> CatProductoMayorPartesTintasBasicaOpuestaPapeles { get; set; }
        public virtual DbSet<CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon> CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon { get; set; }
        public virtual DbSet<CatProductoMayorUnidadesConversion> CatProductoMayorUnidadesConversion { get; set; }
        public virtual DbSet<CatSubCategoria> CatSubCategoria { get; set; }
        public virtual DbSet<CatSysfile> CatSysfile { get; set; }
        public virtual DbSet<Ciny056> Ciny056 { get; set; }
        public virtual DbSet<Ciny057> Ciny057 { get; set; }
        public virtual DbSet<CobAdjuntosCobranza> CobAdjuntosCobranza { get; set; }
        public virtual DbSet<CobAvisosCobro> CobAvisosCobro { get; set; }
        public virtual DbSet<CobAvisosCobroTemp> CobAvisosCobroTemp { get; set; }
        public virtual DbSet<CobBanco> CobBanco { get; set; }
        public virtual DbSet<CobDatosCheque> CobDatosCheque { get; set; }
        public virtual DbSet<CobDescuentoIvaTipoTransaccion> CobDescuentoIvaTipoTransaccion { get; set; }
        public virtual DbSet<CobEstadoDeCuenta> CobEstadoDeCuenta { get; set; }
        public virtual DbSet<CobEstadoDeCuentaBk> CobEstadoDeCuentaBk { get; set; }
        public virtual DbSet<CobExcepcion> CobExcepcion { get; set; }
        public virtual DbSet<CobGeneralCobranza> CobGeneralCobranza { get; set; }
        public virtual DbSet<CobGrabacionCobranzas> CobGrabacionCobranzas { get; set; }
        public virtual DbSet<CobIntegridadCobranzasVsWary074> CobIntegridadCobranzasVsWary074 { get; set; }
        public virtual DbSet<CobPagosRetenciones> CobPagosRetenciones { get; set; }
        public virtual DbSet<CobPorcentajesImpuestos> CobPorcentajesImpuestos { get; set; }
        public virtual DbSet<CobRangosVencimiento> CobRangosVencimiento { get; set; }
        public virtual DbSet<CobResumenEstadoCuenta> CobResumenEstadoCuenta { get; set; }
        public virtual DbSet<CobResumenEstadoCuentaTemp> CobResumenEstadoCuentaTemp { get; set; }
        public virtual DbSet<CobRolCobranza> CobRolCobranza { get; set; }
        public virtual DbSet<CobSysfile> CobSysfile { get; set; }
        public virtual DbSet<CobTipoTransaccion> CobTipoTransaccion { get; set; }
        public virtual DbSet<CobTipoTransaccionRespaldoAntesEliminarColettilla> CobTipoTransaccionRespaldoAntesEliminarColettilla { get; set; }
        public virtual DbSet<CobTransacciones> CobTransacciones { get; set; }
        public virtual DbSet<CobValoresRetencionIslr> CobValoresRetencionIslr { get; set; }
        public virtual DbSet<CobValoresRetencionIva> CobValoresRetencionIva { get; set; }
        public virtual DbSet<CobValoresRetenciones> CobValoresRetenciones { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Cpry010> Cpry010 { get; set; }
        public virtual DbSet<Cpry012> Cpry012 { get; set; }
        public virtual DbSet<CreAdjuntoSolicitudCredito> CreAdjuntoSolicitudCredito { get; set; }
        public virtual DbSet<CreClientesExcepcion> CreClientesExcepcion { get; set; }
        public virtual DbSet<CreCotizacionDocumento> CreCotizacionDocumento { get; set; }
        public virtual DbSet<CreEvaluacionCredito> CreEvaluacionCredito { get; set; }
        public virtual DbSet<CreRangoAprobacionOficinaUsuarioMontoDias> CreRangoAprobacionOficinaUsuarioMontoDias { get; set; }
        public virtual DbSet<CreResponsableAprobarExcepcion> CreResponsableAprobarExcepcion { get; set; }
        public virtual DbSet<CreSolicitudDeCredito> CreSolicitudDeCredito { get; set; }
        public virtual DbSet<CreSolicitudDeCreditoHistorico> CreSolicitudDeCreditoHistorico { get; set; }
        public virtual DbSet<CreSolicitudExcepcion> CreSolicitudExcepcion { get; set; }
        public virtual DbSet<CreSolicitudExcepcionHistorico> CreSolicitudExcepcionHistorico { get; set; }
        public virtual DbSet<CrmEncuestaCliente> CrmEncuestaCliente { get; set; }
        public virtual DbSet<CrmMtrCes> CrmMtrCes { get; set; }
        public virtual DbSet<CrmMtrCs> CrmMtrCs { get; set; }
        public virtual DbSet<CrmMtrEstado> CrmMtrEstado { get; set; }
        public virtual DbSet<CrmMtrNps> CrmMtrNps { get; set; }
        public virtual DbSet<CrmMtrSeguimiento> CrmMtrSeguimiento { get; set; }
        public virtual DbSet<CrmNotificacionActividades> CrmNotificacionActividades { get; set; }
        public virtual DbSet<CrmSeguimiento> CrmSeguimiento { get; set; }
        public virtual DbSet<CrmVisitaDia> CrmVisitaDia { get; set; }
        public virtual DbSet<CrmVisitaFrecuencia> CrmVisitaFrecuencia { get; set; }
        public virtual DbSet<CrmVisitaSemana> CrmVisitaSemana { get; set; }
        public virtual DbSet<Ctmy033> Ctmy033 { get; set; }
        public virtual DbSet<Ctmy034> Ctmy034 { get; set; }
        public virtual DbSet<DataInicial> DataInicial { get; set; }
        public virtual DbSet<DeudorTipoRetencion> DeudorTipoRetencion { get; set; }
        public virtual DbSet<Deudores> Deudores { get; set; }
        public virtual DbSet<EjeucionProceso> EjeucionProceso { get; set; }
        public virtual DbSet<EjeucionProcesoComisiones> EjeucionProcesoComisiones { get; set; }
        public virtual DbSet<EscaneoTicket> EscaneoTicket { get; set; }
        public virtual DbSet<F03b11> F03b11 { get; set; }
        public virtual DbSet<GssAdjuntoTarea> GssAdjuntoTarea { get; set; }
        public virtual DbSet<GssAdminApp> GssAdminApp { get; set; }
        public virtual DbSet<GssAprobacionServicio> GssAprobacionServicio { get; set; }
        public virtual DbSet<GssAreaServicio> GssAreaServicio { get; set; }
        public virtual DbSet<GssCompañia> GssCompañia { get; set; }
        public virtual DbSet<GssEstatusSolicitud> GssEstatusSolicitud { get; set; }
        public virtual DbSet<GssEstatusTarea> GssEstatusTarea { get; set; }
        public virtual DbSet<GssGrupoTrabajo> GssGrupoTrabajo { get; set; }
        public virtual DbSet<GssGrupoTrabajoUsuario> GssGrupoTrabajoUsuario { get; set; }
        public virtual DbSet<GssMtrTipoDato> GssMtrTipoDato { get; set; }
        public virtual DbSet<GssNivel> GssNivel { get; set; }
        public virtual DbSet<GssPais> GssPais { get; set; }
        public virtual DbSet<GssPasoSolicitud> GssPasoSolicitud { get; set; }
        public virtual DbSet<GssPlantillaServicio> GssPlantillaServicio { get; set; }
        public virtual DbSet<GssServicioNivel> GssServicioNivel { get; set; }
        public virtual DbSet<GssServicioResponsable> GssServicioResponsable { get; set; }
        public virtual DbSet<GssServicios> GssServicios { get; set; }
        public virtual DbSet<GssSolicitud> GssSolicitud { get; set; }
        public virtual DbSet<GssSolicitudServicio> GssSolicitudServicio { get; set; }
        public virtual DbSet<GssTarea> GssTarea { get; set; }
        public virtual DbSet<GssTareaComentario> GssTareaComentario { get; set; }
        public virtual DbSet<GssTareaPlantillaServicio> GssTareaPlantillaServicio { get; set; }
        public virtual DbSet<GssTipoDocumento> GssTipoDocumento { get; set; }
        public virtual DbSet<GssTipoServicio> GssTipoServicio { get; set; }
        public virtual DbSet<GssUnidadServicio> GssUnidadServicio { get; set; }
        public virtual DbSet<GssUnidadServicioCompañia> GssUnidadServicioCompañia { get; set; }
        public virtual DbSet<GssUsuarioCompañia> GssUsuarioCompañia { get; set; }
        public virtual DbSet<GssUsuarioNivel> GssUsuarioNivel { get; set; }
        public virtual DbSet<GssUsuarioPlantillaServicio> GssUsuarioPlantillaServicio { get; set; }
        public virtual DbSet<GssVariable> GssVariable { get; set; }
        public virtual DbSet<Marm> Marm { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<MtrBancos> MtrBancos { get; set; }
        public virtual DbSet<MtrCliente> MtrCliente { get; set; }
        public virtual DbSet<MtrDirecciones> MtrDirecciones { get; set; }
        public virtual DbSet<MtrClienteProspecto> MtrClienteProspecto { get; set; }
        public virtual DbSet<MtrClienteTemp> MtrClienteTemp { get; set; }
        public virtual DbSet<MtrCondicionPago> MtrCondicionPago { get; set; }
        public virtual DbSet<MtrContactos> MtrContactos { get; set; }
        public virtual DbSet<MtrEmpleado> MtrEmpleado { get; set; }
        public virtual DbSet<MtrFechaFeriada> MtrFechaFeriada { get; set; }
        public virtual DbSet<MtrHorarioLaborable> MtrHorarioLaborable { get; set; }
        public virtual DbSet<MtrOficina> MtrOficina { get; set; }
        public virtual DbSet<MtrPerfilCorreo> MtrPerfilCorreo { get; set; }
        public virtual DbSet<MtrProducto> MtrProducto { get; set; }
        public virtual DbSet<MtrProductoBasica> MtrProductoBasica { get; set; }
        public virtual DbSet<MtrProductoOpuesta> MtrProductoOpuesta { get; set; }
        public virtual DbSet<MtrProductoPapeles> MtrProductoPapeles { get; set; }
        public virtual DbSet<MtrTipoCuentaDestino> MtrTipoCuentaDestino { get; set; }
        public virtual DbSet<MtrTipoDocumentoFiscal> MtrTipoDocumentoFiscal { get; set; }
        public virtual DbSet<MtrTipoMoneda> MtrTipoMoneda { get; set; }
        public virtual DbSet<MtrTipoNomina> MtrTipoNomina { get; set; }
        public virtual DbSet<MtrTipoOrden> MtrTipoOrden { get; set; }
        public virtual DbSet<MtrTipoTransaccionCuentaDestino> MtrTipoTransaccionCuentaDestino { get; set; }
        public virtual DbSet<MtrTipoValorRetencion> MtrTipoValorRetencion { get; set; }
        public virtual DbSet<MtrUsuarioOficina> MtrUsuarioOficina { get; set; }
        public virtual DbSet<MtrVendedor> MtrVendedor { get; set; }
        public virtual DbSet<OfdAdjunto> OfdAdjunto { get; set; }
        public virtual DbSet<OfdAdjuntoCriterio> OfdAdjuntoCriterio { get; set; }
        public virtual DbSet<OfdAdjuntosDiseno> OfdAdjuntosDiseno { get; set; }
        public virtual DbSet<OfdAprobacionDiseno> OfdAprobacionDiseno { get; set; }
        public virtual DbSet<OfdCambioDiseno> OfdCambioDiseno { get; set; }
        public virtual DbSet<OfdConstruccionCotizacion> OfdConstruccionCotizacion { get; set; }
        public virtual DbSet<OfdCotizacion> OfdCotizacion { get; set; }
        public virtual DbSet<OfdCriterioBusqueda> OfdCriterioBusqueda { get; set; }
        public virtual DbSet<OfdDetalleSolicitudDiseno> OfdDetalleSolicitudDiseno { get; set; }
        public virtual DbSet<OfdEspecificacionCotizacion> OfdEspecificacionCotizacion { get; set; }
        public virtual DbSet<OfdEstatusFlujo> OfdEstatusFlujo { get; set; }
        public virtual DbSet<OfdFlujoEstacion> OfdFlujoEstacion { get; set; }
        public virtual DbSet<OfdGrupoCriterio> OfdGrupoCriterio { get; set; }
        public virtual DbSet<OfdGrupoTipoDocumento> OfdGrupoTipoDocumento { get; set; }
        public virtual DbSet<OfdMaestroEstacion> OfdMaestroEstacion { get; set; }
        public virtual DbSet<OfdMaestroFlujo> OfdMaestroFlujo { get; set; }
        public virtual DbSet<OfdMaestroPieImprenta> OfdMaestroPieImprenta { get; set; }
        public virtual DbSet<OfdMaestroTipoRespaldo> OfdMaestroTipoRespaldo { get; set; }
        public virtual DbSet<OfdMaestroUbicacionMarginal> OfdMaestroUbicacionMarginal { get; set; }
        public virtual DbSet<OfdMaestroVoBo> OfdMaestroVoBo { get; set; }
        public virtual DbSet<OfdObservacionAdjunto> OfdObservacionAdjunto { get; set; }
        public virtual DbSet<OfdPartesCotizacion> OfdPartesCotizacion { get; set; }
        public virtual DbSet<OfdPlantillaPreset> OfdPlantillaPreset { get; set; }
        public virtual DbSet<OfdPropuesta> OfdPropuesta { get; set; }
        public virtual DbSet<OfdPropuestaResp> OfdPropuestaResp { get; set; }
        public virtual DbSet<OfdRenglon> OfdRenglon { get; set; }
        public virtual DbSet<OfdRolTipoDocumento> OfdRolTipoDocumento { get; set; }
        public virtual DbSet<OfdSeguimiento> OfdSeguimiento { get; set; }
        public virtual DbSet<OfdSolicitudDiseno> OfdSolicitudDiseno { get; set; }
        public virtual DbSet<OfdSolicitudDisenoCambios> OfdSolicitudDisenoCambios { get; set; }
        public virtual DbSet<OfdSolicitudDocFiscal> OfdSolicitudDocFiscal { get; set; }
        public virtual DbSet<OfdTintasCotizacion> OfdTintasCotizacion { get; set; }
        public virtual DbSet<OfdTipoCambioDiseno> OfdTipoCambioDiseno { get; set; }
        public virtual DbSet<OfdTipoDocumento> OfdTipoDocumento { get; set; }
        public virtual DbSet<OfdVariablesEspecificacion> OfdVariablesEspecificacion { get; set; }
        public virtual DbSet<OfdVoBoDiseno> OfdVoBoDiseno { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<PrcNumeracionFiscal> PrcNumeracionFiscal { get; set; }
        public virtual DbSet<PrcObjetosProcesos> PrcObjetosProcesos { get; set; }
        public virtual DbSet<PrcOrdenIdPropuesta> PrcOrdenIdPropuesta { get; set; }
        public virtual DbSet<PrcPlantillaNumeraciones> PrcPlantillaNumeraciones { get; set; }
        public virtual DbSet<PrcUsuarioProcesos> PrcUsuarioProcesos { get; set; }
        public virtual DbSet<ReqAreaRequerimiento> ReqAreaRequerimiento { get; set; }
        public virtual DbSet<ReqCompañia> ReqCompañia { get; set; }
        public virtual DbSet<ReqOrigenRequerimiento> ReqOrigenRequerimiento { get; set; }
        public virtual DbSet<ReqTarea> ReqTarea { get; set; }
        public virtual DbSet<ReqTipoTarea> ReqTipoTarea { get; set; }
        public virtual DbSet<ReqVariables> ReqVariables { get; set; }
        public virtual DbSet<RrdejecutarSql> RrdejecutarSql { get; set; }
        public virtual DbSet<SapFrecuenciaVisitaCliente> SapFrecuenciaVisitaCliente { get; set; }
        public virtual DbSet<SapRetenciones> SapRetenciones { get; set; }
        public virtual DbSet<SegModulo> SegModulo { get; set; }
        public virtual DbSet<SegPrograma> SegPrograma { get; set; }
        public virtual DbSet<SegRol> SegRol { get; set; }
        public virtual DbSet<SegRolEstacion> SegRolEstacion { get; set; }
        public virtual DbSet<SegRolModulo> SegRolModulo { get; set; }
        public virtual DbSet<SegTicket> SegTicket { get; set; }
        public virtual DbSet<SegUsuario> SegUsuario { get; set; }
        public virtual DbSet<SegUsuarioRol> SegUsuarioRol { get; set; }
        public virtual DbSet<Sysfile> Sysfile { get; set; }
        public virtual DbSet<T006a> T006a { get; set; }
        public virtual DbSet<TEnControlCalculo> TEnControlCalculo { get; set; }
        public virtual DbSet<TEnEntradas> TEnEntradas { get; set; }
        public virtual DbSet<TPaFormulas> TPaFormulas { get; set; }
        public virtual DbSet<TPaModeloCalculo> TPaModeloCalculo { get; set; }
        public virtual DbSet<TPaPlantillaEntradas> TPaPlantillaEntradas { get; set; }
        public virtual DbSet<TPaSysfile> TPaSysfile { get; set; }
        public virtual DbSet<TPaTipoCalculo> TPaTipoCalculo { get; set; }
        public virtual DbSet<TPaTiposDeVariables> TPaTiposDeVariables { get; set; }
        public virtual DbSet<TPaVariables> TPaVariables { get; set; }
        public virtual DbSet<TPrCalculo> TPrCalculo { get; set; }
        public virtual DbSet<TSaCalculoHistorico> TSaCalculoHistorico { get; set; }
        public virtual DbSet<TSaEntradasHistorico> TSaEntradasHistorico { get; set; }
        public virtual DbSet<TSaReporteAnalisisCredito> TSaReporteAnalisisCredito { get; set; }
        public virtual DbSet<TempRbfactura> TempRbfactura { get; set; }
        public virtual DbSet<TempReciboCobro> TempReciboCobro { get; set; }
        public virtual DbSet<Thumbnail> Thumbnail { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<ValevenDataResumen> ValevenDataResumen { get; set; }
        public virtual DbSet<ValevenImpresiones> ValevenImpresiones { get; set; }
        public virtual DbSet<Wary074> Wary074 { get; set; }
        public virtual DbSet<Wary074temp> Wary074temp { get; set; }
        public virtual DbSet<Wary074tempReconstruir> Wary074tempReconstruir { get; set; }
        public virtual DbSet<Wary182> Wary182 { get; set; }
        public virtual DbSet<Wary241> Wary241 { get; set; }
        //public virtual DbSet<Wivy003> Wivy003 { get; set; }
        public virtual DbSet<Wsmy469> Wsmy469 { get; set; }
        public virtual DbSet<CobMatrixMonedaValidaPago> CobMatrixMonedaValidaPago { get; set; }

        public virtual DbSet<PageMenu> PageMenu { get; set; }

        public virtual DbSet<ChildMenu> ChildMenu { get; set; }


        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Server=.;Database=RRDDev;Integrated Security = true");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AppConfigApp>(entity =>
            {
                entity.Property(e => e.Clave)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppDetailQuotes>(entity =>
            {
                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.NombreComercialProducto)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CantidadSolicitada).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioUsd).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Producto).HasMaxLength(20);

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalUsd).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.HasOne(d => d.AppGeneralQuotes)
                    .WithMany(p => p.AppDetailQuotes)
                    .HasForeignKey(d => d.AppGeneralQuotesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppDetailQuotes_AppDetailQuotes");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.AppDetailQuotes)
                    .HasForeignKey(d => d.IdEstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppDetailQuotes_AppStatusQuote");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.AppDetailQuotes)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppDetailQuotes_AppDetailQuotes1");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.AppDetailQuotes)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppDetailQuotes_AppUnits");
            });

            modelBuilder.Entity<AppDetailQuotesConversionUnit>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.AppDetailQuotes)
                    .WithMany(p => p.AppDetailQuotesConversionUnit)
                    .HasForeignKey(d => d.AppDetailQuotesId)
                    .HasConstraintName("FK_AppDetailQuotesConversionUnit_AppDetailQuotes");

                entity.HasOne(d => d.AppVariable)
                    .WithMany(p => p.AppDetailQuotesConversionUnit)
                    .HasForeignKey(d => d.AppVariableId)
                    .HasConstraintName("FK_AppDetailQuotesConversionUnit_AppVariables");
            });

            modelBuilder.Entity<AppEmbarques>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("App_Embarques");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombreCategoria).HasMaxLength(100);

                entity.Property(e => e.NombreSubCategoria).HasMaxLength(100);

                entity.Property(e => e.TotalVenta).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<AppGeneralQuotes>(entity =>
            {
                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaActualiza).HasColumnType("datetime");

                entity.Property(e => e.FechaCaducidad).HasColumnType("datetime");

                entity.Property(e => e.FechaPostergada).HasColumnType("datetime");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IdDireccionEntregar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDireccionFacturar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdMtrTipoMoneda).HasDefaultValueSql("((1))");

                entity.Property(e => e.IdVendedor)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.ObservacionPostergar)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.Property(e => e.UsuarioActualiza)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.AppGeneralQuotes)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppGeneralQuotes_MtrCliente");

                /*entity.HasOne(d => d.IdCondPagoNavigation)
                    .WithMany(p => p.AppGeneralQuotes)
                    .HasForeignKey(d => d.IdCondPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppGeneralQuotes_WIVY003");*/

                entity.HasOne(d => d.IdContactoNavigation)
                    .WithMany(p => p.AppGeneralQuotes)
                    .HasForeignKey(d => d.IdContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppGeneralQuotes_MtrContactos");
                
                entity.HasOne(d => d.IdDireccionEntregarNavigation)
                    .WithMany(p => p.AppGeneralQuotesIdDireccionEntregarNavigation)
                    .HasForeignKey(d => d.IdDireccionEntregar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppGeneralQuotes_MtrDirecciones1");

                entity.HasOne(d => d.IdDireccionFacturarNavigation)
                    .WithMany(p => p.AppGeneralQuotesIdDireccionFacturarNavigation)
                    .HasForeignKey(d => d.IdDireccionFacturar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppGeneralQuotes_MtrDirecciones");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.AppGeneralQuotes)
                    .HasForeignKey(d => d.IdEstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppGeneralQuotes_AppStatusQuote");

                entity.HasOne(d => d.IdMtrTipoMonedaNavigation)
                   .WithMany(p => p.AppGeneralQuotes)
                   .HasForeignKey(d => d.IdMtrTipoMoneda)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_AppGeneralQuotes_MtrTipoMoneda");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.AppGeneralQuotes)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppGeneralQuotes_MtrVendedor");
            });

            modelBuilder.Entity<AppIngredients>(entity =>
            {
                //entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.HasOne(d => d.PrymaryMtrMoneda)
                    .WithMany(p => p.AppIngredientsPrymaryMtrMoneda)
                    .HasForeignKey(d => d.PrymaryMtrMonedaId)
                    .HasConstraintName("FK_AppIngredients_MtrTipoMoneda");

                entity.HasOne(d => d.SecundaryMtrMoneda)
                    .WithMany(p => p.AppIngredientsSecundaryMtrMoneda)
                    .HasForeignKey(d => d.SecundaryMtrMonedaId)
                    .HasConstraintName("FK_AppIngredients_MtrTipoMoneda1");
            });

            modelBuilder.Entity<AppProductVariableSearchText>(entity =>
            {
                entity.HasIndex(e => e.SearchText)
                    .HasName("IX_AppProductVariableSearchText_1");

                entity.HasIndex(e => new { e.AppVariableId, e.SearchText })
                    .HasName("IX_AppProductVariableSearchText");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SearchText).HasMaxLength(50);

                entity.HasOne(d => d.AppProduct)
                    .WithMany(p => p.AppProductVariableSearchText)
                    .HasForeignKey(d => d.AppProductId)
                    .HasConstraintName("FK_AppProductVariableSearchText_AppProducts");

                entity.HasOne(d => d.AppVariable)
                    .WithMany(p => p.AppProductVariableSearchText)
                    .HasForeignKey(d => d.AppVariableId)
                    .HasConstraintName("FK_AppProductVariableSearchText_AppVariables");
            });

            modelBuilder.Entity<AppProducts>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IDX_c5c748798c834681a2e817335d")
                    .IsUnique();

                entity.HasIndex(e => e.Description1)
                    .HasName("IDX_1c12fa4c818762546d1ba59397")
                    .IsUnique();

                entity.HasIndex(e => e.Description2)
                    .HasName("IDX_b37f2a37140a932857d2337bdf")
                    .IsUnique();

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UrlImage)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.HasOne(d => d.AppSubCategory)
                    .WithMany(p => p.AppProducts)
                    .HasForeignKey(d => d.AppSubCategoryId)
                    .HasConstraintName("FK_AppProducts_AppSubCategory");

                entity.HasOne(d => d.AppUnits)
                    .WithMany(p => p.AppProductsAppUnits)
                    .HasForeignKey(d => d.AppUnitsId)
                    .HasConstraintName("FK_AppProducts_AppUnits");

                entity.HasOne(d => d.ProductionUnit)
                    .WithMany(p => p.AppProductsProductionUnit)
                    .HasForeignKey(d => d.ProductionUnitId)
                    .HasConstraintName("FK_AppProducts_AppUnits1");

                entity.HasOne(d => d.PrymaryMtrMoneda)
                    .WithMany(p => p.AppProductsPrymaryMtrMoneda)
                    .HasForeignKey(d => d.PrymaryMtrMonedaId)
                    .HasConstraintName("FK_AppProducts_MtrTipoMoneda");

                entity.HasOne(d => d.SecundaryMtrMoneda)
                    .WithMany(p => p.AppProductsSecundaryMtrMoneda)
                    .HasForeignKey(d => d.SecundaryMtrMonedaId)
                    .HasConstraintName("FK_AppProducts_MtrTipoMoneda1");
            });

            modelBuilder.Entity<AppRecipes>(entity =>
            {
                //entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.AppIngredients)
                    .WithMany(p => p.AppRecipes)
                    .HasForeignKey(d => d.AppIngredientsId)
                    .HasConstraintName("FK_AppRecipes_AppIngredients");

                entity.HasOne(d => d.AppVariable)
                    .WithMany(p => p.AppRecipes)
                    .HasForeignKey(d => d.AppVariableId)
                    .HasConstraintName("FK_AppRecipes_AppVariables");

                entity.HasOne(d => d.Appproducts)
                    .WithMany(p => p.AppRecipes)
                    .HasForeignKey(d => d.AppproductsId)
                    .HasConstraintName("FK_AppRecipes_AppProducts");
            });

            modelBuilder.Entity<AppStatusQuote>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Abreviado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CondicionRazonId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlagActiva)
                    .HasColumnName("Flag_Activa")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagCaducaInactiva)
                    .HasColumnName("Flag_CaducaInactiva")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FlagCaducada)
                    .HasColumnName("Flag_Caducada")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagEnEspera)
                    .HasColumnName("Flag_EnEspera")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagGanada)
                    .HasColumnName("Flag_Ganada")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagModificar)
                    .HasColumnName("Flag_Modificar")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagPerdida)
                    .HasColumnName("Flag_Perdida")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FlagPostergada)
                    .HasColumnName("Flag_Postergada")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrimeraEstacion).HasMaxLength(1);
            });

            modelBuilder.Entity<AppSubCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AppCategory)
                    .WithMany(p => p.AppSubCategory)
                    .HasForeignKey(d => d.AppCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppSubCategory_AppCategory");
            });
            modelBuilder.Entity<AppTemplateConversionUnit>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Formula).HasDefaultValueSql("('')");

                entity.Property(e => e.FormulaValue).HasDefaultValueSql("('')");

                entity.Property(e => e.OrderCalculate).HasDefaultValueSql("((0))");

                entity.Property(e => e.SumValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.AppUnitIdSinceNavigation)
                    .WithMany(p => p.AppTemplateConversionUnitAppUnitIdSinceNavigation)
                    .HasForeignKey(d => d.AppUnitIdSince)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppTemplateConversionUnit_AppUnits");

                entity.HasOne(d => d.AppUnitIdUntilNavigation)
                    .WithMany(p => p.AppTemplateConversionUnitAppUnitIdUntilNavigation)
                    .HasForeignKey(d => d.AppUnitIdUntil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppTemplateConversionUnit_AppUnits1");

                entity.HasOne(d => d.AppVariable)
                    .WithMany(p => p.AppTemplateConversionUnit)
                    .HasForeignKey(d => d.AppVariableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppTemplateConversionUnit_AppVariables");
            });
            modelBuilder.Entity<AppUnits>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_AppUnits")
                    .IsUnique();

                entity.HasIndex(e => e.Description1)
                    .HasName("IX_AppUnits_1");

                entity.HasIndex(e => e.Description2)
                    .HasName("IX_AppUnits_2");

                entity.HasIndex(e => e.Description3)
                    .HasName("IX_AppUnits_3");

                entity.HasIndex(e => e.Description4)
                    .HasName("IX_AppUnits_4");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description1)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.Description3)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Description4)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);
            });

            modelBuilder.Entity<AppUnitsofMeasureforIngredients>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Denominator).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Numerator).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.HasOne(d => d.AppIngredients)
                    .WithMany(p => p.AppUnitsofMeasureforIngredients)
                    .HasForeignKey(d => d.AppIngredientsId)
                    .HasConstraintName("FK_AppUnitsofMeasureforIngredients_AppIngredients");

                entity.HasOne(d => d.AppUnits)
                    .WithMany(p => p.AppUnitsofMeasureforIngredients)
                    .HasForeignKey(d => d.AppUnitsId)
                    .HasConstraintName("FK_AppUnitsofMeasureforIngredients_AppUnits");
            });

            modelBuilder.Entity<AppUnitsofMeasureforMaterials>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Denominator).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Numerator).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.HasOne(d => d.AppProducts)
                    .WithMany(p => p.AppUnitsofMeasureforMaterials)
                    .HasForeignKey(d => d.AppProductsId)
                    .HasConstraintName("FK_AppUnitsofMeasureforMaterials_AppProducts");

                entity.HasOne(d => d.AppUnits)
                    .WithMany(p => p.AppUnitsofMeasureforMaterials)
                    .HasForeignKey(d => d.AppUnitsId)
                    .HasConstraintName("FK_AppUnitsofMeasureforMaterials_AppUnits");
            });
            modelBuilder.Entity<AppVariableSearch>(entity =>
            {
                entity.Property(e => e.SearchText).HasMaxLength(50);

                entity.HasOne(d => d.AppSubCategory)
                    .WithMany(p => p.AppVariableSearch)
                    .HasForeignKey(d => d.AppSubCategoryId)
                    .HasConstraintName("FK_AppVariableSearch_AppSubCategory");

                entity.HasOne(d => d.AppVariable)
                    .WithMany(p => p.AppVariableSearch)
                    .HasForeignKey(d => d.AppVariableId)
                    .HasConstraintName("FK_AppVariableSearch_AppVariables");
            });
            modelBuilder.Entity<AppVariables>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IDX_fa6816ce90cf44a526144256df")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);
            });


            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FieldName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OldValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Pk)
                    .HasColumnName("PK")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId);

                entity.HasIndex(e => new { e.TableName, e.AuditDate })
                    .HasName("idx_AutoAudit_TableName_AuditDate");

                entity.Property(e => e.AuditId).HasColumnName("AuditID");

                entity.Property(e => e.AuditDate).HasColumnType("datetime");

                entity.Property(e => e.AuditUserName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NewContent).HasColumnType("xml");

                entity.Property(e => e.OldContent).HasColumnType("xml");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cary028>(entity =>
            {
                entity.HasKey(e => e.NotaCredito)
                    .HasName("CARY028_INDEX01");

                entity.ToTable("CARY028");

                entity.Property(e => e.NotaCredito)
                    .HasColumnName("NOTA_CREDITO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfectaFactura)
                    .IsRequired()
                    .HasColumnName("AFECTA_FACTURA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AfectaNota)
                    .IsRequired()
                    .HasColumnName("AFECTA_NOTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantResumen)
                    .HasColumnName("CANT_RESUMEN")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CantRevive)
                    .HasColumnName("CANT_REVIVE")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.ColetillaInd1)
                    .HasColumnName("COLETILLA_IND1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd2)
                    .HasColumnName("COLETILLA_IND2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd3)
                    .HasColumnName("COLETILLA_IND3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd4)
                    .HasColumnName("COLETILLA_IND4")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Contrapartida)
                    .IsRequired()
                    .HasColumnName("CONTRAPARTIDA")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CuentaContable)
                    .HasColumnName("CUENTA_CONTABLE")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DescResumen1)
                    .HasColumnName("DESC_RESUMEN1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescResumen2)
                    .HasColumnName("DESC_RESUMEN2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion1)
                    .IsRequired()
                    .HasColumnName("DIRECCION1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion2)
                    .IsRequired()
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion3)
                    .HasColumnName("DIRECCION3")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagAfecVende)
                    .IsRequired()
                    .HasColumnName("FLAG_AFEC_VENDE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagComision)
                    .IsRequired()
                    .HasColumnName("FLAG_COMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImpreso)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRESO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ImpPorConsumo)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasColumnType("decimal(14, 4)");

                entity.Property(e => e.ImpSobVentas)
                    .HasColumnName("IMP_SOB_VENTAS")
                    .HasColumnType("decimal(14, 4)");

                entity.Property(e => e.Impuesto)
                    .HasColumnName("IMPUESTO")
                    .HasColumnType("decimal(14, 4)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Iq).HasColumnName("IQ");

                entity.Property(e => e.Ir).HasColumnName("IR");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.Motivo).HasColumnName("MOTIVO");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroControl).HasColumnName("NRO_CONTROL");

                entity.Property(e => e.Nula)
                    .IsRequired()
                    .HasColumnName("NULA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsCobranzas1)
                    .HasColumnName("OBS_COBRANZAS1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas2)
                    .HasColumnName("OBS_COBRANZAS2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas3)
                    .HasColumnName("OBS_COBRANZAS3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas4)
                    .HasColumnName("OBS_COBRANZAS4")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion1)
                    .IsRequired()
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .IsRequired()
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .IsRequired()
                    .HasColumnName("OBSERVACION3")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PorcConcesion)
                    .HasColumnName("PORC_CONCESION")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasColumnName("RESPONSABLE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ReviveJob)
                    .IsRequired()
                    .HasColumnName("REVIVE_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasColumnName("RIF")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rif2)
                    .IsRequired()
                    .HasColumnName("RIF2")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RimpPorConsum)
                    .HasColumnName("RIMP_POR_CONSUM")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RimpSobVentas)
                    .HasColumnName("RIMP_SOB_VENTAS")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rimpuesto)
                    .HasColumnName("RIMPUESTO")
                    .HasColumnType("decimal(14, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rvalor)
                    .HasColumnName("RVALOR")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RVALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaImpuesto)
                    .HasColumnName("TASA_IMPUESTO")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.TipoDoc).HasColumnName("TIPO_DOC");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UndResumen)
                    .HasColumnName("UND_RESUMEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadFacturar).HasColumnName("UNIDAD_FACTURAR");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Valor1)
                    .HasColumnName("VALOR_$")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Valorfactura)
                    .HasColumnName("VALORFACTURA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cary029>(entity =>
            {
                entity.HasKey(e => new { e.NumeroNota, e.Recnum })
                    .HasName("CARY029_INDEX01");

                entity.ToTable("CARY029");

                entity.Property(e => e.NumeroNota).HasColumnName("NUMERO_NOTA");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Almacen)
                    .HasColumnName("ALMACEN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnName("BS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnName("BS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnName("BS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnName("BS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasColumnName("COD_PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Costo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CtaConc)
                    .IsRequired()
                    .HasColumnName("CTA_CONC")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtaLista)
                    .IsRequired()
                    .HasColumnName("CTA_LISTA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion2)
                    .HasColumnName("DESCRIPCION2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Estadisticas)
                    .IsRequired()
                    .HasColumnName("ESTADISTICAS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Exento)
                    .HasColumnName("EXENTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaNota)
                    .HasColumnName("FECHA_NOTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormasUnidad)
                    .HasColumnName("FORMAS_UNIDAD")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.IdSolicitudCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCostoCpj)
                    .HasColumnName("IdSolicitudCosto_CPJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idsolicitud)
                    .HasColumnName("idsolicitud")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpPorConsumo)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ImpSobVentas)
                    .HasColumnName("IMP_SOB_VENTAS")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Ivarefact)
                    .HasColumnName("IVAREFACT")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasColumnName("LINEA1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaUniDol)
                    .HasColumnName("LISTA_UNI_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Millares)
                    .HasColumnName("MILLARES")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pieslineales)
                    .HasColumnName("PIESLINEALES")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnName("PORC_MC_FINAN")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Preciounidad)
                    .HasColumnName("PRECIOUNIDAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RecalcularMargen).HasMaxLength(1);

                entity.Property(e => e.RimpPorConsum)
                    .HasColumnName("RIMP_POR_CONSUM")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.RimpSobVentas)
                    .HasColumnName("RIMP_SOB_VENTAS")
                    .HasColumnType("decimal(12, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Riva)
                    .HasColumnName("RIVA")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnName("RPRECIO_VENTA")
                    .HasColumnType("decimal(20, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpreciounidad)
                    .HasColumnName("RPRECIOUNIDAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RVALOR_LISTA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnName("RVALOR_VENTA")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TipoDoc).HasColumnName("TIPO_DOC");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasColumnName("TIPO_PAPEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalparcialFa)
                    .HasColumnName("TOTALPARCIAL_FA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadFacturar)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Unidadesfact)
                    .HasColumnName("UNIDADESFACT")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR_$")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorVentaCpj)
                    .HasColumnName("VALOR_VENTA_CPJ")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VentaUniDol)
                    .HasColumnName("VENTA_UNI_DOL")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<CatAuditoriaCalculo>(entity =>
            {
                entity.Property(e => e.Codigo).HasMaxLength(12);

                entity.Property(e => e.DescripcionFormula).HasMaxLength(4000);

                entity.Property(e => e.EntradaCalculo).HasMaxLength(20);

                entity.Property(e => e.Formula)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.IdCalculo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.Item).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NombreVariable)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrdenCalculo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CatCalibrePapel>(entity =>
            {
                entity.HasKey(e => e.Papel);

                entity.ToTable("Cat_CalibrePapel");

                entity.Property(e => e.Papel).HasMaxLength(100);

                entity.Property(e => e.Calibre).HasColumnType("decimal(18, 8)");
            });

            modelBuilder.Entity<CatCalibrePapelRollos>(entity =>
            {
                entity.ToTable("Cat_CalibrePapelRollos");

                entity.Property(e => e.CatCalibrePapelRollosId).HasColumnName("Cat_CalibrePapelRollosId");

                entity.Property(e => e.Calibre).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Papel)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CatCodigoMayorPartesBasica>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cat_CodigoMayor_Partes_Basica");

                entity.Property(e => e.BasicaBusqueda).HasMaxLength(50);

                entity.Property(e => e.CodigoMayor)
                    .HasColumnName("Codigo_Mayor")
                    .HasMaxLength(50);

                entity.Property(e => e.Frecuencia).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<CatLista>(entity =>
            {
                entity.ToTable("Cat_Lista");

                entity.Property(e => e.CatListaId).HasColumnName("Cat_ListaId");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12);

                entity.Property(e => e.Descripcion).HasMaxLength(400);

                entity.Property(e => e.Duracion).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IdCalculo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IncrementoCantidad).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioMaximo)
                    .HasColumnName("Precio_Maximo")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioMinimo)
                    .HasColumnName("Precio_Minimo")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.CatMaterial)
                    .WithMany(p => p.CatLista)
                    .HasForeignKey(d => d.CatMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cat_Lista_CatMaterial");

              
            });

            modelBuilder.Entity<CatMaterial>(entity =>
            {
                entity.HasIndex(e => e.CatMedidaBasicaId)
                    .HasName("IX_CatMedidaBasicaId");

                entity.HasIndex(e => e.Codigo)
                    .HasName("CatMaterial_Codigo_Index")
                    .IsUnique();

                entity.HasIndex(e => new { e.CatProductoMayorId, e.CatProductoMayorPartesId, e.CatProductoMayorPartesTintasId, e.CatProductoMayorPartesTintasBasicaId, e.CatProductoMayorPartesTintasBasicaOpuestaId, e.CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbonId, e.CatProductoMayorPartesTintasBasicaOpuestaPapelesId })
                    .HasName("IX_CatMaterial");

                entity.HasIndex(e => new { e.CodigoProduct, e.Partes, e.Tintas, e.BasicaBusqueda, e.OpuestaBusqueda, e.PapelesBusqueda, e.CarbonBusqueda })
                    .HasName("IX_CatMaterial_1")
                    .IsUnique();

                entity.Property(e => e.BasicaBusqueda).HasMaxLength(10);

                entity.Property(e => e.BasicaDecimal)
                    .HasColumnType("numeric(18, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CalibrePapelRollos).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.CarbonBusqueda).HasMaxLength(100);

                entity.Property(e => e.Codigo).HasMaxLength(12);

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12);

                entity.Property(e => e.Combinacion).HasMaxLength(400);

                entity.Property(e => e.Descripcion).HasMaxLength(400);

                entity.Property(e => e.ManejaInv)
                    .HasColumnName("MANEJA_INV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OpuestaBusqueda).HasMaxLength(100);

                entity.Property(e => e.PapelesBusqueda).HasMaxLength(200);

                entity.HasOne(d => d.CatMedidaBasica)
                    .WithMany(p => p.CatMaterial)
                    .HasForeignKey(d => d.CatMedidaBasicaId)
                    .HasConstraintName("FK_dbo.CatMaterial_dbo.CatMedidaBasica_CatMedidaBasicaId");

                entity.HasOne(d => d.CodigoProductNavigation)
                    .WithMany(p => p.CatMaterial)
                    .HasForeignKey(d => d.CodigoProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatMaterial_MtrProducto");
            });

            modelBuilder.Entity<CatMaterialDetalle>(entity =>
            {
                entity.HasIndex(e => e.CatMaterialId)
                    .HasName("IX_CatMaterialId");

                entity.HasIndex(e => e.CatMedidaOpuestaId)
                    .HasName("IX_CatMedidaOpuestaId");

                entity.HasOne(d => d.CatMaterial)
                    .WithMany(p => p.CatMaterialDetalle)
                    .HasForeignKey(d => d.CatMaterialId)
                    .HasConstraintName("FK_dbo.CatMaterialDetalle_dbo.CatMaterial_CatMaterialId");

                entity.HasOne(d => d.CatMedidaOpuesta)
                    .WithMany(p => p.CatMaterialDetalle)
                    .HasForeignKey(d => d.CatMedidaOpuestaId)
                    .HasConstraintName("FK_dbo.CatMaterialDetalle_dbo.CatMedidaOpuesta_CatMedidaOpuestaId");
            });

            modelBuilder.Entity<CatMaterialDetalleTmp>(entity =>
            {
                entity.HasIndex(e => e.CatMedidaOpuestaId)
                    .HasName("IX_CatMedidaOpuestaId");

                entity.HasIndex(e => e.CatPapelId)
                    .HasName("IX_CatPapelId");

                entity.Property(e => e.CatPapelId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CatMedidaOpuesta)
                    .WithMany(p => p.CatMaterialDetalleTmp)
                    .HasForeignKey(d => d.CatMedidaOpuestaId)
                    .HasConstraintName("FK_dbo.CatMaterialDetalleTmp_dbo.CatMedidaOpuesta_CatMedidaOpuestaId");

                entity.HasOne(d => d.CatPapel)
                    .WithMany(p => p.CatMaterialDetalleTmp)
                    .HasForeignKey(d => d.CatPapelId)
                    .HasConstraintName("FK_dbo.CatMaterialDetalleTmp_dbo.CatPapel_CatPapelId");
            });

            modelBuilder.Entity<CatMedidaBasica>(entity =>
            {
                entity.HasKey(e => e.Medida);

                entity.ToTable("Cat_MedidaBasica");

                entity.Property(e => e.Medida)
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(50);

                entity.Property(e => e.MedidaIn)
                    .HasColumnName("MEDIDA_IN")
                    .HasMaxLength(10);

                entity.Property(e => e.MedidaMm)
                    .HasColumnName("MEDIDA_MM")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<CatMedidaBasica1>(entity =>
            {
                entity.HasKey(e => e.CatMedidaBasicaId)
                    .HasName("PK_dbo.CatMedidaBasica");

                entity.ToTable("CatMedidaBasica");

                entity.HasIndex(e => e.MedidaBusqueda)
                    .HasName("CatMedidaBasica_MedidaBusqueda_Index");

                entity.HasIndex(e => e.MedidaString)
                    .HasName("CatMedidaBasica_MedidaString_Index")
                    .IsUnique();

                entity.Property(e => e.MedidaBusqueda)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.MedidaDecimal).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.MedidaString)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<CatMedidaBasicaRollos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cat_MedidaBasicaRollos");

                entity.Property(e => e.CatMedidaBasicaRollosId).HasColumnName("Cat_MedidaBasicaRollosId");

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(50);

                entity.Property(e => e.MedidaIn)
                    .HasColumnName("MEDIDA_IN")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MedidaMm)
                    .HasColumnName("MEDIDA_MM")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<CatMedidaOpuesta>(entity =>
            {
                entity.HasIndex(e => e.MedidaBusqueda)
                    .HasName("CatMedidaOpuesta_MedidaBusqueda_Index");

                entity.HasIndex(e => e.MedidaString)
                    .HasName("CatMedidaOpuesta_MedidaString_Index")
                    .IsUnique();

                entity.Property(e => e.MedidaBusqueda)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.MedidaDecimal).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.MedidaString)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<CatPapel>(entity =>
            {
                entity.Property(e => e.CatPapelId).HasMaxLength(20);

                entity.Property(e => e.Descripcion).HasMaxLength(256);
            });

            modelBuilder.Entity<CatProductoMayor>(entity =>
            {
                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12);

                entity.Property(e => e.Descripcion).HasMaxLength(400);

                entity.Property(e => e.Inactivo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CatProductoMayorPartes>(entity =>
            {
                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<CatProductoMayorPartesTintas>(entity =>
            {
                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<CatProductoMayorPartesTintasBasica>(entity =>
            {
                entity.Property(e => e.BasicaBusqueda).HasMaxLength(100);

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<CatProductoMayorPartesTintasBasicaOpuesta>(entity =>
            {
                entity.Property(e => e.BasicaBusqueda).HasMaxLength(100);

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12);

                entity.Property(e => e.OpuestaBusqueda).HasMaxLength(100);
            });

            modelBuilder.Entity<CatProductoMayorPartesTintasBasicaOpuestaPapeles>(entity =>
            {
                entity.Property(e => e.BasicaBusqueda).HasMaxLength(100);

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12);

                entity.Property(e => e.OpuestaBusqueda).HasMaxLength(100);

                entity.Property(e => e.PapelesBusqueda).HasMaxLength(100);
            });

            modelBuilder.Entity<CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon>(entity =>
            {
                entity.Property(e => e.BasicaBusqueda).HasMaxLength(100);

                entity.Property(e => e.CarbonBusqueda).HasMaxLength(100);

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12);

                entity.Property(e => e.OpuestaBusqueda).HasMaxLength(100);

                entity.Property(e => e.PapelesBusqueda).HasMaxLength(100);
            });

            modelBuilder.Entity<CatProductoMayorUnidadesConversion>(entity =>
            {
                entity.Property(e => e.Calculado).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12);

                entity.Property(e => e.Msehi)
                    .HasColumnName("MSEHI")
                    .HasMaxLength(18);

                entity.Property(e => e.Msehl)
                    .HasColumnName("MSEHL")
                    .HasMaxLength(18);

                entity.Property(e => e.Umren)
                    .HasColumnName("UMREN")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Umrez)
                    .HasColumnName("UMREZ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.UnidadsapVentainterna)
                    .HasColumnName("UNIDADSAP_VENTAINTERNA")
                    .HasMaxLength(3);

                entity.HasOne(d => d.CodigoProductNavigation)
                    .WithMany(p => p.CatProductoMayorUnidadesConversion)
                    .HasForeignKey(d => d.CodigoProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatProductoMayorUnidadesConversion_MtrProducto");
            });

            modelBuilder.Entity<CatSubCategoria>(entity =>
            {
                entity.HasKey(e => e.IdSubCategoria);

                entity.ToTable("Cat_SubCategoria");

                entity.Property(e => e.IdSubCategoria).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatSysfile>(entity =>
            {
                entity.ToTable("Cat_Sysfile");

                entity.Property(e => e.CatSysfileId).HasColumnName("Cat_SysfileId");

                entity.Property(e => e.FechaModificacionMateriales).HasMaxLength(20);

                entity.Property(e => e.FechaPublicacion).HasMaxLength(20);
            });

            modelBuilder.Entity<Ciny056>(entity =>
            {
                entity.HasKey(e => new { e.Factura, e.CentroFact, e.TipoDoc })
                    .HasName("CINY056_INDEX01");

                entity.ToTable("CINY056");

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.CentroFact).HasColumnName("CENTRO_FACT");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.AnoFactura)
                    .HasColumnName("ANO_FACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anticipo)
                    .HasColumnName("ANTICIPO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anulada)
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cajas)
                    .HasColumnName("CAJAS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantResumen)
                    .HasColumnName("CANT_RESUMEN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClienteJde)
                    .HasColumnName("CLIENTE_JDE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRepetici)
                    .HasColumnName("CODIGO_REPETICI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ColetillaInd1)
                    .HasColumnName("COLETILLA_IND1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd2)
                    .HasColumnName("COLETILLA_IND2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd3)
                    .HasColumnName("COLETILLA_IND3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColetillaInd4)
                    .HasColumnName("COLETILLA_IND4")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CondicionPago)
                    .HasColumnName("CONDICION_PAGO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cotizacion).HasMaxLength(20);

                entity.Property(e => e.CredConta)
                    .HasColumnName("CRED_CONTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dciudad)
                    .HasColumnName("DCIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescResumen1)
                    .HasColumnName("DESC_RESUMEN1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescResumen2)
                    .HasColumnName("DESC_RESUMEN2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Destado)
                    .HasColumnName("DESTADO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DireccFiscal)
                    .HasColumnName("DIRECC_FISCAL")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionEmb1)
                    .HasColumnName("DIRECCION_EMB1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb2)
                    .HasColumnName("DIRECCION_EMB2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb3)
                    .HasColumnName("DIRECCION_EMB3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact1)
                    .HasColumnName("DIRECCION_FACT1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .HasColumnName("DIRECCION_FACT2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact3)
                    .HasColumnName("DIRECCION_FACT3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DocumentoSap).HasMaxLength(10);

                entity.Property(e => e.Dolar)
                    .HasColumnName("DOLAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.FactAdelantada)
                    .HasColumnName("FACT_ADELANTADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FactFinal)
                    .HasColumnName("FACT_FINAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FacturaRepetir)
                    .HasColumnName("FACTURA_REPETIR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAnulada)
                    .HasColumnName("FECHA_ANULADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnName("FECHA_DESPACHO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaRecibCli)
                    .HasColumnName("FECHA_RECIB_CLI")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Field98)
                    .HasColumnName("FIELD98")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fiscal)
                    .HasColumnName("FISCAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagComision)
                    .HasColumnName("FLAG_COMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagGeneroPdf)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagImpreso)
                    .HasColumnName("FLAG_IMPRESO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Flete)
                    .HasColumnName("FLETE")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDireccion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Imp)
                    .HasColumnName("IMP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpStock)
                    .HasColumnName("IMP_STOCK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.LineaAnt)
                    .HasColumnName("LINEA_ANT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MesFactura)
                    .HasColumnName("MES_FACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Miscelaneo)
                    .HasColumnName("MISCELANEO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MultiplesEmb)
                    .HasColumnName("MULTIPLES_EMB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NcFacturar)
                    .HasColumnName("NC_FACTURAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NitEmb)
                    .HasColumnName("NIT_EMB")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NitFact)
                    .HasColumnName("NIT_FACT")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreEmb)
                    .HasColumnName("NOMBRE_EMB")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreFact)
                    .HasColumnName("NOMBRE_FACT")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroControl)
                    .HasColumnName("NRO_CONTROL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NroNc)
                    .HasColumnName("NRO_NC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NuevaLineaAnt)
                    .HasColumnName("NUEVA_LINEA_ANT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObsCobranzas1)
                    .HasColumnName("OBS_COBRANZAS1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas2)
                    .HasColumnName("OBS_COBRANZAS2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas3)
                    .HasColumnName("OBS_COBRANZAS3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObsCobranzas4)
                    .HasColumnName("OBS_COBRANZAS4")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion1)
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .HasColumnName("OBSERVACION3")
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("ORDEN_COMPRA")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OtroGasto1)
                    .HasColumnName("OTRO_GASTO_1")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtroGasto2)
                    .HasColumnName("OTRO_GASTO_2")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pltyp)
                    .HasColumnName("PLTYP")
                    .HasMaxLength(2);

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.RegistroTribut)
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifEmb)
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RotroGasto1)
                    .HasColumnName("ROTRO_GASTO_1")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RsdoAnticipo)
                    .HasColumnName("RSDO_ANTICIPO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RVALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnName("RVALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SdoAnticipo)
                    .HasColumnName("SDO_ANTICIPO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SdoAnticipoDo)
                    .HasColumnName("SDO_ANTICIPO_DO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Seguro)
                    .HasColumnName("SEGURO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaAnticipo)
                    .HasColumnName("TASA_ANTICIPO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TasaImpuesto)
                    .HasColumnName("TASA_IMPUESTO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalParcial)
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transmision)
                    .HasColumnName("TRANSMISION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UndResumen)
                    .HasColumnName("UND_RESUMEN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadFacturar)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VendGestion)
                    .HasColumnName("VEND_GESTION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ciny057>(entity =>
            {
                entity.HasKey(e => new { e.Factura, e.CentroFact, e.TipoDoc, e.Recnum })
                    .HasName("CINY057_INDEX01");

                entity.ToTable("CINY057");

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.CentroFact).HasColumnName("CENTRO_FACT");

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("TIPO_DOC")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Almacen)
                    .HasColumnName("ALMACEN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnName("ARTICULO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnName("BS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnName("BS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnName("BS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnName("BS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bsmc)
                    .HasColumnName("BSMC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BultoDesp)
                    .HasColumnName("BULTO_DESP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BultoTran)
                    .HasColumnName("BULTO_TRAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bultos).HasColumnName("BULTOS");

                entity.Property(e => e.CantEntregar)
                    .HasColumnName("CANT_ENTREGAR")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Copy)
                    .HasColumnName("COPY")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Costo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CtaConc)
                    .IsRequired()
                    .HasColumnName("CTA_CONC")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtaLista)
                    .IsRequired()
                    .HasColumnName("CTA_LISTA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion1)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion2)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb)
                    .HasColumnName("DIRECCION_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionFact)
                    .HasColumnName("DIRECCION_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.Estadisticas)
                    .IsRequired()
                    .HasColumnName("ESTADISTICAS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasColumnName("FAMILIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecComproClte)
                    .HasColumnName("FEC_COMPRO_CLTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnName("FEC_REC_PLANEAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaOrden)
                    .HasColumnName("FECHA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaProg)
                    .HasColumnName("FECHA_PROG")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagFaltante)
                    .IsRequired()
                    .HasColumnName("FLAG_FALTANTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImprenta)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRENTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasColumnName("FLAG_RETENIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoOrden)
                    .IsRequired()
                    .HasColumnName("FLAG_TIPO_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FormasBajotiro).HasColumnName("FORMAS_BAJOTIRO");

                entity.Property(e => e.FormasUnidad)
                    .HasColumnName("FORMAS_UNIDAD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GeneraDespacho)
                    .HasColumnName("GENERA_DESPACHO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdPrelista).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSolicitud)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSolicitudCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCostoCpj)
                    .HasColumnName("IdSolicitudCosto_CPJ")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImpStock)
                    .HasColumnName("IMP_STOCK")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Impuesto1)
                    .HasColumnName("IMPUESTO_1")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Impuesto2)
                    .HasColumnName("IMPUESTO_2")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnName("IMPUESTO_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.KiloBulto)
                    .HasColumnName("KILO_BULTO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasColumnName("LINEA1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lipamepa)
                    .IsRequired()
                    .HasColumnName("LIPAMEPA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaUniDol)
                    .HasColumnName("LISTA_UNI_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MetodoCalculo).HasDefaultValueSql("((0))");

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasColumnName("METODO_PRECIO1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Millares)
                    .IsRequired()
                    .HasColumnName("MILLARES")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoEntrega).HasColumnName("NO_ENTREGA");

                entity.Property(e => e.NombreEmb)
                    .HasColumnName("NOMBRE_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.NombreFact)
                    .HasColumnName("NOMBRE_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.NumCliDesde)
                    .HasColumnName("NUM_CLI_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliDesdeE)
                    .HasColumnName("NUM_CLI_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliHasta)
                    .HasColumnName("NUM_CLI_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCliHastaE)
                    .HasColumnName("NUM_CLI_HASTA_E")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDesde)
                    .IsRequired()
                    .HasColumnName("NUMERO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDesdeE)
                    .HasColumnName("NUMERO_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroHasta)
                    .IsRequired()
                    .HasColumnName("NUMERO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroHastaE)
                    .HasColumnName("NUMERO_HASTA_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("PAIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasColumnName("PARTES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pieslineales)
                    .HasColumnName("PIESLINEALES")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnName("PORC_MC_FINAN")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Preciounidad)
                    .HasColumnName("PRECIOUNIDAD")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.PrefijoCli)
                    .HasColumnName("PREFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoCliE)
                    .HasColumnName("PREFIJO_CLI_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoDesde)
                    .IsRequired()
                    .HasColumnName("PREFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoDesdeE)
                    .HasColumnName("PREFIJO_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefijoHasta)
                    .IsRequired()
                    .HasColumnName("PREFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoHastaE)
                    .HasColumnName("PREFIJO_HASTA_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnName("RBS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcFinansc)
                    .HasColumnName("RBS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnName("RBS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapelsc)
                    .HasColumnName("RBS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rbsmc)
                    .HasColumnName("RBSMC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecalcularMargen)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegistroTribut)
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RemisionOfi)
                    .HasColumnName("REMISION_OFI")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportadoSeniat).HasMaxLength(1);

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rimpuesto1)
                    .HasColumnName("RIMPUESTO_1")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprecioLista)
                    .HasColumnName("RPRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnName("RPRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpreciounidad)
                    .HasColumnName("RPRECIOUNIDAD")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnName("RVALOR_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnName("RVALOR_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SufijoCli)
                    .HasColumnName("SUFIJO_CLI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoCliE)
                    .HasColumnName("SUFIJO_CLI_E")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoDesde)
                    .IsRequired()
                    .HasColumnName("SUFIJO_DESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoDesdeE)
                    .HasColumnName("SUFIJO_DESDE_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SufijoHasta)
                    .IsRequired()
                    .HasColumnName("SUFIJO_HASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoHastaE)
                    .HasColumnName("SUFIJO_HASTA_E")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasColumnName("TIPO_PAPEL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFacturar)
                    .IsRequired()
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Unidadesent)
                    .HasColumnName("UNIDADESENT")
                    .HasColumnType("decimal(16, 3)");

                entity.Property(e => e.Unidadesfact)
                    .HasColumnName("UNIDADESFACT")
                    .HasColumnType("decimal(16, 3)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorLista)
                    .HasColumnName("VALOR_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorListad)
                    .HasColumnName("VALOR_LISTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVenta)
                    .HasColumnName("VALOR_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVentaCpj)
                    .HasColumnName("VALOR_VENTA_CPJ")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ValorVentad)
                    .HasColumnName("VALOR_VENTAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VentaUniDol)
                    .HasColumnName("VENTA_UNI_DOL")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<CobAdjuntosCobranza>(entity =>
            {
                entity.HasKey(e => e.IdAdjunto);

                entity.HasIndex(e => e.Documento)
                    .HasName("IX_CobAdjuntosCobranza");

                entity.HasIndex(e => new { e.Documento, e.IdTipoDocumento })
                    .HasName("IX_CobAdjuntosCobranza_1");

                //entity.Property(e => e.Archivo).IsRequired();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ruta).HasMaxLength(600);

                entity.HasOne(d => d.DocumentoNavigation)
                    .WithMany(p => p.CobAdjuntosCobranza)
                    .HasForeignKey(d => d.Documento)
                    .HasConstraintName("FK_CobAdjuntosCobranza_CobGeneralCobranza");
            });

            modelBuilder.Entity<CobAvisosCobro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cob_AvisosCobro");

                entity.HasIndex(e => e.Cliente)
                    .HasName("IX_Cob_AvisosCobro");

                entity.HasIndex(e => e.Fecha)
                    .HasName("IX_Cob_AvisosCobro_1");

                entity.HasIndex(e => e.Procesado)
                    .HasName("IX_Cob_AvisosCobro_2");

                entity.Property(e => e.Archivo).IsRequired();

                entity.Property(e => e.ArchivotTiff).IsRequired();

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Html).HasColumnName("HTML");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CobAvisosCobroTemp>(entity =>
            {
                entity.HasKey(e => e.Cliente);

                entity.ToTable("Cob_AvisosCobro_Temp");

                entity.HasIndex(e => e.Cliente)
                    .HasName("IX_Cob_AvisosCobro_Temp");

                entity.HasIndex(e => e.Usuario)
                    .HasName("IX_Cob_AvisosCobro_Temp_1");

                entity.Property(e => e.Cliente).HasMaxLength(10);

                entity.Property(e => e.Archivo).IsRequired();

                entity.Property(e => e.ArchivotTiff).IsRequired();

                entity.Property(e => e.Html).HasColumnName("HTML");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CobBanco>(entity =>
            {
                entity.HasKey(e => e.IdBanco);

                entity.Property(e => e.NombreBanco).HasMaxLength(50);
            });

            modelBuilder.Entity<CobDatosCheque>(entity =>
            {
                entity.HasKey(e => e.Documento);

                entity.Property(e => e.Documento).ValueGeneratedNever();

                entity.Property(e => e.FechaCheque).HasColumnType("datetime");

                entity.Property(e => e.IdBanco)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.IdTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.MontoCheque).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.DocumentoNavigation)
                    .WithOne(p => p.CobDatosCheque)
                    .HasForeignKey<CobDatosCheque>(d => d.Documento)
                    .HasConstraintName("FK_CobDatosCheque_CobGeneralCobranza");
            });

            modelBuilder.Entity<CobDescuentoIvaTipoTransaccion>(entity =>
            {
                entity.HasIndex(e => new { e.IdTipoTransaccion, e.BsDesde, e.BsHasta })
                    .HasName("IX_CobDescuentoIvaTipoTransaccion")
                    .IsUnique();

                entity.Property(e => e.BsDesde).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BsHasta).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.PorcDescuento).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<CobEstadoDeCuenta>(entity =>
            {
                entity.HasIndex(e => e.IdCliente)
                    .HasName("IX_CobEstadoDeCuenta_1");

                entity.HasIndex(e => e.Rpdoc)
                    .HasName("IX_CobEstadoDeCuenta_2");

                entity.HasIndex(e => new { e.Rpkco, e.Rpdct, e.Rpdoc, e.Rpsfx })
                    .HasName("IX_CobEstadoDeCuenta");
                   

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BaseImponible)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentoSap).HasMaxLength(10);

                entity.Property(e => e.FechaDocumento).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasMaxLength(50);

                entity.Property(e => e.Iva)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoOriginal)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OficinaVenta)
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10);

                entity.Property(e => e.Pltyp)
                    .HasColumnName("PLTYP")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('Z2')");

                entity.Property(e => e.Rpaap)
                    .HasColumnName("RPAAP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpag)
                    .HasColumnName("RPAG")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpan8)
                    .HasColumnName("RPAN8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpdct)
                    .IsRequired()
                    .HasColumnName("RPDCT")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpdoc).HasColumnName("RPDOC");

                entity.Property(e => e.Rpkco)
                    .IsRequired()
                    .HasColumnName("RPKCO")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Rpsfx)
                    .IsRequired()
                    .HasColumnName("RPSFX")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor).HasMaxLength(4);

                entity.Property(e => e.Moneda).HasMaxLength(10);

            });

            modelBuilder.Entity<CobEstadoDeCuentaBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CobEstadoDeCuentaBK");

                entity.Property(e => e.BaseImponible).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaDocumento).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdCliente).HasMaxLength(50);

                entity.Property(e => e.Iva).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MontoOriginal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OficinaVenta)
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10);

                entity.Property(e => e.Rpaap).HasColumnName("RPAAP");

                entity.Property(e => e.Rpag).HasColumnName("RPAG");

                entity.Property(e => e.Rpan8).HasColumnName("RPAN8");

                entity.Property(e => e.Rpdct)
                    .IsRequired()
                    .HasColumnName("RPDCT")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpdoc).HasColumnName("RPDOC");

                entity.Property(e => e.Rpkco)
                    .IsRequired()
                    .HasColumnName("RPKCO")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Rpsfx)
                    .IsRequired()
                    .HasColumnName("RPSFX")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor).HasMaxLength(4);
            });

            modelBuilder.Entity<CobExcepcion>(entity =>
            {
                entity.HasKey(e => e.IdExcepcion);

                entity.HasIndex(e => e.Documento)
                    .HasName("IX_CobExcepcion")
                    .IsUnique();

                entity.Property(e => e.FechaLm)
                    .HasColumnName("FechaLM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.DocumentoNavigation)
                    .WithOne(p => p.CobExcepcion)
                    .HasForeignKey<CobExcepcion>(d => d.Documento)
                    .HasConstraintName("FK_CobExcepcion_CobGeneralCobranza");
            });

            modelBuilder.Entity<CobGeneralCobranza>(entity =>
            {
                entity.HasKey(e => e.Documento);

                entity.HasIndex(e => e.NumReferencia)
                    .HasName("IX_CobGeneralCobranza");

                entity.Property(e => e.Batch).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCliente)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaAnulado).HasColumnType("datetime");

                entity.Property(e => e.FechaAprobado).HasColumnType("datetime");

                entity.Property(e => e.FechaConfirmado).HasColumnType("datetime");

                entity.Property(e => e.FechaEnviado).HasColumnType("datetime");

                entity.Property(e => e.FechaLm)
                    .HasColumnName("FechaLM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLmcxC)
                    .HasColumnName("FechaLMCxC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReversado).HasColumnType("datetime");

                entity.Property(e => e.FechaTransaccion).HasColumnType("datetime");

                entity.Property(e => e.FlagAnulado).HasDefaultValueSql("((0))");

                entity.Property(e => e.FlagConfirmado).HasDefaultValueSql("((0))");

                entity.Property(e => e.FlagPagoMas).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdBanco)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IdTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.MontoTransaccion).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ObsvAnulacion).HasDefaultValueSql("('')");

                entity.Property(e => e.RmontoTransaccion)
                    .HasColumnName("RMontoTransaccion")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RtotalDetalleCobrado)
                    .HasColumnName("RTotalDetalleCobrado")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SearchText).HasMaxLength(400);
               
                entity.HasIndex(e => e.OficinaVenta)
                   .HasName("IX_CobGeneralCobranza_3");

                entity.Property(e => e.TotalDetalleCobrado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransferidoSap).HasColumnName("TransferidoSAP");

                entity.Property(e => e.UsuarioAnula).HasMaxLength(40);

                entity.Property(e => e.UsuarioAprueba).HasMaxLength(40);

                entity.Property(e => e.UsuarioConfirma).HasMaxLength(40);

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UsuarioReversa).HasMaxLength(40);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CobGeneralCobranza)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CobGeneralCobranza_MtrCliente");

                entity.HasOne(d => d.IdMtrTipoMonedaNavigation)
                    .WithMany(p => p.CobGeneralCobranza)
                    .HasForeignKey(d => d.IdMtrTipoMoneda)
                    .HasConstraintName("FK_CobGeneralCobranza_MtrTipoMoneda");

                entity.HasOne(d => d.IdTipoTransaccionNavigation)
                    .WithMany(p => p.CobGeneralCobranza)
                    .HasForeignKey(d => d.IdTipoTransaccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CobGeneralCobranza_CobTipoTransaccion");
            });

            modelBuilder.Entity<CobGrabacionCobranzas>(entity =>
            {
                entity.HasIndex(e => e.Cotizacion)
                    .HasName("IX_CobGrabacionCobranzas_4");

                entity.HasIndex(e => e.DocAfecta)
                    .HasName("IX_CobGrabacionCobranzas_1");

                entity.HasIndex(e => e.Documento)
                    .HasName("IX_CobGrabacionCobranzas");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_CobGrabacionCobranzas_2");

                entity.HasIndex(e => new { e.Transaccion, e.Cotizacion })
                    .HasName("IX_CobGrabacionCobranzas_3");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocAfecta).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocAfectaSap).HasMaxLength(10);

                entity.Property(e => e.DocumentoSap).HasMaxLength(10);

                entity.Property(e => e.EjercicioDocumentoSap).HasMaxLength(4);

                entity.Property(e => e.Monto).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PagoCorrespondeIva).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rmonto)
                    .HasColumnName("RMonto")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rpdct)
                    .IsRequired()
                    .HasColumnName("RPDCT")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rpdoc).HasColumnName("RPDOC");

                entity.Property(e => e.Rpkco)
                    .IsRequired()
                    .HasColumnName("RPKCO")
                    .HasMaxLength(5)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rpsfx)
                    .IsRequired()
                    .HasColumnName("RPSFX")
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Transaccion).HasMaxLength(2);

                entity.HasOne(d => d.DocumentoNavigation)
                    .WithMany(p => p.CobGrabacionCobranzas)
                    .HasForeignKey(d => d.Documento)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CobGrabacionCobranzas_CobGeneralCobranza");

                entity.HasOne(d => d.TransaccionNavigation)
                    .WithMany(p => p.CobGrabacionCobranzas)
                    .HasPrincipalKey(p => p.Transaccion)
                    .HasForeignKey(d => d.Transaccion)
                    .HasConstraintName("FK_CobGrabacionCobranzas_CobTransacciones");
            });

            modelBuilder.Entity<CobIntegridadCobranzasVsWary074>(entity =>
            {
                entity.HasKey(e => e.Documento);

                entity.Property(e => e.Documento).ValueGeneratedNever();

                entity.Property(e => e.Cliente).HasMaxLength(10);

                entity.Property(e => e.Diferencia).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaEvaluacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MontoCobrado).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoRetenido).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCobradoWary074).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCobroRetencion).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalSapCobranzas).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<CobPagosRetenciones>(entity =>
            {
                entity.HasIndex(e => new { e.IdCobranza, e.IdTransaccion, e.Porcentaje })
                    .HasName("IX_CobPagosRetenciones")
                    .IsUnique();

                entity.Property(e => e.FechaComprobante)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Monto).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NroComprobante)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Porcentaje).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rmonto)
                    .HasColumnName("RMonto")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DocumentoSap).HasMaxLength(10);

                entity.Property(e => e.EjercicioDocumentoSap).HasMaxLength(4);

                entity.HasOne(d => d.IdCobranzaNavigation)
                    .WithMany(p => p.CobPagosRetenciones)
                    .HasForeignKey(d => d.IdCobranza)
                    .HasConstraintName("FK_CobPagosRetenciones_CobGrabacionCobranzas");
            });

            modelBuilder.Entity<CobPorcentajesImpuestos>(entity =>
            {
                entity.HasKey(e => e.IdPorcImpuestos);

                entity.Property(e => e.Desde).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Hasta).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Incremento).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModificacion).HasMaxLength(50);
            });

            modelBuilder.Entity<CobRangosVencimiento>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("Cob_Rangos_Vencimiento");

                entity.Property(e => e.Codigo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.DiasDesde).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiasHasta).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PieDos).HasColumnName("Pie_Dos");

                entity.Property(e => e.PieUno).HasColumnName("Pie_Uno");
            });

            modelBuilder.Entity<CobResumenEstadoCuenta>(entity =>
            {
                entity.HasKey(e => e.Cliente);

                entity.ToTable("Cob_Resumen_Estado_Cuenta");

                entity.HasIndex(e => e.Consultor)
                    .HasName("IX_Cob_Resumen_Estado_Cuenta_1");

                entity.HasIndex(e => e.Oficina)
                    .HasName("IX_Cob_Resumen_Estado_Cuenta");

                entity.Property(e => e.Cliente).HasMaxLength(10);

                entity.Property(e => e.Consultor).HasMaxLength(4);

                entity.Property(e => e.DescripcionRango).HasMaxLength(80);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombreCliente).HasMaxLength(80);

                entity.Property(e => e.NombreConsultor).HasMaxLength(80);

                entity.Property(e => e.NombreOficina).HasMaxLength(80);

                entity.Property(e => e.Saldo).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<CobResumenEstadoCuentaTemp>(entity =>
            {
                entity.HasKey(e => e.Cliente);

                entity.ToTable("Cob_Resumen_Estado_Cuenta_Temp");

                entity.Property(e => e.Cliente).HasMaxLength(10);

                entity.Property(e => e.Consultor).HasMaxLength(4);

                entity.Property(e => e.DescripcionRango).HasMaxLength(80);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombreCliente).HasMaxLength(80);

                entity.Property(e => e.NombreConsultor).HasMaxLength(80);

                entity.Property(e => e.NombreOficina).HasMaxLength(80);

                entity.Property(e => e.Saldo).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<CobRolCobranza>(entity =>
            {
                entity.HasKey(e => e.IdRolCobranza);

                entity.HasIndex(e => new { e.IdUsuario, e.IdOficina })
                    .HasName("IX_CobRolCobranza")
                    .IsUnique();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CobSysfile>(entity =>
            {
                entity.Property(e => e.FechaLm)
                    .HasColumnName("FechaLM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLmcxC)
                    .HasColumnName("FechaLMCxC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagAprobarRc)
                    .IsRequired()
                    .HasColumnName("FlagAprobarRC")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CobTipoTransaccion>(entity =>
            {
                entity.HasKey(e => e.IdTipoTransaccion);

                entity.Property(e => e.IdTipoTransaccion).HasMaxLength(4);

                entity.Property(e => e.ColetillaIva)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdTipoPagoSap)
                    .IsRequired()
                    .HasColumnName("IdTipoPagoSAP")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<CobTipoTransaccionRespaldoAntesEliminarColettilla>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ColetillaIva)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.IdTipoPagoSap)
                    .IsRequired()
                    .HasColumnName("IdTipoPagoSAP")
                    .HasMaxLength(50);

                entity.Property(e => e.IdTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.NombreTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<CobTransacciones>(entity =>
            {
                entity.HasKey(e => e.IdTransacccionCobranzas);

                entity.HasIndex(e => e.TransLegacy)
                    .HasName("IX_CobTransacciones_1")
                    .IsUnique();

                entity.HasIndex(e => e.Transaccion)
                    .HasName("IX_CobTransacciones")
                    .IsUnique();

                entity.Property(e => e.BsHolgura).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CuentaSap)
                    .IsRequired()
                    .HasColumnName("CuentaSAP")
                    .HasMaxLength(10);

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.NombreTransaccion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoSap)
                    .IsRequired()
                    .HasColumnName("TipoSAP")
                    .HasMaxLength(20);

                entity.Property(e => e.TransLegacy)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(40);

                entity.Property(e => e.UsuarioModificacion).HasMaxLength(40);
            });

            modelBuilder.Entity<CobValoresRetencionIslr>(entity =>
            {
                entity.HasKey(e => e.IdRetIslr);

                entity.ToTable("CobValoresRetencionISLR");

                entity.Property(e => e.IdRetIslr).HasColumnName("IdRetISLR");

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.PorcRetIslr)
                    .HasColumnName("PorcRetISLR")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(40);

                entity.Property(e => e.UsuarioModificacion).HasMaxLength(40);
            });

            modelBuilder.Entity<CobValoresRetencionIva>(entity =>
            {
                entity.HasKey(e => e.IdRetIva);

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.PorcRetIva).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(40);

                entity.Property(e => e.UsuarioModificacion).HasMaxLength(40);
            });

            modelBuilder.Entity<CobValoresRetenciones>(entity =>
            {
                entity.HasKey(e => e.IdTransaccion);

                entity.Property(e => e.IdTransaccion).ValueGeneratedNever();

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioModifica).HasMaxLength(40);

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Valores)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("Company_Name_Index")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Cpry010>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("CPRY010_INDEX01");

                entity.ToTable("CPRY010");

                entity.HasIndex(e => e.Cliente)
                    .HasName("IX_CPRY010");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArregloReopera).HasColumnName("ARREGLO_REOPERA");

                entity.Property(e => e.CantAProducir).HasColumnName("CANT_A_PRODUCIR");

                entity.Property(e => e.CantAcabado)
                    .HasColumnName("CANT_ACABADO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantArte)
                    .HasColumnName("CANT_ARTE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantBcs)
                    .HasColumnName("CANT_BCS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantCajaUtili).HasColumnName("CANT_CAJA_UTILI");

                entity.Property(e => e.CantColect)
                    .HasColumnName("CANT_COLECT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantEmbarque)
                    .HasColumnName("CANT_EMBARQUE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantFactura)
                    .HasColumnName("CANT_FACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantFoto)
                    .HasColumnName("CANT_FOTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantPlan)
                    .HasColumnName("CANT_PLAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantPrensa)
                    .HasColumnName("CANT_PRENSA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantProgramada).HasColumnName("CANT_PROGRAMADA");

                entity.Property(e => e.CantidRemanent).HasColumnName("CANTID_REMANENT");

                entity.Property(e => e.CausaReoperaci).HasColumnName("CAUSA_REOPERACI");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodBacklogRet).HasColumnName("COD_BACKLOG_RET");

                entity.Property(e => e.CodigoCaja)
                    .HasColumnName("CODIGO_CAJA")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Combinacion)
                    .HasColumnName("COMBINACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cotizacion)
                    .HasColumnName("COTIZACION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtdEntregada).HasColumnName("CTD_ENTREGADA");

                entity.Property(e => e.CtdFactAdelan).HasColumnName("CTD_FACT_ADELAN");

                entity.Property(e => e.DiasAcabado).HasColumnName("DIAS_ACABADO");

                entity.Property(e => e.DiasArte).HasColumnName("DIAS_ARTE");

                entity.Property(e => e.DiasBcs).HasColumnName("DIAS_BCS");

                entity.Property(e => e.DiasColectora).HasColumnName("DIAS_COLECTORA");

                entity.Property(e => e.DiasEmbarque).HasColumnName("DIAS_EMBARQUE");

                entity.Property(e => e.DiasFoto).HasColumnName("DIAS_FOTO");

                entity.Property(e => e.DiasPlaneacion).HasColumnName("DIAS_PLANEACION");

                entity.Property(e => e.DiasPrensa).HasColumnName("DIAS_PRENSA");

                entity.Property(e => e.DiasRetAcabad).HasColumnName("DIAS_RET_ACABAD");

                entity.Property(e => e.DiasRetArte).HasColumnName("DIAS_RET_ARTE");

                entity.Property(e => e.DiasRetBcs).HasColumnName("DIAS_RET_BCS");

                entity.Property(e => e.DiasRetColect).HasColumnName("DIAS_RET_COLECT");

                entity.Property(e => e.DiasRetEmbarq).HasColumnName("DIAS_RET_EMBARQ");

                entity.Property(e => e.DiasRetFoto).HasColumnName("DIAS_RET_FOTO");

                entity.Property(e => e.DiasRetPlanea).HasColumnName("DIAS_RET_PLANEA");

                entity.Property(e => e.DiasRetPrensa).HasColumnName("DIAS_RET_PRENSA");

                entity.Property(e => e.Elimina)
                    .HasColumnName("ELIMINA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecRealOrden)
                    .HasColumnName("FEC_REAL_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaArchivo)
                    .HasColumnName("FECHA_ARCHIVO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaOrdEntry)
                    .HasColumnName("FECHA_ORD_ENTRY")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRet)
                    .HasColumnName("FECHA_RET")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRetenido)
                    .HasColumnName("FECHA_RETENIDO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaeEstAcab)
                    .HasColumnName("FECHAE_EST_ACAB")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaeEstBcs)
                    .HasColumnName("FECHAE_EST_BCS")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaeEstCole)
                    .HasColumnName("FECHAE_EST_COLE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaeEstDise)
                    .HasColumnName("FECHAE_EST_DISE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaeEstEmba)
                    .HasColumnName("FECHAE_EST_EMBA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaeEstEntr)
                    .HasColumnName("FECHAE_EST_ENTR")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaeEstFact)
                    .HasColumnName("FECHAE_EST_FACT")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaeEstNega)
                    .HasColumnName("FECHAE_EST_NEGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaeEstPren)
                    .HasColumnName("FECHAE_EST_PREN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaerAcabado)
                    .HasColumnName("FECHAER_ACABADO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaerBcs)
                    .HasColumnName("FECHAER_BCS")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaerColecto)
                    .HasColumnName("FECHAER_COLECTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaerDiseno)
                    .HasColumnName("FECHAER_DISENO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaerEmbarqu)
                    .HasColumnName("FECHAER_EMBARQU")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaerFactura)
                    .HasColumnName("FECHAER_FACTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaerNegativ)
                    .HasColumnName("FECHAER_NEGATIV")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaerPrelim)
                    .HasColumnName("FECHAER_PRELIM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaerPrensas)
                    .HasColumnName("FECHAER_PRENSAS")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasEstAcab)
                    .HasColumnName("FECHAS_EST_ACAB")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasEstBcs)
                    .HasColumnName("FECHAS_EST_BCS")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasEstCole)
                    .HasColumnName("FECHAS_EST_COLE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasEstDise)
                    .HasColumnName("FECHAS_EST_DISE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasEstEmba)
                    .HasColumnName("FECHAS_EST_EMBA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasEstFact)
                    .HasColumnName("FECHAS_EST_FACT")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasEstNega)
                    .HasColumnName("FECHAS_EST_NEGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasEstPrel)
                    .HasColumnName("FECHAS_EST_PREL")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasEstPren)
                    .HasColumnName("FECHAS_EST_PREN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasrAcabado)
                    .HasColumnName("FECHASR_ACABADO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasrBcs)
                    .HasColumnName("FECHASR_BCS")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasrColecto)
                    .HasColumnName("FECHASR_COLECTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasrDiseno)
                    .HasColumnName("FECHASR_DISENO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasrEmbarqu)
                    .HasColumnName("FECHASR_EMBARQU")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasrNegativ)
                    .HasColumnName("FECHASR_NEGATIV")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasrPrelim)
                    .HasColumnName("FECHASR_PRELIM")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechasrPrensas)
                    .HasColumnName("FECHASR_PRENSAS")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiscal)
                    .HasColumnName("FISCAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagAcabado)
                    .HasColumnName("FLAG_ACABADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagBcs)
                    .HasColumnName("FLAG_BCS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagColectora)
                    .HasColumnName("FLAG_COLECTORA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagDiseno)
                    .HasColumnName("FLAG_DISENO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagEmbarque)
                    .HasColumnName("FLAG_EMBARQUE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagEtiqImpre)
                    .HasColumnName("FLAG_ETIQ_IMPRE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagFoto)
                    .HasColumnName("FLAG_FOTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagPlaneac)
                    .HasColumnName("FLAG_PLANEAC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagPlaneado)
                    .HasColumnName("FLAG_PLANEADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagPrensas)
                    .HasColumnName("FLAG_PRENSAS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetenido)
                    .HasColumnName("FLAG_RETENIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagSoportev)
                    .HasColumnName("FLAG_SOPORTEV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormInicial).HasColumnName("FORM_INICIAL");

                entity.Property(e => e.FormPorCaja).HasColumnName("FORM_POR_CAJA");

                entity.Property(e => e.JobAutomatico)
                    .HasColumnName("JOB_AUTOMATICO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JobRestar).HasColumnName("JOB_RESTAR");

                entity.Property(e => e.LineaProduccio).HasColumnName("LINEA_PRODUCCIO");

                entity.Property(e => e.Lista)
                    .HasColumnName("LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LugarProducir)
                    .HasColumnName("LUGAR_PRODUCIR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoAnulacion).HasColumnName("NO_ANULACION");

                entity.Property(e => e.NoColectora).HasColumnName("NO_COLECTORA");

                entity.Property(e => e.NoPrensa).HasColumnName("NO_PRENSA");

                entity.Property(e => e.NuevaCtd).HasColumnName("NUEVA_CTD");

                entity.Property(e => e.NuevaFechaEnt)
                    .HasColumnName("NUEVA_FECHA_ENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumeroFactura).HasColumnName("NUMERO_FACTURA");

                entity.Property(e => e.Obser)
                    .HasColumnName("OBSER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("text");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenReoperac)
                    .HasColumnName("ORIGEN_REOPERAC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PartesAReope).HasColumnName("PARTES_A_REOPE");

                entity.Property(e => e.PasoSql)
                    .HasColumnName("PASO_SQL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PiesArteCole)
                    .HasColumnName("PIES_ARTE_COLE")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PiesArtePren)
                    .HasColumnName("PIES_ARTE_PREN")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PiesColect)
                    .HasColumnName("PIES_COLECT")
                    .HasColumnType("decimal(16, 4)");

                entity.Property(e => e.PiesFotoCole)
                    .HasColumnName("PIES_FOTO_COLE")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PiesFotoPren)
                    .HasColumnName("PIES_FOTO_PREN")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PiesPlanCole)
                    .HasColumnName("PIES_PLAN_COLE")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PiesPlanPren)
                    .HasColumnName("PIES_PLAN_PREN")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PiesPrensCole)
                    .HasColumnName("PIES_PRENS_COLE")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PiesPrensPren)
                    .HasColumnName("PIES_PRENS_PREN")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PiesPrensa)
                    .HasColumnName("PIES_PRENSA")
                    .HasColumnType("decimal(16, 4)");

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ProduInmediata)
                    .HasColumnName("PRODU_INMEDIATA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Programada)
                    .HasColumnName("PROGRAMADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Remanente)
                    .HasColumnName("REMANENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReopSolicPor).HasColumnName("REOP_SOLIC_POR");

                entity.Property(e => e.ReoperacionNo).HasColumnName("REOPERACION_NO");

                entity.Property(e => e.ResponsaReoper)
                    .HasColumnName("RESPONSA_REOPER")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rlista)
                    .HasColumnName("RLISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpreciolista)
                    .HasColumnName("RPRECIOLISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rprecioventa)
                    .HasColumnName("RPRECIOVENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rventa)
                    .HasColumnName("RVENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusDelJob)
                    .HasColumnName("STATUS_DEL_JOB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupervVentas)
                    .IsRequired()
                    .HasColumnName("SUPERV_VENTAS")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCaja).HasColumnName("TIPO_CAJA");

                entity.Property(e => e.TipoOrden).HasColumnName("TIPO_ORDEN");

                entity.Property(e => e.TipoProduccion)
                    .HasColumnName("TIPO_PRODUCCION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRet)
                    .HasColumnName("USUARIO_RET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Venta)
                    .HasColumnName("VENTA")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<Cpry012>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CPRY012");

                entity.HasIndex(e => e.Orden)
                    .HasName("IX_CPRY012");

                entity.Property(e => e.Adelantada)
                    .HasColumnName("ADELANTADA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.An8entregar)
                    .HasColumnName("AN8ENTREGAR")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.An8facturar)
                    .HasColumnName("AN8FACTURAR")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnchosPts1)
                    .HasColumnName("ANCHOS_PTS1")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnchosPts2)
                    .HasColumnName("ANCHOS_PTS2")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnchosRod1)
                    .HasColumnName("ANCHOS_ROD1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnchosRod2)
                    .HasColumnName("ANCHOS_ROD2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.AnticipoJde)
                    .HasColumnName("ANTICIPO_JDE")
                    .HasColumnType("decimal(10, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anulada)
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutorizaAde)
                    .HasColumnName("AUTORIZA_ADE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BsMcFinan)
                    .HasColumnName("BS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinanE)
                    .HasColumnName("BS_MC_FINAN_E")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnName("BS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinansce)
                    .HasColumnName("BS_MC_FINANSCE")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnName("BS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapelE)
                    .HasColumnName("BS_MC_PAPEL_E")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnName("BS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BsMcPapelsce)
                    .HasColumnName("BS_MC_PAPELSCE")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CambioCompo)
                    .HasColumnName("CAMBIO_COMPO")
                    .HasColumnType("decimal(4, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantAProducir).HasColumnName("CANT_A_PRODUCIR");

                entity.Property(e => e.CantCajas).HasColumnName("CANT_CAJAS");

                entity.Property(e => e.CantFacturada).HasColumnName("CANT_FACTURADA");

                entity.Property(e => e.CantOrdenada).HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.CantProducida).HasColumnName("CANT_PRODUCIDA");

                entity.Property(e => e.CantProgramada).HasColumnName("CANT_PROGRAMADA");

                entity.Property(e => e.CantXCajas).HasColumnName("CANT_X_CAJAS");

                entity.Property(e => e.CantXPaq).HasColumnName("CANT_X_PAQ");

                entity.Property(e => e.CantidadRodada)
                    .HasColumnName("CANTIDAD_RODADA")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClaseOrden)
                    .HasColumnName("CLASE_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodAplicacion)
                    .HasColumnName("COD_APLICACION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodBacklogRet).HasColumnName("COD_BACKLOG_RET");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasColumnName("COD_PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodTeleop)
                    .HasColumnName("COD_TELEOP")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.CondicionProdu)
                    .HasColumnName("CONDICION_PRODU")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConsArchivo).HasColumnName("CONS_ARCHIVO");

                entity.Property(e => e.Cortado)
                    .HasColumnName("CORTADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasColumnName("COTIZACION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtdEntregada).HasColumnName("CTD_ENTREGADA");

                entity.Property(e => e.CtdNc).HasColumnName("CTD_NC");

                entity.Property(e => e.CteEntregar)
                    .HasColumnName("CTE_ENTREGAR")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CteFacturar)
                    .HasColumnName("CTE_FACTURAR")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuarTintaFte)
                    .HasColumnName("CUAR_TINTA_FTE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescProducto)
                    .HasColumnName("DESC_PRODUCTO")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar)
                    .HasColumnName("DIREC_ENTREGAR")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar2)
                    .HasColumnName("DIREC_ENTREGAR2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar3)
                    .HasColumnName("DIREC_ENTREGAR3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar)
                    .HasColumnName("DIREC_FACTURAR")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar2)
                    .HasColumnName("DIREC_FACTURAR2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar3)
                    .HasColumnName("DIREC_FACTURAR3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Doblez)
                    .HasColumnName("DOBLEZ")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmbReverso)
                    .HasColumnName("EMB_REVERSO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmpacarEn)
                    .HasColumnName("EMPACAR_EN")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EngomaCarbCol)
                    .HasColumnName("ENGOMA_CARB_COL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EngomaCarbPre)
                    .HasColumnName("ENGOMA_CARB_PRE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.Excepcion)
                    .HasColumnName("EXCEPCION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FacturaDolar)
                    .HasColumnName("FACTURA_DOLAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FamiliaProduct)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecCierreOrd)
                    .HasColumnName("FEC_CIERRE_ORD")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecComproClte)
                    .HasColumnName("FEC_COMPRO_CLTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecCreditos)
                    .HasColumnName("FEC_CREDITOS")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecProgramada)
                    .HasColumnName("FEC_PROGRAMADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRecibPlant)
                    .HasColumnName("FEC_RECIB_PLANT")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecRegVentas)
                    .HasColumnName("FEC_REG_VENTAS")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FecTransmision)
                    .HasColumnName("FEC_TRANSMISION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaArchivo)
                    .HasColumnName("FECHA_ARCHIVO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaCalculo)
                    .HasColumnName("FECHA_CALCULO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDolar)
                    .HasColumnName("FECHA_DOLAR")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiscal)
                    .HasColumnName("FISCAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagActivo)
                    .HasColumnName("FLAG_ACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagFactura)
                    .HasColumnName("FLAG_FACTURA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagProdInter)
                    .HasColumnName("FLAG_PROD_INTER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagSoportev)
                    .HasColumnName("FLAG_SOPORTEV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagV19)
                    .HasColumnName("FLAG_V19")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormasUndFact).HasColumnName("FORMAS_UND_FACT");

                entity.Property(e => e.GomaRegPtes)
                    .HasColumnName("GOMA_REG_PTES")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdCombinada).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdSolicitud)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSolicitud2)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSolicitudCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idcalendar)
                    .HasColumnName("IDCALENDAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Idcalendar2)
                    .IsRequired()
                    .HasColumnName("IDCALENDAR2")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Impout)
                    .HasColumnName("IMPOUT")
                    .HasColumnType("decimal(1, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Impresion)
                    .HasColumnName("IMPRESION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImprimeDol)
                    .HasColumnName("IMPRIME_DOL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.Impvar)
                    .HasColumnName("IMPVAR")
                    .HasColumnType("decimal(1, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InstFacturar)
                    .HasColumnName("INST_FACTURAR")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineaAnt).HasColumnName("LINEA_ANT");

                entity.Property(e => e.LineaAntJde)
                    .HasColumnName("LINEA_ANT_JDE")
                    .HasColumnType("decimal(2, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProducto)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListaTotDolar)
                    .HasColumnName("LISTA_TOT_DOLAR")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ListaUnitDol)
                    .HasColumnName("LISTA_UNIT_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LugarEnviar)
                    .HasColumnName("LUGAR_ENVIAR")
                    .HasColumnType("text");

                entity.Property(e => e.LugarProducir)
                    .HasColumnName("LUGAR_PRODUCIR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MedidaBase).HasColumnName("MEDIDA_BASE");

                entity.Property(e => e.MedidaVariable).HasColumnName("MEDIDA_VARIABLE");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NoTransmision).HasColumnName("NO_TRANSMISION");

                entity.Property(e => e.Nocalculamc)
                    .HasColumnName("NOCALCULAMC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreProducto)
                    .HasColumnName("NOMBRE_PRODUCTO")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NuTintasFrent).HasColumnName("NU_TINTAS_FRENT");

                entity.Property(e => e.NuTintasResp).HasColumnName("NU_TINTAS_RESP");

                entity.Property(e => e.NumeroTiras).HasColumnName("NUMERO_TIRAS");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenAnterior).HasColumnName("ORDEN_ANTERIOR");

                entity.Property(e => e.OrdenComb)
                    .HasColumnName("ORDEN_COMB")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PCobranza)
                    .HasColumnName("P_COBRANZA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.POverger)
                    .HasColumnName("P_OVERGER")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.POverride)
                    .HasColumnName("P_OVERRIDE")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.POverrideCg)
                    .HasColumnName("P_OVERRIDE_CG")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.POverrideG)
                    .HasColumnName("P_OVERRIDE_G")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.POverrideGo)
                    .HasColumnName("P_OVERRIDE_GO")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PartesFormula).HasColumnName("PARTES_FORMULA");

                entity.Property(e => e.PartesTiras)
                    .HasColumnName("PARTES_TIRAS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Plantilla).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoncMargDer)
                    .HasColumnName("PONC_MARG_DER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PoncMargIzq)
                    .HasColumnName("PONC_MARG_IZQ")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PoncheEsp)
                    .HasColumnName("PONCHE_ESP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PorcCom)
                    .HasColumnName("PORC_COM")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PorcComRegulada)
                    .HasColumnType("numeric(5, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMc)
                    .HasColumnName("PORC_MC")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnName("PORC_MC_FINAN")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinanE)
                    .HasColumnName("PORC_MC_FINAN_E")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcMinimo).HasColumnType("numeric(5, 3)");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapelE)
                    .HasColumnName("PORC_MC_PAPEL_E")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcfinansce)
                    .HasColumnName("PORC_MCFINANSCE")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PorcMcpapelsce)
                    .HasColumnName("PORC_MCPAPELSCE")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PorcRespSocial)
                    .HasColumnType("numeric(5, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PosTirasF)
                    .HasColumnName("POS_TIRAS_F")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PosTirasR)
                    .HasColumnName("POS_TIRAS_R")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.PrefColeEsp)
                    .HasColumnName("PREF_COLE_ESP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrefColeStd)
                    .HasColumnName("PREF_COLE_STD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrefPrenEsp)
                    .HasColumnName("PREF_PREN_ESP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrefPrenStd)
                    .HasColumnName("PREF_PREN_STD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrimTintaFte)
                    .HasColumnName("PRIM_TINTA_FTE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrimTintaResp)
                    .HasColumnName("PRIM_TINTA_RESP")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QuintTintaFte)
                    .HasColumnName("QUINT_TINTA_FTE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnName("RBS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcFinansc)
                    .HasColumnName("RBS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnName("RBS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapelsc)
                    .HasColumnName("RBS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rcomision)
                    .HasColumnName("RCOMISION")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecalcularMargen)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Refinado)
                    .HasColumnName("REFINADO")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.RefinadoEn)
                    .HasColumnName("REFINADO_EN")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Regular)
                    .HasColumnName("REGULAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifEntregar)
                    .HasColumnName("RIF_ENTREGAR")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifFacturar)
                    .HasColumnName("RIF_FACTURAR")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RifImprimir)
                    .HasColumnName("RIF_IMPRIMIR")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RollosCtd1)
                    .HasColumnName("ROLLOS_CTD1")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RollosCtd2)
                    .HasColumnName("ROLLOS_CTD2")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RollosCtd3)
                    .HasColumnName("ROLLOS_CTD3")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RollosPts1)
                    .HasColumnName("ROLLOS_PTS1")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RollosPts2)
                    .HasColumnName("ROLLOS_PTS2")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RollosPts3)
                    .HasColumnName("ROLLOS_PTS3")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RollosRod1).HasColumnName("ROLLOS_ROD1");

                entity.Property(e => e.RollosRod2).HasColumnName("ROLLOS_ROD2");

                entity.Property(e => e.RollosRod3).HasColumnName("ROLLOS_ROD3");

                entity.Property(e => e.RprecioLista)
                    .HasColumnName("RPRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnName("RPRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rtasa)
                    .HasColumnName("RTASA")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalLista)
                    .HasColumnName("RTOTAL_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalListaEx)
                    .HasColumnName("RTOTAL_LISTA_EX")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnName("RTOTAL_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalVentaEx)
                    .HasColumnName("RTOTAL_VENTA_EX")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalidaPreCab)
                    .HasColumnName("SALIDA_PRE_CAB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalidaPrePie)
                    .HasColumnName("SALIDA_PRE_PIE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SegTintaFte)
                    .HasColumnName("SEG_TINTA_FTE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SegTintaResp)
                    .HasColumnName("SEG_TINTA_RESP")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SexTintaFte)
                    .HasColumnName("SEX_TINTA_FTE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasColumnName("SI_COLETILLA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.SiDolares)
                    .HasColumnName("SI_DOLARES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.SiIndexado)
                    .HasColumnName("SI_INDEXADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Solido)
                    .HasColumnName("SOLIDO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusOrden)
                    .HasColumnName("STATUS_ORDEN")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tabla).HasColumnName("TABLA");

                entity.Property(e => e.TalonExtra)
                    .HasColumnName("TALON_EXTRA")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tasa)
                    .HasColumnName("TASA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TercTintaFte)
                    .HasColumnName("TERC_TINTA_FTE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TercTintaResp)
                    .HasColumnName("TERC_TINTA_RESP")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCaja)
                    .HasColumnName("TIPO_CAJA")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEmpaque)
                    .HasColumnName("TIPO_EMPAQUE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .IsRequired()
                    .HasColumnName("TIPO_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalLista)
                    .HasColumnName("TOTAL_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TotalListaExt)
                    .HasColumnName("TOTAL_LISTA_EXT")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TotalVenta)
                    .HasColumnName("TOTAL_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TotalVentaExt)
                    .HasColumnName("TOTAL_VENTA_EXT")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TranfTapeEf)
                    .HasColumnName("TRANF_TAPE_EF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TranfTapePerm)
                    .HasColumnName("TRANF_TAPE_PERM")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TranfTapeRem)
                    .HasColumnName("TRANF_TAPE_REM")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentaTotDolar)
                    .HasColumnName("VENTA_TOT_DOLAR")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VentaUnitDol)
                    .HasColumnName("VENTA_UNIT_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VinetaImpresa)
                    .IsRequired()
                    .HasColumnName("VINETA_IMPRESA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Web)
                    .HasColumnName("WEB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ws)
                    .HasColumnName("WS")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('HOST_NAME()')");
            });

            modelBuilder.Entity<CreAdjuntoSolicitudCredito>(entity =>
            {
                entity.HasKey(e => e.SolicitudDeCredito);

                entity.Property(e => e.SolicitudDeCredito).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<CreClientesExcepcion>(entity =>
            {
                entity.HasIndex(e => e.CodCliente)
                    .HasName("IX_CreClientesExcepcion");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasColumnName("COD_CLIENTE")
                    .HasMaxLength(10);

                entity.Property(e => e.Excepcion)
                    .HasColumnName("EXCEPCION")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<CreCotizacionDocumento>(entity =>
            {
                entity.HasIndex(e => e.Cotizacion)
                    .HasName("IX_CreCotizacionDocumento");

                entity.HasIndex(e => e.Documento)
                    .HasName("IX_CreCotizacionDocumento_1");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.Documento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(40);

                entity.Property(e => e.UsuarioModificacion).HasMaxLength(40);
            });

            modelBuilder.Entity<CreEvaluacionCredito>(entity =>
            {
                entity.HasKey(e => e.IdEvaluacion);

                entity.Property(e => e.IdEvaluacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(10);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSolicitudAnalisis).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Monto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rmonto)
                    .HasColumnName("RMonto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<CreRangoAprobacionOficinaUsuarioMontoDias>(entity =>
            {
                entity.HasIndex(e => new { e.Oficina, e.Usuario, e.MontoDesde, e.MontoHasta })
                    .HasName("IX_CreRangoAprobacionOficinaUsuarioMontoDias")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MontoDesde).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MontoHasta).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RmontoDesde)
                    .HasColumnName("RMontoDesde")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RmontoHasta)
                    .HasColumnName("RMontoHasta")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CreResponsableAprobarExcepcion>(entity =>
            {
                entity.HasIndex(e => e.Usuario)
                    .HasName("IX_CreResponsableAprobarExcepcion");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Usuario).HasMaxLength(40);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(40);

                entity.Property(e => e.UsuarioModificacion).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CreSolicitudDeCredito>(entity =>
            {
                entity.HasIndex(e => e.Aprobada)
                    .HasName("IX_CreSolicitudDeCredito_1");

                entity.HasIndex(e => e.Cotizacion)
                    .HasName("IX_CreSolicitudDeCredito");

                entity.HasIndex(e => e.SolicitudDeCredito)
                    .HasName("IX_CreSolicitudDeCredito_2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Aprobada).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("COD_CLIENTE")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.EvaluadaAdministradora).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

                entity.Property(e => e.IdSolicitudAnalisisAprobacion)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoSolicitado)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NroExcepcion)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObservacionesCredito).HasDefaultValueSql("('')");

                entity.Property(e => e.Rechazado).HasDefaultValueSql("((0))");

                entity.Property(e => e.RmontoSolicitado)
                    .HasColumnName("RMontoSolicitado")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SolicitudDeCredito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UltimoIdSolicitudAnalisis)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioAprobador).HasMaxLength(50);

                entity.Property(e => e.UsuarioAprobo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuarioRechazo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CreSolicitudDeCreditoHistorico>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Aprobada).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("COD_CLIENTE")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.EvaluadaAdministradora).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

                entity.Property(e => e.IdSolicitudAnalisisAprobacion)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoSolicitado)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NroExcepcion)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObservacionesCredito).HasDefaultValueSql("('')");

                entity.Property(e => e.Rechazado).HasDefaultValueSql("((0))");

                entity.Property(e => e.RmontoSolicitado)
                    .HasColumnName("RMontoSolicitado")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SolicitudDeCredito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UltimoIdSolicitudAnalisis)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioAprobador).HasMaxLength(50);

                entity.Property(e => e.UsuarioAprobo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuarioRechazo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CreSolicitudExcepcion>(entity =>
            {
                entity.HasKey(e => e.SolicitudDeCredito)
                    .HasName("PK_CreSolicitudExcepcion_1");

                entity.Property(e => e.SolicitudDeCredito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechaAprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("smalldatetime");

                entity.Property(e => e.NombreImagen).HasMaxLength(500);

                entity.Property(e => e.UsuarioAprobador).HasMaxLength(50);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioRechazo).HasMaxLength(50);
            });

            modelBuilder.Entity<CreSolicitudExcepcionHistorico>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FechaAprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("smalldatetime");

                entity.Property(e => e.NombreImagen).HasMaxLength(500);

                entity.Property(e => e.SolicitudDeCredito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UsuarioAprobador).HasMaxLength(50);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioRechazo).HasMaxLength(50);
            });

            modelBuilder.Entity<CrmEncuestaCliente>(entity =>
            {
                entity.HasKey(e => e.IdSatisfaccion);

                entity.HasIndex(e => new { e.IdCliente, e.Ano, e.Mes })
                    .HasName("IX_CrmEncuestaCliente");

                entity.Property(e => e.IdSatisfaccion)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IdConsultor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CrmMtrCes>(entity =>
            {
                entity.HasKey(e => e.PuntosCes);

                entity.Property(e => e.PuntosCes).ValueGeneratedNever();

                entity.Property(e => e.NombreCes)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CrmMtrCs>(entity =>
            {
                entity.HasKey(e => e.PuntosCs);

                entity.Property(e => e.PuntosCs).ValueGeneratedNever();

                entity.Property(e => e.NombreCs)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CrmMtrEstado>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.Property(e => e.IdEstado).ValueGeneratedNever();

                entity.Property(e => e.NombreEstado)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CrmMtrNps>(entity =>
            {
                entity.HasKey(e => e.PuntosNps);

                entity.Property(e => e.PuntosNps).ValueGeneratedNever();

                entity.Property(e => e.NombreNps)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CrmMtrSeguimiento>(entity =>
            {
                entity.HasKey(e => e.IdTipoSegumiento);

                entity.Property(e => e.IdTipoSegumiento).ValueGeneratedNever();

                entity.Property(e => e.NombreSeguimiento)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CrmNotificacionActividades>(entity =>
            {
                entity.HasKey(e => e.IdNotificacion);

                entity.HasIndex(e => e.IdSeguimiento)
                    .HasName("IX_CrmNotificacionActividades")
                    .IsUnique();

                entity.Property(e => e.IdNotificacion)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cc)
                    .IsRequired()
                    .HasColumnName("CC");

                entity.Property(e => e.Cuerpo).IsRequired();

                entity.Property(e => e.FechaHoraEnvio).HasColumnType("datetime");

                entity.Property(e => e.Para)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<CrmSeguimiento>(entity =>
            {
                entity.HasKey(e => e.IdSeguimiento);

                entity.HasIndex(e => e.IdCliente)
                    .HasName("IX_CrmSeguimiento");

                entity.Property(e => e.Comentarios).IsRequired();

                entity.Property(e => e.FechaHoraFin).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaUpdate).HasColumnType("datetime");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ListaInformados)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuarioUpdate)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CrmSeguimiento)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmSeguimiento_MtrCliente");

                entity.HasOne(d => d.IdContactoNavigation)
                    .WithMany(p => p.CrmSeguimiento)
                    .HasForeignKey(d => d.IdContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmSeguimiento_MtrContactos");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CrmSeguimiento)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmSeguimiento_CrmMtrEstado");

                entity.HasOne(d => d.IdTipoSeguimientoNavigation)
                    .WithMany(p => p.CrmSeguimiento)
                    .HasForeignKey(d => d.IdTipoSeguimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmSeguimiento_CrmMtrSeguimiento");
            });

            modelBuilder.Entity<CrmVisitaDia>(entity =>
            {
                entity.HasKey(e => e.IdDia);

                entity.Property(e => e.IdDia).ValueGeneratedNever();

                entity.Property(e => e.AbreviadoDia)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.NombreDia)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CrmVisitaFrecuencia>(entity =>
            {
                entity.HasKey(e => e.IdFrecuencia);

                entity.Property(e => e.IdFrecuencia).ValueGeneratedNever();

                entity.Property(e => e.NombreFrecuencia)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CrmVisitaSemana>(entity =>
            {
                entity.HasKey(e => e.IdSemana);

                entity.Property(e => e.AbreviadoSemana)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NombreSemana)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdFrecuenciaNavigation)
                    .WithMany(p => p.CrmVisitaSemana)
                    .HasForeignKey(d => d.IdFrecuencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmVisitaSemana_CrmVisitaFrecuencia");
            });

            modelBuilder.Entity<Ctmy033>(entity =>
            {
                entity.HasKey(e => e.Orden)
                    .HasName("CTMY033_INDEX01");

                entity.ToTable("CTMY033");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .ValueGeneratedNever();

                entity.Property(e => e.An8entregar)
                    .HasColumnName("AN8ENTREGAR")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.An8facturar)
                    .HasColumnName("AN8FACTURAR")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.Anulado)
                    .IsRequired()
                    .HasColumnName("ANULADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AutorizaConc)
                    .IsRequired()
                    .HasColumnName("AUTORIZA_CONC")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AutorizaCred)
                    .IsRequired()
                    .HasColumnName("AUTORIZA_CRED")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodTeleop)
                    .IsRequired()
                    .HasColumnName("COD_TELEOP")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Coment1)
                    .IsRequired()
                    .HasColumnName("COMENT1")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Coment2)
                    .IsRequired()
                    .HasColumnName("COMENT2")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondicionPago).HasColumnName("CONDICION_PAGO");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasColumnName("CONTACTO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccFiscal)
                    .HasColumnName("DIRECC_FISCAL")
                    .HasColumnType("text");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EMB3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.FacturaDolar)
                    .IsRequired()
                    .HasColumnName("FACTURA_DOLAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasColumnName("FAX")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCob)
                    .HasColumnName("FECHA_COB")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaGrabacion)
                    .HasColumnName("FECHA_GRABACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaPedido)
                    .HasColumnName("FECHA_PEDIDO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRc)
                    .HasColumnName("FECHA_RC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaReactiva)
                    .HasColumnName("FECHA_REACTIVA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaTasa)
                    .HasColumnName("FECHA_TASA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiscal)
                    .IsRequired()
                    .HasColumnName("FISCAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagCombo)
                    .HasColumnName("FLAG_COMBO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giro)
                    .IsRequired()
                    .HasColumnName("GIRO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Impresa)
                    .IsRequired()
                    .HasColumnName("IMPRESA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaAnt).HasColumnName("LINEA_ANT");

                entity.Property(e => e.MultiplesEmb)
                    .IsRequired()
                    .HasColumnName("MULTIPLES_EMB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NitEmb).HasColumnName("NIT_EMB");

                entity.Property(e => e.NitFact).HasColumnName("NIT_FACT");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreEmb)
                    .IsRequired()
                    .HasColumnName("NOMBRE_EMB")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreFact)
                    .IsRequired()
                    .HasColumnName("NOMBRE_FACT")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NuevaFechaEnt)
                    .HasColumnName("NUEVA_FECHA_ENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumeroPedido).HasColumnName("NUMERO_PEDIDO");

                entity.Property(e => e.Oficina)
                    .IsRequired()
                    .HasColumnName("OFICINA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasColumnName("ORDEN_COMPRA")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasColumnName("PASO_SQL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcentConc)
                    .HasColumnName("PORCENT_CONC")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.ReciboCobro).HasColumnName("RECIBO_COBRO");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.RegTributario)
                    .IsRequired()
                    .HasColumnName("REG_TRIBUTARIO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RequiereNe)
                    .HasColumnName("REQUIERE_NE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rtasa)
                    .HasColumnName("RTASA")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalLista)
                    .HasColumnName("RTOTAL_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnName("RTOTAL_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SiColetilla)
                    .IsRequired()
                    .HasColumnName("SI_COLETILLA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SiDolares)
                    .IsRequired()
                    .HasColumnName("SI_DOLARES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SiIndexacion)
                    .IsRequired()
                    .HasColumnName("SI_INDEXACION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.StatusOrden)
                    .IsRequired()
                    .HasColumnName("STATUS_ORDEN")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SupervisorConc)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR_CONC")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tasa)
                    .HasColumnName("TASA")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalLista)
                    .HasColumnName("TOTAL_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TotalListaDol)
                    .HasColumnName("TOTAL_LISTA_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TotalVenta)
                    .HasColumnName("TOTAL_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TotalVentaDol)
                    .HasColumnName("TOTAL_VENTA_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.UnidadFacturar).HasColumnName("UNIDAD_FACTURAR");

                entity.Property(e => e.UsrNuevaFecha)
                    .HasColumnName("USR_NUEVA_FECHA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendGestion)
                    .IsRequired()
                    .HasColumnName("VEND_GESTION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Web)
                    .IsRequired()
                    .HasColumnName("WEB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ctmy034>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.CodProducto })
                    .HasName("CTMY034_INDEX01");

                entity.ToTable("CTMY034");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.CodProducto)
                    .HasColumnName("COD_PRODUCTO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Altoempaque)
                    .HasColumnName("ALTOEMPAQUE")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Anchoempaque)
                    .HasColumnName("ANCHOEMPAQUE")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AnticipoJde)
                    .HasColumnName("ANTICIPO_JDE")
                    .HasColumnType("decimal(10, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anulado)
                    .IsRequired()
                    .HasColumnName("ANULADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnName("BS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnName("BS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnName("BS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnName("BS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bsmc)
                    .HasColumnName("BSMC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantFacturada)
                    .HasColumnName("CANT_FACTURADA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CantPedida).HasColumnName("CANT_PEDIDA");

                entity.Property(e => e.Cantidadcajasempaques).HasColumnName("CANTIDADCAJASEMPAQUES");

                entity.Property(e => e.CodAplicacion)
                    .HasColumnName("COD_APLICACION")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.CodResponsable)
                    .HasColumnName("COD_RESPONSABLE")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Codigocaja)
                    .IsRequired()
                    .HasColumnName("CODIGOCAJA")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Controldesde)
                    .HasColumnName("CONTROLDESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Controlhasta)
                    .HasColumnName("CONTROLHASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CtdDespOfic).HasColumnName("CTD_DESP_OFIC");

                entity.Property(e => e.CtdEntregada)
                    .HasColumnName("CTD_ENTREGADA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DescProducto)
                    .IsRequired()
                    .HasColumnName("DESC_PRODUCTO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb)
                    .HasColumnName("DIRECCION_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionFact)
                    .HasColumnName("DIRECCION_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.EbitBs)
                    .HasColumnName("EBIT_BS")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.EbitPorc)
                    .HasColumnName("EBIT_PORC")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Equipoupdate)
                    .IsRequired()
                    .HasColumnName("EQUIPOUPDATE")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Excepcion)
                    .HasColumnName("EXCEPCION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FamiliaProduct)
                    .IsRequired()
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaRemision)
                    .HasColumnName("FECHA_REMISION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechaupdate)
                    .HasColumnName("FECHAUPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiscal)
                    .HasColumnName("FISCAL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Formatodesde)
                    .HasColumnName("FORMATODESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Formatohasta)
                    .HasColumnName("FORMATOHASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HorasMaquina)
                    .HasColumnName("HORAS_MAQUINA")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.IdSolicitud)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSolicitud2).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvaJde)
                    .HasColumnName("IVA_JDE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Largoempaque)
                    .HasColumnName("LARGOEMPAQUE")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LineaAntJde)
                    .HasColumnName("LINEA_ANT_JDE")
                    .HasColumnType("decimal(2, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProducto)
                    .IsRequired()
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaTotDol)
                    .HasColumnName("LISTA_TOT_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Longitudmascara)
                    .HasColumnName("LONGITUDMASCARA")
                    .HasColumnType("decimal(14, 0)");

                entity.Property(e => e.Maquina)
                    .HasColumnName("MAQUINA")
                    .HasColumnType("decimal(4, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasColumnName("MEDIDA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nocalculamc)
                    .HasColumnName("NOCALCULAMC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEmb)
                    .HasColumnName("NOMBRE_EMB")
                    .HasColumnType("text");

                entity.Property(e => e.NombreFact)
                    .HasColumnName("NOMBRE_FACT")
                    .HasColumnType("text");

                entity.Property(e => e.NumeroPedido).HasColumnName("NUMERO_PEDIDO");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Papel)
                    .HasColumnName("PAPEL")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasColumnName("PASO_SQL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcCom)
                    .HasColumnName("PORC_COM")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.PorcIva)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnName("PORC_MC_FINAN")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcentConces)
                    .HasColumnName("PORCENT_CONCES")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Pormc)
                    .HasColumnName("PORMC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("PRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Presentacion)
                    .IsRequired()
                    .HasColumnName("PRESENTACION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnName("RBS_MC_FINAN")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcFinansc)
                    .HasColumnName("RBS_MC_FINANSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnName("RBS_MC_PAPEL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapelsc)
                    .HasColumnName("RBS_MC_PAPELSC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rbsmc)
                    .HasColumnName("RBSMC")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecalcularMargen)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.RemisionOfic).HasColumnName("REMISION_OFIC");

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasColumnName("RIF_EMB")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RprecioLista)
                    .HasColumnName("RPRECIO_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnName("RPRECIO_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rtasa)
                    .HasColumnName("RTASA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalLista)
                    .HasColumnName("RTOTAL_LISTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnName("RTOTAL_VENTA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sddcto)
                    .HasColumnName("SDDCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sddoco)
                    .HasColumnName("SDDOCO")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sdkcoo)
                    .HasColumnName("SDKCOO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Sdlnid)
                    .HasColumnName("SDLNID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Seriecdesde)
                    .HasColumnName("SERIECDESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Seriechasta)
                    .HasColumnName("SERIECHASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Seriefdesde)
                    .HasColumnName("SERIEFDESDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Seriefhasta)
                    .HasColumnName("SERIEFHASTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tasa)
                    .HasColumnName("TASA")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TipoIva)
                    .HasColumnName("TIPO_IVA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tipodocumento)
                    .HasColumnName("TIPODOCUMENTO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLista)
                    .HasColumnName("TOTAL_LISTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TotalVenta)
                    .HasColumnName("TOTAL_VENTA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.UnitListaDol)
                    .HasColumnName("UNIT_LISTA_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.UnitVentaDol)
                    .HasColumnName("UNIT_VENTA_DOL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Usuarioupdate)
                    .IsRequired()
                    .HasColumnName("USUARIOUPDATE")
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.VendGestion)
                    .IsRequired()
                    .HasColumnName("VEND_GESTION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.VentaTotDol)
                    .HasColumnName("VENTA_TOT_DOL")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<DataInicial>(entity =>
            {
                entity.HasIndex(e => e.Archivo)
                    .HasName("IX_DataInicial");

                entity.HasIndex(e => e.Data)
                    .HasName("index_Data_DataInicial");

                entity.HasIndex(e => e.Lote)
                    .HasName("IX_DataInicial_1");

                entity.HasIndex(e => e.OrdenArchivo)
                    .HasName("index_DataInicial_OrdenArchivo");

                entity.HasIndex(e => new { e.OrdenArchivo, e.Id })
                    .HasName("index_DataInicial_OrdenArchivoId");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Archivo).HasMaxLength(100);

                entity.Property(e => e.Data).HasMaxLength(250);

                entity.Property(e => e.Lote).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrdenArchivo).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<DeudorTipoRetencion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cliente).HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IndicadorRetencion).HasMaxLength(2);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.TipoRetencion).HasMaxLength(2);
            });

            modelBuilder.Entity<Deudores>(entity =>
            {
                entity.HasKey(e => e.Cliente);

                entity.Property(e => e.Cliente).HasMaxLength(10);

                entity.Property(e => e.Clase).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.Rif).HasMaxLength(255);
            });

            modelBuilder.Entity<EjeucionProceso>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FechaEjecucion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fin).HasColumnType("datetime");

                entity.Property(e => e.IdEvaluacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdObjetoProceso).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Query).IsRequired();

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<EjeucionProcesoComisiones>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FechaEjecucion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fin).HasColumnType("datetime");

                entity.Property(e => e.IdEvaluacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Query).IsRequired();

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<EscaneoTicket>(entity =>
            {
                entity.HasIndex(e => e.Data)
                    .HasName("IX_EscaneoTickect");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Data).HasMaxLength(250);

                entity.Property(e => e.FechaEscaneo).HasColumnType("smalldatetime");

                entity.Property(e => e.UsuarioEscaneo).HasMaxLength(128);
            });

            modelBuilder.Entity<F03b11>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("F03B11");

                entity.Property(e => e.Actualizacion)
                    .HasColumnName("ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dias).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechaFoto)
                    .HasColumnName("Fecha_foto")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mensaje).HasMaxLength(255);

                entity.Property(e => e.PorcFoto).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rpaap).HasColumnName("RPAAP");

                entity.Property(e => e.Rpacr).HasColumnName("RPACR");

                entity.Property(e => e.Rpadsa).HasColumnName("RPADSA");

                entity.Property(e => e.Rpadsc).HasColumnName("RPADSC");

                entity.Property(e => e.Rpafc)
                    .HasColumnName("RPAFC")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpag).HasColumnName("RPAG");

                entity.Property(e => e.Rpaid)
                    .HasColumnName("RPAID")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Rpaid2)
                    .HasColumnName("RPAID2")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Rpajcl)
                    .HasColumnName("RPAJCL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpalph)
                    .HasColumnName("RPALPH")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Rpalt6)
                    .HasColumnName("RPALT6")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpam)
                    .HasColumnName("RPAM")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpam2)
                    .HasColumnName("RPAM2")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpan8).HasColumnName("RPAN8");

                entity.Property(e => e.Rpan8j).HasColumnName("RPAN8J");

                entity.Property(e => e.Rpar01)
                    .HasColumnName("RPAR01")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpar02)
                    .HasColumnName("RPAR02")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpar03)
                    .HasColumnName("RPAR03")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpar04)
                    .HasColumnName("RPAR04")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpar05)
                    .HasColumnName("RPAR05")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpar06)
                    .HasColumnName("RPAR06")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpar07)
                    .HasColumnName("RPAR07")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpar08)
                    .HasColumnName("RPAR08")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpar09)
                    .HasColumnName("RPAR09")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpar10)
                    .HasColumnName("RPAR10")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpatad).HasColumnName("RPATAD");

                entity.Property(e => e.Rpatxa).HasColumnName("RPATXA");

                entity.Property(e => e.Rpatxn).HasColumnName("RPATXN");

                entity.Property(e => e.Rpbalj)
                    .HasColumnName("RPBALJ")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpbcrc)
                    .HasColumnName("RPBCRC")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpcds).HasColumnName("RPCDS");

                entity.Property(e => e.Rpcdsa).HasColumnName("RPCDSA");

                entity.Property(e => e.Rpclmg)
                    .HasColumnName("RPCLMG")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rpcmc1).HasColumnName("RPCMC1");

                entity.Property(e => e.Rpcmgr)
                    .HasColumnName("RPCMGR")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rpco)
                    .HasColumnName("RPCO")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Rpcoll)
                    .HasColumnName("RPCOLL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpcorc)
                    .HasColumnName("RPCORC")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpcrcd)
                    .HasColumnName("RPCRCD")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpcrr).HasColumnName("RPCRR");

                entity.Property(e => e.Rpcrrm)
                    .HasColumnName("RPCRRM")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpctad).HasColumnName("RPCTAD");

                entity.Property(e => e.Rpctam).HasColumnName("RPCTAM");

                entity.Property(e => e.Rpctl)
                    .HasColumnName("RPCTL")
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Rpctry).HasColumnName("RPCTRY");

                entity.Property(e => e.Rpctxa).HasColumnName("RPCTXA");

                entity.Property(e => e.Rpctxn).HasColumnName("RPCTXN");

                entity.Property(e => e.Rpdct)
                    .IsRequired()
                    .HasColumnName("RPDCT")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpdcto)
                    .HasColumnName("RPDCTO")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpddex)
                    .HasColumnName("RPDDEX")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpddj)
                    .HasColumnName("RPDDJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpddnj)
                    .HasColumnName("RPDDNJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpdgj)
                    .HasColumnName("RPDGJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpdicj)
                    .HasColumnName("RPDICJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpdivj)
                    .HasColumnName("RPDIVJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpdmcd)
                    .HasColumnName("RPDMCD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpdnlt)
                    .HasColumnName("RPDNLT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpdoc).HasColumnName("RPDOC");

                entity.Property(e => e.Rpdoco).HasColumnName("RPDOCO");

                entity.Property(e => e.Rpdrf).HasColumnName("RPDRF");

                entity.Property(e => e.Rpdsvj)
                    .HasColumnName("RPDSVJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpdtpb)
                    .HasColumnName("RPDTPB")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpdtxs)
                    .HasColumnName("RPDTXS")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rperdj)
                    .HasColumnName("RPERDJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpexr1)
                    .HasColumnName("RPEXR1")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpfap).HasColumnName("RPFAP");

                entity.Property(e => e.Rpfnlp)
                    .HasColumnName("RPFNLP")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpfnrt).HasColumnName("RPFNRT");

                entity.Property(e => e.Rpfy).HasColumnName("RPFY");

                entity.Property(e => e.Rpgfl1)
                    .HasColumnName("RPGFL1")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpgfl2)
                    .HasColumnName("RPGFL2")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpglba)
                    .HasColumnName("RPGLBA")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Rpglc)
                    .HasColumnName("RPGLC")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Rphcrr).HasColumnName("RPHCRR");

                entity.Property(e => e.Rphdgj)
                    .HasColumnName("RPHDGJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpicu).HasColumnName("RPICU");

                entity.Property(e => e.Rpicut)
                    .HasColumnName("RPICUT")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpistc)
                    .HasColumnName("RPISTC")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpistr)
                    .HasColumnName("RPISTR")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpitm).HasColumnName("RPITM");

                entity.Property(e => e.Rpjcl)
                    .HasColumnName("RPJCL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpjobn)
                    .HasColumnName("RPJOBN")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rpkco)
                    .IsRequired()
                    .HasColumnName("RPKCO")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Rpkcoo)
                    .HasColumnName("RPKCOO")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Rplfcj)
                    .HasColumnName("RPLFCJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rplnid).HasColumnName("RPLNID");

                entity.Property(e => e.Rpmcu)
                    .HasColumnName("RPMCU")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Rpmcu2)
                    .HasColumnName("RPMCU2")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Rpnbrr)
                    .HasColumnName("RPNBRR")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpnetdoc).HasColumnName("RPNETDOC");

                entity.Property(e => e.Rpnetrc5).HasColumnName("RPNETRC5");

                entity.Property(e => e.Rpnetst)
                    .HasColumnName("RPNETST")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpnettcid).HasColumnName("RPNETTCID");

                entity.Property(e => e.Rpnrta).HasColumnName("RPNRTA");

                entity.Property(e => e.Rpobj)
                    .HasColumnName("RPOBJ")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Rpodct)
                    .HasColumnName("RPODCT")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpodoc).HasColumnName("RPODOC");

                entity.Property(e => e.Rpokco)
                    .HasColumnName("RPOKCO")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Rpomod)
                    .HasColumnName("RPOMOD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rposfx)
                    .HasColumnName("RPOSFX")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rppa8).HasColumnName("RPPA8");

                entity.Property(e => e.Rppdct)
                    .HasColumnName("RPPDCT")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rppid)
                    .HasColumnName("RPPID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rppkco)
                    .HasColumnName("RPPKCO")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Rppn).HasColumnName("RPPN");

                entity.Property(e => e.Rppo)
                    .HasColumnName("RPPO")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Rppost)
                    .HasColumnName("RPPOST")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpppdi)
                    .HasColumnName("RPPPDI")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpprgf)
                    .HasColumnName("RPPRGF")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rppst)
                    .HasColumnName("RPPST")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpptc)
                    .HasColumnName("RPPTC")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rppwpg).HasColumnName("RPPWPG");

                entity.Property(e => e.Rppyid).HasColumnName("RPPYID");

                entity.Property(e => e.Rppyr).HasColumnName("RPPYR");

                entity.Property(e => e.Rprddj)
                    .HasColumnName("RPRDDJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rprdrl)
                    .HasColumnName("RPRDRL")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rprdsj)
                    .HasColumnName("RPRDSJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rprf)
                    .HasColumnName("RPRF")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rprmds).HasColumnName("RPRMDS");

                entity.Property(e => e.Rprmk)
                    .HasColumnName("RPRMK")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Rprnid).HasColumnName("RPRNID");

                entity.Property(e => e.Rprp1)
                    .HasColumnName("RPRP1")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rprp2)
                    .HasColumnName("RPRP2")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rprp3)
                    .HasColumnName("RPRP3")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rprsco)
                    .HasColumnName("RPRSCO")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpryin)
                    .HasColumnName("RPRYIN")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpsbl)
                    .HasColumnName("RPSBL")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Rpsblt)
                    .HasColumnName("RPSBLT")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpsdct)
                    .HasColumnName("RPSDCT")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpsdoc).HasColumnName("RPSDOC");

                entity.Property(e => e.Rpsfx)
                    .IsRequired()
                    .HasColumnName("RPSFX")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpsfxo)
                    .HasColumnName("RPSFXO")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpshpn).HasColumnName("RPSHPN");

                entity.Property(e => e.Rpskco)
                    .HasColumnName("RPSKCO")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Rpsmtj)
                    .HasColumnName("RPSMTJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpsotf)
                    .HasColumnName("RPSOTF")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpstam).HasColumnName("RPSTAM");

                entity.Property(e => e.Rpsub)
                    .HasColumnName("RPSUB")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Rptorg)
                    .HasColumnName("RPTORG")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rptxa1)
                    .HasColumnName("RPTXA1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rpu).HasColumnName("RPU");

                entity.Property(e => e.Rpum)
                    .HasColumnName("RPUM")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Rpunit)
                    .HasColumnName("RPUNIT")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Rpupmj)
                    .HasColumnName("RPUPMJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpupmt).HasColumnName("RPUPMT");

                entity.Property(e => e.Rpurab).HasColumnName("RPURAB");

                entity.Property(e => e.Rpurat).HasColumnName("RPURAT");

                entity.Property(e => e.Rpurc1)
                    .HasColumnName("RPURC1")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Rpurdt)
                    .HasColumnName("RPURDT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpurrf)
                    .HasColumnName("RPURRF")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Rpuser)
                    .HasColumnName("RPUSER")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rpvdgj)
                    .HasColumnName("RPVDGJ")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpvinv)
                    .HasColumnName("RPVINV")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Rpvldt)
                    .HasColumnName("RPVLDT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rpvod)
                    .HasColumnName("RPVOD")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Rpvr01)
                    .HasColumnName("RPVR01")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.SaldoFoto).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Transferir)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.VencimientoEntrega).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<GssAdjuntoTarea>(entity =>
            {
                entity.HasKey(e => e.IdAdjuntoTarea)
                    .HasName("PK_AdjuntoTarea");

                entity.HasIndex(e => e.IdTarea)
                    .HasName("IX_IdTarea");

                entity.Property(e => e.Archivo).IsRequired();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdTareaNavigation)
                    .WithMany(p => p.GssAdjuntoTarea)
                    .HasForeignKey(d => d.IdTarea)
                    .HasConstraintName("FK_GssAdjuntoTarea_GssTarea");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.GssAdjuntoTarea)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAdjuntoTarea_GssTipoDocumento");
            });

            modelBuilder.Entity<GssAdminApp>(entity =>
            {
                entity.HasKey(e => new { e.IdUnidadServicio, e.IdUsuario });
            });

            modelBuilder.Entity<GssAprobacionServicio>(entity =>
            {
                entity.HasKey(e => e.IdAprobacionServicio);

                entity.HasIndex(e => new { e.IdTarea, e.Secuencia })
                    .HasName("IX_IdTarea_Secuencia")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdEstatusTarea, e.IdUsuario, e.IdTarea, e.Secuencia })
                    .HasName("IX_EstatusUsuarioTareaSecuencia")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdAprobacionServicio, e.IdTarea, e.IdNivel, e.IdGrupoTrabajo, e.Secuencia, e.FechaEntrada, e.IdEstatusTarea })
                    .HasName("IX_Servicios_x_Ejecutar");

                entity.Property(e => e.FechaEntrada).HasColumnType("datetime");

                entity.Property(e => e.FechaSalida).HasColumnType("datetime");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdEstatusTareaNavigation)
                    .WithMany(p => p.GssAprobacionServicio)
                    .HasForeignKey(d => d.IdEstatusTarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAprobacionServicio_GssEstatusTarea");

                entity.HasOne(d => d.IdNivelNavigation)
                    .WithMany(p => p.GssAprobacionServicio)
                    .HasForeignKey(d => d.IdNivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAprobacionServicio_GssNivel");

                entity.HasOne(d => d.IdTareaNavigation)
                    .WithMany(p => p.GssAprobacionServicio)
                    .HasForeignKey(d => d.IdTarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAprobacionServicio_GssTarea");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.GssAprobacionServicio)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAprobacionServicio_SegUsuario");
            });

            modelBuilder.Entity<GssAreaServicio>(entity =>
            {
                entity.HasKey(e => e.IdAreaServicio);

                entity.HasComment("Areas de Servicio por Unidad (Dpto.)");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.NombreAreaServicio)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.IdUnidadServicioNavigation)
                    .WithMany(p => p.GssAreaServicio)
                    .HasForeignKey(d => d.IdUnidadServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAreaServicio_GssUnidadServicio");
            });

            modelBuilder.Entity<GssCompañia>(entity =>
            {
                entity.HasKey(e => e.IdCompañia);

                entity.HasComment("Registro de Compañias");

                entity.Property(e => e.IdCompañia).ValueGeneratedNever();

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.IdJde)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NombreCompañia)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.GssCompañia)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssCompañia_GssPais");
            });

            modelBuilder.Entity<GssEstatusSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdEstatusSolicitud);

                entity.Property(e => e.Abreviado)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.NombreEstatusSolicitud)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GssEstatusTarea>(entity =>
            {
                entity.HasKey(e => e.IdEstatusTarea);

                entity.Property(e => e.Abreviado)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.NombreEstatusTarea)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GssGrupoTrabajo>(entity =>
            {
                entity.HasKey(e => e.IdGrupoTabajo);

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.IdUnidadServicio).HasDefaultValueSql("((0))");

                entity.Property(e => e.NombreGrupoTrabajo)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<GssGrupoTrabajoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdGrupoTrabajoUsuario);

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");
            });

            modelBuilder.Entity<GssMtrTipoDato>(entity =>
            {
                entity.HasKey(e => e.IdTipoDato);

                entity.HasIndex(e => e.Orden)
                    .HasName("IX_GssMtrTipoDato")
                    .IsUnique();

                entity.Property(e => e.IdTipoDato).HasMaxLength(30);

                entity.Property(e => e.MascaraUsuario)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MensajeUsuario)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TipoDatoDatatables)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GssNivel>(entity =>
            {
                entity.HasKey(e => e.IdNivel);

                entity.HasComment("Niveles por area de servicio");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.NombreNivel)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.IdUnidadServicioNavigation)
                    .WithMany(p => p.GssNivel)
                    .HasForeignKey(d => d.IdUnidadServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssNivel_GssNivel");
            });

            modelBuilder.Entity<GssPais>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.NombrePais)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GssPasoSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdPasoSolicitud);

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.GssPasoSolicitud)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssPasoSolicitud_GssSolicitud");
            });

            modelBuilder.Entity<GssPlantillaServicio>(entity =>
            {
                entity.HasKey(e => e.IdPlantillaServicio);

                entity.HasComment("Plantilla de Servicio");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.FuncionBusqueda).HasMaxLength(80);

                entity.Property(e => e.OcultaDuplicado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.GssPlantillaServicio)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssPlantillaServicio_GssServicios");

                entity.HasOne(d => d.IdVariableNavigation)
                    .WithMany(p => p.GssPlantillaServicio)
                    .HasForeignKey(d => d.IdVariable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssPlantillaServicio_GssVariablesPlantilla");
            });

            modelBuilder.Entity<GssServicioNivel>(entity =>
            {
                entity.HasKey(e => e.IdServicioNivel);

                entity.HasComment("Niveles por servicios");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.HasOne(d => d.IdNivelNavigation)
                    .WithMany(p => p.GssServicioNivel)
                    .HasForeignKey(d => d.IdNivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssServicioNivel_GssNivel");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.GssServicioNivel)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssServicioNivel_GssServicios");
            });

            modelBuilder.Entity<GssServicioResponsable>(entity =>
            {
                entity.HasKey(e => e.IdServicioResponsable);

                entity.HasIndex(e => new { e.IdServicio, e.IdResponsable })
                    .HasName("IX_GssServicioResponsable_1");

                entity.HasIndex(e => new { e.IdServicio, e.IdTipoNomina, e.IdResponsable, e.Secuencia })
                    .HasName("IX_GssServicioResponsable")
                    .IsUnique();

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.IdTipoNomina)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<GssServicios>(entity =>
            {
                entity.HasKey(e => e.IdServicio);

                entity.HasComment("Servicios Disponibles");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.FlagControlNomina)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FormatoReporte)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreServicio)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.GssServicios)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssServicios_GssTipoServicio");
            });

            modelBuilder.Entity<GssSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud)
                    .HasName("PK_GssSolicitudServicio");

                entity.HasComment("Registro Solicitud de Servicio");

                entity.Property(e => e.DescripcionSolicitud).IsRequired();

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");

                entity.Property(e => e.JustificacionSolicitud).IsRequired();

                entity.Property(e => e.TituloSolicitud)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.IdEstatusSolicitudNavigation)
                    .WithMany(p => p.GssSolicitud)
                    .HasForeignKey(d => d.IdEstatusSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssSolicitud_GssEstatusSolicitud");

                entity.HasOne(d => d.IdUnidadServicioNavigation)
                    .WithMany(p => p.GssSolicitud)
                    .HasForeignKey(d => d.IdUnidadServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssSolicitud_GssUnidadServicio");
            });

            modelBuilder.Entity<GssSolicitudServicio>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudServicio)
                    .HasName("PK_GssSolicitudServicio_1");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");
            });

            modelBuilder.Entity<GssTarea>(entity =>
            {
                entity.HasKey(e => e.IdTarea)
                    .HasName("PK_GssTareas");

                entity.HasComment("Registro de Tareas por Solicitud");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_IdSolicitud");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.FechaProcesada).HasColumnType("datetime");

                entity.Property(e => e.FechaTarea).HasColumnType("datetime");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.GssTarea)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssTareas_GssServicios");

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.GssTarea)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssTarea_GssSolicitud");
            });

            modelBuilder.Entity<GssTareaComentario>(entity =>
            {
                entity.HasKey(e => e.IdComentarioTarea)
                    .IsClustered(false);

                entity.Property(e => e.ComentarioTarea)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaComentario).HasColumnType("datetime");

                entity.HasOne(d => d.IdTareaNavigation)
                    .WithMany(p => p.GssTareaComentario)
                    .HasForeignKey(d => d.IdTarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssTareaComentario_GssTarea");
            });

            modelBuilder.Entity<GssTareaPlantillaServicio>(entity =>
            {
                entity.HasKey(e => e.IdTareaPlantillaServicio);

                entity.HasComment("Detalle de Tarea Plantilla de Srvicio");

                entity.HasIndex(e => new { e.IdTarea, e.IdVariable })
                    .HasName("IX_IdTarea_IdVariable")
                    .IsUnique();

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.MensajeBusqueda)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Requerido)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ValorEntrada)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ValorSalida)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdPlantillaServicioNavigation)
                    .WithMany(p => p.GssTareaPlantillaServicio)
                    .HasForeignKey(d => d.IdPlantillaServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssTareaPlantillaServicio_GssPlantillaServicio");

                entity.HasOne(d => d.IdTareaNavigation)
                    .WithMany(p => p.GssTareaPlantillaServicio)
                    .HasForeignKey(d => d.IdTarea)
                    .HasConstraintName("FK_GssTareaPlantillaServicio_GssTarea");
            });

            modelBuilder.Entity<GssTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombreDocumento)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GssTipoServicio>(entity =>
            {
                entity.HasKey(e => e.IdTipoServicio);

                entity.HasComment("Tipo de Servicio por Area / Unudad");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.NombreTipoServicio)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.IdAreaServicioNavigation)
                    .WithMany(p => p.GssTipoServicio)
                    .HasForeignKey(d => d.IdAreaServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssTipoServicio_GssAreaServicio");
            });

            modelBuilder.Entity<GssUnidadServicio>(entity =>
            {
                entity.HasKey(e => e.IdUnidadServicio);

                entity.HasComment("Unidad de Servicio por Compañia   (Dpto.) ");

                entity.Property(e => e.Abreviado)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CuentaUnidadServicio)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.NombreUnidadServicio)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<GssUnidadServicioCompañia>(entity =>
            {
                entity.HasKey(e => e.IdUnidadServicioCompañia);

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.HasOne(d => d.IdCompañiaNavigation)
                    .WithMany(p => p.GssUnidadServicioCompañia)
                    .HasForeignKey(d => d.IdCompañia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssUnidadServicioCompañia_GssCompañia");

                entity.HasOne(d => d.IdUnidadServicioNavigation)
                    .WithMany(p => p.GssUnidadServicioCompañia)
                    .HasForeignKey(d => d.IdUnidadServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssUnidadServicioCompañia_GssUnidadServicio");
            });

            modelBuilder.Entity<GssUsuarioCompañia>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioCompañia);

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.HasOne(d => d.IdCompañiaNavigation)
                    .WithMany(p => p.GssUsuarioCompañia)
                    .HasForeignKey(d => d.IdCompañia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssUsuarioCompañia_GssCompañia");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.GssUsuarioCompañia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssUsuarioCompañia_SegUsuario");
            });

            modelBuilder.Entity<GssUsuarioNivel>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioNivel);

                entity.HasComment("Usuario por niveles de servicio");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.HasOne(d => d.IdNivelNavigation)
                    .WithMany(p => p.GssUsuarioNivel)
                    .HasForeignKey(d => d.IdNivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssUsuarioNivel_GssNivel");
            });

            modelBuilder.Entity<GssUsuarioPlantillaServicio>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioPlantillaServicio)
                    .HasName("PK_GssUsuarioPlantillaServicio_1");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.GssUsuarioPlantillaServicio)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssUsuarioPlantillaServicio_GssServicios");

                entity.HasOne(d => d.IdVariableNavigation)
                    .WithMany(p => p.GssUsuarioPlantillaServicio)
                    .HasForeignKey(d => d.IdVariable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssUsuarioPlantillaServicio_GssVariable");
            });

            modelBuilder.Entity<GssVariable>(entity =>
            {
                entity.HasKey(e => e.IdVariable)
                    .HasName("PK_GssVariablesPlantilla");

                entity.HasComment("Variables de entrada por plantilla de servicio");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.FlagGenerica)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FuncionBusqueda).HasMaxLength(80);

                entity.Property(e => e.NombreVariable)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TipoDato)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TituloVariable)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Marm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MARM");

                entity.HasIndex(e => new { e.Matnr, e.Meinh })
                    .HasName("IX_MARM")
                    .IsUnique();

                entity.Property(e => e.Atinn)
                    .IsRequired()
                    .HasColumnName("ATINN")
                    .HasMaxLength(60);

                entity.Property(e => e.BflmeMarm)
                    .IsRequired()
                    .HasColumnName("BFLME_MARM")
                    .HasMaxLength(6);

                entity.Property(e => e.Breit)
                    .HasColumnName("BREIT")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Brgew)
                    .HasColumnName("BRGEW")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Capause)
                    .HasColumnName("CAPAUSE")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Ean11)
                    .IsRequired()
                    .HasColumnName("EAN11")
                    .HasMaxLength(108);

                entity.Property(e => e.Eannr)
                    .IsRequired()
                    .HasColumnName("EANNR")
                    .HasMaxLength(78);

                entity.Property(e => e.Gewei)
                    .IsRequired()
                    .HasColumnName("GEWEI")
                    .HasMaxLength(18);

                entity.Property(e => e.GtinVariant)
                    .IsRequired()
                    .HasColumnName("GTIN_VARIANT")
                    .HasMaxLength(12);

                entity.Property(e => e.Hoehe)
                    .HasColumnName("HOEHE")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Kzwso)
                    .IsRequired()
                    .HasColumnName("KZWSO")
                    .HasMaxLength(6);

                entity.Property(e => e.Laeng)
                    .HasColumnName("LAENG")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Mandt)
                    .IsRequired()
                    .HasColumnName("MANDT")
                    .HasMaxLength(18);

                entity.Property(e => e.Matnr)
                    .IsRequired()
                    .HasColumnName("MATNR")
                    .HasMaxLength(12);

                entity.Property(e => e.MaxStack).HasColumnName("MAX_STACK");

                entity.Property(e => e.Meabm)
                    .IsRequired()
                    .HasColumnName("MEABM")
                    .HasMaxLength(18);

                entity.Property(e => e.Meinh)
                    .IsRequired()
                    .HasColumnName("MEINH")
                    .HasMaxLength(18);

                entity.Property(e => e.Mesrt)
                    .IsRequired()
                    .HasColumnName("MESRT")
                    .HasMaxLength(12);

                entity.Property(e => e.Mesub)
                    .IsRequired()
                    .HasColumnName("MESUB")
                    .HasMaxLength(18);

                entity.Property(e => e.Msehi)
                    .IsRequired()
                    .HasColumnName("MSEHI")
                    .HasMaxLength(18);

                entity.Property(e => e.NestFtr)
                    .HasColumnName("NEST_FTR")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Numtp)
                    .IsRequired()
                    .HasColumnName("NUMTP")
                    .HasMaxLength(12);

                entity.Property(e => e.Ty2tq)
                    .IsRequired()
                    .HasColumnName("TY2TQ")
                    .HasMaxLength(6);

                entity.Property(e => e.Umren)
                    .HasColumnName("UMREN")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Umrez)
                    .HasColumnName("UMREZ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Voleh)
                    .IsRequired()
                    .HasColumnName("VOLEH")
                    .HasMaxLength(18);

                entity.Property(e => e.Volum)
                    .HasColumnName("VOLUM")
                    .HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Xbeww)
                    .IsRequired()
                    .HasColumnName("XBEWW")
                    .HasMaxLength(6);

                entity.Property(e => e.Xfhdw)
                    .IsRequired()
                    .HasColumnName("XFHDW")
                    .HasMaxLength(6);

              

              
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MtrBancos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WARY075_INDEX01");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AplicaImp)
                    .IsRequired()
                    .HasColumnName("APLICA_IMP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodContable)
                    .IsRequired()
                    .HasColumnName("COD_CONTABLE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProdGenerico)
                    .HasColumnName("PROD_GENERICO")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TraAsociada)
                    .HasColumnName("TRA_ASOCIADA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TraJde)
                    .HasColumnName("TRA_JDE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdTipoCuentaDestinoNavigation)
                    .WithMany(p => p.MtrBancos)
                    .HasForeignKey(d => d.IdTipoCuentaDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MtrBancos_MtrTipoCuentaDestino");
            });

            modelBuilder.Entity<MtrCliente>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.HasIndex(e => e.CodJde)
                    .HasName("IX_MtrCliente_2");

                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_MtrCliente");

                entity.HasIndex(e => e.Nombre)
                    .HasName("IX_MtrCliente_4");

                entity.HasIndex(e => e.OficinaVenta)
                    .HasName("IX_MtrCliente_3");

                entity.HasIndex(e => e.Vendedor1)
                    .HasName("IX_MtrCliente_1");

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CapitalSoc)
                    .HasColumnName("CAPITAL_SOC")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnName("CIERRE_EJERC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClientContado)
                    .HasColumnName("Client_Contado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");

                entity.Property(e => e.CodJdePadre).HasColumnName("Cod_jdePadre");

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("Cod_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasColumnName("Cod_SubSegmento")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("Codigo_Ciudad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("Codigo_Estado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("Codigo_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoNumerico)
                    .HasColumnName("codigo_numerico")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CodigoParroq)
                    .HasColumnName("Codigo_Parroq")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("Codigo_Postal")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("Codigo_Region")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContCarg1)
                    .HasColumnName("Cont_Carg_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasColumnName("Cont_Carg_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasColumnName("Cont_Carg_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasColumnName("Cont_Email_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasColumnName("Cont_Email_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasColumnName("Cont_Email_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasColumnName("Cont_Especial")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnName("Cont_FechNacm_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnName("Cont_FechNacm_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnName("Cont_FechNacm_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb1)
                    .HasColumnName("Cont_Nomb_1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasColumnName("Cont_Nomb_2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasColumnName("Cont_Nomb_3")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasColumnName("Cont_Telf_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasColumnName("Cont_Telf_2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasColumnName("Cont_Telf_3")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasColumnName("DEPURA_COD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Depurar)
                    .HasColumnName("depurar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasColumnName("Dia_de_Cobro")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion).HasMaxLength(80);

                entity.Property(e => e.Direccion1).HasMaxLength(80);

                entity.Property(e => e.Direccion2).HasMaxLength(80);

                entity.Property(e => e.EMailClient)
                    .HasColumnName("E_mail_Client")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado).HasMaxLength(2);

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasColumnName("Exento_de_Impuesto")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FApertura)
                    .HasColumnName("F_Apertura")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FModificacion)
                    .HasColumnName("F_Modificacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnName("F_Ultm_Compra")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAtendido)
                    .HasColumnName("Fecha_Atendido")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCerrado)
                    .HasColumnName("Fecha_Cerrado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDesatendido)
                    .HasColumnName("Fecha_Desatendido")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnName("Fecha_Inactivo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaLegal)
                    .HasColumnName("FECHA_LEGAL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificadoLimite)
                    .HasColumnName("Fecha_modificado_Limite")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnName("Fecha_Reactivado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnName("FECHA_RIESGO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlagAtendido)
                    .HasColumnName("Flag_Atendido")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FlagCerrado)
                    .HasColumnName("Flag_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("Flag_Inactivo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMat)
                    .HasColumnName("Flag_Mat")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasColumnName("Flag_Modificado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasColumnName("Flag_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasColumnName("Giro_Negocio")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoCliente)
                    .HasColumnName("GRUPO_CLIENTE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_direccion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Klabc)
                    .HasColumnName("KLABC")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'C')");

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_Credito")
                    .HasColumnType("money");

                entity.Property(e => e.Legal)
                    .HasColumnName("LEGAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("Limite_Cred_Ut")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.Municipio).HasMaxLength(2);

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoPasoJde)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasColumnName("No_Reg_Tribut")
                    .HasMaxLength(12);

                entity.Property(e => e.Nombre).HasMaxLength(80);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OficinaVenta)
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("Orden_Compra")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasColumnName("Pagina_Web")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasColumnName("Repres_Legal")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasColumnName("RIESGO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RutCartero)
                    .HasColumnName("Rut_Cartero")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Saldo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Segmento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiDolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Smacc)
                    .HasColumnName("smacc")
                    .HasMaxLength(50);

                entity.Property(e => e.SubSegmentoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TImpuesto).HasColumnName("T_Impuesto");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoNegocio)
                    .HasColumnName("Tipo_Negocio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasColumnName("USUARIO_MOD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zzsn01)
                    .HasColumnName("ZZSN01")
                    .HasMaxLength(50)
                    .HasComment("Página Web");

                entity.Property(e => e.Zzsn02)
                    .HasColumnName("ZZSN02")
                    .HasMaxLength(50)
                    .HasComment("Facebook");

                entity.Property(e => e.Zzsn03)
                    .HasColumnName("ZZSN03")
                    .HasMaxLength(50)
                    .HasComment("Google+");

                entity.Property(e => e.Zzsn04)
                    .HasColumnName("ZZSN04")
                    .HasMaxLength(50)
                    .HasComment("Instagram");

                entity.Property(e => e.Zzsn05)
                    .HasColumnName("ZZSN05")
                    .HasMaxLength(50)
                    .HasComment("Twitter");

                entity.Property(e => e.Zzsn06)
                    .HasColumnName("ZZSN06")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<MtrClienteProspecto>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.HasIndex(e => e.Rif)
                    .HasName("IX_Rif")
                    .IsUnique();

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.Direccion).HasMaxLength(240);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdVendedor).HasMaxLength(10);

                entity.Property(e => e.NombreCliente).HasMaxLength(80);

                entity.Property(e => e.Rif).HasMaxLength(12);
            });

            modelBuilder.Entity<MtrClienteTemp>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_MtrCliente_temp");

                entity.ToTable("MtrCliente_Temp");

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.AreaCobranz)
                    .HasColumnName("Area_Cobranz")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CapitalSoc)
                    .HasColumnName("CAPITAL_SOC")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnName("CIERRE_EJERC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClientContado)
                    .HasColumnName("Client_Contado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasColumnName("Cliente_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");

                entity.Property(e => e.CodJdePadre).HasColumnName("Cod_jdePadre");

                entity.Property(e => e.CodMcpo)
                    .HasColumnName("Cod_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasColumnName("Cod_SubSegmento")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("Codigo_Ciudad")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasColumnName("Codigo_Estado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasColumnName("Codigo_Mcpo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoNumerico)
                    .HasColumnName("codigo_numerico")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CodigoParroq)
                    .HasColumnName("Codigo_Parroq")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("Codigo_Postal")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("Codigo_Region")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnName("COND_PAGO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContCarg1)
                    .HasColumnName("Cont_Carg_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasColumnName("Cont_Carg_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasColumnName("Cont_Carg_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasColumnName("Cont_Email_1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasColumnName("Cont_Email_2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasColumnName("Cont_Email_3")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasColumnName("Cont_Especial")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnName("Cont_FechNacm_1")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnName("Cont_FechNacm_2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnName("Cont_FechNacm_3")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContNomb1)
                    .HasColumnName("Cont_Nomb_1")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasColumnName("Cont_Nomb_2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasColumnName("Cont_Nomb_3")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasColumnName("Cont_Telf_1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasColumnName("Cont_Telf_2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasColumnName("Cont_Telf_3")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasColumnName("DEPURA_COD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Depurar)
                    .HasColumnName("depurar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasColumnName("Dia_de_Cobro")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion).HasMaxLength(80);

                entity.Property(e => e.Direccion1).HasMaxLength(80);

                entity.Property(e => e.Direccion2).HasMaxLength(80);

                entity.Property(e => e.EMailClient)
                    .HasColumnName("E_mail_Client")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado).HasMaxLength(2);

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasColumnName("Exento_de_Impuesto")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FApertura)
                    .HasColumnName("F_Apertura")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FModificacion)
                    .HasColumnName("F_Modificacion")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnName("F_Ultm_Compra")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAtendido)
                    .HasColumnName("Fecha_Atendido")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCerrado)
                    .HasColumnName("Fecha_Cerrado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDesatendido)
                    .HasColumnName("Fecha_Desatendido")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnName("Fecha_Inactivo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaLegal)
                    .HasColumnName("FECHA_LEGAL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificadoLimite)
                    .HasColumnName("Fecha_modificado_Limite")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnName("Fecha_Reactivado")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnName("FECHA_RIESGO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlagAtendido)
                    .HasColumnName("Flag_Atendido")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FlagCerrado)
                    .HasColumnName("Flag_Cerrado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasColumnName("Flag_Inactivo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMat)
                    .HasColumnName("Flag_Mat")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasColumnName("Flag_Modificado")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasColumnName("Flag_Nuevo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasColumnName("Giro_Negocio")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoCliente)
                    .HasColumnName("GRUPO_CLIENTE")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.IdDireccion)
                    .HasColumnName("Id_direccion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Klabc)
                    .HasColumnName("KLABC")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'C')");

                entity.Property(e => e.LCredito)
                    .HasColumnName("L_Credito")
                    .HasColumnType("money");

                entity.Property(e => e.Legal)
                    .HasColumnName("LEGAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnName("Limite_Cred_Ut")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.Municipio).HasMaxLength(2);

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoPasoJde)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasColumnName("No_Reg_Tribut")
                    .HasMaxLength(12);

                entity.Property(e => e.Nombre).HasMaxLength(80);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OficinaVenta)
                    .HasColumnName("Oficina_Venta")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("Orden_Compra")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasColumnName("Pagina_Web")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasColumnName("Repres_Legal")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasColumnName("RIESGO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RutCartero)
                    .HasColumnName("Rut_Cartero")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Saldo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Segmento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiDolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Smacc)
                    .HasColumnName("smacc")
                    .HasMaxLength(50);

                entity.Property(e => e.SubSegmentoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TImpuesto).HasColumnName("T_Impuesto");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoNegocio)
                    .HasColumnName("Tipo_Negocio")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasColumnName("USUARIO_MOD")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vendedor1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zzsn01)
                    .HasColumnName("ZZSN01")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn02)
                    .HasColumnName("ZZSN02")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn03)
                    .HasColumnName("ZZSN03")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn04)
                    .HasColumnName("ZZSN04")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn05)
                    .HasColumnName("ZZSN05")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn06)
                    .HasColumnName("ZZSN06")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<MtrCondicionPago>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AprobCredM)
                    .HasColumnName("APROB_CRED_M")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodJde)
                    .HasColumnName("COD_JDE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CondicionSap)
                    .IsRequired()
                    .HasColumnName("CondicionSAP")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiasVcto).HasColumnName("DIAS_VCTO");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("inactivo")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.PorcRequerido).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.RequiereLimiteCredito)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MtrContactos>(entity =>
            {
                entity.HasKey(e => e.IdContacto);

                entity.HasIndex(e => e.Email)
                    .HasName("IX_MtrContactos");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("IX_MtrContactos_1");

                entity.HasIndex(e => new { e.IdCliente, e.Rif })
                    .HasName("IX_MtrContactos_2");

                entity.Property(e => e.IdContacto).ValueGeneratedNever();

                entity.Property(e => e.AceptaEmail).HasDefaultValueSql("((0))");

                entity.Property(e => e.AceptaSms).HasDefaultValueSql("((0))");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Inactivo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prospecto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<MtrDirecciones>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_MtrDirecciones");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion1)
                    .HasColumnName("Direccion_1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion2)
                    .HasColumnName("Direccion_2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobacionDireccion).HasMaxLength(50);

                entity.Property(e => e.FechaUpdate).HasColumnType("smalldatetime");

                entity.Property(e => e.FuncionInterlocutor).HasMaxLength(2);

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nuevo)
                    .HasColumnName("NUEVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Origen).HasMaxLength(40);

                entity.Property(e => e.Ort02)
                    .HasColumnName("ORT02")
                    .HasMaxLength(35);

                entity.Property(e => e.PuntoReferencia).HasMaxLength(80);

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StmpAddr)
                    .HasColumnName("STMP_ADDR")
                    .HasMaxLength(240);

                entity.Property(e => e.Telf1)
                    .HasColumnName("TELF1")
                    .HasMaxLength(30);

                entity.Property(e => e.Telf2)
                    .HasColumnName("TELF2")
                    .HasMaxLength(30);

                entity.Property(e => e.UsuarioAprobacionDireccion).HasMaxLength(50);

                entity.Property(e => e.Zzsn01)
                    .HasColumnName("ZZSN01")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn02)
                    .HasColumnName("ZZSN02")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn03)
                    .HasColumnName("ZZSN03")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn04)
                    .HasColumnName("ZZSN04")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn05)
                    .HasColumnName("ZZSN05")
                    .HasMaxLength(50);

                entity.Property(e => e.Zzsn06)
                    .HasColumnName("ZZSN06")
                    .HasMaxLength(8);
            });


            modelBuilder.Entity<MtrEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.Property(e => e.IdEmpleado)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Categoria1)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Categoria2)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Categoria3)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cuenta)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Direccion1)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Direccion2)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.FechaRetiro).HasColumnType("datetime");

                entity.Property(e => e.IdCargo)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdDepartamento)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdGrupo)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdSupervisor)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreEmpleado)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rif)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SexoEmpleado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelefonoHabitacion)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoNomina)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MtrFechaFeriada>(entity =>
            {
                entity.HasKey(e => e.FechaFeriada);

                entity.Property(e => e.FechaFeriada)
                    .HasColumnName("FECHA_FERIADA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.MostrarBs)
                    .IsRequired()
                    .HasColumnName("MOSTRAR_BS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasColumnName("MOTIVO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MtrHorarioLaborable>(entity =>
            {
                entity.HasKey(e => e.IdHorario);

                entity.Property(e => e.Almuerzo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Fin)
                    .HasColumnName("fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.Laborable)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PrimerBloque)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<MtrOficina>(entity =>
            {
                entity.HasKey(e => e.CodOficina);

                entity.Property(e => e.CodOficina)
                    .HasColumnName("COD_OFICINA")
                    .ValueGeneratedNever();

                entity.Property(e => e.Abreviado).HasMaxLength(3);

                entity.Property(e => e.AdministradoraEmail)
                    .HasColumnName("Administradora_email")
                    .HasMaxLength(50);

                entity.Property(e => e.Analista2Email)
                    .HasColumnName("Analista2_email")
                    .HasMaxLength(50);

                entity.Property(e => e.AnalistaEmail)
                    .HasColumnName("Analista_email")
                    .HasMaxLength(50);

                entity.Property(e => e.Canal)
                    .HasColumnName("CANAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CarpetaDiseno)
                    .HasColumnName("CARPETA_DISENO")
                    .HasMaxLength(50);

                entity.Property(e => e.ClienteNacionales)
                    .HasColumnName("CLIENTE_NACIONALES")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodOficina2)
                    .IsRequired()
                    .HasColumnName("COD_OFICINA2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoJde)
                    .HasColumnName("CODIGO_JDE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoParroq).HasColumnName("CODIGO_PARROQ");

                entity.Property(e => e.DataManagerEmail)
                    .HasColumnName("DataManager_email")
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion2)
                    .IsRequired()
                    .HasColumnName("DIRECCION2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasColumnName("FAX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GerenteOficina)
                    .IsRequired()
                    .HasColumnName("GERENTE_OFICINA")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Idtitulo).HasColumnName("IDTITULO");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomOficina)
                    .IsRequired()
                    .HasColumnName("NOM_OFICINA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OficinaActiva)
                    .HasColumnName("OFICINA_ACTIVA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Override)
                    .HasColumnName("OVERRIDE")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PAusente)
                    .HasColumnName("P_AUSENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SinImpuesto)
                    .HasColumnName("SIN_IMPUESTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAdministradora).HasMaxLength(50);

                entity.Property(e => e.UsuarioAnalista).HasMaxLength(50);
            });

            modelBuilder.Entity<MtrPerfilCorreo>(entity =>
            {
                entity.HasKey(e => e.PerfilId);

                entity.Property(e => e.PerfilId).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Perfil).HasMaxLength(50);
            });

            modelBuilder.Entity<MtrProducto>(entity =>
            {
                entity.HasKey(e => e.CodigoProduct)
                    .HasName("MtrProducto_INDEX01");

                entity.HasIndex(e => e.Recnum)
                    .HasName("IX_MtrProducto");

                entity.Property(e => e.CodigoProduct)
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasMaxLength(12)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Almacensap)
                    .HasColumnName("ALMACENSAP")
                    .HasMaxLength(4);

                entity.Property(e => e.CantidadXAnch).HasColumnName("CANTIDAD_X_ANCH");

                entity.Property(e => e.CategoriaDashBoard)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodJde)
                    .HasColumnName("COD_JDE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodResponsable)
                    .HasColumnName("COD_RESPONSABLE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Codcorp)
                    .HasColumnName("CODCORP")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoCaja)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodprodRpg)
                    .HasColumnName("CODPROD_RPG")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Consecutivo)
                    .HasColumnName("consecutivo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CostoReposicion)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DescripVta)
                    .HasColumnName("DESCRIP_VTA")
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionVentas).HasMaxLength(1000);

                entity.Property(e => e.FamiliaProduct)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagCorp)
                    .HasColumnName("FLAG_CORP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagCortoTiraje).HasMaxLength(1);

                entity.Property(e => e.FlagDesact)
                    .HasColumnName("FLAG_DESACT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagPrdIntern)
                    .HasColumnName("FLAG_PRD_INTERN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagPrecioMinimo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagRollo)
                    .HasColumnName("FLAG_ROLLO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdUnidadCosteoSap)
                    .HasColumnName("IdUnidadCosteoSAP")
                    .HasMaxLength(18);

                entity.Property(e => e.Idsubcategoria)
                    .HasColumnName("IDSUBCATEGORIA")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.ImpPorConsumo)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProducto)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ManejaInv)
                    .HasColumnName("MANEJA_INV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Miscelaneo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.PesoKilos).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.PiesCuadradoUnidad).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PorcCosto).HasColumnName("PORC_COSTO");

                entity.Property(e => e.PorcMcAprob)
                    .HasColumnName("PORC_MC_APROB")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prefijo)
                    .HasColumnName("PREFIJO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrintNoPrint)
                    .HasColumnName("Print_NoPrint")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Sufijo)
                    .HasColumnName("SUFIJO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SujetoALote)
                    .HasColumnName("SUJETO_A_LOTE")
                    .HasMaxLength(1);

                entity.Property(e => e.TipoProducto).HasColumnName("TIPO_PRODUCTO");

                entity.Property(e => e.Titulo)
                    .HasColumnName("TITULO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo1)
                    .HasColumnName("TITULO1")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo2)
                    .HasColumnName("TITULO2")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo3)
                    .HasColumnName("TITULO3")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo4)
                    .HasColumnName("TITULO4")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo5)
                    .HasColumnName("TITULO5")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Titulo6)
                    .HasColumnName("TITULO6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TituloPe)
                    .HasColumnName("TITULO_PE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TituloVentas)
                    .HasColumnName("TITULO_VENTAS")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidadCosteo).HasColumnName("UNIDAD_COSTEO");

                entity.Property(e => e.Unidadsap)
                    .HasColumnName("UNIDADSAP")
                    .HasMaxLength(3);

                entity.Property(e => e.UnidadsapVenta)
                    .HasColumnName("UNIDADSAP_VENTA")
                    .HasMaxLength(3);

                entity.Property(e => e.UnidadsapVentainterna)
                    .HasColumnName("UNIDADSAP_VENTAINTERNA")
                    .HasMaxLength(3);

                entity.Property(e => e.Web)
                    .HasColumnName("WEB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdUnidadCosteoSapNavigation)
                    .WithMany(p => p.MtrProducto)
                    .HasForeignKey(d => d.IdUnidadCosteoSap)
                    .HasConstraintName("FK_MtrProducto_T006A");
            });

            modelBuilder.Entity<MtrProductoBasica>(entity =>
            {
                entity.HasKey(e => new { e.Producto, e.MedidaMascara })
                    .HasName("PK_MtrProductoBasica_1");

                entity.Property(e => e.Producto).HasMaxLength(20);

                entity.Property(e => e.MedidaMascara).HasMaxLength(6);

                entity.Property(e => e.Frecuencia).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MedidaFraccion)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MtrProductoOpuesta>(entity =>
            {
                entity.HasKey(e => new { e.Producto, e.MedidaMascara })
                    .HasName("PK_MtrProductoOpuesta_1");

                entity.Property(e => e.Producto).HasMaxLength(20);

                entity.Property(e => e.MedidaMascara).HasMaxLength(6);

                entity.Property(e => e.Frecuencia).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MedidaFraccion)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MtrProductoPapeles>(entity =>
            {
                entity.HasKey(e => new { e.Producto, e.Parte, e.Papel });

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.Papel).HasMaxLength(8);

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Frecuencia).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MtrTipoCuentaDestino>(entity =>
            {
                entity.HasKey(e => e.IdTipoCuentaDestino);

                entity.Property(e => e.IdTipoCuentaDestino).ValueGeneratedNever();

                entity.Property(e => e.NombreCuentaDestino)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<MtrTipoDocumentoFiscal>(entity =>
            {
                entity.HasKey(e => e.TipoDocumento);

                entity.Property(e => e.TipoDocumento).HasMaxLength(2);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MtrTipoMoneda>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<MtrTipoNomina>(entity =>
            {
                entity.HasKey(e => e.Tipnom)
                    .HasName("PK_NMT003");

                entity.Property(e => e.Tipnom)
                    .HasColumnName("TIPNOM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Anocom)
                    .HasColumnName("ANOCOM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Asifon)
                    .HasColumnName("ASIFON")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Canmin)
                    .HasColumnName("CANMIN")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CiaCodcia)
                    .HasColumnName("CIA_CODCIA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Clanom)
                    .HasColumnName("CLANOM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Codcon)
                    .HasColumnName("CODCON")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codpai)
                    .HasColumnName("CODPAI")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Dedfon)
                    .HasColumnName("DEDFON")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Desm01)
                    .HasColumnName("DESM01")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm02)
                    .HasColumnName("DESM02")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm03)
                    .HasColumnName("DESM03")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm04)
                    .HasColumnName("DESM04")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm05)
                    .HasColumnName("DESM05")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm06)
                    .HasColumnName("DESM06")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm07)
                    .HasColumnName("DESM07")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm08)
                    .HasColumnName("DESM08")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm09)
                    .HasColumnName("DESM09")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm10)
                    .HasColumnName("DESM10")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm11)
                    .HasColumnName("DESM11")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm12)
                    .HasColumnName("DESM12")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm13)
                    .HasColumnName("DESM13")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm14)
                    .HasColumnName("DESM14")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm15)
                    .HasColumnName("DESM15")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm16)
                    .HasColumnName("DESM16")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm17)
                    .HasColumnName("DESM17")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm18)
                    .HasColumnName("DESM18")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm19)
                    .HasColumnName("DESM19")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desm20)
                    .HasColumnName("DESM20")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Desnom)
                    .HasColumnName("DESNOM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Facgua)
                    .HasColumnName("FACGUA")
                    .HasColumnType("numeric(13, 10)");

                entity.Property(e => e.Fecabo)
                    .HasColumnName("FECABO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecact)
                    .HasColumnName("FECACT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Feccre)
                    .HasColumnName("FECCRE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecto1)
                    .HasColumnName("FECTO1")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecto2)
                    .HasColumnName("FECTO2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecto3)
                    .HasColumnName("FECTO3")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecto4)
                    .HasColumnName("FECTO4")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecto5)
                    .HasColumnName("FECTO5")
                    .HasColumnType("datetime");

                entity.Property(e => e.Frenom)
                    .HasColumnName("FRENOM")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Fresue)
                    .HasColumnName("FRESUE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Pgmrec)
                    .HasColumnName("PGMREC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reghab)
                    .HasColumnName("REGHAB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Salmin)
                    .HasColumnName("SALMIN")
                    .HasColumnType("numeric(12, 5)");

                entity.Property(e => e.Tasmon)
                    .HasColumnName("TASMON")
                    .HasColumnType("numeric(13, 10)");

                entity.Property(e => e.Tipfec)
                    .HasColumnName("TIPFEC")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Tipmon)
                    .HasColumnName("TIPMON")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Topgua)
                    .HasColumnName("TOPGUA")
                    .HasColumnType("numeric(12, 5)");

                entity.Property(e => e.Unim01)
                    .HasColumnName("UNIM01")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim02)
                    .HasColumnName("UNIM02")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim03)
                    .HasColumnName("UNIM03")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim04)
                    .HasColumnName("UNIM04")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim05)
                    .HasColumnName("UNIM05")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim06)
                    .HasColumnName("UNIM06")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim07)
                    .HasColumnName("UNIM07")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim08)
                    .HasColumnName("UNIM08")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim09)
                    .HasColumnName("UNIM09")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim10)
                    .HasColumnName("UNIM10")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim11)
                    .HasColumnName("UNIM11")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim12)
                    .HasColumnName("UNIM12")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim13)
                    .HasColumnName("UNIM13")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim14)
                    .HasColumnName("UNIM14")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim15)
                    .HasColumnName("UNIM15")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim16)
                    .HasColumnName("UNIM16")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim17)
                    .HasColumnName("UNIM17")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim18)
                    .HasColumnName("UNIM18")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim19)
                    .HasColumnName("UNIM19")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Unim20)
                    .HasColumnName("UNIM20")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Usract)
                    .HasColumnName("USRACT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Usrcre)
                    .HasColumnName("USRCRE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Valfon)
                    .HasColumnName("VALFON")
                    .HasColumnType("numeric(7, 2)");

                entity.Property(e => e.Valred)
                    .HasColumnName("VALRED")
                    .HasColumnType("numeric(7, 2)");
            });

            modelBuilder.Entity<MtrTipoOrden>(entity =>
            {
                entity.HasKey(e => e.IdTipoOrden);

                entity.Property(e => e.IdTipoOrden).ValueGeneratedNever();

                entity.Property(e => e.TipoOrden).HasMaxLength(100);
            });

            modelBuilder.Entity<MtrTipoTransaccionCuentaDestino>(entity =>
            {
                entity.HasKey(e => e.IdTransaccionCuentaDestino);

                entity.HasIndex(e => new { e.IdTipoTransaccion, e.IdTipoCuentaDestino })
                    .HasName("IX_MtrTipoTransaccionCuentaDestino")
                    .IsUnique();

                entity.Property(e => e.IdTransaccionCuentaDestino).ValueGeneratedNever();

                entity.Property(e => e.IdTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<MtrTipoValorRetencion>(entity =>
            {
                entity.HasKey(e => e.IdTipoValor);

                entity.Property(e => e.IdTipoValor).HasMaxLength(1);

                entity.Property(e => e.NombreTipoValor)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MtrUsuarioOficina>(entity =>
            {
                entity.HasKey(e => new { e.Usuario, e.Oficina });

                entity.HasIndex(e => e.Usuario)
                    .HasName("IX_MtrUsuarioOficina");

                entity.Property(e => e.Usuario).HasMaxLength(40);
            });

            modelBuilder.Entity<MtrVendedor>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.HasIndex(e => e.Supervisor)
                    .HasName("IX_MtrVendedor");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasColumnName("ACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.An8).HasColumnName("AN8");

                entity.Property(e => e.Asignacion)
                    .IsRequired()
                    .HasColumnName("ASIGNACION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("CATEGORIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ClaseVendedor).HasColumnName("CLASE_VENDEDOR");

                entity.Property(e => e.Club300Asistid).HasColumnName("CLUB300_ASISTID");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodDivision).HasColumnName("COD_DIVISION");

                entity.Property(e => e.CodigoGrupo)
                    .IsRequired()
                    .HasColumnName("CODIGO_GRUPO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoOverride).HasColumnName("CODIGO_OVERRIDE");

                entity.Property(e => e.CodigoRegion)
                    .IsRequired()
                    .HasColumnName("CODIGO_REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ComisionComprd)
                    .HasColumnName("COMISION_COMPRD")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ComisionFactur)
                    .IsRequired()
                    .HasColumnName("COMISION_FACTUR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ComisionImpres)
                    .HasColumnName("COMISION_IMPRES")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ComisionOrden)
                    .IsRequired()
                    .HasColumnName("COMISION_ORDEN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ComisionServ)
                    .HasColumnName("COMISION_SERV")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ComisionStock)
                    .HasColumnName("COMISION_STOCK")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.CompanyBeeper).HasColumnName("COMPANY_BEEPER");

                entity.Property(e => e.Consecutivo).HasColumnName("CONSECUTIVO");

                entity.Property(e => e.CotCorrelativo).HasColumnName("COT_CORRELATIVO");

                entity.Property(e => e.CotizadorPlus).HasMaxLength(1);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ExtTelefonica).HasColumnName("EXT_TELEFONICA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRetiro)
                    .HasColumnName("FECHA_RETIRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ficha)
                    .IsRequired()
                    .HasColumnName("FICHA")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagAdmin)
                    .HasColumnName("FLAG_ADMIN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.FlagCalculo)
                    .HasColumnName("FLAG_CALCULO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.FlagCambio)
                    .IsRequired()
                    .HasColumnName("FLAG_CAMBIO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagDeGerente)
                    .IsRequired()
                    .HasColumnName("FLAG_DE_GERENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagForaneo)
                    .HasColumnName("FLAG_FORANEO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagGerenteOf)
                    .IsRequired()
                    .HasColumnName("FLAG_GERENTE_OF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagIc)
                    .HasColumnName("FLAG_IC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagReplicar)
                    .IsRequired()
                    .HasColumnName("FLAG_REPLICAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetirado)
                    .IsRequired()
                    .HasColumnName("FLAG_RETIRADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRevisar)
                    .HasColumnName("FLAG_REVISAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagSupervisor)
                    .IsRequired()
                    .HasColumnName("FLAG_SUPERVISOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FreeLance)
                    .IsRequired()
                    .HasColumnName("FREE_LANCE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Garantia)
                    .IsRequired()
                    .HasColumnName("GARANTIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GerenteOficina)
                    .IsRequired()
                    .HasColumnName("GERENTE_OFICINA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GerenteRegion)
                    .IsRequired()
                    .HasColumnName("GERENTE_REGION")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.Property(e => e.GrupoVendedoresSap)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdOficinaFisica).HasMaxLength(2);

                entity.Property(e => e.IdOficinaMixProduct)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombAbreviado)
                    .IsRequired()
                    .HasColumnName("NOMB_ABREVIADO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroDeClientes).HasColumnName("NRO_DE_CLIENTES");

                entity.Property(e => e.NroVendedor).HasColumnName("NRO_VENDEDOR");

                entity.Property(e => e.OfiRefer)
                    .HasColumnName("OFI_REFER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oficina).HasColumnName("OFICINA");

                entity.Property(e => e.OrdenRep).HasColumnName("ORDEN_REP");

                entity.Property(e => e.Ordenado).HasColumnName("ORDENADO");

                entity.Property(e => e.Override)
                    .HasColumnName("OVERRIDE")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("@PASSWORD")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pedido).HasColumnName("PEDIDO");

                entity.Property(e => e.Posicion).HasColumnName("POSICION");

                entity.Property(e => e.ProduccionInterna)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PuntosDelClub).HasColumnName("PUNTOS_DEL_CLUB");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TlfCelular)
                    .IsRequired()
                    .HasColumnName("TLF_CELULAR")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TlfCelularold)
                    .HasColumnName("TLF_CELULAROld")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadBeeper)
                    .IsRequired()
                    .HasColumnName("UNIDAD_BEEPER")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.HasOne(d => d.OficinaNavigation)
                    .WithMany(p => p.MtrVendedor)
                    .HasForeignKey(d => d.Oficina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MtrVendedor_MtrOficina");
            });

            modelBuilder.Entity<OfdAdjunto>(entity =>
            {
                entity.HasKey(e => e.IdAdjunto)
                    .HasName("PK_MtrAdjunto");

                entity.HasIndex(e => e.IdAdjuntoCotizadorPluss)
                    .HasName("IX_OfdAdjunto");

                entity.Property(e => e.Archivo).IsRequired();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.IdAdjuntoCotizadorPluss).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OfdAdjuntoCriterio>(entity =>
            {
                entity.HasKey(e => e.IdAdjuntoCriterio);

                entity.HasIndex(e => e.IdAdjunto)
                    .HasName("IX_OfdAdjuntoCriterio");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdAdjuntoNavigation)
                    .WithMany(p => p.OfdAdjuntoCriterio)
                    .HasForeignKey(d => d.IdAdjunto)
                    .HasConstraintName("FK_OfdAdjuntoCriterio_OfdAdjunto");

                entity.HasOne(d => d.IdCriterioBusquedaNavigation)
                    .WithMany(p => p.OfdAdjuntoCriterio)
                    .HasForeignKey(d => d.IdCriterioBusqueda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdAdjuntoCriterio_OfdCriterioBusqueda");
            });

            modelBuilder.Entity<OfdAdjuntosDiseno>(entity =>
            {
                entity.HasKey(e => e.IdAdjunto);

                entity.HasIndex(e => new { e.IdAdjunto, e.IdTipoDocumento })
                    .HasName("IX_OfdAdjuntosDiseno");

                entity.Property(e => e.Archivo).IsRequired();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.OfdAdjuntosDiseno)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdAdjuntosDiseno_OfdSolicitudDiseno");
            });

            modelBuilder.Entity<OfdAprobacionDiseno>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.Property(e => e.IdSolicitud).ValueGeneratedNever();

                entity.Property(e => e.Cargo)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cedula).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCliente).HasMaxLength(500);

                entity.Property(e => e.FechaAgrega)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdTicket).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObsCliente)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObsConsultor)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuarioAgrega)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithOne(p => p.OfdAprobacionDiseno)
                    .HasForeignKey<OfdAprobacionDiseno>(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdAprobacionDiseno_OfdSolicitudDiseno");
            });

            modelBuilder.Entity<OfdCambioDiseno>(entity =>
            {
                entity.HasKey(e => e.IdCambio);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdTipoCambio)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.NombreCambio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdTipoCambioNavigation)
                    .WithMany(p => p.OfdCambioDiseno)
                    .HasForeignKey(d => d.IdTipoCambio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdCambioDiseno_OfdTipoCambioDiseno");
            });

            modelBuilder.Entity<OfdConstruccionCotizacion>(entity =>
            {
                entity.HasKey(e => new { e.Cotizacion, e.Renglon, e.Propuesta, e.IdVariable, e.IdParte, e.Valor })
                    .HasName("PK_WPRY251");

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.IdVariable).HasMaxLength(20);

                entity.Property(e => e.Valor)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<OfdCotizacion>(entity =>
            {
                entity.HasKey(e => e.IdCotizacion)
                    .HasName("PK_OfdCotizacion_1");

                entity.HasIndex(e => e.Cotizacion)
                    .HasName("IX_OfdCotizacion")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdVendedor, e.IdCliente, e.IdCotizacion })
                    .HasName("IX_OfdCotizacionVendedorClienteCotizacion");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaActualiza)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaCaducidad).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaPostergada).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdDireccionEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDireccionFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdProspecto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdVendedor)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.ObservacionPostergar)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObsvCotizacion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuarioActualiza)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdContactoNavigation)
                    .WithMany(p => p.OfdCotizacion)
                    .HasForeignKey(d => d.IdContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdCotizacion_MtrContactos");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.OfdCotizacion)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdCotizacion_MtrVendedor");
            });

            modelBuilder.Entity<OfdCriterioBusqueda>(entity =>
            {
                entity.HasKey(e => e.IdCriterioBusqueda);

                entity.Property(e => e.CampoBusqueda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<OfdDetalleSolicitudDiseno>(entity =>
            {
                entity.HasKey(e => e.IdDetalleSolicitud);

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_OfdDetalleSolicitudDiseno");

                entity.HasIndex(e => new { e.IdSolicitud, e.NumeroAnotacion })
                    .HasName("IX_OfdDetalleSolicitudDiseno_2")
                    .IsUnique();

                entity.Property(e => e.Anotacion)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.NombreImagen).HasMaxLength(500);

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.OfdDetalleSolicitudDiseno)
                    .HasForeignKey(d => d.IdSolicitud)
                    .HasConstraintName("FK_OfdDetalleSolicitudDiseno_OfdSolicitudDiseno");
            });

            modelBuilder.Entity<OfdEspecificacionCotizacion>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud)
                    .HasName("PK_WPRY229");

                entity.HasComment("Datos generales de las solicitudes");

                entity.HasIndex(e => e.Orden)
                    .HasName("IX_WPRY229_1");

                entity.HasIndex(e => new { e.Cotizacion, e.Renglon, e.Propuesta })
                    .HasName("IX_WPRY229")
                    .IsUnique();

                entity.Property(e => e.IdSolicitud).ValueGeneratedNever();

                entity.Property(e => e.CantidadProducto).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.DescripcionSolicitud)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitud)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlagFiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Instrucciones)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LongitudMascara).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumDesde)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumHasta)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroControlDesde).HasMaxLength(8);

                entity.Property(e => e.NumeroControlHasta).HasMaxLength(8);

                entity.Property(e => e.NumeroFormatoDesde).HasMaxLength(8);

                entity.Property(e => e.NumeroFormatoHasta).HasMaxLength(8);

                entity.Property(e => e.NumeroSdf)
                    .HasColumnName("NumeroSDF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumeroSerieControlDesde)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumeroSerieControlHasta)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumeroSerieFormatoDesde).HasMaxLength(10);

                entity.Property(e => e.NumeroSerieFormatoHasta).HasMaxLength(10);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.OrdenAnterior).HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoDocumento).HasMaxLength(2);

                entity.Property(e => e.ValorLista).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValorVenta).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<OfdEstatusFlujo>(entity =>
            {
                entity.HasKey(e => e.IdEstatus);

                entity.Property(e => e.IdEstatus).HasMaxLength(10);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FlagAprobado)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.FlagEnviado)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.FlagPendiente)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.FlagRechazado)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.NombreEstatus)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<OfdFlujoEstacion>(entity =>
            {
                entity.HasKey(e => e.IdFlujoEstacion);

                entity.HasIndex(e => e.IdEstacionActual)
                    .HasName("IX_OfdFlujoEstacion")
                    .IsUnique();

                entity.Property(e => e.IdFlujoEstacion).ValueGeneratedNever();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdEstacionActualNavigation)
                    .WithOne(p => p.OfdFlujoEstacion)
                    .HasForeignKey<OfdFlujoEstacion>(d => d.IdEstacionActual)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdFlujoEstacion_OfdMaestroEstacion");
            });

            modelBuilder.Entity<OfdGrupoCriterio>(entity =>
            {
                entity.HasKey(e => e.IdGrupoCriterio);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioModificacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdCriterioBusquedaNavigation)
                    .WithMany(p => p.OfdGrupoCriterio)
                    .HasForeignKey(d => d.IdCriterioBusqueda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdGrupoCriterio_OfdCriterioBusqueda");

                entity.HasOne(d => d.IdGrupoTipoDocumentoNavigation)
                    .WithMany(p => p.OfdGrupoCriterio)
                    .HasForeignKey(d => d.IdGrupoTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdGrupoCriterio_OdfGrupoTipoDocumento");
            });

            modelBuilder.Entity<OfdGrupoTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdGrupoTipoDocumento)
                    .HasName("PK_OdfGrupoTipoDocumento");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioModificacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.NombreGrupo)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OfdMaestroEstacion>(entity =>
            {
                entity.HasKey(e => e.IdEstacion)
                    .HasName("PK_OfdEstacionesSED");

                entity.HasIndex(e => e.AbreviadoEstacion)
                    .HasName("IX_OfdEstacionesDiseno")
                    .IsUnique();

                entity.Property(e => e.IdEstacion).ValueGeneratedNever();

                entity.Property(e => e.AbreviadoEstacion)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreEstacion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdFlujoNavigation)
                    .WithMany(p => p.OfdMaestroEstacion)
                    .HasForeignKey(d => d.IdFlujo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdMaestroEstacion_OfdMaestroFlujo");
            });

            modelBuilder.Entity<OfdMaestroFlujo>(entity =>
            {
                entity.HasKey(e => e.IdFlujo)
                    .HasName("PK_OfdMaestroFlujos");

                entity.Property(e => e.IdFlujo).ValueGeneratedNever();

                entity.Property(e => e.NombreFlujo)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OfdMaestroPieImprenta>(entity =>
            {
                entity.HasKey(e => e.IdPieImprenta);

                entity.Property(e => e.IdPieImprenta).HasMaxLength(50);

                entity.Property(e => e.DescripcionPie)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OfdMaestroTipoRespaldo>(entity =>
            {
                entity.HasKey(e => e.IdTipoRespaldo)
                    .HasName("PK_OfdMaestroTipoMarginal");

                entity.Property(e => e.IdTipoRespaldo).ValueGeneratedNever();

                entity.Property(e => e.TipoRespaldo)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OfdMaestroUbicacionMarginal>(entity =>
            {
                entity.HasKey(e => e.IdUbicacionMarginal);

                entity.Property(e => e.IdUbicacionMarginal).ValueGeneratedNever();

                entity.Property(e => e.UbicacionMarginal)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OfdMaestroVoBo>(entity =>
            {
                entity.HasKey(e => e.IdVoBo);

                entity.HasIndex(e => e.IdEstacion)
                    .HasName("IX_OfdMaestroVoBo_1");

                entity.HasIndex(e => new { e.IdEstacion, e.Orden })
                    .HasName("IX_OfdMaestroVoBo")
                    .IsUnique();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Instruccion)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<OfdObservacionAdjunto>(entity =>
            {
                entity.HasKey(e => e.IdObservacionAdjunto)
                    .HasName("PK_PrcObservacionAdjunto");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Observaciones).IsRequired();
            });

            modelBuilder.Entity<OfdPartesCotizacion>(entity =>
            {
                entity.HasKey(e => new { e.Cotizacion, e.Renglon, e.Propuesta, e.IdParte })
                    .HasName("PK_OfdPartesCotizacion_1");

                entity.HasIndex(e => e.Recnum)
                    .HasName("IX_OfdPartesCotizacion");

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.AnchoCm).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FrasesMarginales)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdPapel)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LargoCm).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MedidaBase)
                    .HasColumnName("Medida_Base")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MedidaOpuesta)
                    .HasColumnName("Medida_Opuesta")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<OfdPlantillaPreset>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Basica)
                    .HasColumnName("BASICA")
                    .HasMaxLength(50);

                entity.Property(e => e.Cambioscomposicion)
                    .HasColumnName("CAMBIOSCOMPOSICION")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cantfranjastransfertape)
                    .HasColumnName("CANTFRANJASTRANSFERTAPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cantitintas)
                    .HasColumnName("CANTITINTAS")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Carbon)
                    .HasColumnName("CARBON")
                    .HasMaxLength(50);

                entity.Property(e => e.CodProducto)
                    .HasColumnName("COD_PRODUCTO")
                    .HasMaxLength(12);

                entity.Property(e => e.Grupopapel)
                    .HasColumnName("GRUPOPAPEL")
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Medidaopuestacarbon)
                    .HasColumnName("MEDIDAOPUESTACARBON")
                    .HasMaxLength(50);

                entity.Property(e => e.Millares).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Nombreproducto)
                    .HasColumnName("NOMBREPRODUCTO")
                    .HasMaxLength(50);

                entity.Property(e => e.Opuesta)
                    .HasColumnName("OPUESTA")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasMaxLength(50);

                entity.Property(e => e.Ordenreferencia)
                    .HasColumnName("ORDENReferencia")
                    .HasMaxLength(50);

                entity.Property(e => e.Papel)
                    .HasColumnName("PAPEL")
                    .HasMaxLength(100);

                entity.Property(e => e.Partes)
                    .HasColumnName("PARTES")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrecioMaximoMillar).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Talonextra)
                    .HasColumnName("TALONEXTRA")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienecarbonspot)
                    .HasColumnName("TIENECARBONSPOT")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OfdPropuesta>(entity =>
            {
                entity.HasKey(e => e.IdPropuesta);

                entity.HasIndex(e => new { e.Cotizacion, e.Renglon, e.Propuesta })
                    .HasName("IX_OfdPropuesta")
                    .IsUnique();

                entity.Property(e => e.Cajas).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CantFormas)
                    .HasColumnName("Cant_Formas")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CantXCaja)
                    .HasColumnName("Cant_x_Caja")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(16, 3)");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.CotizacionRenglonPropuesta)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EstatusPlanta)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.FactorSdf).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdPresentacion)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IdSolicitud)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObsrPropuesta)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PorMcBruto).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.PorMcFinan).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PorcComRegulada).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.PorcComision).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.PorcIva).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PorcMcMinimo).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.PorcRespSocial).HasColumnType("numeric(5, 3)");

                entity.Property(e => e.PorcTolerancia).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RecalcularMargen)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdRenglonNavigation)
                    .WithMany(p => p.OfdPropuesta)
                    .HasForeignKey(d => d.IdRenglon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdPropuesta_OfdRenglon");
            });

            modelBuilder.Entity<OfdPropuestaResp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cajas).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CantFormas)
                    .HasColumnName("Cant_Formas")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CantXCaja)
                    .HasColumnName("Cant_x_Caja")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(16, 3)");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.CotizacionRenglonPropuesta)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EstatusPlanta)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.FactorSdf).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdPresentacion)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IdSolicitud)
                    .IsRequired()
                    .HasMaxLength(9);

                entity.Property(e => e.ObsrPropuesta)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PorMcBruto).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.PorMcFinan).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PorcComRegulada).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.PorcComision).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.PorcIva).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PorcMcMinimo).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.PorcRespSocial).HasColumnType("numeric(5, 3)");

                entity.Property(e => e.PorcTolerancia).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.Precio).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.RecalcularMargen)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Total).HasColumnType("decimal(16, 4)");
            });

            modelBuilder.Entity<OfdRenglon>(entity =>
            {
                entity.HasKey(e => e.IdRenglon);

                entity.HasIndex(e => e.IdCotizacion)
                    .HasName("IX_OfdRenglon_1");

                entity.HasIndex(e => new { e.Cotizacion, e.Renglon })
                    .HasName("IX_OfdRenglon")
                    .IsUnique();

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.EstatusPlanta)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaReorden).HasColumnType("datetime");

                entity.Property(e => e.IdProducto)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.NombreComercialProducto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ObsrGanarPerder)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObsvRenglon)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RazonGanadaPerdida).HasDefaultValueSql("('')");

                entity.Property(e => e.TotalGanado).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TotalRenglon).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdCotizacionNavigation)
                    .WithMany(p => p.OfdRenglon)
                    .HasForeignKey(d => d.IdCotizacion)
                    .HasConstraintName("FK_OfdRenglon_OfdCotizacion");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.OfdRenglon)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdRenglon_MtrProducto");
            });

            modelBuilder.Entity<OfdRolTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdRolTipoDocumento);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.OfdRolTipoDocumento)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdRolTipoDocumento_SegRol");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.OfdRolTipoDocumento)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdRolTipoDocumento_OfdTipoDocumento");
            });

            modelBuilder.Entity<OfdSeguimiento>(entity =>
            {
                entity.HasKey(e => e.IdSeguimiento);

                entity.HasIndex(e => e.FechaEntrada)
                    .HasName("IX_OfdSeguimiento_4");

                entity.HasIndex(e => e.FechaSalida)
                    .HasName("IX_OfdSeguimiento_2");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_OfdSeguimiento");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FechaEntrada).HasColumnType("datetime");

                entity.Property(e => e.FechaSalida).HasColumnType("datetime");

                entity.Property(e => e.IdEstatus)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdEstacionNavigation)
                    .WithMany(p => p.OfdSeguimiento)
                    .HasForeignKey(d => d.IdEstacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSeguimiento_OfdMaestroEstacion");

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.OfdSeguimiento)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSeguimiento_OfdSolicitudDiseno");
            });

            modelBuilder.Entity<OfdSolicitudDiseno>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.HasIndex(e => e.IdPropuesta)
                    .HasName("IX_OfdSolicitudDiseno");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdPieImprenta)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdTipoCambio)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('ND')");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ObsvSolicitud)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.UsuarioActivo)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdPieImprentaNavigation)
                    .WithMany(p => p.OfdSolicitudDiseno)
                    .HasForeignKey(d => d.IdPieImprenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSolicitudDiseno_OfdMaestroPieImprenta");

                entity.HasOne(d => d.IdPropuestaNavigation)
                    .WithMany(p => p.OfdSolicitudDiseno)
                    .HasForeignKey(d => d.IdPropuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSolicitudDiseno_OfdPropuesta");

                entity.HasOne(d => d.IdTipoCambioNavigation)
                    .WithMany(p => p.OfdSolicitudDiseno)
                    .HasForeignKey(d => d.IdTipoCambio)
                    .HasConstraintName("FK_OfdSolicitudDiseno_OfdTipoCambioDiseno");

                entity.HasOne(d => d.IdTipoRespaldoNavigation)
                    .WithMany(p => p.OfdSolicitudDiseno)
                    .HasForeignKey(d => d.IdTipoRespaldo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSolicitudDiseno_OfdMaestroTipoRespaldo");

                entity.HasOne(d => d.UbicacionMarginalNavigation)
                    .WithMany(p => p.OfdSolicitudDiseno)
                    .HasForeignKey(d => d.UbicacionMarginal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSolicitudDiseno_OfdMaestroUbicacionMarginal");
            });

            modelBuilder.Entity<OfdSolicitudDisenoCambios>(entity =>
            {
                entity.HasKey(e => e.IdSolDisCam);

                entity.HasIndex(e => new { e.IdSolicitud, e.IdCambio })
                    .HasName("IX_OfdSolicitudDisenoCambios")
                    .IsUnique();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdCambioNavigation)
                    .WithMany(p => p.OfdSolicitudDisenoCambios)
                    .HasForeignKey(d => d.IdCambio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSolicitudDisenoCambios_OfdCambioDiseno");

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.OfdSolicitudDisenoCambios)
                    .HasForeignKey(d => d.IdSolicitud)
                    .HasConstraintName("FK_OfdSolicitudDisenoCambios_OfdSolicitudDiseno");
            });

            modelBuilder.Entity<OfdSolicitudDocFiscal>(entity =>
            {
                entity.HasKey(e => e.IdSdf);

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EmailCliente)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FechaAgrega)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdEstatus)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IdTicket)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObsvCliente)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObsvConsultor)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuarioAgrega)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.OfdSolicitudDocFiscal)
                    .HasForeignKey(d => d.IdEstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSolicitudDocFiscal_OfdEstatusFlujo");

                entity.HasOne(d => d.IdNumeracionNavigation)
                    .WithMany(p => p.OfdSolicitudDocFiscal)
                    .HasForeignKey(d => d.IdNumeracion)
                    .HasConstraintName("FK_OfdSolicitudDocFiscal_PrcNumeracionFiscal");
            });

            modelBuilder.Entity<OfdTintasCotizacion>(entity =>
            {
                entity.HasKey(e => new { e.Cotizacion, e.Renglon, e.Propuesta, e.IdParte, e.IdUbicacion, e.IdTinta });

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.IdTinta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OfdTipoCambioDiseno>(entity =>
            {
                entity.HasKey(e => e.IdTipoCambio);

                entity.HasIndex(e => e.IdPonderacion)
                    .HasName("IX_OfdTipoCambioDiseno")
                    .IsUnique();

                entity.Property(e => e.IdTipoCambio).HasMaxLength(4);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreTipoCambio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<OfdTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento)
                    .HasName("PK_TipoDocumento");

                entity.Property(e => e.IdTipoDocumento).ValueGeneratedNever();

                entity.Property(e => e.AfectaExpediente)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.IdUsuarioModificacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.NombreDocumento)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Obligatorio)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdGrupoTipoDocumentoNavigation)
                    .WithMany(p => p.OfdTipoDocumento)
                    .HasForeignKey(d => d.IdGrupoTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdTipoDocumento_OdfGrupoTipoDocumento");
            });

            modelBuilder.Entity<OfdVariablesEspecificacion>(entity =>
            {
                entity.HasKey(e => e.IdVariable)
                    .HasName("PK_WPRY248");

                entity.Property(e => e.IdVariable)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlagGralParte)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagInactiva)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagMultipleValor)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagObligatorio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdVariableMc)
                    .IsRequired()
                    .HasColumnName("IdVariableMC")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreVariable)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OfdVoBoDiseno>(entity =>
            {
                entity.HasKey(e => e.IdVoBoSolicitud);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.OfdVoBoDiseno)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdVoBoDiseno_OfdSolicitudDiseno");

                entity.HasOne(d => d.IdVoBoNavigation)
                    .WithMany(p => p.OfdVoBoDiseno)
                    .HasForeignKey(d => d.IdVoBo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdVoBoDiseno_OfdMaestroVoBo");
            });

            modelBuilder.Entity<Personas>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Primernombre)
                    .IsRequired()
                    .HasColumnName("PRIMERNOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Segundonombre)
                    .IsRequired()
                    .HasColumnName("SEGUNDONOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrcNumeracionFiscal>(entity =>
            {
                entity.HasKey(e => e.IdNumeracion);

                entity.HasIndex(e => e.IdPropuesta)
                    .HasName("IX_PrcNumeracionFiscal");

                entity.HasIndex(e => new { e.Rif, e.NumeroSerieControlDesde, e.NumeroControlDesde })
                    .HasName("IX_SerieControl");

                entity.Property(e => e.FechaAgrega)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LongitudMascaraFormato).HasDefaultValueSql("((0))");

                entity.Property(e => e.NumeroControlDesde)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.NumeroControlHasta)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.NumeroFormatoDesde)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroFormatoHasta)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroSerieControlDesde)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumeroSerieControlHasta)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumeroSerieFormatoDesde)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroSerieFormatoHasta).HasMaxLength(10);

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.UsuarioAgrega)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdPropuestaNavigation)
                    .WithMany(p => p.PrcNumeracionFiscal)
                    .HasForeignKey(d => d.IdPropuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrcNumeracionFiscal_OfdPropuesta");

                entity.HasOne(d => d.TipoDocumentoNavigation)
                    .WithMany(p => p.PrcNumeracionFiscal)
                    .HasForeignKey(d => d.TipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrcNumeracionFiscal_MtrTipoDocumentoFiscal");
            });

            modelBuilder.Entity<PrcObjetosProcesos>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BaseDatos)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ColaDeTrabajo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Objeto)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Servidor)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<PrcOrdenIdPropuesta>(entity =>
            {
                entity.HasIndex(e => e.IdPropuesta)
                    .HasName("IX_PrcOrdenIdPropuesta");

                entity.HasIndex(e => e.Orden)
                    .HasName("IX_PrcOrdenIdPropuesta_1");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PrcPlantillaNumeraciones>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Mascara)
                    .HasName("IX_PrcNumeraciones");

                entity.Property(e => e.Hasta).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MaximoNumero).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrefijoChar).HasMaxLength(2);
            });

            modelBuilder.Entity<PrcUsuarioProcesos>(entity =>
            {
                entity.HasIndex(e => new { e.IdProceso, e.Usuario })
                    .HasName("IX_PrcUsuarioProcesos")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdProceso).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdProcesoNavigation)
                    .WithMany(p => p.PrcUsuarioProcesos)
                    .HasForeignKey(d => d.IdProceso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrcUsuarioProcesos_PrcObjetosProcesos");
            });

            modelBuilder.Entity<ReqAreaRequerimiento>(entity =>
            {
                entity.HasKey(e => e.IdAreaRequerimiento);

                entity.Property(e => e.IdAreaRequerimiento).ValueGeneratedNever();

                entity.Property(e => e.DescripcionAreaRequerimiento)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.FechaCambio).HasColumnType("smalldatetime");

                entity.Property(e => e.UsuarioCambio).HasMaxLength(30);

                entity.HasOne(d => d.IdOrigenRequerimientoNavigation)
                    .WithMany(p => p.ReqAreaRequerimiento)
                    .HasForeignKey(d => d.IdOrigenRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqAreaRequerimiento_ReqOrigenRequerimiento");
            });

            modelBuilder.Entity<ReqCompañia>(entity =>
            {
                entity.HasKey(e => e.IdCompañia);

                entity.HasComment("Lista de Compañias");

                entity.Property(e => e.IdCompañia).HasMaxLength(10);

                entity.Property(e => e.FechaCambio).HasColumnType("smalldatetime");

                entity.Property(e => e.NombreCompañia)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.UsuarioCambio).HasMaxLength(30);
            });

            modelBuilder.Entity<ReqOrigenRequerimiento>(entity =>
            {
                entity.HasKey(e => e.IdOrigenRequerimiento);

                entity.HasComment("Origenes de Requerimientos de Servicios");

                entity.Property(e => e.IdOrigenRequerimiento).ValueGeneratedNever();

                entity.Property(e => e.DescripcionOrigenRequerimiento)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaCambio).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCompañia).HasMaxLength(10);

                entity.Property(e => e.UsuarioCambio).HasMaxLength(30);

                entity.HasOne(d => d.IdCompañiaNavigation)
                    .WithMany(p => p.ReqOrigenRequerimiento)
                    .HasForeignKey(d => d.IdCompañia)
                    .HasConstraintName("FK_ReqOrigenRequerimiento_ReqCompañia");
            });

            modelBuilder.Entity<ReqTarea>(entity =>
            {
                entity.HasKey(e => e.IdTarea);

                entity.Property(e => e.IdTarea).ValueGeneratedNever();

                entity.Property(e => e.DescripcionTarea)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FechaCambio).HasColumnType("smalldatetime");

                entity.Property(e => e.UsuarioCambio).HasMaxLength(30);

                entity.HasOne(d => d.IdTipoTareaNavigation)
                    .WithMany(p => p.ReqTarea)
                    .HasForeignKey(d => d.IdTipoTarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqTarea_ReqTipoTarea");
            });

            modelBuilder.Entity<ReqTipoTarea>(entity =>
            {
                entity.HasKey(e => e.IdTipoTarea)
                    .HasName("PK_ReqTipoRequerimiento");

                entity.Property(e => e.IdTipoTarea).ValueGeneratedNever();

                entity.Property(e => e.DescripcionTipoTarea)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.FechaCambio).HasColumnType("smalldatetime");

                entity.Property(e => e.UsuarioCambio)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.IdAreaRequerimientoNavigation)
                    .WithMany(p => p.ReqTipoTarea)
                    .HasForeignKey(d => d.IdAreaRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqTipoRequerimiento_ReqAreaRequerimiento");
            });

            modelBuilder.Entity<ReqVariables>(entity =>
            {
                entity.HasKey(e => e.IdVariable);

                entity.HasComment("Variables para Plantillas por Tarea");

                entity.Property(e => e.IdVariable).ValueGeneratedNever();

                entity.Property(e => e.FechaCambio).HasColumnType("smalldatetime");

                entity.Property(e => e.FuncionValidacion).HasMaxLength(1500);

                entity.Property(e => e.NombreVariable)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TipoDato)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UsuarioCambio)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<RrdejecutarSql>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RRDEjecutarSql");

                entity.Property(e => e.Ejecutar).HasMaxLength(1);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Proceso).HasMaxLength(50);
            });

            modelBuilder.Entity<SapFrecuenciaVisitaCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.FechaActualiza)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioActualiza)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<SapRetenciones>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Denominacion).HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IndicadordeRetencion).HasMaxLength(255);

                entity.Property(e => e.TipodeRetencion).HasMaxLength(255);
            });

            modelBuilder.Entity<SegModulo>(entity =>
            {
                entity.HasKey(e => e.IdModulo);

                entity.Property(e => e.IdModulo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.FlagPortafolioReportes)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Icono)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IconoMenu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdTipoReporte).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkModulo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreModulo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreReporte)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RutaReporte)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ServidorReporte).HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoLlamada)
                    .HasColumnName("TipoLLamada")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SegPrograma>(entity =>
            {
                entity.HasKey(e => e.IdPrograma);

                entity.Property(e => e.IdPrograma).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.FlagRequerimiento).HasMaxLength(1);

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(200);

                entity.Property(e => e.NombrePrograma)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPrograma)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SegRol>(entity =>
            {
                entity.HasKey(e => e.IdRol);

                entity.Property(e => e.IdRol).ValueGeneratedNever();

                entity.Property(e => e.AbreviadoRol)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DescripcionRol).IsRequired();

                entity.Property(e => e.NombreRol)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SegRolEstacion>(entity =>
            {
                entity.HasKey(e => e.IdRolEstacion);

                entity.HasIndex(e => e.IdRol)
                    .HasName("IX_SegRolEstacion_1");

                entity.HasIndex(e => new { e.IdEstacion, e.IdRol })
                    .HasName("IX_SegRolEstacion")
                    .IsUnique();
            });

            modelBuilder.Entity<SegRolModulo>(entity =>
            {
                entity.HasKey(e => e.IdRolModulo);

                entity.HasIndex(e => new { e.IdRol, e.IdModulo })
                    .HasName("IX_SegRolModulo")
                    .IsUnique();

                entity.Property(e => e.IdRolModulo).ValueGeneratedNever();
            });

            modelBuilder.Entity<SegTicket>(entity =>
            {
                entity.HasKey(e => e.TicketSha1);

                entity.Property(e => e.TicketSha1).HasMaxLength(100);

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaHoraGetIp).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraUso).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.IpUsuario)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SegUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK_Usuario");

                entity.HasIndex(e => e.Email)
                    .HasName("IX_Email");

                entity.HasIndex(e => e.Usuario)
                    .HasName("IX_SegUsuario_1")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).ValueGeneratedNever();

                entity.Property(e => e.ClasificacionUsuario)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EquipoImei1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EquipoImei2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EquipoImei3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.Ficha)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FlagDisenador)
                    .HasColumnName("Flag_Disenador")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Imei1)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Imei2)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Imei3)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SegUsuarioRol>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioRol);

                entity.HasIndex(e => new { e.IdUsuario, e.IdRol })
                    .HasName("IX_SegUsuarioRol")
                    .IsUnique();

                entity.Property(e => e.IdUsuarioRol).ValueGeneratedNever();

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.SegUsuarioRol)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegUsuarioRol_SegRol");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.SegUsuarioRol)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegUsuarioRol_SegUsuario1");
            });

            modelBuilder.Entity<Sysfile>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DirVirtualOd)
                    .HasColumnName("DirVirtualOD")
                    .HasMaxLength(50);

                entity.Property(e => e.LinkServer).HasMaxLength(50);

                entity.Property(e => e.LinkServerProduccion).HasMaxLength(50);

                entity.Property(e => e.MailserverName)
                    .HasColumnName("mailserver_name")
                    .HasMaxLength(100);

                entity.Property(e => e.MailserverPort)
                    .HasColumnName("mailserver_Port")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MailserverType)
                    .HasColumnName("mailserver_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Servidor).HasMaxLength(100);

                entity.Property(e => e.WebServer)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<T006a>(entity =>
            {
                entity.HasKey(e => e.Msehi);

                entity.ToTable("T006A");

                entity.Property(e => e.Msehi)
                    .HasColumnName("MSEHI")
                    .HasMaxLength(18);

                entity.Property(e => e.Mandt)
                    .IsRequired()
                    .HasColumnName("MANDT")
                    .HasMaxLength(18);

                entity.Property(e => e.Mseh3)
                    .IsRequired()
                    .HasColumnName("MSEH3")
                    .HasMaxLength(18);

                entity.Property(e => e.Mseh6)
                    .IsRequired()
                    .HasColumnName("MSEH6")
                    .HasMaxLength(36);

                entity.Property(e => e.Msehl)
                    .IsRequired()
                    .HasColumnName("MSEHL")
                    .HasMaxLength(180);

                entity.Property(e => e.Mseht)
                    .IsRequired()
                    .HasColumnName("MSEHT")
                    .HasMaxLength(60);

                entity.Property(e => e.Spras)
                    .IsRequired()
                    .HasColumnName("SPRAS")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<TEnControlCalculo>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.ToTable("T_En_ControlCalculo");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Documento).HasMaxLength(20);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TEnEntradas>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_En_Entradas");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.FuncionDeBusqueda).HasMaxLength(500);

                entity.Property(e => e.FuncionDeBusquedaValor).HasMaxLength(500);

                entity.Property(e => e.FuncionDeValidacion)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MensajeValidacion)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Orden).HasMaxLength(20);

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.Valor).HasMaxLength(50);

                entity.HasOne(d => d.IdVariablesNavigation)
                    .WithMany(p => p.TEnEntradas)
                    .HasForeignKey(d => d.IdVariables)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_En_Entradas_T_Pa_Variables");
            });

            modelBuilder.Entity<TPaFormulas>(entity =>
            {
                entity.HasKey(e => new { e.IdVariables, e.LineaNegocio });

                entity.ToTable("T_Pa_Formulas");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.DescripcionFormula)
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Formula).HasMaxLength(4000);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrdenCalculo).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaModeloCalculo>(entity =>
            {
                entity.HasKey(e => e.CodigoModelo)
                    .HasName("PK_T_Pr_TiposDeCalculo");

                entity.ToTable("T_Pa_ModeloCalculo");

                entity.Property(e => e.CodigoModelo).ValueGeneratedNever();

                entity.Property(e => e.DescripcionModelo).HasMaxLength(256);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaPlantillaEntradas>(entity =>
            {
                entity.HasKey(e => new { e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_PA_PlantillaEntradas");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.DescripcionVariable).HasMaxLength(100);

                entity.Property(e => e.FuncionDeBusqueda).HasMaxLength(500);

                entity.Property(e => e.FuncionDeValidacion).HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Observaciones).HasMaxLength(500);

                entity.Property(e => e.Valor).HasMaxLength(50);

                entity.HasOne(d => d.IdVariablesNavigation)
                    .WithMany(p => p.TPaPlantillaEntradas)
                    .HasForeignKey(d => d.IdVariables)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_PA_PlantillaEntradas_T_Pa_Variables");

                entity.HasOne(d => d.LineaNegocioNavigation)
                    .WithMany(p => p.TPaPlantillaEntradas)
                    .HasForeignKey(d => d.LineaNegocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_PA_PlantillaEntradas_T_Pa_ModeloCalculo");
            });

            modelBuilder.Entity<TPaSysfile>(entity =>
            {
                entity.ToTable("T_Pa_Sysfile");

                entity.Property(e => e.ConsecutivoOrdenPlantilla).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CopiaFuncional).HasMaxLength(256);

                entity.Property(e => e.CopiaTecnico).HasMaxLength(256);

                entity.Property(e => e.DestinatarioFuncional).HasMaxLength(256);

                entity.Property(e => e.DestinatarioTecnico).HasMaxLength(256);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.SegundaCopiaFuncional).HasMaxLength(256);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaTipoCalculo>(entity =>
            {
                entity.HasKey(e => e.TipoCalculo);

                entity.ToTable("T_Pa_TipoCalculo");

                entity.Property(e => e.TipoCalculo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Promedio).HasMaxLength(1);

                entity.Property(e => e.Reposicion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaTiposDeVariables>(entity =>
            {
                entity.HasKey(e => e.IdTipoVariable);

                entity.ToTable("T_Pa_TiposDeVariables");

                entity.Property(e => e.IdTipoVariable).ValueGeneratedNever();

                entity.Property(e => e.Acumulador)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.AcumuladorGeneral)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Busqueda)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Calculo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Constante)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Entrada)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);
            });

            modelBuilder.Entity<TPaVariables>(entity =>
            {
                entity.HasKey(e => e.IdVariables);

                entity.ToTable("T_Pa_Variables");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.AfectaCostoPororden).HasMaxLength(1);

                entity.Property(e => e.AfectaMc)
                    .HasColumnName("AfectaMC")
                    .HasMaxLength(1);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.General)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IgualEnCombinacion).HasMaxLength(1);

                entity.Property(e => e.NombreVariable).HasMaxLength(100);

                entity.Property(e => e.TipoDato).HasMaxLength(25);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioModifico).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoVariableNavigation)
                    .WithMany(p => p.TPaVariables)
                    .HasForeignKey(d => d.IdTipoVariable)
                    .HasConstraintName("FK_T_Pa_Variables_T_Pa_TiposDeVariables");
            });

            modelBuilder.Entity<TPrCalculo>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_Pr_Calculo");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.Calculo).HasMaxLength(1);

                entity.Property(e => e.DescripcionFormula).HasMaxLength(4000);

                entity.Property(e => e.Formula).HasMaxLength(4000);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Orden).HasMaxLength(20);

                entity.Property(e => e.OrdenCalculo).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.Qry).HasMaxLength(4000);

                entity.Property(e => e.TiempoEjecucion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Valor).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<TSaCalculoHistorico>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_Sa_CalculoHistorico");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.DescripcionFormula).HasMaxLength(4000);

                entity.Property(e => e.FechaCalculo)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Formula).HasMaxLength(4000);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Orden).HasMaxLength(20);

                entity.Property(e => e.OrdenCalculo).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.Qry).HasMaxLength(4000);

                entity.Property(e => e.TiempoEjecucion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Valor).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<TSaEntradasHistorico>(entity =>
            {
                entity.HasKey(e => new { e.IdSolicitud, e.LineaNegocio, e.IdVariables, e.Item });

                entity.ToTable("T_Sa_EntradasHistorico");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.FechaCalculo)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FuncionDeBusqueda).HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Orden).HasMaxLength(20);

                entity.Property(e => e.Producto).HasMaxLength(12);

                entity.Property(e => e.Valor).HasMaxLength(50);
            });

            modelBuilder.Entity<TSaReporteAnalisisCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Sa_ReporteAnalisisCredito");

                entity.HasIndex(e => e.IdSolicitud)
                    .HasName("IX_T_Sa_ReporteAnalisisCredito");

                entity.HasIndex(e => new { e.IdSolicitud, e.LineaReporte })
                    .HasName("IX_T_Sa_ReporteAnalisisCredito_1");

                entity.HasIndex(e => new { e.IdSolicitud, e.IdvariablePadre, e.Idvariables })
                    .HasName("IX_T_Sa_ReporteAnalisisCredito_2");

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdvariablePadre).HasMaxLength(20);

                entity.Property(e => e.Idvariables).HasMaxLength(20);

                entity.Property(e => e.LineaReporte).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NombreVariable).HasMaxLength(100);

                entity.Property(e => e.Titulo).HasMaxLength(1);

                entity.Property(e => e.Valor).HasMaxLength(50);
            });

            modelBuilder.Entity<TempRbfactura>(entity =>
            {
                entity.HasKey(e => e.Recnum);

                entity.ToTable("TempRBFactura");

                entity.HasIndex(e => new { e.DocRb, e.Factura })
                    .HasName("IX_TempRBFactura")
                    .IsUnique();

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DocRb).HasColumnName("DocRB");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TempReciboCobro>(entity =>
            {
                entity.HasKey(e => e.Documento);

                entity.HasIndex(e => e.Recnum)
                    .HasName("IX_TempReciboCobro")
                    .IsUnique();

                entity.Property(e => e.Documento).ValueGeneratedNever();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Thumbnail>(entity =>
            {
                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.UserName)
                    .HasName("User_UserName_Index")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message).HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.User_dbo.Company_CompanyId");
            });

            modelBuilder.Entity<ValevenDataResumen>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<ValevenImpresiones>(entity =>
            {
                entity.HasKey(e => e.Archivo);

                entity.Property(e => e.Archivo).HasMaxLength(50);
            });

            modelBuilder.Entity<Wary074>(entity =>
            {
                entity.HasKey(e => new { e.TipoCompania, e.PlantaOficina, e.Transaccion, e.Documento, e.Linea })
                    .HasName("WARY074_INDEX01");

                entity.ToTable("WARY074");

                entity.HasComment("TRANSACCIONES PERMANENTE  CXC");

                entity.HasIndex(e => e.Batch)
                    .HasName("IX_WARY074_1");

                entity.HasIndex(e => e.Recnum)
                    .HasName("IX_WARY074_3")
                    .IsUnique();

                entity.HasIndex(e => new { e.Batch, e.DocCanc })
                    .HasName("IX_WARY074_2");

                entity.HasIndex(e => new { e.Cliente, e.Documento })
                    .HasName("IX_WARY074");

                entity.Property(e => e.TipoCompania)
                    .HasColumnName("TIPO_COMPANIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PlantaOficina).HasColumnName("PLANTA_OFICINA");

                entity.Property(e => e.Transaccion)
                    .HasColumnName("TRANSACCION")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Documento).HasColumnName("DOCUMENTO");

                entity.Property(e => e.Linea).HasColumnName("LINEA");

                entity.Property(e => e.AO).HasColumnName("A#O");

                entity.Property(e => e.Afectanota)
                    .HasColumnName("AFECTANOTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.AsigActual).HasColumnName("ASIG_ACTUAL");

                entity.Property(e => e.Banco)
                    .HasColumnName("BANCO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Cambio)
                    .HasColumnName("CAMBIO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodContrapart)
                    .HasColumnName("COD_CONTRAPART")
                    .HasMaxLength(50);

                entity.Property(e => e.ComisionPag)
                    .HasColumnName("COMISION_PAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comisionpagada)
                    .HasColumnName("COMISIONPAGADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompLinea).HasColumnName("COMP_LINEA");

                entity.Property(e => e.Comprobante).HasColumnName("COMPROBANTE");

                entity.Property(e => e.Concepto)
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.Contabilizado)
                    .HasColumnName("CONTABILIZADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion)
                    .HasColumnName("COTIZACION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaEfecto)
                    .HasColumnName("CUENTA_EFECTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Depura)
                    .HasColumnName("DEPURA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dias).HasColumnName("DIAS");

                entity.Property(e => e.DiasEntrega).HasColumnName("DIAS_ENTREGA");

                entity.Property(e => e.Diastransc).HasColumnName("DIASTRANSC");

                entity.Property(e => e.Diferencial)
                    .HasColumnName("DIFERENCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocCanc).HasColumnName("DOC_CANC");

                entity.Property(e => e.DocJde)
                    .HasColumnName("doc_jde")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Efectivo)
                    .HasColumnName("EFECTIVO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eliminar)
                    .HasColumnName("ELIMINAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estacion)
                    .HasColumnName("ESTACION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCobro)
                    .HasColumnName("FECHA_COBRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("FECHA_EMISION")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaPlanilla)
                    .HasColumnName("FECHA_PLANILLA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUsuario)
                    .HasColumnName("FECHA_USUARIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVcto)
                    .HasColumnName("FECHA_VCTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechadoccanc)
                    .HasColumnName("FECHADOCCANC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecrecibPl)
                    .HasColumnName("FECRECIB_PL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoActual)
                    .HasColumnName("GRUPO_ACTUAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraCreacion)
                    .HasColumnName("HORA_CREACION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HoraUsario).HasColumnName("HORA_USARIO");

                entity.Property(e => e.InformeQueja).HasColumnName("INFORME_QUEJA");

                entity.Property(e => e.LinCanc).HasColumnName("LIN_CANC");

                entity.Property(e => e.Lote)
                    .HasColumnName("LOTE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Matriz)
                    .HasColumnName("MATRIZ")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.MinutosUsuario).HasColumnName("MINUTOS_USUARIO");

                entity.Property(e => e.Moneda)
                    .HasColumnName("MONEDA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoDolar)
                    .HasColumnName("MONTO_DOLAR")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MontoMoneda)
                    .HasColumnName("MONTO_MONEDA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NoTieneDebe)
                    .HasColumnName("NO_TIENE_DEBE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NroPlanilla)
                    .HasColumnName("NRO_PLANILLA")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Nrocheque)
                    .HasColumnName("NROCHEQUE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroPl)
                    .HasColumnName("NUMERO_PL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Observacion1)
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion2)
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PasoJde)
                    .HasColumnName("paso_jde")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasColumnName("PASO_SQL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorIva)
                    .HasColumnName("POR_IVA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Porcret)
                    .HasColumnName("PORCRET")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Recalcular)
                    .HasColumnName("RECALCULAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecibidaPl)
                    .HasColumnName("RECIBIDA_PL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Referencia).HasColumnName("REFERENCIA");

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionActual)
                    .IsRequired()
                    .HasColumnName("REGION_ACTUAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RelacionCobro).HasColumnName("RELACION_COBRO");

                entity.Property(e => e.Remisionma).HasColumnName("REMISIONMA");

                entity.Property(e => e.Remisionsi).HasColumnName("REMISIONSI");

                entity.Property(e => e.Rmonto)
                    .HasColumnName("RMONTO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rsaldo)
                    .HasColumnName("RSALDO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rzvre)
                    .HasColumnName("RZVRE")
                    .HasMaxLength(10);

                entity.Property(e => e.Saldo)
                    .HasColumnName("SALDO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaldoDolar)
                    .HasColumnName("SALDO_DOLAR")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TasaCambio)
                    .HasColumnName("TASA_CAMBIO")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCanc)
                    .IsRequired()
                    .HasColumnName("TIPO_CANC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCiudad)
                    .HasColumnName("TIPO_CIUDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Transferencia)
                    .HasColumnName("TRANSFERENCIA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UltimoPago)
                    .HasColumnName("ULTIMO_PAGO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VecesCobro).HasColumnName("VECES_COBRO");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasColumnName("ZONA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wary074temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WARY074Temp");

                entity.HasComment("TRANSACCIONES PERMANENTE  CXC");

                entity.HasIndex(e => e.Recnum)
                    .HasName("IX_WARY074Temp_3")
                    .IsUnique();

                entity.Property(e => e.AO).HasColumnName("A#O");

                entity.Property(e => e.Afectanota)
                    .HasColumnName("AFECTANOTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.AsigActual).HasColumnName("ASIG_ACTUAL");

                entity.Property(e => e.Banco)
                    .HasColumnName("BANCO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Cambio)
                    .HasColumnName("CAMBIO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodContrapart)
                    .HasColumnName("COD_CONTRAPART")
                    .HasMaxLength(50);

                entity.Property(e => e.ComisionPag)
                    .HasColumnName("COMISION_PAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comisionpagada)
                    .HasColumnName("COMISIONPAGADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompLinea).HasColumnName("COMP_LINEA");

                entity.Property(e => e.Comprobante).HasColumnName("COMPROBANTE");

                entity.Property(e => e.Concepto)
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.Contabilizado)
                    .HasColumnName("CONTABILIZADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion)
                    .HasColumnName("COTIZACION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaEfecto)
                    .HasColumnName("CUENTA_EFECTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Depura)
                    .HasColumnName("DEPURA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dias).HasColumnName("DIAS");

                entity.Property(e => e.DiasEntrega).HasColumnName("DIAS_ENTREGA");

                entity.Property(e => e.Diastransc).HasColumnName("DIASTRANSC");

                entity.Property(e => e.Diferencial)
                    .HasColumnName("DIFERENCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocCanc).HasColumnName("DOC_CANC");

                entity.Property(e => e.DocJde)
                    .HasColumnName("doc_jde")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Documento).HasColumnName("DOCUMENTO");

                entity.Property(e => e.Efectivo)
                    .HasColumnName("EFECTIVO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eliminar)
                    .HasColumnName("ELIMINAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estacion)
                    .HasColumnName("ESTACION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCobro)
                    .HasColumnName("FECHA_COBRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("FECHA_EMISION")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaPlanilla)
                    .HasColumnName("FECHA_PLANILLA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUsuario)
                    .HasColumnName("FECHA_USUARIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVcto)
                    .HasColumnName("FECHA_VCTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechadoccanc)
                    .HasColumnName("FECHADOCCANC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecrecibPl)
                    .HasColumnName("FECRECIB_PL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoActual)
                    .HasColumnName("GRUPO_ACTUAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraCreacion)
                    .HasColumnName("HORA_CREACION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HoraUsario).HasColumnName("HORA_USARIO");

                entity.Property(e => e.InformeQueja).HasColumnName("INFORME_QUEJA");

                entity.Property(e => e.LinCanc).HasColumnName("LIN_CANC");

                entity.Property(e => e.Linea).HasColumnName("LINEA");

                entity.Property(e => e.Lote)
                    .HasColumnName("LOTE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Matriz)
                    .HasColumnName("MATRIZ")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.MinutosUsuario).HasColumnName("MINUTOS_USUARIO");

                entity.Property(e => e.Moneda)
                    .HasColumnName("MONEDA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoDolar)
                    .HasColumnName("MONTO_DOLAR")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MontoMoneda)
                    .HasColumnName("MONTO_MONEDA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NoTieneDebe)
                    .HasColumnName("NO_TIENE_DEBE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NroPlanilla)
                    .HasColumnName("NRO_PLANILLA")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Nrocheque)
                    .HasColumnName("NROCHEQUE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroPl)
                    .HasColumnName("NUMERO_PL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Observacion1)
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion2)
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PasoJde)
                    .HasColumnName("paso_jde")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasColumnName("PASO_SQL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PlantaOficina).HasColumnName("PLANTA_OFICINA");

                entity.Property(e => e.PorIva)
                    .HasColumnName("POR_IVA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Porcret)
                    .HasColumnName("PORCRET")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Recalcular)
                    .HasColumnName("RECALCULAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecibidaPl)
                    .HasColumnName("RECIBIDA_PL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Referencia).HasColumnName("REFERENCIA");

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionActual)
                    .IsRequired()
                    .HasColumnName("REGION_ACTUAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RelacionCobro).HasColumnName("RELACION_COBRO");

                entity.Property(e => e.Remisionma).HasColumnName("REMISIONMA");

                entity.Property(e => e.Remisionsi).HasColumnName("REMISIONSI");

                entity.Property(e => e.Rmonto)
                    .HasColumnName("RMONTO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rsaldo)
                    .HasColumnName("RSALDO")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rzvre)
                    .HasColumnName("RZVRE")
                    .HasMaxLength(10);

                entity.Property(e => e.Saldo)
                    .HasColumnName("SALDO")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaldoDolar)
                    .HasColumnName("SALDO_DOLAR")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TasaCambio)
                    .HasColumnName("TASA_CAMBIO")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCanc)
                    .IsRequired()
                    .HasColumnName("TIPO_CANC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoCiudad)
                    .HasColumnName("TIPO_CIUDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCompania)
                    .IsRequired()
                    .HasColumnName("TIPO_COMPANIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasColumnName("TRANSACCION")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transferencia)
                    .HasColumnName("TRANSFERENCIA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UltimoPago)
                    .HasColumnName("ULTIMO_PAGO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VecesCobro).HasColumnName("VECES_COBRO");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasColumnName("ZONA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wary074tempReconstruir>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WARY074TempReconstruir");

                entity.Property(e => e.AO).HasColumnName("A#O");

                entity.Property(e => e.Afectanota)
                    .HasColumnName("AFECTANOTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.AsigActual).HasColumnName("ASIG_ACTUAL");

                entity.Property(e => e.Banco)
                    .HasColumnName("BANCO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Cambio)
                    .HasColumnName("CAMBIO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodContrapart)
                    .HasColumnName("COD_CONTRAPART")
                    .HasMaxLength(50);

                entity.Property(e => e.ComisionPag)
                    .HasColumnName("COMISION_PAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Comisionpagada)
                    .HasColumnName("COMISIONPAGADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompLinea).HasColumnName("COMP_LINEA");

                entity.Property(e => e.Comprobante).HasColumnName("COMPROBANTE");

                entity.Property(e => e.Concepto)
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.Contabilizado)
                    .HasColumnName("CONTABILIZADO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion)
                    .HasColumnName("COTIZACION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaEfecto)
                    .HasColumnName("CUENTA_EFECTO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Depura)
                    .HasColumnName("DEPURA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Dias).HasColumnName("DIAS");

                entity.Property(e => e.DiasEntrega).HasColumnName("DIAS_ENTREGA");

                entity.Property(e => e.Diastransc).HasColumnName("DIASTRANSC");

                entity.Property(e => e.Diferencial)
                    .HasColumnName("DIFERENCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocCanc).HasColumnName("DOC_CANC");

                entity.Property(e => e.DocJde)
                    .HasColumnName("doc_jde")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Documento).HasColumnName("DOCUMENTO");

                entity.Property(e => e.Efectivo)
                    .HasColumnName("EFECTIVO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eliminar)
                    .HasColumnName("ELIMINAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estacion).HasColumnName("ESTACION");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCobro)
                    .HasColumnName("FECHA_COBRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("FECHA_EMISION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaPlanilla)
                    .HasColumnName("FECHA_PLANILLA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUsuario)
                    .HasColumnName("FECHA_USUARIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVcto)
                    .HasColumnName("FECHA_VCTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechadoccanc)
                    .HasColumnName("FECHADOCCANC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecrecibPl)
                    .HasColumnName("FECRECIB_PL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoActual)
                    .HasColumnName("GRUPO_ACTUAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraCreacion)
                    .HasColumnName("HORA_CREACION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HoraUsario).HasColumnName("HORA_USARIO");

                entity.Property(e => e.InformeQueja).HasColumnName("INFORME_QUEJA");

                entity.Property(e => e.LinCanc).HasColumnName("LIN_CANC");

                entity.Property(e => e.Linea).HasColumnName("LINEA");

                entity.Property(e => e.Lote)
                    .HasColumnName("LOTE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Matriz)
                    .HasColumnName("MATRIZ")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.MinutosUsuario).HasColumnName("MINUTOS_USUARIO");

                entity.Property(e => e.Moneda)
                    .HasColumnName("MONEDA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Monto)
                    .HasColumnName("MONTO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MontoDolar)
                    .HasColumnName("MONTO_DOLAR")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MontoMoneda)
                    .HasColumnName("MONTO_MONEDA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NoTieneDebe)
                    .HasColumnName("NO_TIENE_DEBE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NroPlanilla)
                    .HasColumnName("NRO_PLANILLA")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Nrocheque)
                    .HasColumnName("NROCHEQUE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroPl).HasColumnName("NUMERO_PL");

                entity.Property(e => e.Observacion1)
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observacion2)
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PasoJde)
                    .HasColumnName("paso_jde")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasColumnName("PASO_SQL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlantaOficina).HasColumnName("PLANTA_OFICINA");

                entity.Property(e => e.PorIva)
                    .HasColumnName("POR_IVA")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Porcret)
                    .HasColumnName("PORCRET")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Recalcular)
                    .HasColumnName("RECALCULAR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecibidaPl)
                    .HasColumnName("RECIBIDA_PL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Referencia).HasColumnName("REFERENCIA");

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionActual)
                    .IsRequired()
                    .HasColumnName("REGION_ACTUAL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RelacionCobro).HasColumnName("RELACION_COBRO");

                entity.Property(e => e.Remisionma).HasColumnName("REMISIONMA");

                entity.Property(e => e.Remisionsi).HasColumnName("REMISIONSI");

                entity.Property(e => e.Rmonto)
                    .HasColumnName("RMONTO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Rsaldo)
                    .HasColumnName("RSALDO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Rzvre)
                    .HasColumnName("RZVRE")
                    .HasMaxLength(10);

                entity.Property(e => e.Saldo)
                    .HasColumnName("SALDO")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SaldoDolar)
                    .HasColumnName("SALDO_DOLAR")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasColumnName("SUPERVISOR")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TasaCambio)
                    .HasColumnName("TASA_CAMBIO")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCanc)
                    .IsRequired()
                    .HasColumnName("TIPO_CANC")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCiudad)
                    .HasColumnName("TIPO_CIUDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCompania)
                    .IsRequired()
                    .HasColumnName("TIPO_COMPANIA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasColumnName("TRANSACCION")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Transferencia)
                    .HasColumnName("TRANSFERENCIA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UltimoPago)
                    .HasColumnName("ULTIMO_PAGO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VecesCobro).HasColumnName("VECES_COBRO");

                entity.Property(e => e.Vendedor)
                    .HasColumnName("VENDEDOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasColumnName("ZONA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wary182>(entity =>
            {
                entity.HasKey(e => e.Nota)
                    .HasName("WARY182_INDEX01");

                entity.ToTable("WARY182");

                entity.Property(e => e.Nota)
                    .HasColumnName("NOTA")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anulada)
                    .IsRequired()
                    .HasColumnName("ANULADA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasColumnName("BANCO")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cambio)
                    .HasColumnName("CAMBIO")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasColumnName("COBRADOR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodJdepadre)
                    .HasColumnName("COD_JDEPADRE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Contrapartida)
                    .IsRequired()
                    .HasColumnName("CONTRAPARTIDA")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DatosCliente)
                    .HasColumnName("DATOS_CLIENTE")
                    .HasColumnType("text");

                entity.Property(e => e.DireccionFact1)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact3)
                    .IsRequired()
                    .HasColumnName("DIRECCION_FACT3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("FECHA_EMISION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("FECHA_INGRESO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaVenc)
                    .HasColumnName("FECHA_VENC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagImpreso)
                    .IsRequired()
                    .HasColumnName("FLAG_IMPRESO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Ivad)
                    .HasColumnName("IVAD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Ivaporc)
                    .HasColumnName("IVAPORC")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.NitFact)
                    .IsRequired()
                    .HasColumnName("NIT_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreFact)
                    .IsRequired()
                    .HasColumnName("NOMBRE_FACT")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroControl).HasColumnName("NRO_CONTROL");

                entity.Property(e => e.Observacion1)
                    .IsRequired()
                    .HasColumnName("OBSERVACION1")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .IsRequired()
                    .HasColumnName("OBSERVACION2")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .IsRequired()
                    .HasColumnName("OBSERVACION3")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion4)
                    .IsRequired()
                    .HasColumnName("OBSERVACION4")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasColumnName("REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasColumnName("RIF_FACT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Riva)
                    .HasColumnName("RIVA")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rsubtotal)
                    .HasColumnName("RSUBTOTAL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rtotal)
                    .HasColumnName("RTOTAL")
                    .HasColumnType("decimal(16, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("SUBTOTAL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Subtotald)
                    .HasColumnName("SUBTOTALD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Totald)
                    .HasColumnName("TOTALD")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasColumnName("TRANSACCION")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wary241>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WARY241");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaUpdate)
                    .HasColumnName("FECHA_UPDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RutBs)
                    .HasColumnName("RUT_BS")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UtBs)
                    .HasColumnName("UT_BS")
                    .HasColumnType("decimal(18, 3)");
            });

            /*modelBuilder.Entity<Wivy003>(entity =>
            {
                entity.HasKey(e => e.Recnum);

                entity.ToTable("WIVY003");

                entity.Property(e => e.Recnum)
                    .HasColumnName("RECNUM")
                    .HasColumnType("decimal(28, 0)");

                entity.Property(e => e.AprobCredM)
                    .HasColumnName("APROB_CRED_M")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodJde)
                    .HasColumnName("COD_JDE")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasVcto).HasColumnName("DIAS_VCTO");

                entity.Property(e => e.Inactivo)
                    .HasColumnName("inactivo")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PorcRequerido).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RequiereLimiteCredito)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });*/

            modelBuilder.Entity<Wsmy469>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY469");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaHoraAgrega).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaHoraModifica).HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDireccionEntregar)
                    .HasColumnName("Id_direccionEntregar")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDireccionFacturar)
                    .HasColumnName("Id_direccionFacturar")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LongitudMascara).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeroControlDesde)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroControlHasta)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroFormatoDesde)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroFormatoHasta)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroSdf).HasColumnName("NumeroSDF");

                entity.Property(e => e.NumeroSerieControlDesde)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroSerieControlHasta)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroSerieFormatoDesde)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumeroSerieFormatoHasta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Producto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rif)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAgrega)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
