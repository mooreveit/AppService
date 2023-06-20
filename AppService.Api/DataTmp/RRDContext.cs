using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppService.Api.DataTmp
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

        public virtual DbSet<AppCantidadMinima> AppCantidadMinimas { get; set; }
        public virtual DbSet<AppCategory> AppCategories { get; set; }
        public virtual DbSet<AppConfigApp> AppConfigApps { get; set; }
        public virtual DbSet<AppDesarrolloEtiquetasPrime> AppDesarrolloEtiquetasPrimes { get; set; }
        public virtual DbSet<AppDetailQuote> AppDetailQuotes { get; set; }
        public virtual DbSet<AppDetailQuotesConversionUnit> AppDetailQuotesConversionUnits { get; set; }
        public virtual DbSet<AppEmbarque> AppEmbarques { get; set; }
        public virtual DbSet<AppGeneralQuote> AppGeneralQuotes { get; set; }
        public virtual DbSet<AppIngredient> AppIngredients { get; set; }
        public virtual DbSet<AppOrdenProductoRepeticion> AppOrdenProductoRepeticions { get; set; }
        public virtual DbSet<AppPorcentajeAdicionalM2> AppPorcentajeAdicionalM2s { get; set; }
        public virtual DbSet<AppPrecioTemporal> AppPrecioTemporals { get; set; }
        public virtual DbSet<AppPrice> AppPrices { get; set; }
        public virtual DbSet<AppPrice04042023> AppPrice04042023s { get; set; }
        public virtual DbSet<AppPriceAl08302022> AppPriceAl08302022s { get; set; }
        public virtual DbSet<AppProduct> AppProducts { get; set; }
        public virtual DbSet<AppProductConversion> AppProductConversions { get; set; }
        public virtual DbSet<AppProductVariableSearchText> AppProductVariableSearchTexts { get; set; }
        public virtual DbSet<AppProducts04042023> AppProducts04042023s { get; set; }
        public virtual DbSet<AppRecipe> AppRecipes { get; set; }
        public virtual DbSet<AppRecipes04042023> AppRecipes04042023s { get; set; }
        public virtual DbSet<AppRecipesByAppDetailQuote> AppRecipesByAppDetailQuotes { get; set; }
        public virtual DbSet<AppRecipesByAppDetailQuotesHistory> AppRecipesByAppDetailQuotesHistories { get; set; }
        public virtual DbSet<AppRepeticionClienteBasica> AppRepeticionClienteBasicas { get; set; }
        public virtual DbSet<AppRepeticionClienteNombreForma> AppRepeticionClienteNombreFormas { get; set; }
        public virtual DbSet<AppRepeticionClienteOpuestum> AppRepeticionClienteOpuesta { get; set; }
        public virtual DbSet<AppRepeticionClientePapelCuartaParte> AppRepeticionClientePapelCuartaPartes { get; set; }
        public virtual DbSet<AppRepeticionClientePapelPrimeraParte> AppRepeticionClientePapelPrimeraPartes { get; set; }
        public virtual DbSet<AppRepeticionClientePapelQuintaParte> AppRepeticionClientePapelQuintaPartes { get; set; }
        public virtual DbSet<AppRepeticionClientePapelSegundaParte> AppRepeticionClientePapelSegundaPartes { get; set; }
        public virtual DbSet<AppRepeticionClientePapelTerceraParte> AppRepeticionClientePapelTerceraPartes { get; set; }
        public virtual DbSet<AppRepeticionClienteParte> AppRepeticionClientePartes { get; set; }
        public virtual DbSet<AppRepeticionClienteProducto> AppRepeticionClienteProductos { get; set; }
        public virtual DbSet<AppRepeticionClienteTinta> AppRepeticionClienteTintas { get; set; }
        public virtual DbSet<AppStatusQuote> AppStatusQuotes { get; set; }
        public virtual DbSet<AppSubCategory> AppSubCategories { get; set; }
        public virtual DbSet<AppTemplateConversionUnit> AppTemplateConversionUnits { get; set; }
        public virtual DbSet<AppTituloVariable> AppTituloVariables { get; set; }
        public virtual DbSet<AppUnit> AppUnits { get; set; }
        public virtual DbSet<AppUnitsofMeasureforIngredient> AppUnitsofMeasureforIngredients { get; set; }
        public virtual DbSet<AppUnitsofMeasureforMaterial> AppUnitsofMeasureforMaterials { get; set; }
        public virtual DbSet<AppVariable> AppVariables { get; set; }
        public virtual DbSet<AppVariableSearch> AppVariableSearches { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<AutoAudit> AutoAudits { get; set; }
        public virtual DbSet<Cary028> Cary028s { get; set; }
        public virtual DbSet<Cary029> Cary029s { get; set; }
        public virtual DbSet<CatAuditoriaCalculo> CatAuditoriaCalculos { get; set; }
        public virtual DbSet<CatCalibrePapel> CatCalibrePapels { get; set; }
        public virtual DbSet<CatCalibrePapelRollo> CatCalibrePapelRollos { get; set; }
        public virtual DbSet<CatCodigoMayorPartesBasica> CatCodigoMayorPartesBasicas { get; set; }
        public virtual DbSet<CatListum> CatLista { get; set; }
        public virtual DbSet<CatMaterial> CatMaterials { get; set; }
        public virtual DbSet<CatMaterialDetalle> CatMaterialDetalles { get; set; }
        public virtual DbSet<CatMaterialDetalleTmp> CatMaterialDetalleTmps { get; set; }
        public virtual DbSet<CatMedidaBasica> CatMedidaBasicas { get; set; }
        public virtual DbSet<CatMedidaBasica1> CatMedidaBasicas1 { get; set; }
        public virtual DbSet<CatMedidaBasicaRollo> CatMedidaBasicaRollos { get; set; }
        public virtual DbSet<CatMedidaOpuestum> CatMedidaOpuesta { get; set; }
        public virtual DbSet<CatPapel> CatPapels { get; set; }
        public virtual DbSet<CatProductoMayor> CatProductoMayors { get; set; }
        public virtual DbSet<CatProductoMayorParte> CatProductoMayorPartes { get; set; }
        public virtual DbSet<CatProductoMayorPartesTinta> CatProductoMayorPartesTintas { get; set; }
        public virtual DbSet<CatProductoMayorPartesTintasBasica> CatProductoMayorPartesTintasBasicas { get; set; }
        public virtual DbSet<CatProductoMayorPartesTintasBasicaOpuestaPapele> CatProductoMayorPartesTintasBasicaOpuestaPapeles { get; set; }
        public virtual DbSet<CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon> CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbons { get; set; }
        public virtual DbSet<CatProductoMayorPartesTintasBasicaOpuestum> CatProductoMayorPartesTintasBasicaOpuesta { get; set; }
        public virtual DbSet<CatProductoMayorUnidadesConversion> CatProductoMayorUnidadesConversions { get; set; }
        public virtual DbSet<CatSubCategorium> CatSubCategoria { get; set; }
        public virtual DbSet<CatSysfile> CatSysfiles { get; set; }
        public virtual DbSet<ChildMenu> ChildMenus { get; set; }
        public virtual DbSet<Ciny056> Ciny056s { get; set; }
        public virtual DbSet<Ciny057> Ciny057s { get; set; }
        public virtual DbSet<CobAdjuntosCobranza> CobAdjuntosCobranzas { get; set; }
        public virtual DbSet<CobAvisosCobro> CobAvisosCobros { get; set; }
        public virtual DbSet<CobAvisosCobroTemp> CobAvisosCobroTemps { get; set; }
        public virtual DbSet<CobBanco> CobBancos { get; set; }
        public virtual DbSet<CobDatosCheque> CobDatosCheques { get; set; }
        public virtual DbSet<CobDescuentoIvaTipoTransaccion> CobDescuentoIvaTipoTransaccions { get; set; }
        public virtual DbSet<CobDiferenciaRetencion> CobDiferenciaRetencions { get; set; }
        public virtual DbSet<CobEstadoDeCuentaBk> CobEstadoDeCuentaBks { get; set; }
        public virtual DbSet<CobEstadoDeCuentum> CobEstadoDeCuenta { get; set; }
        public virtual DbSet<CobExcepcion> CobExcepcions { get; set; }
        public virtual DbSet<CobGeneralCobranza> CobGeneralCobranzas { get; set; }
        public virtual DbSet<CobGrabacionCobranza> CobGrabacionCobranzas { get; set; }
        public virtual DbSet<CobIntegridadCobranzasVsWary074> CobIntegridadCobranzasVsWary074s { get; set; }
        public virtual DbSet<CobMatrixMonedaValidaPago> CobMatricesMonedaValidaPago { get; set; }
        public virtual DbSet<CobPagosRetencione> CobPagosRetenciones { get; set; }
        public virtual DbSet<CobPorcentajesImpuesto> CobPorcentajesImpuestos { get; set; }
        public virtual DbSet<CobRangoDiasPago> CobRangoDiasPagos { get; set; }
        public virtual DbSet<CobRangosVencimiento> CobRangosVencimientos { get; set; }
        public virtual DbSet<CobResumenEstadoCuentaTemp> CobResumenEstadoCuentaTemps { get; set; }
        public virtual DbSet<CobResumenEstadoCuentum> CobResumenEstadoCuenta { get; set; }
        public virtual DbSet<CobRolCobranza> CobRolCobranzas { get; set; }
        public virtual DbSet<CobSysfile> CobSysfiles { get; set; }
        public virtual DbSet<CobTipoTransaccion> CobTipoTransaccions { get; set; }
        public virtual DbSet<CobTipoTransaccionRespaldoAntesEliminarColettilla> CobTipoTransaccionRespaldoAntesEliminarColettillas { get; set; }
        public virtual DbSet<CobTransaccione> CobTransacciones { get; set; }
        public virtual DbSet<CobValoresRetencionIslr> CobValoresRetencionIslrs { get; set; }
        public virtual DbSet<CobValoresRetencionIva> CobValoresRetencionIvas { get; set; }
        public virtual DbSet<CobValoresRetencione> CobValoresRetenciones { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Cpry010> Cpry010s { get; set; }
        public virtual DbSet<Cpry012> Cpry012s { get; set; }
        public virtual DbSet<CreAdjuntoSolicitudCredito> CreAdjuntoSolicitudCreditos { get; set; }
        public virtual DbSet<CreClientesExcepcion> CreClientesExcepcions { get; set; }
        public virtual DbSet<CreCobradoCotizacion> CreCobradoCotizacions { get; set; }
        public virtual DbSet<CreCotizacionDocumento> CreCotizacionDocumentos { get; set; }
        public virtual DbSet<CreEvaluacionCredito> CreEvaluacionCreditos { get; set; }
        public virtual DbSet<CrePendientesExcepcion> CrePendientesExcepcions { get; set; }
        public virtual DbSet<CreRangoAprobacionOficinaUsuarioMontoDia> CreRangoAprobacionOficinaUsuarioMontoDias { get; set; }
        public virtual DbSet<CreResponsableAprobarExcepcion> CreResponsableAprobarExcepcions { get; set; }
        public virtual DbSet<CreSolicitudDeCredito> CreSolicitudDeCreditos { get; set; }
        public virtual DbSet<CreSolicitudDeCreditoHistorico> CreSolicitudDeCreditoHistoricos { get; set; }
        public virtual DbSet<CreSolicitudExcepcion> CreSolicitudExcepcions { get; set; }
        public virtual DbSet<CreSolicitudExcepcionHistorico> CreSolicitudExcepcionHistoricos { get; set; }
        public virtual DbSet<CrmEncuestaCliente> CrmEncuestaClientes { get; set; }
        public virtual DbSet<CrmMtrC> CrmMtrCs { get; set; }
        public virtual DbSet<CrmMtrCe> CrmMtrCes { get; set; }
        public virtual DbSet<CrmMtrEstado> CrmMtrEstados { get; set; }
        public virtual DbSet<CrmMtrNp> CrmMtrNps { get; set; }
        public virtual DbSet<CrmMtrSeguimiento> CrmMtrSeguimientos { get; set; }
        public virtual DbSet<CrmNotificacionActividade> CrmNotificacionActividades { get; set; }
        public virtual DbSet<CrmSeguimiento> CrmSeguimientos { get; set; }
        public virtual DbSet<CrmVisitaDium> CrmVisitaDia { get; set; }
        public virtual DbSet<CrmVisitaFrecuencium> CrmVisitaFrecuencia { get; set; }
        public virtual DbSet<CrmVisitaSemana> CrmVisitaSemanas { get; set; }
        public virtual DbSet<Ctmy033> Ctmy033s { get; set; }
        public virtual DbSet<Ctmy034> Ctmy034s { get; set; }
        public virtual DbSet<DataInicial> DataInicials { get; set; }
        public virtual DbSet<DeudorTipoRetencion> DeudorTipoRetencions { get; set; }
        public virtual DbSet<Deudore> Deudores { get; set; }
        public virtual DbSet<EjeucionProceso> EjeucionProcesos { get; set; }
        public virtual DbSet<EjeucionProcesoComisione> EjeucionProcesoComisiones { get; set; }
        public virtual DbSet<EscaneoTicket> EscaneoTickets { get; set; }
        public virtual DbSet<F03b11> F03b11s { get; set; }
        public virtual DbSet<GssAdjuntoTarea> GssAdjuntoTareas { get; set; }
        public virtual DbSet<GssAdminApp> GssAdminApps { get; set; }
        public virtual DbSet<GssAprobacionServicio> GssAprobacionServicios { get; set; }
        public virtual DbSet<GssAreaServicio> GssAreaServicios { get; set; }
        public virtual DbSet<GssCompañium> GssCompañia { get; set; }
        public virtual DbSet<GssEstatusSolicitud> GssEstatusSolicituds { get; set; }
        public virtual DbSet<GssEstatusTarea> GssEstatusTareas { get; set; }
        public virtual DbSet<GssGrupoTrabajo> GssGrupoTrabajos { get; set; }
        public virtual DbSet<GssGrupoTrabajoUsuario> GssGrupoTrabajoUsuarios { get; set; }
        public virtual DbSet<GssMtrTipoDato> GssMtrTipoDatos { get; set; }
        public virtual DbSet<GssNivel> GssNivels { get; set; }
        public virtual DbSet<GssPai> GssPais { get; set; }
        public virtual DbSet<GssPasoSolicitud> GssPasoSolicituds { get; set; }
        public virtual DbSet<GssPlantillaServicio> GssPlantillaServicios { get; set; }
        public virtual DbSet<GssServicio> GssServicios { get; set; }
        public virtual DbSet<GssServicioNivel> GssServicioNivels { get; set; }
        public virtual DbSet<GssServicioResponsable> GssServicioResponsables { get; set; }
        public virtual DbSet<GssSolicitud> GssSolicituds { get; set; }
        public virtual DbSet<GssSolicitudServicio> GssSolicitudServicios { get; set; }
        public virtual DbSet<GssTarea> GssTareas { get; set; }
        public virtual DbSet<GssTareaComentario> GssTareaComentarios { get; set; }
        public virtual DbSet<GssTareaPlantillaServicio> GssTareaPlantillaServicios { get; set; }
        public virtual DbSet<GssTipoDocumento> GssTipoDocumentos { get; set; }
        public virtual DbSet<GssTipoServicio> GssTipoServicios { get; set; }
        public virtual DbSet<GssUnidadServicio> GssUnidadServicios { get; set; }
        public virtual DbSet<GssUnidadServicioCompañium> GssUnidadServicioCompañia { get; set; }
        public virtual DbSet<GssUsuarioCompañium> GssUsuarioCompañia { get; set; }
        public virtual DbSet<GssUsuarioNivel> GssUsuarioNivels { get; set; }
        public virtual DbSet<GssUsuarioPlantillaServicio> GssUsuarioPlantillaServicios { get; set; }
        public virtual DbSet<GssVariable> GssVariables { get; set; }
        public virtual DbSet<HistoricoNomina> HistoricoNominas { get; set; }
        public virtual DbSet<HistoricoPersonalCargo> HistoricoPersonalCargos { get; set; }
        public virtual DbSet<Marm> Marms { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<MtrBanco> MtrBancos { get; set; }
        public virtual DbSet<MtrCliente> MtrClientes { get; set; }
        public virtual DbSet<MtrClienteEnvioOdooLog> MtrClienteEnvioOdooLogs { get; set; }
        public virtual DbSet<MtrClienteProspecto> MtrClienteProspectos { get; set; }
        public virtual DbSet<MtrClienteTemp> MtrClienteTemps { get; set; }
        public virtual DbSet<MtrCondicionPago> MtrCondicionPagos { get; set; }
        public virtual DbSet<MtrContacto> MtrContactos { get; set; }
        public virtual DbSet<MtrContactosAl30052023> MtrContactosAl30052023s { get; set; }
        public virtual DbSet<MtrDireccione> MtrDirecciones { get; set; }
        public virtual DbSet<MtrEmpleado> MtrEmpleados { get; set; }
        public virtual DbSet<MtrFechaFeriadum> MtrFechaFeriada { get; set; }
        public virtual DbSet<MtrHorarioLaborable> MtrHorarioLaborables { get; set; }
        public virtual DbSet<MtrOficina> MtrOficinas { get; set; }
        public virtual DbSet<MtrPerfilCorreo> MtrPerfilCorreos { get; set; }
        public virtual DbSet<MtrProducto> MtrProductos { get; set; }
        public virtual DbSet<MtrProductoBasica> MtrProductoBasicas { get; set; }
        public virtual DbSet<MtrProductoOpuestum> MtrProductoOpuesta { get; set; }
        public virtual DbSet<MtrProductoPapele> MtrProductoPapeles { get; set; }
        public virtual DbSet<MtrRegione> MtrRegiones { get; set; }
        public virtual DbSet<MtrTipoCuentaDestino> MtrTipoCuentaDestinos { get; set; }
        public virtual DbSet<MtrTipoDocumentoFiscal> MtrTipoDocumentoFiscals { get; set; }
        public virtual DbSet<MtrTipoMonedum> MtrTipoMoneda { get; set; }
        public virtual DbSet<MtrTipoNomina> MtrTipoNominas { get; set; }
        public virtual DbSet<MtrTipoOrden> MtrTipoOrdens { get; set; }
        public virtual DbSet<MtrTipoTransaccionCuentaDestino> MtrTipoTransaccionCuentaDestinos { get; set; }
        public virtual DbSet<MtrTipoValorRetencion> MtrTipoValorRetencions { get; set; }
        public virtual DbSet<MtrUsuarioOficina> MtrUsuarioOficinas { get; set; }
        public virtual DbSet<MtrVendedor> MtrVendedors { get; set; }
        public virtual DbSet<OfdAdjunto> OfdAdjuntos { get; set; }
        public virtual DbSet<OfdAdjuntoCriterio> OfdAdjuntoCriterios { get; set; }
        public virtual DbSet<OfdAdjuntosDiseno> OfdAdjuntosDisenos { get; set; }
        public virtual DbSet<OfdAprobacionDiseno> OfdAprobacionDisenos { get; set; }
        public virtual DbSet<OfdCambioDiseno> OfdCambioDisenos { get; set; }
        public virtual DbSet<OfdConstruccionCotizacion> OfdConstruccionCotizacions { get; set; }
        public virtual DbSet<OfdCotizacion> OfdCotizacions { get; set; }
        public virtual DbSet<OfdCriterioBusquedum> OfdCriterioBusqueda { get; set; }
        public virtual DbSet<OfdDetalleSolicitudDiseno> OfdDetalleSolicitudDisenos { get; set; }
        public virtual DbSet<OfdEspecificacionCotizacion> OfdEspecificacionCotizacions { get; set; }
        public virtual DbSet<OfdEstatusFlujo> OfdEstatusFlujos { get; set; }
        public virtual DbSet<OfdExcepcionFlujoProducto> OfdExcepcionFlujoProductos { get; set; }
        public virtual DbSet<OfdFlujoEstacion> OfdFlujoEstacions { get; set; }
        public virtual DbSet<OfdGrupoCriterio> OfdGrupoCriterios { get; set; }
        public virtual DbSet<OfdGrupoTipoDocumento> OfdGrupoTipoDocumentos { get; set; }
        public virtual DbSet<OfdMaestroEstacion> OfdMaestroEstacions { get; set; }
        public virtual DbSet<OfdMaestroFlujo> OfdMaestroFlujos { get; set; }
        public virtual DbSet<OfdMaestroPieImprentum> OfdMaestroPieImprenta { get; set; }
        public virtual DbSet<OfdMaestroTipoRespaldo> OfdMaestroTipoRespaldos { get; set; }
        public virtual DbSet<OfdMaestroUbicacionMarginal> OfdMaestroUbicacionMarginals { get; set; }
        public virtual DbSet<OfdMaestroVoBo> OfdMaestroVoBos { get; set; }
        public virtual DbSet<OfdObservacionAdjunto> OfdObservacionAdjuntos { get; set; }
        public virtual DbSet<OfdPartesCotizacion> OfdPartesCotizacions { get; set; }
        public virtual DbSet<OfdPlantillaPreset> OfdPlantillaPresets { get; set; }
        public virtual DbSet<OfdPropuestaResp> OfdPropuestaResps { get; set; }
        public virtual DbSet<OfdPropuestum> OfdPropuesta { get; set; }
        public virtual DbSet<OfdRenglon> OfdRenglons { get; set; }
        public virtual DbSet<OfdRolTipoDocumento> OfdRolTipoDocumentos { get; set; }
        public virtual DbSet<OfdSeguimiento> OfdSeguimientos { get; set; }
        public virtual DbSet<OfdSolicitudDiseno> OfdSolicitudDisenos { get; set; }
        public virtual DbSet<OfdSolicitudDisenoCambio> OfdSolicitudDisenoCambios { get; set; }
        public virtual DbSet<OfdSolicitudDocFiscal> OfdSolicitudDocFiscals { get; set; }
        public virtual DbSet<OfdTintasCotizacion> OfdTintasCotizacions { get; set; }
        public virtual DbSet<OfdTipoCambioDiseno> OfdTipoCambioDisenos { get; set; }
        public virtual DbSet<OfdTipoDocumento> OfdTipoDocumentos { get; set; }
        public virtual DbSet<OfdVariablesEspecificacion> OfdVariablesEspecificacions { get; set; }
        public virtual DbSet<OfdVoBoDiseno> OfdVoBoDisenos { get; set; }
        public virtual DbSet<PageMenu> PageMenus { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<PrcNumeracionFiscal> PrcNumeracionFiscals { get; set; }
        public virtual DbSet<PrcObjetosProceso> PrcObjetosProcesos { get; set; }
        public virtual DbSet<PrcOrdenIdPropuestum> PrcOrdenIdPropuesta { get; set; }
        public virtual DbSet<PrcPlantillaNumeracione> PrcPlantillaNumeraciones { get; set; }
        public virtual DbSet<PrcUsuarioProceso> PrcUsuarioProcesos { get; set; }
        public virtual DbSet<PrecioActualizar> PrecioActualizars { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<ReqAreaRequerimiento> ReqAreaRequerimientos { get; set; }
        public virtual DbSet<ReqCompañium> ReqCompañia { get; set; }
        public virtual DbSet<ReqOrigenRequerimiento> ReqOrigenRequerimientos { get; set; }
        public virtual DbSet<ReqTarea> ReqTareas { get; set; }
        public virtual DbSet<ReqTipoTarea> ReqTipoTareas { get; set; }
        public virtual DbSet<ReqVariable> ReqVariables { get; set; }
        public virtual DbSet<RetencionesCorregir> RetencionesCorregirs { get; set; }
        public virtual DbSet<RrdejecutarSql> RrdejecutarSqls { get; set; }
        public virtual DbSet<SapFrecuenciaVisitaCliente> SapFrecuenciaVisitaClientes { get; set; }
        public virtual DbSet<SapRetencione> SapRetenciones { get; set; }
        public virtual DbSet<SegModulo> SegModulos { get; set; }
        public virtual DbSet<SegPrograma> SegProgramas { get; set; }
        public virtual DbSet<SegRol> SegRols { get; set; }
        public virtual DbSet<SegRolEstacion> SegRolEstacions { get; set; }
        public virtual DbSet<SegRolModulo> SegRolModulos { get; set; }
        public virtual DbSet<SegTicket> SegTickets { get; set; }
        public virtual DbSet<SegUsuario> SegUsuarios { get; set; }
        public virtual DbSet<SegUsuarioRol> SegUsuarioRols { get; set; }
        public virtual DbSet<Sysfile> Sysfiles { get; set; }
        public virtual DbSet<T006a> T006as { get; set; }
        public virtual DbSet<TEnControlCalculo> TEnControlCalculos { get; set; }
        public virtual DbSet<TEnEntrada> TEnEntradas { get; set; }
        public virtual DbSet<TPaFormula> TPaFormulas { get; set; }
        public virtual DbSet<TPaModeloCalculo> TPaModeloCalculos { get; set; }
        public virtual DbSet<TPaPlantillaEntrada> TPaPlantillaEntradas { get; set; }
        public virtual DbSet<TPaSysfile> TPaSysfiles { get; set; }
        public virtual DbSet<TPaTasaBancoCentral> TPaTasaBancoCentrals { get; set; }
        public virtual DbSet<TPaTasaReferencial> TPaTasaReferencials { get; set; }
        public virtual DbSet<TPaTipoCalculo> TPaTipoCalculos { get; set; }
        public virtual DbSet<TPaTiposDeVariable> TPaTiposDeVariables { get; set; }
        public virtual DbSet<TPaVariable> TPaVariables { get; set; }
        public virtual DbSet<TPrCalculo> TPrCalculos { get; set; }
        public virtual DbSet<TSaCalculoHistorico> TSaCalculoHistoricos { get; set; }
        public virtual DbSet<TSaEntradasHistorico> TSaEntradasHistoricos { get; set; }
        public virtual DbSet<TSaPlantillaReporteAnalisisCredito> TSaPlantillaReporteAnalisisCreditos { get; set; }
        public virtual DbSet<TSaReporteAnalisisCredito> TSaReporteAnalisisCreditos { get; set; }
        public virtual DbSet<TempRbfactura> TempRbfacturas { get; set; }
        public virtual DbSet<TempReciboCobro> TempReciboCobros { get; set; }
        public virtual DbSet<Thumbnail> Thumbnails { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsuariosOdoo> UsuariosOdoos { get; set; }
        public virtual DbSet<VCobrosDiasTranscurrido> VCobrosDiasTranscurridos { get; set; }
        public virtual DbSet<VRecipePrecioMaximo> VRecipePrecioMaximos { get; set; }
        public virtual DbSet<VRetencionesCobrada> VRetencionesCobradas { get; set; }
        public virtual DbSet<ValevenDataResuman> ValevenDataResumen { get; set; }
        public virtual DbSet<ValevenImpresione> ValevenImpresiones { get; set; }
        public virtual DbSet<Wary074> Wary074s { get; set; }
        public virtual DbSet<Wary074temp> Wary074temps { get; set; }
        public virtual DbSet<Wary074tempReconstruir> Wary074tempReconstruirs { get; set; }
        public virtual DbSet<Wary182> Wary182s { get; set; }
        public virtual DbSet<Wary241> Wary241s { get; set; }
        public virtual DbSet<Wimy001> Wimy001s { get; set; }
        public virtual DbSet<Wivy003> Wivy003s { get; set; }
        public virtual DbSet<Wsmy469> Wsmy469s { get; set; }
        public virtual DbSet<Wsmy582> Wsmy582s { get; set; }
        public virtual DbSet<Wsmy583> Wsmy583s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.28.107.19;Database=RRD;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<AppCantidadMinima>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppCantidadMinima");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<AppCategory>(entity =>
            {
                entity.ToTable("AppCategory");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AppConfigApp>(entity =>
            {
                entity.ToTable("AppConfigApp");

                entity.HasIndex(e => e.Clave, "IX_AppConfigApp");

                entity.HasIndex(e => e.Id, "IX_AppConfigApp_1");

                entity.Property(e => e.Clave)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppDesarrolloEtiquetasPrime>(entity =>
            {
                entity.ToTable("AppDesarrolloEtiquetasPrime");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Desarrollo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Desde).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Hasta).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<AppDetailQuote>(entity =>
            {
                entity.HasIndex(e => e.AppGeneralQuotesId, "IX_AppDetailQuotes");

                entity.HasIndex(e => e.Cotizacion, "IX_AppDetailQuotes_1");

                entity.Property(e => e.CalculoId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantPartes).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantTintas).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CantidadPorUnidadProduccion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantidadSolicitada).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Iva)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MedidaBasica)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MedidaOpuesta)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Medidas)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreComercialProducto)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ObsSolicitud).HasMaxLength(300);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.OdooId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Orden).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdenAnterior).HasDefaultValueSql("((0))");

                entity.Property(e => e.Papeles)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PorcIva)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PrecioUsd).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Producto).HasMaxLength(20);

                entity.Property(e => e.Rprecio)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("RPrecio")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rtotal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RTotal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SolicitarPrecio).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tintas)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoPapeles)
                    .HasMaxLength(400)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalConIva)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalUsd).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UnitPriceBaseProduction)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPriceConverted)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.Property(e => e.ValorConvertido)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

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
                entity.ToTable("AppDetailQuotesConversionUnit");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Max)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Min)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.AppDetailQuotes)
                    .WithMany(p => p.AppDetailQuotesConversionUnits)
                    .HasForeignKey(d => d.AppDetailQuotesId)
                    .HasConstraintName("FK_AppDetailQuotesConversionUnit_AppDetailQuotes");

                entity.HasOne(d => d.AppVariable)
                    .WithMany(p => p.AppDetailQuotesConversionUnits)
                    .HasForeignKey(d => d.AppVariableId)
                    .HasConstraintName("FK_AppDetailQuotesConversionUnit_AppVariables");
            });

            modelBuilder.Entity<AppEmbarque>(entity =>
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

            modelBuilder.Entity<AppGeneralQuote>(entity =>
            {
                entity.HasIndex(e => e.Fecha, "IX_AppGeneralQuotes");

                entity.HasIndex(e => new { e.Fecha, e.SearchText }, "IX_AppGeneralQuotes_1");

                entity.HasIndex(e => e.Cotizacion, "IX_AppGeneralQuotes_2")
                    .IsUnique();

                entity.HasIndex(e => e.IdVendedor, "IX_AppGeneralQuotes_3");

                entity.HasIndex(e => e.Orden, "IX_AppGeneralQuotes_4");

                entity.HasIndex(e => new { e.IdEstatus, e.Orden }, "IX_AppGeneralQuotes_5");

                entity.HasIndex(e => new { e.IdEstatus, e.Orden, e.TieneOrden }, "IX_AppGeneralQuotes_6");

                entity.Property(e => e.Actualizar).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cancel).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescripcionMunicipio)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Direccion).HasMaxLength(240);

                entity.Property(e => e.Eliminar).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnviarAlCliente).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnviarAprobacionPrecio).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExistQuotes).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaActualiza).HasColumnType("datetime");

                entity.Property(e => e.FechaCaducidad).HasColumnType("datetime");

                entity.Property(e => e.FechaPostergada).HasColumnType("datetime");

                entity.Property(e => e.FijarPrecioBs).HasDefaultValueSql("((0))");

                entity.Property(e => e.GanarPerder).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IdDireccionEntregar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDireccionFacturar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdMtrTipoMoneda).HasDefaultValueSql("((1))");

                entity.Property(e => e.IdMunicipio)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdVendedor)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Imprimir).HasDefaultValueSql("((0))");

                entity.Property(e => e.IntegrarCotizacion).HasDefaultValueSql("((0))");

                entity.Property(e => e.ObservacionPostergar)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Orden).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdenAnterior).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Postergar).HasDefaultValueSql("((0))");

                entity.Property(e => e.Proximo).HasDefaultValueSql("((0))");

                entity.Property(e => e.RazonSocial).HasMaxLength(80);

                entity.Property(e => e.RetornarAgrabacion)
                    .HasColumnName("RetornarAGrabacion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rif)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SearchText)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TieneOrden).HasDefaultValueSql("((0))");

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

                entity.HasOne(d => d.IdContactoNavigation)
                    .WithMany(p => p.AppGeneralQuotes)
                    .HasForeignKey(d => d.IdContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppGeneralQuotes_MtrContactos");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.AppGeneralQuotes)
                    .HasForeignKey(d => d.IdEstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppGeneralQuotes_AppStatusQuote");

                entity.HasOne(d => d.IdMtrTipoMonedaNavigation)
                    .WithMany(p => p.AppGeneralQuotes)
                    .HasForeignKey(d => d.IdMtrTipoMoneda)
                    .HasConstraintName("FK_AppGeneralQuotes_MtrTipoMoneda");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.AppGeneralQuotes)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppGeneralQuotes_MtrVendedor");
            });

            modelBuilder.Entity<AppIngredient>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.HasOne(d => d.PrymaryMtrMoneda)
                    .WithMany(p => p.AppIngredientPrymaryMtrMoneda)
                    .HasForeignKey(d => d.PrymaryMtrMonedaId)
                    .HasConstraintName("FK_AppIngredients_MtrTipoMoneda");

                entity.HasOne(d => d.SecundaryMtrMoneda)
                    .WithMany(p => p.AppIngredientSecundaryMtrMoneda)
                    .HasForeignKey(d => d.SecundaryMtrMonedaId)
                    .HasConstraintName("FK_AppIngredients_MtrTipoMoneda1");
            });

            modelBuilder.Entity<AppOrdenProductoRepeticion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppOrdenProductoRepeticion");

                entity.HasIndex(e => e.IdCliente, "IX_AppOrdenProductoRepeticion");

                entity.HasIndex(e => e.Orden, "IX_AppOrdenProductoRepeticion_1");

                entity.Property(e => e.AppproductsDecription).HasMaxLength(200);

                entity.Property(e => e.BasicaHumano).HasMaxLength(50);

                entity.Property(e => e.CantOrdenada).HasColumnName("CANT_ORDENADA");

                entity.Property(e => e.CantTintas).HasColumnName("Cant_Tintas");

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(12)
                    .HasColumnName("COD_PRODUCTO");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.MedidaBase).HasColumnName("MEDIDA_BASE");

                entity.Property(e => e.MedidaBaseDecimal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MEDIDA_BASE_DECIMAL");

                entity.Property(e => e.MedidaBasicaCm)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MedidaOpuestaCm)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MedidaVariable).HasColumnName("MEDIDA_VARIABLE");

                entity.Property(e => e.MedidaVariableDecimal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MEDIDA_VARIABLE_DECIMAL");

                entity.Property(e => e.NombreCliente).HasMaxLength(500);

                entity.Property(e => e.NombreForma).HasMaxLength(500);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);

                entity.Property(e => e.OpuestaHumano).HasMaxLength(50);

                entity.Property(e => e.Papelcuartaparte)
                    .HasMaxLength(50)
                    .HasColumnName("PAPELCUARTAPARTE");

                entity.Property(e => e.Papelprimeraparte)
                    .HasMaxLength(50)
                    .HasColumnName("PAPELPRIMERAPARTE");

                entity.Property(e => e.Papelquintaparte)
                    .HasMaxLength(50)
                    .HasColumnName("PAPELQUINTAPARTE");

                entity.Property(e => e.Papelsegundaparte)
                    .HasMaxLength(50)
                    .HasColumnName("PAPELSEGUNDAPARTE");

                entity.Property(e => e.Papelterceraparte)
                    .HasMaxLength(50)
                    .HasColumnName("PAPELTERCERAPARTE");

                entity.Property(e => e.PartesFormula).HasColumnName("PARTES_FORMULA");

                entity.Property(e => e.PrecioUnitarioUsd).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.TotalPropuestaUsd).HasColumnType("numeric(20, 4)");
            });

            modelBuilder.Entity<AppPorcentajeAdicionalM2>(entity =>
            {
                entity.ToTable("AppPorcentajeAdicionalM2");

                entity.HasIndex(e => new { e.M2desde, e.M2hasta }, "IX_AppPorcentajeAdicionalM2")
                    .IsUnique();

                entity.Property(e => e.M2desde)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("M2Desde");

                entity.Property(e => e.M2hasta)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("M2Hasta");

                entity.Property(e => e.Porcentaje).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<AppPrecioTemporal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppPrecioTemporal");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdPrecio).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrecioNuevo).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<AppPrice>(entity =>
            {
                entity.ToTable("AppPrice");

                entity.Property(e => e.Desde).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Hasta).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.Appproducts)
                    .WithMany(p => p.AppPrices)
                    .HasForeignKey(d => d.AppproductsId)
                    .HasConstraintName("FK_AppPrice_AppProducts");
            });

            modelBuilder.Entity<AppPrice04042023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppPrice04042023");

                entity.Property(e => e.Desde).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Hasta).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<AppPriceAl08302022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppPriceAl08302022");

                entity.Property(e => e.Desde).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Hasta).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<AppProduct>(entity =>
            {
                entity.HasIndex(e => e.Description1, "IDX_1c12fa4c818762546d1ba59397")
                    .IsUnique();

                entity.HasIndex(e => e.Description2, "IDX_b37f2a37140a932857d2337bdf");

                entity.HasIndex(e => e.Code, "IDX_c5c748798c834681a2e817335d")
                    .IsUnique();

                entity.Property(e => e.CajasProgramadas).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CantidadFija)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantidadMinima)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodAplicacion).HasDefaultValueSql("((0))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Disponible).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Existencia).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExternalCode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Inventariable).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequiereDatosEntrada).HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoCalculo).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UrlImage)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.Property(e => e.ValidadCantidadFija).HasDefaultValueSql("((0))");

                entity.Property(e => e.VariablesSearchText)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.AppSubCategory)
                    .WithMany(p => p.AppProducts)
                    .HasForeignKey(d => d.AppSubCategoryId)
                    .HasConstraintName("FK_AppProducts_AppSubCategory");

                entity.HasOne(d => d.AppUnits)
                    .WithMany(p => p.AppProductAppUnits)
                    .HasForeignKey(d => d.AppUnitsId)
                    .HasConstraintName("FK_AppProducts_AppUnits");

                entity.HasOne(d => d.ProductionUnit)
                    .WithMany(p => p.AppProductProductionUnits)
                    .HasForeignKey(d => d.ProductionUnitId)
                    .HasConstraintName("FK_AppProducts_AppUnits1");

                entity.HasOne(d => d.PrymaryMtrMoneda)
                    .WithMany(p => p.AppProductPrymaryMtrMoneda)
                    .HasForeignKey(d => d.PrymaryMtrMonedaId)
                    .HasConstraintName("FK_AppProducts_MtrTipoMoneda");

                entity.HasOne(d => d.SecundaryMtrMoneda)
                    .WithMany(p => p.AppProductSecundaryMtrMoneda)
                    .HasForeignKey(d => d.SecundaryMtrMonedaId)
                    .HasConstraintName("FK_AppProducts_MtrTipoMoneda1");
            });

            modelBuilder.Entity<AppProductConversion>(entity =>
            {
                entity.ToTable("AppProductConversion");

                entity.Property(e => e.XNumerador)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("X_Numerador");

                entity.Property(e => e.YDenominador)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Y_Denominador");

                entity.HasOne(d => d.AppProducts)
                    .WithMany(p => p.AppProductConversions)
                    .HasForeignKey(d => d.AppProductsId)
                    .HasConstraintName("FK_AppProductConversion_AppProducts");

                entity.HasOne(d => d.AppUnitsIdAlternativaNavigation)
                    .WithMany(p => p.AppProductConversionAppUnitsIdAlternativaNavigations)
                    .HasForeignKey(d => d.AppUnitsIdAlternativa)
                    .HasConstraintName("FK_AppProductConversion_AppUnits");

                entity.HasOne(d => d.AppUnitsIdBaseNavigation)
                    .WithMany(p => p.AppProductConversionAppUnitsIdBaseNavigations)
                    .HasForeignKey(d => d.AppUnitsIdBase)
                    .HasConstraintName("FK_AppProductConversion_AppUnits1");
            });

            modelBuilder.Entity<AppProductVariableSearchText>(entity =>
            {
                entity.ToTable("AppProductVariableSearchText");

                entity.HasIndex(e => new { e.AppVariableId, e.SearchText }, "IX_AppProductVariableSearchText");

                entity.HasIndex(e => e.SearchText, "IX_AppProductVariableSearchText_1");

                entity.HasIndex(e => e.AppProductId, "IX_AppProductVariableSearchText_2");

                entity.Property(e => e.CodeVariable).HasMaxLength(50);

                entity.Property(e => e.SearchText).HasMaxLength(50);

                entity.HasOne(d => d.AppProduct)
                    .WithMany(p => p.AppProductVariableSearchTexts)
                    .HasForeignKey(d => d.AppProductId)
                    .HasConstraintName("FK_AppProductVariableSearchText_AppProducts");

                entity.HasOne(d => d.AppVariable)
                    .WithMany(p => p.AppProductVariableSearchTexts)
                    .HasForeignKey(d => d.AppVariableId)
                    .HasConstraintName("FK_AppProductVariableSearchText_AppVariables");
            });

            modelBuilder.Entity<AppProducts04042023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppProducts04042023");

                entity.Property(e => e.CajasProgramadas).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CantidadFija).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CantidadMinima).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Disponible).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Existencia).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExternalCode).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UrlImage)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.Property(e => e.VariablesSearchText)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<AppRecipe>(entity =>
            {
                entity.HasIndex(e => e.AppproductsId, "IX_AppRecipes");

                entity.HasIndex(e => new { e.AppproductsId, e.AppVariableId }, "IX_AppRecipes_1");

                entity.HasIndex(e => e.Id, "IX_AppRecipes_2");

                entity.Property(e => e.AfectaCosto).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DescriptionSearch).HasMaxLength(4000);

                entity.Property(e => e.EsVariableDeEntrada).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeInSearch).HasDefaultValueSql("((0))");

                entity.Property(e => e.MensajeValidacionFormula)
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderCalculate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.RetornarElMayor).HasDefaultValueSql("((0))");

                entity.Property(e => e.RetornarElMenor).HasDefaultValueSql("((0))");

                entity.Property(e => e.Secuencia).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.TruncarEntero).HasDefaultValueSql("((0))");

                entity.Property(e => e.VariablesSearchText)
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

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

            modelBuilder.Entity<AppRecipes04042023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppRecipes04042023");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DescriptionSearch).HasMaxLength(4000);

                entity.Property(e => e.MensajeValidacionFormula).HasMaxLength(4000);

                entity.Property(e => e.OrderCalculate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.VariablesSearchText).HasMaxLength(4000);
            });

            modelBuilder.Entity<AppRecipesByAppDetailQuote>(entity =>
            {
                entity.HasIndex(e => e.AppproductsId, "IX_AppRecipesByAppDetailQuotes");

                entity.HasIndex(e => new { e.AppproductsId, e.AppVariableId }, "IX_AppRecipesByAppDetailQuotes_1");

                entity.HasIndex(e => new { e.CalculoId, e.AppproductsId, e.Code }, "IX_AppRecipesByAppDetailQuotes_2");

                entity.HasIndex(e => e.CalculoId, "IX_AppRecipesByAppDetailQuotes_3");

                entity.HasIndex(e => new { e.CalculoId, e.Code }, "IX_AppRecipesByAppDetailQuotes_4");

                entity.Property(e => e.AfectaCosto).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EsVariableDeEntrada).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeInSearch).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderCalculate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Secuencia).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TruncarEntero).HasDefaultValueSql("((0))");

                entity.Property(e => e.VariablesSearchText)
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.AppIngredients)
                    .WithMany(p => p.AppRecipesByAppDetailQuotes)
                    .HasForeignKey(d => d.AppIngredientsId)
                    .HasConstraintName("FK_AppRecipesByAppDetailQuotes_AppIngredients");

                entity.HasOne(d => d.AppVariable)
                    .WithMany(p => p.AppRecipesByAppDetailQuotes)
                    .HasForeignKey(d => d.AppVariableId)
                    .HasConstraintName("FK_AppRecipesByAppDetailQuotes_AppVariables");

                entity.HasOne(d => d.Appproducts)
                    .WithMany(p => p.AppRecipesByAppDetailQuotes)
                    .HasForeignKey(d => d.AppproductsId)
                    .HasConstraintName("FK_AppRecipesByAppDetailQuotes_AppProducts");
            });

            modelBuilder.Entity<AppRecipesByAppDetailQuotesHistory>(entity =>
            {
                entity.ToTable("AppRecipesByAppDetailQuotesHistory");

                entity.HasIndex(e => e.CalculoId, "IX_AppRecipesByAppDetailQuotesHistory");

                entity.HasIndex(e => new { e.CalculoId, e.Code }, "IX_AppRecipesByAppDetailQuotesHistory_1");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.OrderCalculate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VariablesSearchText).HasMaxLength(4000);
            });

            modelBuilder.Entity<AppRepeticionClienteBasica>(entity =>
            {
                entity.ToTable("AppRepeticionClienteBasica");

                entity.Property(e => e.BasicaHumano).HasMaxLength(200);

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.NombreForma).HasMaxLength(200);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);
            });

            modelBuilder.Entity<AppRepeticionClienteNombreForma>(entity =>
            {
                entity.ToTable("AppRepeticionClienteNombreForma");

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.NombreForma).HasMaxLength(200);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);
            });

            modelBuilder.Entity<AppRepeticionClienteOpuestum>(entity =>
            {
                entity.Property(e => e.BasicaHumano).HasMaxLength(200);

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.NombreForma).HasMaxLength(200);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);

                entity.Property(e => e.OpuestaHumano).HasMaxLength(200);
            });

            modelBuilder.Entity<AppRepeticionClientePapelCuartaParte>(entity =>
            {
                entity.ToTable("AppRepeticionClientePapelCuartaParte");

                entity.Property(e => e.BasicaHumano).HasMaxLength(200);

                entity.Property(e => e.CantTintas).HasColumnName("Cant_Tintas");

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.NombreForma).HasMaxLength(200);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);

                entity.Property(e => e.OpuestaHumano).HasMaxLength(200);

                entity.Property(e => e.Papelcuartaparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELCUARTAPARTE");

                entity.Property(e => e.Papelprimeraparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELPRIMERAPARTE");

                entity.Property(e => e.Papelsegundaparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELSEGUNDAPARTE");

                entity.Property(e => e.Papelterceraparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELTERCERAPARTE");

                entity.Property(e => e.PartesFormula).HasColumnName("partes_formula");
            });

            modelBuilder.Entity<AppRepeticionClientePapelPrimeraParte>(entity =>
            {
                entity.ToTable("AppRepeticionClientePapelPrimeraParte");

                entity.Property(e => e.BasicaHumano).HasMaxLength(200);

                entity.Property(e => e.CantTintas).HasColumnName("Cant_Tintas");

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.NombreForma).HasMaxLength(200);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);

                entity.Property(e => e.OpuestaHumano).HasMaxLength(200);

                entity.Property(e => e.Papelprimeraparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELPRIMERAPARTE");

                entity.Property(e => e.PartesFormula).HasColumnName("partes_formula");
            });

            modelBuilder.Entity<AppRepeticionClientePapelQuintaParte>(entity =>
            {
                entity.ToTable("AppRepeticionClientePapelQuintaParte");

                entity.Property(e => e.BasicaHumano).HasMaxLength(200);

                entity.Property(e => e.CantTintas).HasColumnName("Cant_Tintas");

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.NombreForma).HasMaxLength(200);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);

                entity.Property(e => e.OpuestaHumano).HasMaxLength(200);

                entity.Property(e => e.Papelcuartaparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELCUARTAPARTE");

                entity.Property(e => e.Papelprimeraparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELPRIMERAPARTE");

                entity.Property(e => e.Papelquintaparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELQUINTAPARTE");

                entity.Property(e => e.Papelsegundaparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELSEGUNDAPARTE");

                entity.Property(e => e.Papelterceraparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELTERCERAPARTE");

                entity.Property(e => e.PartesFormula).HasColumnName("partes_formula");
            });

            modelBuilder.Entity<AppRepeticionClientePapelSegundaParte>(entity =>
            {
                entity.ToTable("AppRepeticionClientePapelSegundaParte");

                entity.Property(e => e.BasicaHumano).HasMaxLength(200);

                entity.Property(e => e.CantTintas).HasColumnName("Cant_Tintas");

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.NombreForma).HasMaxLength(200);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);

                entity.Property(e => e.OpuestaHumano).HasMaxLength(200);

                entity.Property(e => e.Papelprimeraparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELPRIMERAPARTE");

                entity.Property(e => e.Papelsegundaparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELSEGUNDAPARTE");

                entity.Property(e => e.PartesFormula).HasColumnName("partes_formula");
            });

            modelBuilder.Entity<AppRepeticionClientePapelTerceraParte>(entity =>
            {
                entity.ToTable("AppRepeticionClientePapelTerceraParte");

                entity.Property(e => e.BasicaHumano).HasMaxLength(200);

                entity.Property(e => e.CantTintas).HasColumnName("Cant_Tintas");

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.NombreForma).HasMaxLength(200);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);

                entity.Property(e => e.OpuestaHumano).HasMaxLength(200);

                entity.Property(e => e.Papelprimeraparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELPRIMERAPARTE");

                entity.Property(e => e.Papelsegundaparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELSEGUNDAPARTE");

                entity.Property(e => e.Papelterceraparte)
                    .HasMaxLength(200)
                    .HasColumnName("PAPELTERCERAPARTE");

                entity.Property(e => e.PartesFormula).HasColumnName("partes_formula");
            });

            modelBuilder.Entity<AppRepeticionClienteParte>(entity =>
            {
                entity.Property(e => e.BasicaHumano).HasMaxLength(200);

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.NombreForma).HasMaxLength(200);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);

                entity.Property(e => e.OpuestaHumano).HasMaxLength(200);

                entity.Property(e => e.PartesFormula).HasColumnName("partes_formula");
            });

            modelBuilder.Entity<AppRepeticionClienteProducto>(entity =>
            {
                entity.ToTable("AppRepeticionClienteProducto");

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);
            });

            modelBuilder.Entity<AppRepeticionClienteTinta>(entity =>
            {
                entity.Property(e => e.BasicaHumano).HasMaxLength(200);

                entity.Property(e => e.CantTintas).HasColumnName("Cant_Tintas");

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.NombreForma).HasMaxLength(200);

                entity.Property(e => e.NombreProducto).HasMaxLength(200);

                entity.Property(e => e.OpuestaHumano).HasMaxLength(200);

                entity.Property(e => e.PartesFormula).HasColumnName("partes_formula");
            });

            modelBuilder.Entity<AppStatusQuote>(entity =>
            {
                entity.ToTable("AppStatusQuote");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Abreviado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ClaseCss)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CondicionRazonId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlagActiva)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Activa");

                entity.Property(e => e.FlagCaducaInactiva)
                    .HasMaxLength(1)
                    .HasColumnName("Flag_CaducaInactiva")
                    .IsFixedLength();

                entity.Property(e => e.FlagCaducada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Caducada");

                entity.Property(e => e.FlagEnEspera)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Flag_EnEspera");

                entity.Property(e => e.FlagGanada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Ganada");

                entity.Property(e => e.FlagModificar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Modificar");

                entity.Property(e => e.FlagPerdida)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Perdida");

                entity.Property(e => e.FlagPostergada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Postergada");

                entity.Property(e => e.OdooStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimeraEstacion).HasMaxLength(1);
            });

            modelBuilder.Entity<AppSubCategory>(entity =>
            {
                entity.ToTable("AppSubCategory");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AppCategory)
                    .WithMany(p => p.AppSubCategories)
                    .HasForeignKey(d => d.AppCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppSubCategory_AppCategory");
            });

            modelBuilder.Entity<AppTemplateConversionUnit>(entity =>
            {
                entity.ToTable("AppTemplateConversionUnit");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Formula).HasDefaultValueSql("('')");

                entity.Property(e => e.FormulaValue).HasDefaultValueSql("('')");

                entity.Property(e => e.Max).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Min).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.OrderCalculate).HasDefaultValueSql("((0))");

                entity.Property(e => e.SumValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.AppUnitIdSinceNavigation)
                    .WithMany(p => p.AppTemplateConversionUnitAppUnitIdSinceNavigations)
                    .HasForeignKey(d => d.AppUnitIdSince)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppTemplateConversionUnit_AppUnits");

                entity.HasOne(d => d.AppUnitIdUntilNavigation)
                    .WithMany(p => p.AppTemplateConversionUnitAppUnitIdUntilNavigations)
                    .HasForeignKey(d => d.AppUnitIdUntil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppTemplateConversionUnit_AppUnits1");

                entity.HasOne(d => d.AppVariable)
                    .WithMany(p => p.AppTemplateConversionUnits)
                    .HasForeignKey(d => d.AppVariableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppTemplateConversionUnit_AppVariables");
            });

            modelBuilder.Entity<AppTituloVariable>(entity =>
            {
                entity.ToTable("AppTituloVariable");

                entity.Property(e => e.CodeVariable).HasMaxLength(50);

                entity.Property(e => e.Titulo).HasMaxLength(100);
            });

            modelBuilder.Entity<AppUnit>(entity =>
            {
                entity.HasIndex(e => e.Code, "IX_AppUnits");

                entity.HasIndex(e => e.Description1, "IX_AppUnits_1");

                entity.HasIndex(e => e.Description2, "IX_AppUnits_2");

                entity.HasIndex(e => e.Description3, "IX_AppUnits_3");

                entity.HasIndex(e => e.Description4, "IX_AppUnits_4");

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

                entity.Property(e => e.UserCreate).HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);
            });

            modelBuilder.Entity<AppUnitsofMeasureforIngredient>(entity =>
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

            modelBuilder.Entity<AppUnitsofMeasureforMaterial>(entity =>
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

            modelBuilder.Entity<AppVariable>(entity =>
            {
                entity.HasIndex(e => e.Code, "IDX_fa6816ce90cf44a526144256df");

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

            modelBuilder.Entity<AppVariableSearch>(entity =>
            {
                entity.ToTable("AppVariableSearch");

                entity.Property(e => e.SearchText).HasMaxLength(50);

                entity.HasOne(d => d.AppSubCategory)
                    .WithMany(p => p.AppVariableSearches)
                    .HasForeignKey(d => d.AppSubCategoryId)
                    .HasConstraintName("FK_AppVariableSearch_AppSubCategory");

                entity.HasOne(d => d.AppVariable)
                    .WithMany(p => p.AppVariableSearches)
                    .HasForeignKey(d => d.AppVariableId)
                    .HasConstraintName("FK_AppVariableSearch_AppVariables");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_RoleId");

                            j.HasIndex(new[] { "UserId" }, "IX_UserId");

                            j.IndexerProperty<string>("UserId").HasMaxLength(128);

                            j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Audit");

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
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PK");

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

                entity.ToTable("AutoAudit");

                entity.HasIndex(e => new { e.TableName, e.AuditDate }, "idx_AutoAudit_TableName_AuditDate");

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
                    .ValueGeneratedNever()
                    .HasColumnName("NOTA_CREDITO");

                entity.Property(e => e.AfectaFactura)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AFECTA_FACTURA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AfectaNota)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AFECTA_NOTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Batch)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("BATCH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantResumen)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("CANT_RESUMEN");

                entity.Property(e => e.CantRevive)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("CANT_REVIVE");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.ColetillaInd1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COLETILLA_IND1");

                entity.Property(e => e.ColetillaInd2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COLETILLA_IND2");

                entity.Property(e => e.ColetillaInd3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COLETILLA_IND3");

                entity.Property(e => e.ColetillaInd4)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COLETILLA_IND4");

                entity.Property(e => e.Contrapartida)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CONTRAPARTIDA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CuentaContable)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("CUENTA_CONTABLE");

                entity.Property(e => e.DescResumen1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_RESUMEN1");

                entity.Property(e => e.DescResumen2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_RESUMEN2");

                entity.Property(e => e.Direccion1)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion2)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Direccion3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION3");

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.Factura).HasColumnName("FACTURA");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA");

                entity.Property(e => e.FlagAfecVende)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_AFEC_VENDE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagComision)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_COMISION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImpreso)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_IMPRESO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ImpPorConsumo)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("IMP_POR_CONSUMO");

                entity.Property(e => e.ImpSobVentas)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("IMP_SOB_VENTAS");

                entity.Property(e => e.Impuesto)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("IMPUESTO");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("IMPUESTO_DOL");

                entity.Property(e => e.Iq).HasColumnName("IQ");

                entity.Property(e => e.Ir).HasColumnName("IR");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.Motivo).HasColumnName("MOTIVO");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroControl).HasColumnName("NRO_CONTROL");

                entity.Property(e => e.Nula)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NULA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ObsCobranzas1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("OBS_COBRANZAS1");

                entity.Property(e => e.ObsCobranzas2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("OBS_COBRANZAS2");

                entity.Property(e => e.ObsCobranzas3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("OBS_COBRANZAS3");

                entity.Property(e => e.ObsCobranzas4)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("OBS_COBRANZAS4");

                entity.Property(e => e.Observacion1)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PorcConcesion)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("PORC_CONCESION");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSABLE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ReviveJob)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REVIVE_JOB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("RIF")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rif2)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("RIF2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RimpPorConsum)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("RIMP_POR_CONSUM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RimpSobVentas)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("RIMP_SOB_VENTAS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rimpuesto)
                    .HasColumnType("decimal(14, 4)")
                    .HasColumnName("RIMPUESTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rvalor)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("RVALOR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaImpuesto)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("TASA_IMPUESTO");

                entity.Property(e => e.TipoCambio)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("TIPO_CAMBIO");

                entity.Property(e => e.TipoDoc).HasColumnName("TIPO_DOC");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UndResumen)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UND_RESUMEN");

                entity.Property(e => e.UnidadFacturar).HasColumnName("UNIDAD_FACTURAR");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("VALOR");

                entity.Property(e => e.Valor1)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("VALOR_$");

                entity.Property(e => e.ValorLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_LISTA");

                entity.Property(e => e.ValorListad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_LISTAD");

                entity.Property(e => e.ValorVentad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_VENTAD");

                entity.Property(e => e.Valorfactura)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALORFACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Cary029>(entity =>
            {
                entity.HasKey(e => new { e.NumeroNota, e.Recnum })
                    .HasName("CARY029_INDEX01");

                entity.ToTable("CARY029");

                entity.Property(e => e.NumeroNota).HasColumnName("NUMERO_NOTA");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Almacen)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ALMACEN");

                entity.Property(e => e.Batch)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("BATCH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPELSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("CANTIDAD");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("COMISION");

                entity.Property(e => e.Copy)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("COPY");

                entity.Property(e => e.Costo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CtaConc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CTA_CONC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtaLista)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CTA_LISTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION2");

                entity.Property(e => e.Estadisticas)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTADISTICAS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Exento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXENTO");

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaNota)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_NOTA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN");

                entity.Property(e => e.FormasUnidad)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("FORMAS_UNIDAD");

                entity.Property(e => e.IdSolicitudCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCostoCpj)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IdSolicitudCosto_CPJ");

                entity.Property(e => e.Idsolicitud)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("idsolicitud")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpPorConsumo)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("IMP_POR_CONSUMO");

                entity.Property(e => e.ImpSobVentas)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("IMP_SOB_VENTAS");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("IMPUESTO_DOL");

                entity.Property(e => e.Iva)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("IVA");

                entity.Property(e => e.Ivarefact)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IVAREFACT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobId)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaUniDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_UNI_DOL");

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("METODO_PRECIO1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Millares)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MILLARES");

                entity.Property(e => e.Orden)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PARTES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pieslineales)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PIESLINEALES");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("PORC_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.Preciounidad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIOUNIDAD");

                entity.Property(e => e.RecalcularMargen).HasMaxLength(1);

                entity.Property(e => e.RimpPorConsum)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("RIMP_POR_CONSUM");

                entity.Property(e => e.RimpSobVentas)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("RIMP_SOB_VENTAS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Riva)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("RIVA");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("RPRECIO_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpreciounidad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOUNIDAD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("RVALOR_LISTA");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("RVALOR_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoCambio)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("TIPO_CAMBIO");

                entity.Property(e => e.TipoDoc).HasColumnName("TIPO_DOC");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalparcialFa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TOTALPARCIAL_FA");

                entity.Property(e => e.UnidadFacturar)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD_FACTURAR");

                entity.Property(e => e.Unidadesfact)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("UNIDADESFACT");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("VALOR_$");

                entity.Property(e => e.ValorLista)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("VALOR_LISTA");

                entity.Property(e => e.ValorListad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_LISTAD");

                entity.Property(e => e.ValorVenta)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("VALOR_VENTA");

                entity.Property(e => e.ValorVentaCpj)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_VENTA_CPJ");

                entity.Property(e => e.ValorVentad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_VENTAD");

                entity.Property(e => e.VentaUniDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_UNI_DOL");
            });

            modelBuilder.Entity<CatAuditoriaCalculo>(entity =>
            {
                entity.ToTable("CatAuditoriaCalculo");

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

            modelBuilder.Entity<CatCalibrePapelRollo>(entity =>
            {
                entity.HasKey(e => e.CatCalibrePapelRollosId);

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
                    .HasMaxLength(50)
                    .HasColumnName("Codigo_Mayor");

                entity.Property(e => e.Frecuencia).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<CatListum>(entity =>
            {
                entity.HasKey(e => e.CatListaId)
                    .HasName("PK_dbo.Cat_Lista");

                entity.ToTable("Cat_Lista");

                entity.Property(e => e.CatListaId).HasColumnName("Cat_ListaId");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("CODIGO_PRODUCT");

                entity.Property(e => e.Descripcion).HasMaxLength(400);

                entity.Property(e => e.Duracion).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IdCalculo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IncrementoCantidad).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioMaximo)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Precio_Maximo");

                entity.Property(e => e.PrecioMinimo)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Precio_Minimo");

                entity.HasOne(d => d.CatMaterial)
                    .WithMany(p => p.CatLista)
                    .HasForeignKey(d => d.CatMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cat_Lista_CatMaterial");

                entity.HasOne(d => d.CodigoProductNavigation)
                    .WithMany(p => p.CatLista)
                    .HasForeignKey(d => d.CodigoProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cat_Lista_MtrProducto");
            });

            modelBuilder.Entity<CatMaterial>(entity =>
            {
                entity.ToTable("CatMaterial");

                entity.HasIndex(e => e.Codigo, "CatMaterial_Codigo_Index")
                    .IsUnique();

                entity.HasIndex(e => new { e.CatProductoMayorId, e.CatProductoMayorPartesId, e.CatProductoMayorPartesTintasId, e.CatProductoMayorPartesTintasBasicaId, e.CatProductoMayorPartesTintasBasicaOpuestaId, e.CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbonId, e.CatProductoMayorPartesTintasBasicaOpuestaPapelesId }, "IX_CatMaterial");

                entity.HasIndex(e => new { e.CodigoProduct, e.Partes, e.Tintas, e.BasicaBusqueda, e.OpuestaBusqueda, e.PapelesBusqueda, e.CarbonBusqueda }, "IX_CatMaterial_1")
                    .IsUnique();

                entity.HasIndex(e => e.CatMedidaBasicaId, "IX_CatMedidaBasicaId");

                entity.Property(e => e.BasicaBusqueda).HasMaxLength(10);

                entity.Property(e => e.BasicaDecimal)
                    .HasColumnType("numeric(18, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CalibrePapelRollos).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.CarbonBusqueda).HasMaxLength(100);

                entity.Property(e => e.Codigo).HasMaxLength(12);

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("CODIGO_PRODUCT");

                entity.Property(e => e.Combinacion).HasMaxLength(400);

                entity.Property(e => e.Descripcion).HasMaxLength(400);

                entity.Property(e => e.ManejaInv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MANEJA_INV");

                entity.Property(e => e.OpuestaBusqueda).HasMaxLength(100);

                entity.Property(e => e.PapelesBusqueda).HasMaxLength(200);

                entity.HasOne(d => d.CatMedidaBasica)
                    .WithMany(p => p.CatMaterials)
                    .HasForeignKey(d => d.CatMedidaBasicaId)
                    .HasConstraintName("FK_dbo.CatMaterial_dbo.CatMedidaBasica_CatMedidaBasicaId");

                entity.HasOne(d => d.CodigoProductNavigation)
                    .WithMany(p => p.CatMaterials)
                    .HasForeignKey(d => d.CodigoProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatMaterial_MtrProducto");
            });

            modelBuilder.Entity<CatMaterialDetalle>(entity =>
            {
                entity.ToTable("CatMaterialDetalle");

                entity.HasIndex(e => e.CatMaterialId, "IX_CatMaterialId");

                entity.HasIndex(e => e.CatMedidaOpuestaId, "IX_CatMedidaOpuestaId");

                entity.HasOne(d => d.CatMaterial)
                    .WithMany(p => p.CatMaterialDetalles)
                    .HasForeignKey(d => d.CatMaterialId)
                    .HasConstraintName("FK_dbo.CatMaterialDetalle_dbo.CatMaterial_CatMaterialId");

                entity.HasOne(d => d.CatMedidaOpuesta)
                    .WithMany(p => p.CatMaterialDetalles)
                    .HasForeignKey(d => d.CatMedidaOpuestaId)
                    .HasConstraintName("FK_dbo.CatMaterialDetalle_dbo.CatMedidaOpuesta_CatMedidaOpuestaId");
            });

            modelBuilder.Entity<CatMaterialDetalleTmp>(entity =>
            {
                entity.ToTable("CatMaterialDetalleTmp");

                entity.HasIndex(e => e.CatMedidaOpuestaId, "IX_CatMedidaOpuestaId");

                entity.HasIndex(e => e.CatPapelId, "IX_CatPapelId");

                entity.Property(e => e.CatPapelId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CatMedidaOpuesta)
                    .WithMany(p => p.CatMaterialDetalleTmps)
                    .HasForeignKey(d => d.CatMedidaOpuestaId)
                    .HasConstraintName("FK_dbo.CatMaterialDetalleTmp_dbo.CatMedidaOpuesta_CatMedidaOpuestaId");

                entity.HasOne(d => d.CatPapel)
                    .WithMany(p => p.CatMaterialDetalleTmps)
                    .HasForeignKey(d => d.CatPapelId)
                    .HasConstraintName("FK_dbo.CatMaterialDetalleTmp_dbo.CatPapel_CatPapelId");
            });

            modelBuilder.Entity<CatMedidaBasica>(entity =>
            {
                entity.HasKey(e => e.Medida);

                entity.ToTable("Cat_MedidaBasica");

                entity.Property(e => e.Medida)
                    .HasMaxLength(50)
                    .HasColumnName("MEDIDA");

                entity.Property(e => e.MedidaIn)
                    .HasMaxLength(10)
                    .HasColumnName("MEDIDA_IN");

                entity.Property(e => e.MedidaMm)
                    .HasMaxLength(10)
                    .HasColumnName("MEDIDA_MM");
            });

            modelBuilder.Entity<CatMedidaBasica1>(entity =>
            {
                entity.HasKey(e => e.CatMedidaBasicaId)
                    .HasName("PK_dbo.CatMedidaBasica");

                entity.ToTable("CatMedidaBasica");

                entity.HasIndex(e => e.MedidaBusqueda, "CatMedidaBasica_MedidaBusqueda_Index");

                entity.HasIndex(e => e.MedidaString, "CatMedidaBasica_MedidaString_Index")
                    .IsUnique();

                entity.Property(e => e.MedidaBusqueda)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.MedidaDecimal).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.MedidaString)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<CatMedidaBasicaRollo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cat_MedidaBasicaRollos");

                entity.Property(e => e.CatMedidaBasicaRollosId).HasColumnName("Cat_MedidaBasicaRollosId");

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MEDIDA");

                entity.Property(e => e.MedidaIn)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MEDIDA_IN");

                entity.Property(e => e.MedidaMm)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MEDIDA_MM");
            });

            modelBuilder.Entity<CatMedidaOpuestum>(entity =>
            {
                entity.HasKey(e => e.CatMedidaOpuestaId)
                    .HasName("PK_dbo.CatMedidaOpuesta");

                entity.HasIndex(e => e.MedidaBusqueda, "CatMedidaOpuesta_MedidaBusqueda_Index");

                entity.HasIndex(e => e.MedidaString, "CatMedidaOpuesta_MedidaString_Index")
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
                entity.ToTable("CatPapel");

                entity.Property(e => e.CatPapelId).HasMaxLength(20);

                entity.Property(e => e.Descripcion).HasMaxLength(256);
            });

            modelBuilder.Entity<CatProductoMayor>(entity =>
            {
                entity.ToTable("CatProductoMayor");

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("CODIGO_PRODUCT");

                entity.Property(e => e.Descripcion).HasMaxLength(400);

                entity.Property(e => e.Inactivo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CatProductoMayorParte>(entity =>
            {
                entity.HasKey(e => e.CatProductoMayorPartesId)
                    .HasName("PK_dbo.CatProductoMayorPartes");

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("CODIGO_PRODUCT");
            });

            modelBuilder.Entity<CatProductoMayorPartesTinta>(entity =>
            {
                entity.HasKey(e => e.CatProductoMayorPartesTintasId)
                    .HasName("PK_dbo.CatProductoMayorPartesTintas");

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("CODIGO_PRODUCT");
            });

            modelBuilder.Entity<CatProductoMayorPartesTintasBasica>(entity =>
            {
                entity.ToTable("CatProductoMayorPartesTintasBasica");

                entity.Property(e => e.BasicaBusqueda).HasMaxLength(100);

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("CODIGO_PRODUCT");
            });

            modelBuilder.Entity<CatProductoMayorPartesTintasBasicaOpuestaPapele>(entity =>
            {
                entity.HasKey(e => e.CatProductoMayorPartesTintasBasicaOpuestaPapelesId)
                    .HasName("PK_dbo.CatProductoMayorPartesTintasBasicaOpuestaPapeles");

                entity.Property(e => e.BasicaBusqueda).HasMaxLength(100);

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("CODIGO_PRODUCT");

                entity.Property(e => e.OpuestaBusqueda).HasMaxLength(100);

                entity.Property(e => e.PapelesBusqueda).HasMaxLength(100);
            });

            modelBuilder.Entity<CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon>(entity =>
            {
                entity.ToTable("CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon");

                entity.Property(e => e.BasicaBusqueda).HasMaxLength(100);

                entity.Property(e => e.CarbonBusqueda).HasMaxLength(100);

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("CODIGO_PRODUCT");

                entity.Property(e => e.OpuestaBusqueda).HasMaxLength(100);

                entity.Property(e => e.PapelesBusqueda).HasMaxLength(100);
            });

            modelBuilder.Entity<CatProductoMayorPartesTintasBasicaOpuestum>(entity =>
            {
                entity.HasKey(e => e.CatProductoMayorPartesTintasBasicaOpuestaId)
                    .HasName("PK_dbo.CatProductoMayorPartesTintasBasicaOpuesta");

                entity.Property(e => e.BasicaBusqueda).HasMaxLength(100);

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("CODIGO_PRODUCT");

                entity.Property(e => e.OpuestaBusqueda).HasMaxLength(100);
            });

            modelBuilder.Entity<CatProductoMayorUnidadesConversion>(entity =>
            {
                entity.ToTable("CatProductoMayorUnidadesConversion");

                entity.Property(e => e.Calculado).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoProduct)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("CODIGO_PRODUCT");

                entity.Property(e => e.Msehi)
                    .HasMaxLength(18)
                    .HasColumnName("MSEHI");

                entity.Property(e => e.Msehl)
                    .HasMaxLength(18)
                    .HasColumnName("MSEHL");

                entity.Property(e => e.Umren)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("UMREN");

                entity.Property(e => e.Umrez)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("UMREZ");

                entity.Property(e => e.UnidadsapVentainterna)
                    .HasMaxLength(3)
                    .HasColumnName("UNIDADSAP_VENTAINTERNA");

                entity.HasOne(d => d.CodigoProductNavigation)
                    .WithMany(p => p.CatProductoMayorUnidadesConversions)
                    .HasForeignKey(d => d.CodigoProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatProductoMayorUnidadesConversion_MtrProducto");
            });

            modelBuilder.Entity<CatSubCategorium>(entity =>
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

            modelBuilder.Entity<ChildMenu>(entity =>
            {
                entity.ToTable("ChildMenu");

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .HasColumnName("icon");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);
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
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Batch)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("BATCH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cajas)
                    .HasColumnName("CAJAS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantResumen)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("CANT_RESUMEN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClienteJde)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE_JDE");

                entity.Property(e => e.CodigoRepetici)
                    .HasColumnName("CODIGO_REPETICI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ColetillaInd1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COLETILLA_IND1");

                entity.Property(e => e.ColetillaInd2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COLETILLA_IND2");

                entity.Property(e => e.ColetillaInd3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COLETILLA_IND3");

                entity.Property(e => e.ColetillaInd4)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COLETILLA_IND4");

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
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CRED_CONTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dciudad)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DCIUDAD");

                entity.Property(e => e.DescResumen1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_RESUMEN1");

                entity.Property(e => e.DescResumen2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_RESUMEN2");

                entity.Property(e => e.Destado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DESTADO");

                entity.Property(e => e.DireccFiscal)
                    .HasColumnType("text")
                    .HasColumnName("DIRECC_FISCAL");

                entity.Property(e => e.DireccionEmb1)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_EMB1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_EMB2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_EMB3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact1)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACT1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACT2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACT3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DocumentoSap).HasMaxLength(10);

                entity.Property(e => e.Dolar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOLAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.FactAdelantada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FACT_ADELANTADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FactFinal)
                    .HasColumnName("FACT_FINAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FacturaRepetir)
                    .HasColumnName("FACTURA_REPETIR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAnulada)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ANULADA");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DESPACHO")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaRecibCli)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RECIB_CLI")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.Field98)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FIELD98");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagComision)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_COMISION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagGeneroPdf)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagImpreso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_IMPRESO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Flete)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("FLETE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDireccion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Imp)
                    .HasColumnName("IMP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImpStock)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_STOCK")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("IMPUESTO_DOL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobId)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.LineaAnt)
                    .HasColumnName("LINEA_ANT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MesFactura)
                    .HasColumnName("MES_FACTURA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Miscelaneo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MISCELANEO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MultiplesEmb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MULTIPLES_EMB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MUNICIPIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NcFacturar)
                    .HasColumnName("NC_FACTURAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NitEmb)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NIT_EMB")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NitFact)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NIT_FACT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreEmb)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_EMB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreFact)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_FACT")
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
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("OBS_COBRANZAS1");

                entity.Property(e => e.ObsCobranzas2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("OBS_COBRANZAS2");

                entity.Property(e => e.ObsCobranzas3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("OBS_COBRANZAS3");

                entity.Property(e => e.ObsCobranzas4)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("OBS_COBRANZAS4");

                entity.Property(e => e.Observacion1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .HasMaxLength(79)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdenCompra)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_COMPRA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OtroGasto1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OTRO_GASTO_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtroGasto2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OTRO_GASTO_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pais)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pltyp)
                    .HasMaxLength(2)
                    .HasColumnName("PLTYP");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RegistroTribut)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REGISTRO_TRIBUT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifEmb)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_EMB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_FACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RotroGasto1)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("ROTRO_GASTO_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RsdoAnticipo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RSDO_ANTICIPO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SdoAnticipo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("SDO_ANTICIPO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SdoAnticipoDo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("SDO_ANTICIPO_DO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Seguro)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("SEGURO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TasaAnticipo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TASA_ANTICIPO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TasaImpuesto)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("TASA_IMPUESTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoCambio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TIPO_CAMBIO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalParcial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Transmision)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANSMISION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UndResumen)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UND_RESUMEN");

                entity.Property(e => e.UnidadFacturar)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");

                entity.Property(e => e.ValorLista)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorListad)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR_LISTAD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorVentad)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR_VENTAD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VendGestion)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VEND_GESTION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
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
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Almacen)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ALMACEN");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ARTICULO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Batch)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("BATCH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPELSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bsmc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BSMC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BultoDesp)
                    .HasColumnName("BULTO_DESP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BultoTran)
                    .HasColumnName("BULTO_TRAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bultos).HasColumnName("BULTOS");

                entity.Property(e => e.CantEntregar)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("CANT_ENTREGAR");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("CANTIDAD");

                entity.Property(e => e.Copy)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("COPY");

                entity.Property(e => e.Costo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CtaConc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CTA_CONC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CtaLista)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CTA_LISTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Descripcion2)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb)
                    .HasColumnType("text")
                    .HasColumnName("DIRECCION_EMB");

                entity.Property(e => e.DireccionFact)
                    .HasColumnType("text")
                    .HasColumnName("DIRECCION_FACT");

                entity.Property(e => e.Estadisticas)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTADISTICAS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FamiliaProducc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA_PRODUCC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FecComproClte)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_COMPRO_CLTE");

                entity.Property(e => e.FecRecPlaneac)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REC_PLANEAC");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORDEN");

                entity.Property(e => e.FechaProg)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PROG");

                entity.Property(e => e.FlagFaltante)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FALTANTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagImprenta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_IMPRENTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetenido)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETENIDO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoJob)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_TIPO_JOB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagTipoOrden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_TIPO_ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FormasBajotiro).HasColumnName("FORMAS_BAJOTIRO");

                entity.Property(e => e.FormasUnidad)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("FORMAS_UNIDAD");

                entity.Property(e => e.GeneraDespacho)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENERA_DESPACHO");

                entity.Property(e => e.IdPrelista).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSolicitud)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSolicitudCosto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitudCostoCpj)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IdSolicitudCosto_CPJ");

                entity.Property(e => e.ImpStock)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_STOCK");

                entity.Property(e => e.Impuesto1)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("IMPUESTO_1");

                entity.Property(e => e.Impuesto2)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("IMPUESTO_2");

                entity.Property(e => e.ImpuestoDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("IMPUESTO_DOL");

                entity.Property(e => e.Iva)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IVA");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.KiloBulto)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("KILO_BULTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaProduccio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCCIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lipamepa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LIPAMEPA")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.ListaUniDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_UNI_DOL");

                entity.Property(e => e.MetodoCalculo).HasDefaultValueSql("((0))");

                entity.Property(e => e.MetodoPrecio1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("METODO_PRECIO1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Millares)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MILLARES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NoEntrega).HasColumnName("NO_ENTREGA");

                entity.Property(e => e.NombreEmb)
                    .HasColumnType("text")
                    .HasColumnName("NOMBRE_EMB");

                entity.Property(e => e.NombreFact)
                    .HasColumnType("text")
                    .HasColumnName("NOMBRE_FACT");

                entity.Property(e => e.NumCliDesde)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUM_CLI_DESDE");

                entity.Property(e => e.NumCliDesdeE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUM_CLI_DESDE_E");

                entity.Property(e => e.NumCliHasta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUM_CLI_HASTA");

                entity.Property(e => e.NumCliHastaE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUM_CLI_HASTA_E");

                entity.Property(e => e.NumeroDesde)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_DESDE");

                entity.Property(e => e.NumeroDesdeE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_DESDE_E");

                entity.Property(e => e.NumeroHasta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_HASTA");

                entity.Property(e => e.NumeroHastaE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_HASTA_E");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAIS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Partes)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PARTES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pieslineales)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PIESLINEALES");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PORC_MC_FINAN");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PORC_MC_FINANSC");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PORC_MC_PAPEL");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PORC_MC_PAPELSC");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(16, 6)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.Preciounidad)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("PRECIOUNIDAD");

                entity.Property(e => e.PrefijoCli)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO_CLI");

                entity.Property(e => e.PrefijoCliE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO_CLI_E");

                entity.Property(e => e.PrefijoDesde)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO_DESDE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoDesdeE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO_DESDE_E");

                entity.Property(e => e.PrefijoHasta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO_HASTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PrefijoHastaE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO_HASTA_E");

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPELSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rbsmc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBSMC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecalcularMargen)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegistroTribut)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REGISTRO_TRIBUT");

                entity.Property(e => e.RemisionOfi)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("REMISION_OFI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportadoSeniat).HasMaxLength(1);

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_EMB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_FACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rimpuesto1)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RIMPUESTO_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpreciounidad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOUNIDAD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVALOR_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SufijoCli)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO_CLI");

                entity.Property(e => e.SufijoCliE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO_CLI_E");

                entity.Property(e => e.SufijoDesde)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO_DESDE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoDesdeE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO_DESDE_E");

                entity.Property(e => e.SufijoHasta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO_HASTA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SufijoHastaE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO_HASTA_E");

                entity.Property(e => e.TipoCambio)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("TIPO_CAMBIO");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalParcial)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TOTAL_PARCIAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UnidadFacturar)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD_FACTURAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Unidadesent)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("UNIDADESENT");

                entity.Property(e => e.Unidadesfact)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("UNIDADESFACT");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");

                entity.Property(e => e.ValorLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_LISTA");

                entity.Property(e => e.ValorListad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_LISTAD");

                entity.Property(e => e.ValorVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_VENTA");

                entity.Property(e => e.ValorVentaCpj)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_VENTA_CPJ");

                entity.Property(e => e.ValorVentad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VALOR_VENTAD");

                entity.Property(e => e.VentaUniDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_UNI_DOL");
            });

            modelBuilder.Entity<CobAdjuntosCobranza>(entity =>
            {
                entity.HasKey(e => e.IdAdjunto);

                entity.ToTable("CobAdjuntosCobranza");

                entity.HasIndex(e => e.Documento, "IX_CobAdjuntosCobranza");

                entity.HasIndex(e => new { e.Documento, e.IdTipoDocumento }, "IX_CobAdjuntosCobranza_1");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ruta)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TextoPrueba)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CobAvisosCobro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cob_AvisosCobro");

                entity.HasIndex(e => e.Cliente, "IX_Cob_AvisosCobro");

                entity.HasIndex(e => e.Fecha, "IX_Cob_AvisosCobro_1");

                entity.HasIndex(e => e.Procesado, "IX_Cob_AvisosCobro_2");

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

                entity.HasIndex(e => e.Cliente, "IX_Cob_AvisosCobro_Temp");

                entity.HasIndex(e => e.Usuario, "IX_Cob_AvisosCobro_Temp_1");

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

                entity.ToTable("CobBanco");

                entity.Property(e => e.NombreBanco).HasMaxLength(50);
            });

            modelBuilder.Entity<CobDatosCheque>(entity =>
            {
                entity.HasKey(e => e.Documento);

                entity.ToTable("CobDatosCheque");

                entity.Property(e => e.Documento).ValueGeneratedNever();

                entity.Property(e => e.FechaCheque).HasColumnType("datetime");

                entity.Property(e => e.IdBanco)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.IdTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.MontoCheque).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RmontoCheque)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RMontoCheque");

                entity.HasOne(d => d.DocumentoNavigation)
                    .WithOne(p => p.CobDatosCheque)
                    .HasForeignKey<CobDatosCheque>(d => d.Documento)
                    .HasConstraintName("FK_CobDatosCheque_CobGeneralCobranza");
            });

            modelBuilder.Entity<CobDescuentoIvaTipoTransaccion>(entity =>
            {
                entity.ToTable("CobDescuentoIvaTipoTransaccion");

                entity.HasIndex(e => new { e.IdTipoTransaccion, e.BsDesde, e.BsHasta }, "IX_CobDescuentoIvaTipoTransaccion")
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

                entity.Property(e => e.RbsDesde)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RBsDesde");

                entity.Property(e => e.RbsHasta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RBsHasta");
            });

            modelBuilder.Entity<CobDiferenciaRetencion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CobDiferenciaRetencion");

                entity.HasIndex(e => new { e.AñoCobro, e.MesCobro }, "IX_CobDiferenciaRetencion");

                entity.Property(e => e.BsEmision).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Diferencia).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DocumentoSap).HasMaxLength(50);

                entity.Property(e => e.DolaresComprobante).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DolaresContabilizacion).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DolaresFechaFactura).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaComprobante).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaContabilizacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");

                entity.Property(e => e.NombreCliente).HasMaxLength(200);

                entity.Property(e => e.NroComprobante).HasMaxLength(50);

                entity.Property(e => e.Oficina).HasMaxLength(50);

                entity.Property(e => e.Porcentaje).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.TasaComprobante).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TasaContabilizacion).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vendedor).HasMaxLength(100);
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
                    .HasMaxLength(10)
                    .HasColumnName("Oficina_Venta");

                entity.Property(e => e.Rpaap).HasColumnName("RPAAP");

                entity.Property(e => e.Rpag).HasColumnName("RPAG");

                entity.Property(e => e.Rpan8).HasColumnName("RPAN8");

                entity.Property(e => e.Rpdct)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("RPDCT")
                    .IsFixedLength();

                entity.Property(e => e.Rpdoc).HasColumnName("RPDOC");

                entity.Property(e => e.Rpkco)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("RPKCO")
                    .IsFixedLength();

                entity.Property(e => e.Rpsfx)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("RPSFX")
                    .IsFixedLength();

                entity.Property(e => e.Vendedor).HasMaxLength(4);
            });

            modelBuilder.Entity<CobEstadoDeCuentum>(entity =>
            {
                entity.HasIndex(e => new { e.Rpkco, e.Rpdct, e.Rpdoc, e.Rpsfx }, "IX_CobEstadoDeCuenta");

                entity.HasIndex(e => e.IdCliente, "IX_CobEstadoDeCuenta_1");

                entity.HasIndex(e => e.Rpdoc, "IX_CobEstadoDeCuenta_2");

                entity.HasIndex(e => e.DocumentoSap, "IX_CobEstadoDeCuenta_3");

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

                entity.Property(e => e.Moneda).HasMaxLength(10);

                entity.Property(e => e.MontoOriginal)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OficinaVenta)
                    .HasMaxLength(10)
                    .HasColumnName("Oficina_Venta");

                entity.Property(e => e.Pltyp)
                    .HasMaxLength(2)
                    .HasColumnName("PLTYP")
                    .HasDefaultValueSql("('Z2')");

                entity.Property(e => e.RbaseImponible)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RBaseImponible")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Riva)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RIva")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RmontoOriginal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RMontoOriginal")
                    .HasDefaultValueSql("((0))");

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
                    .HasMaxLength(2)
                    .HasColumnName("RPDCT")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Rpdoc).HasColumnName("RPDOC");

                entity.Property(e => e.Rpkco)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("RPKCO")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Rpsfx)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("RPSFX")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Rrpaap)
                    .HasColumnName("RRPAAP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rrpag)
                    .HasColumnName("RRPAG")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendedor).HasMaxLength(4);
            });

            modelBuilder.Entity<CobExcepcion>(entity =>
            {
                entity.HasKey(e => e.IdExcepcion);

                entity.ToTable("CobExcepcion");

                entity.HasIndex(e => e.Documento, "IX_CobExcepcion")
                    .IsUnique();

                entity.Property(e => e.FechaLm)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaLM");

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

                entity.ToTable("CobGeneralCobranza");

                entity.HasIndex(e => e.NumReferencia, "IX_CobGeneralCobranza");

                entity.HasIndex(e => e.SearchText, "IX_CobGeneralCobranza_1");

                entity.HasIndex(e => e.IdCliente, "IX_CobGeneralCobranza_2");

                entity.HasIndex(e => e.OficinaVenta, "IX_CobGeneralCobranza_3");

                entity.HasIndex(e => new { e.OficinaVenta, e.SearchText }, "IX_CobGeneralCobranza_4");

                entity.HasIndex(e => new { e.OficinaVenta, e.FlagEnviado, e.FlagAnulado, e.FlagConfirmado }, "IX_CobGeneralCobranza_5");

                entity.HasIndex(e => e.DocumentoEfectivo, "IX_CobGeneralCobranza_6");

                entity.Property(e => e.Batch).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCliente)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaAnulado).HasColumnType("datetime");

                entity.Property(e => e.FechaAprobado).HasColumnType("datetime");

                entity.Property(e => e.FechaConfirmado).HasColumnType("datetime");

                entity.Property(e => e.FechaEnviado).HasColumnType("datetime");

                entity.Property(e => e.FechaLm)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaLM");

                entity.Property(e => e.FechaLmcxC)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaLMCxC");

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

                entity.Property(e => e.OficinaVenta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RmontoTransaccion)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RMontoTransaccion");

                entity.Property(e => e.RtotalDetalleCobrado)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RTotalDetalleCobrado");

                entity.Property(e => e.SearchText)
                    .IsRequired()
                    .HasMaxLength(400);

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
                    .WithMany(p => p.CobGeneralCobranzas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CobGeneralCobranza_MtrCliente");
            });

            modelBuilder.Entity<CobGrabacionCobranza>(entity =>
            {
                entity.HasIndex(e => e.Documento, "IX_CobGrabacionCobranzas");

                entity.HasIndex(e => e.DocAfecta, "IX_CobGrabacionCobranzas_1");

                entity.HasIndex(e => e.Id, "IX_CobGrabacionCobranzas_2");

                entity.HasIndex(e => new { e.Transaccion, e.Cotizacion }, "IX_CobGrabacionCobranzas_3");

                entity.HasIndex(e => e.Cotizacion, "IX_CobGrabacionCobranzas_4");

                entity.HasIndex(e => new { e.Documento, e.Transaccion }, "IX_CobGrabacionCobranzas_5");

                entity.HasIndex(e => e.Rpdoc, "IX_CobGrabacionCobranzas_6");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocAfecta).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocAfectaSap)
                    .HasMaxLength(10)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DocumentoSap)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EjercicioDocumentoSap)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaTasa).HasColumnType("datetime");

                entity.Property(e => e.Monto)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoBs).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoReconvertido).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PagoCorrespondeIva).HasDefaultValueSql("((0))");

                entity.Property(e => e.PagoDeMas).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rmonto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RMonto");

                entity.Property(e => e.RmontoBs)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RMontoBs");

                entity.Property(e => e.Rpdct)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("RPDCT")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Rpdoc).HasColumnName("RPDOC");

                entity.Property(e => e.Rpkco)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("RPKCO")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Rpsfx)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("RPSFX")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RtasaBancoCentral)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RTasaBancoCentral");

                entity.Property(e => e.TasaBancoCentral).HasColumnType("numeric(18, 4)");

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

                entity.ToTable("CobIntegridadCobranzasVsWary074");

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

            modelBuilder.Entity<CobMatrixMonedaValidaPago>(entity =>
            {
                entity.ToTable("CobMatrixMonedaValidaPago");

                entity.Property(e => e.MonedaDocumento).HasMaxLength(4);

                entity.Property(e => e.MonedaPago).HasMaxLength(4);
            });

            modelBuilder.Entity<CobPagosRetencione>(entity =>
            {
                entity.HasIndex(e => new { e.IdCobranza, e.IdTransaccion, e.Porcentaje }, "IX_CobPagosRetenciones")
                    .IsUnique();

                entity.Property(e => e.DocumentoSap)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EjercicioDocumentoSap)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

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
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RMonto");

                entity.HasOne(d => d.IdCobranzaNavigation)
                    .WithMany(p => p.CobPagosRetenciones)
                    .HasForeignKey(d => d.IdCobranza)
                    .HasConstraintName("FK_CobPagosRetenciones_CobGrabacionCobranzas");
            });

            modelBuilder.Entity<CobPorcentajesImpuesto>(entity =>
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

            modelBuilder.Entity<CobRangoDiasPago>(entity =>
            {
                entity.ToTable("CobRangoDiasPago");

                entity.Property(e => e.Titulo).HasMaxLength(200);
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

            modelBuilder.Entity<CobResumenEstadoCuentum>(entity =>
            {
                entity.HasKey(e => e.Cliente);

                entity.ToTable("Cob_Resumen_Estado_Cuenta");

                entity.HasIndex(e => e.Oficina, "IX_Cob_Resumen_Estado_Cuenta");

                entity.HasIndex(e => e.Consultor, "IX_Cob_Resumen_Estado_Cuenta_1");

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

                entity.ToTable("CobRolCobranza");

                entity.HasIndex(e => new { e.IdUsuario, e.IdOficina }, "IX_CobRolCobranza")
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
                entity.ToTable("CobSysfile");

                entity.Property(e => e.FechaLm)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaLM");

                entity.Property(e => e.FechaLmcxC)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaLMCxC");

                entity.Property(e => e.FlagAprobarRc)
                    .IsRequired()
                    .HasColumnName("FlagAprobarRC")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CobTipoTransaccion>(entity =>
            {
                entity.HasKey(e => e.IdTipoTransaccion);

                entity.ToTable("CobTipoTransaccion");

                entity.Property(e => e.IdTipoTransaccion).HasMaxLength(4);

                entity.Property(e => e.ColetillaIva)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdTipoPagoSap)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IdTipoPagoSAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<CobTipoTransaccionRespaldoAntesEliminarColettilla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CobTipoTransaccionRespaldoAntesEliminarColettilla");

                entity.Property(e => e.ColetillaIva)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.IdTipoPagoSap)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IdTipoPagoSAP");

                entity.Property(e => e.IdTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.NombreTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<CobTransaccione>(entity =>
            {
                entity.HasKey(e => e.IdTransacccionCobranzas);

                entity.HasIndex(e => e.Transaccion, "IX_CobTransacciones")
                    .IsUnique();

                entity.HasIndex(e => e.TransLegacy, "IX_CobTransacciones_1")
                    .IsUnique();

                entity.Property(e => e.BsHolgura).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CuentaSap)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("CuentaSAP");

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.NombreTransaccion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoSap)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("TipoSAP");

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
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PorcRetISLR");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(40);

                entity.Property(e => e.UsuarioModificacion).HasMaxLength(40);
            });

            modelBuilder.Entity<CobValoresRetencionIva>(entity =>
            {
                entity.HasKey(e => e.IdRetIva);

                entity.ToTable("CobValoresRetencionIva");

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.PorcRetIva).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(40);

                entity.Property(e => e.UsuarioModificacion).HasMaxLength(40);
            });

            modelBuilder.Entity<CobValoresRetencione>(entity =>
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
                entity.ToTable("Company");

                entity.HasIndex(e => e.Name, "Company_Name_Index")
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

                entity.HasIndex(e => e.Cliente, "IX_CPRY010");

                entity.Property(e => e.JobId)
                    .ValueGeneratedNever()
                    .HasColumnName("JOB_ID");

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
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_CAJA")
                    .IsFixedLength();

                entity.Property(e => e.Combinacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMBINACION");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
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
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINA")
                    .IsFixedLength();

                entity.Property(e => e.FecRealOrden)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REAL_ORDEN");

                entity.Property(e => e.FechaArchivo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCHIVO");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FACTURA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaOrdEntry)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ORD_ENTRY");

                entity.Property(e => e.FechaRet)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RET");

                entity.Property(e => e.FechaRetenido)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RETENIDO");

                entity.Property(e => e.FechaeEstAcab)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_ACAB");

                entity.Property(e => e.FechaeEstBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_BCS");

                entity.Property(e => e.FechaeEstCole)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_COLE");

                entity.Property(e => e.FechaeEstDise)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_DISE");

                entity.Property(e => e.FechaeEstEmba)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_EMBA");

                entity.Property(e => e.FechaeEstEntr)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_ENTR");

                entity.Property(e => e.FechaeEstFact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_FACT");

                entity.Property(e => e.FechaeEstNega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_NEGA");

                entity.Property(e => e.FechaeEstPren)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAE_EST_PREN");

                entity.Property(e => e.FechaerAcabado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_ACABADO");

                entity.Property(e => e.FechaerBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_BCS");

                entity.Property(e => e.FechaerColecto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_COLECTO");

                entity.Property(e => e.FechaerDiseno)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_DISENO");

                entity.Property(e => e.FechaerEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_EMBARQU");

                entity.Property(e => e.FechaerFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_FACTURA");

                entity.Property(e => e.FechaerNegativ)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_NEGATIV");

                entity.Property(e => e.FechaerPrelim)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_PRELIM");

                entity.Property(e => e.FechaerPrensas)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAER_PRENSAS");

                entity.Property(e => e.FechasEstAcab)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_ACAB");

                entity.Property(e => e.FechasEstBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_BCS");

                entity.Property(e => e.FechasEstCole)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_COLE");

                entity.Property(e => e.FechasEstDise)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_DISE");

                entity.Property(e => e.FechasEstEmba)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_EMBA");

                entity.Property(e => e.FechasEstFact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_FACT");

                entity.Property(e => e.FechasEstNega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_NEGA");

                entity.Property(e => e.FechasEstPrel)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_PREL");

                entity.Property(e => e.FechasEstPren)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAS_EST_PREN");

                entity.Property(e => e.FechasrAcabado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_ACABADO");

                entity.Property(e => e.FechasrBcs)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_BCS");

                entity.Property(e => e.FechasrColecto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_COLECTO");

                entity.Property(e => e.FechasrDiseno)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_DISENO");

                entity.Property(e => e.FechasrEmbarqu)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_EMBARQU");

                entity.Property(e => e.FechasrNegativ)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_NEGATIV");

                entity.Property(e => e.FechasrPrelim)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_PRELIM");

                entity.Property(e => e.FechasrPrensas)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHASR_PRENSAS");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength();

                entity.Property(e => e.FlagAcabado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACABADO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagBcs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_BCS")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagColectora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_COLECTORA")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagDiseno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_DISENO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagEmbarque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_EMBARQUE")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagEtiqImpre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ETIQ_IMPRE")
                    .IsFixedLength();

                entity.Property(e => e.FlagFoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FOTO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagPlaneac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEAC")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagPlaneado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PLANEADO")
                    .IsFixedLength();

                entity.Property(e => e.FlagPrensas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PRENSAS")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FlagRetenido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETENIDO")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.FlagSoportev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_SOPORTEV")
                    .IsFixedLength();

                entity.Property(e => e.FormInicial).HasColumnName("FORM_INICIAL");

                entity.Property(e => e.FormPorCaja).HasColumnName("FORM_POR_CAJA");

                entity.Property(e => e.JobAutomatico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("JOB_AUTOMATICO")
                    .IsFixedLength();

                entity.Property(e => e.JobRestar).HasColumnName("JOB_RESTAR");

                entity.Property(e => e.LineaProduccio).HasColumnName("LINEA_PRODUCCIO");

                entity.Property(e => e.Lista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA");

                entity.Property(e => e.LugarProducir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_PRODUCIR")
                    .IsFixedLength();

                entity.Property(e => e.NoAnulacion).HasColumnName("NO_ANULACION");

                entity.Property(e => e.NoColectora).HasColumnName("NO_COLECTORA");

                entity.Property(e => e.NoPrensa).HasColumnName("NO_PRENSA");

                entity.Property(e => e.NuevaCtd).HasColumnName("NUEVA_CTD");

                entity.Property(e => e.NuevaFechaEnt)
                    .HasColumnType("datetime")
                    .HasColumnName("NUEVA_FECHA_ENT");

                entity.Property(e => e.NumeroFactura).HasColumnName("NUMERO_FACTURA");

                entity.Property(e => e.Obser)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OBSER")
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasColumnType("text")
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrigenReoperac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_REOPERAC")
                    .IsFixedLength();

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PartesAReope).HasColumnName("PARTES_A_REOPE");

                entity.Property(e => e.PasoSql)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .IsFixedLength();

                entity.Property(e => e.PiesArteCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_COLE");

                entity.Property(e => e.PiesArtePren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_ARTE_PREN");

                entity.Property(e => e.PiesColect)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_COLECT");

                entity.Property(e => e.PiesFotoCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_COLE");

                entity.Property(e => e.PiesFotoPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_FOTO_PREN");

                entity.Property(e => e.PiesPlanCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_COLE");

                entity.Property(e => e.PiesPlanPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PLAN_PREN");

                entity.Property(e => e.PiesPrensCole)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_COLE");

                entity.Property(e => e.PiesPrensPren)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PIES_PRENS_PREN");

                entity.Property(e => e.PiesPrensa)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PIES_PRENSA");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.ProduInmediata)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRODU_INMEDIATA")
                    .IsFixedLength();

                entity.Property(e => e.Programada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMADA")
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Remanente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REMANENTE")
                    .IsFixedLength();

                entity.Property(e => e.ReopSolicPor).HasColumnName("REOP_SOLIC_POR");

                entity.Property(e => e.ReoperacionNo).HasColumnName("REOPERACION_NO");

                entity.Property(e => e.ResponsaReoper)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSA_REOPER")
                    .IsFixedLength();

                entity.Property(e => e.Rlista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RLISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpreciolista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOLISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rprecioventa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIOVENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rventa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RVENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusDelJob)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_DEL_JOB")
                    .IsFixedLength();

                entity.Property(e => e.SupervVentas)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERV_VENTAS")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.TipoCaja).HasColumnName("TIPO_CAJA");

                entity.Property(e => e.TipoOrden).HasColumnName("TIPO_ORDEN");

                entity.Property(e => e.TipoProduccion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCCION")
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRet)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_RET");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Venta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA");
            });

            modelBuilder.Entity<Cpry012>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CPRY012");

                entity.HasIndex(e => e.Orden, "IX_CPRY012");

                entity.Property(e => e.Adelantada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADELANTADA");

                entity.Property(e => e.An8entregar)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("AN8ENTREGAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.An8facturar)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("AN8FACTURAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnchosPts1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_PTS1")
                    .IsFixedLength();

                entity.Property(e => e.AnchosPts2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_PTS2")
                    .IsFixedLength();

                entity.Property(e => e.AnchosRod1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_ROD1")
                    .IsFixedLength();

                entity.Property(e => e.AnchosRod2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANCHOS_ROD2")
                    .IsFixedLength();

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.AnticipoJde)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("ANTICIPO_JDE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anulada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADA")
                    .IsFixedLength();

                entity.Property(e => e.AutorizaAde)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AUTORIZA_ADE");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinanE)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINAN_E");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinansce)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINANSCE");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapelE)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPEL_E");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPELSC");

                entity.Property(e => e.BsMcPapelsce)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPELSCE");

                entity.Property(e => e.CambioCompo)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CAMBIO_COMPO")
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
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("CANTIDAD_RODADA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClaseOrden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLASE_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodAplicacion)
                    .HasColumnName("COD_APLICACION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodBacklogRet).HasColumnName("COD_BACKLOG_RET");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.CodTeleop)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COD_TELEOP")
                    .IsFixedLength();

                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("COMISION");

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.CondicionProdu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONDICION_PRODU")
                    .IsFixedLength();

                entity.Property(e => e.ConsArchivo).HasColumnName("CONS_ARCHIVO");

                entity.Property(e => e.Cortado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CORTADO")
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.CtdEntregada).HasColumnName("CTD_ENTREGADA");

                entity.Property(e => e.CtdNc).HasColumnName("CTD_NC");

                entity.Property(e => e.CteEntregar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CTE_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.CteFacturar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CTE_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.CuarTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CUAR_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.DescProducto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR2")
                    .IsFixedLength();

                entity.Property(e => e.DirecEntregar3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_ENTREGAR3")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR2")
                    .IsFixedLength();

                entity.Property(e => e.DirecFacturar3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIREC_FACTURAR3")
                    .IsFixedLength();

                entity.Property(e => e.Doblez)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DOBLEZ")
                    .IsFixedLength();

                entity.Property(e => e.EmbReverso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EMB_REVERSO")
                    .IsFixedLength();

                entity.Property(e => e.EmpacarEn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EMPACAR_EN")
                    .IsFixedLength();

                entity.Property(e => e.EngomaCarbCol)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENGOMA_CARB_COL")
                    .IsFixedLength();

                entity.Property(e => e.EngomaCarbPre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENGOMA_CARB_PRE")
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .IsFixedLength();

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.Excepcion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXCEPCION")
                    .IsFixedLength();

                entity.Property(e => e.FacturaDolar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FACTURA_DOLAR")
                    .IsFixedLength();

                entity.Property(e => e.FamiliaProduct)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .IsFixedLength();

                entity.Property(e => e.FecCierreOrd)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_CIERRE_ORD");

                entity.Property(e => e.FecComproClte)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_COMPRO_CLTE");

                entity.Property(e => e.FecCreditos)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_CREDITOS");

                entity.Property(e => e.FecProgramada)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_PROGRAMADA");

                entity.Property(e => e.FecRecibPlant)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_RECIB_PLANT");

                entity.Property(e => e.FecRegVentas)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_REG_VENTAS")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FecTransmision)
                    .HasColumnType("datetime")
                    .HasColumnName("FEC_TRANSMISION");

                entity.Property(e => e.FechaArchivo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARCHIVO")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaCalculo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CALCULO");

                entity.Property(e => e.FechaDolar)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DOLAR");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .IsFixedLength();

                entity.Property(e => e.FlagActivo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ACTIVO")
                    .IsFixedLength();

                entity.Property(e => e.FlagFactura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FACTURA")
                    .IsFixedLength();

                entity.Property(e => e.FlagProdInter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PROD_INTER")
                    .IsFixedLength();

                entity.Property(e => e.FlagSoportev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_SOPORTEV")
                    .IsFixedLength();

                entity.Property(e => e.FlagV19)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_V19")
                    .IsFixedLength();

                entity.Property(e => e.FormasUndFact).HasColumnName("FORMAS_UND_FACT");

                entity.Property(e => e.GomaRegPtes)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOMA_REG_PTES")
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
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("IDCALENDAR2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Impout)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("IMPOUT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Impresion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPRESION")
                    .IsFixedLength();

                entity.Property(e => e.ImprimeDol)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPRIME_DOL")
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.Impvar)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("IMPVAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InstFacturar)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("INST_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.LineaAnt).HasColumnName("LINEA_ANT");

                entity.Property(e => e.LineaAntJde)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("LINEA_ANT_JDE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProducto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.ListaTotDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_TOT_DOLAR");

                entity.Property(e => e.ListaUnitDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_UNIT_DOL");

                entity.Property(e => e.LugarEnviar)
                    .HasColumnType("text")
                    .HasColumnName("LUGAR_ENVIAR");

                entity.Property(e => e.LugarProducir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_PRODUCIR")
                    .IsFixedLength();

                entity.Property(e => e.MedidaBase).HasColumnName("MEDIDA_BASE");

                entity.Property(e => e.MedidaVariable).HasColumnName("MEDIDA_VARIABLE");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NoTransmision).HasColumnName("NO_TRANSMISION");

                entity.Property(e => e.Nocalculamc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOCALCULAMC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.NuTintasFrent).HasColumnName("NU_TINTAS_FRENT");

                entity.Property(e => e.NuTintasResp).HasColumnName("NU_TINTAS_RESP");

                entity.Property(e => e.NumeroTiras).HasColumnName("NUMERO_TIRAS");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.OrdenAnterior).HasColumnName("ORDEN_ANTERIOR");

                entity.Property(e => e.OrdenComb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_COMB")
                    .IsFixedLength();

                entity.Property(e => e.PCobranza)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_COBRANZA");

                entity.Property(e => e.POverger)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERGER");

                entity.Property(e => e.POverride)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE");

                entity.Property(e => e.POverrideCg)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE_CG");

                entity.Property(e => e.POverrideG)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE_G");

                entity.Property(e => e.POverrideGo)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("P_OVERRIDE_GO");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.PartesFormula).HasColumnName("PARTES_FORMULA");

                entity.Property(e => e.PartesTiras)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PARTES_TIRAS")
                    .IsFixedLength();

                entity.Property(e => e.Plantilla).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoncMargDer)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PONC_MARG_DER")
                    .IsFixedLength();

                entity.Property(e => e.PoncMargIzq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PONC_MARG_IZQ")
                    .IsFixedLength();

                entity.Property(e => e.PoncheEsp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PONCHE_ESP")
                    .IsFixedLength();

                entity.Property(e => e.PorcCom)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_COM");

                entity.Property(e => e.PorcComRegulada)
                    .HasColumnType("numeric(5, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinanE)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINAN_E");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcMinimo).HasColumnType("numeric(5, 3)");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapelE)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPEL_E");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcfinansce)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MCFINANSCE");

                entity.Property(e => e.PorcMcpapelsce)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MCPAPELSCE");

                entity.Property(e => e.PorcRespSocial)
                    .HasColumnType("numeric(5, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PosTirasF)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("POS_TIRAS_F")
                    .IsFixedLength();

                entity.Property(e => e.PosTirasR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("POS_TIRAS_R")
                    .IsFixedLength();

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.PrefColeEsp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_COLE_ESP")
                    .IsFixedLength();

                entity.Property(e => e.PrefColeStd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_COLE_STD")
                    .IsFixedLength();

                entity.Property(e => e.PrefPrenEsp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_PREN_ESP")
                    .IsFixedLength();

                entity.Property(e => e.PrefPrenStd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREF_PREN_STD")
                    .IsFixedLength();

                entity.Property(e => e.PrimTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.PrimTintaResp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PRIM_TINTA_RESP")
                    .IsFixedLength();

                entity.Property(e => e.QuintTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("QUINT_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPELSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rcomision)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RCOMISION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecalcularMargen)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Refinado)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("REFINADO");

                entity.Property(e => e.RefinadoEn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("REFINADO_EN")
                    .IsFixedLength();

                entity.Property(e => e.Regular)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGULAR")
                    .IsFixedLength();

                entity.Property(e => e.RifEntregar)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_ENTREGAR")
                    .IsFixedLength();

                entity.Property(e => e.RifFacturar)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_FACTURAR")
                    .IsFixedLength();

                entity.Property(e => e.RifImprimir)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_IMPRIMIR")
                    .IsFixedLength();

                entity.Property(e => e.RollosCtd1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ROLLOS_CTD1");

                entity.Property(e => e.RollosCtd2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ROLLOS_CTD2");

                entity.Property(e => e.RollosCtd3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ROLLOS_CTD3");

                entity.Property(e => e.RollosPts1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ROLLOS_PTS1")
                    .IsFixedLength();

                entity.Property(e => e.RollosPts2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ROLLOS_PTS2")
                    .IsFixedLength();

                entity.Property(e => e.RollosPts3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ROLLOS_PTS3")
                    .IsFixedLength();

                entity.Property(e => e.RollosRod1).HasColumnName("ROLLOS_ROD1");

                entity.Property(e => e.RollosRod2).HasColumnName("ROLLOS_ROD2");

                entity.Property(e => e.RollosRod3).HasColumnName("ROLLOS_ROD3");

                entity.Property(e => e.RprecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rtasa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("RTASA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalListaEx)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA_EX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalVentaEx)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA_EX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalidaPreCab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SALIDA_PRE_CAB")
                    .IsFixedLength();

                entity.Property(e => e.SalidaPrePie)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SALIDA_PRE_PIE")
                    .IsFixedLength();

                entity.Property(e => e.SegTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.SegTintaResp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEG_TINTA_RESP")
                    .IsFixedLength();

                entity.Property(e => e.SexTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEX_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.SiColetilla)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_COLETILLA")
                    .HasDefaultValueSql("('X')")
                    .IsFixedLength();

                entity.Property(e => e.SiDolares)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_DOLARES")
                    .HasDefaultValueSql("('X')")
                    .IsFixedLength();

                entity.Property(e => e.SiIndexado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_INDEXADO")
                    .IsFixedLength();

                entity.Property(e => e.Solido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOLIDO")
                    .IsFixedLength();

                entity.Property(e => e.StatusOrden)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .IsFixedLength();

                entity.Property(e => e.Tabla).HasColumnName("TABLA");

                entity.Property(e => e.TalonExtra)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TALON_EXTRA")
                    .IsFixedLength();

                entity.Property(e => e.Tasa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("TASA");

                entity.Property(e => e.TercTintaFte)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_FTE")
                    .IsFixedLength();

                entity.Property(e => e.TercTintaResp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TERC_TINTA_RESP")
                    .IsFixedLength();

                entity.Property(e => e.TipoCaja)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CAJA")
                    .IsFixedLength();

                entity.Property(e => e.TipoEmpaque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_EMPAQUE")
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_ORDEN")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.TotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_LISTA");

                entity.Property(e => e.TotalListaExt)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_LISTA_EXT");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.TotalVentaExt)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TOTAL_VENTA_EXT");

                entity.Property(e => e.TranfTapeEf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANF_TAPE_EF")
                    .IsFixedLength();

                entity.Property(e => e.TranfTapePerm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANF_TAPE_PERM")
                    .IsFixedLength();

                entity.Property(e => e.TranfTapeRem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TRANF_TAPE_REM")
                    .IsFixedLength();

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.VentaTotDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_TOT_DOLAR");

                entity.Property(e => e.VentaUnitDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_UNIT_DOL");

                entity.Property(e => e.VinetaImpresa)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VINETA_IMPRESA")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Web)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WEB")
                    .IsFixedLength();

                entity.Property(e => e.Ws)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WS")
                    .HasDefaultValueSql("('HOST_NAME()')");
            });

            modelBuilder.Entity<CreAdjuntoSolicitudCredito>(entity =>
            {
                entity.HasKey(e => e.SolicitudDeCredito);

                entity.ToTable("CreAdjuntoSolicitudCredito");

                entity.Property(e => e.SolicitudDeCredito).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<CreClientesExcepcion>(entity =>
            {
                entity.ToTable("CreClientesExcepcion");

                entity.HasIndex(e => e.CodCliente, "IX_CreClientesExcepcion");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("COD_CLIENTE");

                entity.Property(e => e.Excepcion)
                    .HasMaxLength(1000)
                    .HasColumnName("EXCEPCION");
            });

            modelBuilder.Entity<CreCobradoCotizacion>(entity =>
            {
                entity.ToTable("CreCobradoCotizacion");

                entity.HasIndex(e => e.Cotizacion, "IX_CreCobradoCotizacion");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.DocAfecta).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Documento).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechaTasa).HasColumnType("datetime");

                entity.Property(e => e.IdCobro).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Monto).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TasaBancoCentral).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TasaReferencial).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Transaccion).HasMaxLength(2);

                entity.Property(e => e.UsdCobradoBancoCentral).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UsdCobradoReferencial).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<CreCotizacionDocumento>(entity =>
            {
                entity.ToTable("CreCotizacionDocumento");

                entity.HasIndex(e => e.Cotizacion, "IX_CreCotizacionDocumento");

                entity.HasIndex(e => e.Documento, "IX_CreCotizacionDocumento_1");

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

                entity.ToTable("CreEvaluacionCredito");

                entity.Property(e => e.IdEvaluacion).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(10)
                    .HasColumnName("Cod_Cliente");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSolicitudAnalisis).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Monto).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rmonto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("RMonto");

                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<CrePendientesExcepcion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrePendientesExcepcion");

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<CreRangoAprobacionOficinaUsuarioMontoDia>(entity =>
            {
                entity.HasIndex(e => new { e.Oficina, e.Usuario, e.MontoDesde, e.MontoHasta }, "IX_CreRangoAprobacionOficinaUsuarioMontoDias")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MontoDesde).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MontoHasta).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RmontoDesde)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("RMontoDesde");

                entity.Property(e => e.RmontoHasta)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("RMontoHasta");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CreResponsableAprobarExcepcion>(entity =>
            {
                entity.ToTable("CreResponsableAprobarExcepcion");

                entity.HasIndex(e => e.Usuario, "IX_CreResponsableAprobarExcepcion");

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
                entity.ToTable("CreSolicitudDeCredito");

                entity.HasIndex(e => e.Cotizacion, "IX_CreSolicitudDeCredito");

                entity.HasIndex(e => e.Aprobada, "IX_CreSolicitudDeCredito_1");

                entity.HasIndex(e => e.SolicitudDeCredito, "IX_CreSolicitudDeCredito_2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Aprobada).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(10)
                    .HasColumnName("COD_CLIENTE")
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
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("RMontoSolicitado")
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
                entity.ToTable("CreSolicitudDeCreditoHistorico");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Aprobada).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(10)
                    .HasColumnName("COD_CLIENTE")
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
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("RMontoSolicitado")
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

                entity.ToTable("CreSolicitudExcepcion");

                entity.Property(e => e.SolicitudDeCredito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.FechaAprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCompromiso).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoPagado)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NombreImagen).HasMaxLength(500);

                entity.Property(e => e.SolicitudCerrada).HasDefaultValueSql("((0))");

                entity.Property(e => e.SolicitudExcepcionPorPago).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioAprobador).HasMaxLength(50);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioRechazo).HasMaxLength(50);
            });

            modelBuilder.Entity<CreSolicitudExcepcionHistorico>(entity =>
            {
                entity.ToTable("CreSolicitudExcepcionHistorico");

                entity.HasIndex(e => e.FechaCreacion, "IX_CreSolicitudExcepcionHistorico");

                entity.HasIndex(e => e.Cotizacion, "IX_CreSolicitudExcepcionHistorico_1");

                entity.HasIndex(e => new { e.NombreRegion, e.NombreOficina, e.NombreVendedor, e.NombreCliente }, "IX_CreSolicitudExcepcionHistorico_2");

                entity.HasIndex(e => e.FechaAprobacion, "IX_CreSolicitudExcepcionHistorico_3");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.FechaAprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCompromiso).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.IdOficina).HasMaxLength(10);

                entity.Property(e => e.IdRegion).HasMaxLength(10);

                entity.Property(e => e.IdVendedor).HasMaxLength(4);

                entity.Property(e => e.MontoPagado)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NombreCliente).HasMaxLength(80);

                entity.Property(e => e.NombreImagen).HasMaxLength(500);

                entity.Property(e => e.NombreOficina).HasMaxLength(50);

                entity.Property(e => e.NombreRegion).HasMaxLength(50);

                entity.Property(e => e.NombreVendedor).HasMaxLength(50);

                entity.Property(e => e.Orden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SolicitudDeCredito).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SolicitudExcepcionPorPago).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsdCotizado).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UsuarioAprobador).HasMaxLength(50);

                entity.Property(e => e.UsuarioCreacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioRechazo).HasMaxLength(50);
            });

            modelBuilder.Entity<CrmEncuestaCliente>(entity =>
            {
                entity.HasKey(e => e.IdSatisfaccion);

                entity.ToTable("CrmEncuestaCliente");

                entity.HasIndex(e => new { e.IdCliente, e.Ano, e.Mes }, "IX_CrmEncuestaCliente");

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

            modelBuilder.Entity<CrmMtrC>(entity =>
            {
                entity.HasKey(e => e.PuntosCs);

                entity.Property(e => e.PuntosCs).ValueGeneratedNever();

                entity.Property(e => e.NombreCs)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CrmMtrCe>(entity =>
            {
                entity.HasKey(e => e.PuntosCes);

                entity.Property(e => e.PuntosCes).ValueGeneratedNever();

                entity.Property(e => e.NombreCes)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CrmMtrEstado>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("CrmMtrEstado");

                entity.Property(e => e.IdEstado).ValueGeneratedNever();

                entity.Property(e => e.NombreEstado)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CrmMtrNp>(entity =>
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

                entity.ToTable("CrmMtrSeguimiento");

                entity.Property(e => e.IdTipoSegumiento).ValueGeneratedNever();

                entity.Property(e => e.NombreSeguimiento)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CrmNotificacionActividade>(entity =>
            {
                entity.HasKey(e => e.IdNotificacion);

                entity.HasIndex(e => e.IdSeguimiento, "IX_CrmNotificacionActividades")
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

                entity.ToTable("CrmSeguimiento");

                entity.HasIndex(e => e.IdCliente, "IX_CrmSeguimiento");

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
                    .WithMany(p => p.CrmSeguimientos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmSeguimiento_MtrCliente");

                entity.HasOne(d => d.IdContactoNavigation)
                    .WithMany(p => p.CrmSeguimientos)
                    .HasForeignKey(d => d.IdContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmSeguimiento_MtrContactos");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CrmSeguimientos)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmSeguimiento_CrmMtrEstado");

                entity.HasOne(d => d.IdTipoSeguimientoNavigation)
                    .WithMany(p => p.CrmSeguimientos)
                    .HasForeignKey(d => d.IdTipoSeguimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmSeguimiento_CrmMtrSeguimiento");
            });

            modelBuilder.Entity<CrmVisitaDium>(entity =>
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

            modelBuilder.Entity<CrmVisitaFrecuencium>(entity =>
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

                entity.ToTable("CrmVisitaSemana");

                entity.Property(e => e.AbreviadoSemana)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NombreSemana)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdFrecuenciaNavigation)
                    .WithMany(p => p.CrmVisitaSemanas)
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
                    .ValueGeneratedNever()
                    .HasColumnName("ORDEN");

                entity.Property(e => e.An8entregar)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("AN8ENTREGAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.An8facturar)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("AN8FACTURAR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.Anulado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AutorizaConc)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AUTORIZA_CONC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.AutorizaCred)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AUTORIZA_CRED")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CIUDAD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.CodTeleop)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COD_TELEOP")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Coment1)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("COMENT1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Coment2)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("COMENT2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CondicionPago).HasColumnName("CONDICION_PAGO");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CONTACTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccFiscal)
                    .HasColumnType("text")
                    .HasColumnName("DIRECC_FISCAL");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb1)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_EMB1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb2)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_EMB2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb3)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_EMB3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact1)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACT1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACT2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact3)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACT3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.EstadoEntregar).HasMaxLength(2);

                entity.Property(e => e.EstadoFacturar).HasMaxLength(2);

                entity.Property(e => e.FacturaDolar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FACTURA_DOLAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaCambio)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CAMBIO");

                entity.Property(e => e.FechaCob)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_COB");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FechaGrabacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_GRABACION");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PEDIDO");

                entity.Property(e => e.FechaRc)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RC");

                entity.Property(e => e.FechaReactiva)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REACTIVA");

                entity.Property(e => e.FechaTasa)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TASA");

                entity.Property(e => e.Fiscal)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagCombo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_COMBO")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Giro)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GIRO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.IdDirEntregar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdDirFacturar).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Impresa)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMPRESA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.LineaAnt).HasColumnName("LINEA_ANT");

                entity.Property(e => e.MultiplesEmb)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MULTIPLES_EMB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MunicipioEntregar).HasMaxLength(2);

                entity.Property(e => e.MunicipioFacturar).HasMaxLength(2);

                entity.Property(e => e.NitEmb).HasColumnName("NIT_EMB");

                entity.Property(e => e.NitFact).HasColumnName("NIT_FACT");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreEmb)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_EMB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreFact)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_FACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NuevaFechaEnt)
                    .HasColumnType("datetime")
                    .HasColumnName("NUEVA_FECHA_ENT");

                entity.Property(e => e.NumeroPedido).HasColumnName("NUMERO_PEDIDO");

                entity.Property(e => e.Oficina)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ORDEN_COMPRA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcentConc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORCENT_CONC");

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.ReciboCobro).HasColumnName("RECIBO_COBRO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RegTributario)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REG_TRIBUTARIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RequiereNe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REQUIERE_NE");

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_EMB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_FACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Rtasa)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("RTASA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SiColetilla)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_COLETILLA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SiDolares)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_DOLARES")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SiIndexacion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SI_INDEXACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.StatusOrden)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS_ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SupervisorConc)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR_CONC")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tasa)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TASA");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_LISTA");

                entity.Property(e => e.TotalListaDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_LISTA_DOL");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.TotalVentaDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_VENTA_DOL");

                entity.Property(e => e.UnidadFacturar).HasColumnName("UNIDAD_FACTURAR");

                entity.Property(e => e.UsrNuevaFecha)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USR_NUEVA_FECHA");

                entity.Property(e => e.VendGestion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VEND_GESTION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Web)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WEB")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Ctmy034>(entity =>
            {
                entity.HasKey(e => new { e.Orden, e.CodProducto })
                    .HasName("CTMY034_INDEX01");

                entity.ToTable("CTMY034");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Altoempaque)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("ALTOEMPAQUE");

                entity.Property(e => e.Anchoempaque)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("ANCHOEMPAQUE");

                entity.Property(e => e.AnticipoJde)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("ANTICIPO_JDE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anulado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.BsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BS_MC_PAPELSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bsmc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("BSMC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantFacturada)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("CANT_FACTURADA");

                entity.Property(e => e.CantPedida).HasColumnName("CANT_PEDIDA");

                entity.Property(e => e.Cantidadcajasempaques).HasColumnName("CANTIDADCAJASEMPAQUES");

                entity.Property(e => e.CodAplicacion)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("COD_APLICACION");

                entity.Property(e => e.CodResponsable)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("COD_RESPONSABLE");

                entity.Property(e => e.Codigocaja)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("CODIGOCAJA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Controldesde)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CONTROLDESDE");

                entity.Property(e => e.Controlhasta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CONTROLHASTA");

                entity.Property(e => e.CtdDespOfic).HasColumnName("CTD_DESP_OFIC");

                entity.Property(e => e.CtdEntregada)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("CTD_ENTREGADA");

                entity.Property(e => e.DescProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionEmb)
                    .HasColumnType("text")
                    .HasColumnName("DIRECCION_EMB");

                entity.Property(e => e.DireccionFact)
                    .HasColumnType("text")
                    .HasColumnName("DIRECCION_FACT");

                entity.Property(e => e.EbitBs)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("EBIT_BS");

                entity.Property(e => e.EbitPorc)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("EBIT_PORC");

                entity.Property(e => e.Equipoupdate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EQUIPOUPDATE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Excepcion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXCEPCION")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.FamiliaProduct)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaRemision)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REMISION");

                entity.Property(e => e.Fechaupdate)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAUPDATE");

                entity.Property(e => e.Fiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FISCAL");

                entity.Property(e => e.Formatodesde)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FORMATODESDE");

                entity.Property(e => e.Formatohasta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FORMATOHASTA");

                entity.Property(e => e.HorasMaquina)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("HORAS_MAQUINA");

                entity.Property(e => e.IdSolicitud)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdSolicitud2).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvaJde)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IVA_JDE");

                entity.Property(e => e.Largoempaque)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("LARGOEMPAQUE");

                entity.Property(e => e.LineaAntJde)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("LINEA_ANT_JDE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProducto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ListaTotDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("LISTA_TOT_DOL");

                entity.Property(e => e.Longitudmascara)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("LONGITUDMASCARA");

                entity.Property(e => e.Maquina)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MAQUINA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Medida)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MEDIDA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nocalculamc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOCALCULAMC");

                entity.Property(e => e.NombreEmb)
                    .HasColumnType("text")
                    .HasColumnName("NOMBRE_EMB");

                entity.Property(e => e.NombreFact)
                    .HasColumnType("text")
                    .HasColumnName("NOMBRE_FACT");

                entity.Property(e => e.NumeroPedido).HasColumnName("NUMERO_PEDIDO");

                entity.Property(e => e.OrigenProducto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Papel)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PAPEL");

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PorcCom)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("PORC_COM");

                entity.Property(e => e.PorcIva)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinan)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcFinansc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapel)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcMcPapelsc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORC_MC_PAPELSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcentConces)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PORCENT_CONCES");

                entity.Property(e => e.Pormc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PORMC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_LISTA");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("PRECIO_VENTA");

                entity.Property(e => e.Presentacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRESENTACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RbsMcFinan)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINAN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcFinansc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_FINANSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapel)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RbsMcPapelsc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBS_MC_PAPELSC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rbsmc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RBSMC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecalcularMargen)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RemisionOfic).HasColumnName("REMISION_OFIC");

                entity.Property(e => e.RifEmb)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("RIF_EMB")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("RIF_FACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RprecioLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RprecioVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RPRECIO_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rtasa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTASA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_LISTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL_VENTA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sddcto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SDDCTO");

                entity.Property(e => e.Sddoco)
                    .HasColumnType("decimal(14, 0)")
                    .HasColumnName("SDDOCO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sdkcoo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SDKCOO");

                entity.Property(e => e.Sdlnid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SDLNID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Seriecdesde)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SERIECDESDE");

                entity.Property(e => e.Seriechasta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SERIECHASTA");

                entity.Property(e => e.Seriefdesde)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SERIEFDESDE");

                entity.Property(e => e.Seriefhasta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SERIEFHASTA");

                entity.Property(e => e.Tasa)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("TASA");

                entity.Property(e => e.TipoIva)
                    .HasColumnName("TIPO_IVA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUCTO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tipodocumento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPODOCUMENTO");

                entity.Property(e => e.TotalLista)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_LISTA");

                entity.Property(e => e.TotalVenta)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL_VENTA");

                entity.Property(e => e.UnitListaDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("UNIT_LISTA_DOL");

                entity.Property(e => e.UnitVentaDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("UNIT_VENTA_DOL");

                entity.Property(e => e.Usuarioupdate)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("USUARIOUPDATE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.VendGestion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VEND_GESTION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.VentaTotDol)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VENTA_TOT_DOL");
            });

            modelBuilder.Entity<DataInicial>(entity =>
            {
                entity.ToTable("DataInicial");

                entity.HasIndex(e => e.Archivo, "IX_DataInicial");

                entity.HasIndex(e => e.Lote, "IX_DataInicial_1");

                entity.HasIndex(e => e.OrdenArchivo, "index_DataInicial_OrdenArchivo");

                entity.HasIndex(e => new { e.OrdenArchivo, e.Id }, "index_DataInicial_OrdenArchivoId");

                entity.HasIndex(e => e.Data, "index_Data_DataInicial");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Archivo).HasMaxLength(100);

                entity.Property(e => e.Data).HasMaxLength(250);

                entity.Property(e => e.Lote).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrdenArchivo).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<DeudorTipoRetencion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DeudorTipoRetencion");

                entity.Property(e => e.Cliente).HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IndicadorRetencion).HasMaxLength(2);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.TipoRetencion).HasMaxLength(2);
            });

            modelBuilder.Entity<Deudore>(entity =>
            {
                entity.HasKey(e => e.Cliente);

                entity.Property(e => e.Cliente).HasMaxLength(10);

                entity.Property(e => e.Clase).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.Rif).HasMaxLength(255);
            });

            modelBuilder.Entity<EjeucionProceso>(entity =>
            {
                entity.ToTable("EjeucionProceso");

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

            modelBuilder.Entity<EjeucionProcesoComisione>(entity =>
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
                entity.ToTable("EscaneoTicket");

                entity.HasIndex(e => e.Data, "IX_EscaneoTickect");

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
                    .HasColumnType("datetime")
                    .HasColumnName("ACTUALIZACION");

                entity.Property(e => e.Dias).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechaFoto)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_foto");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mensaje).HasMaxLength(255);

                entity.Property(e => e.PorcFoto).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rpaap).HasColumnName("RPAAP");

                entity.Property(e => e.Rpacr).HasColumnName("RPACR");

                entity.Property(e => e.Rpadsa).HasColumnName("RPADSA");

                entity.Property(e => e.Rpadsc).HasColumnName("RPADSC");

                entity.Property(e => e.Rpafc)
                    .HasMaxLength(1)
                    .HasColumnName("RPAFC")
                    .IsFixedLength();

                entity.Property(e => e.Rpag).HasColumnName("RPAG");

                entity.Property(e => e.Rpaid)
                    .HasMaxLength(8)
                    .HasColumnName("RPAID")
                    .IsFixedLength();

                entity.Property(e => e.Rpaid2)
                    .HasMaxLength(8)
                    .HasColumnName("RPAID2")
                    .IsFixedLength();

                entity.Property(e => e.Rpajcl)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPAJCL");

                entity.Property(e => e.Rpalph)
                    .HasMaxLength(40)
                    .HasColumnName("RPALPH")
                    .IsFixedLength();

                entity.Property(e => e.Rpalt6)
                    .HasMaxLength(1)
                    .HasColumnName("RPALT6")
                    .IsFixedLength();

                entity.Property(e => e.Rpam)
                    .HasMaxLength(1)
                    .HasColumnName("RPAM")
                    .IsFixedLength();

                entity.Property(e => e.Rpam2)
                    .HasMaxLength(1)
                    .HasColumnName("RPAM2")
                    .IsFixedLength();

                entity.Property(e => e.Rpan8).HasColumnName("RPAN8");

                entity.Property(e => e.Rpan8j).HasColumnName("RPAN8J");

                entity.Property(e => e.Rpar01)
                    .HasMaxLength(3)
                    .HasColumnName("RPAR01")
                    .IsFixedLength();

                entity.Property(e => e.Rpar02)
                    .HasMaxLength(3)
                    .HasColumnName("RPAR02")
                    .IsFixedLength();

                entity.Property(e => e.Rpar03)
                    .HasMaxLength(3)
                    .HasColumnName("RPAR03")
                    .IsFixedLength();

                entity.Property(e => e.Rpar04)
                    .HasMaxLength(3)
                    .HasColumnName("RPAR04")
                    .IsFixedLength();

                entity.Property(e => e.Rpar05)
                    .HasMaxLength(3)
                    .HasColumnName("RPAR05")
                    .IsFixedLength();

                entity.Property(e => e.Rpar06)
                    .HasMaxLength(3)
                    .HasColumnName("RPAR06")
                    .IsFixedLength();

                entity.Property(e => e.Rpar07)
                    .HasMaxLength(3)
                    .HasColumnName("RPAR07")
                    .IsFixedLength();

                entity.Property(e => e.Rpar08)
                    .HasMaxLength(3)
                    .HasColumnName("RPAR08")
                    .IsFixedLength();

                entity.Property(e => e.Rpar09)
                    .HasMaxLength(3)
                    .HasColumnName("RPAR09")
                    .IsFixedLength();

                entity.Property(e => e.Rpar10)
                    .HasMaxLength(3)
                    .HasColumnName("RPAR10")
                    .IsFixedLength();

                entity.Property(e => e.Rpatad).HasColumnName("RPATAD");

                entity.Property(e => e.Rpatxa).HasColumnName("RPATXA");

                entity.Property(e => e.Rpatxn).HasColumnName("RPATXN");

                entity.Property(e => e.Rpbalj)
                    .HasMaxLength(1)
                    .HasColumnName("RPBALJ")
                    .IsFixedLength();

                entity.Property(e => e.Rpbcrc)
                    .HasMaxLength(3)
                    .HasColumnName("RPBCRC")
                    .IsFixedLength();

                entity.Property(e => e.Rpcds).HasColumnName("RPCDS");

                entity.Property(e => e.Rpcdsa).HasColumnName("RPCDSA");

                entity.Property(e => e.Rpclmg)
                    .HasMaxLength(10)
                    .HasColumnName("RPCLMG")
                    .IsFixedLength();

                entity.Property(e => e.Rpcmc1).HasColumnName("RPCMC1");

                entity.Property(e => e.Rpcmgr)
                    .HasMaxLength(10)
                    .HasColumnName("RPCMGR")
                    .IsFixedLength();

                entity.Property(e => e.Rpco)
                    .HasMaxLength(5)
                    .HasColumnName("RPCO")
                    .IsFixedLength();

                entity.Property(e => e.Rpcoll)
                    .HasMaxLength(1)
                    .HasColumnName("RPCOLL")
                    .IsFixedLength();

                entity.Property(e => e.Rpcorc)
                    .HasMaxLength(2)
                    .HasColumnName("RPCORC")
                    .IsFixedLength();

                entity.Property(e => e.Rpcrcd)
                    .HasMaxLength(3)
                    .HasColumnName("RPCRCD")
                    .IsFixedLength();

                entity.Property(e => e.Rpcrr).HasColumnName("RPCRR");

                entity.Property(e => e.Rpcrrm)
                    .HasMaxLength(1)
                    .HasColumnName("RPCRRM")
                    .IsFixedLength();

                entity.Property(e => e.Rpctad).HasColumnName("RPCTAD");

                entity.Property(e => e.Rpctam).HasColumnName("RPCTAM");

                entity.Property(e => e.Rpctl)
                    .HasMaxLength(13)
                    .HasColumnName("RPCTL")
                    .IsFixedLength();

                entity.Property(e => e.Rpctry).HasColumnName("RPCTRY");

                entity.Property(e => e.Rpctxa).HasColumnName("RPCTXA");

                entity.Property(e => e.Rpctxn).HasColumnName("RPCTXN");

                entity.Property(e => e.Rpdct)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("RPDCT")
                    .IsFixedLength();

                entity.Property(e => e.Rpdcto)
                    .HasMaxLength(2)
                    .HasColumnName("RPDCTO")
                    .IsFixedLength();

                entity.Property(e => e.Rpddex)
                    .HasMaxLength(2)
                    .HasColumnName("RPDDEX")
                    .IsFixedLength();

                entity.Property(e => e.Rpddj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPDDJ");

                entity.Property(e => e.Rpddnj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPDDNJ");

                entity.Property(e => e.Rpdgj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPDGJ");

                entity.Property(e => e.Rpdicj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPDICJ");

                entity.Property(e => e.Rpdivj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPDIVJ");

                entity.Property(e => e.Rpdmcd)
                    .HasMaxLength(1)
                    .HasColumnName("RPDMCD")
                    .IsFixedLength();

                entity.Property(e => e.Rpdnlt)
                    .HasMaxLength(1)
                    .HasColumnName("RPDNLT")
                    .IsFixedLength();

                entity.Property(e => e.Rpdoc).HasColumnName("RPDOC");

                entity.Property(e => e.Rpdoco).HasColumnName("RPDOCO");

                entity.Property(e => e.Rpdrf).HasColumnName("RPDRF");

                entity.Property(e => e.Rpdsvj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPDSVJ");

                entity.Property(e => e.Rpdtpb)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPDTPB");

                entity.Property(e => e.Rpdtxs)
                    .HasMaxLength(1)
                    .HasColumnName("RPDTXS")
                    .IsFixedLength();

                entity.Property(e => e.Rperdj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPERDJ");

                entity.Property(e => e.Rpexr1)
                    .HasMaxLength(2)
                    .HasColumnName("RPEXR1")
                    .IsFixedLength();

                entity.Property(e => e.Rpfap).HasColumnName("RPFAP");

                entity.Property(e => e.Rpfnlp)
                    .HasMaxLength(1)
                    .HasColumnName("RPFNLP")
                    .IsFixedLength();

                entity.Property(e => e.Rpfnrt).HasColumnName("RPFNRT");

                entity.Property(e => e.Rpfy).HasColumnName("RPFY");

                entity.Property(e => e.Rpgfl1)
                    .HasMaxLength(1)
                    .HasColumnName("RPGFL1")
                    .IsFixedLength();

                entity.Property(e => e.Rpgfl2)
                    .HasMaxLength(1)
                    .HasColumnName("RPGFL2")
                    .IsFixedLength();

                entity.Property(e => e.Rpglba)
                    .HasMaxLength(8)
                    .HasColumnName("RPGLBA")
                    .IsFixedLength();

                entity.Property(e => e.Rpglc)
                    .HasMaxLength(4)
                    .HasColumnName("RPGLC")
                    .IsFixedLength();

                entity.Property(e => e.Rphcrr).HasColumnName("RPHCRR");

                entity.Property(e => e.Rphdgj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPHDGJ");

                entity.Property(e => e.Rpicu).HasColumnName("RPICU");

                entity.Property(e => e.Rpicut)
                    .HasMaxLength(2)
                    .HasColumnName("RPICUT")
                    .IsFixedLength();

                entity.Property(e => e.Rpistc)
                    .HasMaxLength(1)
                    .HasColumnName("RPISTC")
                    .IsFixedLength();

                entity.Property(e => e.Rpistr)
                    .HasMaxLength(1)
                    .HasColumnName("RPISTR")
                    .IsFixedLength();

                entity.Property(e => e.Rpitm).HasColumnName("RPITM");

                entity.Property(e => e.Rpjcl)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPJCL");

                entity.Property(e => e.Rpjobn)
                    .HasMaxLength(10)
                    .HasColumnName("RPJOBN")
                    .IsFixedLength();

                entity.Property(e => e.Rpkco)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("RPKCO")
                    .IsFixedLength();

                entity.Property(e => e.Rpkcoo)
                    .HasMaxLength(5)
                    .HasColumnName("RPKCOO")
                    .IsFixedLength();

                entity.Property(e => e.Rplfcj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPLFCJ");

                entity.Property(e => e.Rplnid).HasColumnName("RPLNID");

                entity.Property(e => e.Rpmcu)
                    .HasMaxLength(12)
                    .HasColumnName("RPMCU")
                    .IsFixedLength();

                entity.Property(e => e.Rpmcu2)
                    .HasMaxLength(12)
                    .HasColumnName("RPMCU2")
                    .IsFixedLength();

                entity.Property(e => e.Rpnbrr)
                    .HasMaxLength(1)
                    .HasColumnName("RPNBRR")
                    .IsFixedLength();

                entity.Property(e => e.Rpnetdoc).HasColumnName("RPNETDOC");

                entity.Property(e => e.Rpnetrc5).HasColumnName("RPNETRC5");

                entity.Property(e => e.Rpnetst)
                    .HasMaxLength(1)
                    .HasColumnName("RPNETST")
                    .IsFixedLength();

                entity.Property(e => e.Rpnettcid).HasColumnName("RPNETTCID");

                entity.Property(e => e.Rpnrta).HasColumnName("RPNRTA");

                entity.Property(e => e.Rpobj)
                    .HasMaxLength(6)
                    .HasColumnName("RPOBJ")
                    .IsFixedLength();

                entity.Property(e => e.Rpodct)
                    .HasMaxLength(2)
                    .HasColumnName("RPODCT")
                    .IsFixedLength();

                entity.Property(e => e.Rpodoc).HasColumnName("RPODOC");

                entity.Property(e => e.Rpokco)
                    .HasMaxLength(5)
                    .HasColumnName("RPOKCO")
                    .IsFixedLength();

                entity.Property(e => e.Rpomod)
                    .HasMaxLength(1)
                    .HasColumnName("RPOMOD")
                    .IsFixedLength();

                entity.Property(e => e.Rposfx)
                    .HasMaxLength(3)
                    .HasColumnName("RPOSFX")
                    .IsFixedLength();

                entity.Property(e => e.Rppa8).HasColumnName("RPPA8");

                entity.Property(e => e.Rppdct)
                    .HasMaxLength(2)
                    .HasColumnName("RPPDCT")
                    .IsFixedLength();

                entity.Property(e => e.Rppid)
                    .HasMaxLength(10)
                    .HasColumnName("RPPID")
                    .IsFixedLength();

                entity.Property(e => e.Rppkco)
                    .HasMaxLength(5)
                    .HasColumnName("RPPKCO")
                    .IsFixedLength();

                entity.Property(e => e.Rppn).HasColumnName("RPPN");

                entity.Property(e => e.Rppo)
                    .HasMaxLength(8)
                    .HasColumnName("RPPO")
                    .IsFixedLength();

                entity.Property(e => e.Rppost)
                    .HasMaxLength(1)
                    .HasColumnName("RPPOST")
                    .IsFixedLength();

                entity.Property(e => e.Rpppdi)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPPPDI");

                entity.Property(e => e.Rpprgf)
                    .HasMaxLength(1)
                    .HasColumnName("RPPRGF")
                    .IsFixedLength();

                entity.Property(e => e.Rppst)
                    .HasMaxLength(1)
                    .HasColumnName("RPPST")
                    .IsFixedLength();

                entity.Property(e => e.Rpptc)
                    .HasMaxLength(3)
                    .HasColumnName("RPPTC")
                    .IsFixedLength();

                entity.Property(e => e.Rppwpg).HasColumnName("RPPWPG");

                entity.Property(e => e.Rppyid).HasColumnName("RPPYID");

                entity.Property(e => e.Rppyr).HasColumnName("RPPYR");

                entity.Property(e => e.Rprddj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPRDDJ");

                entity.Property(e => e.Rprdrl)
                    .HasMaxLength(1)
                    .HasColumnName("RPRDRL")
                    .IsFixedLength();

                entity.Property(e => e.Rprdsj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPRDSJ");

                entity.Property(e => e.Rprf)
                    .HasMaxLength(2)
                    .HasColumnName("RPRF")
                    .IsFixedLength();

                entity.Property(e => e.Rprmds).HasColumnName("RPRMDS");

                entity.Property(e => e.Rprmk)
                    .HasMaxLength(30)
                    .HasColumnName("RPRMK")
                    .IsFixedLength();

                entity.Property(e => e.Rprnid).HasColumnName("RPRNID");

                entity.Property(e => e.Rprp1)
                    .HasMaxLength(1)
                    .HasColumnName("RPRP1")
                    .IsFixedLength();

                entity.Property(e => e.Rprp2)
                    .HasMaxLength(1)
                    .HasColumnName("RPRP2")
                    .IsFixedLength();

                entity.Property(e => e.Rprp3)
                    .HasMaxLength(1)
                    .HasColumnName("RPRP3")
                    .IsFixedLength();

                entity.Property(e => e.Rprsco)
                    .HasMaxLength(2)
                    .HasColumnName("RPRSCO")
                    .IsFixedLength();

                entity.Property(e => e.Rpryin)
                    .HasMaxLength(1)
                    .HasColumnName("RPRYIN")
                    .IsFixedLength();

                entity.Property(e => e.Rpsbl)
                    .HasMaxLength(8)
                    .HasColumnName("RPSBL")
                    .IsFixedLength();

                entity.Property(e => e.Rpsblt)
                    .HasMaxLength(1)
                    .HasColumnName("RPSBLT")
                    .IsFixedLength();

                entity.Property(e => e.Rpsdct)
                    .HasMaxLength(2)
                    .HasColumnName("RPSDCT")
                    .IsFixedLength();

                entity.Property(e => e.Rpsdoc).HasColumnName("RPSDOC");

                entity.Property(e => e.Rpsfx)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("RPSFX")
                    .IsFixedLength();

                entity.Property(e => e.Rpsfxo)
                    .HasMaxLength(3)
                    .HasColumnName("RPSFXO")
                    .IsFixedLength();

                entity.Property(e => e.Rpshpn).HasColumnName("RPSHPN");

                entity.Property(e => e.Rpskco)
                    .HasMaxLength(5)
                    .HasColumnName("RPSKCO")
                    .IsFixedLength();

                entity.Property(e => e.Rpsmtj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPSMTJ");

                entity.Property(e => e.Rpsotf)
                    .HasMaxLength(1)
                    .HasColumnName("RPSOTF")
                    .IsFixedLength();

                entity.Property(e => e.Rpstam).HasColumnName("RPSTAM");

                entity.Property(e => e.Rpsub)
                    .HasMaxLength(8)
                    .HasColumnName("RPSUB")
                    .IsFixedLength();

                entity.Property(e => e.Rptorg)
                    .HasMaxLength(10)
                    .HasColumnName("RPTORG")
                    .IsFixedLength();

                entity.Property(e => e.Rptxa1)
                    .HasMaxLength(10)
                    .HasColumnName("RPTXA1")
                    .IsFixedLength();

                entity.Property(e => e.Rpu).HasColumnName("RPU");

                entity.Property(e => e.Rpum)
                    .HasMaxLength(2)
                    .HasColumnName("RPUM")
                    .IsFixedLength();

                entity.Property(e => e.Rpunit)
                    .HasMaxLength(8)
                    .HasColumnName("RPUNIT")
                    .IsFixedLength();

                entity.Property(e => e.Rpupmj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPUPMJ");

                entity.Property(e => e.Rpupmt).HasColumnName("RPUPMT");

                entity.Property(e => e.Rpurab).HasColumnName("RPURAB");

                entity.Property(e => e.Rpurat).HasColumnName("RPURAT");

                entity.Property(e => e.Rpurc1)
                    .HasMaxLength(3)
                    .HasColumnName("RPURC1")
                    .IsFixedLength();

                entity.Property(e => e.Rpurdt)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPURDT");

                entity.Property(e => e.Rpurrf)
                    .HasMaxLength(15)
                    .HasColumnName("RPURRF")
                    .IsFixedLength();

                entity.Property(e => e.Rpuser)
                    .HasMaxLength(10)
                    .HasColumnName("RPUSER")
                    .IsFixedLength();

                entity.Property(e => e.Rpvdgj)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPVDGJ");

                entity.Property(e => e.Rpvinv)
                    .HasMaxLength(25)
                    .HasColumnName("RPVINV")
                    .IsFixedLength();

                entity.Property(e => e.Rpvldt)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RPVLDT");

                entity.Property(e => e.Rpvod)
                    .HasMaxLength(1)
                    .HasColumnName("RPVOD")
                    .IsFixedLength();

                entity.Property(e => e.Rpvr01)
                    .HasMaxLength(25)
                    .HasColumnName("RPVR01")
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

                entity.ToTable("GssAdjuntoTarea");

                entity.HasIndex(e => e.IdTarea, "IX_IdTarea");

                entity.Property(e => e.Archivo).IsRequired();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdTareaNavigation)
                    .WithMany(p => p.GssAdjuntoTareas)
                    .HasForeignKey(d => d.IdTarea)
                    .HasConstraintName("FK_GssAdjuntoTarea_GssTarea");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.GssAdjuntoTareas)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAdjuntoTarea_GssTipoDocumento");
            });

            modelBuilder.Entity<GssAdminApp>(entity =>
            {
                entity.HasKey(e => new { e.IdUnidadServicio, e.IdUsuario });

                entity.ToTable("GssAdminApp");
            });

            modelBuilder.Entity<GssAprobacionServicio>(entity =>
            {
                entity.HasKey(e => e.IdAprobacionServicio);

                entity.ToTable("GssAprobacionServicio");

                entity.HasIndex(e => new { e.IdEstatusTarea, e.IdUsuario, e.IdTarea, e.Secuencia }, "IX_EstatusUsuarioTareaSecuencia")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdTarea, e.Secuencia }, "IX_IdTarea_Secuencia")
                    .IsUnique();

                entity.HasIndex(e => e.IdEstatusTarea, "IX_Servicios_x_Ejecutar");

                entity.Property(e => e.FechaEntrada).HasColumnType("datetime");

                entity.Property(e => e.FechaSalida).HasColumnType("datetime");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdEstatusTareaNavigation)
                    .WithMany(p => p.GssAprobacionServicios)
                    .HasForeignKey(d => d.IdEstatusTarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAprobacionServicio_GssEstatusTarea");

                entity.HasOne(d => d.IdNivelNavigation)
                    .WithMany(p => p.GssAprobacionServicios)
                    .HasForeignKey(d => d.IdNivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAprobacionServicio_GssNivel");

                entity.HasOne(d => d.IdTareaNavigation)
                    .WithMany(p => p.GssAprobacionServicios)
                    .HasForeignKey(d => d.IdTarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAprobacionServicio_GssTarea");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.GssAprobacionServicios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAprobacionServicio_SegUsuario");
            });

            modelBuilder.Entity<GssAreaServicio>(entity =>
            {
                entity.HasKey(e => e.IdAreaServicio);

                entity.ToTable("GssAreaServicio");

                entity.HasComment("Areas de Servicio por Unidad (Dpto.)");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.NombreAreaServicio)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.IdUnidadServicioNavigation)
                    .WithMany(p => p.GssAreaServicios)
                    .HasForeignKey(d => d.IdUnidadServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssAreaServicio_GssUnidadServicio");
            });

            modelBuilder.Entity<GssCompañium>(entity =>
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

                entity.ToTable("GssEstatusSolicitud");

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

                entity.ToTable("GssEstatusTarea");

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

                entity.ToTable("GssGrupoTrabajo");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.IdUnidadServicio).HasDefaultValueSql("((0))");

                entity.Property(e => e.NombreGrupoTrabajo)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<GssGrupoTrabajoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdGrupoTrabajoUsuario);

                entity.ToTable("GssGrupoTrabajoUsuario");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");
            });

            modelBuilder.Entity<GssMtrTipoDato>(entity =>
            {
                entity.HasKey(e => e.IdTipoDato);

                entity.ToTable("GssMtrTipoDato");

                entity.HasIndex(e => e.Orden, "IX_GssMtrTipoDato")
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

                entity.ToTable("GssNivel");

                entity.HasComment("Niveles por area de servicio");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.NombreNivel)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.IdUnidadServicioNavigation)
                    .WithMany(p => p.GssNivels)
                    .HasForeignKey(d => d.IdUnidadServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssNivel_GssNivel");
            });

            modelBuilder.Entity<GssPai>(entity =>
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

                entity.ToTable("GssPasoSolicitud");

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.GssPasoSolicituds)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssPasoSolicitud_GssSolicitud");
            });

            modelBuilder.Entity<GssPlantillaServicio>(entity =>
            {
                entity.HasKey(e => e.IdPlantillaServicio);

                entity.ToTable("GssPlantillaServicio");

                entity.HasComment("Plantilla de Servicio");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.FuncionBusqueda).HasMaxLength(80);

                entity.Property(e => e.OcultaDuplicado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.GssPlantillaServicios)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssPlantillaServicio_GssServicios");

                entity.HasOne(d => d.IdVariableNavigation)
                    .WithMany(p => p.GssPlantillaServicios)
                    .HasForeignKey(d => d.IdVariable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssPlantillaServicio_GssVariablesPlantilla");
            });

            modelBuilder.Entity<GssServicio>(entity =>
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

            modelBuilder.Entity<GssServicioNivel>(entity =>
            {
                entity.HasKey(e => e.IdServicioNivel);

                entity.ToTable("GssServicioNivel");

                entity.HasComment("Niveles por servicios");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.HasOne(d => d.IdNivelNavigation)
                    .WithMany(p => p.GssServicioNivels)
                    .HasForeignKey(d => d.IdNivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssServicioNivel_GssNivel");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.GssServicioNivels)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssServicioNivel_GssServicios");
            });

            modelBuilder.Entity<GssServicioResponsable>(entity =>
            {
                entity.HasKey(e => e.IdServicioResponsable);

                entity.ToTable("GssServicioResponsable");

                entity.HasIndex(e => new { e.IdServicio, e.IdTipoNomina, e.IdResponsable, e.Secuencia }, "IX_GssServicioResponsable")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdServicio, e.IdResponsable }, "IX_GssServicioResponsable_1");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.IdTipoNomina)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<GssSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud)
                    .HasName("PK_GssSolicitudServicio");

                entity.ToTable("GssSolicitud");

                entity.HasComment("Registro Solicitud de Servicio");

                entity.Property(e => e.DescripcionSolicitud).IsRequired();

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");

                entity.Property(e => e.JustificacionSolicitud).IsRequired();

                entity.Property(e => e.TituloSolicitud)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.IdEstatusSolicitudNavigation)
                    .WithMany(p => p.GssSolicituds)
                    .HasForeignKey(d => d.IdEstatusSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssSolicitud_GssEstatusSolicitud");

                entity.HasOne(d => d.IdUnidadServicioNavigation)
                    .WithMany(p => p.GssSolicituds)
                    .HasForeignKey(d => d.IdUnidadServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssSolicitud_GssUnidadServicio");
            });

            modelBuilder.Entity<GssSolicitudServicio>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudServicio)
                    .HasName("PK_GssSolicitudServicio_1");

                entity.ToTable("GssSolicitudServicio");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");
            });

            modelBuilder.Entity<GssTarea>(entity =>
            {
                entity.HasKey(e => e.IdTarea)
                    .HasName("PK_GssTareas");

                entity.ToTable("GssTarea");

                entity.HasComment("Registro de Tareas por Solicitud");

                entity.HasIndex(e => e.IdSolicitud, "IX_IdSolicitud");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.FechaProcesada).HasColumnType("datetime");

                entity.Property(e => e.FechaTarea).HasColumnType("datetime");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.GssTareas)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssTareas_GssServicios");

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.GssTareas)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssTarea_GssSolicitud");
            });

            modelBuilder.Entity<GssTareaComentario>(entity =>
            {
                entity.HasKey(e => e.IdComentarioTarea)
                    .IsClustered(false);

                entity.ToTable("GssTareaComentario");

                entity.Property(e => e.ComentarioTarea)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaComentario).HasColumnType("datetime");

                entity.HasOne(d => d.IdTareaNavigation)
                    .WithMany(p => p.GssTareaComentarios)
                    .HasForeignKey(d => d.IdTarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssTareaComentario_GssTarea");
            });

            modelBuilder.Entity<GssTareaPlantillaServicio>(entity =>
            {
                entity.HasKey(e => e.IdTareaPlantillaServicio);

                entity.ToTable("GssTareaPlantillaServicio");

                entity.HasComment("Detalle de Tarea Plantilla de Srvicio");

                entity.HasIndex(e => new { e.IdTarea, e.IdVariable }, "IX_GssTareaPlantillaServicio");

                entity.HasIndex(e => new { e.IdTarea, e.IdVariable }, "IX_IdTarea_IdVariable")
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
                    .WithMany(p => p.GssTareaPlantillaServicios)
                    .HasForeignKey(d => d.IdPlantillaServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssTareaPlantillaServicio_GssPlantillaServicio");

                entity.HasOne(d => d.IdTareaNavigation)
                    .WithMany(p => p.GssTareaPlantillaServicios)
                    .HasForeignKey(d => d.IdTarea)
                    .HasConstraintName("FK_GssTareaPlantillaServicio_GssTarea");
            });

            modelBuilder.Entity<GssTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento);

                entity.ToTable("GssTipoDocumento");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombreDocumento)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GssTipoServicio>(entity =>
            {
                entity.HasKey(e => e.IdTipoServicio);

                entity.ToTable("GssTipoServicio");

                entity.HasComment("Tipo de Servicio por Area / Unudad");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.NombreTipoServicio)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.IdAreaServicioNavigation)
                    .WithMany(p => p.GssTipoServicios)
                    .HasForeignKey(d => d.IdAreaServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssTipoServicio_GssAreaServicio");
            });

            modelBuilder.Entity<GssUnidadServicio>(entity =>
            {
                entity.HasKey(e => e.IdUnidadServicio);

                entity.ToTable("GssUnidadServicio");

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

            modelBuilder.Entity<GssUnidadServicioCompañium>(entity =>
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

            modelBuilder.Entity<GssUsuarioCompañium>(entity =>
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

                entity.ToTable("GssUsuarioNivel");

                entity.HasComment("Usuario por niveles de servicio");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.HasOne(d => d.IdNivelNavigation)
                    .WithMany(p => p.GssUsuarioNivels)
                    .HasForeignKey(d => d.IdNivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssUsuarioNivel_GssNivel");
            });

            modelBuilder.Entity<GssUsuarioPlantillaServicio>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioPlantillaServicio)
                    .HasName("PK_GssUsuarioPlantillaServicio_1");

                entity.ToTable("GssUsuarioPlantillaServicio");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.GssUsuarioPlantillaServicios)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssUsuarioPlantillaServicio_GssServicios");

                entity.HasOne(d => d.IdVariableNavigation)
                    .WithMany(p => p.GssUsuarioPlantillaServicios)
                    .HasForeignKey(d => d.IdVariable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GssUsuarioPlantillaServicio_GssVariable");
            });

            modelBuilder.Entity<GssVariable>(entity =>
            {
                entity.HasKey(e => e.IdVariable)
                    .HasName("PK_GssVariablesPlantilla");

                entity.ToTable("GssVariable");

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

            modelBuilder.Entity<HistoricoNomina>(entity =>
            {
                entity.ToTable("HistoricoNomina");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodigoEmpresa)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("CODIGO_EMPRESA");

                entity.Property(e => e.CodigoPeriodo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("CODIGO_PERIODO");

                entity.Property(e => e.CodigoPersona)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("CODIGO_PERSONA");

                entity.Property(e => e.CodigoTipoNomina)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("CODIGO_TIPO_NOMINA");

                entity.HasOne(d => d.Codigo)
                    .WithMany(p => p.HistoricoNominas)
                    .HasForeignKey(d => new { d.CodigoEmpresa, d.CodigoPersona, d.CodigoTipoNomina, d.CodigoPeriodo })
                    .HasConstraintName("FK_HistoricoNomina_HistoricoPersonalCargo");
            });

            modelBuilder.Entity<HistoricoPersonalCargo>(entity =>
            {
                entity.HasKey(e => new { e.CodigoEmpresa, e.CodigoPersona, e.CodigoTipoNomina, e.CodigoPeriodo });

                entity.ToTable("HistoricoPersonalCargo");

                entity.Property(e => e.CodigoEmpresa)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("CODIGO_EMPRESA");

                entity.Property(e => e.CodigoPersona)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("CODIGO_PERSONA");

                entity.Property(e => e.CodigoTipoNomina)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("CODIGO_TIPO_NOMINA");

                entity.Property(e => e.CodigoPeriodo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("CODIGO_PERIODO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(10)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Marm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MARM");

                entity.HasIndex(e => new { e.Matnr, e.Meinh }, "IX_MARM")
                    .IsUnique();

                entity.Property(e => e.Atinn)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("ATINN");

                entity.Property(e => e.BflmeMarm)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("BFLME_MARM");

                entity.Property(e => e.Breit)
                    .HasColumnType("decimal(13, 3)")
                    .HasColumnName("BREIT");

                entity.Property(e => e.Brgew)
                    .HasColumnType("decimal(13, 3)")
                    .HasColumnName("BRGEW");

                entity.Property(e => e.Capause)
                    .HasColumnType("decimal(15, 3)")
                    .HasColumnName("CAPAUSE");

                entity.Property(e => e.Ean11)
                    .IsRequired()
                    .HasMaxLength(108)
                    .HasColumnName("EAN11");

                entity.Property(e => e.Eannr)
                    .IsRequired()
                    .HasMaxLength(78)
                    .HasColumnName("EANNR");

                entity.Property(e => e.Gewei)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("GEWEI");

                entity.Property(e => e.GtinVariant)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("GTIN_VARIANT");

                entity.Property(e => e.Hoehe)
                    .HasColumnType("decimal(13, 3)")
                    .HasColumnName("HOEHE");

                entity.Property(e => e.Kzwso)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("KZWSO");

                entity.Property(e => e.Laeng)
                    .HasColumnType("decimal(13, 3)")
                    .HasColumnName("LAENG");

                entity.Property(e => e.Mandt)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("MANDT");

                entity.Property(e => e.Matnr)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("MATNR");

                entity.Property(e => e.MaxStack).HasColumnName("MAX_STACK");

                entity.Property(e => e.Meabm)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("MEABM");

                entity.Property(e => e.Meinh)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("MEINH");

                entity.Property(e => e.Mesrt)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("MESRT");

                entity.Property(e => e.Mesub)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("MESUB");

                entity.Property(e => e.Msehi)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("MSEHI");

                entity.Property(e => e.NestFtr)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("NEST_FTR");

                entity.Property(e => e.Numtp)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("NUMTP");

                entity.Property(e => e.Ty2tq)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("TY2TQ");

                entity.Property(e => e.Umren)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("UMREN");

                entity.Property(e => e.Umrez)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("UMREZ");

                entity.Property(e => e.Voleh)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("VOLEH");

                entity.Property(e => e.Volum)
                    .HasColumnType("decimal(13, 3)")
                    .HasColumnName("VOLUM");

                entity.Property(e => e.Xbeww)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("XBEWW");

                entity.Property(e => e.Xfhdw)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("XFHDW");

                entity.HasOne(d => d.MatnrNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Matnr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MARM_MtrProducto");

                entity.HasOne(d => d.MeinhNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Meinh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MARM_T006A");
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

            modelBuilder.Entity<MtrBanco>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("WARY075_INDEX01");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.AplicaImp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APLICA_IMP");

                entity.Property(e => e.CodContable)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("COD_CONTABLE");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.ProdGenerico)
                    .HasMaxLength(20)
                    .HasColumnName("PROD_GENERICO")
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.TraAsociada)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRA_ASOCIADA");

                entity.Property(e => e.TraJde)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRA_JDE")
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

                entity.ToTable("MtrCliente");

                entity.HasIndex(e => e.Codigo, "IX_MtrCliente");

                entity.HasIndex(e => e.Vendedor1, "IX_MtrCliente_1");

                entity.HasIndex(e => e.CodJde, "IX_MtrCliente_2");

                entity.HasIndex(e => e.OficinaVenta, "IX_MtrCliente_3");

                entity.HasIndex(e => e.Nombre, "IX_MtrCliente_4");

                entity.HasIndex(e => e.FlagInactivo, "IX_MtrCliente_5");

                entity.HasIndex(e => new { e.Codigo, e.NoRegTribut, e.Nombre }, "IX_MtrCliente_6");

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.AreaCobranz)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Area_Cobranz")
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Canal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANAL")
                    .IsFixedLength();

                entity.Property(e => e.CapitalSoc)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CAPITAL_SOC");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CIERRE_EJERC");

                entity.Property(e => e.ClientContado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Client_Contado")
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cliente_Nuevo")
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");

                entity.Property(e => e.CodJdePadre).HasColumnName("Cod_jdePadre");

                entity.Property(e => e.CodMcpo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Mcpo")
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Proveedor")
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cod_SubSegmento")
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Ciudad")
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Estado")
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Mcpo")
                    .IsFixedLength();

                entity.Property(e => e.CodigoNumerico)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("codigo_numerico");

                entity.Property(e => e.CodigoParroq)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Parroq")
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Postal")
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Region")
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("COND_PAGO");

                entity.Property(e => e.ContCarg1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Carg_1")
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Carg_2")
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Carg_3")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_1")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_2")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_3")
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Especial")
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Cont_FechNacm_1");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Cont_FechNacm_2");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Cont_FechNacm_3");

                entity.Property(e => e.ContNomb1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_1")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_2")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_3")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_1")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_2")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_3")
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEPURA_COD")
                    .IsFixedLength();

                entity.Property(e => e.Depurar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("depurar")
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Dia_de_Cobro")
                    .IsFixedLength();

                entity.Property(e => e.Direccion).HasMaxLength(80);

                entity.Property(e => e.Direccion1).HasMaxLength(80);

                entity.Property(e => e.Direccion2).HasMaxLength(80);

                entity.Property(e => e.EMailClient)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("E_mail_Client")
                    .IsFixedLength();

                entity.Property(e => e.Estado).HasMaxLength(2);

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Exento_de_Impuesto")
                    .IsFixedLength();

                entity.Property(e => e.FApertura)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_Apertura");

                entity.Property(e => e.FModificacion)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_Modificacion");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_Ultm_Compra");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAtendido)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Atendido");

                entity.Property(e => e.FechaCerrado)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Cerrado");

                entity.Property(e => e.FechaDesatendido)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Desatendido");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Inactivo");

                entity.Property(e => e.FechaLegal)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_LEGAL");

                entity.Property(e => e.FechaModificadoLimite)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_modificado_Limite");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Reactivado");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_RIESGO");

                entity.Property(e => e.FlagAtendido)
                    .HasMaxLength(1)
                    .HasColumnName("Flag_Atendido")
                    .IsFixedLength();

                entity.Property(e => e.FlagCerrado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Cerrado")
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Inactivo")
                    .IsFixedLength();

                entity.Property(e => e.FlagMat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Mat")
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Modificado")
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Nuevo")
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Giro_Negocio")
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoCliente)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("GRUPO_CLIENTE");

                entity.Property(e => e.IdDireccion)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Id_direccion");

                entity.Property(e => e.Klabc)
                    .HasMaxLength(2)
                    .HasColumnName("KLABC")
                    .HasDefaultValueSql("(N'C')");

                entity.Property(e => e.LCredito)
                    .HasColumnType("money")
                    .HasColumnName("L_Credito");

                entity.Property(e => e.Legal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LEGAL")
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("Limite_Cred_Ut");

                entity.Property(e => e.Municipio).HasMaxLength(2);

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoPasoJde)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasMaxLength(12)
                    .HasColumnName("No_Reg_Tribut");

                entity.Property(e => e.Nombre).HasMaxLength(80);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OficinaVenta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Oficina_Venta")
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Orden_Compra")
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Pagina_Web")
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Repres_Legal")
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RIESGO")
                    .IsFixedLength();

                entity.Property(e => e.Rsaldo)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("RSaldo");

                entity.Property(e => e.RutCartero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Rut_Cartero")
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
                    .HasMaxLength(50)
                    .HasColumnName("smacc");

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
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Negocio")
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MOD")
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
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN01")
                    .HasComment("Página Web")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Zzsn02)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN02")
                    .HasComment("Facebook")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Zzsn03)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN03")
                    .HasComment("Google+")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Zzsn04)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN04")
                    .HasComment("Instagram")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Zzsn05)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN05")
                    .HasComment("Twitter")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Zzsn06)
                    .HasMaxLength(8)
                    .HasColumnName("ZZSN06")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MtrClienteEnvioOdooLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MtrClienteEnvioOdooLog");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdCliente).HasMaxLength(10);

                entity.Property(e => e.JsonSend).HasMaxLength(4000);

                entity.Property(e => e.Mensaje).HasMaxLength(4000);
            });

            modelBuilder.Entity<MtrClienteProspecto>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("MtrClienteProspecto");

                entity.HasIndex(e => e.Rif, "IX_Rif")
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
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Area_Cobranz")
                    .IsFixedLength();

                entity.Property(e => e.Asignacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Canal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANAL")
                    .IsFixedLength();

                entity.Property(e => e.CapitalSoc)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CAPITAL_SOC");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CierreEjerc)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CIERRE_EJERC");

                entity.Property(e => e.ClientContado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Client_Contado")
                    .IsFixedLength();

                entity.Property(e => e.ClienteNuevo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cliente_Nuevo")
                    .IsFixedLength();

                entity.Property(e => e.Cobrador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodJde).HasColumnName("cod_jde");

                entity.Property(e => e.CodJdePadre).HasColumnName("Cod_jdePadre");

                entity.Property(e => e.CodMcpo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Mcpo")
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Proveedor")
                    .IsFixedLength();

                entity.Property(e => e.CodSubSegmento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cod_SubSegmento")
                    .IsFixedLength();

                entity.Property(e => e.CodigoCiudad)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Ciudad")
                    .IsFixedLength();

                entity.Property(e => e.CodigoEstado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Estado")
                    .IsFixedLength();

                entity.Property(e => e.CodigoMcpo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Mcpo")
                    .IsFixedLength();

                entity.Property(e => e.CodigoNumerico)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("codigo_numerico");

                entity.Property(e => e.CodigoParroq)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Parroq")
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Postal")
                    .IsFixedLength();

                entity.Property(e => e.CodigoRegion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_Region")
                    .IsFixedLength();

                entity.Property(e => e.CondPago)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("COND_PAGO");

                entity.Property(e => e.ContCarg1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Carg_1")
                    .IsFixedLength();

                entity.Property(e => e.ContCarg2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Carg_2")
                    .IsFixedLength();

                entity.Property(e => e.ContCarg3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Carg_3")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_1")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_2")
                    .IsFixedLength();

                entity.Property(e => e.ContEmail3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Email_3")
                    .IsFixedLength();

                entity.Property(e => e.ContEspecial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Especial")
                    .IsFixedLength();

                entity.Property(e => e.ContFechNacm1)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Cont_FechNacm_1");

                entity.Property(e => e.ContFechNacm2)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Cont_FechNacm_2");

                entity.Property(e => e.ContFechNacm3)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Cont_FechNacm_3");

                entity.Property(e => e.ContNomb1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_1")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_2")
                    .IsFixedLength();

                entity.Property(e => e.ContNomb3)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Nomb_3")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_1")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_2")
                    .IsFixedLength();

                entity.Property(e => e.ContTelf3)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cont_Telf_3")
                    .IsFixedLength();

                entity.Property(e => e.DepuraCod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEPURA_COD")
                    .IsFixedLength();

                entity.Property(e => e.Depurar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("depurar")
                    .IsFixedLength();

                entity.Property(e => e.DiaDeCobro)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Dia_de_Cobro")
                    .IsFixedLength();

                entity.Property(e => e.Direccion).HasMaxLength(80);

                entity.Property(e => e.Direccion1).HasMaxLength(80);

                entity.Property(e => e.Direccion2).HasMaxLength(80);

                entity.Property(e => e.EMailClient)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("E_mail_Client")
                    .IsFixedLength();

                entity.Property(e => e.Estado).HasMaxLength(2);

                entity.Property(e => e.ExentoDeImpuesto)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Exento_de_Impuesto")
                    .IsFixedLength();

                entity.Property(e => e.FApertura)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_Apertura");

                entity.Property(e => e.FModificacion)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_Modificacion");

                entity.Property(e => e.FUltmCompra)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("F_Ultm_Compra");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAtendido)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Atendido");

                entity.Property(e => e.FechaCerrado)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Cerrado");

                entity.Property(e => e.FechaDesatendido)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Desatendido");

                entity.Property(e => e.FechaInactivo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Inactivo");

                entity.Property(e => e.FechaLegal)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_LEGAL");

                entity.Property(e => e.FechaModificadoLimite)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_modificado_Limite");

                entity.Property(e => e.FechaReactivado)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Reactivado");

                entity.Property(e => e.FechaRiesgo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_RIESGO");

                entity.Property(e => e.FlagAtendido)
                    .HasMaxLength(1)
                    .HasColumnName("Flag_Atendido")
                    .IsFixedLength();

                entity.Property(e => e.FlagCerrado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Cerrado")
                    .IsFixedLength();

                entity.Property(e => e.FlagInactivo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Inactivo")
                    .IsFixedLength();

                entity.Property(e => e.FlagMat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Mat")
                    .IsFixedLength();

                entity.Property(e => e.FlagMod03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagModificado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Modificado")
                    .IsFixedLength();

                entity.Property(e => e.FlagNuevo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Nuevo")
                    .IsFixedLength();

                entity.Property(e => e.GiroNegocio)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Giro_Negocio")
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoCliente)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("GRUPO_CLIENTE");

                entity.Property(e => e.IdDireccion)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Id_direccion");

                entity.Property(e => e.Klabc)
                    .HasMaxLength(2)
                    .HasColumnName("KLABC")
                    .HasDefaultValueSql("(N'C')");

                entity.Property(e => e.LCredito)
                    .HasColumnType("money")
                    .HasColumnName("L_Credito");

                entity.Property(e => e.Legal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LEGAL")
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredUt)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("Limite_Cred_Ut");

                entity.Property(e => e.Municipio).HasMaxLength(2);

                entity.Property(e => e.Nit)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoPasoJde)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NoRegTribut)
                    .HasMaxLength(12)
                    .HasColumnName("No_Reg_Tribut");

                entity.Property(e => e.Nombre).HasMaxLength(80);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OficinaVenta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Oficina_Venta")
                    .IsFixedLength();

                entity.Property(e => e.OrdenCompra)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Orden_Compra")
                    .IsFixedLength();

                entity.Property(e => e.PaginaWeb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Pagina_Web")
                    .IsFixedLength();

                entity.Property(e => e.RepresLegal)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Repres_Legal")
                    .IsFixedLength();

                entity.Property(e => e.Riesgo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RIESGO")
                    .IsFixedLength();

                entity.Property(e => e.RutCartero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Rut_Cartero")
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
                    .HasMaxLength(50)
                    .HasColumnName("smacc");

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
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Negocio")
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MOD")
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
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN01");

                entity.Property(e => e.Zzsn02)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN02");

                entity.Property(e => e.Zzsn03)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN03");

                entity.Property(e => e.Zzsn04)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN04");

                entity.Property(e => e.Zzsn05)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN05");

                entity.Property(e => e.Zzsn06)
                    .HasMaxLength(8)
                    .HasColumnName("ZZSN06");
            });

            modelBuilder.Entity<MtrCondicionPago>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("MtrCondicionPago");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.AprobCredM)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APROB_CRED_M")
                    .IsFixedLength();

                entity.Property(e => e.CodJde)
                    .HasMaxLength(3)
                    .HasColumnName("COD_JDE")
                    .IsFixedLength();

                entity.Property(e => e.CondicionSap)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("CondicionSAP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.DiasVcto).HasColumnName("DIAS_VCTO");

                entity.Property(e => e.Inactivo)
                    .HasMaxLength(1)
                    .HasColumnName("inactivo")
                    .IsFixedLength();

                entity.Property(e => e.OdooId).HasMaxLength(50);

                entity.Property(e => e.PorcRequerido).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.RequiereLimiteCredito)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MtrContacto>(entity =>
            {
                entity.HasKey(e => e.IdContacto);

                entity.HasIndex(e => e.Email, "IX_MtrContactos");

                entity.HasIndex(e => e.IdCliente, "IX_MtrContactos_1");

                entity.HasIndex(e => new { e.IdCliente, e.Rif }, "IX_MtrContactos_2");

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

                entity.Property(e => e.IdClienteOdoo).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdContactoOdoo).HasDefaultValueSql("((0))");

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

            modelBuilder.Entity<MtrContactosAl30052023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MtrContactosAl30052023");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Telefono1).HasMaxLength(50);

                entity.Property(e => e.Telefono2).HasMaxLength(50);

                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<MtrDireccione>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion1)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Direccion_1")
                    .IsFixedLength();

                entity.Property(e => e.Direccion2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Direccion_2")
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .IsFixedLength();

                entity.Property(e => e.FechaAprobacionDireccion).HasMaxLength(50);

                entity.Property(e => e.FechaUpdate).HasColumnType("smalldatetime");

                entity.Property(e => e.FuncionInterlocutor).HasMaxLength(2);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MUNICIPIO")
                    .IsFixedLength();

                entity.Property(e => e.Nuevo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NUEVO")
                    .IsFixedLength();

                entity.Property(e => e.Origen).HasMaxLength(40);

                entity.Property(e => e.Ort02)
                    .HasMaxLength(35)
                    .HasColumnName("ORT02");

                entity.Property(e => e.PuntoReferencia).HasMaxLength(80);

                entity.Property(e => e.Recnum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rif)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StmpAddr)
                    .HasMaxLength(240)
                    .HasColumnName("STMP_ADDR");

                entity.Property(e => e.Telf1)
                    .HasMaxLength(30)
                    .HasColumnName("TELF1");

                entity.Property(e => e.Telf2)
                    .HasMaxLength(30)
                    .HasColumnName("TELF2");

                entity.Property(e => e.UsuarioAprobacionDireccion).HasMaxLength(50);

                entity.Property(e => e.Zzsn01)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN01");

                entity.Property(e => e.Zzsn02)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN02");

                entity.Property(e => e.Zzsn03)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN03");

                entity.Property(e => e.Zzsn04)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN04");

                entity.Property(e => e.Zzsn05)
                    .HasMaxLength(50)
                    .HasColumnName("ZZSN05");

                entity.Property(e => e.Zzsn06)
                    .HasMaxLength(8)
                    .HasColumnName("ZZSN06");
            });

            modelBuilder.Entity<MtrEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.ToTable("MtrEmpleado");

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
                    .HasMaxLength(80)
                    .HasColumnName("email")
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
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

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

            modelBuilder.Entity<MtrFechaFeriadum>(entity =>
            {
                entity.HasKey(e => e.FechaFeriada);

                entity.Property(e => e.FechaFeriada)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FERIADA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.MostrarBs)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MOSTRAR_BS")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MOTIVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<MtrHorarioLaborable>(entity =>
            {
                entity.HasKey(e => e.IdHorario);

                entity.ToTable("MtrHorarioLaborable");

                entity.Property(e => e.Almuerzo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Fin)
                    .HasColumnType("datetime")
                    .HasColumnName("fin");

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

                entity.ToTable("MtrOficina");

                entity.Property(e => e.CodOficina)
                    .ValueGeneratedNever()
                    .HasColumnName("COD_OFICINA");

                entity.Property(e => e.Abreviado).HasMaxLength(3);

                entity.Property(e => e.AdministradoraEmail)
                    .HasMaxLength(50)
                    .HasColumnName("Administradora_email");

                entity.Property(e => e.Analista2Email)
                    .HasMaxLength(50)
                    .HasColumnName("Analista2_email");

                entity.Property(e => e.AnalistaEmail)
                    .HasMaxLength(50)
                    .HasColumnName("Analista_email");

                entity.Property(e => e.Canal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANAL")
                    .IsFixedLength();

                entity.Property(e => e.CarpetaDiseno)
                    .HasMaxLength(50)
                    .HasColumnName("CARPETA_DISENO");

                entity.Property(e => e.ClienteNacionales)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLIENTE_NACIONALES")
                    .IsFixedLength();

                entity.Property(e => e.CodOficina2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COD_OFICINA2");

                entity.Property(e => e.CodigoJde)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_JDE");

                entity.Property(e => e.CodigoParroq).HasColumnName("CODIGO_PARROQ");

                entity.Property(e => e.DataManagerEmail)
                    .HasMaxLength(50)
                    .HasColumnName("DataManager_email");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Direccion2)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION2");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FAX");

                entity.Property(e => e.GerenteOficina)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GERENTE_OFICINA");

                entity.Property(e => e.Idtitulo).HasColumnName("IDTITULO");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MUNICIPIO");

                entity.Property(e => e.NomOficina)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NOM_OFICINA");

                entity.Property(e => e.OficinaActiva)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OFICINA_ACTIVA")
                    .IsFixedLength();

                entity.Property(e => e.Override)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("OVERRIDE");

                entity.Property(e => e.PAusente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("P_AUSENTE");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGION");

                entity.Property(e => e.SinImpuesto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIN_IMPUESTO")
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO");

                entity.Property(e => e.UsuarioAdministradora).HasMaxLength(50);

                entity.Property(e => e.UsuarioAnalista).HasMaxLength(50);
            });

            modelBuilder.Entity<MtrPerfilCorreo>(entity =>
            {
                entity.HasKey(e => e.PerfilId);

                entity.ToTable("MtrPerfilCorreo");

                entity.Property(e => e.PerfilId).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Perfil).HasMaxLength(50);
            });

            modelBuilder.Entity<MtrProducto>(entity =>
            {
                entity.HasKey(e => e.CodigoProduct)
                    .HasName("MtrProducto_INDEX01");

                entity.ToTable("MtrProducto");

                entity.HasIndex(e => e.Recnum, "IX_MtrProducto");

                entity.Property(e => e.CodigoProduct)
                    .HasMaxLength(12)
                    .HasColumnName("CODIGO_PRODUCT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Almacensap)
                    .HasMaxLength(4)
                    .HasColumnName("ALMACENSAP");

                entity.Property(e => e.CantidadXAnch).HasColumnName("CANTIDAD_X_ANCH");

                entity.Property(e => e.CategoriaDashBoard)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodJde)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("COD_JDE");

                entity.Property(e => e.CodResponsable)
                    .HasColumnName("COD_RESPONSABLE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Codcorp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CODCORP")
                    .IsFixedLength();

                entity.Property(e => e.CodigoCaja)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodprodRpg)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODPROD_RPG")
                    .IsFixedLength();

                entity.Property(e => e.Consecutivo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("consecutivo");

                entity.Property(e => e.CostoReposicion)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DescripVta)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIP_VTA");

                entity.Property(e => e.DescripcionVentas).HasMaxLength(1000);

                entity.Property(e => e.FamiliaProduct)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FAMILIA_PRODUCT")
                    .IsFixedLength();

                entity.Property(e => e.FlagCorp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_CORP")
                    .IsFixedLength();

                entity.Property(e => e.FlagCortoTiraje).HasMaxLength(1);

                entity.Property(e => e.FlagDesact)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_DESACT")
                    .IsFixedLength();

                entity.Property(e => e.FlagPrdIntern)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_PRD_INTERN")
                    .IsFixedLength();

                entity.Property(e => e.FlagPrecioMinimo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagRollo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ROLLO");

                entity.Property(e => e.IdUnidadCosteoSap)
                    .HasMaxLength(18)
                    .HasColumnName("IdUnidadCosteoSAP");

                entity.Property(e => e.Idsubcategoria)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("IDSUBCATEGORIA");

                entity.Property(e => e.ImpPorConsumo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMP_POR_CONSUMO")
                    .IsFixedLength();

                entity.Property(e => e.LineaIncoming).HasColumnName("LINEA_INCOMING");

                entity.Property(e => e.LineaProducto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LINEA_PRODUCTO")
                    .IsFixedLength();

                entity.Property(e => e.ManejaInv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MANEJA_INV")
                    .HasDefaultValueSql("('')")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Miscelaneo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.PesoKilos).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.PiesCuadradoUnidad).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PorcCosto).HasColumnName("PORC_COSTO");

                entity.Property(e => e.PorcMcAprob)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("PORC_MC_APROB");

                entity.Property(e => e.Prefijo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PREFIJO")
                    .IsFixedLength();

                entity.Property(e => e.PrintNoPrint)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Print_NoPrint")
                    .IsFixedLength();

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Sufijo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUFIJO")
                    .IsFixedLength();

                entity.Property(e => e.SujetoALote)
                    .HasMaxLength(1)
                    .HasColumnName("SUJETO_A_LOTE");

                entity.Property(e => e.TipoProducto).HasColumnName("TIPO_PRODUCTO");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TITULO")
                    .IsFixedLength();

                entity.Property(e => e.Titulo1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TITULO1")
                    .IsFixedLength();

                entity.Property(e => e.Titulo2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TITULO2")
                    .IsFixedLength();

                entity.Property(e => e.Titulo3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TITULO3")
                    .IsFixedLength();

                entity.Property(e => e.Titulo4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TITULO4")
                    .IsFixedLength();

                entity.Property(e => e.Titulo5)
                    .HasColumnName("TITULO5")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Titulo6)
                    .HasColumnName("TITULO6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TituloPe)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TITULO_PE")
                    .IsFixedLength();

                entity.Property(e => e.TituloVentas)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TITULO_VENTAS")
                    .IsFixedLength();

                entity.Property(e => e.UnidadCosteo).HasColumnName("UNIDAD_COSTEO");

                entity.Property(e => e.Unidadsap)
                    .HasMaxLength(3)
                    .HasColumnName("UNIDADSAP");

                entity.Property(e => e.UnidadsapVenta)
                    .HasMaxLength(3)
                    .HasColumnName("UNIDADSAP_VENTA");

                entity.Property(e => e.UnidadsapVentainterna)
                    .HasMaxLength(3)
                    .HasColumnName("UNIDADSAP_VENTAINTERNA");

                entity.Property(e => e.Web)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WEB")
                    .IsFixedLength();

                entity.HasOne(d => d.IdUnidadCosteoSapNavigation)
                    .WithMany(p => p.MtrProductos)
                    .HasForeignKey(d => d.IdUnidadCosteoSap)
                    .HasConstraintName("FK_MtrProducto_T006A");
            });

            modelBuilder.Entity<MtrProductoBasica>(entity =>
            {
                entity.HasKey(e => new { e.Producto, e.MedidaMascara })
                    .HasName("PK_MtrProductoBasica_1");

                entity.ToTable("MtrProductoBasica");

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

            modelBuilder.Entity<MtrProductoOpuestum>(entity =>
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

            modelBuilder.Entity<MtrProductoPapele>(entity =>
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

            modelBuilder.Entity<MtrRegione>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodigoJde)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_JDE");

                entity.Property(e => e.CodigoRegion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_REGION");

                entity.Property(e => e.GerenteRegion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GERENTE_REGION");

                entity.Property(e => e.NombreRegion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_REGION");

                entity.Property(e => e.OverrideRegion)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("OVERRIDE_REGION");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<MtrTipoCuentaDestino>(entity =>
            {
                entity.HasKey(e => e.IdTipoCuentaDestino);

                entity.ToTable("MtrTipoCuentaDestino");

                entity.Property(e => e.IdTipoCuentaDestino).ValueGeneratedNever();

                entity.Property(e => e.NombreCuentaDestino)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<MtrTipoDocumentoFiscal>(entity =>
            {
                entity.HasKey(e => e.TipoDocumento);

                entity.ToTable("MtrTipoDocumentoFiscal");

                entity.Property(e => e.TipoDocumento).HasMaxLength(2);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MtrTipoMonedum>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.OdooId).HasMaxLength(50);
            });

            modelBuilder.Entity<MtrTipoNomina>(entity =>
            {
                entity.HasKey(e => e.Tipnom)
                    .HasName("PK_NMT003");

                entity.ToTable("MtrTipoNomina");

                entity.Property(e => e.Tipnom)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TIPNOM");

                entity.Property(e => e.Anocom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANOCOM");

                entity.Property(e => e.Asifon)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("ASIFON");

                entity.Property(e => e.Canmin)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("CANMIN");

                entity.Property(e => e.CiaCodcia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIA_CODCIA");

                entity.Property(e => e.Clanom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLANOM");

                entity.Property(e => e.Codcon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODCON");

                entity.Property(e => e.Codpai)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODPAI");

                entity.Property(e => e.Dedfon)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("DEDFON");

                entity.Property(e => e.Desm01)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM01");

                entity.Property(e => e.Desm02)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM02");

                entity.Property(e => e.Desm03)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM03");

                entity.Property(e => e.Desm04)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM04");

                entity.Property(e => e.Desm05)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM05");

                entity.Property(e => e.Desm06)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM06");

                entity.Property(e => e.Desm07)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM07");

                entity.Property(e => e.Desm08)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM08");

                entity.Property(e => e.Desm09)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM09");

                entity.Property(e => e.Desm10)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM10");

                entity.Property(e => e.Desm11)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM11");

                entity.Property(e => e.Desm12)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM12");

                entity.Property(e => e.Desm13)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM13");

                entity.Property(e => e.Desm14)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM14");

                entity.Property(e => e.Desm15)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM15");

                entity.Property(e => e.Desm16)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM16");

                entity.Property(e => e.Desm17)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM17");

                entity.Property(e => e.Desm18)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM18");

                entity.Property(e => e.Desm19)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM19");

                entity.Property(e => e.Desm20)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESM20");

                entity.Property(e => e.Desnom)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESNOM");

                entity.Property(e => e.Facgua)
                    .HasColumnType("numeric(13, 10)")
                    .HasColumnName("FACGUA");

                entity.Property(e => e.Fecabo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECABO");

                entity.Property(e => e.Fecact)
                    .HasColumnType("datetime")
                    .HasColumnName("FECACT");

                entity.Property(e => e.Feccre)
                    .HasColumnType("datetime")
                    .HasColumnName("FECCRE");

                entity.Property(e => e.Fecto1)
                    .HasColumnType("datetime")
                    .HasColumnName("FECTO1");

                entity.Property(e => e.Fecto2)
                    .HasColumnType("datetime")
                    .HasColumnName("FECTO2");

                entity.Property(e => e.Fecto3)
                    .HasColumnType("datetime")
                    .HasColumnName("FECTO3");

                entity.Property(e => e.Fecto4)
                    .HasColumnType("datetime")
                    .HasColumnName("FECTO4");

                entity.Property(e => e.Fecto5)
                    .HasColumnType("datetime")
                    .HasColumnName("FECTO5");

                entity.Property(e => e.Frenom)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("FRENOM");

                entity.Property(e => e.Fresue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FRESUE");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Pgmrec)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PGMREC");

                entity.Property(e => e.Reghab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGHAB");

                entity.Property(e => e.Salmin)
                    .HasColumnType("numeric(12, 5)")
                    .HasColumnName("SALMIN");

                entity.Property(e => e.Tasmon)
                    .HasColumnType("numeric(13, 10)")
                    .HasColumnName("TASMON");

                entity.Property(e => e.Tipfec)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("TIPFEC");

                entity.Property(e => e.Tipmon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIPMON");

                entity.Property(e => e.Topgua)
                    .HasColumnType("numeric(12, 5)")
                    .HasColumnName("TOPGUA");

                entity.Property(e => e.Unim01)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM01");

                entity.Property(e => e.Unim02)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM02");

                entity.Property(e => e.Unim03)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM03");

                entity.Property(e => e.Unim04)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM04");

                entity.Property(e => e.Unim05)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM05");

                entity.Property(e => e.Unim06)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM06");

                entity.Property(e => e.Unim07)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM07");

                entity.Property(e => e.Unim08)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM08");

                entity.Property(e => e.Unim09)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM09");

                entity.Property(e => e.Unim10)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM10");

                entity.Property(e => e.Unim11)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM11");

                entity.Property(e => e.Unim12)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM12");

                entity.Property(e => e.Unim13)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM13");

                entity.Property(e => e.Unim14)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM14");

                entity.Property(e => e.Unim15)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM15");

                entity.Property(e => e.Unim16)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM16");

                entity.Property(e => e.Unim17)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM17");

                entity.Property(e => e.Unim18)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM18");

                entity.Property(e => e.Unim19)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM19");

                entity.Property(e => e.Unim20)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("UNIM20");

                entity.Property(e => e.Usract)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USRACT");

                entity.Property(e => e.Usrcre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USRCRE");

                entity.Property(e => e.Valfon)
                    .HasColumnType("numeric(7, 2)")
                    .HasColumnName("VALFON");

                entity.Property(e => e.Valred)
                    .HasColumnType("numeric(7, 2)")
                    .HasColumnName("VALRED");
            });

            modelBuilder.Entity<MtrTipoOrden>(entity =>
            {
                entity.HasKey(e => e.IdTipoOrden);

                entity.ToTable("MtrTipoOrden");

                entity.Property(e => e.IdTipoOrden).ValueGeneratedNever();

                entity.Property(e => e.TipoOrden).HasMaxLength(100);
            });

            modelBuilder.Entity<MtrTipoTransaccionCuentaDestino>(entity =>
            {
                entity.HasKey(e => e.IdTransaccionCuentaDestino);

                entity.ToTable("MtrTipoTransaccionCuentaDestino");

                entity.HasIndex(e => new { e.IdTipoTransaccion, e.IdTipoCuentaDestino }, "IX_MtrTipoTransaccionCuentaDestino")
                    .IsUnique();

                entity.Property(e => e.IdTransaccionCuentaDestino).ValueGeneratedNever();

                entity.Property(e => e.IdTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<MtrTipoValorRetencion>(entity =>
            {
                entity.HasKey(e => e.IdTipoValor);

                entity.ToTable("MtrTipoValorRetencion");

                entity.Property(e => e.IdTipoValor).HasMaxLength(1);

                entity.Property(e => e.NombreTipoValor)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MtrUsuarioOficina>(entity =>
            {
                entity.HasKey(e => new { e.Usuario, e.Oficina });

                entity.ToTable("MtrUsuarioOficina");

                entity.HasIndex(e => e.Usuario, "IX_MtrUsuarioOficina");

                entity.Property(e => e.Usuario).HasMaxLength(40);
            });

            modelBuilder.Entity<MtrVendedor>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("MtrVendedor");

                entity.HasIndex(e => e.Supervisor, "IX_MtrVendedor");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(4)
                    .HasColumnName("CODIGO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.An8).HasColumnName("AN8");

                entity.Property(e => e.Asignacion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ASIGNACION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORIA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ClaseVendedor).HasColumnName("CLASE_VENDEDOR");

                entity.Property(e => e.Club300Asistid).HasColumnName("CLUB300_ASISTID");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COBRADOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodDivision).HasColumnName("COD_DIVISION");

                entity.Property(e => e.CodigoGrupo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_GRUPO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodigoOverride).HasColumnName("CODIGO_OVERRIDE");

                entity.Property(e => e.CodigoRegion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_REGION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("COMISION");

                entity.Property(e => e.ComisionComprd)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("COMISION_COMPRD");

                entity.Property(e => e.ComisionFactur)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMISION_FACTUR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ComisionImpres)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("COMISION_IMPRES");

                entity.Property(e => e.ComisionOrden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMISION_ORDEN")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ComisionServ)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("COMISION_SERV");

                entity.Property(e => e.ComisionStock)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("COMISION_STOCK");

                entity.Property(e => e.CompanyBeeper).HasColumnName("COMPANY_BEEPER");

                entity.Property(e => e.Consecutivo).HasColumnName("CONSECUTIVO");

                entity.Property(e => e.CotCorrelativo).HasColumnName("COT_CORRELATIVO");

                entity.Property(e => e.CotizadorPlus).HasMaxLength(1);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("E_MAIL")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ExtTelefonica).HasColumnName("EXT_TELEFONICA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.FechaRetiro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_RETIRO");

                entity.Property(e => e.Ficha)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FICHA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagAdmin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_ADMIN")
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.FlagCalculo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_CALCULO")
                    .HasDefaultValueSql("('X')")
                    .IsFixedLength();

                entity.Property(e => e.FlagCambio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_CAMBIO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagDeGerente)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_DE_GERENTE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagForaneo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_FORANEO")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.FlagGerenteOf)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_GERENTE_OF")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagIc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_IC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagReplicar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_REPLICAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRetirado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_RETIRADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FlagRevisar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_REVISAR")
                    .IsFixedLength();

                entity.Property(e => e.FlagSupervisor)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_SUPERVISOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FreeLance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FREE_LANCE")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Garantia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GARANTIA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GerenteOficina)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GERENTE_OFICINA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GerenteRegion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("GERENTE_REGION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Grupo).HasColumnName("GRUPO");

                entity.Property(e => e.GrupoVendedoresSap)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdOficinaFisica).HasMaxLength(2);

                entity.Property(e => e.IdOficinaMixProduct)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdUsuarioOdoo).HasDefaultValueSql("((0))");

                entity.Property(e => e.NombAbreviado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOMB_ABREVIADO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
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
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("OVERRIDE");

                entity.Property(e => e.Pais).HasColumnName("PAIS");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("@PASSWORD")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Pedido).HasColumnName("PEDIDO");

                entity.Property(e => e.Posicion).HasColumnName("POSICION");

                entity.Property(e => e.ProduccionInterna)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PuntosDelClub).HasColumnName("PUNTOS_DEL_CLUB");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TlfCelular)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TLF_CELULAR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TlfCelularold)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TLF_CELULAROld");

                entity.Property(e => e.UnidadBeeper)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD_BEEPER")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .HasDefaultValueSql("(' ')");

                entity.HasOne(d => d.OficinaNavigation)
                    .WithMany(p => p.MtrVendedors)
                    .HasForeignKey(d => d.Oficina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MtrVendedor_MtrOficina");
            });

            modelBuilder.Entity<OfdAdjunto>(entity =>
            {
                entity.HasKey(e => e.IdAdjunto)
                    .HasName("PK_MtrAdjunto");

                entity.ToTable("OfdAdjunto");

                entity.HasIndex(e => e.IdAdjuntoCotizadorPluss, "IX_OfdAdjunto");

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

                entity.ToTable("OfdAdjuntoCriterio");

                entity.HasIndex(e => e.IdAdjunto, "IX_OfdAdjuntoCriterio");

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
                    .WithMany(p => p.OfdAdjuntoCriterios)
                    .HasForeignKey(d => d.IdAdjunto)
                    .HasConstraintName("FK_OfdAdjuntoCriterio_OfdAdjunto");

                entity.HasOne(d => d.IdCriterioBusquedaNavigation)
                    .WithMany(p => p.OfdAdjuntoCriterios)
                    .HasForeignKey(d => d.IdCriterioBusqueda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdAdjuntoCriterio_OfdCriterioBusqueda");
            });

            modelBuilder.Entity<OfdAdjuntosDiseno>(entity =>
            {
                entity.HasKey(e => e.IdAdjunto);

                entity.ToTable("OfdAdjuntosDiseno");

                entity.HasIndex(e => new { e.IdAdjunto, e.IdTipoDocumento }, "IX_OfdAdjuntosDiseno");

                entity.Property(e => e.Archivo).IsRequired();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.IdUsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.OfdAdjuntosDisenos)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdAdjuntosDiseno_OfdSolicitudDiseno");
            });

            modelBuilder.Entity<OfdAprobacionDiseno>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.ToTable("OfdAprobacionDiseno");

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

                entity.ToTable("OfdCambioDiseno");

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
                    .WithMany(p => p.OfdCambioDisenos)
                    .HasForeignKey(d => d.IdTipoCambio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdCambioDiseno_OfdTipoCambioDiseno");
            });

            modelBuilder.Entity<OfdConstruccionCotizacion>(entity =>
            {
                entity.HasKey(e => new { e.Cotizacion, e.Renglon, e.Propuesta, e.IdVariable, e.IdParte, e.Valor })
                    .HasName("PK_WPRY251");

                entity.ToTable("OfdConstruccionCotizacion");

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

                entity.ToTable("OfdCotizacion");

                entity.HasIndex(e => e.Cotizacion, "IX_OfdCotizacion")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdVendedor, e.IdCliente, e.IdCotizacion }, "IX_OfdCotizacionVendedorClienteCotizacion");

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
                    .WithMany(p => p.OfdCotizacions)
                    .HasForeignKey(d => d.IdContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdCotizacion_MtrContactos");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.OfdCotizacions)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdCotizacion_MtrVendedor");
            });

            modelBuilder.Entity<OfdCriterioBusquedum>(entity =>
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

                entity.ToTable("OfdDetalleSolicitudDiseno");

                entity.HasIndex(e => e.IdSolicitud, "IX_OfdDetalleSolicitudDiseno");

                entity.HasIndex(e => new { e.IdSolicitud, e.NumeroAnotacion }, "IX_OfdDetalleSolicitudDiseno_1");

                entity.HasIndex(e => new { e.IdSolicitud, e.NumeroAnotacion }, "IX_OfdDetalleSolicitudDiseno_2")
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
                    .WithMany(p => p.OfdDetalleSolicitudDisenos)
                    .HasForeignKey(d => d.IdSolicitud)
                    .HasConstraintName("FK_OfdDetalleSolicitudDiseno_OfdSolicitudDiseno");
            });

            modelBuilder.Entity<OfdEspecificacionCotizacion>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud)
                    .HasName("PK_WPRY229");

                entity.ToTable("OfdEspecificacionCotizacion");

                entity.HasComment("Datos generales de las solicitudes");

                entity.HasIndex(e => new { e.Cotizacion, e.Renglon, e.Propuesta }, "IX_WPRY229")
                    .IsUnique();

                entity.HasIndex(e => e.Orden, "IX_WPRY229_1");

                entity.Property(e => e.IdSolicitud).ValueGeneratedNever();

                entity.Property(e => e.CantidadProducto).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Cotizacion)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.DescripcionSolicitud)
                    .IsRequired()
                    .HasMaxLength(200);

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

                entity.Property(e => e.RvalorLista)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("RValorLista");

                entity.Property(e => e.RvalorVenta)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("RValorVenta");

                entity.Property(e => e.TipoDocumento).HasMaxLength(2);

                entity.Property(e => e.ValorLista).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValorVenta).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<OfdEstatusFlujo>(entity =>
            {
                entity.HasKey(e => e.IdEstatus);

                entity.ToTable("OfdEstatusFlujo");

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

            modelBuilder.Entity<OfdExcepcionFlujoProducto>(entity =>
            {
                entity.ToTable("OfdExcepcionFlujoProducto");

                entity.HasIndex(e => e.Producto, "IX_OfdExcepcionFlujoProducto")
                    .IsUnique();

                entity.Property(e => e.Producto).HasMaxLength(12);
            });

            modelBuilder.Entity<OfdFlujoEstacion>(entity =>
            {
                entity.HasKey(e => e.IdFlujoEstacion);

                entity.ToTable("OfdFlujoEstacion");

                entity.HasIndex(e => e.IdEstacionActual, "IX_OfdFlujoEstacion")
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

                entity.ToTable("OfdGrupoCriterio");

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
                    .WithMany(p => p.OfdGrupoCriterios)
                    .HasForeignKey(d => d.IdCriterioBusqueda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdGrupoCriterio_OfdCriterioBusqueda");

                entity.HasOne(d => d.IdGrupoTipoDocumentoNavigation)
                    .WithMany(p => p.OfdGrupoCriterios)
                    .HasForeignKey(d => d.IdGrupoTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdGrupoCriterio_OdfGrupoTipoDocumento");
            });

            modelBuilder.Entity<OfdGrupoTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdGrupoTipoDocumento)
                    .HasName("PK_OdfGrupoTipoDocumento");

                entity.ToTable("OfdGrupoTipoDocumento");

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

                entity.ToTable("OfdMaestroEstacion");

                entity.HasIndex(e => e.AbreviadoEstacion, "IX_OfdEstacionesDiseno")
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
                    .WithMany(p => p.OfdMaestroEstacions)
                    .HasForeignKey(d => d.IdFlujo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdMaestroEstacion_OfdMaestroFlujo");
            });

            modelBuilder.Entity<OfdMaestroFlujo>(entity =>
            {
                entity.HasKey(e => e.IdFlujo)
                    .HasName("PK_OfdMaestroFlujos");

                entity.ToTable("OfdMaestroFlujo");

                entity.Property(e => e.IdFlujo).ValueGeneratedNever();

                entity.Property(e => e.NombreFlujo)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OfdMaestroPieImprentum>(entity =>
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

                entity.ToTable("OfdMaestroTipoRespaldo");

                entity.Property(e => e.IdTipoRespaldo).ValueGeneratedNever();

                entity.Property(e => e.TipoRespaldo)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OfdMaestroUbicacionMarginal>(entity =>
            {
                entity.HasKey(e => e.IdUbicacionMarginal);

                entity.ToTable("OfdMaestroUbicacionMarginal");

                entity.Property(e => e.IdUbicacionMarginal).ValueGeneratedNever();

                entity.Property(e => e.UbicacionMarginal)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OfdMaestroVoBo>(entity =>
            {
                entity.HasKey(e => e.IdVoBo);

                entity.ToTable("OfdMaestroVoBo");

                entity.HasIndex(e => new { e.IdEstacion, e.Orden }, "IX_OfdMaestroVoBo")
                    .IsUnique();

                entity.HasIndex(e => e.IdEstacion, "IX_OfdMaestroVoBo_1");

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

                entity.ToTable("OfdObservacionAdjunto");

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

                entity.ToTable("OfdPartesCotizacion");

                entity.HasIndex(e => e.Recnum, "IX_OfdPartesCotizacion");

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

                entity.ToTable("OfdPlantillaPreset");

                entity.Property(e => e.Basica)
                    .HasMaxLength(50)
                    .HasColumnName("BASICA");

                entity.Property(e => e.Cambioscomposicion)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CAMBIOSCOMPOSICION");

                entity.Property(e => e.Cantfranjastransfertape)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CANTFRANJASTRANSFERTAPE");

                entity.Property(e => e.Cantitintas)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CANTITINTAS");

                entity.Property(e => e.Carbon)
                    .HasMaxLength(50)
                    .HasColumnName("CARBON");

                entity.Property(e => e.CodProducto)
                    .HasMaxLength(12)
                    .HasColumnName("COD_PRODUCTO");

                entity.Property(e => e.Grupopapel)
                    .HasMaxLength(100)
                    .HasColumnName("GRUPOPAPEL");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSolicitud).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Medidaopuestacarbon)
                    .HasMaxLength(50)
                    .HasColumnName("MEDIDAOPUESTACARBON");

                entity.Property(e => e.Millares).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Nombreproducto)
                    .HasMaxLength(50)
                    .HasColumnName("NOMBREPRODUCTO");

                entity.Property(e => e.Opuesta)
                    .HasMaxLength(50)
                    .HasColumnName("OPUESTA")
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasMaxLength(50)
                    .HasColumnName("ORDEN");

                entity.Property(e => e.Ordenreferencia)
                    .HasMaxLength(50)
                    .HasColumnName("ORDENReferencia");

                entity.Property(e => e.Papel)
                    .HasMaxLength(100)
                    .HasColumnName("PAPEL");

                entity.Property(e => e.Partes)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PARTES");

                entity.Property(e => e.PrecioMaximoMillar).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Talonextra)
                    .HasMaxLength(50)
                    .HasColumnName("TALONEXTRA");

                entity.Property(e => e.Tienecarbonspot)
                    .HasMaxLength(50)
                    .HasColumnName("TIENECARBONSPOT");
            });

            modelBuilder.Entity<OfdPropuestaResp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OfdPropuestaResp");

                entity.Property(e => e.Cajas).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CantFormas)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Cant_Formas");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CantXCaja)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Cant_x_Caja");

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

            modelBuilder.Entity<OfdPropuestum>(entity =>
            {
                entity.HasKey(e => e.IdPropuesta);

                entity.HasIndex(e => new { e.Cotizacion, e.Renglon, e.Propuesta }, "IX_OfdPropuesta")
                    .IsUnique();

                entity.Property(e => e.Cajas).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CantFormas)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Cant_Formas");

                entity.Property(e => e.CantMill).HasColumnName("Cant_Mill");

                entity.Property(e => e.CantXCaja)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Cant_x_Caja");

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

                entity.Property(e => e.Rprecio)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("RPrecio");

                entity.Property(e => e.Rtotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("RTotal");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdRenglonNavigation)
                    .WithMany(p => p.OfdPropuesta)
                    .HasForeignKey(d => d.IdRenglon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdPropuesta_OfdRenglon");
            });

            modelBuilder.Entity<OfdRenglon>(entity =>
            {
                entity.HasKey(e => e.IdRenglon);

                entity.ToTable("OfdRenglon");

                entity.HasIndex(e => new { e.Cotizacion, e.Renglon }, "IX_OfdRenglon")
                    .IsUnique();

                entity.HasIndex(e => e.IdCotizacion, "IX_OfdRenglon_1");

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
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

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

                entity.Property(e => e.RtotalGanado)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("RTotalGanado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RtotalRenglon)
                    .HasColumnType("numeric(20, 4)")
                    .HasColumnName("RTotalRenglon")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalGanado).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.TotalRenglon).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdCotizacionNavigation)
                    .WithMany(p => p.OfdRenglons)
                    .HasForeignKey(d => d.IdCotizacion)
                    .HasConstraintName("FK_OfdRenglon_OfdCotizacion");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.OfdRenglons)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdRenglon_MtrProducto");
            });

            modelBuilder.Entity<OfdRolTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdRolTipoDocumento);

                entity.ToTable("OfdRolTipoDocumento");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.OfdRolTipoDocumentos)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdRolTipoDocumento_SegRol");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.OfdRolTipoDocumentos)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdRolTipoDocumento_OfdTipoDocumento");
            });

            modelBuilder.Entity<OfdSeguimiento>(entity =>
            {
                entity.HasKey(e => e.IdSeguimiento);

                entity.ToTable("OfdSeguimiento");

                entity.HasIndex(e => e.IdSolicitud, "IX_OfdSeguimiento");

                entity.HasIndex(e => e.FechaSalida, "IX_OfdSeguimiento_1");

                entity.HasIndex(e => e.FechaSalida, "IX_OfdSeguimiento_2");

                entity.HasIndex(e => e.FechaEntrada, "IX_OfdSeguimiento_3");

                entity.HasIndex(e => e.FechaEntrada, "IX_OfdSeguimiento_4");

                entity.HasIndex(e => new { e.IdSolicitud, e.IdEstacion }, "IX_OfdSeguimiento_5");

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
                    .WithMany(p => p.OfdSeguimientos)
                    .HasForeignKey(d => d.IdEstacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSeguimiento_OfdMaestroEstacion");

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.OfdSeguimientos)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSeguimiento_OfdSolicitudDiseno");
            });

            modelBuilder.Entity<OfdSolicitudDiseno>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.ToTable("OfdSolicitudDiseno");

                entity.HasIndex(e => e.IdPropuesta, "IX_OfdSolicitudDiseno");

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
                    .WithMany(p => p.OfdSolicitudDisenos)
                    .HasForeignKey(d => d.IdPieImprenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSolicitudDiseno_OfdMaestroPieImprenta");

                entity.HasOne(d => d.IdPropuestaNavigation)
                    .WithMany(p => p.OfdSolicitudDisenos)
                    .HasForeignKey(d => d.IdPropuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSolicitudDiseno_OfdPropuesta");

                entity.HasOne(d => d.IdTipoCambioNavigation)
                    .WithMany(p => p.OfdSolicitudDisenos)
                    .HasForeignKey(d => d.IdTipoCambio)
                    .HasConstraintName("FK_OfdSolicitudDiseno_OfdTipoCambioDiseno");

                entity.HasOne(d => d.IdTipoRespaldoNavigation)
                    .WithMany(p => p.OfdSolicitudDisenos)
                    .HasForeignKey(d => d.IdTipoRespaldo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSolicitudDiseno_OfdMaestroTipoRespaldo");

                entity.HasOne(d => d.UbicacionMarginalNavigation)
                    .WithMany(p => p.OfdSolicitudDisenos)
                    .HasForeignKey(d => d.UbicacionMarginal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSolicitudDiseno_OfdMaestroUbicacionMarginal");
            });

            modelBuilder.Entity<OfdSolicitudDisenoCambio>(entity =>
            {
                entity.HasKey(e => e.IdSolDisCam);

                entity.HasIndex(e => new { e.IdSolicitud, e.IdCambio }, "IX_OfdSolicitudDisenoCambios")
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

                entity.ToTable("OfdSolicitudDocFiscal");

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
                    .WithMany(p => p.OfdSolicitudDocFiscals)
                    .HasForeignKey(d => d.IdEstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdSolicitudDocFiscal_OfdEstatusFlujo");

                entity.HasOne(d => d.IdNumeracionNavigation)
                    .WithMany(p => p.OfdSolicitudDocFiscals)
                    .HasForeignKey(d => d.IdNumeracion)
                    .HasConstraintName("FK_OfdSolicitudDocFiscal_PrcNumeracionFiscal");
            });

            modelBuilder.Entity<OfdTintasCotizacion>(entity =>
            {
                entity.HasKey(e => new { e.Cotizacion, e.Renglon, e.Propuesta, e.IdParte, e.IdUbicacion, e.IdTinta });

                entity.ToTable("OfdTintasCotizacion");

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

                entity.ToTable("OfdTipoCambioDiseno");

                entity.HasIndex(e => e.IdPonderacion, "IX_OfdTipoCambioDiseno")
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

                entity.ToTable("OfdTipoDocumento");

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
                    .WithMany(p => p.OfdTipoDocumentos)
                    .HasForeignKey(d => d.IdGrupoTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdTipoDocumento_OdfGrupoTipoDocumento");
            });

            modelBuilder.Entity<OfdVariablesEspecificacion>(entity =>
            {
                entity.HasKey(e => e.IdVariable)
                    .HasName("PK_WPRY248");

                entity.ToTable("OfdVariablesEspecificacion");

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
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IdVariableMC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreVariable)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OfdVoBoDiseno>(entity =>
            {
                entity.HasKey(e => e.IdVoBoSolicitud);

                entity.ToTable("OfdVoBoDiseno");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.OfdVoBoDisenos)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdVoBoDiseno_OfdSolicitudDiseno");

                entity.HasOne(d => d.IdVoBoNavigation)
                    .WithMany(p => p.OfdVoBoDisenos)
                    .HasForeignKey(d => d.IdVoBo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfdVoBoDiseno_OfdMaestroVoBo");
            });

            modelBuilder.Entity<PageMenu>(entity =>
            {
                entity.ToTable("PageMenu");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Mobil).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Primernombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIMERNOMBRE");

                entity.Property(e => e.Segundonombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEGUNDONOMBRE");
            });

            modelBuilder.Entity<PrcNumeracionFiscal>(entity =>
            {
                entity.HasKey(e => e.IdNumeracion);

                entity.ToTable("PrcNumeracionFiscal");

                entity.HasIndex(e => e.IdPropuesta, "IX_PrcNumeracionFiscal");

                entity.HasIndex(e => new { e.Rif, e.NumeroSerieControlDesde, e.NumeroControlDesde }, "IX_SerieControl");

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
                    .WithMany(p => p.PrcNumeracionFiscals)
                    .HasForeignKey(d => d.IdPropuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrcNumeracionFiscal_OfdPropuesta");

                entity.HasOne(d => d.TipoDocumentoNavigation)
                    .WithMany(p => p.PrcNumeracionFiscals)
                    .HasForeignKey(d => d.TipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrcNumeracionFiscal_MtrTipoDocumentoFiscal");
            });

            modelBuilder.Entity<PrcObjetosProceso>(entity =>
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

            modelBuilder.Entity<PrcOrdenIdPropuestum>(entity =>
            {
                entity.HasIndex(e => e.IdPropuesta, "IX_PrcOrdenIdPropuesta");

                entity.HasIndex(e => e.Orden, "IX_PrcOrdenIdPropuesta_1");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PrcPlantillaNumeracione>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Mascara, "IX_PrcNumeraciones");

                entity.Property(e => e.Hasta).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MaximoNumero).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrefijoChar).HasMaxLength(2);
            });

            modelBuilder.Entity<PrcUsuarioProceso>(entity =>
            {
                entity.HasIndex(e => new { e.IdProceso, e.Usuario }, "IX_PrcUsuarioProcesos")
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

            modelBuilder.Entity<PrecioActualizar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PrecioActualizar");

                entity.Property(e => e.Precio).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRODUCTO");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(255)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PRECIO");
            });

            modelBuilder.Entity<ReqAreaRequerimiento>(entity =>
            {
                entity.HasKey(e => e.IdAreaRequerimiento);

                entity.ToTable("ReqAreaRequerimiento");

                entity.Property(e => e.IdAreaRequerimiento).ValueGeneratedNever();

                entity.Property(e => e.DescripcionAreaRequerimiento)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.FechaCambio).HasColumnType("smalldatetime");

                entity.Property(e => e.UsuarioCambio).HasMaxLength(30);

                entity.HasOne(d => d.IdOrigenRequerimientoNavigation)
                    .WithMany(p => p.ReqAreaRequerimientos)
                    .HasForeignKey(d => d.IdOrigenRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqAreaRequerimiento_ReqOrigenRequerimiento");
            });

            modelBuilder.Entity<ReqCompañium>(entity =>
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

                entity.ToTable("ReqOrigenRequerimiento");

                entity.HasComment("Origenes de Requerimientos de Servicios");

                entity.Property(e => e.IdOrigenRequerimiento).ValueGeneratedNever();

                entity.Property(e => e.DescripcionOrigenRequerimiento)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaCambio).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCompañia).HasMaxLength(10);

                entity.Property(e => e.UsuarioCambio).HasMaxLength(30);

                entity.HasOne(d => d.IdCompañiaNavigation)
                    .WithMany(p => p.ReqOrigenRequerimientos)
                    .HasForeignKey(d => d.IdCompañia)
                    .HasConstraintName("FK_ReqOrigenRequerimiento_ReqCompañia");
            });

            modelBuilder.Entity<ReqTarea>(entity =>
            {
                entity.HasKey(e => e.IdTarea);

                entity.ToTable("ReqTarea");

                entity.Property(e => e.IdTarea).ValueGeneratedNever();

                entity.Property(e => e.DescripcionTarea)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FechaCambio).HasColumnType("smalldatetime");

                entity.Property(e => e.UsuarioCambio).HasMaxLength(30);

                entity.HasOne(d => d.IdTipoTareaNavigation)
                    .WithMany(p => p.ReqTareas)
                    .HasForeignKey(d => d.IdTipoTarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqTarea_ReqTipoTarea");
            });

            modelBuilder.Entity<ReqTipoTarea>(entity =>
            {
                entity.HasKey(e => e.IdTipoTarea)
                    .HasName("PK_ReqTipoRequerimiento");

                entity.ToTable("ReqTipoTarea");

                entity.Property(e => e.IdTipoTarea).ValueGeneratedNever();

                entity.Property(e => e.DescripcionTipoTarea)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.FechaCambio).HasColumnType("smalldatetime");

                entity.Property(e => e.UsuarioCambio)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.IdAreaRequerimientoNavigation)
                    .WithMany(p => p.ReqTipoTareas)
                    .HasForeignKey(d => d.IdAreaRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqTipoRequerimiento_ReqAreaRequerimiento");
            });

            modelBuilder.Entity<ReqVariable>(entity =>
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

            modelBuilder.Entity<RetencionesCorregir>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RetencionesCorregir");

                entity.Property(e => e.CertificadoRetencion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ejercicio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCertificadoRetencion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorRetenciN)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IndicadorRetenci¢n");

                entity.Property(e => e.Posicion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sociedad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRetenciones)
                    .HasMaxLength(50)
                    .IsUnicode(false);
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

                entity.ToTable("SapFrecuenciaVisitaCliente");

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

            modelBuilder.Entity<SapRetencione>(entity =>
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

                entity.ToTable("SegModulo");

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

                entity.ToTable("SegPrograma");

                entity.Property(e => e.IdPrograma).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.FlagRequerimiento).HasMaxLength(1);

                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .HasColumnName("link");

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

                entity.ToTable("SegRol");

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

                entity.ToTable("SegRolEstacion");

                entity.HasIndex(e => new { e.IdEstacion, e.IdRol }, "IX_SegRolEstacion")
                    .IsUnique();

                entity.HasIndex(e => e.IdRol, "IX_SegRolEstacion_1");
            });

            modelBuilder.Entity<SegRolModulo>(entity =>
            {
                entity.HasKey(e => e.IdRolModulo);

                entity.ToTable("SegRolModulo");

                entity.HasIndex(e => new { e.IdRol, e.IdModulo }, "IX_SegRolModulo")
                    .IsUnique();

                entity.Property(e => e.IdRolModulo).ValueGeneratedNever();
            });

            modelBuilder.Entity<SegTicket>(entity =>
            {
                entity.HasKey(e => e.TicketSha1);

                entity.ToTable("SegTicket");

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

                entity.ToTable("SegUsuario");

                entity.HasIndex(e => e.Email, "IX_Email");

                entity.HasIndex(e => e.Usuario, "IX_SegUsuario")
                    .IsUnique();

                entity.HasIndex(e => e.Usuario, "IX_SegUsuario_1")
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
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Flag_Disenador");

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

                entity.ToTable("SegUsuarioRol");

                entity.HasIndex(e => new { e.IdUsuario, e.IdRol }, "IX_SegUsuarioRol")
                    .IsUnique();

                entity.Property(e => e.IdUsuarioRol).ValueGeneratedNever();

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.SegUsuarioRols)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegUsuarioRol_SegRol");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.SegUsuarioRols)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegUsuarioRol_SegUsuario1");
            });

            modelBuilder.Entity<Sysfile>(entity =>
            {
                entity.ToTable("Sysfile");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DirVirtualOd)
                    .HasMaxLength(50)
                    .HasColumnName("DirVirtualOD");

                entity.Property(e => e.LinkServer).HasMaxLength(50);

                entity.Property(e => e.LinkServerProduccion).HasMaxLength(50);

                entity.Property(e => e.MailserverName)
                    .HasMaxLength(100)
                    .HasColumnName("mailserver_name");

                entity.Property(e => e.MailserverPort)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("mailserver_Port");

                entity.Property(e => e.MailserverType)
                    .HasMaxLength(100)
                    .HasColumnName("mailserver_type");

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
                    .HasMaxLength(18)
                    .HasColumnName("MSEHI");

                entity.Property(e => e.Mandt)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("MANDT");

                entity.Property(e => e.Mseh3)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasColumnName("MSEH3");

                entity.Property(e => e.Mseh6)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("MSEH6");

                entity.Property(e => e.Msehl)
                    .IsRequired()
                    .HasMaxLength(180)
                    .HasColumnName("MSEHL");

                entity.Property(e => e.Mseht)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("MSEHT");

                entity.Property(e => e.Spras)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("SPRAS");
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

            modelBuilder.Entity<TEnEntrada>(entity =>
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
                    .WithMany(p => p.TEnEntrada)
                    .HasForeignKey(d => d.IdVariables)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_En_Entradas_T_Pa_Variables");
            });

            modelBuilder.Entity<TPaFormula>(entity =>
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

            modelBuilder.Entity<TPaPlantillaEntrada>(entity =>
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
                    .WithMany(p => p.TPaPlantillaEntrada)
                    .HasForeignKey(d => d.IdVariables)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_PA_PlantillaEntradas_T_Pa_Variables");

                entity.HasOne(d => d.LineaNegocioNavigation)
                    .WithMany(p => p.TPaPlantillaEntrada)
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

            modelBuilder.Entity<TPaTasaBancoCentral>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_Tasa_BancoCentral");

                entity.HasIndex(e => e.Fecha, "IX_T_Pa_Tasa_BancoCentral");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaTasa)
                    .HasMaxLength(18)
                    .HasColumnName("Fecha_Tasa")
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rtasa)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("RTasa");

                entity.Property(e => e.Tasa).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<TPaTasaReferencial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Pa_Tasa_Referencial");

                entity.HasIndex(e => e.Fecha, "IX_T_Pa_Tasa_Referencial");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaTasa)
                    .HasMaxLength(18)
                    .HasColumnName("Fecha_Tasa")
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rtasa)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("RTasa");

                entity.Property(e => e.Tasa).HasColumnType("numeric(18, 4)");
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

            modelBuilder.Entity<TPaTiposDeVariable>(entity =>
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

            modelBuilder.Entity<TPaVariable>(entity =>
            {
                entity.HasKey(e => e.IdVariables);

                entity.ToTable("T_Pa_Variables");

                entity.Property(e => e.IdVariables).HasMaxLength(20);

                entity.Property(e => e.AfectaCostoPororden).HasMaxLength(1);

                entity.Property(e => e.AfectaMc)
                    .HasMaxLength(1)
                    .HasColumnName("AfectaMC");

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

            modelBuilder.Entity<TSaPlantillaReporteAnalisisCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Sa_PlantillaReporteAnalisisCredito");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariablePadre).HasMaxLength(20);

                entity.Property(e => e.Idvariables).HasMaxLength(20);

                entity.Property(e => e.LineaReporte).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NombreVariable).HasMaxLength(100);

                entity.Property(e => e.Titulo).HasMaxLength(1);
            });

            modelBuilder.Entity<TSaReporteAnalisisCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Sa_ReporteAnalisisCredito");

                entity.HasIndex(e => e.IdSolicitud, "IX_T_Sa_ReporteAnalisisCredito");

                entity.HasIndex(e => new { e.IdSolicitud, e.LineaReporte }, "IX_T_Sa_ReporteAnalisisCredito_1");

                entity.HasIndex(e => new { e.IdSolicitud, e.IdvariablePadre, e.Idvariables }, "IX_T_Sa_ReporteAnalisisCredito_2");

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

                entity.HasIndex(e => new { e.DocRb, e.Factura }, "IX_TempRBFactura")
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

                entity.ToTable("TempReciboCobro");

                entity.HasIndex(e => e.Recnum, "IX_TempReciboCobro")
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
                entity.ToTable("Thumbnail");

                entity.Property(e => e.Fname)
                    .HasMaxLength(255)
                    .HasColumnName("fname");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasIndex(e => e.UserName, "User_UserName_Index")
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
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.User_dbo.Company_CompanyId");
            });

            modelBuilder.Entity<UsuariosOdoo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UsuariosOdoo");

                entity.Property(e => e.EmailOdoo).HasMaxLength(500);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VCobrosDiasTranscurrido>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CobrosDiasTranscurridos");

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodOficina)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoVendedor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion).HasMaxLength(13);

                entity.Property(e => e.DocAfecta).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocAfectaSap)
                    .HasMaxLength(10)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DocumentoSap).HasMaxLength(10);

                entity.Property(e => e.EjercicioDocumentoSap).HasMaxLength(4);

                entity.Property(e => e.FacturaNd)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("FacturaND")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FechaLm)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaLM");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaTasa).HasColumnType("datetime");

                entity.Property(e => e.FechaTransaccion).HasColumnType("datetime");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IdTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Moneda).HasMaxLength(50);

                entity.Property(e => e.Monto).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MontoBs).HasColumnType("numeric(37, 6)");

                entity.Property(e => e.MontoUsd).HasColumnType("numeric(38, 18)");

                entity.Property(e => e.NombreCliente).HasMaxLength(80);

                entity.Property(e => e.NombreRegion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_REGION");

                entity.Property(e => e.NombreVendedor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Oficina)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Rpdct)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("RPDCT")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Rpdoc).HasColumnName("RPDOC");

                entity.Property(e => e.Rpkco)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("RPKCO")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Rpsfx)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("RPSFX")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SoloBs).HasColumnType("numeric(38, 18)");

                entity.Property(e => e.SoloUsd).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TasaBancoCentral).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Titulo).HasMaxLength(200);

                entity.Property(e => e.Transaccion).HasMaxLength(2);
            });

            modelBuilder.Entity<VRecipePrecioMaximo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RecipePrecioMaximo");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DescriptionSearch).HasMaxLength(4000);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MensajeValidacionFormula).HasMaxLength(4000);

                entity.Property(e => e.OrderCalculate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.VariablesSearchText).HasMaxLength(4000);
            });

            modelBuilder.Entity<VRetencionesCobrada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RetencionesCobradas");

                entity.Property(e => e.BsEmision).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Diferencia).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DocumentoSap).HasMaxLength(50);

                entity.Property(e => e.DolaresComprobante).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DolaresContabilizacion).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DolaresFechaFactura).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaComprobante).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaContabilizacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");

                entity.Property(e => e.NombreCliente).HasMaxLength(200);

                entity.Property(e => e.NroComprobante).HasMaxLength(50);

                entity.Property(e => e.Oficina).HasMaxLength(50);

                entity.Property(e => e.Porcentaje).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.TasaComprobante).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TasaContabilizacion).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Vendedor).HasMaxLength(100);
            });

            modelBuilder.Entity<ValevenDataResuman>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<ValevenImpresione>(entity =>
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

                entity.HasIndex(e => new { e.Cliente, e.Documento }, "IX_WARY074");

                entity.HasIndex(e => e.Batch, "IX_WARY074_1");

                entity.HasIndex(e => new { e.Batch, e.DocCanc }, "IX_WARY074_2");

                entity.HasIndex(e => e.Recnum, "IX_WARY074_3")
                    .IsUnique();

                entity.Property(e => e.TipoCompania)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_COMPANIA")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.PlantaOficina).HasColumnName("PLANTA_OFICINA");

                entity.Property(e => e.Transaccion)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Documento).HasColumnName("DOCUMENTO");

                entity.Property(e => e.Linea).HasColumnName("LINEA");

                entity.Property(e => e.AO).HasColumnName("A#O");

                entity.Property(e => e.Afectanota)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AFECTANOTA")
                    .IsFixedLength();

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.AsigActual).HasColumnName("ASIG_ACTUAL");

                entity.Property(e => e.Banco)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BANCO")
                    .IsFixedLength();

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Cambio)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("CAMBIO");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIUDAD")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COBRADOR")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.CodContrapart)
                    .HasMaxLength(50)
                    .HasColumnName("COD_CONTRAPART");

                entity.Property(e => e.ComisionPag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMISION_PAG")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comisionpagada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMISIONPAGADA")
                    .IsFixedLength();

                entity.Property(e => e.CompLinea).HasColumnName("COMP_LINEA");

                entity.Property(e => e.Comprobante).HasColumnName("COMPROBANTE");

                entity.Property(e => e.Concepto)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CONCEPTO")
                    .IsFixedLength();

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.Contabilizado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONTABILIZADO")
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .IsFixedLength();

                entity.Property(e => e.CuentaEfecto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CUENTA_EFECTO")
                    .IsFixedLength();

                entity.Property(e => e.Depura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEPURA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dias).HasColumnName("DIAS");

                entity.Property(e => e.DiasEntrega).HasColumnName("DIAS_ENTREGA");

                entity.Property(e => e.Diastransc).HasColumnName("DIASTRANSC");

                entity.Property(e => e.Diferencial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DIFERENCIAL")
                    .IsFixedLength();

                entity.Property(e => e.DocCanc).HasColumnName("DOC_CANC");

                entity.Property(e => e.DocJde)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("doc_jde")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Efectivo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EFECTIVO")
                    .IsFixedLength();

                entity.Property(e => e.Eliminar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINAR")
                    .IsFixedLength();

                entity.Property(e => e.Estacion)
                    .HasColumnName("ESTACION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FechaCobro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_COBRO");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_EMISION")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INGRESO")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaPlanilla)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PLANILLA");

                entity.Property(e => e.FechaUsuario)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_USUARIO");

                entity.Property(e => e.FechaVcto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_VCTO");

                entity.Property(e => e.Fechadoccanc)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHADOCCANC");

                entity.Property(e => e.FecrecibPl)
                    .HasColumnType("datetime")
                    .HasColumnName("FECRECIB_PL");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRUPO")
                    .IsFixedLength();

                entity.Property(e => e.GrupoActual)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRUPO_ACTUAL")
                    .IsFixedLength();

                entity.Property(e => e.HoraCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HORA_CREACION");

                entity.Property(e => e.HoraUsario).HasColumnName("HORA_USARIO");

                entity.Property(e => e.InformeQueja).HasColumnName("INFORME_QUEJA");

                entity.Property(e => e.LinCanc).HasColumnName("LIN_CANC");

                entity.Property(e => e.Lote)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOTE")
                    .IsFixedLength();

                entity.Property(e => e.Matriz)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MATRIZ")
                    .IsFixedLength();

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.MinutosUsuario).HasColumnName("MINUTOS_USUARIO");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MONEDA")
                    .IsFixedLength();

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("MONTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MONTO_DOLAR");

                entity.Property(e => e.MontoMoneda)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MONTO_MONEDA");

                entity.Property(e => e.NoTieneDebe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NO_TIENE_DEBE")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .IsFixedLength();

                entity.Property(e => e.NroPlanilla)
                    .HasMaxLength(25)
                    .HasColumnName("NRO_PLANILLA")
                    .IsFixedLength();

                entity.Property(e => e.Nrocheque)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NROCHEQUE")
                    .IsFixedLength();

                entity.Property(e => e.NumeroPl)
                    .HasColumnName("NUMERO_PL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Observacion1)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION1")
                    .IsFixedLength();

                entity.Property(e => e.Observacion2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION2")
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PasoJde)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("paso_jde")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.PorIva)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("POR_IVA");

                entity.Property(e => e.Porcret)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PORCRET");

                entity.Property(e => e.Recalcular)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECALCULAR")
                    .IsFixedLength();

                entity.Property(e => e.RecibidaPl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECIBIDA_PL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Referencia).HasColumnName("REFERENCIA");

                entity.Property(e => e.Region)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGION")
                    .IsFixedLength();

                entity.Property(e => e.RegionActual)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGION_ACTUAL")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.RelacionCobro).HasColumnName("RELACION_COBRO");

                entity.Property(e => e.Remisionma).HasColumnName("REMISIONMA");

                entity.Property(e => e.Remisionsi).HasColumnName("REMISIONSI");

                entity.Property(e => e.Rmonto)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RMONTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rsaldo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RSALDO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rzvre)
                    .HasMaxLength(10)
                    .HasColumnName("RZVRE");

                entity.Property(e => e.Saldo)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("SALDO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaldoDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("SALDO_DOLAR");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .IsFixedLength();

                entity.Property(e => e.TasaCambio)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("TASA_CAMBIO");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.TipoCanc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CANC")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.TipoCiudad)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CIUDAD")
                    .IsFixedLength();

                entity.Property(e => e.Transferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSFERENCIA")
                    .IsFixedLength();

                entity.Property(e => e.UltimoPago)
                    .HasColumnType("datetime")
                    .HasColumnName("ULTIMO_PAGO");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .IsFixedLength();

                entity.Property(e => e.VecesCobro).HasColumnName("VECES_COBRO");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ZONA")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wary074temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WARY074Temp");

                entity.HasComment("TRANSACCIONES PERMANENTE  CXC");

                entity.HasIndex(e => e.Recnum, "IX_WARY074Temp_3")
                    .IsUnique();

                entity.Property(e => e.AO).HasColumnName("A#O");

                entity.Property(e => e.Afectanota)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AFECTANOTA")
                    .IsFixedLength();

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.AsigActual).HasColumnName("ASIG_ACTUAL");

                entity.Property(e => e.Banco)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BANCO")
                    .IsFixedLength();

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Cambio)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("CAMBIO");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIUDAD")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COBRADOR")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.CodContrapart)
                    .HasMaxLength(50)
                    .HasColumnName("COD_CONTRAPART");

                entity.Property(e => e.ComisionPag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMISION_PAG")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comisionpagada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMISIONPAGADA")
                    .IsFixedLength();

                entity.Property(e => e.CompLinea).HasColumnName("COMP_LINEA");

                entity.Property(e => e.Comprobante).HasColumnName("COMPROBANTE");

                entity.Property(e => e.Concepto)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CONCEPTO")
                    .IsFixedLength();

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.Contabilizado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONTABILIZADO")
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .IsFixedLength();

                entity.Property(e => e.CuentaEfecto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CUENTA_EFECTO")
                    .IsFixedLength();

                entity.Property(e => e.Depura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEPURA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Dias).HasColumnName("DIAS");

                entity.Property(e => e.DiasEntrega).HasColumnName("DIAS_ENTREGA");

                entity.Property(e => e.Diastransc).HasColumnName("DIASTRANSC");

                entity.Property(e => e.Diferencial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DIFERENCIAL")
                    .IsFixedLength();

                entity.Property(e => e.DocCanc).HasColumnName("DOC_CANC");

                entity.Property(e => e.DocJde)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("doc_jde")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Documento).HasColumnName("DOCUMENTO");

                entity.Property(e => e.Efectivo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EFECTIVO")
                    .IsFixedLength();

                entity.Property(e => e.Eliminar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINAR")
                    .IsFixedLength();

                entity.Property(e => e.Estacion)
                    .HasColumnName("ESTACION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.FechaCobro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_COBRO");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_EMISION")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INGRESO")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaPlanilla)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PLANILLA");

                entity.Property(e => e.FechaUsuario)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_USUARIO");

                entity.Property(e => e.FechaVcto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_VCTO");

                entity.Property(e => e.Fechadoccanc)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHADOCCANC");

                entity.Property(e => e.FecrecibPl)
                    .HasColumnType("datetime")
                    .HasColumnName("FECRECIB_PL");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRUPO")
                    .IsFixedLength();

                entity.Property(e => e.GrupoActual)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRUPO_ACTUAL")
                    .IsFixedLength();

                entity.Property(e => e.HoraCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HORA_CREACION");

                entity.Property(e => e.HoraUsario).HasColumnName("HORA_USARIO");

                entity.Property(e => e.InformeQueja).HasColumnName("INFORME_QUEJA");

                entity.Property(e => e.LinCanc).HasColumnName("LIN_CANC");

                entity.Property(e => e.Linea).HasColumnName("LINEA");

                entity.Property(e => e.Lote)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOTE")
                    .IsFixedLength();

                entity.Property(e => e.Matriz)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MATRIZ")
                    .IsFixedLength();

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.MinutosUsuario).HasColumnName("MINUTOS_USUARIO");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MONEDA")
                    .IsFixedLength();

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("MONTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MontoDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MONTO_DOLAR");

                entity.Property(e => e.MontoMoneda)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MONTO_MONEDA");

                entity.Property(e => e.NoTieneDebe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NO_TIENE_DEBE")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .IsFixedLength();

                entity.Property(e => e.NroPlanilla)
                    .HasMaxLength(25)
                    .HasColumnName("NRO_PLANILLA")
                    .IsFixedLength();

                entity.Property(e => e.Nrocheque)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NROCHEQUE")
                    .IsFixedLength();

                entity.Property(e => e.NumeroPl)
                    .HasColumnName("NUMERO_PL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Observacion1)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION1")
                    .IsFixedLength();

                entity.Property(e => e.Observacion2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION2")
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PasoJde)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("paso_jde")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.PlantaOficina).HasColumnName("PLANTA_OFICINA");

                entity.Property(e => e.PorIva)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("POR_IVA");

                entity.Property(e => e.Porcret)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PORCRET");

                entity.Property(e => e.Recalcular)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECALCULAR")
                    .IsFixedLength();

                entity.Property(e => e.RecibidaPl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECIBIDA_PL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Referencia).HasColumnName("REFERENCIA");

                entity.Property(e => e.Region)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGION")
                    .IsFixedLength();

                entity.Property(e => e.RegionActual)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGION_ACTUAL")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.RelacionCobro).HasColumnName("RELACION_COBRO");

                entity.Property(e => e.Remisionma).HasColumnName("REMISIONMA");

                entity.Property(e => e.Remisionsi).HasColumnName("REMISIONSI");

                entity.Property(e => e.Rmonto)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RMONTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rsaldo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RSALDO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rzvre)
                    .HasMaxLength(10)
                    .HasColumnName("RZVRE");

                entity.Property(e => e.Saldo)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("SALDO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaldoDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("SALDO_DOLAR");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .IsFixedLength();

                entity.Property(e => e.TasaCambio)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("TASA_CAMBIO");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.TipoCanc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CANC")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.TipoCiudad)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CIUDAD")
                    .IsFixedLength();

                entity.Property(e => e.TipoCompania)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_COMPANIA")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION")
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.Transferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSFERENCIA")
                    .IsFixedLength();

                entity.Property(e => e.UltimoPago)
                    .HasColumnType("datetime")
                    .HasColumnName("ULTIMO_PAGO");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .IsFixedLength();

                entity.Property(e => e.VecesCobro).HasColumnName("VECES_COBRO");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ZONA")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wary074tempReconstruir>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WARY074TempReconstruir");

                entity.Property(e => e.AO).HasColumnName("A#O");

                entity.Property(e => e.Afectanota)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AFECTANOTA")
                    .IsFixedLength();

                entity.Property(e => e.Anticipo).HasColumnName("ANTICIPO");

                entity.Property(e => e.AsigActual).HasColumnName("ASIG_ACTUAL");

                entity.Property(e => e.Banco)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BANCO")
                    .IsFixedLength();

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Cambio)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("CAMBIO");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CIUDAD")
                    .IsFixedLength();

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COBRADOR")
                    .IsFixedLength();

                entity.Property(e => e.CodContrapart)
                    .HasMaxLength(50)
                    .HasColumnName("COD_CONTRAPART");

                entity.Property(e => e.ComisionPag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMISION_PAG");

                entity.Property(e => e.Comisionpagada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COMISIONPAGADA")
                    .IsFixedLength();

                entity.Property(e => e.CompLinea).HasColumnName("COMP_LINEA");

                entity.Property(e => e.Comprobante).HasColumnName("COMPROBANTE");

                entity.Property(e => e.Concepto)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CONCEPTO")
                    .IsFixedLength();

                entity.Property(e => e.CondPago).HasColumnName("COND_PAGO");

                entity.Property(e => e.Contabilizado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONTABILIZADO")
                    .IsFixedLength();

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COTIZACION")
                    .IsFixedLength();

                entity.Property(e => e.CuentaEfecto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CUENTA_EFECTO")
                    .IsFixedLength();

                entity.Property(e => e.Depura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEPURA");

                entity.Property(e => e.Dias).HasColumnName("DIAS");

                entity.Property(e => e.DiasEntrega).HasColumnName("DIAS_ENTREGA");

                entity.Property(e => e.Diastransc).HasColumnName("DIASTRANSC");

                entity.Property(e => e.Diferencial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DIFERENCIAL")
                    .IsFixedLength();

                entity.Property(e => e.DocCanc).HasColumnName("DOC_CANC");

                entity.Property(e => e.DocJde)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("doc_jde");

                entity.Property(e => e.Documento).HasColumnName("DOCUMENTO");

                entity.Property(e => e.Efectivo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EFECTIVO")
                    .IsFixedLength();

                entity.Property(e => e.Eliminar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINAR")
                    .IsFixedLength();

                entity.Property(e => e.Estacion).HasColumnName("ESTACION");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .IsFixedLength();

                entity.Property(e => e.FechaCobro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_COBRO");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_EMISION");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ENTREGA");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.FechaPlanilla)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PLANILLA");

                entity.Property(e => e.FechaUsuario)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_USUARIO");

                entity.Property(e => e.FechaVcto)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_VCTO");

                entity.Property(e => e.Fechadoccanc)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHADOCCANC");

                entity.Property(e => e.FecrecibPl)
                    .HasColumnType("datetime")
                    .HasColumnName("FECRECIB_PL");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRUPO")
                    .IsFixedLength();

                entity.Property(e => e.GrupoActual)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRUPO_ACTUAL")
                    .IsFixedLength();

                entity.Property(e => e.HoraCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HORA_CREACION");

                entity.Property(e => e.HoraUsario).HasColumnName("HORA_USARIO");

                entity.Property(e => e.InformeQueja).HasColumnName("INFORME_QUEJA");

                entity.Property(e => e.LinCanc).HasColumnName("LIN_CANC");

                entity.Property(e => e.Linea).HasColumnName("LINEA");

                entity.Property(e => e.Lote)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOTE")
                    .IsFixedLength();

                entity.Property(e => e.Matriz)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MATRIZ")
                    .IsFixedLength();

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.MinutosUsuario).HasColumnName("MINUTOS_USUARIO");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MONEDA")
                    .IsFixedLength();

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("MONTO");

                entity.Property(e => e.MontoDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MONTO_DOLAR");

                entity.Property(e => e.MontoMoneda)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MONTO_MONEDA");

                entity.Property(e => e.NoTieneDebe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NO_TIENE_DEBE")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE")
                    .IsFixedLength();

                entity.Property(e => e.NroPlanilla)
                    .HasMaxLength(25)
                    .HasColumnName("NRO_PLANILLA")
                    .IsFixedLength();

                entity.Property(e => e.Nrocheque)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NROCHEQUE")
                    .IsFixedLength();

                entity.Property(e => e.NumeroPl).HasColumnName("NUMERO_PL");

                entity.Property(e => e.Observacion1)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION1")
                    .IsFixedLength();

                entity.Property(e => e.Observacion2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION2")
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.PasoJde)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("paso_jde")
                    .IsFixedLength();

                entity.Property(e => e.PasoSql)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASO_SQL")
                    .IsFixedLength();

                entity.Property(e => e.PlantaOficina).HasColumnName("PLANTA_OFICINA");

                entity.Property(e => e.PorIva)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("POR_IVA");

                entity.Property(e => e.Porcret)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PORCRET");

                entity.Property(e => e.Recalcular)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECALCULAR")
                    .IsFixedLength();

                entity.Property(e => e.RecibidaPl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RECIBIDA_PL");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Referencia).HasColumnName("REFERENCIA");

                entity.Property(e => e.Region)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGION")
                    .IsFixedLength();

                entity.Property(e => e.RegionActual)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGION_ACTUAL")
                    .IsFixedLength();

                entity.Property(e => e.RelacionCobro).HasColumnName("RELACION_COBRO");

                entity.Property(e => e.Remisionma).HasColumnName("REMISIONMA");

                entity.Property(e => e.Remisionsi).HasColumnName("REMISIONSI");

                entity.Property(e => e.Rmonto)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RMONTO");

                entity.Property(e => e.Rsaldo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RSALDO");

                entity.Property(e => e.Rzvre)
                    .HasMaxLength(10)
                    .HasColumnName("RZVRE");

                entity.Property(e => e.Saldo)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("SALDO");

                entity.Property(e => e.SaldoDolar)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("SALDO_DOLAR");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR")
                    .IsFixedLength();

                entity.Property(e => e.TasaCambio)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("TASA_CAMBIO");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .IsFixedLength();

                entity.Property(e => e.TipoCanc)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CANC")
                    .IsFixedLength();

                entity.Property(e => e.TipoCiudad)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CIUDAD")
                    .IsFixedLength();

                entity.Property(e => e.TipoCompania)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_COMPANIA")
                    .IsFixedLength();

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION")
                    .IsFixedLength();

                entity.Property(e => e.Transferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRANSFERENCIA")
                    .IsFixedLength();

                entity.Property(e => e.UltimoPago)
                    .HasColumnType("datetime")
                    .HasColumnName("ULTIMO_PAGO");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO")
                    .IsFixedLength();

                entity.Property(e => e.VecesCobro).HasColumnName("VECES_COBRO");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("VENDEDOR")
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ZONA")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wary182>(entity =>
            {
                entity.HasKey(e => e.Nota)
                    .HasName("WARY182_INDEX01");

                entity.ToTable("WARY182");

                entity.Property(e => e.Nota)
                    .ValueGeneratedNever()
                    .HasColumnName("NOTA");

                entity.Property(e => e.Anulada)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ANULADA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("BANCO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Batch)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BATCH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cambio)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("CAMBIO");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("CANTIDAD");

                entity.Property(e => e.Cliente).HasColumnName("CLIENTE");

                entity.Property(e => e.Cobrador)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COBRADOR")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CodJdepadre)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("COD_JDEPADRE");

                entity.Property(e => e.Contrapartida)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CONTRAPARTIDA")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DatosCliente)
                    .HasColumnType("text")
                    .HasColumnName("DATOS_CLIENTE");

                entity.Property(e => e.DireccionFact1)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACT1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact2)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACT2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DireccionFact3)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_FACT3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_EMISION");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INGRESO")
                    .HasDefaultValueSql("('01/01/1753')");

                entity.Property(e => e.FechaVenc)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_VENC");

                entity.Property(e => e.FlagImpreso)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAG_IMPRESO")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Iva)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("IVA");

                entity.Property(e => e.Ivad)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("IVAD");

                entity.Property(e => e.Ivaporc)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IVAPORC");

                entity.Property(e => e.NitFact)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NIT_FACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NombreFact)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_FACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NroControl).HasColumnName("NRO_CONTROL");

                entity.Property(e => e.Observacion1)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION1")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion2)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION2")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion3)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION3")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Observacion4)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION4")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REGION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RifFact)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RIF_FACT")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Riva)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RIVA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rsubtotal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RSUBTOTAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rtotal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("RTOTAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("SUBTOTAL");

                entity.Property(e => e.Subtotald)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("SUBTOTALD");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.Totald)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTALD");

                entity.Property(e => e.Transaccion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACCION")
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Wary241>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WARY241");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.FechaUpdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA_UPDATE");

                entity.Property(e => e.RutBs)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("RUT_BS");

                entity.Property(e => e.UtBs)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("UT_BS");
            });

            modelBuilder.Entity<Wimy001>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WIMY001");

                entity.Property(e => e.Calibre).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.CategoriaValoracion).HasMaxLength(4);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");

                entity.Property(e => e.CostoValorado)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO_VALORADO");

                entity.Property(e => e.Ctacon)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTACON");

                entity.Property(e => e.Ctainv)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("CTAINV");

                entity.Property(e => e.CtdActual).HasColumnName("CTD_ACTUAL");

                entity.Property(e => e.CtdCompro).HasColumnName("CTD_COMPRO");

                entity.Property(e => e.DescCompras1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_COMPRAS1");

                entity.Property(e => e.DescCompras2)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_COMPRAS2");

                entity.Property(e => e.DescCompras3)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_COMPRAS3");

                entity.Property(e => e.DescMaterial1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_MATERIAL1");

                entity.Property(e => e.DescMaterial2)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_MATERIAL2");

                entity.Property(e => e.DescVentas1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_VENTAS1");

                entity.Property(e => e.DescVentas2)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESC_VENTAS2");

                entity.Property(e => e.Eliminado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO");

                entity.Property(e => e.EquiListPrec)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EQUI_LIST_PREC");

                entity.Property(e => e.FUltCompra)
                    .HasColumnType("datetime")
                    .HasColumnName("F_ULT_COMPRA");

                entity.Property(e => e.FUltEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("F_ULT_ENTRADA");

                entity.Property(e => e.FUltSalida)
                    .HasColumnType("datetime")
                    .HasColumnName("F_ULT_SALIDA");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaModifica)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICA");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENERO");

                entity.Property(e => e.Gramaje)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("GRAMAJE");

                entity.Property(e => e.GrupoArticulo)
                    .HasMaxLength(10)
                    .HasColumnName("GRUPO_ARTICULO");

                entity.Property(e => e.Idcategoria).HasColumnName("IDCATEGORIA");

                entity.Property(e => e.Maximo).HasColumnName("MAXIMO");

                entity.Property(e => e.Minimo).HasColumnName("MINIMO");

                entity.Property(e => e.Observacion)
                    .HasColumnType("text")
                    .HasColumnName("OBSERVACION");

                entity.Property(e => e.Pplana)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PPLANA");

                entity.Property(e => e.PuntoReorden).HasColumnName("PUNTO_REORDEN");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.TiempoEntrega).HasColumnName("TIEMPO_ENTREGA");

                entity.Property(e => e.TipoPapel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PAPEL");

                entity.Property(e => e.UltProveedor).HasColumnName("ULT_PROVEEDOR");

                entity.Property(e => e.UltimoCosto)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("ULTIMO_COSTO");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD");

                entity.Property(e => e.UsuarioCreo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_CREO");

                entity.Property(e => e.UsuarioModif)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MODIF");

                entity.Property(e => e.Zonaalmcensap)
                    .HasMaxLength(3)
                    .HasColumnName("ZONAALMCENSAP");
            });

            modelBuilder.Entity<Wivy003>(entity =>
            {
                entity.HasKey(e => e.Recnum);

                entity.ToTable("WIVY003");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.AprobCredM)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APROB_CRED_M")
                    .IsFixedLength();

                entity.Property(e => e.CodJde)
                    .HasMaxLength(3)
                    .HasColumnName("COD_JDE")
                    .IsFixedLength();

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DiasVcto).HasColumnName("DIAS_VCTO");

                entity.Property(e => e.Inactivo)
                    .HasMaxLength(1)
                    .HasColumnName("inactivo")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.PorcRequerido).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RequiereLimiteCredito)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

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
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.IdDireccionEntregar)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_direccionEntregar");

                entity.Property(e => e.IdDireccionFacturar)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Id_direccionFacturar");

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

            modelBuilder.Entity<Wsmy582>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY582");

                entity.Property(e => e.Frecuencia).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MedidaDecimal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MedidaFraccion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MedidaMascara)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Wsmy583>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSMY583");

                entity.Property(e => e.Frecuencia).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MedidaDecimal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MedidaFraccion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MedidaMascara)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
