using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AppService.Infrastructure.Data
{
    public class RRDContext : DbContext
    {
        public RRDContext()
        {
        }

        public RRDContext(DbContextOptions<RRDContext> options)
          : base((DbContextOptions)options)
        {
        }


        public virtual DbSet<AppService.Core.Entities.AppRepeticionClienteProducto> AppRepeticionClienteProducto { get; set; }
        public virtual DbSet<AppService.Core.Entities.AppRepeticionClienteNombreForma> AppRepeticionClienteNombreForma { get; set; }
        public virtual DbSet<AppService.Core.Entities.AppRepeticionClienteBasica> AppRepeticionClienteBasica { get; set; }
        public virtual DbSet<AppService.Core.Entities.AppRepeticionClienteOpuesta> AppRepeticionClienteOpuesta { get; set; }
        public virtual DbSet<AppService.Core.Entities.AppRepeticionClientePartes> AppRepeticionClientePartes { get; set; }
        public virtual DbSet<AppService.Core.Entities.AppRepeticionClienteTintas> AppRepeticionClienteTintas { get; set; }
        public virtual DbSet<AppService.Core.Entities.AppRepeticionClientePapelPrimeraParte> AppRepeticionClientePapelPrimeraParte { get; set; }
        public virtual DbSet<AppService.Core.Entities.AppRepeticionClientePapelSegundaParte> AppRepeticionClientePapelSegundaParte { get; set; }
        public virtual DbSet<AppService.Core.Entities.AppRepeticionClientePapelTerceraParte> AppRepeticionClientePapelTerceraParte { get; set; }
        public virtual DbSet<AppService.Core.Entities.AppRepeticionClientePapelCuartaParte> AppRepeticionClientePapelCuartaParte { get; set; }
        public virtual DbSet<AppService.Core.Entities.AppRepeticionClientePapelQuintaParte> AppRepeticionClientePapelQuintaParte { get; set; }


        public virtual DbSet<AppService.Core.Entities.MtrClienteEnvioOdooLog> MtrClienteEnvioOdooLog { get; set; }



        public virtual DbSet<AppService.Core.Entities.AppOrdenProductoRepeticion> AppOrdenProductoRepeticion { get; set; }
        public virtual DbSet<AppService.Core.Entities.AppCategory> AppCategory { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppConfigApp> AppConfigApp { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppDetailQuotes> AppDetailQuotes { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppDetailQuotesConversionUnit> AppDetailQuotesConversionUnit { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppEmbarques> AppEmbarques { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppGeneralQuotes> AppGeneralQuotes { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppIngredients> AppIngredients { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppProductVariableSearchText> AppProductVariableSearchText { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppProducts> AppProducts { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppRecipes> AppRecipes { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppProductConversion> AppProductConversion { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppRecipesByAppDetailQuotes> AppRecipesByAppDetailQuotes { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppRecipesByAppDetailQuotesHistory> AppRecipesByAppDetailQuotesHistory { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppPrice> AppPrice { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppStatusQuote> AppStatusQuote { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppSubCategory> AppSubCategory { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppTemplateConversionUnit> AppTemplateConversionUnit { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppUnits> AppUnits { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppUnitsofMeasureforIngredients> AppUnitsofMeasureforIngredients { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppUnitsofMeasureforMaterials> AppUnitsofMeasureforMaterials { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppVariableSearch> AppVariableSearch { get; set; }

        public virtual DbSet<AppService.Core.Entities.AppVariables> AppVariables { get; set; }

        public virtual DbSet<AppService.Core.Entities.AspNetRoles> AspNetRoles { get; set; }

        public virtual DbSet<AppService.Core.Entities.AspNetUserClaims> AspNetUserClaims { get; set; }

        public virtual DbSet<AppService.Core.Entities.AspNetUserLogins> AspNetUserLogins { get; set; }

        public virtual DbSet<AppService.Core.Entities.AspNetUserRoles> AspNetUserRoles { get; set; }

        public virtual DbSet<AppService.Core.Entities.AspNetUsers> AspNetUsers { get; set; }

        public virtual DbSet<AppService.Core.Entities.Audit> Audit { get; set; }

        public virtual DbSet<AppService.Core.Entities.AutoAudit> AutoAudit { get; set; }

        public virtual DbSet<AppService.Core.Entities.Cary028> Cary028 { get; set; }

        public virtual DbSet<AppService.Core.Entities.Cary029> Cary029 { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatAuditoriaCalculo> CatAuditoriaCalculo { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatCalibrePapel> CatCalibrePapel { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatCalibrePapelRollos> CatCalibrePapelRollos { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatCodigoMayorPartesBasica> CatCodigoMayorPartesBasica { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatLista> CatLista { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatMaterial> CatMaterial { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatMaterialDetalle> CatMaterialDetalle { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatMaterialDetalleTmp> CatMaterialDetalleTmp { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatMedidaBasica> CatMedidaBasica { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatMedidaBasica1> CatMedidaBasica1 { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatMedidaBasicaRollos> CatMedidaBasicaRollos { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatMedidaOpuesta> CatMedidaOpuesta { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatPapel> CatPapel { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatProductoMayor> CatProductoMayor { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatProductoMayorPartes> CatProductoMayorPartes { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatProductoMayorPartesTintas> CatProductoMayorPartesTintas { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatProductoMayorPartesTintasBasica> CatProductoMayorPartesTintasBasica { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuesta> CatProductoMayorPartesTintasBasicaOpuesta { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapeles> CatProductoMayorPartesTintasBasicaOpuestaPapeles { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon> CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatProductoMayorUnidadesConversion> CatProductoMayorUnidadesConversion { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatSubCategoria> CatSubCategoria { get; set; }

        public virtual DbSet<AppService.Core.Entities.CatSysfile> CatSysfile { get; set; }

        public virtual DbSet<AppService.Core.Entities.ChildMenu> ChildMenu { get; set; }

        public virtual DbSet<AppService.Core.Entities.Ciny056> Ciny056 { get; set; }

        public virtual DbSet<AppService.Core.Entities.Ciny057> Ciny057 { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobAdjuntosCobranza> CobAdjuntosCobranza { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobAvisosCobro> CobAvisosCobro { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobAvisosCobroTemp> CobAvisosCobroTemp { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobBanco> CobBanco { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobDatosCheque> CobDatosCheque { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion> CobDescuentoIvaTipoTransaccion { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobDiferenciaRetencion> CobDiferenciaRetencion { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobEstadoDeCuenta> CobEstadoDeCuenta { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobEstadoDeCuentaBk> CobEstadoDeCuentaBk { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobExcepcion> CobExcepcion { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobGeneralCobranza> CobGeneralCobranza { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobGrabacionCobranzas> CobGrabacionCobranzas { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobIntegridadCobranzasVsWary074> CobIntegridadCobranzasVsWary074 { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobMatrixMonedaValidaPago> CobMatrixMonedaValidaPago { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobPagosRetenciones> CobPagosRetenciones { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobPorcentajesImpuestos> CobPorcentajesImpuestos { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobRangosVencimiento> CobRangosVencimiento { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobResumenEstadoCuenta> CobResumenEstadoCuenta { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobResumenEstadoCuentaTemp> CobResumenEstadoCuentaTemp { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobRolCobranza> CobRolCobranza { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobSysfile> CobSysfile { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobTipoTransaccion> CobTipoTransaccion { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobTipoTransaccionRespaldoAntesEliminarColettilla> CobTipoTransaccionRespaldoAntesEliminarColettilla { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobTransacciones> CobTransacciones { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobValoresRetencionIslr> CobValoresRetencionIslr { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobValoresRetencionIva> CobValoresRetencionIva { get; set; }

        public virtual DbSet<AppService.Core.Entities.CobValoresRetenciones> CobValoresRetenciones { get; set; }

        public virtual DbSet<AppService.Core.Entities.Company> Company { get; set; }

        public virtual DbSet<AppService.Core.Entities.Cpry010> Cpry010 { get; set; }

        public virtual DbSet<AppService.Core.Entities.Cpry012> Cpry012 { get; set; }

        public virtual DbSet<AppService.Core.Entities.CreAdjuntoSolicitudCredito> CreAdjuntoSolicitudCredito { get; set; }

        public virtual DbSet<AppService.Core.Entities.CreClientesExcepcion> CreClientesExcepcion { get; set; }

        public virtual DbSet<AppService.Core.Entities.CreCotizacionDocumento> CreCotizacionDocumento { get; set; }

        public virtual DbSet<AppService.Core.Entities.CreEvaluacionCredito> CreEvaluacionCredito { get; set; }

        public virtual DbSet<AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias> CreRangoAprobacionOficinaUsuarioMontoDias { get; set; }

        public virtual DbSet<AppService.Core.Entities.CreResponsableAprobarExcepcion> CreResponsableAprobarExcepcion { get; set; }

        public virtual DbSet<AppService.Core.Entities.CreSolicitudDeCredito> CreSolicitudDeCredito { get; set; }

        public virtual DbSet<AppService.Core.Entities.CreSolicitudDeCreditoHistorico> CreSolicitudDeCreditoHistorico { get; set; }

        public virtual DbSet<AppService.Core.Entities.CreSolicitudExcepcion> CreSolicitudExcepcion { get; set; }

        public virtual DbSet<AppService.Core.Entities.CreSolicitudExcepcionHistorico> CreSolicitudExcepcionHistorico { get; set; }

        public virtual DbSet<AppService.Core.Entities.CrmEncuestaCliente> CrmEncuestaCliente { get; set; }

        public virtual DbSet<AppService.Core.Entities.CrmMtrCes> CrmMtrCes { get; set; }

        public virtual DbSet<AppService.Core.Entities.CrmMtrCs> CrmMtrCs { get; set; }

        public virtual DbSet<AppService.Core.Entities.CrmMtrEstado> CrmMtrEstado { get; set; }

        public virtual DbSet<AppService.Core.Entities.CrmMtrNps> CrmMtrNps { get; set; }

        public virtual DbSet<AppService.Core.Entities.CrmMtrSeguimiento> CrmMtrSeguimiento { get; set; }

        public virtual DbSet<AppService.Core.Entities.CrmNotificacionActividades> CrmNotificacionActividades { get; set; }

        public virtual DbSet<AppService.Core.Entities.CrmSeguimiento> CrmSeguimiento { get; set; }

        public virtual DbSet<AppService.Core.Entities.CrmVisitaDia> CrmVisitaDia { get; set; }

        public virtual DbSet<AppService.Core.Entities.CrmVisitaFrecuencia> CrmVisitaFrecuencia { get; set; }

        public virtual DbSet<AppService.Core.Entities.CrmVisitaSemana> CrmVisitaSemana { get; set; }

        public virtual DbSet<AppService.Core.Entities.Ctmy033> Ctmy033 { get; set; }

        public virtual DbSet<AppService.Core.Entities.Ctmy034> Ctmy034 { get; set; }

        public virtual DbSet<AppService.Core.Entities.DataInicial> DataInicial { get; set; }

        public virtual DbSet<AppService.Core.Entities.DeudorTipoRetencion> DeudorTipoRetencion { get; set; }

        public virtual DbSet<AppService.Core.Entities.Deudores> Deudores { get; set; }

        public virtual DbSet<AppService.Core.Entities.EjeucionProceso> EjeucionProceso { get; set; }

        public virtual DbSet<AppService.Core.Entities.EjeucionProcesoComisiones> EjeucionProcesoComisiones { get; set; }

        public virtual DbSet<AppService.Core.Entities.EscaneoTicket> EscaneoTicket { get; set; }

        public virtual DbSet<AppService.Core.Entities.F03b11> F03b11 { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssAdjuntoTarea> GssAdjuntoTarea { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssAdminApp> GssAdminApp { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssAprobacionServicio> GssAprobacionServicio { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssAreaServicio> GssAreaServicio { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssCompañia> GssCompañia { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssEstatusSolicitud> GssEstatusSolicitud { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssEstatusTarea> GssEstatusTarea { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssGrupoTrabajo> GssGrupoTrabajo { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssGrupoTrabajoUsuario> GssGrupoTrabajoUsuario { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssMtrTipoDato> GssMtrTipoDato { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssNivel> GssNivel { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssPais> GssPais { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssPasoSolicitud> GssPasoSolicitud { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssPlantillaServicio> GssPlantillaServicio { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssServicioNivel> GssServicioNivel { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssServicioResponsable> GssServicioResponsable { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssServicios> GssServicios { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssSolicitud> GssSolicitud { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssSolicitudServicio> GssSolicitudServicio { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssTarea> GssTarea { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssTareaComentario> GssTareaComentario { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssTareaPlantillaServicio> GssTareaPlantillaServicio { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssTipoDocumento> GssTipoDocumento { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssTipoServicio> GssTipoServicio { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssUnidadServicio> GssUnidadServicio { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssUnidadServicioCompañia> GssUnidadServicioCompañia { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssUsuarioCompañia> GssUsuarioCompañia { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssUsuarioNivel> GssUsuarioNivel { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssUsuarioPlantillaServicio> GssUsuarioPlantillaServicio { get; set; }

        public virtual DbSet<AppService.Core.Entities.GssVariable> GssVariable { get; set; }

        public virtual DbSet<AppService.Core.Entities.Marm> Marm { get; set; }

        public virtual DbSet<AppService.Core.Entities.MigrationHistory> MigrationHistory { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrBancos> MtrBancos { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrCliente> MtrCliente { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrClienteProspecto> MtrClienteProspecto { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrClienteTemp> MtrClienteTemp { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrCondicionPago> MtrCondicionPago { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrContactos> MtrContactos { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrDirecciones> MtrDirecciones { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrEmpleado> MtrEmpleado { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrFechaFeriada> MtrFechaFeriada { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrHorarioLaborable> MtrHorarioLaborable { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrOficina> MtrOficina { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrPerfilCorreo> MtrPerfilCorreo { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrProducto> MtrProducto { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrProductoBasica> MtrProductoBasica { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrProductoOpuesta> MtrProductoOpuesta { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrProductoPapeles> MtrProductoPapeles { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrRegiones> MtrRegiones { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrTipoCuentaDestino> MtrTipoCuentaDestino { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrTipoDocumentoFiscal> MtrTipoDocumentoFiscal { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrTipoMoneda> MtrTipoMoneda { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrTipoNomina> MtrTipoNomina { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrTipoOrden> MtrTipoOrden { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrTipoTransaccionCuentaDestino> MtrTipoTransaccionCuentaDestino { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrTipoValorRetencion> MtrTipoValorRetencion { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrUsuarioOficina> MtrUsuarioOficina { get; set; }

        public virtual DbSet<AppService.Core.Entities.MtrVendedor> MtrVendedor { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdAdjunto> OfdAdjunto { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdAdjuntoCriterio> OfdAdjuntoCriterio { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdAdjuntosDiseno> OfdAdjuntosDiseno { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdAprobacionDiseno> OfdAprobacionDiseno { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdCambioDiseno> OfdCambioDiseno { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdConstruccionCotizacion> OfdConstruccionCotizacion { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdCotizacion> OfdCotizacion { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdCriterioBusqueda> OfdCriterioBusqueda { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdDetalleSolicitudDiseno> OfdDetalleSolicitudDiseno { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdEspecificacionCotizacion> OfdEspecificacionCotizacion { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdEstatusFlujo> OfdEstatusFlujo { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdExcepcionFlujoProducto> OfdExcepcionFlujoProducto { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdFlujoEstacion> OfdFlujoEstacion { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdGrupoCriterio> OfdGrupoCriterio { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdGrupoTipoDocumento> OfdGrupoTipoDocumento { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdMaestroEstacion> OfdMaestroEstacion { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdMaestroFlujo> OfdMaestroFlujo { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdMaestroPieImprenta> OfdMaestroPieImprenta { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdMaestroTipoRespaldo> OfdMaestroTipoRespaldo { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdMaestroUbicacionMarginal> OfdMaestroUbicacionMarginal { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdMaestroVoBo> OfdMaestroVoBo { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdObservacionAdjunto> OfdObservacionAdjunto { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdPartesCotizacion> OfdPartesCotizacion { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdPlantillaPreset> OfdPlantillaPreset { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdPropuesta> OfdPropuesta { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdPropuestaResp> OfdPropuestaResp { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdRenglon> OfdRenglon { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdRolTipoDocumento> OfdRolTipoDocumento { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdSeguimiento> OfdSeguimiento { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdSolicitudDiseno> OfdSolicitudDiseno { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdSolicitudDisenoCambios> OfdSolicitudDisenoCambios { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdSolicitudDocFiscal> OfdSolicitudDocFiscal { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdTintasCotizacion> OfdTintasCotizacion { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdTipoCambioDiseno> OfdTipoCambioDiseno { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdTipoDocumento> OfdTipoDocumento { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdVariablesEspecificacion> OfdVariablesEspecificacion { get; set; }

        public virtual DbSet<AppService.Core.Entities.OfdVoBoDiseno> OfdVoBoDiseno { get; set; }

        public virtual DbSet<AppService.Core.Entities.PageMenu> PageMenu { get; set; }

        public virtual DbSet<AppService.Core.Entities.Personas> Personas { get; set; }

        public virtual DbSet<AppService.Core.Entities.PrcNumeracionFiscal> PrcNumeracionFiscal { get; set; }

        public virtual DbSet<AppService.Core.Entities.PrcObjetosProcesos> PrcObjetosProcesos { get; set; }

        public virtual DbSet<AppService.Core.Entities.PrcOrdenIdPropuesta> PrcOrdenIdPropuesta { get; set; }

        public virtual DbSet<AppService.Core.Entities.PrcPlantillaNumeraciones> PrcPlantillaNumeraciones { get; set; }

        public virtual DbSet<AppService.Core.Entities.PrcUsuarioProcesos> PrcUsuarioProcesos { get; set; }

        public virtual DbSet<AppService.Core.Entities.Producto> Producto { get; set; }

        public virtual DbSet<AppService.Core.Entities.ReqAreaRequerimiento> ReqAreaRequerimiento { get; set; }

        public virtual DbSet<AppService.Core.Entities.ReqCompañia> ReqCompañia { get; set; }

        public virtual DbSet<AppService.Core.Entities.ReqOrigenRequerimiento> ReqOrigenRequerimiento { get; set; }

        public virtual DbSet<AppService.Core.Entities.ReqTarea> ReqTarea { get; set; }

        public virtual DbSet<AppService.Core.Entities.ReqTipoTarea> ReqTipoTarea { get; set; }

        public virtual DbSet<AppService.Core.Entities.ReqVariables> ReqVariables { get; set; }

        public virtual DbSet<AppService.Core.Entities.RetencionesCorregir> RetencionesCorregir { get; set; }

        public virtual DbSet<AppService.Core.Entities.RrdejecutarSql> RrdejecutarSql { get; set; }

        public virtual DbSet<AppService.Core.Entities.SapFrecuenciaVisitaCliente> SapFrecuenciaVisitaCliente { get; set; }

        public virtual DbSet<AppService.Core.Entities.SapRetenciones> SapRetenciones { get; set; }

        public virtual DbSet<AppService.Core.Entities.SegModulo> SegModulo { get; set; }

        public virtual DbSet<AppService.Core.Entities.SegPrograma> SegPrograma { get; set; }

        public virtual DbSet<AppService.Core.Entities.SegRol> SegRol { get; set; }

        public virtual DbSet<AppService.Core.Entities.SegRolEstacion> SegRolEstacion { get; set; }

        public virtual DbSet<AppService.Core.Entities.SegRolModulo> SegRolModulo { get; set; }

        public virtual DbSet<AppService.Core.Entities.SegTicket> SegTicket { get; set; }

        public virtual DbSet<AppService.Core.Entities.SegUsuario> SegUsuario { get; set; }

        public virtual DbSet<AppService.Core.Entities.SegUsuarioRol> SegUsuarioRol { get; set; }

        public virtual DbSet<AppService.Core.Entities.Sysfile> Sysfile { get; set; }

        public virtual DbSet<AppService.Core.Entities.T006a> T006a { get; set; }

        public virtual DbSet<AppService.Core.Entities.TEnControlCalculo> TEnControlCalculo { get; set; }

        public virtual DbSet<AppService.Core.Entities.TEnEntradas> TEnEntradas { get; set; }

        public virtual DbSet<AppService.Core.Entities.TPaFormulas> TPaFormulas { get; set; }

        public virtual DbSet<AppService.Core.Entities.TPaModeloCalculo> TPaModeloCalculo { get; set; }

        public virtual DbSet<AppService.Core.Entities.TPaPlantillaEntradas> TPaPlantillaEntradas { get; set; }

        public virtual DbSet<AppService.Core.Entities.TPaSysfile> TPaSysfile { get; set; }

        public virtual DbSet<AppService.Core.Entities.TPaTasaBancoCentral> TPaTasaBancoCentral { get; set; }

        public virtual DbSet<AppService.Core.Entities.TPaTasaReferencial> TPaTasaReferencial { get; set; }

        public virtual DbSet<AppService.Core.Entities.TPaTipoCalculo> TPaTipoCalculo { get; set; }

        public virtual DbSet<AppService.Core.Entities.TPaTiposDeVariables> TPaTiposDeVariables { get; set; }

        public virtual DbSet<AppService.Core.Entities.TPaVariables> TPaVariables { get; set; }

        public virtual DbSet<AppService.Core.Entities.TPrCalculo> TPrCalculo { get; set; }

        public virtual DbSet<AppService.Core.Entities.TSaCalculoHistorico> TSaCalculoHistorico { get; set; }

        public virtual DbSet<AppService.Core.Entities.TSaEntradasHistorico> TSaEntradasHistorico { get; set; }

        public virtual DbSet<AppService.Core.Entities.TSaPlantillaReporteAnalisisCredito> TSaPlantillaReporteAnalisisCredito { get; set; }

        public virtual DbSet<AppService.Core.Entities.TSaReporteAnalisisCredito> TSaReporteAnalisisCredito { get; set; }

        public virtual DbSet<AppService.Core.Entities.TempRbfactura> TempRbfactura { get; set; }

        public virtual DbSet<AppService.Core.Entities.TempReciboCobro> TempReciboCobro { get; set; }

        public virtual DbSet<AppService.Core.Entities.Thumbnail> Thumbnail { get; set; }

        public virtual DbSet<AppService.Core.Entities.User> User { get; set; }

        public virtual DbSet<AppService.Core.Entities.VRetencionesCobradas> VRetencionesCobradas { get; set; }

        public virtual DbSet<AppService.Core.Entities.ValevenDataResumen> ValevenDataResumen { get; set; }

        public virtual DbSet<AppService.Core.Entities.ValevenImpresiones> ValevenImpresiones { get; set; }

        public virtual DbSet<AppService.Core.Entities.Wary074> Wary074 { get; set; }

        public virtual DbSet<AppService.Core.Entities.Wary074temp> Wary074temp { get; set; }

        public virtual DbSet<AppService.Core.Entities.Wary074tempReconstruir> Wary074tempReconstruir { get; set; }

        public virtual DbSet<AppService.Core.Entities.Wary182> Wary182 { get; set; }

        public virtual DbSet<AppService.Core.Entities.Wary241> Wary241 { get; set; }

        public virtual DbSet<AppService.Core.Entities.Wivy003> Wivy003 { get; set; }

        public virtual DbSet<AppService.Core.Entities.Wsmy469> Wsmy469 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppService.Core.Entities.AppCategory>((Action<EntityTypeBuilder<AppService.Core.Entities.AppCategory>>)(entity =>
            {
                entity.Property<int>((Expression<Func<AppService.Core.Entities.AppCategory, int>>)(e => e.Id)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppCategory, string>>)(e => e.Description)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppConfigApp>((Action<EntityTypeBuilder<AppService.Core.Entities.AppConfigApp>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppConfigApp, string>>)(e => e.Clave)).HasMaxLength((int)byte.MaxValue).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppConfigApp, string>>)(e => e.Valor)).HasMaxLength((int)byte.MaxValue).IsUnicode(false);
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppDetailQuotes>((Action<EntityTypeBuilder<AppService.Core.Entities.AppDetailQuotes>>)(entity =>
            {
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal>>)(e => e.Cantidad)).HasColumnType<Decimal>("numeric(18, 3)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal?>>)(e => e.CantidadPorUnidadProduccion)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal?>>)(e => e.CantidadSolicitada)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, string>>)(e => e.Cotizacion)).IsRequired(true).HasMaxLength(13);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, DateTime>>)(e => e.CreatedAt)).HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, string>>)(e => e.NombreComercialProducto)).IsRequired(true).HasMaxLength(200);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, string>>)(e => e.ObsSolicitud)).HasMaxLength(300);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, string>>)(e => e.Observaciones)).IsRequired(true).HasMaxLength(300);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal>>)(e => e.Precio)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal>>)(e => e.PrecioUsd)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, string>>)(e => e.Producto)).HasMaxLength(20);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal?>>)(e => e.Rprecio)).HasColumnName<Decimal?>("RPrecio").HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal?>>)(e => e.Rtotal)).HasColumnName<Decimal?>("RTotal").HasColumnType<Decimal?>("numeric(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, bool?>>)(e => e.SolicitarPrecio)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal>>)(e => e.Total)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal>>)(e => e.TotalUsd)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal?>>)(e => e.UnitPriceBaseProduction)).HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal?>>)(e => e.UnitPriceConverted)).HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, DateTime?>>)(e => e.UpdatedAt)).HasDefaultValueSql<DateTime?>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, string>>)(e => e.UserCreate)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, string>>)(e => e.UserUpdate)).HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, Decimal?>>)(e => e.ValorConvertido)).HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.HasOne<AppService.Core.Entities.AppGeneralQuotes>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, AppService.Core.Entities.AppGeneralQuotes>>)(d => d.AppGeneralQuotes)).WithMany((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, IEnumerable<AppService.Core.Entities.AppDetailQuotes>>>)(p => p.AppDetailQuotes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppDetailQuotes, object>>)(d => (object)d.AppGeneralQuotesId)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.AppGeneralQuotes, AppService.Core.Entities.AppDetailQuotes>("FK_AppDetailQuotes_AppDetailQuotes");
                entity.HasOne<AppService.Core.Entities.AppStatusQuote>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, AppService.Core.Entities.AppStatusQuote>>)(d => d.IdEstatusNavigation)).WithMany((Expression<Func<AppService.Core.Entities.AppStatusQuote, IEnumerable<AppService.Core.Entities.AppDetailQuotes>>>)(p => p.AppDetailQuotes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppDetailQuotes, object>>)(d => (object)d.IdEstatus)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.AppStatusQuote, AppService.Core.Entities.AppDetailQuotes>("FK_AppDetailQuotes_AppStatusQuote");
                entity.HasOne<AppService.Core.Entities.AppProducts>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, AppService.Core.Entities.AppProducts>>)(d => d.IdProductoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.AppProducts, IEnumerable<AppService.Core.Entities.AppDetailQuotes>>>)(p => p.AppDetailQuotes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppDetailQuotes, object>>)(d => (object)d.IdProducto)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.AppProducts, AppService.Core.Entities.AppDetailQuotes>("FK_AppDetailQuotes_AppDetailQuotes1");
                entity.HasOne<AppService.Core.Entities.AppUnits>((Expression<Func<AppService.Core.Entities.AppDetailQuotes, AppService.Core.Entities.AppUnits>>)(d => d.IdUnidadNavigation)).WithMany((Expression<Func<AppService.Core.Entities.AppUnits, IEnumerable<AppService.Core.Entities.AppDetailQuotes>>>)(p => p.AppDetailQuotes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppDetailQuotes, object>>)(d => (object)d.IdUnidad)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.AppUnits, AppService.Core.Entities.AppDetailQuotes>("FK_AppDetailQuotes_AppUnits");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppDetailQuotesConversionUnit>((Action<EntityTypeBuilder<AppService.Core.Entities.AppDetailQuotesConversionUnit>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppDetailQuotesConversionUnit, string>>)(e => e.Code)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppDetailQuotesConversionUnit, string>>)(e => e.Description)).HasMaxLength(100);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppDetailQuotesConversionUnit, Decimal?>>)(e => e.Max)).HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppDetailQuotesConversionUnit, Decimal?>>)(e => e.Min)).HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppDetailQuotesConversionUnit, Decimal?>>)(e => e.Value)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.HasOne<AppService.Core.Entities.AppDetailQuotes>((Expression<Func<AppService.Core.Entities.AppDetailQuotesConversionUnit, AppService.Core.Entities.AppDetailQuotes>>)(d => d.AppDetailQuotes)).WithMany((Expression<Func<AppService.Core.Entities.AppDetailQuotes, IEnumerable<AppService.Core.Entities.AppDetailQuotesConversionUnit>>>)(p => p.AppDetailQuotesConversionUnit)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppDetailQuotesConversionUnit, object>>)(d => (object)d.AppDetailQuotesId)).HasConstraintName<AppService.Core.Entities.AppDetailQuotes, AppService.Core.Entities.AppDetailQuotesConversionUnit>("FK_AppDetailQuotesConversionUnit_AppDetailQuotes");
                entity.HasOne<AppService.Core.Entities.AppVariables>((Expression<Func<AppService.Core.Entities.AppDetailQuotesConversionUnit, AppService.Core.Entities.AppVariables>>)(d => d.AppVariable)).WithMany((Expression<Func<AppService.Core.Entities.AppVariables, IEnumerable<AppService.Core.Entities.AppDetailQuotesConversionUnit>>>)(p => p.AppDetailQuotesConversionUnit)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppDetailQuotesConversionUnit, object>>)(d => (object)d.AppVariableId)).HasConstraintName<AppService.Core.Entities.AppVariables, AppService.Core.Entities.AppDetailQuotesConversionUnit>("FK_AppDetailQuotesConversionUnit_AppVariables");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppEmbarques>((Action<EntityTypeBuilder<AppService.Core.Entities.AppEmbarques>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.AppEmbarques>("App_Embarques");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppEmbarques, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppEmbarques, string>>)(e => e.NombreCategoria)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppEmbarques, string>>)(e => e.NombreSubCategoria)).HasMaxLength(100);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppEmbarques, Decimal?>>)(e => e.TotalVenta)).HasColumnType<Decimal?>("numeric(18, 2)");
            }));
            //modelBuilder.Entity<AppService.Core.Entities.AppGeneralQuotes>((Action<EntityTypeBuilder<AppService.Core.Entities.AppGeneralQuotes>>)(entity =>
            //{
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.Cotizacion)).IsRequired(true).HasMaxLength(13);
            //    entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, DateTime>>)(e => e.CreatedAt)).HasDefaultValueSql<DateTime>("(getdate())");
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.DescripcionMunicipio)).HasMaxLength(50).HasDefaultValueSql<string>("('')");
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.Direccion)).HasMaxLength(240);
            //    entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, DateTime>>)(e => e.Fecha)).HasColumnType<DateTime>("datetime");
            //    entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, DateTime>>)(e => e.FechaActualiza)).HasColumnType<DateTime>("datetime");
            //    entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, DateTime>>)(e => e.FechaCaducidad)).HasColumnType<DateTime>("datetime");
            //    entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, DateTime?>>)(e => e.FechaPostergada)).HasColumnType<DateTime?>("datetime");
            //    entity.Property<bool?>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, bool?>>)(e => e.FijarPrecioBs)).HasDefaultValueSql<bool?>("((0))");
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.IdCliente)).IsRequired(true).HasMaxLength(10);
            //    entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, Decimal>>)(e => e.IdDireccionEntregar)).HasColumnType<Decimal>("numeric(18, 0)");
            //    entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, Decimal>>)(e => e.IdDireccionFacturar)).HasColumnType<Decimal>("numeric(18, 0)");
            //    entity.Property<long?>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, long?>>)(e => e.IdMtrTipoMoneda)).HasDefaultValueSql<long?>("((1))");
            //    entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, Decimal?>>)(e => e.IdMunicipio)).HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.IdVendedor)).IsRequired(true).HasMaxLength(4);
            //    entity.Property<bool?>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, bool?>>)(e => e.IntegrarCotizacion)).HasDefaultValueSql<bool?>("((0))");
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.ObservacionPostergar)).IsRequired(true).HasMaxLength(500);
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.Observaciones)).IsRequired(true).HasMaxLength(250);
            //    entity.Property<long?>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, long?>>)(e => e.Orden)).HasDefaultValueSql<long?>("((0))");
            //    entity.Property<long?>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, long?>>)(e => e.OrdenAnterior)).HasDefaultValueSql<long?>("((0))");
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.OrdenCompra)).IsRequired(true).HasMaxLength(16);
            //    entity.Property<int?>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, int?>>)(e => e.Proximo)).HasDefaultValueSql<int?>("((0))");
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.RazonSocial)).HasMaxLength(80);
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.Rif)).HasMaxLength(12);
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.SearchText)).IsRequired(true).HasMaxLength(400).HasDefaultValueSql<string>("('')");
            //    entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, DateTime?>>)(e => e.UpdatedAt)).HasDefaultValueSql<DateTime?>("(getdate())");
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.UserCreate)).IsRequired(true).HasMaxLength(50);
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.UserUpdate)).HasMaxLength(50);
            //    entity.Property<string>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, string>>)(e => e.UsuarioActualiza)).IsRequired(true).HasMaxLength(50);
            //    entity.HasOne<AppService.Core.Entities.MtrCliente>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, AppService.Core.Entities.MtrCliente>>)(d => d.IdClienteNavigation)).WithOne((Expression<Func<AppService.Core.Entities.MtrCliente, AppService.Core.Entities.AppGeneralQuotes>>)(x => x.AppGeneralQuotes)).HasPrincipalKey<AppService.Core.Entities.AppGeneralQuotes>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, object>>)(x => x.IdCliente)).HasForeignKey<AppService.Core.Entities.MtrCliente>((Expression<Func<AppService.Core.Entities.MtrCliente, object>>)(x => x.Codigo)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.AppGeneralQuotes, AppService.Core.Entities.MtrCliente>("FK_AppGeneralQuotes_MtrCliente");
            //    entity.HasOne<AppService.Core.Entities.MtrContactos>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, AppService.Core.Entities.MtrContactos>>)(d => d.IdContactoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrContactos, IEnumerable<AppService.Core.Entities.AppGeneralQuotes>>>)(p => p.AppGeneralQuotes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, object>>)(d => (object)d.IdContacto)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrContactos, AppService.Core.Entities.AppGeneralQuotes>("FK_AppGeneralQuotes_MtrContactos");
            //    entity.HasOne<AppService.Core.Entities.AppStatusQuote>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, AppService.Core.Entities.AppStatusQuote>>)(d => d.IdEstatusNavigation)).WithMany((Expression<Func<AppService.Core.Entities.AppStatusQuote, IEnumerable<AppService.Core.Entities.AppGeneralQuotes>>>)(p => p.AppGeneralQuotes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, object>>)(d => (object)d.IdEstatus)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.AppStatusQuote, AppService.Core.Entities.AppGeneralQuotes>("FK_AppGeneralQuotes_AppStatusQuote");
            //    entity.HasOne<AppService.Core.Entities.MtrTipoMoneda>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, AppService.Core.Entities.MtrTipoMoneda>>)(d => d.IdMtrTipoMonedaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrTipoMoneda, IEnumerable<AppService.Core.Entities.AppGeneralQuotes>>>)(p => p.AppGeneralQuotes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, object>>)(d => (object)d.IdMtrTipoMoneda)).HasConstraintName<AppService.Core.Entities.MtrTipoMoneda, AppService.Core.Entities.AppGeneralQuotes>("FK_AppGeneralQuotes_MtrTipoMoneda");
            //    entity.HasOne<AppService.Core.Entities.MtrVendedor>((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, AppService.Core.Entities.MtrVendedor>>)(d => d.IdVendedorNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrVendedor, IEnumerable<AppService.Core.Entities.AppGeneralQuotes>>>)(p => p.AppGeneralQuotes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppGeneralQuotes, object>>)(d => d.IdVendedor)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrVendedor, AppService.Core.Entities.AppGeneralQuotes>("FK_AppGeneralQuotes_MtrVendedor");
            //}));

            modelBuilder.Entity<AppService.Core.Entities.AppGeneralQuotes>(entity =>
            {
                entity.HasIndex(e => e.Fecha, "IX_AppGeneralQuotes");

                entity.HasIndex(e => new { e.Fecha, e.SearchText }, "IX_AppGeneralQuotes_1");

                entity.HasIndex(e => e.Cotizacion, "IX_AppGeneralQuotes_2");

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

                entity.Property(e => e.RetornarAGrabacion)
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

            modelBuilder.Entity<AppService.Core.Entities.AppIngredients>((Action<EntityTypeBuilder<AppService.Core.Entities.AppIngredients>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppIngredients, string>>)(e => e.Code)).IsRequired(true).HasMaxLength(50);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppIngredients, Decimal>>)(e => e.Cost)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.AppIngredients, DateTime>>)(e => e.CreatedAt)).HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppIngredients, string>>)(e => e.Description)).IsRequired(true).HasMaxLength(100);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.AppIngredients, DateTime?>>)(e => e.UpdatedAt)).HasDefaultValueSql<DateTime?>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppIngredients, string>>)(e => e.UserCreate)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppIngredients, string>>)(e => e.UserUpdate)).HasMaxLength(50);
                entity.HasOne<AppService.Core.Entities.MtrTipoMoneda>((Expression<Func<AppService.Core.Entities.AppIngredients, AppService.Core.Entities.MtrTipoMoneda>>)(d => d.PrymaryMtrMoneda)).WithMany((Expression<Func<AppService.Core.Entities.MtrTipoMoneda, IEnumerable<AppService.Core.Entities.AppIngredients>>>)(p => p.AppIngredientsPrymaryMtrMoneda)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppIngredients, object>>)(d => (object)d.PrymaryMtrMonedaId)).HasConstraintName<AppService.Core.Entities.MtrTipoMoneda, AppService.Core.Entities.AppIngredients>("FK_AppIngredients_MtrTipoMoneda");
                entity.HasOne<AppService.Core.Entities.MtrTipoMoneda>((Expression<Func<AppService.Core.Entities.AppIngredients, AppService.Core.Entities.MtrTipoMoneda>>)(d => d.SecundaryMtrMoneda)).WithMany((Expression<Func<AppService.Core.Entities.MtrTipoMoneda, IEnumerable<AppService.Core.Entities.AppIngredients>>>)(p => p.AppIngredientsSecundaryMtrMoneda)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppIngredients, object>>)(d => (object)d.SecundaryMtrMonedaId)).HasConstraintName<AppService.Core.Entities.MtrTipoMoneda, AppService.Core.Entities.AppIngredients>("FK_AppIngredients_MtrTipoMoneda1");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppProductVariableSearchText>((Action<EntityTypeBuilder<AppService.Core.Entities.AppProductVariableSearchText>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppProductVariableSearchText, object>>)(e => e.SearchText)).HasName<AppService.Core.Entities.AppProductVariableSearchText>("IX_AppProductVariableSearchText_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppProductVariableSearchText, object>>)(e => new
                {
                    AppVariableId = e.AppVariableId,
                    SearchText = e.SearchText
                })).HasName<AppService.Core.Entities.AppProductVariableSearchText>("IX_AppProductVariableSearchText");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppProductVariableSearchText, string>>)(e => e.SearchText)).HasMaxLength(50);
                entity.HasOne<AppService.Core.Entities.AppProducts>((Expression<Func<AppService.Core.Entities.AppProductVariableSearchText, AppService.Core.Entities.AppProducts>>)(d => d.AppProduct)).WithMany((Expression<Func<AppService.Core.Entities.AppProducts, IEnumerable<AppService.Core.Entities.AppProductVariableSearchText>>>)(p => p.AppProductVariableSearchText)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppProductVariableSearchText, object>>)(d => (object)d.AppProductId)).HasConstraintName<AppService.Core.Entities.AppProducts, AppService.Core.Entities.AppProductVariableSearchText>("FK_AppProductVariableSearchText_AppProducts");
                entity.HasOne<AppService.Core.Entities.AppVariables>((Expression<Func<AppService.Core.Entities.AppProductVariableSearchText, AppService.Core.Entities.AppVariables>>)(d => d.AppVariable)).WithMany((Expression<Func<AppService.Core.Entities.AppVariables, IEnumerable<AppService.Core.Entities.AppProductVariableSearchText>>>)(p => p.AppProductVariableSearchText)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppProductVariableSearchText, object>>)(d => (object)d.AppVariableId)).HasConstraintName<AppService.Core.Entities.AppVariables, AppService.Core.Entities.AppProductVariableSearchText>("FK_AppProductVariableSearchText_AppVariables");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppProducts>((Action<EntityTypeBuilder<AppService.Core.Entities.AppProducts>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppProducts, object>>)(e => e.Code)).HasName<AppService.Core.Entities.AppProducts>("IDX_c5c748798c834681a2e817335d").IsUnique(true);
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppProducts, object>>)(e => e.Description1)).HasName<AppService.Core.Entities.AppProducts>("IDX_1c12fa4c818762546d1ba59397").IsUnique(true);
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppProducts, object>>)(e => e.Description2)).HasName<AppService.Core.Entities.AppProducts>("IDX_b37f2a37140a932857d2337bdf");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppProducts, object>>)(e => e.VariablesSearchText)).HasName<AppService.Core.Entities.AppProducts>("IX_AppProducts");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppProducts, Decimal?>>)(e => e.CajasProgramadas)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppProducts, string>>)(e => e.Code)).IsRequired(true).HasMaxLength(20);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.AppProducts, DateTime>>)(e => e.CreatedAt)).HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppProducts, string>>)(e => e.Description1)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppProducts, string>>)(e => e.Description2)).IsRequired(true).HasMaxLength(100);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppProducts, Decimal?>>)(e => e.Disponible)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppProducts, Decimal?>>)(e => e.Existencia)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppProducts, string>>)(e => e.ExternalCode)).HasMaxLength(20).HasDefaultValueSql<string>("('')");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.AppProducts, bool?>>)(e => e.RequiereDatosEntrada)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppProducts, Decimal>>)(e => e.UnitPrice)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.AppProducts, DateTime?>>)(e => e.UpdatedAt)).HasDefaultValueSql<DateTime?>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppProducts, string>>)(e => e.UrlImage)).IsRequired(true).HasMaxLength(400);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppProducts, string>>)(e => e.UserCreate)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppProducts, string>>)(e => e.UserUpdate)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppProducts, string>>)(e => e.VariablesSearchText)).IsRequired(true).HasMaxLength(400).HasDefaultValueSql<string>("('')");
                entity.HasOne<AppService.Core.Entities.AppSubCategory>((Expression<Func<AppService.Core.Entities.AppProducts, AppService.Core.Entities.AppSubCategory>>)(d => d.AppSubCategory)).WithMany((Expression<Func<AppService.Core.Entities.AppSubCategory, IEnumerable<AppService.Core.Entities.AppProducts>>>)(p => p.AppProducts)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppProducts, object>>)(d => (object)d.AppSubCategoryId)).HasConstraintName<AppService.Core.Entities.AppSubCategory, AppService.Core.Entities.AppProducts>("FK_AppProducts_AppSubCategory");
                entity.HasOne<AppService.Core.Entities.AppUnits>((Expression<Func<AppService.Core.Entities.AppProducts, AppService.Core.Entities.AppUnits>>)(d => d.AppUnits)).WithMany((Expression<Func<AppService.Core.Entities.AppUnits, IEnumerable<AppService.Core.Entities.AppProducts>>>)(p => p.AppProductsAppUnits)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppProducts, object>>)(d => (object)d.AppUnitsId)).HasConstraintName<AppService.Core.Entities.AppUnits, AppService.Core.Entities.AppProducts>("FK_AppProducts_AppUnits");
                entity.HasOne<AppService.Core.Entities.AppUnits>((Expression<Func<AppService.Core.Entities.AppProducts, AppService.Core.Entities.AppUnits>>)(d => d.ProductionUnit)).WithMany((Expression<Func<AppService.Core.Entities.AppUnits, IEnumerable<AppService.Core.Entities.AppProducts>>>)(p => p.AppProductsProductionUnit)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppProducts, object>>)(d => (object)d.ProductionUnitId)).HasConstraintName<AppService.Core.Entities.AppUnits, AppService.Core.Entities.AppProducts>("FK_AppProducts_AppUnits1");
                entity.HasOne<AppService.Core.Entities.MtrTipoMoneda>((Expression<Func<AppService.Core.Entities.AppProducts, AppService.Core.Entities.MtrTipoMoneda>>)(d => d.PrymaryMtrMoneda)).WithMany((Expression<Func<AppService.Core.Entities.MtrTipoMoneda, IEnumerable<AppService.Core.Entities.AppProducts>>>)(p => p.AppProductsPrymaryMtrMoneda)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppProducts, object>>)(d => (object)d.PrymaryMtrMonedaId)).HasConstraintName<AppService.Core.Entities.MtrTipoMoneda, AppService.Core.Entities.AppProducts>("FK_AppProducts_MtrTipoMoneda");
                entity.HasOne<AppService.Core.Entities.MtrTipoMoneda>((Expression<Func<AppService.Core.Entities.AppProducts, AppService.Core.Entities.MtrTipoMoneda>>)(d => d.SecundaryMtrMoneda)).WithMany((Expression<Func<AppService.Core.Entities.MtrTipoMoneda, IEnumerable<AppService.Core.Entities.AppProducts>>>)(p => p.AppProductsSecundaryMtrMoneda)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppProducts, object>>)(d => (object)d.SecundaryMtrMonedaId)).HasConstraintName<AppService.Core.Entities.MtrTipoMoneda, AppService.Core.Entities.AppProducts>("FK_AppProducts_MtrTipoMoneda1");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppRecipes>((Action<EntityTypeBuilder<AppService.Core.Entities.AppRecipes>>)(entity =>
            {
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.AppRecipes, bool?>>)(e => e.AfectaCosto)).HasDefaultValueSql<bool?>("((1))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppRecipes, string>>)(e => e.Code)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppRecipes, string>>)(e => e.Description)).HasMaxLength(100);
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.AppRecipes, bool?>>)(e => e.IncludeInSearch)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppRecipes, Decimal?>>)(e => e.Quantity)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.AppRecipes, int?>>)(e => e.Secuencia)).HasDefaultValueSql<int?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppRecipes, Decimal?>>)(e => e.TotalCost)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.HasOne<AppService.Core.Entities.AppIngredients>((Expression<Func<AppService.Core.Entities.AppRecipes, AppService.Core.Entities.AppIngredients>>)(d => d.AppIngredients)).WithMany((Expression<Func<AppService.Core.Entities.AppIngredients, IEnumerable<AppService.Core.Entities.AppRecipes>>>)(p => p.AppRecipes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppRecipes, object>>)(d => (object)d.AppIngredientsId)).HasConstraintName<AppService.Core.Entities.AppIngredients, AppService.Core.Entities.AppRecipes>("FK_AppRecipes_AppIngredients");
                entity.HasOne<AppService.Core.Entities.AppVariables>((Expression<Func<AppService.Core.Entities.AppRecipes, AppService.Core.Entities.AppVariables>>)(d => d.AppVariable)).WithMany((Expression<Func<AppService.Core.Entities.AppVariables, IEnumerable<AppService.Core.Entities.AppRecipes>>>)(p => p.AppRecipes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppRecipes, object>>)(d => (object)d.AppVariableId)).HasConstraintName<AppService.Core.Entities.AppVariables, AppService.Core.Entities.AppRecipes>("FK_AppRecipes_AppVariables");
                entity.HasOne<AppService.Core.Entities.AppProducts>((Expression<Func<AppService.Core.Entities.AppRecipes, AppService.Core.Entities.AppProducts>>)(d => d.Appproducts)).WithMany((Expression<Func<AppService.Core.Entities.AppProducts, IEnumerable<AppService.Core.Entities.AppRecipes>>>)(p => p.AppRecipes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppRecipes, object>>)(d => (object)d.AppproductsId)).HasConstraintName<AppService.Core.Entities.AppProducts, AppService.Core.Entities.AppRecipes>("FK_AppRecipes_AppProducts");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppRecipesByAppDetailQuotes>((Action<EntityTypeBuilder<AppService.Core.Entities.AppRecipesByAppDetailQuotes>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, object>>)(e => (object)e.AppproductsId)).HasName<AppService.Core.Entities.AppRecipesByAppDetailQuotes>("IX_AppRecipesByAppDetailQuotes");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, object>>)(e => (object)e.Id)).HasName<AppService.Core.Entities.AppRecipesByAppDetailQuotes>("IX_AppRecipesByAppDetailQuotes_2");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, object>>)(e => new
                {
                    AppproductsId = e.AppproductsId,
                    AppVariableId = e.AppVariableId
                })).HasName<AppService.Core.Entities.AppRecipesByAppDetailQuotes>("IX_AppRecipesByAppDetailQuotes_1");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, bool?>>)(e => e.AfectaCosto)).HasDefaultValueSql<bool?>("((1))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, string>>)(e => e.Code)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, string>>)(e => e.Description)).HasMaxLength(100);
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, bool?>>)(e => e.IncludeInSearch)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, Decimal?>>)(e => e.OrderCalculate)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, Decimal?>>)(e => e.Quantity)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, int?>>)(e => e.Secuencia)).HasDefaultValueSql<int?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, Decimal?>>)(e => e.TotalCost)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, bool?>>)(e => e.TruncarEntero)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, string>>)(e => e.VariablesSearchText)).HasMaxLength(4000).HasDefaultValueSql<string>("('')");
                entity.HasOne<AppService.Core.Entities.AppIngredients>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, AppService.Core.Entities.AppIngredients>>)(d => d.AppIngredients)).WithMany((Expression<Func<AppService.Core.Entities.AppIngredients, IEnumerable<AppService.Core.Entities.AppRecipesByAppDetailQuotes>>>)(p => p.AppRecipesByAppDetailQuotes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, object>>)(d => (object)d.AppIngredientsId)).HasConstraintName<AppService.Core.Entities.AppIngredients, AppService.Core.Entities.AppRecipesByAppDetailQuotes>("FK_AppRecipesByAppDetailQuotes_AppIngredients");
                entity.HasOne<AppService.Core.Entities.AppVariables>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, AppService.Core.Entities.AppVariables>>)(d => d.AppVariable)).WithMany((Expression<Func<AppService.Core.Entities.AppVariables, IEnumerable<AppService.Core.Entities.AppRecipesByAppDetailQuotes>>>)(p => p.AppRecipesByAppDetailQuotes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, object>>)(d => (object)d.AppVariableId)).HasConstraintName<AppService.Core.Entities.AppVariables, AppService.Core.Entities.AppRecipesByAppDetailQuotes>("FK_AppRecipesByAppDetailQuotes_AppVariables");
                entity.HasOne<AppService.Core.Entities.AppProducts>((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, AppService.Core.Entities.AppProducts>>)(d => d.Appproducts)).WithMany((Expression<Func<AppService.Core.Entities.AppProducts, IEnumerable<AppService.Core.Entities.AppRecipesByAppDetailQuotes>>>)(p => p.AppRecipesByAppDetailQuotes)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppRecipesByAppDetailQuotes, object>>)(d => (object)d.AppproductsId)).HasConstraintName<AppService.Core.Entities.AppProducts, AppService.Core.Entities.AppRecipesByAppDetailQuotes>("FK_AppRecipesByAppDetailQuotes_AppProducts");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppPrice>((Action<EntityTypeBuilder<AppService.Core.Entities.AppPrice>>)(entity =>
            {
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppPrice, Decimal>>)(e => e.Desde)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppPrice, Decimal>>)(e => e.Hasta)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.AppPrice, Decimal>>)(e => e.Precio)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.HasOne<AppService.Core.Entities.AppProducts>((Expression<Func<AppService.Core.Entities.AppPrice, AppService.Core.Entities.AppProducts>>)(d => d.Appproducts)).WithMany((Expression<Func<AppService.Core.Entities.AppProducts, IEnumerable<AppService.Core.Entities.AppPrice>>>)(p => p.AppPrices)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppPrice, object>>)(d => (object)d.AppproductsId));
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppProductConversion>((Action<EntityTypeBuilder<AppService.Core.Entities.AppProductConversion>>)(entity =>
            {
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppProductConversion, Decimal?>>)(e => e.XNumerador)).HasColumnName<Decimal?>("X_Numerador").HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppProductConversion, Decimal?>>)(e => e.YDenominador)).HasColumnName<Decimal?>("Y_Denominador").HasColumnType<Decimal?>("numeric(18, 4)");
                entity.HasOne<AppService.Core.Entities.AppProducts>((Expression<Func<AppService.Core.Entities.AppProductConversion, AppService.Core.Entities.AppProducts>>)(d => d.AppProducts)).WithMany((Expression<Func<AppService.Core.Entities.AppProducts, IEnumerable<AppService.Core.Entities.AppProductConversion>>>)(p => p.AppProductConversion)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppProductConversion, object>>)(d => (object)d.AppProductsId)).HasConstraintName<AppService.Core.Entities.AppProducts, AppService.Core.Entities.AppProductConversion>("FK_AppProductConversion_AppProducts");
                entity.HasOne<AppService.Core.Entities.AppUnits>((Expression<Func<AppService.Core.Entities.AppProductConversion, AppService.Core.Entities.AppUnits>>)(d => d.AppUnitsIdAlternativaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.AppUnits, IEnumerable<AppService.Core.Entities.AppProductConversion>>>)(p => p.AppProductConversionAppUnitsIdAlternativaNavigation)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppProductConversion, object>>)(d => (object)d.AppUnitsIdAlternativa)).HasConstraintName<AppService.Core.Entities.AppUnits, AppService.Core.Entities.AppProductConversion>("FK_AppProductConversion_AppUnits");
                entity.HasOne<AppService.Core.Entities.AppUnits>((Expression<Func<AppService.Core.Entities.AppProductConversion, AppService.Core.Entities.AppUnits>>)(d => d.AppUnitsIdBaseNavigation)).WithMany((Expression<Func<AppService.Core.Entities.AppUnits, IEnumerable<AppService.Core.Entities.AppProductConversion>>>)(p => p.AppProductConversionAppUnitsIdBaseNavigation)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppProductConversion, object>>)(d => (object)d.AppUnitsIdBase)).HasConstraintName<AppService.Core.Entities.AppUnits, AppService.Core.Entities.AppProductConversion>("FK_AppProductConversion_AppUnits1");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppStatusQuote>((Action<EntityTypeBuilder<AppService.Core.Entities.AppStatusQuote>>)(entity =>
            {
                entity.Property<int>((Expression<Func<AppService.Core.Entities.AppStatusQuote, int>>)(e => e.Id)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppStatusQuote, string>>)(e => e.Abreviado)).HasMaxLength(3).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppStatusQuote, Decimal?>>)(e => e.CondicionRazonId)).HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppStatusQuote, string>>)(e => e.Descripcion)).HasMaxLength(100).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppStatusQuote, string>>)(e => e.FlagActiva)).HasColumnName<string>("Flag_Activa").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppStatusQuote, string>>)(e => e.FlagCaducaInactiva)).HasColumnName<string>("Flag_CaducaInactiva").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppStatusQuote, string>>)(e => e.FlagCaducada)).HasColumnName<string>("Flag_Caducada").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppStatusQuote, string>>)(e => e.FlagEnEspera)).HasColumnName<string>("Flag_EnEspera").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppStatusQuote, string>>)(e => e.FlagGanada)).HasColumnName<string>("Flag_Ganada").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppStatusQuote, string>>)(e => e.FlagModificar)).HasColumnName<string>("Flag_Modificar").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppStatusQuote, string>>)(e => e.FlagPerdida)).HasColumnName<string>("Flag_Perdida").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppStatusQuote, string>>)(e => e.FlagPostergada)).HasColumnName<string>("Flag_Postergada").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppStatusQuote, string>>)(e => e.PrimeraEstacion)).HasMaxLength(1);
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppSubCategory>((Action<EntityTypeBuilder<AppService.Core.Entities.AppSubCategory>>)(entity =>
            {
                entity.Property<int>((Expression<Func<AppService.Core.Entities.AppSubCategory, int>>)(e => e.Id)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppSubCategory, string>>)(e => e.Description)).IsRequired(true).HasMaxLength(50);
                entity.HasOne<AppService.Core.Entities.AppCategory>((Expression<Func<AppService.Core.Entities.AppSubCategory, AppService.Core.Entities.AppCategory>>)(d => d.AppCategory)).WithMany((Expression<Func<AppService.Core.Entities.AppCategory, IEnumerable<AppService.Core.Entities.AppSubCategory>>>)(p => p.AppSubCategory)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppSubCategory, object>>)(d => (object)d.AppCategoryId)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.AppCategory, AppService.Core.Entities.AppSubCategory>("FK_AppSubCategory_AppCategory");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppTemplateConversionUnit>((Action<EntityTypeBuilder<AppService.Core.Entities.AppTemplateConversionUnit>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, string>>)(e => e.Code)).HasMaxLength(100).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, string>>)(e => e.Description)).HasMaxLength(100).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, string>>)(e => e.Formula)).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, string>>)(e => e.FormulaValue)).HasDefaultValueSql<string>("('')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, Decimal?>>)(e => e.Max)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, Decimal?>>)(e => e.Min)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, int?>>)(e => e.OrderCalculate)).HasDefaultValueSql<int?>("((0))");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, bool?>>)(e => e.SumValue)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, Decimal?>>)(e => e.Value)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.HasOne<AppService.Core.Entities.AppUnits>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, AppService.Core.Entities.AppUnits>>)(d => d.AppUnitIdSinceNavigation)).WithMany((Expression<Func<AppService.Core.Entities.AppUnits, IEnumerable<AppService.Core.Entities.AppTemplateConversionUnit>>>)(p => p.AppTemplateConversionUnitAppUnitIdSinceNavigation)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, object>>)(d => (object)d.AppUnitIdSince)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.AppUnits, AppService.Core.Entities.AppTemplateConversionUnit>("FK_AppTemplateConversionUnit_AppUnits");
                entity.HasOne<AppService.Core.Entities.AppUnits>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, AppService.Core.Entities.AppUnits>>)(d => d.AppUnitIdUntilNavigation)).WithMany((Expression<Func<AppService.Core.Entities.AppUnits, IEnumerable<AppService.Core.Entities.AppTemplateConversionUnit>>>)(p => p.AppTemplateConversionUnitAppUnitIdUntilNavigation)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, object>>)(d => (object)d.AppUnitIdUntil)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.AppUnits, AppService.Core.Entities.AppTemplateConversionUnit>("FK_AppTemplateConversionUnit_AppUnits1");
                entity.HasOne<AppService.Core.Entities.AppVariables>((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, AppService.Core.Entities.AppVariables>>)(d => d.AppVariable)).WithMany((Expression<Func<AppService.Core.Entities.AppVariables, IEnumerable<AppService.Core.Entities.AppTemplateConversionUnit>>>)(p => p.AppTemplateConversionUnit)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppTemplateConversionUnit, object>>)(d => (object)d.AppVariableId)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.AppVariables, AppService.Core.Entities.AppTemplateConversionUnit>("FK_AppTemplateConversionUnit_AppVariables");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppUnits>((Action<EntityTypeBuilder<AppService.Core.Entities.AppUnits>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppUnits, object>>)(e => e.Code)).HasName<AppService.Core.Entities.AppUnits>("IX_AppUnits");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppUnits, object>>)(e => e.Description1)).HasName<AppService.Core.Entities.AppUnits>("IX_AppUnits_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppUnits, object>>)(e => e.Description2)).HasName<AppService.Core.Entities.AppUnits>("IX_AppUnits_2");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppUnits, object>>)(e => e.Description3)).HasName<AppService.Core.Entities.AppUnits>("IX_AppUnits_3");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppUnits, object>>)(e => e.Description4)).HasName<AppService.Core.Entities.AppUnits>("IX_AppUnits_4");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppUnits, string>>)(e => e.Code)).IsRequired(true).HasMaxLength(3);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.AppUnits, DateTime?>>)(e => e.CreatedAt)).HasDefaultValueSql<DateTime?>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppUnits, string>>)(e => e.Description1)).IsRequired(true).HasMaxLength(3);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppUnits, string>>)(e => e.Description2)).IsRequired(true).HasMaxLength(6);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppUnits, string>>)(e => e.Description3)).IsRequired(true).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppUnits, string>>)(e => e.Description4)).IsRequired(true).HasMaxLength(30);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.AppUnits, DateTime?>>)(e => e.UpdatedAt)).HasDefaultValueSql<DateTime?>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppUnits, string>>)(e => e.UserCreate)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppUnits, string>>)(e => e.UserUpdate)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppUnitsofMeasureforIngredients>((Action<EntityTypeBuilder<AppService.Core.Entities.AppUnitsofMeasureforIngredients>>)(entity =>
            {
                entity.Property<int>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforIngredients, int>>)(e => e.Id)).ValueGeneratedNever();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforIngredients, Decimal?>>)(e => e.Denominator)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforIngredients, Decimal?>>)(e => e.Numerator)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforIngredients, string>>)(e => e.UserCreate)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforIngredients, string>>)(e => e.UserUpdate)).HasMaxLength(50);
                entity.HasOne<AppService.Core.Entities.AppIngredients>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforIngredients, AppService.Core.Entities.AppIngredients>>)(d => d.AppIngredients)).WithMany((Expression<Func<AppService.Core.Entities.AppIngredients, IEnumerable<AppService.Core.Entities.AppUnitsofMeasureforIngredients>>>)(p => p.AppUnitsofMeasureforIngredients)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforIngredients, object>>)(d => (object)d.AppIngredientsId)).HasConstraintName<AppService.Core.Entities.AppIngredients, AppService.Core.Entities.AppUnitsofMeasureforIngredients>("FK_AppUnitsofMeasureforIngredients_AppIngredients");
                entity.HasOne<AppService.Core.Entities.AppUnits>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforIngredients, AppService.Core.Entities.AppUnits>>)(d => d.AppUnits)).WithMany((Expression<Func<AppService.Core.Entities.AppUnits, IEnumerable<AppService.Core.Entities.AppUnitsofMeasureforIngredients>>>)(p => p.AppUnitsofMeasureforIngredients)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforIngredients, object>>)(d => (object)d.AppUnitsId)).HasConstraintName<AppService.Core.Entities.AppUnits, AppService.Core.Entities.AppUnitsofMeasureforIngredients>("FK_AppUnitsofMeasureforIngredients_AppUnits");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppUnitsofMeasureforMaterials>((Action<EntityTypeBuilder<AppService.Core.Entities.AppUnitsofMeasureforMaterials>>)(entity =>
            {
                entity.Property<int>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforMaterials, int>>)(e => e.Id)).ValueGeneratedNever();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforMaterials, Decimal?>>)(e => e.Denominator)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforMaterials, Decimal?>>)(e => e.Numerator)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforMaterials, string>>)(e => e.UserCreate)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforMaterials, string>>)(e => e.UserUpdate)).HasMaxLength(50);
                entity.HasOne<AppService.Core.Entities.AppProducts>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforMaterials, AppService.Core.Entities.AppProducts>>)(d => d.AppProducts)).WithMany((Expression<Func<AppService.Core.Entities.AppProducts, IEnumerable<AppService.Core.Entities.AppUnitsofMeasureforMaterials>>>)(p => p.AppUnitsofMeasureforMaterials)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforMaterials, object>>)(d => (object)d.AppProductsId)).HasConstraintName<AppService.Core.Entities.AppProducts, AppService.Core.Entities.AppUnitsofMeasureforMaterials>("FK_AppUnitsofMeasureforMaterials_AppProducts");
                entity.HasOne<AppService.Core.Entities.AppUnits>((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforMaterials, AppService.Core.Entities.AppUnits>>)(d => d.AppUnits)).WithMany((Expression<Func<AppService.Core.Entities.AppUnits, IEnumerable<AppService.Core.Entities.AppUnitsofMeasureforMaterials>>>)(p => p.AppUnitsofMeasureforMaterials)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppUnitsofMeasureforMaterials, object>>)(d => (object)d.AppUnitsId)).HasConstraintName<AppService.Core.Entities.AppUnits, AppService.Core.Entities.AppUnitsofMeasureforMaterials>("FK_AppUnitsofMeasureforMaterials_AppUnits");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppVariableSearch>((Action<EntityTypeBuilder<AppService.Core.Entities.AppVariableSearch>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppVariableSearch, string>>)(e => e.SearchText)).HasMaxLength(50);
                entity.HasOne<AppService.Core.Entities.AppSubCategory>((Expression<Func<AppService.Core.Entities.AppVariableSearch, AppService.Core.Entities.AppSubCategory>>)(d => d.AppSubCategory)).WithMany((Expression<Func<AppService.Core.Entities.AppSubCategory, IEnumerable<AppService.Core.Entities.AppVariableSearch>>>)(p => p.AppVariableSearch)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppVariableSearch, object>>)(d => (object)d.AppSubCategoryId)).HasConstraintName<AppService.Core.Entities.AppSubCategory, AppService.Core.Entities.AppVariableSearch>("FK_AppVariableSearch_AppSubCategory");
                entity.HasOne<AppService.Core.Entities.AppVariables>((Expression<Func<AppService.Core.Entities.AppVariableSearch, AppService.Core.Entities.AppVariables>>)(d => d.AppVariable)).WithMany((Expression<Func<AppService.Core.Entities.AppVariables, IEnumerable<AppService.Core.Entities.AppVariableSearch>>>)(p => p.AppVariableSearch)).HasForeignKey((Expression<Func<AppService.Core.Entities.AppVariableSearch, object>>)(d => (object)d.AppVariableId)).HasConstraintName<AppService.Core.Entities.AppVariables, AppService.Core.Entities.AppVariableSearch>("FK_AppVariableSearch_AppVariables");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AppVariables>((Action<EntityTypeBuilder<AppService.Core.Entities.AppVariables>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AppVariables, object>>)(e => e.Code)).HasName<AppService.Core.Entities.AppVariables>("IDX_fa6816ce90cf44a526144256df");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppVariables, string>>)(e => e.Code)).IsRequired(true).HasMaxLength(100);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.AppVariables, DateTime>>)(e => e.CreatedAt)).HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppVariables, string>>)(e => e.Description)).IsRequired(true).HasMaxLength(450);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.AppVariables, DateTime?>>)(e => e.UpdatedAt)).HasDefaultValueSql<DateTime?>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppVariables, string>>)(e => e.UserCreate)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AppVariables, string>>)(e => e.UserUpdate)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.AspNetRoles>((Action<EntityTypeBuilder<AppService.Core.Entities.AspNetRoles>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AspNetRoles, object>>)(e => e.Name)).HasName<AppService.Core.Entities.AspNetRoles>("RoleNameIndex").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AspNetRoles, string>>)(e => e.Id)).HasMaxLength(128);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AspNetRoles, string>>)(e => e.Name)).IsRequired(true).HasMaxLength(256);
            }));
            modelBuilder.Entity<AppService.Core.Entities.AspNetUserClaims>((Action<EntityTypeBuilder<AppService.Core.Entities.AspNetUserClaims>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AspNetUserClaims, object>>)(e => e.UserId)).HasName<AppService.Core.Entities.AspNetUserClaims>("IX_UserId");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AspNetUserClaims, string>>)(e => e.UserId)).IsRequired(true).HasMaxLength(128);
                entity.HasOne<AppService.Core.Entities.AspNetUsers>((Expression<Func<AppService.Core.Entities.AspNetUserClaims, AppService.Core.Entities.AspNetUsers>>)(d => d.User)).WithMany((Expression<Func<AppService.Core.Entities.AspNetUsers, IEnumerable<AppService.Core.Entities.AspNetUserClaims>>>)(p => p.AspNetUserClaims)).HasForeignKey((Expression<Func<AppService.Core.Entities.AspNetUserClaims, object>>)(d => d.UserId)).HasConstraintName<AppService.Core.Entities.AspNetUsers, AppService.Core.Entities.AspNetUserClaims>("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AspNetUserLogins>((Action<EntityTypeBuilder<AppService.Core.Entities.AspNetUserLogins>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.AspNetUserLogins, object>>)(e => new
                {
                    LoginProvider = e.LoginProvider,
                    ProviderKey = e.ProviderKey,
                    UserId = e.UserId
                })).HasName("PK_dbo.AspNetUserLogins");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AspNetUserLogins, object>>)(e => e.UserId)).HasName<AppService.Core.Entities.AspNetUserLogins>("IX_UserId");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AspNetUserLogins, string>>)(e => e.LoginProvider)).HasMaxLength(128);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AspNetUserLogins, string>>)(e => e.ProviderKey)).HasMaxLength(128);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AspNetUserLogins, string>>)(e => e.UserId)).HasMaxLength(128);
                entity.HasOne<AppService.Core.Entities.AspNetUsers>((Expression<Func<AppService.Core.Entities.AspNetUserLogins, AppService.Core.Entities.AspNetUsers>>)(d => d.User)).WithMany((Expression<Func<AppService.Core.Entities.AspNetUsers, IEnumerable<AppService.Core.Entities.AspNetUserLogins>>>)(p => p.AspNetUserLogins)).HasForeignKey((Expression<Func<AppService.Core.Entities.AspNetUserLogins, object>>)(d => d.UserId)).HasConstraintName<AppService.Core.Entities.AspNetUsers, AppService.Core.Entities.AspNetUserLogins>("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AspNetUserRoles>((Action<EntityTypeBuilder<AppService.Core.Entities.AspNetUserRoles>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.AspNetUserRoles, object>>)(e => new
                {
                    UserId = e.UserId,
                    RoleId = e.RoleId
                })).HasName("PK_dbo.AspNetUserRoles");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AspNetUserRoles, object>>)(e => e.RoleId)).HasName<AppService.Core.Entities.AspNetUserRoles>("IX_RoleId");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AspNetUserRoles, object>>)(e => e.UserId)).HasName<AppService.Core.Entities.AspNetUserRoles>("IX_UserId");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AspNetUserRoles, string>>)(e => e.UserId)).HasMaxLength(128);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AspNetUserRoles, string>>)(e => e.RoleId)).HasMaxLength(128);
                entity.HasOne<AppService.Core.Entities.AspNetRoles>((Expression<Func<AppService.Core.Entities.AspNetUserRoles, AppService.Core.Entities.AspNetRoles>>)(d => d.Role)).WithMany((Expression<Func<AppService.Core.Entities.AspNetRoles, IEnumerable<AppService.Core.Entities.AspNetUserRoles>>>)(p => p.AspNetUserRoles)).HasForeignKey((Expression<Func<AppService.Core.Entities.AspNetUserRoles, object>>)(d => d.RoleId)).HasConstraintName<AppService.Core.Entities.AspNetRoles, AppService.Core.Entities.AspNetUserRoles>("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");
                entity.HasOne<AppService.Core.Entities.AspNetUsers>((Expression<Func<AppService.Core.Entities.AspNetUserRoles, AppService.Core.Entities.AspNetUsers>>)(d => d.User)).WithMany((Expression<Func<AppService.Core.Entities.AspNetUsers, IEnumerable<AppService.Core.Entities.AspNetUserRoles>>>)(p => p.AspNetUserRoles)).HasForeignKey((Expression<Func<AppService.Core.Entities.AspNetUserRoles, object>>)(d => d.UserId)).HasConstraintName<AppService.Core.Entities.AspNetUsers, AppService.Core.Entities.AspNetUserRoles>("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            }));
            modelBuilder.Entity<AppService.Core.Entities.AspNetUsers>((Action<EntityTypeBuilder<AppService.Core.Entities.AspNetUsers>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AspNetUsers, object>>)(e => e.UserName)).HasName<AppService.Core.Entities.AspNetUsers>("UserNameIndex").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AspNetUsers, string>>)(e => e.Id)).HasMaxLength(128);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AspNetUsers, string>>)(e => e.Email)).HasMaxLength(256);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.AspNetUsers, DateTime?>>)(e => e.LockoutEndDateUtc)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AspNetUsers, string>>)(e => e.UserName)).IsRequired(true).HasMaxLength(256);
            }));
            modelBuilder.Entity<AppService.Core.Entities.Audit>((Action<EntityTypeBuilder<AppService.Core.Entities.Audit>>)(entity =>
            {
                entity.HasNoKey();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Audit, string>>)(e => e.FieldName)).HasMaxLength(128).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Audit, string>>)(e => e.NewValue)).HasMaxLength(1000).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Audit, string>>)(e => e.OldValue)).HasMaxLength(1000).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Audit, string>>)(e => e.Pk)).HasColumnName<string>("PK").HasMaxLength(1000).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Audit, string>>)(e => e.TableName)).HasMaxLength(128).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Audit, string>>)(e => e.Type)).HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Audit, DateTime?>>)(e => e.UpdateDate)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Audit, string>>)(e => e.UserName)).HasMaxLength(128).IsUnicode(false);
            }));
            modelBuilder.Entity<AppService.Core.Entities.AutoAudit>((Action<EntityTypeBuilder<AppService.Core.Entities.AutoAudit>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.AutoAudit, object>>)(e => (object)e.AuditId));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.AutoAudit, object>>)(e => new
                {
                    TableName = e.TableName,
                    AuditDate = e.AuditDate
                })).HasName<AppService.Core.Entities.AutoAudit>("idx_AutoAudit_TableName_AuditDate");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.AutoAudit, long>>)(e => e.AuditId)).HasColumnName<long>("AuditID");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.AutoAudit, DateTime?>>)(e => e.AuditDate)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AutoAudit, string>>)(e => e.AuditUserName)).HasMaxLength(128).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AutoAudit, string>>)(e => e.NewContent)).HasColumnType<string>("xml");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AutoAudit, string>>)(e => e.OldContent)).HasColumnType<string>("xml");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.AutoAudit, string>>)(e => e.TableName)).HasMaxLength(128).IsUnicode(false);
            }));
            modelBuilder.Entity<AppService.Core.Entities.Cary028>((Action<EntityTypeBuilder<AppService.Core.Entities.Cary028>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.Cary028, object>>)(e => (object)e.NotaCredito)).HasName("CARY028_INDEX01");
                entity.ToTable<AppService.Core.Entities.Cary028>("CARY028");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Cary028, int>>)(e => e.NotaCredito)).HasColumnName<int>("NOTA_CREDITO").ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.AfectaFactura)).IsRequired(true).HasColumnName<string>("AFECTA_FACTURA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.AfectaNota)).IsRequired(true).HasColumnName<string>("AFECTA_NOTA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary028, Decimal?>>)(e => e.Batch)).HasColumnName<Decimal?>("BATCH").HasColumnType<Decimal?>("decimal(14, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary028, Decimal?>>)(e => e.CantResumen)).HasColumnName<Decimal?>("CANT_RESUMEN").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.CantRevive)).HasColumnName<Decimal>("CANT_REVIVE").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Cary028, int>>)(e => e.Cliente)).HasColumnName<int>("CLIENTE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.ColetillaInd1)).HasColumnName<string>("COLETILLA_IND1").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.ColetillaInd2)).HasColumnName<string>("COLETILLA_IND2").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.ColetillaInd3)).HasColumnName<string>("COLETILLA_IND3").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.ColetillaInd4)).HasColumnName<string>("COLETILLA_IND4").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Contrapartida)).IsRequired(true).HasColumnName<string>("CONTRAPARTIDA").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.CuentaContable)).HasColumnName<Decimal>("CUENTA_CONTABLE").HasColumnType<Decimal>("decimal(12, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.DescResumen1)).HasColumnName<string>("DESC_RESUMEN1").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.DescResumen2)).HasColumnName<string>("DESC_RESUMEN2").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Direccion1)).IsRequired(true).HasColumnName<string>("DIRECCION1").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Direccion2)).IsRequired(true).HasColumnName<string>("DIRECCION2").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Direccion3)).HasColumnName<string>("DIRECCION3").HasMaxLength(80).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.EstadoEntregar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.EstadoFacturar)).HasMaxLength(2);
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Cary028, int>>)(e => e.Factura)).HasColumnName<int>("FACTURA");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Cary028, DateTime>>)(e => e.Fecha)).HasColumnName<DateTime>("FECHA").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cary028, DateTime?>>)(e => e.FechaFactura)).HasColumnName<DateTime?>("FECHA_FACTURA").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.FlagAfecVende)).IsRequired(true).HasColumnName<string>("FLAG_AFEC_VENDE").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.FlagComision)).IsRequired(true).HasColumnName<string>("FLAG_COMISION").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.FlagImpreso)).IsRequired(true).HasColumnName<string>("FLAG_IMPRESO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary028, Decimal?>>)(e => e.IdDirEntregar)).HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary028, Decimal?>>)(e => e.IdDirFacturar)).HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.ImpPorConsumo)).HasColumnName<Decimal>("IMP_POR_CONSUMO").HasColumnType<Decimal>("decimal(14, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.ImpSobVentas)).HasColumnName<Decimal>("IMP_SOB_VENTAS").HasColumnType<Decimal>("decimal(14, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.Impuesto)).HasColumnName<Decimal>("IMPUESTO").HasColumnType<Decimal>("decimal(14, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.ImpuestoDol)).HasColumnName<Decimal>("IMPUESTO_DOL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Cary028, int>>)(e => e.Iq)).HasColumnName<int>("IQ");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Cary028, int>>)(e => e.Ir)).HasColumnName<int>("IR");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Cary028, long>>)(e => e.JobId)).HasColumnName<long>("JOB_ID");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Cary028, short>>)(e => e.Motivo)).HasColumnName<short>("MOTIVO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.MunicipioEntregar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.MunicipioFacturar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.NombreCliente)).IsRequired(true).HasColumnName<string>("NOMBRE_CLIENTE").HasMaxLength(60).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Cary028, long>>)(e => e.NroControl)).HasColumnName<long>("NRO_CONTROL");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Nula)).IsRequired(true).HasColumnName<string>("NULA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.ObsCobranzas1)).HasColumnName<string>("OBS_COBRANZAS1").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.ObsCobranzas2)).HasColumnName<string>("OBS_COBRANZAS2").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.ObsCobranzas3)).HasColumnName<string>("OBS_COBRANZAS3").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.ObsCobranzas4)).HasColumnName<string>("OBS_COBRANZAS4").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Observacion1)).IsRequired(true).HasColumnName<string>("OBSERVACION1").HasMaxLength(40).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Observacion2)).IsRequired(true).HasColumnName<string>("OBSERVACION2").HasMaxLength(40).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Observacion3)).IsRequired(true).HasColumnName<string>("OBSERVACION3").HasMaxLength(40).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Cary028, long>>)(e => e.Orden)).HasColumnName<long>("ORDEN");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.PorcConcesion)).HasColumnName<Decimal>("PORC_CONCESION").HasColumnType<Decimal>("decimal(8, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Responsable)).IsRequired(true).HasColumnName<string>("RESPONSABLE").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.ReviveJob)).IsRequired(true).HasColumnName<string>("REVIVE_JOB").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Rif)).IsRequired(true).HasColumnName<string>("RIF").HasMaxLength(14).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Rif2)).IsRequired(true).HasColumnName<string>("RIF2").HasMaxLength(14).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary028, Decimal?>>)(e => e.RimpPorConsum)).HasColumnName<Decimal?>("RIMP_POR_CONSUM").HasColumnType<Decimal?>("decimal(14, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary028, Decimal?>>)(e => e.RimpSobVentas)).HasColumnName<Decimal?>("RIMP_SOB_VENTAS").HasColumnType<Decimal?>("decimal(14, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary028, Decimal?>>)(e => e.Rimpuesto)).HasColumnName<Decimal?>("RIMPUESTO").HasColumnType<Decimal?>("decimal(14, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary028, Decimal?>>)(e => e.Rvalor)).HasColumnName<Decimal?>("RVALOR").HasColumnType<Decimal?>("decimal(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary028, Decimal?>>)(e => e.RvalorLista)).HasColumnName<Decimal?>("RVALOR_LISTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Supervisor)).IsRequired(true).HasColumnName<string>("SUPERVISOR").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.TasaImpuesto)).HasColumnName<Decimal>("TASA_IMPUESTO").HasColumnType<Decimal>("decimal(6, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.TipoCambio)).HasColumnName<Decimal>("TIPO_CAMBIO").HasColumnType<Decimal>("decimal(10, 4)");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Cary028, short>>)(e => e.TipoDoc)).HasColumnName<short>("TIPO_DOC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.TipoProducto)).IsRequired(true).HasColumnName<string>("TIPO_PRODUCTO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.UndResumen)).HasColumnName<string>("UND_RESUMEN").HasMaxLength(10).IsUnicode(false);
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Cary028, short>>)(e => e.UnidadFacturar)).HasColumnName<short>("UNIDAD_FACTURAR");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Usuario)).HasColumnName<string>("USUARIO").HasMaxLength(20).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.Valor)).HasColumnName<Decimal>("VALOR").HasColumnType<Decimal>("decimal(18, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.Valor1)).HasColumnName<Decimal>("VALOR_$").HasColumnType<Decimal>("decimal(10, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.ValorLista)).HasColumnName<Decimal>("VALOR_LISTA").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.ValorListad)).HasColumnName<Decimal>("VALOR_LISTAD").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary028, Decimal>>)(e => e.ValorVentad)).HasColumnName<Decimal>("VALOR_VENTAD").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary028, Decimal?>>)(e => e.Valorfactura)).HasColumnName<Decimal?>("VALORFACTURA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary028, string>>)(e => e.Vendedor)).IsRequired(true).HasColumnName<string>("VENDEDOR").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.Cary029>((Action<EntityTypeBuilder<AppService.Core.Entities.Cary029>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.Cary029, object>>)(e => new
                {
                    NumeroNota = e.NumeroNota,
                    Recnum = e.Recnum
                })).HasName("CARY029_INDEX01");
                entity.ToTable<AppService.Core.Entities.Cary029>("CARY029");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Cary029, int>>)(e => e.NumeroNota)).HasColumnName<int>("NUMERO_NOTA");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.Almacen)).HasColumnName<string>("ALMACEN").HasMaxLength(12).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Batch)).HasColumnName<Decimal?>("BATCH").HasColumnType<Decimal?>("decimal(14, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.BsMcFinan)).HasColumnName<Decimal?>("BS_MC_FINAN").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.BsMcFinansc)).HasColumnName<Decimal?>("BS_MC_FINANSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.BsMcPapel)).HasColumnName<Decimal?>("BS_MC_PAPEL").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.BsMcPapelsc)).HasColumnName<Decimal?>("BS_MC_PAPELSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.Cantidad)).HasColumnName<Decimal>("CANTIDAD").HasColumnType<Decimal>("decimal(12, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.CodProducto)).IsRequired(true).HasColumnName<string>("COD_PRODUCTO").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.Comision)).HasColumnName<Decimal>("COMISION").HasColumnType<Decimal>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Copy)).HasColumnName<Decimal?>("COPY").HasColumnType<Decimal?>("decimal(6, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Costo)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.CtaConc)).IsRequired(true).HasColumnName<string>("CTA_CONC").HasMaxLength(20).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.CtaLista)).IsRequired(true).HasColumnName<string>("CTA_LISTA").HasMaxLength(20).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.Descripcion)).IsRequired(true).HasColumnName<string>("DESCRIPCION").HasMaxLength(30).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.Descripcion2)).HasColumnName<string>("DESCRIPCION2").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.Estadisticas)).IsRequired(true).HasColumnName<string>("ESTADISTICAS").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.Exento)).HasColumnName<string>("EXENTO").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.Familia)).IsRequired(true).HasColumnName<string>("FAMILIA").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.FamiliaProducc)).IsRequired(true).HasColumnName<string>("FAMILIA_PRODUCC").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Cary029, DateTime>>)(e => e.FechaNota)).HasColumnName<DateTime>("FECHA_NOTA").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cary029, DateTime?>>)(e => e.FechaOrden)).HasColumnName<DateTime?>("FECHA_ORDEN").HasColumnType<DateTime?>("datetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.FormasUnidad)).HasColumnName<Decimal?>("FORMAS_UNIDAD").HasColumnType<Decimal?>("decimal(12, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.IdSolicitudCosto)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.IdSolicitudCostoCpj)).HasColumnName<Decimal?>("IdSolicitudCosto_CPJ").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Idsolicitud)).HasColumnName<Decimal?>("idsolicitud").HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.ImpPorConsumo)).HasColumnName<Decimal>("IMP_POR_CONSUMO").HasColumnType<Decimal>("decimal(12, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.ImpSobVentas)).HasColumnName<Decimal>("IMP_SOB_VENTAS").HasColumnType<Decimal>("decimal(12, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.ImpuestoDol)).HasColumnName<Decimal>("IMPUESTO_DOL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Iva)).HasColumnName<Decimal?>("IVA").HasColumnType<Decimal?>("decimal(8, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Ivarefact)).HasColumnName<Decimal?>("IVAREFACT").HasColumnType<Decimal?>("decimal(6, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.JobId)).HasColumnName<string>("JOB_ID").HasMaxLength(14).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.Linea1)).IsRequired(true).HasColumnName<string>("LINEA1").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Cary029, short>>)(e => e.LineaIncoming)).HasColumnName<short>("LINEA_INCOMING");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.LineaProduccio)).IsRequired(true).HasColumnName<string>("LINEA_PRODUCCIO").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.ListaUniDol)).HasColumnName<Decimal>("LISTA_UNI_DOL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.MetodoPrecio1)).IsRequired(true).HasColumnName<string>("METODO_PRECIO1").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Millares)).HasColumnName<Decimal?>("MILLARES").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.Orden)).HasColumnName<string>("ORDEN").HasMaxLength(14).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.Partes)).IsRequired(true).HasColumnName<string>("PARTES").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Pieslineales)).HasColumnName<Decimal?>("PIESLINEALES").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.PorcMcFinan)).HasColumnName<Decimal?>("PORC_MC_FINAN").HasColumnType<Decimal?>("decimal(8, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.PorcMcFinansc)).HasColumnName<Decimal?>("PORC_MC_FINANSC").HasColumnType<Decimal?>("decimal(8, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.PorcMcPapel)).HasColumnName<Decimal?>("PORC_MC_PAPEL").HasColumnType<Decimal?>("decimal(8, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.PorcMcPapelsc)).HasColumnName<Decimal?>("PORC_MC_PAPELSC").HasColumnType<Decimal?>("decimal(8, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.PrecioVenta)).HasColumnName<Decimal>("PRECIO_VENTA").HasColumnType<Decimal>("decimal(20, 6)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Preciounidad)).HasColumnName<Decimal?>("PRECIOUNIDAD").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.RecalcularMargen)).HasMaxLength(1);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.RimpPorConsum)).HasColumnName<Decimal?>("RIMP_POR_CONSUM").HasColumnType<Decimal?>("decimal(12, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.RimpSobVentas)).HasColumnName<Decimal?>("RIMP_SOB_VENTAS").HasColumnType<Decimal?>("decimal(12, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Riva)).HasColumnName<Decimal?>("RIVA").HasColumnType<Decimal?>("decimal(10, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.RprecioVenta)).HasColumnName<Decimal?>("RPRECIO_VENTA").HasColumnType<Decimal?>("decimal(20, 6)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Rpreciounidad)).HasColumnName<Decimal?>("RPRECIOUNIDAD").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.RvalorLista)).HasColumnName<Decimal?>("RVALOR_LISTA").HasColumnType<Decimal?>("decimal(18, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.RvalorVenta)).HasColumnName<Decimal?>("RVALOR_VENTA").HasColumnType<Decimal?>("decimal(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.TipoCambio)).HasColumnName<Decimal?>("TIPO_CAMBIO").HasColumnType<Decimal?>("decimal(8, 2)");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Cary029, short>>)(e => e.TipoDoc)).HasColumnName<short>("TIPO_DOC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.TipoPapel)).IsRequired(true).HasColumnName<string>("TIPO_PAPEL").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.TipoProducto)).IsRequired(true).HasColumnName<string>("TIPO_PRODUCTO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.TotalparcialFa)).HasColumnName<string>("TOTALPARCIAL_FA").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.UnidadFacturar)).HasColumnName<string>("UNIDAD_FACTURAR").HasMaxLength(10).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.Unidadesfact)).HasColumnName<Decimal?>("UNIDADESFACT").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cary029, string>>)(e => e.Usuario)).HasColumnName<string>("USUARIO").HasMaxLength(20).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.Valor)).HasColumnName<Decimal>("VALOR_$").HasColumnType<Decimal>("decimal(10, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.ValorLista)).HasColumnName<Decimal>("VALOR_LISTA").HasColumnType<Decimal>("decimal(18, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.ValorListad)).HasColumnName<Decimal>("VALOR_LISTAD").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.ValorVenta)).HasColumnName<Decimal>("VALOR_VENTA").HasColumnType<Decimal>("decimal(18, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cary029, Decimal?>>)(e => e.ValorVentaCpj)).HasColumnName<Decimal?>("VALOR_VENTA_CPJ").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.ValorVentad)).HasColumnName<Decimal>("VALOR_VENTAD").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cary029, Decimal>>)(e => e.VentaUniDol)).HasColumnName<Decimal>("VENTA_UNI_DOL").HasColumnType<Decimal>("decimal(16, 2)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatAuditoriaCalculo>((Action<EntityTypeBuilder<AppService.Core.Entities.CatAuditoriaCalculo>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatAuditoriaCalculo, string>>)(e => e.Codigo)).HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatAuditoriaCalculo, string>>)(e => e.DescripcionFormula)).HasMaxLength(4000);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatAuditoriaCalculo, string>>)(e => e.EntradaCalculo)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatAuditoriaCalculo, string>>)(e => e.Formula)).IsRequired(true).HasMaxLength(4000);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatAuditoriaCalculo, Decimal>>)(e => e.IdCalculo)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatAuditoriaCalculo, string>>)(e => e.IdVariables)).HasMaxLength(20);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatAuditoriaCalculo, Decimal>>)(e => e.Item)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatAuditoriaCalculo, string>>)(e => e.NombreVariable)).IsRequired(true).HasMaxLength(100);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatAuditoriaCalculo, Decimal>>)(e => e.OrdenCalculo)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatAuditoriaCalculo, string>>)(e => e.Query)).IsRequired(true).HasMaxLength(4000);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatAuditoriaCalculo, string>>)(e => e.Valor)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatCalibrePapel>((Action<EntityTypeBuilder<AppService.Core.Entities.CatCalibrePapel>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CatCalibrePapel, object>>)(e => e.Papel));
                entity.ToTable<AppService.Core.Entities.CatCalibrePapel>("Cat_CalibrePapel");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatCalibrePapel, string>>)(e => e.Papel)).HasMaxLength(100);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CatCalibrePapel, Decimal?>>)(e => e.Calibre)).HasColumnType<Decimal?>("decimal(18, 8)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatCalibrePapelRollos>((Action<EntityTypeBuilder<AppService.Core.Entities.CatCalibrePapelRollos>>)(entity =>
            {
                entity.ToTable<AppService.Core.Entities.CatCalibrePapelRollos>("Cat_CalibrePapelRollos");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.CatCalibrePapelRollos, long>>)(e => e.CatCalibrePapelRollosId)).HasColumnName<long>("Cat_CalibrePapelRollosId");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CatCalibrePapelRollos, Decimal?>>)(e => e.Calibre)).HasColumnType<Decimal?>("numeric(18, 8)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatCalibrePapelRollos, string>>)(e => e.Papel)).IsRequired(true).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatCodigoMayorPartesBasica>((Action<EntityTypeBuilder<AppService.Core.Entities.CatCodigoMayorPartesBasica>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.CatCodigoMayorPartesBasica>("Cat_CodigoMayor_Partes_Basica");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatCodigoMayorPartesBasica, string>>)(e => e.BasicaBusqueda)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatCodigoMayorPartesBasica, string>>)(e => e.CodigoMayor)).HasColumnName<string>("Codigo_Mayor").HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CatCodigoMayorPartesBasica, Decimal?>>)(e => e.Frecuencia)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatCodigoMayorPartesBasica, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatLista>((Action<EntityTypeBuilder<AppService.Core.Entities.CatLista>>)(entity =>
            {
                entity.ToTable<AppService.Core.Entities.CatLista>("Cat_Lista");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.CatLista, int>>)(e => e.CatListaId)).HasColumnName<int>("Cat_ListaId");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatLista, Decimal>>)(e => e.Cantidad)).HasColumnType<Decimal>("numeric(18, 3)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatLista, string>>)(e => e.CodigoProduct)).IsRequired(true).HasColumnName<string>("CODIGO_PRODUCT").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatLista, string>>)(e => e.Descripcion)).HasMaxLength(400);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatLista, Decimal>>)(e => e.Duracion)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatLista, Decimal>>)(e => e.IdCalculo)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatLista, Decimal>>)(e => e.IncrementoCantidad)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatLista, Decimal>>)(e => e.PrecioMaximo)).HasColumnName<Decimal>("Precio_Maximo").HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatLista, Decimal>>)(e => e.PrecioMinimo)).HasColumnName<Decimal>("Precio_Minimo").HasColumnType<Decimal>("numeric(18, 2)");
                entity.HasOne<AppService.Core.Entities.CatMaterial>((Expression<Func<AppService.Core.Entities.CatLista, AppService.Core.Entities.CatMaterial>>)(d => d.CatMaterial)).WithMany((Expression<Func<AppService.Core.Entities.CatMaterial, IEnumerable<AppService.Core.Entities.CatLista>>>)(p => p.CatLista)).HasForeignKey((Expression<Func<AppService.Core.Entities.CatLista, object>>)(d => (object)d.CatMaterialId)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.CatMaterial, AppService.Core.Entities.CatLista>("FK_Cat_Lista_CatMaterial");
                entity.HasOne<AppService.Core.Entities.MtrProducto>((Expression<Func<AppService.Core.Entities.CatLista, AppService.Core.Entities.MtrProducto>>)(d => d.CodigoProductNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrProducto, IEnumerable<AppService.Core.Entities.CatLista>>>)(p => p.CatLista)).HasForeignKey((Expression<Func<AppService.Core.Entities.CatLista, object>>)(d => d.CodigoProduct)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrProducto, AppService.Core.Entities.CatLista>("FK_Cat_Lista_MtrProducto");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatMaterial>((Action<EntityTypeBuilder<AppService.Core.Entities.CatMaterial>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMaterial, object>>)(e => (object)e.CatMedidaBasicaId)).HasName<AppService.Core.Entities.CatMaterial>("IX_CatMedidaBasicaId");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMaterial, object>>)(e => e.Codigo)).HasName<AppService.Core.Entities.CatMaterial>("CatMaterial_Codigo_Index").IsUnique(true);
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMaterial, object>>)(e => new
                {
                    CatProductoMayorId = e.CatProductoMayorId,
                    CatProductoMayorPartesId = e.CatProductoMayorPartesId,
                    CatProductoMayorPartesTintasId = e.CatProductoMayorPartesTintasId,
                    CatProductoMayorPartesTintasBasicaId = e.CatProductoMayorPartesTintasBasicaId,
                    CatProductoMayorPartesTintasBasicaOpuestaId = e.CatProductoMayorPartesTintasBasicaOpuestaId,
                    CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbonId = e.CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbonId,
                    CatProductoMayorPartesTintasBasicaOpuestaPapelesId = e.CatProductoMayorPartesTintasBasicaOpuestaPapelesId
                })).HasName<AppService.Core.Entities.CatMaterial>("IX_CatMaterial");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMaterial, object>>)(e => new
                {
                    CodigoProduct = e.CodigoProduct,
                    Partes = e.Partes,
                    Tintas = e.Tintas,
                    BasicaBusqueda = e.BasicaBusqueda,
                    OpuestaBusqueda = e.OpuestaBusqueda,
                    PapelesBusqueda = e.PapelesBusqueda,
                    CarbonBusqueda = e.CarbonBusqueda
                })).HasName<AppService.Core.Entities.CatMaterial>("IX_CatMaterial_1").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMaterial, string>>)(e => e.BasicaBusqueda)).HasMaxLength(10);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CatMaterial, Decimal?>>)(e => e.BasicaDecimal)).HasColumnType<Decimal?>("numeric(18, 8)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CatMaterial, Decimal?>>)(e => e.CalibrePapelRollos)).HasColumnType<Decimal?>("numeric(18, 8)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMaterial, string>>)(e => e.CarbonBusqueda)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMaterial, string>>)(e => e.Codigo)).HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMaterial, string>>)(e => e.CodigoProduct)).IsRequired(true).HasColumnName<string>("CODIGO_PRODUCT").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMaterial, string>>)(e => e.Combinacion)).HasMaxLength(400);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMaterial, string>>)(e => e.Descripcion)).HasMaxLength(400);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMaterial, string>>)(e => e.ManejaInv)).HasColumnName<string>("MANEJA_INV").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMaterial, string>>)(e => e.OpuestaBusqueda)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMaterial, string>>)(e => e.PapelesBusqueda)).HasMaxLength(200);
                entity.HasOne<AppService.Core.Entities.CatMedidaBasica1>((Expression<Func<AppService.Core.Entities.CatMaterial, AppService.Core.Entities.CatMedidaBasica1>>)(d => d.CatMedidaBasica)).WithMany((Expression<Func<AppService.Core.Entities.CatMedidaBasica1, IEnumerable<AppService.Core.Entities.CatMaterial>>>)(p => p.CatMaterial)).HasForeignKey((Expression<Func<AppService.Core.Entities.CatMaterial, object>>)(d => (object)d.CatMedidaBasicaId)).HasConstraintName<AppService.Core.Entities.CatMedidaBasica1, AppService.Core.Entities.CatMaterial>("FK_dbo.CatMaterial_dbo.CatMedidaBasica_CatMedidaBasicaId");
                entity.HasOne<AppService.Core.Entities.MtrProducto>((Expression<Func<AppService.Core.Entities.CatMaterial, AppService.Core.Entities.MtrProducto>>)(d => d.CodigoProductNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrProducto, IEnumerable<AppService.Core.Entities.CatMaterial>>>)(p => p.CatMaterial)).HasForeignKey((Expression<Func<AppService.Core.Entities.CatMaterial, object>>)(d => d.CodigoProduct)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrProducto, AppService.Core.Entities.CatMaterial>("FK_CatMaterial_MtrProducto");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatMaterialDetalle>((Action<EntityTypeBuilder<AppService.Core.Entities.CatMaterialDetalle>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMaterialDetalle, object>>)(e => (object)e.CatMaterialId)).HasName<AppService.Core.Entities.CatMaterialDetalle>("IX_CatMaterialId");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMaterialDetalle, object>>)(e => (object)e.CatMedidaOpuestaId)).HasName<AppService.Core.Entities.CatMaterialDetalle>("IX_CatMedidaOpuestaId");
                entity.HasOne<AppService.Core.Entities.CatMaterial>((Expression<Func<AppService.Core.Entities.CatMaterialDetalle, AppService.Core.Entities.CatMaterial>>)(d => d.CatMaterial)).WithMany((Expression<Func<AppService.Core.Entities.CatMaterial, IEnumerable<AppService.Core.Entities.CatMaterialDetalle>>>)(p => p.CatMaterialDetalle)).HasForeignKey((Expression<Func<AppService.Core.Entities.CatMaterialDetalle, object>>)(d => (object)d.CatMaterialId)).HasConstraintName<AppService.Core.Entities.CatMaterial, AppService.Core.Entities.CatMaterialDetalle>("FK_dbo.CatMaterialDetalle_dbo.CatMaterial_CatMaterialId");
                entity.HasOne<AppService.Core.Entities.CatMedidaOpuesta>((Expression<Func<AppService.Core.Entities.CatMaterialDetalle, AppService.Core.Entities.CatMedidaOpuesta>>)(d => d.CatMedidaOpuesta)).WithMany((Expression<Func<AppService.Core.Entities.CatMedidaOpuesta, IEnumerable<AppService.Core.Entities.CatMaterialDetalle>>>)(p => p.CatMaterialDetalle)).HasForeignKey((Expression<Func<AppService.Core.Entities.CatMaterialDetalle, object>>)(d => (object)d.CatMedidaOpuestaId)).HasConstraintName<AppService.Core.Entities.CatMedidaOpuesta, AppService.Core.Entities.CatMaterialDetalle>("FK_dbo.CatMaterialDetalle_dbo.CatMedidaOpuesta_CatMedidaOpuestaId");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatMaterialDetalleTmp>((Action<EntityTypeBuilder<AppService.Core.Entities.CatMaterialDetalleTmp>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMaterialDetalleTmp, object>>)(e => (object)e.CatMedidaOpuestaId)).HasName<AppService.Core.Entities.CatMaterialDetalleTmp>("IX_CatMedidaOpuestaId");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMaterialDetalleTmp, object>>)(e => e.CatPapelId)).HasName<AppService.Core.Entities.CatMaterialDetalleTmp>("IX_CatPapelId");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMaterialDetalleTmp, string>>)(e => e.CatPapelId)).IsRequired(true).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMaterialDetalleTmp, string>>)(e => e.UserName)).IsRequired(true).HasMaxLength(256);
                entity.HasOne<AppService.Core.Entities.CatMedidaOpuesta>((Expression<Func<AppService.Core.Entities.CatMaterialDetalleTmp, AppService.Core.Entities.CatMedidaOpuesta>>)(d => d.CatMedidaOpuesta)).WithMany((Expression<Func<AppService.Core.Entities.CatMedidaOpuesta, IEnumerable<AppService.Core.Entities.CatMaterialDetalleTmp>>>)(p => p.CatMaterialDetalleTmp)).HasForeignKey((Expression<Func<AppService.Core.Entities.CatMaterialDetalleTmp, object>>)(d => (object)d.CatMedidaOpuestaId)).HasConstraintName<AppService.Core.Entities.CatMedidaOpuesta, AppService.Core.Entities.CatMaterialDetalleTmp>("FK_dbo.CatMaterialDetalleTmp_dbo.CatMedidaOpuesta_CatMedidaOpuestaId");
                entity.HasOne<AppService.Core.Entities.CatPapel>((Expression<Func<AppService.Core.Entities.CatMaterialDetalleTmp, AppService.Core.Entities.CatPapel>>)(d => d.CatPapel)).WithMany((Expression<Func<AppService.Core.Entities.CatPapel, IEnumerable<AppService.Core.Entities.CatMaterialDetalleTmp>>>)(p => p.CatMaterialDetalleTmp)).HasForeignKey((Expression<Func<AppService.Core.Entities.CatMaterialDetalleTmp, object>>)(d => d.CatPapelId)).HasConstraintName<AppService.Core.Entities.CatPapel, AppService.Core.Entities.CatMaterialDetalleTmp>("FK_dbo.CatMaterialDetalleTmp_dbo.CatPapel_CatPapelId");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatMedidaBasica>((Action<EntityTypeBuilder<AppService.Core.Entities.CatMedidaBasica>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CatMedidaBasica, object>>)(e => e.Medida));
                entity.ToTable<AppService.Core.Entities.CatMedidaBasica>("Cat_MedidaBasica");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMedidaBasica, string>>)(e => e.Medida)).HasColumnName<string>("MEDIDA").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMedidaBasica, string>>)(e => e.MedidaIn)).HasColumnName<string>("MEDIDA_IN").HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMedidaBasica, string>>)(e => e.MedidaMm)).HasColumnName<string>("MEDIDA_MM").HasMaxLength(10);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatMedidaBasica1>((Action<EntityTypeBuilder<AppService.Core.Entities.CatMedidaBasica1>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CatMedidaBasica1, object>>)(e => (object)e.CatMedidaBasicaId)).HasName("PK_dbo.CatMedidaBasica");
                entity.ToTable<AppService.Core.Entities.CatMedidaBasica1>("CatMedidaBasica");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMedidaBasica1, object>>)(e => e.MedidaBusqueda)).HasName<AppService.Core.Entities.CatMedidaBasica1>("CatMedidaBasica_MedidaBusqueda_Index");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMedidaBasica1, object>>)(e => e.MedidaString)).HasName<AppService.Core.Entities.CatMedidaBasica1>("CatMedidaBasica_MedidaString_Index").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMedidaBasica1, string>>)(e => e.MedidaBusqueda)).IsRequired(true).HasMaxLength(8);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatMedidaBasica1, Decimal>>)(e => e.MedidaDecimal)).HasColumnType<Decimal>("numeric(18, 3)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMedidaBasica1, string>>)(e => e.MedidaString)).IsRequired(true).HasMaxLength(8);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatMedidaBasicaRollos>((Action<EntityTypeBuilder<AppService.Core.Entities.CatMedidaBasicaRollos>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.CatMedidaBasicaRollos>("Cat_MedidaBasicaRollos");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.CatMedidaBasicaRollos, long>>)(e => e.CatMedidaBasicaRollosId)).HasColumnName<long>("Cat_MedidaBasicaRollosId");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMedidaBasicaRollos, string>>)(e => e.Medida)).IsRequired(true).HasColumnName<string>("MEDIDA").HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CatMedidaBasicaRollos, Decimal?>>)(e => e.MedidaIn)).HasColumnName<Decimal?>("MEDIDA_IN").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CatMedidaBasicaRollos, Decimal?>>)(e => e.MedidaMm)).HasColumnName<Decimal?>("MEDIDA_MM").HasColumnType<Decimal?>("numeric(18, 2)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatMedidaOpuesta>((Action<EntityTypeBuilder<AppService.Core.Entities.CatMedidaOpuesta>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMedidaOpuesta, object>>)(e => e.MedidaBusqueda)).HasName<AppService.Core.Entities.CatMedidaOpuesta>("CatMedidaOpuesta_MedidaBusqueda_Index");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CatMedidaOpuesta, object>>)(e => e.MedidaString)).HasName<AppService.Core.Entities.CatMedidaOpuesta>("CatMedidaOpuesta_MedidaString_Index").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMedidaOpuesta, string>>)(e => e.MedidaBusqueda)).IsRequired(true).HasMaxLength(8);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatMedidaOpuesta, Decimal>>)(e => e.MedidaDecimal)).HasColumnType<Decimal>("numeric(18, 3)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatMedidaOpuesta, string>>)(e => e.MedidaString)).IsRequired(true).HasMaxLength(6);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatPapel>((Action<EntityTypeBuilder<AppService.Core.Entities.CatPapel>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatPapel, string>>)(e => e.CatPapelId)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatPapel, string>>)(e => e.Descripcion)).HasMaxLength(256);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatProductoMayor>((Action<EntityTypeBuilder<AppService.Core.Entities.CatProductoMayor>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayor, string>>)(e => e.CodigoProduct)).IsRequired(true).HasColumnName<string>("CODIGO_PRODUCT").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayor, string>>)(e => e.Descripcion)).HasMaxLength(400);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayor, string>>)(e => e.Inactivo)).HasMaxLength(1).HasDefaultValueSql<string>("('')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatProductoMayorPartes>((Action<EntityTypeBuilder<AppService.Core.Entities.CatProductoMayorPartes>>)(entity => entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartes, string>>)(e => e.CodigoProduct)).IsRequired(true).HasColumnName<string>("CODIGO_PRODUCT").HasMaxLength(12)));
            modelBuilder.Entity<AppService.Core.Entities.CatProductoMayorPartesTintas>((Action<EntityTypeBuilder<AppService.Core.Entities.CatProductoMayorPartesTintas>>)(entity => entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintas, string>>)(e => e.CodigoProduct)).IsRequired(true).HasColumnName<string>("CODIGO_PRODUCT").HasMaxLength(12)));
            modelBuilder.Entity<AppService.Core.Entities.CatProductoMayorPartesTintasBasica>((Action<EntityTypeBuilder<AppService.Core.Entities.CatProductoMayorPartesTintasBasica>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasica, string>>)(e => e.BasicaBusqueda)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasica, string>>)(e => e.CodigoProduct)).IsRequired(true).HasColumnName<string>("CODIGO_PRODUCT").HasMaxLength(12);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuesta>((Action<EntityTypeBuilder<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuesta>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuesta, string>>)(e => e.BasicaBusqueda)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuesta, string>>)(e => e.CodigoProduct)).IsRequired(true).HasColumnName<string>("CODIGO_PRODUCT").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuesta, string>>)(e => e.OpuestaBusqueda)).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapeles>((Action<EntityTypeBuilder<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapeles>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapeles, string>>)(e => e.BasicaBusqueda)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapeles, string>>)(e => e.CodigoProduct)).IsRequired(true).HasColumnName<string>("CODIGO_PRODUCT").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapeles, string>>)(e => e.OpuestaBusqueda)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapeles, string>>)(e => e.PapelesBusqueda)).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon>((Action<EntityTypeBuilder<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon, string>>)(e => e.BasicaBusqueda)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon, string>>)(e => e.CarbonBusqueda)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon, string>>)(e => e.CodigoProduct)).IsRequired(true).HasColumnName<string>("CODIGO_PRODUCT").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon, string>>)(e => e.OpuestaBusqueda)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorPartesTintasBasicaOpuestaPapelesCarbon, string>>)(e => e.PapelesBusqueda)).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatProductoMayorUnidadesConversion>((Action<EntityTypeBuilder<AppService.Core.Entities.CatProductoMayorUnidadesConversion>>)(entity =>
            {
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CatProductoMayorUnidadesConversion, bool?>>)(e => e.Calculado)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorUnidadesConversion, string>>)(e => e.CodigoProduct)).IsRequired(true).HasColumnName<string>("CODIGO_PRODUCT").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorUnidadesConversion, string>>)(e => e.Msehi)).HasColumnName<string>("MSEHI").HasMaxLength(18);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorUnidadesConversion, string>>)(e => e.Msehl)).HasColumnName<string>("MSEHL").HasMaxLength(18);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatProductoMayorUnidadesConversion, Decimal>>)(e => e.Umren)).HasColumnName<Decimal>("UMREN").HasColumnType<Decimal>("decimal(5, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CatProductoMayorUnidadesConversion, Decimal>>)(e => e.Umrez)).HasColumnName<Decimal>("UMREZ").HasColumnType<Decimal>("decimal(5, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatProductoMayorUnidadesConversion, string>>)(e => e.UnidadsapVentainterna)).HasColumnName<string>("UNIDADSAP_VENTAINTERNA").HasMaxLength(3);
                entity.HasOne<AppService.Core.Entities.MtrProducto>((Expression<Func<AppService.Core.Entities.CatProductoMayorUnidadesConversion, AppService.Core.Entities.MtrProducto>>)(d => d.CodigoProductNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrProducto, IEnumerable<AppService.Core.Entities.CatProductoMayorUnidadesConversion>>>)(p => p.CatProductoMayorUnidadesConversion)).HasForeignKey((Expression<Func<AppService.Core.Entities.CatProductoMayorUnidadesConversion, object>>)(d => d.CodigoProduct)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrProducto, AppService.Core.Entities.CatProductoMayorUnidadesConversion>("FK_CatProductoMayorUnidadesConversion_MtrProducto");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatSubCategoria>((Action<EntityTypeBuilder<AppService.Core.Entities.CatSubCategoria>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CatSubCategoria, object>>)(e => (object)e.IdSubCategoria));
                entity.ToTable<AppService.Core.Entities.CatSubCategoria>("Cat_SubCategoria");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.CatSubCategoria, int>>)(e => e.IdSubCategoria)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatSubCategoria, string>>)(e => e.Descripcion)).IsRequired(true).HasMaxLength(50).IsUnicode(false);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CatSysfile>((Action<EntityTypeBuilder<AppService.Core.Entities.CatSysfile>>)(entity =>
            {
                entity.ToTable<AppService.Core.Entities.CatSysfile>("Cat_Sysfile");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.CatSysfile, int>>)(e => e.CatSysfileId)).HasColumnName<int>("Cat_SysfileId");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatSysfile, string>>)(e => e.FechaModificacionMateriales)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CatSysfile, string>>)(e => e.FechaPublicacion)).HasMaxLength(20);
            }));
            modelBuilder.Entity<AppService.Core.Entities.ChildMenu>((Action<EntityTypeBuilder<AppService.Core.Entities.ChildMenu>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ChildMenu, string>>)(e => e.Icon)).HasColumnName<string>("icon").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ChildMenu, string>>)(e => e.Title)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ChildMenu, string>>)(e => e.Url)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.Ciny056>((Action<EntityTypeBuilder<AppService.Core.Entities.Ciny056>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.Ciny056, object>>)(e => new
                {
                    Factura = e.Factura,
                    CentroFact = e.CentroFact,
                    TipoDoc = e.TipoDoc
                })).HasName("CINY056_INDEX01");
                entity.ToTable<AppService.Core.Entities.Ciny056>("CINY056");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ciny056, int>>)(e => e.Factura)).HasColumnName<int>("FACTURA");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Ciny056, short>>)(e => e.CentroFact)).HasColumnName<short>("CENTRO_FACT");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Ciny056, short>>)(e => e.TipoDoc)).HasColumnName<short>("TIPO_DOC").HasDefaultValueSql<short>("((2))");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Ciny056, short?>>)(e => e.AnoFactura)).HasColumnName<short?>("ANO_FACTURA").HasDefaultValueSql<short?>("((0))");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Ciny056, int?>>)(e => e.Anticipo)).HasColumnName<int?>("ANTICIPO").HasDefaultValueSql<int?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Anulada)).HasColumnName<string>("ANULADA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.Batch)).HasColumnName<Decimal?>("BATCH").HasColumnType<Decimal?>("decimal(14, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Ciny056, int?>>)(e => e.Cajas)).HasColumnName<int?>("CAJAS").HasDefaultValueSql<int?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.CantResumen)).HasColumnName<Decimal?>("CANT_RESUMEN").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Ciny056, int?>>)(e => e.Cliente)).HasColumnName<int?>("CLIENTE").HasDefaultValueSql<int?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.ClienteJde)).HasColumnName<string>("CLIENTE_JDE").HasMaxLength(25).IsUnicode(false);
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Ciny056, short?>>)(e => e.CodigoRepetici)).HasColumnName<short?>("CODIGO_REPETICI").HasDefaultValueSql<short?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.ColetillaInd1)).HasColumnName<string>("COLETILLA_IND1").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.ColetillaInd2)).HasColumnName<string>("COLETILLA_IND2").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.ColetillaInd3)).HasColumnName<string>("COLETILLA_IND3").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.ColetillaInd4)).HasColumnName<string>("COLETILLA_IND4").HasMaxLength(60).IsUnicode(false);
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Ciny056, short?>>)(e => e.CondPago)).HasColumnName<short?>("COND_PAGO").HasDefaultValueSql<short?>("((0))");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Ciny056, short?>>)(e => e.CondicionPago)).HasColumnName<short?>("CONDICION_PAGO").HasDefaultValueSql<short?>("((0))");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Ciny056, short?>>)(e => e.Copy)).HasColumnName<short?>("COPY").HasDefaultValueSql<short?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Cotizacion)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.CredConta)).HasColumnName<string>("CRED_CONTA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Dciudad)).HasColumnName<string>("DCIUDAD").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.DescResumen1)).HasColumnName<string>("DESC_RESUMEN1").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.DescResumen2)).HasColumnName<string>("DESC_RESUMEN2").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Destado)).HasColumnName<string>("DESTADO").HasMaxLength(20).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.DireccFiscal)).HasColumnName<string>("DIRECC_FISCAL").HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.DireccionEmb1)).HasColumnName<string>("DIRECCION_EMB1").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.DireccionEmb2)).HasColumnName<string>("DIRECCION_EMB2").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.DireccionEmb3)).HasColumnName<string>("DIRECCION_EMB3").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.DireccionFact1)).HasColumnName<string>("DIRECCION_FACT1").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.DireccionFact2)).HasColumnName<string>("DIRECCION_FACT2").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.DireccionFact3)).HasColumnName<string>("DIRECCION_FACT3").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.DocumentoSap)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Dolar)).HasColumnName<string>("DOLAR").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Estado)).HasColumnName<string>("ESTADO").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.EstadoEntregar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.EstadoFacturar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.FactAdelantada)).HasColumnName<string>("FACT_ADELANTADA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Ciny056, int?>>)(e => e.FactFinal)).HasColumnName<int?>("FACT_FINAL").HasDefaultValueSql<int?>("((0))");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Ciny056, int?>>)(e => e.FacturaRepetir)).HasColumnName<int?>("FACTURA_REPETIR").HasDefaultValueSql<int?>("((0))");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ciny056, DateTime?>>)(e => e.FechaAnulada)).HasColumnName<DateTime?>("FECHA_ANULADA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ciny056, DateTime?>>)(e => e.FechaDespacho)).HasColumnName<DateTime?>("FECHA_DESPACHO").HasColumnType<DateTime?>("datetime").HasDefaultValueSql<DateTime?>("('01/01/1753')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ciny056, DateTime?>>)(e => e.FechaFactura)).HasColumnName<DateTime?>("FECHA_FACTURA").HasColumnType<DateTime?>("datetime").HasDefaultValueSql<DateTime?>("('01/01/1753')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ciny056, DateTime?>>)(e => e.FechaRecibCli)).HasColumnName<DateTime?>("FECHA_RECIB_CLI").HasColumnType<DateTime?>("datetime").HasDefaultValueSql<DateTime?>("('01/01/1753')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Field98)).HasColumnName<string>("FIELD98").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Fiscal)).HasColumnName<string>("FISCAL").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.FlagComision)).HasColumnName<string>("FLAG_COMISION").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.FlagGeneroPdf)).HasMaxLength(1).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.FlagImpreso)).HasColumnName<string>("FLAG_IMPRESO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.Flete)).HasColumnName<Decimal?>("FLETE").HasColumnType<Decimal?>("decimal(12, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.IdDirEntregar)).HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.IdDirFacturar)).HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.IdDireccion)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Ciny056, short?>>)(e => e.Imp)).HasColumnName<short?>("IMP").HasDefaultValueSql<short?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.ImpStock)).HasColumnName<string>("IMP_STOCK").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.ImpuestoDol)).HasColumnName<Decimal?>("IMPUESTO_DOL").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.JobId)).HasColumnName<Decimal?>("JOB_ID").HasColumnType<Decimal?>("decimal(8, 0)");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Ciny056, short?>>)(e => e.LineaAnt)).HasColumnName<short?>("LINEA_ANT").HasDefaultValueSql<short?>("((0))");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Ciny056, short?>>)(e => e.MesFactura)).HasColumnName<short?>("MES_FACTURA").HasDefaultValueSql<short?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Miscelaneo)).HasColumnName<string>("MISCELANEO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.MultiplesEmb)).HasColumnName<string>("MULTIPLES_EMB").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Municipio)).HasColumnName<string>("MUNICIPIO").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.MunicipioEntregar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.MunicipioFacturar)).HasMaxLength(2);
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Ciny056, int?>>)(e => e.NcFacturar)).HasColumnName<int?>("NC_FACTURAR").HasDefaultValueSql<int?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.NitEmb)).HasColumnName<string>("NIT_EMB").HasMaxLength(20).IsUnicode(false).HasDefaultValueSql<string>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.NitFact)).HasColumnName<string>("NIT_FACT").HasMaxLength(20).IsUnicode(false).HasDefaultValueSql<string>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Nombre)).HasColumnName<string>("NOMBRE").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.NombreEmb)).HasColumnName<string>("NOMBRE_EMB").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.NombreFact)).HasColumnName<string>("NOMBRE_FACT").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Ciny056, long?>>)(e => e.NroControl)).HasColumnName<long?>("NRO_CONTROL").HasDefaultValueSql<long?>("((0))");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Ciny056, int?>>)(e => e.NroNc)).HasColumnName<int?>("NRO_NC").HasDefaultValueSql<int?>("((0))");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Ciny056, short?>>)(e => e.NuevaLineaAnt)).HasColumnName<short?>("NUEVA_LINEA_ANT").HasDefaultValueSql<short?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.ObsCobranzas1)).HasColumnName<string>("OBS_COBRANZAS1").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.ObsCobranzas2)).HasColumnName<string>("OBS_COBRANZAS2").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.ObsCobranzas3)).HasColumnName<string>("OBS_COBRANZAS3").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.ObsCobranzas4)).HasColumnName<string>("OBS_COBRANZAS4").HasMaxLength(60).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Observacion1)).HasColumnName<string>("OBSERVACION1").HasMaxLength(60).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Observacion2)).HasColumnName<string>("OBSERVACION2").HasMaxLength(79).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Observacion3)).HasColumnName<string>("OBSERVACION3").HasMaxLength(79).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Ciny056, long?>>)(e => e.Orden)).HasColumnName<long?>("ORDEN").HasDefaultValueSql<long?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.OrdenCompra)).HasColumnName<string>("ORDEN_COMPRA").HasMaxLength(16).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.OtroGasto1)).HasColumnName<Decimal?>("OTRO_GASTO_1").HasColumnType<Decimal?>("decimal(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.OtroGasto2)).HasColumnName<Decimal?>("OTRO_GASTO_2").HasColumnType<Decimal?>("decimal(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Ciny056, short?>>)(e => e.Pais)).HasColumnName<short?>("PAIS").HasDefaultValueSql<short?>("((1))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Pltyp)).HasColumnName<string>("PLTYP").HasMaxLength(2);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.RegistroTribut)).HasColumnName<string>("REGISTRO_TRIBUT").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.RifEmb)).HasColumnName<string>("RIF_EMB").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.RifFact)).HasColumnName<string>("RIF_FACT").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.RotroGasto1)).HasColumnName<Decimal?>("ROTRO_GASTO_1").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.RsdoAnticipo)).HasColumnName<Decimal?>("RSDO_ANTICIPO").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.RvalorLista)).HasColumnName<Decimal?>("RVALOR_LISTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.RvalorVenta)).HasColumnName<Decimal?>("RVALOR_VENTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.SdoAnticipo)).HasColumnName<Decimal?>("SDO_ANTICIPO").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.SdoAnticipoDo)).HasColumnName<Decimal?>("SDO_ANTICIPO_DO").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.Seguro)).HasColumnName<Decimal?>("SEGURO").HasColumnType<Decimal?>("decimal(12, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Supervisor)).HasColumnName<string>("SUPERVISOR").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.TasaAnticipo)).HasColumnName<Decimal?>("TASA_ANTICIPO").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.TasaImpuesto)).HasColumnName<Decimal?>("TASA_IMPUESTO").HasColumnType<Decimal?>("decimal(6, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.TipoCambio)).HasColumnName<Decimal?>("TIPO_CAMBIO").HasColumnType<Decimal?>("decimal(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.TotalParcial)).HasColumnName<string>("TOTAL_PARCIAL").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Transmision)).HasColumnName<string>("TRANSMISION").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.UndResumen)).HasColumnName<string>("UND_RESUMEN").HasMaxLength(10).IsUnicode(false);
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Ciny056, short?>>)(e => e.UnidadFacturar)).HasColumnName<short?>("UNIDAD_FACTURAR").HasDefaultValueSql<short?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Usuario)).HasColumnName<string>("USUARIO").HasMaxLength(20).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.ValorLista)).HasColumnName<Decimal?>("VALOR_LISTA").HasColumnType<Decimal?>("decimal(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.ValorListad)).HasColumnName<Decimal?>("VALOR_LISTAD").HasColumnType<Decimal?>("decimal(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.ValorVenta)).HasColumnName<Decimal?>("VALOR_VENTA").HasColumnType<Decimal?>("decimal(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny056, Decimal?>>)(e => e.ValorVentad)).HasColumnName<Decimal?>("VALOR_VENTAD").HasColumnType<Decimal?>("decimal(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.VendGestion)).HasColumnName<string>("VEND_GESTION").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny056, string>>)(e => e.Vendedor)).HasColumnName<string>("VENDEDOR").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.Ciny057>((Action<EntityTypeBuilder<AppService.Core.Entities.Ciny057>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.Ciny057, object>>)(e => new
                {
                    Factura = e.Factura,
                    CentroFact = e.CentroFact,
                    TipoDoc = e.TipoDoc,
                    Recnum = e.Recnum
                })).HasName("CINY057_INDEX01");
                entity.ToTable<AppService.Core.Entities.Ciny057>("CINY057");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ciny057, int>>)(e => e.Factura)).HasColumnName<int>("FACTURA");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Ciny057, short>>)(e => e.CentroFact)).HasColumnName<short>("CENTRO_FACT");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Ciny057, short>>)(e => e.TipoDoc)).HasColumnName<short>("TIPO_DOC").HasDefaultValueSql<short>("((2))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Almacen)).HasColumnName<string>("ALMACEN").HasMaxLength(12).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Articulo)).IsRequired(true).HasColumnName<string>("ARTICULO").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.Batch)).HasColumnName<Decimal?>("BATCH").HasColumnType<Decimal?>("decimal(14, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.BsMcFinan)).HasColumnName<Decimal?>("BS_MC_FINAN").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.BsMcFinansc)).HasColumnName<Decimal?>("BS_MC_FINANSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.BsMcPapel)).HasColumnName<Decimal?>("BS_MC_PAPEL").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.BsMcPapelsc)).HasColumnName<Decimal?>("BS_MC_PAPELSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.Bsmc)).HasColumnName<Decimal?>("BSMC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Ciny057, int?>>)(e => e.BultoDesp)).HasColumnName<int?>("BULTO_DESP").HasDefaultValueSql<int?>("((0))");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Ciny057, int?>>)(e => e.BultoTran)).HasColumnName<int?>("BULTO_TRAN").HasDefaultValueSql<int?>("((0))");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Ciny057, short>>)(e => e.Bultos)).HasColumnName<short>("BULTOS");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.CantEntregar)).HasColumnName<Decimal?>("CANT_ENTREGAR").HasColumnType<Decimal?>("decimal(12, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.Cantidad)).HasColumnName<Decimal>("CANTIDAD").HasColumnType<Decimal>("decimal(10, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.Copy)).HasColumnName<Decimal?>("COPY").HasColumnType<Decimal?>("decimal(4, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.Costo)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.CtaConc)).IsRequired(true).HasColumnName<string>("CTA_CONC").HasMaxLength(20).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.CtaLista)).IsRequired(true).HasColumnName<string>("CTA_LISTA").HasMaxLength(20).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Descripcion1)).IsRequired(true).HasColumnName<string>("DESCRIPCION1").HasMaxLength(60).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Descripcion2)).IsRequired(true).HasColumnName<string>("DESCRIPCION2").HasMaxLength(60).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.DireccionEmb)).HasColumnName<string>("DIRECCION_EMB").HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.DireccionFact)).HasColumnName<string>("DIRECCION_FACT").HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Estadisticas)).IsRequired(true).HasColumnName<string>("ESTADISTICAS").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Familia)).IsRequired(true).HasColumnName<string>("FAMILIA").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.FamiliaProducc)).IsRequired(true).HasColumnName<string>("FAMILIA_PRODUCC").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ciny057, DateTime?>>)(e => e.FecComproClte)).HasColumnName<DateTime?>("FEC_COMPRO_CLTE").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ciny057, DateTime?>>)(e => e.FecRecPlaneac)).HasColumnName<DateTime?>("FEC_REC_PLANEAC").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Ciny057, DateTime>>)(e => e.FechaFactura)).HasColumnName<DateTime>("FECHA_FACTURA").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ciny057, DateTime?>>)(e => e.FechaOrden)).HasColumnName<DateTime?>("FECHA_ORDEN").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ciny057, DateTime?>>)(e => e.FechaProg)).HasColumnName<DateTime?>("FECHA_PROG").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.FlagFaltante)).IsRequired(true).HasColumnName<string>("FLAG_FALTANTE").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.FlagImprenta)).IsRequired(true).HasColumnName<string>("FLAG_IMPRENTA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.FlagRetenido)).IsRequired(true).HasColumnName<string>("FLAG_RETENIDO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.FlagTipoJob)).IsRequired(true).HasColumnName<string>("FLAG_TIPO_JOB").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.FlagTipoOrden)).IsRequired(true).HasColumnName<string>("FLAG_TIPO_ORDEN").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ciny057, int>>)(e => e.FormasBajotiro)).HasColumnName<int>("FORMAS_BAJOTIRO");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.FormasUnidad)).HasColumnName<Decimal>("FORMAS_UNIDAD").HasColumnType<Decimal>("decimal(10, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.GeneraDespacho)).HasColumnName<string>("GENERA_DESPACHO").HasMaxLength(1).IsUnicode(false);
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Ciny057, long?>>)(e => e.IdPrelista)).HasDefaultValueSql<long?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.IdSolicitud)).HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.IdSolicitudCosto)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.IdSolicitudCostoCpj)).HasColumnName<Decimal?>("IdSolicitudCosto_CPJ").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.ImpStock)).HasColumnName<string>("IMP_STOCK").HasMaxLength(1).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.Impuesto1)).HasColumnName<Decimal>("IMPUESTO_1").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.Impuesto2)).HasColumnName<Decimal>("IMPUESTO_2").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.ImpuestoDol)).HasColumnName<Decimal>("IMPUESTO_DOL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.Iva)).HasColumnName<Decimal>("IVA").HasColumnType<Decimal>("decimal(6, 2)");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Ciny057, long>>)(e => e.JobId)).HasColumnName<long>("JOB_ID");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.KiloBulto)).HasColumnName<Decimal?>("KILO_BULTO").HasColumnType<Decimal?>("decimal(12, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Linea1)).IsRequired(true).HasColumnName<string>("LINEA1").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.LineaProduccio)).IsRequired(true).HasColumnName<string>("LINEA_PRODUCCIO").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Lipamepa)).IsRequired(true).HasColumnName<string>("LIPAMEPA").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.ListaUniDol)).HasColumnName<Decimal>("LISTA_UNI_DOL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Ciny057, int?>>)(e => e.MetodoCalculo)).HasDefaultValueSql<int?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.MetodoPrecio1)).IsRequired(true).HasColumnName<string>("METODO_PRECIO1").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Millares)).IsRequired(true).HasColumnName<string>("MILLARES").HasMaxLength(8).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ciny057, int>>)(e => e.NoEntrega)).HasColumnName<int>("NO_ENTREGA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.NombreEmb)).HasColumnName<string>("NOMBRE_EMB").HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.NombreFact)).HasColumnName<string>("NOMBRE_FACT").HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.NumCliDesde)).HasColumnName<string>("NUM_CLI_DESDE").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.NumCliDesdeE)).HasColumnName<string>("NUM_CLI_DESDE_E").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.NumCliHasta)).HasColumnName<string>("NUM_CLI_HASTA").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.NumCliHastaE)).HasColumnName<string>("NUM_CLI_HASTA_E").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.NumeroDesde)).IsRequired(true).HasColumnName<string>("NUMERO_DESDE").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.NumeroDesdeE)).HasColumnName<string>("NUMERO_DESDE_E").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.NumeroHasta)).IsRequired(true).HasColumnName<string>("NUMERO_HASTA").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.NumeroHastaE)).HasColumnName<string>("NUMERO_HASTA_E").HasMaxLength(10).IsUnicode(false);
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Ciny057, long>>)(e => e.Orden)).HasColumnName<long>("ORDEN");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.OrigenProducto)).IsRequired(true).HasColumnName<string>("ORIGEN_PRODUCTO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Pais)).IsRequired(true).HasColumnName<string>("PAIS").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Partes)).IsRequired(true).HasColumnName<string>("PARTES").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.Pieslineales)).HasColumnName<Decimal?>("PIESLINEALES").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.PorcMcFinan)).HasColumnName<Decimal?>("PORC_MC_FINAN").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.PorcMcFinansc)).HasColumnName<Decimal?>("PORC_MC_FINANSC").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.PorcMcPapel)).HasColumnName<Decimal?>("PORC_MC_PAPEL").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.PorcMcPapelsc)).HasColumnName<Decimal?>("PORC_MC_PAPELSC").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.PrecioLista)).HasColumnName<Decimal>("PRECIO_LISTA").HasColumnType<Decimal>("decimal(16, 6)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.PrecioVenta)).HasColumnName<Decimal>("PRECIO_VENTA").HasColumnType<Decimal>("decimal(16, 6)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.Preciounidad)).HasColumnName<Decimal?>("PRECIOUNIDAD").HasColumnType<Decimal?>("decimal(20, 6)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.PrefijoCli)).HasColumnName<string>("PREFIJO_CLI").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.PrefijoCliE)).HasColumnName<string>("PREFIJO_CLI_E").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.PrefijoDesde)).IsRequired(true).HasColumnName<string>("PREFIJO_DESDE").HasMaxLength(10).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.PrefijoDesdeE)).HasColumnName<string>("PREFIJO_DESDE_E").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.PrefijoHasta)).IsRequired(true).HasColumnName<string>("PREFIJO_HASTA").HasMaxLength(10).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.PrefijoHastaE)).HasColumnName<string>("PREFIJO_HASTA_E").HasMaxLength(10).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.RbsMcFinan)).HasColumnName<Decimal?>("RBS_MC_FINAN").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.RbsMcFinansc)).HasColumnName<Decimal?>("RBS_MC_FINANSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.RbsMcPapel)).HasColumnName<Decimal?>("RBS_MC_PAPEL").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.RbsMcPapelsc)).HasColumnName<Decimal?>("RBS_MC_PAPELSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.Rbsmc)).HasColumnName<Decimal?>("RBSMC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.RecalcularMargen)).HasMaxLength(1).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.RegistroTribut)).HasColumnName<string>("REGISTRO_TRIBUT").HasMaxLength(12).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.RemisionOfi)).HasColumnName<Decimal?>("REMISION_OFI").HasColumnType<Decimal?>("decimal(14, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.ReportadoSeniat)).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.RifEmb)).IsRequired(true).HasColumnName<string>("RIF_EMB").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.RifFact)).IsRequired(true).HasColumnName<string>("RIF_FACT").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.Rimpuesto1)).HasColumnName<Decimal?>("RIMPUESTO_1").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.RprecioLista)).HasColumnName<Decimal?>("RPRECIO_LISTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.RprecioVenta)).HasColumnName<Decimal?>("RPRECIO_VENTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.Rpreciounidad)).HasColumnName<Decimal?>("RPRECIOUNIDAD").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.RvalorLista)).HasColumnName<Decimal?>("RVALOR_LISTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.RvalorVenta)).HasColumnName<Decimal?>("RVALOR_VENTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.SufijoCli)).HasColumnName<string>("SUFIJO_CLI").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.SufijoCliE)).HasColumnName<string>("SUFIJO_CLI_E").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.SufijoDesde)).IsRequired(true).HasColumnName<string>("SUFIJO_DESDE").HasMaxLength(10).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.SufijoDesdeE)).HasColumnName<string>("SUFIJO_DESDE_E").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.SufijoHasta)).IsRequired(true).HasColumnName<string>("SUFIJO_HASTA").HasMaxLength(10).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.SufijoHastaE)).HasColumnName<string>("SUFIJO_HASTA_E").HasMaxLength(10).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.TipoCambio)).HasColumnName<Decimal?>("TIPO_CAMBIO").HasColumnType<Decimal?>("decimal(8, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.TipoPapel)).IsRequired(true).HasColumnName<string>("TIPO_PAPEL").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.TipoProducto)).IsRequired(true).HasColumnName<string>("TIPO_PRODUCTO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.TotalParcial)).IsRequired(true).HasColumnName<string>("TOTAL_PARCIAL").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.UnidadFacturar)).IsRequired(true).HasColumnName<string>("UNIDAD_FACTURAR").HasMaxLength(10).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.Unidadesent)).HasColumnName<Decimal?>("UNIDADESENT").HasColumnType<Decimal?>("decimal(16, 3)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.Unidadesfact)).HasColumnName<Decimal?>("UNIDADESFACT").HasColumnType<Decimal?>("decimal(16, 3)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ciny057, string>>)(e => e.Usuario)).HasColumnName<string>("USUARIO").HasMaxLength(20).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.ValorLista)).HasColumnName<Decimal>("VALOR_LISTA").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.ValorListad)).HasColumnName<Decimal>("VALOR_LISTAD").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.ValorVenta)).HasColumnName<Decimal>("VALOR_VENTA").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal?>>)(e => e.ValorVentaCpj)).HasColumnName<Decimal?>("VALOR_VENTA_CPJ").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.ValorVentad)).HasColumnName<Decimal>("VALOR_VENTAD").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ciny057, Decimal>>)(e => e.VentaUniDol)).HasColumnName<Decimal>("VENTA_UNI_DOL").HasColumnType<Decimal>("decimal(16, 2)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobAdjuntosCobranza>((Action<EntityTypeBuilder<AppService.Core.Entities.CobAdjuntosCobranza>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobAdjuntosCobranza, object>>)(e => (object)e.IdAdjunto));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobAdjuntosCobranza, object>>)(e => (object)e.Documento)).HasName<AppService.Core.Entities.CobAdjuntosCobranza>("IX_CobAdjuntosCobranza");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobAdjuntosCobranza, object>>)(e => new
                {
                    Documento = e.Documento,
                    IdTipoDocumento = e.IdTipoDocumento
                })).HasName<AppService.Core.Entities.CobAdjuntosCobranza>("IX_CobAdjuntosCobranza_1");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobAdjuntosCobranza, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAdjuntosCobranza, string>>)(e => e.IdUsuarioCreacion)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAdjuntosCobranza, string>>)(e => e.NombreArchivo)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAdjuntosCobranza, string>>)(e => e.Ruta)).HasMaxLength(150).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAdjuntosCobranza, string>>)(e => e.TextoPrueba)).HasMaxLength(50).HasDefaultValueSql<string>("('')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobAvisosCobro>((Action<EntityTypeBuilder<AppService.Core.Entities.CobAvisosCobro>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.CobAvisosCobro>("Cob_AvisosCobro");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobAvisosCobro, object>>)(e => e.Cliente)).HasName<AppService.Core.Entities.CobAvisosCobro>("IX_Cob_AvisosCobro");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobAvisosCobro, object>>)(e => (object)e.Fecha)).HasName<AppService.Core.Entities.CobAvisosCobro>("IX_Cob_AvisosCobro_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobAvisosCobro, object>>)(e => (object)e.Procesado)).HasName<AppService.Core.Entities.CobAvisosCobro>("IX_Cob_AvisosCobro_2");
                entity.Property<byte[]>((Expression<Func<AppService.Core.Entities.CobAvisosCobro, byte[]>>)(e => e.Archivo)).IsRequired(true);
                entity.Property<byte[]>((Expression<Func<AppService.Core.Entities.CobAvisosCobro, byte[]>>)(e => e.ArchivotTiff)).IsRequired(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAvisosCobro, string>>)(e => e.Cliente)).IsRequired(true).HasMaxLength(10);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobAvisosCobro, DateTime?>>)(e => e.Fecha)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAvisosCobro, string>>)(e => e.Html)).HasColumnName<string>("HTML");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobAvisosCobro, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAvisosCobro, string>>)(e => e.NombreArchivo)).IsRequired(true).HasMaxLength(100).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAvisosCobro, string>>)(e => e.Usuario)).IsRequired(true).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobAvisosCobroTemp>((Action<EntityTypeBuilder<AppService.Core.Entities.CobAvisosCobroTemp>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobAvisosCobroTemp, object>>)(e => e.Cliente));
                entity.ToTable<AppService.Core.Entities.CobAvisosCobroTemp>("Cob_AvisosCobro_Temp");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobAvisosCobroTemp, object>>)(e => e.Cliente)).HasName<AppService.Core.Entities.CobAvisosCobroTemp>("IX_Cob_AvisosCobro_Temp");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobAvisosCobroTemp, object>>)(e => e.Usuario)).HasName<AppService.Core.Entities.CobAvisosCobroTemp>("IX_Cob_AvisosCobro_Temp_1");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAvisosCobroTemp, string>>)(e => e.Cliente)).HasMaxLength(10);
                entity.Property<byte[]>((Expression<Func<AppService.Core.Entities.CobAvisosCobroTemp, byte[]>>)(e => e.Archivo)).IsRequired(true);
                entity.Property<byte[]>((Expression<Func<AppService.Core.Entities.CobAvisosCobroTemp, byte[]>>)(e => e.ArchivotTiff)).IsRequired(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAvisosCobroTemp, string>>)(e => e.Html)).HasColumnName<string>("HTML");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobAvisosCobroTemp, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAvisosCobroTemp, string>>)(e => e.NombreArchivo)).IsRequired(true).HasMaxLength(100).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobAvisosCobroTemp, string>>)(e => e.Usuario)).IsRequired(true).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobBanco>((Action<EntityTypeBuilder<AppService.Core.Entities.CobBanco>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobBanco, object>>)(e => (object)e.IdBanco));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobBanco, string>>)(e => e.NombreBanco)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobDatosCheque>((Action<EntityTypeBuilder<AppService.Core.Entities.CobDatosCheque>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobDatosCheque, object>>)(e => (object)e.Documento));
                entity.Property<long>((Expression<Func<AppService.Core.Entities.CobDatosCheque, long>>)(e => e.Documento)).ValueGeneratedNever();
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobDatosCheque, DateTime>>)(e => e.FechaCheque)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobDatosCheque, string>>)(e => e.IdBanco)).IsRequired(true).HasMaxLength(4);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobDatosCheque, string>>)(e => e.IdTipoTransaccion)).IsRequired(true).HasMaxLength(4);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobDatosCheque, Decimal>>)(e => e.MontoCheque)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobDatosCheque, Decimal?>>)(e => e.RmontoCheque)).HasColumnName<Decimal?>("RMontoCheque").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.HasOne<AppService.Core.Entities.CobGeneralCobranza>((Expression<Func<AppService.Core.Entities.CobDatosCheque, AppService.Core.Entities.CobGeneralCobranza>>)(d => d.DocumentoNavigation)).WithOne((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, AppService.Core.Entities.CobDatosCheque>>)(p => p.CobDatosCheque)).HasForeignKey<AppService.Core.Entities.CobDatosCheque>((Expression<Func<AppService.Core.Entities.CobDatosCheque, object>>)(d => (object)d.Documento)).HasConstraintName<AppService.Core.Entities.CobDatosCheque, AppService.Core.Entities.CobGeneralCobranza>("FK_CobDatosCheque_CobGeneralCobranza");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion>((Action<EntityTypeBuilder<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion, object>>)(e => new
                {
                    IdTipoTransaccion = e.IdTipoTransaccion,
                    BsDesde = e.BsDesde,
                    BsHasta = e.BsHasta
                })).HasName<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion>("IX_CobDescuentoIvaTipoTransaccion").IsUnique(true);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion, Decimal>>)(e => e.BsDesde)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion, Decimal>>)(e => e.BsHasta)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion, string>>)(e => e.IdTipoTransaccion)).IsRequired(true).HasMaxLength(4);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion, Decimal>>)(e => e.PorcDescuento)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion, Decimal?>>)(e => e.RbsDesde)).HasColumnName<Decimal?>("RBsDesde").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobDescuentoIvaTipoTransaccion, Decimal?>>)(e => e.RbsHasta)).HasColumnName<Decimal?>("RBsHasta").HasColumnType<Decimal?>("numeric(18, 2)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobDiferenciaRetencion>((Action<EntityTypeBuilder<AppService.Core.Entities.CobDiferenciaRetencion>>)(entity =>
            {
                entity.HasNoKey();
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, object>>)(e => new
                {
                    AñoCobro = e.AñoCobro,
                    MesCobro = e.MesCobro
                })).HasName<AppService.Core.Entities.CobDiferenciaRetencion>("IX_CobDiferenciaRetencion");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, Decimal?>>)(e => e.BsEmision)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, Decimal?>>)(e => e.Diferencia)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, string>>)(e => e.DocumentoSap)).HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, Decimal?>>)(e => e.DolaresComprobante)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, Decimal?>>)(e => e.DolaresContabilizacion)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, Decimal?>>)(e => e.DolaresFechaFactura)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, DateTime?>>)(e => e.FechaComprobante)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, DateTime?>>)(e => e.FechaContabilizacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, DateTime?>>)(e => e.FechaFactura)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, string>>)(e => e.NombreCliente)).HasMaxLength(200);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, string>>)(e => e.NroComprobante)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, string>>)(e => e.Oficina)).HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, Decimal?>>)(e => e.Porcentaje)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, string>>)(e => e.Region)).HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, Decimal?>>)(e => e.TasaComprobante)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, Decimal?>>)(e => e.TasaContabilizacion)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobDiferenciaRetencion, string>>)(e => e.Vendedor)).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobEstadoDeCuenta>((Action<EntityTypeBuilder<AppService.Core.Entities.CobEstadoDeCuenta>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, object>>)(e => e.DocumentoSap)).HasName<AppService.Core.Entities.CobEstadoDeCuenta>("IX_CobEstadoDeCuenta_3");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, object>>)(e => e.IdCliente)).HasName<AppService.Core.Entities.CobEstadoDeCuenta>("IX_CobEstadoDeCuenta_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, object>>)(e => (object)e.Rpdoc)).HasName<AppService.Core.Entities.CobEstadoDeCuenta>("IX_CobEstadoDeCuenta_2");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, object>>)(e => new
                {
                    Rpkco = e.Rpkco,
                    Rpdct = e.Rpdct,
                    Rpdoc = e.Rpdoc,
                    Rpsfx = e.Rpsfx
                })).HasName<AppService.Core.Entities.CobEstadoDeCuenta>("IX_CobEstadoDeCuenta");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, Decimal?>>)(e => e.BaseImponible)).HasColumnType<Decimal?>("numeric(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, string>>)(e => e.DocumentoSap)).HasMaxLength(10);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, DateTime?>>)(e => e.FechaDocumento)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, DateTime?>>)(e => e.FechaVencimiento)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, string>>)(e => e.IdCliente)).HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, Decimal?>>)(e => e.Iva)).HasColumnType<Decimal?>("numeric(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, string>>)(e => e.Moneda)).HasMaxLength(10);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, Decimal?>>)(e => e.MontoOriginal)).HasColumnType<Decimal?>("numeric(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, string>>)(e => e.OficinaVenta)).HasColumnName<string>("Oficina_Venta").HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, string>>)(e => e.Pltyp)).HasColumnName<string>("PLTYP").HasMaxLength(2).HasDefaultValueSql<string>("('Z2')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, Decimal?>>)(e => e.RbaseImponible)).HasColumnName<Decimal?>("RBaseImponible").HasColumnType<Decimal?>("numeric(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, Decimal?>>)(e => e.Riva)).HasColumnName<Decimal?>("RIva").HasColumnType<Decimal?>("numeric(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, Decimal?>>)(e => e.RmontoOriginal)).HasColumnName<Decimal?>("RMontoOriginal").HasColumnType<Decimal?>("numeric(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, double?>>)(e => e.Rpaap)).HasColumnName<double?>("RPAAP").HasDefaultValueSql<double?>("((0))");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, double?>>)(e => e.Rpag)).HasColumnName<double?>("RPAG").HasDefaultValueSql<double?>("((0))");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, double?>>)(e => e.Rpan8)).HasColumnName<double?>("RPAN8").HasDefaultValueSql<double?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, string>>)(e => e.Rpdct)).IsRequired(true).HasColumnName<string>("RPDCT").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<double>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, double>>)(e => e.Rpdoc)).HasColumnName<double>("RPDOC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, string>>)(e => e.Rpkco)).IsRequired(true).HasColumnName<string>("RPKCO").HasMaxLength(5).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, string>>)(e => e.Rpsfx)).IsRequired(true).HasColumnName<string>("RPSFX").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, double?>>)(e => e.Rrpaap)).HasColumnName<double?>("RRPAAP").HasDefaultValueSql<double?>("((0))");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, double?>>)(e => e.Rrpag)).HasColumnName<double?>("RRPAG").HasDefaultValueSql<double?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuenta, string>>)(e => e.Vendedor)).HasMaxLength(4);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobEstadoDeCuentaBk>((Action<EntityTypeBuilder<AppService.Core.Entities.CobEstadoDeCuentaBk>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.CobEstadoDeCuentaBk>("CobEstadoDeCuentaBK");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, Decimal?>>)(e => e.BaseImponible)).HasColumnType<Decimal?>("decimal(18, 2)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, DateTime?>>)(e => e.FechaDocumento)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, DateTime?>>)(e => e.FechaVencimiento)).HasColumnType<DateTime?>("datetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, string>>)(e => e.IdCliente)).HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, Decimal?>>)(e => e.Iva)).HasColumnType<Decimal?>("decimal(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, Decimal?>>)(e => e.MontoOriginal)).HasColumnType<Decimal?>("decimal(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, string>>)(e => e.OficinaVenta)).HasColumnName<string>("Oficina_Venta").HasMaxLength(10);
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, double?>>)(e => e.Rpaap)).HasColumnName<double?>("RPAAP");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, double?>>)(e => e.Rpag)).HasColumnName<double?>("RPAG");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, double?>>)(e => e.Rpan8)).HasColumnName<double?>("RPAN8");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, string>>)(e => e.Rpdct)).IsRequired(true).HasColumnName<string>("RPDCT").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<double>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, double>>)(e => e.Rpdoc)).HasColumnName<double>("RPDOC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, string>>)(e => e.Rpkco)).IsRequired(true).HasColumnName<string>("RPKCO").HasMaxLength(5).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, string>>)(e => e.Rpsfx)).IsRequired(true).HasColumnName<string>("RPSFX").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobEstadoDeCuentaBk, string>>)(e => e.Vendedor)).HasMaxLength(4);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobExcepcion>((Action<EntityTypeBuilder<AppService.Core.Entities.CobExcepcion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobExcepcion, object>>)(e => (object)e.IdExcepcion));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobExcepcion, object>>)(e => (object)e.Documento)).HasName<AppService.Core.Entities.CobExcepcion>("IX_CobExcepcion").IsUnique(true);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobExcepcion, DateTime>>)(e => e.FechaLm)).HasColumnName<DateTime>("FechaLM").HasColumnType<DateTime>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobExcepcion, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobExcepcion, string>>)(e => e.Motivo)).IsRequired(true).HasMaxLength(500);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobExcepcion, string>>)(e => e.UsuarioRegistro)).IsRequired(true).HasMaxLength(40);
                entity.HasOne<AppService.Core.Entities.CobGeneralCobranza>((Expression<Func<AppService.Core.Entities.CobExcepcion, AppService.Core.Entities.CobGeneralCobranza>>)(d => d.DocumentoNavigation)).WithOne((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, AppService.Core.Entities.CobExcepcion>>)(p => p.CobExcepcion)).HasForeignKey<AppService.Core.Entities.CobExcepcion>((Expression<Func<AppService.Core.Entities.CobExcepcion, object>>)(d => (object)d.Documento)).HasConstraintName<AppService.Core.Entities.CobExcepcion, AppService.Core.Entities.CobGeneralCobranza>("FK_CobExcepcion_CobGeneralCobranza");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobGeneralCobranza>((Action<EntityTypeBuilder<AppService.Core.Entities.CobGeneralCobranza>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, object>>)(e => (object)e.Documento));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, object>>)(e => e.IdCliente)).HasName<AppService.Core.Entities.CobGeneralCobranza>("IX_CobGeneralCobranza_2");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, object>>)(e => (object)e.NumReferencia)).HasName<AppService.Core.Entities.CobGeneralCobranza>("IX_CobGeneralCobranza");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, object>>)(e => e.OficinaVenta)).HasName<AppService.Core.Entities.CobGeneralCobranza>("IX_CobGeneralCobranza_3");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, object>>)(e => e.SearchText)).HasName<AppService.Core.Entities.CobGeneralCobranza>("IX_CobGeneralCobranza_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, object>>)(e => new
                {
                    OficinaVenta = e.OficinaVenta,
                    SearchText = e.SearchText
                })).HasName<AppService.Core.Entities.CobGeneralCobranza>("IX_CobGeneralCobranza_4");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, object>>)(e => new
                {
                    OficinaVenta = e.OficinaVenta,
                    FlagEnviado = e.FlagEnviado,
                    FlagAnulado = e.FlagAnulado,
                    FlagConfirmado = e.FlagConfirmado
                })).HasName<AppService.Core.Entities.CobGeneralCobranza>("IX_CobGeneralCobranza_5");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, double?>>)(e => e.Batch)).HasDefaultValueSql<double?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.EmailCliente)).HasMaxLength(100).HasDefaultValueSql<string>("('')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, DateTime?>>)(e => e.FechaAnulado)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, DateTime?>>)(e => e.FechaAprobado)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, DateTime?>>)(e => e.FechaConfirmado)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, DateTime?>>)(e => e.FechaEnviado)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, DateTime?>>)(e => e.FechaLm)).HasColumnName<DateTime?>("FechaLM").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, DateTime?>>)(e => e.FechaLmcxC)).HasColumnName<DateTime?>("FechaLMCxC").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, DateTime?>>)(e => e.FechaReversado)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, DateTime>>)(e => e.FechaTransaccion)).HasColumnType<DateTime>("datetime");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, bool?>>)(e => e.FlagAnulado)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, bool?>>)(e => e.FlagConfirmado)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, bool?>>)(e => e.FlagPagoMas)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.IdBanco)).IsRequired(true).HasMaxLength(4).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.IdCliente)).IsRequired(true).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.IdTipoTransaccion)).IsRequired(true).HasMaxLength(4);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, Decimal>>)(e => e.MontoTransaccion)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.ObsvAnulacion)).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.OficinaVenta)).IsRequired(true).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, Decimal?>>)(e => e.RmontoTransaccion)).HasColumnName<Decimal?>("RMontoTransaccion").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, Decimal?>>)(e => e.RtotalDetalleCobrado)).HasColumnName<Decimal?>("RTotalDetalleCobrado").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.SearchText)).IsRequired(true).HasMaxLength(400);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, Decimal?>>)(e => e.TotalDetalleCobrado)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<bool>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, bool>>)(e => e.TransferidoSap)).HasColumnName<bool>("TransferidoSAP");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.UsuarioAnula)).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.UsuarioAprueba)).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.UsuarioConfirma)).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.UsuarioRegistro)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, string>>)(e => e.UsuarioReversa)).HasMaxLength(40);
                entity.HasOne<AppService.Core.Entities.MtrCliente>((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, AppService.Core.Entities.MtrCliente>>)(d => d.IdClienteNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrCliente, IEnumerable<AppService.Core.Entities.CobGeneralCobranza>>>)(p => p.CobGeneralCobranza)).HasForeignKey((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, object>>)(d => d.IdCliente)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrCliente, AppService.Core.Entities.CobGeneralCobranza>("FK_CobGeneralCobranza_MtrCliente");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobGrabacionCobranzas>((Action<EntityTypeBuilder<AppService.Core.Entities.CobGrabacionCobranzas>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, object>>)(e => e.Cotizacion)).HasName<AppService.Core.Entities.CobGrabacionCobranzas>("IX_CobGrabacionCobranzas_4");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, object>>)(e => (object)e.DocAfecta)).HasName<AppService.Core.Entities.CobGrabacionCobranzas>("IX_CobGrabacionCobranzas_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, object>>)(e => (object)e.Documento)).HasName<AppService.Core.Entities.CobGrabacionCobranzas>("IX_CobGrabacionCobranzas");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, object>>)(e => (object)e.Id)).HasName<AppService.Core.Entities.CobGrabacionCobranzas>("IX_CobGrabacionCobranzas_2");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, object>>)(e => (object)e.Rpdoc)).HasName<AppService.Core.Entities.CobGrabacionCobranzas>("IX_CobGrabacionCobranzas_6");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, object>>)(e => new
                {
                    Documento = e.Documento,
                    Transaccion = e.Transaccion
                })).HasName<AppService.Core.Entities.CobGrabacionCobranzas>("IX_CobGrabacionCobranzas_5");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, object>>)(e => new
                {
                    Transaccion = e.Transaccion,
                    Cotizacion = e.Cotizacion
                })).HasName<AppService.Core.Entities.CobGrabacionCobranzas>("IX_CobGrabacionCobranzas_3");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, string>>)(e => e.Cotizacion)).HasMaxLength(13).HasDefaultValueSql<string>("('')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, Decimal>>)(e => e.DocAfecta)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, string>>)(e => e.DocAfectaSap)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, string>>)(e => e.DocumentoSap)).HasMaxLength(10).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, string>>)(e => e.EjercicioDocumentoSap)).HasMaxLength(4).HasDefaultValueSql<string>("('')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, DateTime?>>)(e => e.FechaTasa)).HasColumnType<DateTime?>("datetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, Decimal?>>)(e => e.Monto)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, Decimal?>>)(e => e.MontoBs)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, Decimal?>>)(e => e.MontoReconvertido)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, bool?>>)(e => e.PagoCorrespondeIva)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, bool?>>)(e => e.PagoDeMas)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, Decimal?>>)(e => e.Rmonto)).HasColumnName<Decimal?>("RMonto").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, Decimal?>>)(e => e.RmontoBs)).HasColumnName<Decimal?>("RMontoBs").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, string>>)(e => e.Rpdct)).IsRequired(true).HasColumnName<string>("RPDCT").HasMaxLength(2).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<double>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, double>>)(e => e.Rpdoc)).HasColumnName<double>("RPDOC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, string>>)(e => e.Rpkco)).IsRequired(true).HasColumnName<string>("RPKCO").HasMaxLength(5).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, string>>)(e => e.Rpsfx)).IsRequired(true).HasColumnName<string>("RPSFX").HasMaxLength(3).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, Decimal?>>)(e => e.RtasaBancoCentral)).HasColumnName<Decimal?>("RTasaBancoCentral").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, Decimal?>>)(e => e.TasaBancoCentral)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, string>>)(e => e.Transaccion)).HasMaxLength(2);
                entity.HasOne<AppService.Core.Entities.CobGeneralCobranza>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, AppService.Core.Entities.CobGeneralCobranza>>)(d => d.DocumentoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.CobGeneralCobranza, IEnumerable<AppService.Core.Entities.CobGrabacionCobranzas>>>)(p => p.CobGrabacionCobranzas)).HasForeignKey((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, object>>)(d => (object)d.Documento)).OnDelete(DeleteBehavior.Cascade).HasConstraintName<AppService.Core.Entities.CobGeneralCobranza, AppService.Core.Entities.CobGrabacionCobranzas>("FK_CobGrabacionCobranzas_CobGeneralCobranza");
                entity.HasOne<AppService.Core.Entities.CobTransacciones>((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, AppService.Core.Entities.CobTransacciones>>)(d => d.TransaccionNavigation)).WithMany((Expression<Func<AppService.Core.Entities.CobTransacciones, IEnumerable<AppService.Core.Entities.CobGrabacionCobranzas>>>)(p => p.CobGrabacionCobranzas)).HasPrincipalKey((Expression<Func<AppService.Core.Entities.CobTransacciones, object>>)(p => p.Transaccion)).HasForeignKey((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, object>>)(d => d.Transaccion)).HasConstraintName<AppService.Core.Entities.CobTransacciones, AppService.Core.Entities.CobGrabacionCobranzas>("FK_CobGrabacionCobranzas_CobTransacciones");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobIntegridadCobranzasVsWary074>((Action<EntityTypeBuilder<AppService.Core.Entities.CobIntegridadCobranzasVsWary074>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, object>>)(e => (object)e.Documento));
                entity.Property<long>((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, long>>)(e => e.Documento)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, string>>)(e => e.Cliente)).HasMaxLength(10);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, Decimal?>>)(e => e.Diferencia)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, DateTime?>>)(e => e.FechaEvaluacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, DateTime?>>)(e => e.FechaRegistro)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, Decimal?>>)(e => e.MontoCobrado)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, Decimal?>>)(e => e.MontoRetenido)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, Decimal?>>)(e => e.TotalCobradoWary074)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, Decimal?>>)(e => e.TotalCobroRetencion)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobIntegridadCobranzasVsWary074, Decimal?>>)(e => e.TotalSapCobranzas)).HasColumnType<Decimal?>("numeric(18, 2)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobMatrixMonedaValidaPago>((Action<EntityTypeBuilder<AppService.Core.Entities.CobMatrixMonedaValidaPago>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobMatrixMonedaValidaPago, string>>)(e => e.MonedaDocumento)).HasMaxLength(4);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobMatrixMonedaValidaPago, string>>)(e => e.MonedaPago)).HasMaxLength(4);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobPagosRetenciones>((Action<EntityTypeBuilder<AppService.Core.Entities.CobPagosRetenciones>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobPagosRetenciones, object>>)(e => new
                {
                    IdCobranza = e.IdCobranza,
                    IdTransaccion = e.IdTransaccion,
                    Porcentaje = e.Porcentaje
                })).HasName<AppService.Core.Entities.CobPagosRetenciones>("IX_CobPagosRetenciones").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobPagosRetenciones, string>>)(e => e.DocumentoSap)).HasMaxLength(10).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobPagosRetenciones, string>>)(e => e.EjercicioDocumentoSap)).HasMaxLength(4).HasDefaultValueSql<string>("('')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobPagosRetenciones, DateTime>>)(e => e.FechaComprobante)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobPagosRetenciones, DateTime>>)(e => e.FechaCrea)).HasColumnType<DateTime>("datetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobPagosRetenciones, Decimal>>)(e => e.Monto)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobPagosRetenciones, string>>)(e => e.NroComprobante)).IsRequired(true).HasMaxLength(50).HasDefaultValueSql<string>("('')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobPagosRetenciones, Decimal>>)(e => e.Porcentaje)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobPagosRetenciones, Decimal?>>)(e => e.Rmonto)).HasColumnName<Decimal?>("RMonto").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.HasOne<AppService.Core.Entities.CobGrabacionCobranzas>((Expression<Func<AppService.Core.Entities.CobPagosRetenciones, AppService.Core.Entities.CobGrabacionCobranzas>>)(d => d.IdCobranzaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.CobGrabacionCobranzas, IEnumerable<AppService.Core.Entities.CobPagosRetenciones>>>)(p => p.CobPagosRetenciones)).HasForeignKey((Expression<Func<AppService.Core.Entities.CobPagosRetenciones, object>>)(d => (object)d.IdCobranza)).HasConstraintName<AppService.Core.Entities.CobGrabacionCobranzas, AppService.Core.Entities.CobPagosRetenciones>("FK_CobPagosRetenciones_CobGrabacionCobranzas");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobPorcentajesImpuestos>((Action<EntityTypeBuilder<AppService.Core.Entities.CobPorcentajesImpuestos>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobPorcentajesImpuestos, object>>)(e => (object)e.IdPorcImpuestos));
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobPorcentajesImpuestos, Decimal?>>)(e => e.Desde)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobPorcentajesImpuestos, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobPorcentajesImpuestos, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobPorcentajesImpuestos, Decimal?>>)(e => e.Hasta)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobPorcentajesImpuestos, Decimal?>>)(e => e.Incremento)).HasColumnType<Decimal?>("decimal(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobPorcentajesImpuestos, string>>)(e => e.UsuarioCreacion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobPorcentajesImpuestos, string>>)(e => e.UsuarioModificacion)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobRangosVencimiento>((Action<EntityTypeBuilder<AppService.Core.Entities.CobRangosVencimiento>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobRangosVencimiento, object>>)(e => (object)e.Codigo));
                entity.ToTable<AppService.Core.Entities.CobRangosVencimiento>("Cob_Rangos_Vencimiento");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobRangosVencimiento, Decimal>>)(e => e.Codigo)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobRangosVencimiento, string>>)(e => e.Descripcion)).HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobRangosVencimiento, Decimal?>>)(e => e.DiasDesde)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobRangosVencimiento, Decimal?>>)(e => e.DiasHasta)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobRangosVencimiento, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobRangosVencimiento, string>>)(e => e.PieDos)).HasColumnName<string>("Pie_Dos");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobRangosVencimiento, string>>)(e => e.PieUno)).HasColumnName<string>("Pie_Uno");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobResumenEstadoCuenta>((Action<EntityTypeBuilder<AppService.Core.Entities.CobResumenEstadoCuenta>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuenta, object>>)(e => e.Cliente));
                entity.ToTable<AppService.Core.Entities.CobResumenEstadoCuenta>("Cob_Resumen_Estado_Cuenta");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuenta, object>>)(e => e.Consultor)).HasName<AppService.Core.Entities.CobResumenEstadoCuenta>("IX_Cob_Resumen_Estado_Cuenta_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuenta, object>>)(e => (object)e.Oficina)).HasName<AppService.Core.Entities.CobResumenEstadoCuenta>("IX_Cob_Resumen_Estado_Cuenta");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuenta, string>>)(e => e.Cliente)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuenta, string>>)(e => e.Consultor)).HasMaxLength(4);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuenta, string>>)(e => e.DescripcionRango)).HasMaxLength(80);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuenta, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuenta, string>>)(e => e.NombreCliente)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuenta, string>>)(e => e.NombreConsultor)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuenta, string>>)(e => e.NombreOficina)).HasMaxLength(80);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuenta, Decimal>>)(e => e.Saldo)).HasColumnType<Decimal>("numeric(18, 2)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobResumenEstadoCuentaTemp>((Action<EntityTypeBuilder<AppService.Core.Entities.CobResumenEstadoCuentaTemp>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuentaTemp, object>>)(e => e.Cliente));
                entity.ToTable<AppService.Core.Entities.CobResumenEstadoCuentaTemp>("Cob_Resumen_Estado_Cuenta_Temp");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuentaTemp, string>>)(e => e.Cliente)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuentaTemp, string>>)(e => e.Consultor)).HasMaxLength(4);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuentaTemp, string>>)(e => e.DescripcionRango)).HasMaxLength(80);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuentaTemp, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuentaTemp, string>>)(e => e.NombreCliente)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuentaTemp, string>>)(e => e.NombreConsultor)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuentaTemp, string>>)(e => e.NombreOficina)).HasMaxLength(80);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobResumenEstadoCuentaTemp, Decimal>>)(e => e.Saldo)).HasColumnType<Decimal>("numeric(18, 2)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobRolCobranza>((Action<EntityTypeBuilder<AppService.Core.Entities.CobRolCobranza>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobRolCobranza, object>>)(e => (object)e.IdRolCobranza));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobRolCobranza, object>>)(e => new
                {
                    IdUsuario = e.IdUsuario,
                    IdOficina = e.IdOficina
                })).HasName<AppService.Core.Entities.CobRolCobranza>("IX_CobRolCobranza").IsUnique(true);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobRolCobranza, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobRolCobranza, string>>)(e => e.IdUsuario)).IsRequired(true).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobSysfile>((Action<EntityTypeBuilder<AppService.Core.Entities.CobSysfile>>)(entity =>
            {
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobSysfile, DateTime>>)(e => e.FechaLm)).HasColumnName<DateTime>("FechaLM").HasColumnType<DateTime>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobSysfile, DateTime?>>)(e => e.FechaLmcxC)).HasColumnName<DateTime?>("FechaLMCxC").HasColumnType<DateTime?>("datetime");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CobSysfile, bool?>>)(e => e.FlagAprobarRc)).IsRequired(true).HasColumnName<bool?>("FlagAprobarRC").HasDefaultValueSql<bool?>("((1))");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobTipoTransaccion>((Action<EntityTypeBuilder<AppService.Core.Entities.CobTipoTransaccion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobTipoTransaccion, object>>)(e => e.IdTipoTransaccion));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTipoTransaccion, string>>)(e => e.IdTipoTransaccion)).HasMaxLength(4);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTipoTransaccion, string>>)(e => e.ColetillaIva)).IsRequired(true).HasMaxLength(1000).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTipoTransaccion, string>>)(e => e.IdTipoPagoSap)).IsRequired(true).HasColumnName<string>("IdTipoPagoSAP").HasMaxLength(50).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTipoTransaccion, string>>)(e => e.NombreTipoTransaccion)).IsRequired(true).HasMaxLength(250);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobTipoTransaccionRespaldoAntesEliminarColettilla>((Action<EntityTypeBuilder<AppService.Core.Entities.CobTipoTransaccionRespaldoAntesEliminarColettilla>>)(entity =>
            {
                entity.HasNoKey();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTipoTransaccionRespaldoAntesEliminarColettilla, string>>)(e => e.ColetillaIva)).IsRequired(true).HasMaxLength(1000);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTipoTransaccionRespaldoAntesEliminarColettilla, string>>)(e => e.IdTipoPagoSap)).IsRequired(true).HasColumnName<string>("IdTipoPagoSAP").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTipoTransaccionRespaldoAntesEliminarColettilla, string>>)(e => e.IdTipoTransaccion)).IsRequired(true).HasMaxLength(4);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTipoTransaccionRespaldoAntesEliminarColettilla, string>>)(e => e.NombreTipoTransaccion)).IsRequired(true).HasMaxLength(250);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobTransacciones>((Action<EntityTypeBuilder<AppService.Core.Entities.CobTransacciones>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobTransacciones, object>>)(e => (object)e.IdTransacccionCobranzas));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobTransacciones, object>>)(e => e.TransLegacy)).HasName<AppService.Core.Entities.CobTransacciones>("IX_CobTransacciones_1").IsUnique(true);
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CobTransacciones, object>>)(e => e.Transaccion)).HasName<AppService.Core.Entities.CobTransacciones>("IX_CobTransacciones").IsUnique(true);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CobTransacciones, Decimal>>)(e => e.BsHolgura)).HasColumnType<Decimal>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTransacciones, string>>)(e => e.CuentaContable)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTransacciones, string>>)(e => e.CuentaSap)).IsRequired(true).HasColumnName<string>("CuentaSAP").HasMaxLength(10);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobTransacciones, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobTransacciones, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTransacciones, string>>)(e => e.NombreTransaccion)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTransacciones, string>>)(e => e.TipoSap)).IsRequired(true).HasColumnName<string>("TipoSAP").HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTransacciones, string>>)(e => e.TransLegacy)).IsRequired(true).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTransacciones, string>>)(e => e.Transaccion)).IsRequired(true).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTransacciones, string>>)(e => e.UsuarioCreacion)).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobTransacciones, string>>)(e => e.UsuarioModificacion)).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobValoresRetencionIslr>((Action<EntityTypeBuilder<AppService.Core.Entities.CobValoresRetencionIslr>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobValoresRetencionIslr, object>>)(e => (object)e.IdRetIslr));
                entity.ToTable<AppService.Core.Entities.CobValoresRetencionIslr>("CobValoresRetencionISLR");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.CobValoresRetencionIslr, int>>)(e => e.IdRetIslr)).HasColumnName<int>("IdRetISLR");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobValoresRetencionIslr, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobValoresRetencionIslr, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobValoresRetencionIslr, Decimal?>>)(e => e.PorcRetIslr)).HasColumnName<Decimal?>("PorcRetISLR").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobValoresRetencionIslr, string>>)(e => e.UsuarioCreacion)).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobValoresRetencionIslr, string>>)(e => e.UsuarioModificacion)).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobValoresRetencionIva>((Action<EntityTypeBuilder<AppService.Core.Entities.CobValoresRetencionIva>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobValoresRetencionIva, object>>)(e => (object)e.IdRetIva));
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobValoresRetencionIva, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobValoresRetencionIva, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CobValoresRetencionIva, Decimal?>>)(e => e.PorcRetIva)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobValoresRetencionIva, string>>)(e => e.UsuarioCreacion)).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobValoresRetencionIva, string>>)(e => e.UsuarioModificacion)).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CobValoresRetenciones>((Action<EntityTypeBuilder<AppService.Core.Entities.CobValoresRetenciones>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CobValoresRetenciones, object>>)(e => (object)e.IdTransaccion));
                entity.Property<long>((Expression<Func<AppService.Core.Entities.CobValoresRetenciones, long>>)(e => e.IdTransaccion)).ValueGeneratedNever();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CobValoresRetenciones, DateTime?>>)(e => e.FechaModifica)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CobValoresRetenciones, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobValoresRetenciones, string>>)(e => e.UsuarioModifica)).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobValoresRetenciones, string>>)(e => e.UsuarioRegistro)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CobValoresRetenciones, string>>)(e => e.Valores)).IsRequired(true).HasMaxLength(500);
            }));
            modelBuilder.Entity<AppService.Core.Entities.Company>((Action<EntityTypeBuilder<AppService.Core.Entities.Company>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.Company, object>>)(e => e.Name)).HasName<AppService.Core.Entities.Company>("Company_Name_Index").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Company, string>>)(e => e.Address)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Company, string>>)(e => e.Name)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Company, string>>)(e => e.Phone)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.Cpry010>((Action<EntityTypeBuilder<AppService.Core.Entities.Cpry010>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.Cpry010, object>>)(e => (object)e.JobId)).HasName("CPRY010_INDEX01");
                entity.ToTable<AppService.Core.Entities.Cpry010>("CPRY010");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.Cpry010, object>>)(e => (object)e.Cliente)).HasName<AppService.Core.Entities.Cpry010>("IX_CPRY010");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Cpry010, long>>)(e => e.JobId)).HasColumnName<long>("JOB_ID").ValueGeneratedNever();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.ArregloReopera)).HasColumnName<short?>("ARREGLO_REOPERA");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CantAProducir)).HasColumnName<long?>("CANT_A_PRODUCIR");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CantAcabado)).HasColumnName<long?>("CANT_ACABADO").HasDefaultValueSql<long?>("((0))");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CantArte)).HasColumnName<long?>("CANT_ARTE").HasDefaultValueSql<long?>("((0))");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CantBcs)).HasColumnName<long?>("CANT_BCS").HasDefaultValueSql<long?>("((0))");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry010, int?>>)(e => e.CantCajaUtili)).HasColumnName<int?>("CANT_CAJA_UTILI");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CantColect)).HasColumnName<long?>("CANT_COLECT").HasDefaultValueSql<long?>("((0))");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CantEmbarque)).HasColumnName<long?>("CANT_EMBARQUE").HasDefaultValueSql<long?>("((0))");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CantFactura)).HasColumnName<long?>("CANT_FACTURA").HasDefaultValueSql<long?>("((0))");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CantFoto)).HasColumnName<long?>("CANT_FOTO").HasDefaultValueSql<long?>("((0))");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CantPlan)).HasColumnName<long?>("CANT_PLAN").HasDefaultValueSql<long?>("((0))");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CantPrensa)).HasColumnName<long?>("CANT_PRENSA").HasDefaultValueSql<long?>("((0))");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CantProgramada)).HasColumnName<long?>("CANT_PROGRAMADA");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry010, int?>>)(e => e.CantidRemanent)).HasColumnName<int?>("CANTID_REMANENT");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.CausaReoperaci)).HasColumnName<short?>("CAUSA_REOPERACI");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Cpry010, int>>)(e => e.Cliente)).HasColumnName<int>("CLIENTE");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.CodBacklogRet)).HasColumnName<short?>("COD_BACKLOG_RET");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.CodigoCaja)).HasColumnName<string>("CODIGO_CAJA").HasMaxLength(8).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.Combinacion)).HasColumnName<string>("COMBINACION").HasMaxLength(50).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.Cotizacion)).HasColumnName<string>("COTIZACION").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CtdEntregada)).HasColumnName<long?>("CTD_ENTREGADA");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.CtdFactAdelan)).HasColumnName<long?>("CTD_FACT_ADELAN");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasAcabado)).HasColumnName<short?>("DIAS_ACABADO");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasArte)).HasColumnName<short?>("DIAS_ARTE");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasBcs)).HasColumnName<short?>("DIAS_BCS");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasColectora)).HasColumnName<short?>("DIAS_COLECTORA");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasEmbarque)).HasColumnName<short?>("DIAS_EMBARQUE");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasFoto)).HasColumnName<short?>("DIAS_FOTO");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasPlaneacion)).HasColumnName<short?>("DIAS_PLANEACION");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasPrensa)).HasColumnName<short?>("DIAS_PRENSA");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasRetAcabad)).HasColumnName<short?>("DIAS_RET_ACABAD");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasRetArte)).HasColumnName<short?>("DIAS_RET_ARTE");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasRetBcs)).HasColumnName<short?>("DIAS_RET_BCS");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasRetColect)).HasColumnName<short?>("DIAS_RET_COLECT");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasRetEmbarq)).HasColumnName<short?>("DIAS_RET_EMBARQ");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasRetFoto)).HasColumnName<short?>("DIAS_RET_FOTO");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasRetPlanea)).HasColumnName<short?>("DIAS_RET_PLANEA");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.DiasRetPrensa)).HasColumnName<short?>("DIAS_RET_PRENSA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.Elimina)).HasColumnName<string>("ELIMINA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FecRealOrden)).HasColumnName<DateTime?>("FEC_REAL_ORDEN").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaArchivo)).HasColumnName<DateTime?>("FECHA_ARCHIVO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime>>)(e => e.FechaEntrega)).HasColumnName<DateTime>("FECHA_ENTREGA").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime>>)(e => e.FechaFactura)).HasColumnName<DateTime>("FECHA_FACTURA").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaOrdEntry)).HasColumnName<DateTime?>("FECHA_ORD_ENTRY").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaRet)).HasColumnName<DateTime?>("FECHA_RET").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaRetenido)).HasColumnName<DateTime?>("FECHA_RETENIDO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaeEstAcab)).HasColumnName<DateTime?>("FECHAE_EST_ACAB").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaeEstBcs)).HasColumnName<DateTime?>("FECHAE_EST_BCS").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaeEstCole)).HasColumnName<DateTime?>("FECHAE_EST_COLE").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaeEstDise)).HasColumnName<DateTime?>("FECHAE_EST_DISE").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaeEstEmba)).HasColumnName<DateTime?>("FECHAE_EST_EMBA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaeEstEntr)).HasColumnName<DateTime?>("FECHAE_EST_ENTR").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaeEstFact)).HasColumnName<DateTime?>("FECHAE_EST_FACT").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaeEstNega)).HasColumnName<DateTime?>("FECHAE_EST_NEGA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaeEstPren)).HasColumnName<DateTime?>("FECHAE_EST_PREN").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaerAcabado)).HasColumnName<DateTime?>("FECHAER_ACABADO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaerBcs)).HasColumnName<DateTime?>("FECHAER_BCS").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaerColecto)).HasColumnName<DateTime?>("FECHAER_COLECTO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaerDiseno)).HasColumnName<DateTime?>("FECHAER_DISENO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaerEmbarqu)).HasColumnName<DateTime?>("FECHAER_EMBARQU").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaerFactura)).HasColumnName<DateTime?>("FECHAER_FACTURA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaerNegativ)).HasColumnName<DateTime?>("FECHAER_NEGATIV").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaerPrelim)).HasColumnName<DateTime?>("FECHAER_PRELIM").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechaerPrensas)).HasColumnName<DateTime?>("FECHAER_PRENSAS").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasEstAcab)).HasColumnName<DateTime?>("FECHAS_EST_ACAB").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasEstBcs)).HasColumnName<DateTime?>("FECHAS_EST_BCS").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasEstCole)).HasColumnName<DateTime?>("FECHAS_EST_COLE").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasEstDise)).HasColumnName<DateTime?>("FECHAS_EST_DISE").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasEstEmba)).HasColumnName<DateTime?>("FECHAS_EST_EMBA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasEstFact)).HasColumnName<DateTime?>("FECHAS_EST_FACT").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasEstNega)).HasColumnName<DateTime?>("FECHAS_EST_NEGA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasEstPrel)).HasColumnName<DateTime?>("FECHAS_EST_PREL").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasEstPren)).HasColumnName<DateTime?>("FECHAS_EST_PREN").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasrAcabado)).HasColumnName<DateTime?>("FECHASR_ACABADO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasrBcs)).HasColumnName<DateTime?>("FECHASR_BCS").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasrColecto)).HasColumnName<DateTime?>("FECHASR_COLECTO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasrDiseno)).HasColumnName<DateTime?>("FECHASR_DISENO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasrEmbarqu)).HasColumnName<DateTime?>("FECHASR_EMBARQU").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasrNegativ)).HasColumnName<DateTime?>("FECHASR_NEGATIV").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasrPrelim)).HasColumnName<DateTime?>("FECHASR_PRELIM").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.FechasrPrensas)).HasColumnName<DateTime?>("FECHASR_PRENSAS").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.Fiscal)).HasColumnName<string>("FISCAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagAcabado)).HasColumnName<string>("FLAG_ACABADO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagBcs)).HasColumnName<string>("FLAG_BCS").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagColectora)).HasColumnName<string>("FLAG_COLECTORA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagDiseno)).HasColumnName<string>("FLAG_DISENO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagEmbarque)).HasColumnName<string>("FLAG_EMBARQUE").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagEtiqImpre)).HasColumnName<string>("FLAG_ETIQ_IMPRE").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagFoto)).HasColumnName<string>("FLAG_FOTO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagPlaneac)).HasColumnName<string>("FLAG_PLANEAC").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagPlaneado)).HasColumnName<string>("FLAG_PLANEADO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagPrensas)).HasColumnName<string>("FLAG_PRENSAS").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagRetenido)).HasColumnName<string>("FLAG_RETENIDO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.FlagSoportev)).HasColumnName<string>("FLAG_SOPORTEV").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.FormInicial)).HasColumnName<long?>("FORM_INICIAL");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry010, int?>>)(e => e.FormPorCaja)).HasColumnName<int?>("FORM_POR_CAJA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.JobAutomatico)).HasColumnName<string>("JOB_AUTOMATICO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.JobRestar)).HasColumnName<long?>("JOB_RESTAR");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Cpry010, short>>)(e => e.LineaProduccio)).HasColumnName<short>("LINEA_PRODUCCIO");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.Lista)).HasColumnName<Decimal?>("LISTA").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.LugarProducir)).HasColumnName<string>("LUGAR_PRODUCIR").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry010, int?>>)(e => e.NoAnulacion)).HasColumnName<int?>("NO_ANULACION");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Cpry010, short>>)(e => e.NoColectora)).HasColumnName<short>("NO_COLECTORA");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Cpry010, short>>)(e => e.NoPrensa)).HasColumnName<short>("NO_PRENSA");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry010, long?>>)(e => e.NuevaCtd)).HasColumnName<long?>("NUEVA_CTD");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry010, DateTime?>>)(e => e.NuevaFechaEnt)).HasColumnName<DateTime?>("NUEVA_FECHA_ENT").HasColumnType<DateTime?>("datetime");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry010, int?>>)(e => e.NumeroFactura)).HasColumnName<int?>("NUMERO_FACTURA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.Obser)).HasColumnName<string>("OBSER").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.Observaciones)).HasColumnName<string>("OBSERVACIONES").HasColumnType<string>("text");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Cpry010, long>>)(e => e.Orden)).HasColumnName<long>("ORDEN");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.OrigenReoperac)).HasColumnName<string>("ORIGEN_REOPERAC").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Cpry010, short>>)(e => e.Pais)).HasColumnName<short>("PAIS");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.PartesAReope)).HasColumnName<short?>("PARTES_A_REOPE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.PasoSql)).HasColumnName<string>("PASO_SQL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PiesArteCole)).HasColumnName<Decimal?>("PIES_ARTE_COLE").HasColumnType<Decimal?>("decimal(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PiesArtePren)).HasColumnName<Decimal?>("PIES_ARTE_PREN").HasColumnType<Decimal?>("decimal(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PiesColect)).HasColumnName<Decimal?>("PIES_COLECT").HasColumnType<Decimal?>("decimal(16, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PiesFotoCole)).HasColumnName<Decimal?>("PIES_FOTO_COLE").HasColumnType<Decimal?>("decimal(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PiesFotoPren)).HasColumnName<Decimal?>("PIES_FOTO_PREN").HasColumnType<Decimal?>("decimal(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PiesPlanCole)).HasColumnName<Decimal?>("PIES_PLAN_COLE").HasColumnType<Decimal?>("decimal(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PiesPlanPren)).HasColumnName<Decimal?>("PIES_PLAN_PREN").HasColumnType<Decimal?>("decimal(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PiesPrensCole)).HasColumnName<Decimal?>("PIES_PRENS_COLE").HasColumnType<Decimal?>("decimal(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PiesPrensPren)).HasColumnName<Decimal?>("PIES_PRENS_PREN").HasColumnType<Decimal?>("decimal(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PiesPrensa)).HasColumnName<Decimal?>("PIES_PRENSA").HasColumnType<Decimal?>("decimal(16, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PrecioLista)).HasColumnName<Decimal?>("PRECIO_LISTA").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.PrecioVenta)).HasColumnName<Decimal?>("PRECIO_VENTA").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.ProduInmediata)).HasColumnName<string>("PRODU_INMEDIATA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.Programada)).HasColumnName<string>("PROGRAMADA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.Remanente)).HasColumnName<string>("REMANENTE").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.ReopSolicPor)).HasColumnName<short?>("REOP_SOLIC_POR");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry010, int?>>)(e => e.ReoperacionNo)).HasColumnName<int?>("REOPERACION_NO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.ResponsaReoper)).HasColumnName<string>("RESPONSA_REOPER").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.Rlista)).HasColumnName<Decimal?>("RLISTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.Rpreciolista)).HasColumnName<Decimal?>("RPRECIOLISTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.Rprecioventa)).HasColumnName<Decimal?>("RPRECIOVENTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.Rventa)).HasColumnName<Decimal?>("RVENTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.StatusDelJob)).HasColumnName<string>("STATUS_DEL_JOB").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.SupervVentas)).IsRequired(true).HasColumnName<string>("SUPERV_VENTAS").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry010, short?>>)(e => e.TipoCaja)).HasColumnName<short?>("TIPO_CAJA");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Cpry010, short>>)(e => e.TipoOrden)).HasColumnName<short>("TIPO_ORDEN");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.TipoProduccion)).HasColumnName<string>("TIPO_PRODUCCION").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.UsuarioRet)).HasColumnName<string>("USUARIO_RET").HasMaxLength(20).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry010, string>>)(e => e.Vendedor)).IsRequired(true).HasColumnName<string>("VENDEDOR").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry010, Decimal?>>)(e => e.Venta)).HasColumnName<Decimal?>("VENTA").HasColumnType<Decimal?>("decimal(16, 2)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.Cpry012>((Action<EntityTypeBuilder<AppService.Core.Entities.Cpry012>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.Cpry012>("CPRY012");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.Cpry012, object>>)(e => (object)e.Orden)).HasName<AppService.Core.Entities.Cpry012>("IX_CPRY012");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Adelantada)).HasColumnName<string>("ADELANTADA").HasMaxLength(1).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.An8entregar)).HasColumnName<Decimal?>("AN8ENTREGAR").HasColumnType<Decimal?>("decimal(14, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.An8facturar)).HasColumnName<Decimal?>("AN8FACTURAR").HasColumnType<Decimal?>("decimal(14, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.AnchosPts1)).HasColumnName<string>("ANCHOS_PTS1").HasMaxLength(5).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.AnchosPts2)).HasColumnName<string>("ANCHOS_PTS2").HasMaxLength(5).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.AnchosRod1)).HasColumnName<string>("ANCHOS_ROD1").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.AnchosRod2)).HasColumnName<string>("ANCHOS_ROD2").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Cpry012, int>>)(e => e.Anticipo)).HasColumnName<int>("ANTICIPO");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.AnticipoJde)).HasColumnName<Decimal?>("ANTICIPO_JDE").HasColumnType<Decimal?>("decimal(10, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Anulada)).HasColumnName<string>("ANULADA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.AutorizaAde)).HasColumnName<string>("AUTORIZA_ADE").HasMaxLength(20).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.BsMcFinan)).HasColumnName<Decimal?>("BS_MC_FINAN").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.BsMcFinanE)).HasColumnName<Decimal?>("BS_MC_FINAN_E").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.BsMcFinansc)).HasColumnName<Decimal?>("BS_MC_FINANSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.BsMcFinansce)).HasColumnName<Decimal?>("BS_MC_FINANSCE").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.BsMcPapel)).HasColumnName<Decimal?>("BS_MC_PAPEL").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.BsMcPapelE)).HasColumnName<Decimal?>("BS_MC_PAPEL_E").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.BsMcPapelsc)).HasColumnName<Decimal?>("BS_MC_PAPELSC").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.BsMcPapelsce)).HasColumnName<Decimal?>("BS_MC_PAPELSCE").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.CambioCompo)).HasColumnName<Decimal?>("CAMBIO_COMPO").HasColumnType<Decimal?>("decimal(4, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry012, long?>>)(e => e.CantAProducir)).HasColumnName<long?>("CANT_A_PRODUCIR");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry012, int?>>)(e => e.CantCajas)).HasColumnName<int?>("CANT_CAJAS");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry012, long?>>)(e => e.CantFacturada)).HasColumnName<long?>("CANT_FACTURADA");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry012, long?>>)(e => e.CantOrdenada)).HasColumnName<long?>("CANT_ORDENADA");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry012, long?>>)(e => e.CantProducida)).HasColumnName<long?>("CANT_PRODUCIDA");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry012, long?>>)(e => e.CantProgramada)).HasColumnName<long?>("CANT_PROGRAMADA");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry012, int?>>)(e => e.CantXCajas)).HasColumnName<int?>("CANT_X_CAJAS");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry012, int?>>)(e => e.CantXPaq)).HasColumnName<int?>("CANT_X_PAQ");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.CantidadRodada)).HasColumnName<Decimal?>("CANTIDAD_RODADA").HasColumnType<Decimal?>("decimal(14, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.ClaseOrden)).HasColumnName<string>("CLASE_ORDEN").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry012, int?>>)(e => e.Cliente)).HasColumnName<int?>("CLIENTE");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.CodAplicacion)).HasColumnName<short?>("COD_APLICACION").HasDefaultValueSql<short?>("((0))");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.CodBacklogRet)).HasColumnName<short?>("COD_BACKLOG_RET");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.CodProducto)).IsRequired(true).HasColumnName<string>("COD_PRODUCTO").HasMaxLength(12).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.CodTeleop)).HasColumnName<string>("COD_TELEOP").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.Comision)).HasColumnName<Decimal?>("COMISION").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.CondPago)).HasColumnName<short?>("COND_PAGO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.CondicionProdu)).HasColumnName<string>("CONDICION_PRODU").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry012, int?>>)(e => e.ConsArchivo)).HasColumnName<int?>("CONS_ARCHIVO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Cortado)).HasColumnName<string>("CORTADO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Cotizacion)).IsRequired(true).HasColumnName<string>("COTIZACION").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry012, long?>>)(e => e.CtdEntregada)).HasColumnName<long?>("CTD_ENTREGADA");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry012, long?>>)(e => e.CtdNc)).HasColumnName<long?>("CTD_NC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.CteEntregar)).HasColumnName<string>("CTE_ENTREGAR").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.CteFacturar)).HasColumnName<string>("CTE_FACTURAR").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.CuarTintaFte)).HasColumnName<string>("CUAR_TINTA_FTE").HasMaxLength(6).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.DescProducto)).HasColumnName<string>("DESC_PRODUCTO").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.DirecEntregar)).HasColumnName<string>("DIREC_ENTREGAR").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.DirecEntregar2)).HasColumnName<string>("DIREC_ENTREGAR2").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.DirecEntregar3)).HasColumnName<string>("DIREC_ENTREGAR3").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.DirecFacturar)).HasColumnName<string>("DIREC_FACTURAR").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.DirecFacturar2)).HasColumnName<string>("DIREC_FACTURAR2").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.DirecFacturar3)).HasColumnName<string>("DIREC_FACTURAR3").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Doblez)).HasColumnName<string>("DOBLEZ").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.EmbReverso)).HasColumnName<string>("EMB_REVERSO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.EmpacarEn)).HasColumnName<string>("EMPACAR_EN").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.EngomaCarbCol)).HasColumnName<string>("ENGOMA_CARB_COL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.EngomaCarbPre)).HasColumnName<string>("ENGOMA_CARB_PRE").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Estado)).HasColumnName<string>("ESTADO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.EstadoEntregar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.EstadoFacturar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Excepcion)).HasColumnName<string>("EXCEPCION").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.FacturaDolar)).HasColumnName<string>("FACTURA_DOLAR").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.FamiliaProduct)).HasColumnName<string>("FAMILIA_PRODUCT").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry012, DateTime?>>)(e => e.FecCierreOrd)).HasColumnName<DateTime?>("FEC_CIERRE_ORD").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry012, DateTime?>>)(e => e.FecComproClte)).HasColumnName<DateTime?>("FEC_COMPRO_CLTE").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry012, DateTime?>>)(e => e.FecCreditos)).HasColumnName<DateTime?>("FEC_CREDITOS").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry012, DateTime?>>)(e => e.FecProgramada)).HasColumnName<DateTime?>("FEC_PROGRAMADA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry012, DateTime?>>)(e => e.FecRecibPlant)).HasColumnName<DateTime?>("FEC_RECIB_PLANT").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Cpry012, DateTime>>)(e => e.FecRegVentas)).HasColumnName<DateTime>("FEC_REG_VENTAS").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry012, DateTime?>>)(e => e.FecTransmision)).HasColumnName<DateTime?>("FEC_TRANSMISION").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Cpry012, DateTime>>)(e => e.FechaArchivo)).HasColumnName<DateTime>("FECHA_ARCHIVO").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry012, DateTime?>>)(e => e.FechaCalculo)).HasColumnName<DateTime?>("FECHA_CALCULO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Cpry012, DateTime?>>)(e => e.FechaDolar)).HasColumnName<DateTime?>("FECHA_DOLAR").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Fiscal)).HasColumnName<string>("FISCAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.FlagActivo)).HasColumnName<string>("FLAG_ACTIVO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.FlagFactura)).HasColumnName<string>("FLAG_FACTURA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.FlagProdInter)).HasColumnName<string>("FLAG_PROD_INTER").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.FlagSoportev)).HasColumnName<string>("FLAG_SOPORTEV").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.FlagV19)).HasColumnName<string>("FLAG_V19").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry012, int?>>)(e => e.FormasUndFact)).HasColumnName<int?>("FORMAS_UND_FACT");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.GomaRegPtes)).HasColumnName<string>("GOMA_REG_PTES").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry012, int?>>)(e => e.IdCombinada)).HasDefaultValueSql<int?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.IdDirEntregar)).HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.IdDirFacturar)).HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.IdSolicitud)).HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.IdSolicitud2)).HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.IdSolicitudCosto)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry012, int?>>)(e => e.Idcalendar)).HasColumnName<int?>("IDCALENDAR").HasDefaultValueSql<int?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Idcalendar2)).IsRequired(true).HasColumnName<string>("IDCALENDAR2").HasMaxLength(14).IsUnicode(false).HasDefaultValueSql<string>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.Impout)).HasColumnName<Decimal?>("IMPOUT").HasColumnType<Decimal?>("decimal(1, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Impresion)).HasColumnName<string>("IMPRESION").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.ImprimeDol)).HasColumnName<string>("IMPRIME_DOL").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("('X')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.Impvar)).HasColumnName<Decimal?>("IMPVAR").HasColumnType<Decimal?>("decimal(1, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.InstFacturar)).HasColumnName<string>("INST_FACTURAR").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Cpry012, short>>)(e => e.LineaAnt)).HasColumnName<short>("LINEA_ANT");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.LineaAntJde)).HasColumnName<Decimal?>("LINEA_ANT_JDE").HasColumnType<Decimal?>("decimal(2, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.LineaIncoming)).HasColumnName<short?>("LINEA_INCOMING");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.LineaProducto)).HasColumnName<string>("LINEA_PRODUCTO").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.ListaTotDolar)).HasColumnName<Decimal?>("LISTA_TOT_DOLAR").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.ListaUnitDol)).HasColumnName<Decimal?>("LISTA_UNIT_DOL").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.LugarEnviar)).HasColumnName<string>("LUGAR_ENVIAR").HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.LugarProducir)).HasColumnName<string>("LUGAR_PRODUCIR").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry012, int?>>)(e => e.MedidaBase)).HasColumnName<int?>("MEDIDA_BASE");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry012, int?>>)(e => e.MedidaVariable)).HasColumnName<int?>("MEDIDA_VARIABLE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.MunicipioEntregar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.MunicipioFacturar)).HasMaxLength(2);
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Cpry012, int>>)(e => e.NoTransmision)).HasColumnName<int>("NO_TRANSMISION");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Nocalculamc)).HasColumnName<string>("NOCALCULAMC").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.NombreCliente)).IsRequired(true).HasColumnName<string>("NOMBRE_CLIENTE").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.NombreProducto)).HasColumnName<string>("NOMBRE_PRODUCTO").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.NuTintasFrent)).HasColumnName<short?>("NU_TINTAS_FRENT");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.NuTintasResp)).HasColumnName<short?>("NU_TINTAS_RESP");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Cpry012, int?>>)(e => e.NumeroTiras)).HasColumnName<int?>("NUMERO_TIRAS");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Cpry012, long>>)(e => e.Orden)).HasColumnName<long>("ORDEN");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Cpry012, long?>>)(e => e.OrdenAnterior)).HasColumnName<long?>("ORDEN_ANTERIOR");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.OrdenComb)).HasColumnName<string>("ORDEN_COMB").HasMaxLength(40).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PCobranza)).HasColumnName<Decimal?>("P_COBRANZA").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.POverger)).HasColumnName<Decimal?>("P_OVERGER").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.POverride)).HasColumnName<Decimal?>("P_OVERRIDE").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.POverrideCg)).HasColumnName<Decimal?>("P_OVERRIDE_CG").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.POverrideG)).HasColumnName<Decimal?>("P_OVERRIDE_G").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.POverrideGo)).HasColumnName<Decimal?>("P_OVERRIDE_GO").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.Pais)).HasColumnName<short?>("PAIS");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.PartesFormula)).HasColumnName<short?>("PARTES_FORMULA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PartesTiras)).HasColumnName<string>("PARTES_TIRAS").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.Cpry012, bool?>>)(e => e.Plantilla)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PoncMargDer)).HasColumnName<string>("PONC_MARG_DER").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PoncMargIzq)).HasColumnName<string>("PONC_MARG_IZQ").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PoncheEsp)).HasColumnName<string>("PONCHE_ESP").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcCom)).HasColumnName<Decimal?>("PORC_COM").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcComRegulada)).HasColumnType<Decimal?>("numeric(5, 3)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal>>)(e => e.PorcMc)).HasColumnName<Decimal>("PORC_MC").HasColumnType<Decimal>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcMcFinan)).HasColumnName<Decimal?>("PORC_MC_FINAN").HasColumnType<Decimal?>("decimal(6, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcMcFinanE)).HasColumnName<Decimal?>("PORC_MC_FINAN_E").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcMcFinansc)).HasColumnName<Decimal?>("PORC_MC_FINANSC").HasColumnType<Decimal?>("decimal(6, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcMcMinimo)).HasColumnType<Decimal?>("numeric(5, 3)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcMcPapel)).HasColumnName<Decimal?>("PORC_MC_PAPEL").HasColumnType<Decimal?>("decimal(6, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcMcPapelE)).HasColumnName<Decimal?>("PORC_MC_PAPEL_E").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcMcPapelsc)).HasColumnName<Decimal?>("PORC_MC_PAPELSC").HasColumnType<Decimal?>("decimal(6, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcMcfinansce)).HasColumnName<Decimal?>("PORC_MCFINANSCE").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcMcpapelsce)).HasColumnName<Decimal?>("PORC_MCPAPELSCE").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PorcRespSocial)).HasColumnType<Decimal?>("numeric(5, 3)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PosTirasF)).HasColumnName<string>("POS_TIRAS_F").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PosTirasR)).HasColumnName<string>("POS_TIRAS_R").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PrecioLista)).HasColumnName<Decimal?>("PRECIO_LISTA").HasColumnType<Decimal?>("decimal(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.PrecioVenta)).HasColumnName<Decimal?>("PRECIO_VENTA").HasColumnType<Decimal?>("decimal(14, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PrefColeEsp)).HasColumnName<string>("PREF_COLE_ESP").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PrefColeStd)).HasColumnName<string>("PREF_COLE_STD").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PrefPrenEsp)).HasColumnName<string>("PREF_PREN_ESP").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PrefPrenStd)).HasColumnName<string>("PREF_PREN_STD").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PrimTintaFte)).HasColumnName<string>("PRIM_TINTA_FTE").HasMaxLength(6).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.PrimTintaResp)).HasColumnName<string>("PRIM_TINTA_RESP").HasMaxLength(6).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.QuintTintaFte)).HasColumnName<string>("QUINT_TINTA_FTE").HasMaxLength(6).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RbsMcFinan)).HasColumnName<Decimal?>("RBS_MC_FINAN").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RbsMcFinansc)).HasColumnName<Decimal?>("RBS_MC_FINANSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RbsMcPapel)).HasColumnName<Decimal?>("RBS_MC_PAPEL").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RbsMcPapelsc)).HasColumnName<Decimal?>("RBS_MC_PAPELSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.Rcomision)).HasColumnName<Decimal?>("RCOMISION").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.RecalcularMargen)).HasMaxLength(1).HasDefaultValueSql<string>("('')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.Refinado)).HasColumnName<Decimal?>("REFINADO").HasColumnType<Decimal?>("decimal(4, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.RefinadoEn)).HasColumnName<string>("REFINADO_EN").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Regular)).HasColumnName<string>("REGULAR").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.RifEntregar)).HasColumnName<string>("RIF_ENTREGAR").HasMaxLength(12).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.RifFacturar)).HasColumnName<string>("RIF_FACTURAR").HasMaxLength(12).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.RifImprimir)).HasColumnName<string>("RIF_IMPRIMIR").HasMaxLength(12).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RollosCtd1)).HasColumnName<Decimal?>("ROLLOS_CTD1").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RollosCtd2)).HasColumnName<Decimal?>("ROLLOS_CTD2").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RollosCtd3)).HasColumnName<Decimal?>("ROLLOS_CTD3").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.RollosPts1)).HasColumnName<string>("ROLLOS_PTS1").HasMaxLength(5).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.RollosPts2)).HasColumnName<string>("ROLLOS_PTS2").HasMaxLength(5).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.RollosPts3)).HasColumnName<string>("ROLLOS_PTS3").HasMaxLength(5).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.RollosRod1)).HasColumnName<short?>("ROLLOS_ROD1");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.RollosRod2)).HasColumnName<short?>("ROLLOS_ROD2");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.RollosRod3)).HasColumnName<short?>("ROLLOS_ROD3");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RprecioLista)).HasColumnName<Decimal?>("RPRECIO_LISTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RprecioVenta)).HasColumnName<Decimal?>("RPRECIO_VENTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.Rtasa)).HasColumnName<Decimal?>("RTASA").HasColumnType<Decimal?>("decimal(6, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RtotalLista)).HasColumnName<Decimal?>("RTOTAL_LISTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RtotalListaEx)).HasColumnName<Decimal?>("RTOTAL_LISTA_EX").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RtotalVenta)).HasColumnName<Decimal?>("RTOTAL_VENTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.RtotalVentaEx)).HasColumnName<Decimal?>("RTOTAL_VENTA_EX").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.SalidaPreCab)).HasColumnName<string>("SALIDA_PRE_CAB").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.SalidaPrePie)).HasColumnName<string>("SALIDA_PRE_PIE").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.SegTintaFte)).HasColumnName<string>("SEG_TINTA_FTE").HasMaxLength(6).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.SegTintaResp)).HasColumnName<string>("SEG_TINTA_RESP").HasMaxLength(6).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.SexTintaFte)).HasColumnName<string>("SEX_TINTA_FTE").HasMaxLength(6).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.SiColetilla)).HasColumnName<string>("SI_COLETILLA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("('X')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.SiDolares)).HasColumnName<string>("SI_DOLARES").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("('X')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.SiIndexado)).HasColumnName<string>("SI_INDEXADO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Solido)).HasColumnName<string>("SOLIDO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.StatusOrden)).HasColumnName<string>("STATUS_ORDEN").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Supervisor)).HasColumnName<string>("SUPERVISOR").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Cpry012, short?>>)(e => e.Tabla)).HasColumnName<short?>("TABLA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.TalonExtra)).HasColumnName<string>("TALON_EXTRA").HasMaxLength(8).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.Tasa)).HasColumnName<Decimal?>("TASA").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.TercTintaFte)).HasColumnName<string>("TERC_TINTA_FTE").HasMaxLength(6).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.TercTintaResp)).HasColumnName<string>("TERC_TINTA_RESP").HasMaxLength(6).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.TipoCaja)).HasColumnName<string>("TIPO_CAJA").HasMaxLength(6).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.TipoEmpaque)).HasColumnName<string>("TIPO_EMPAQUE").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.TipoOrden)).IsRequired(true).HasColumnName<string>("TIPO_ORDEN").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.TipoProducto)).HasColumnName<string>("TIPO_PRODUCTO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.TotalLista)).HasColumnName<Decimal?>("TOTAL_LISTA").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.TotalListaExt)).HasColumnName<Decimal?>("TOTAL_LISTA_EXT").HasColumnType<Decimal?>("decimal(12, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.TotalVenta)).HasColumnName<Decimal?>("TOTAL_VENTA").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.TotalVentaExt)).HasColumnName<Decimal?>("TOTAL_VENTA_EXT").HasColumnType<Decimal?>("decimal(12, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.TranfTapeEf)).HasColumnName<string>("TRANF_TAPE_EF").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.TranfTapePerm)).HasColumnName<string>("TRANF_TAPE_PERM").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.TranfTapeRem)).HasColumnName<string>("TRANF_TAPE_REM").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Vendedor)).HasColumnName<string>("VENDEDOR").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.VentaTotDolar)).HasColumnName<Decimal?>("VENTA_TOT_DOLAR").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Cpry012, Decimal?>>)(e => e.VentaUnitDol)).HasColumnName<Decimal?>("VENTA_UNIT_DOL").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.VinetaImpresa)).IsRequired(true).HasColumnName<string>("VINETA_IMPRESA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Web)).HasColumnName<string>("WEB").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Cpry012, string>>)(e => e.Ws)).HasColumnName<string>("WS").HasMaxLength(30).IsUnicode(false).HasDefaultValueSql<string>("('HOST_NAME()')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CreAdjuntoSolicitudCredito>((Action<EntityTypeBuilder<AppService.Core.Entities.CreAdjuntoSolicitudCredito>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CreAdjuntoSolicitudCredito, object>>)(e => (object)e.SolicitudDeCredito));
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreAdjuntoSolicitudCredito, Decimal>>)(e => e.SolicitudDeCredito)).HasColumnType<Decimal>("numeric(18, 0)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CreClientesExcepcion>((Action<EntityTypeBuilder<AppService.Core.Entities.CreClientesExcepcion>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CreClientesExcepcion, object>>)(e => e.CodCliente)).HasName<AppService.Core.Entities.CreClientesExcepcion>("IX_CreClientesExcepcion");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreClientesExcepcion, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreClientesExcepcion, string>>)(e => e.CodCliente)).IsRequired(true).HasColumnName<string>("COD_CLIENTE").HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreClientesExcepcion, string>>)(e => e.Excepcion)).HasColumnName<string>("EXCEPCION").HasMaxLength(1000);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CreCotizacionDocumento>((Action<EntityTypeBuilder<AppService.Core.Entities.CreCotizacionDocumento>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CreCotizacionDocumento, object>>)(e => e.Cotizacion)).HasName<AppService.Core.Entities.CreCotizacionDocumento>("IX_CreCotizacionDocumento");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CreCotizacionDocumento, object>>)(e => (object)e.Documento)).HasName<AppService.Core.Entities.CreCotizacionDocumento>("IX_CreCotizacionDocumento_1");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreCotizacionDocumento, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreCotizacionDocumento, string>>)(e => e.Cotizacion)).HasMaxLength(13);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreCotizacionDocumento, Decimal?>>)(e => e.Documento)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreCotizacionDocumento, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreCotizacionDocumento, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreCotizacionDocumento, string>>)(e => e.UsuarioCreacion)).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreCotizacionDocumento, string>>)(e => e.UsuarioModificacion)).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CreEvaluacionCredito>((Action<EntityTypeBuilder<AppService.Core.Entities.CreEvaluacionCredito>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CreEvaluacionCredito, object>>)(e => (object)e.IdEvaluacion));
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreEvaluacionCredito, Decimal>>)(e => e.IdEvaluacion)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreEvaluacionCredito, string>>)(e => e.CodCliente)).HasColumnName<string>("Cod_Cliente").HasMaxLength(10);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreEvaluacionCredito, DateTime?>>)(e => e.FechaRegistro)).HasColumnType<DateTime?>("smalldatetime").HasDefaultValueSql<DateTime?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreEvaluacionCredito, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreEvaluacionCredito, Decimal?>>)(e => e.IdSolicitudAnalisis)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreEvaluacionCredito, Decimal?>>)(e => e.Monto)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreEvaluacionCredito, Decimal?>>)(e => e.Rmonto)).HasColumnName<Decimal?>("RMonto").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreEvaluacionCredito, string>>)(e => e.Usuario)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias>((Action<EntityTypeBuilder<AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias, object>>)(e => new
                {
                    Oficina = e.Oficina,
                    Usuario = e.Usuario,
                    MontoDesde = e.MontoDesde,
                    MontoHasta = e.MontoHasta
                })).HasName<AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias>("IX_CreRangoAprobacionOficinaUsuarioMontoDias").IsUnique(true);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias, Decimal>>)(e => e.MontoDesde)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias, Decimal>>)(e => e.MontoHasta)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias, Decimal?>>)(e => e.RmontoDesde)).HasColumnName<Decimal?>("RMontoDesde").HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias, Decimal?>>)(e => e.RmontoHasta)).HasColumnName<Decimal?>("RMontoHasta").HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreRangoAprobacionOficinaUsuarioMontoDias, string>>)(e => e.Usuario)).IsRequired(true).HasMaxLength(40).IsUnicode(false);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CreResponsableAprobarExcepcion>((Action<EntityTypeBuilder<AppService.Core.Entities.CreResponsableAprobarExcepcion>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CreResponsableAprobarExcepcion, object>>)(e => e.Usuario)).HasName<AppService.Core.Entities.CreResponsableAprobarExcepcion>("IX_CreResponsableAprobarExcepcion");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreResponsableAprobarExcepcion, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreResponsableAprobarExcepcion, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreResponsableAprobarExcepcion, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreResponsableAprobarExcepcion, string>>)(e => e.Usuario)).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreResponsableAprobarExcepcion, string>>)(e => e.UsuarioCreacion)).HasMaxLength(40);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreResponsableAprobarExcepcion, DateTime?>>)(e => e.UsuarioModificacion)).HasColumnType<DateTime?>("smalldatetime");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CreSolicitudDeCredito>((Action<EntityTypeBuilder<AppService.Core.Entities.CreSolicitudDeCredito>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, object>>)(e => (object)e.Aprobada)).HasName<AppService.Core.Entities.CreSolicitudDeCredito>("IX_CreSolicitudDeCredito_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, object>>)(e => e.Cotizacion)).HasName<AppService.Core.Entities.CreSolicitudDeCredito>("IX_CreSolicitudDeCredito");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, object>>)(e => (object)e.SolicitudDeCredito)).HasName<AppService.Core.Entities.CreSolicitudDeCredito>("IX_CreSolicitudDeCredito_2").IsUnique(true);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, bool?>>)(e => e.Aprobada)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, string>>)(e => e.CodCliente)).HasColumnName<string>("COD_CLIENTE").HasMaxLength(10).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, string>>)(e => e.Cotizacion)).HasMaxLength(13);
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, bool?>>)(e => e.EvaluadaAdministradora)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, DateTime?>>)(e => e.FechaAprobacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, DateTime?>>)(e => e.FechaRechazo)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, DateTime?>>)(e => e.FechaRegistro)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, Decimal?>>)(e => e.IdSolicitudAnalisisAprobacion)).HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, Decimal?>>)(e => e.MontoSolicitado)).HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, Decimal?>>)(e => e.NroExcepcion)).HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, string>>)(e => e.ObservacionesCredito)).HasDefaultValueSql<string>("('')");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, bool?>>)(e => e.Rechazado)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, Decimal?>>)(e => e.RmontoSolicitado)).HasColumnName<Decimal?>("RMontoSolicitado").HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, Decimal>>)(e => e.SolicitudDeCredito)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, Decimal?>>)(e => e.UltimoIdSolicitudAnalisis)).HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, string>>)(e => e.UsuarioAprobador)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, string>>)(e => e.UsuarioAprobo)).HasMaxLength(50).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCredito, string>>)(e => e.UsuarioRechazo)).HasMaxLength(50).HasDefaultValueSql<string>("('')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CreSolicitudDeCreditoHistorico>((Action<EntityTypeBuilder<AppService.Core.Entities.CreSolicitudDeCreditoHistorico>>)(entity =>
            {
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, bool?>>)(e => e.Aprobada)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, string>>)(e => e.CodCliente)).HasColumnName<string>("COD_CLIENTE").HasMaxLength(10).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, string>>)(e => e.Cotizacion)).HasMaxLength(13);
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, bool?>>)(e => e.EvaluadaAdministradora)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, DateTime?>>)(e => e.FechaAprobacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, DateTime?>>)(e => e.FechaRechazo)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, DateTime?>>)(e => e.FechaRegistro)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, Decimal?>>)(e => e.IdSolicitudAnalisisAprobacion)).HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, Decimal?>>)(e => e.MontoSolicitado)).HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, Decimal?>>)(e => e.NroExcepcion)).HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, string>>)(e => e.ObservacionesCredito)).HasDefaultValueSql<string>("('')");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, bool?>>)(e => e.Rechazado)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, Decimal?>>)(e => e.RmontoSolicitado)).HasColumnName<Decimal?>("RMontoSolicitado").HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, Decimal>>)(e => e.SolicitudDeCredito)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, Decimal?>>)(e => e.UltimoIdSolicitudAnalisis)).HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, string>>)(e => e.UsuarioAprobador)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, string>>)(e => e.UsuarioAprobo)).HasMaxLength(50).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudDeCreditoHistorico, string>>)(e => e.UsuarioRechazo)).HasMaxLength(50).HasDefaultValueSql<string>("('')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CreSolicitudExcepcion>((Action<EntityTypeBuilder<AppService.Core.Entities.CreSolicitudExcepcion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, object>>)(e => (object)e.SolicitudDeCredito)).HasName("PK_CreSolicitudExcepcion_1");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, Decimal>>)(e => e.SolicitudDeCredito)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, DateTime?>>)(e => e.FechaAprobacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, DateTime?>>)(e => e.FechaCompromiso)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, DateTime?>>)(e => e.FechaRechazo)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, Decimal?>>)(e => e.MontoPagado)).HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, string>>)(e => e.NombreImagen)).HasMaxLength(500);
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, bool?>>)(e => e.SolicitudCerrada)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, bool?>>)(e => e.SolicitudExcepcionPorPago)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, string>>)(e => e.UsuarioAprobador)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, string>>)(e => e.UsuarioCreacion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcion, string>>)(e => e.UsuarioRechazo)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CreSolicitudExcepcionHistorico>((Action<EntityTypeBuilder<AppService.Core.Entities.CreSolicitudExcepcionHistorico>>)(entity =>
            {
                entity.HasNoKey();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, DateTime?>>)(e => e.FechaAprobacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, DateTime?>>)(e => e.FechaCompromiso)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, DateTime?>>)(e => e.FechaRechazo)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, Decimal?>>)(e => e.MontoPagado)).HasColumnType<Decimal?>("numeric(18, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, string>>)(e => e.NombreImagen)).HasMaxLength(500);
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, bool?>>)(e => e.SolicitudCerrada)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, Decimal>>)(e => e.SolicitudDeCredito)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, bool?>>)(e => e.SolicitudExcepcionPorPago)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, string>>)(e => e.UsuarioAprobador)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, string>>)(e => e.UsuarioCreacion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CreSolicitudExcepcionHistorico, string>>)(e => e.UsuarioRechazo)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CrmEncuestaCliente>((Action<EntityTypeBuilder<AppService.Core.Entities.CrmEncuestaCliente>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CrmEncuestaCliente, object>>)(e => (object)e.IdSatisfaccion));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CrmEncuestaCliente, object>>)(e => new
                {
                    IdCliente = e.IdCliente,
                    Ano = e.Ano,
                    Mes = e.Mes
                })).HasName<AppService.Core.Entities.CrmEncuestaCliente>("IX_CrmEncuestaCliente");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CrmEncuestaCliente, Decimal>>)(e => e.IdSatisfaccion)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CrmEncuestaCliente, DateTime>>)(e => e.Fecha)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmEncuestaCliente, string>>)(e => e.IdCliente)).IsRequired(true).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmEncuestaCliente, string>>)(e => e.IdConsultor)).IsRequired(true).HasMaxLength(4).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmEncuestaCliente, string>>)(e => e.Observaciones)).IsRequired(true).HasMaxLength(500);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmEncuestaCliente, string>>)(e => e.Usuario)).IsRequired(true).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CrmMtrCes>((Action<EntityTypeBuilder<AppService.Core.Entities.CrmMtrCes>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CrmMtrCes, object>>)(e => (object)e.PuntosCes));
                entity.Property<short>((Expression<Func<AppService.Core.Entities.CrmMtrCes, short>>)(e => e.PuntosCes)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmMtrCes, string>>)(e => e.NombreCes)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CrmMtrCs>((Action<EntityTypeBuilder<AppService.Core.Entities.CrmMtrCs>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CrmMtrCs, object>>)(e => (object)e.PuntosCs));
                entity.Property<short>((Expression<Func<AppService.Core.Entities.CrmMtrCs, short>>)(e => e.PuntosCs)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmMtrCs, string>>)(e => e.NombreCs)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CrmMtrEstado>((Action<EntityTypeBuilder<AppService.Core.Entities.CrmMtrEstado>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CrmMtrEstado, object>>)(e => (object)e.IdEstado));
                entity.Property<short>((Expression<Func<AppService.Core.Entities.CrmMtrEstado, short>>)(e => e.IdEstado)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmMtrEstado, string>>)(e => e.NombreEstado)).IsRequired(true).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CrmMtrNps>((Action<EntityTypeBuilder<AppService.Core.Entities.CrmMtrNps>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CrmMtrNps, object>>)(e => (object)e.PuntosNps));
                entity.Property<short>((Expression<Func<AppService.Core.Entities.CrmMtrNps, short>>)(e => e.PuntosNps)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmMtrNps, string>>)(e => e.NombreNps)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CrmMtrSeguimiento>((Action<EntityTypeBuilder<AppService.Core.Entities.CrmMtrSeguimiento>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CrmMtrSeguimiento, object>>)(e => (object)e.IdTipoSegumiento));
                entity.Property<short>((Expression<Func<AppService.Core.Entities.CrmMtrSeguimiento, short>>)(e => e.IdTipoSegumiento)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmMtrSeguimiento, string>>)(e => e.NombreSeguimiento)).IsRequired(true).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CrmNotificacionActividades>((Action<EntityTypeBuilder<AppService.Core.Entities.CrmNotificacionActividades>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CrmNotificacionActividades, object>>)(e => (object)e.IdNotificacion));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CrmNotificacionActividades, object>>)(e => (object)e.IdSeguimiento)).HasName<AppService.Core.Entities.CrmNotificacionActividades>("IX_CrmNotificacionActividades").IsUnique(true);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.CrmNotificacionActividades, Decimal>>)(e => e.IdNotificacion)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmNotificacionActividades, string>>)(e => e.Cc)).IsRequired(true).HasColumnName<string>("CC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmNotificacionActividades, string>>)(e => e.Cuerpo)).IsRequired(true);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CrmNotificacionActividades, DateTime>>)(e => e.FechaHoraEnvio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmNotificacionActividades, string>>)(e => e.Para)).IsRequired(true).HasMaxLength(500);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CrmSeguimiento>((Action<EntityTypeBuilder<AppService.Core.Entities.CrmSeguimiento>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CrmSeguimiento, object>>)(e => (object)e.IdSeguimiento));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.CrmSeguimiento, object>>)(e => e.IdCliente)).HasName<AppService.Core.Entities.CrmSeguimiento>("IX_CrmSeguimiento");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmSeguimiento, string>>)(e => e.Comentarios)).IsRequired(true);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.CrmSeguimiento, DateTime?>>)(e => e.FechaHoraFin)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CrmSeguimiento, DateTime>>)(e => e.FechaHoraInicio)).HasColumnType<DateTime>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.CrmSeguimiento, DateTime>>)(e => e.FechaUpdate)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmSeguimiento, string>>)(e => e.IdCliente)).IsRequired(true).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmSeguimiento, string>>)(e => e.ListaInformados)).IsRequired(true).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmSeguimiento, string>>)(e => e.UsuarioUpdate)).IsRequired(true).HasMaxLength(40);
                entity.HasOne<AppService.Core.Entities.MtrCliente>((Expression<Func<AppService.Core.Entities.CrmSeguimiento, AppService.Core.Entities.MtrCliente>>)(d => d.IdClienteNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrCliente, IEnumerable<AppService.Core.Entities.CrmSeguimiento>>>)(p => p.CrmSeguimiento)).HasForeignKey((Expression<Func<AppService.Core.Entities.CrmSeguimiento, object>>)(d => d.IdCliente)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrCliente, AppService.Core.Entities.CrmSeguimiento>("FK_CrmSeguimiento_MtrCliente");
                entity.HasOne<AppService.Core.Entities.MtrContactos>((Expression<Func<AppService.Core.Entities.CrmSeguimiento, AppService.Core.Entities.MtrContactos>>)(d => d.IdContactoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrContactos, IEnumerable<AppService.Core.Entities.CrmSeguimiento>>>)(p => p.CrmSeguimiento)).HasForeignKey((Expression<Func<AppService.Core.Entities.CrmSeguimiento, object>>)(d => (object)d.IdContacto)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrContactos, AppService.Core.Entities.CrmSeguimiento>("FK_CrmSeguimiento_MtrContactos");
                entity.HasOne<AppService.Core.Entities.CrmMtrEstado>((Expression<Func<AppService.Core.Entities.CrmSeguimiento, AppService.Core.Entities.CrmMtrEstado>>)(d => d.IdEstadoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.CrmMtrEstado, IEnumerable<AppService.Core.Entities.CrmSeguimiento>>>)(p => p.CrmSeguimiento)).HasForeignKey((Expression<Func<AppService.Core.Entities.CrmSeguimiento, object>>)(d => (object)d.IdEstado)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.CrmMtrEstado, AppService.Core.Entities.CrmSeguimiento>("FK_CrmSeguimiento_CrmMtrEstado");
                entity.HasOne<AppService.Core.Entities.CrmMtrSeguimiento>((Expression<Func<AppService.Core.Entities.CrmSeguimiento, AppService.Core.Entities.CrmMtrSeguimiento>>)(d => d.IdTipoSeguimientoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.CrmMtrSeguimiento, IEnumerable<AppService.Core.Entities.CrmSeguimiento>>>)(p => p.CrmSeguimiento)).HasForeignKey((Expression<Func<AppService.Core.Entities.CrmSeguimiento, object>>)(d => (object)d.IdTipoSeguimiento)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.CrmMtrSeguimiento, AppService.Core.Entities.CrmSeguimiento>("FK_CrmSeguimiento_CrmMtrSeguimiento");
            }));
            modelBuilder.Entity<AppService.Core.Entities.CrmVisitaDia>((Action<EntityTypeBuilder<AppService.Core.Entities.CrmVisitaDia>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CrmVisitaDia, object>>)(e => (object)e.IdDia));
                entity.Property<short>((Expression<Func<AppService.Core.Entities.CrmVisitaDia, short>>)(e => e.IdDia)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmVisitaDia, string>>)(e => e.AbreviadoDia)).IsRequired(true).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmVisitaDia, string>>)(e => e.NombreDia)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CrmVisitaFrecuencia>((Action<EntityTypeBuilder<AppService.Core.Entities.CrmVisitaFrecuencia>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CrmVisitaFrecuencia, object>>)(e => (object)e.IdFrecuencia));
                entity.Property<short>((Expression<Func<AppService.Core.Entities.CrmVisitaFrecuencia, short>>)(e => e.IdFrecuencia)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmVisitaFrecuencia, string>>)(e => e.NombreFrecuencia)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.CrmVisitaSemana>((Action<EntityTypeBuilder<AppService.Core.Entities.CrmVisitaSemana>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.CrmVisitaSemana, object>>)(e => (object)e.IdSemana));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmVisitaSemana, string>>)(e => e.AbreviadoSemana)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.CrmVisitaSemana, string>>)(e => e.NombreSemana)).IsRequired(true).HasMaxLength(100);
                entity.HasOne<AppService.Core.Entities.CrmVisitaFrecuencia>((Expression<Func<AppService.Core.Entities.CrmVisitaSemana, AppService.Core.Entities.CrmVisitaFrecuencia>>)(d => d.IdFrecuenciaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.CrmVisitaFrecuencia, IEnumerable<AppService.Core.Entities.CrmVisitaSemana>>>)(p => p.CrmVisitaSemana)).HasForeignKey((Expression<Func<AppService.Core.Entities.CrmVisitaSemana, object>>)(d => (object)d.IdFrecuencia)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.CrmVisitaFrecuencia, AppService.Core.Entities.CrmVisitaSemana>("FK_CrmVisitaSemana_CrmVisitaFrecuencia");
            }));
            modelBuilder.Entity<AppService.Core.Entities.Ctmy033>((Action<EntityTypeBuilder<AppService.Core.Entities.Ctmy033>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.Ctmy033, object>>)(e => (object)e.Orden)).HasName("CTMY033_INDEX01");
                entity.ToTable<AppService.Core.Entities.Ctmy033>("CTMY033");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Ctmy033, long>>)(e => e.Orden)).HasColumnName<long>("ORDEN").ValueGeneratedNever();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal?>>)(e => e.An8entregar)).HasColumnName<Decimal?>("AN8ENTREGAR").HasColumnType<Decimal?>("decimal(14, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal?>>)(e => e.An8facturar)).HasColumnName<Decimal?>("AN8FACTURAR").HasColumnType<Decimal?>("decimal(14, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ctmy033, int>>)(e => e.Anticipo)).HasColumnName<int>("ANTICIPO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Anulado)).IsRequired(true).HasColumnName<string>("ANULADO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.AutorizaConc)).IsRequired(true).HasColumnName<string>("AUTORIZA_CONC").HasMaxLength(40).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.AutorizaCred)).IsRequired(true).HasColumnName<string>("AUTORIZA_CRED").HasMaxLength(40).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Ciudad)).IsRequired(true).HasColumnName<string>("CIUDAD").HasMaxLength(30).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ctmy033, int>>)(e => e.Cliente)).HasColumnName<int>("CLIENTE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.CodTeleop)).IsRequired(true).HasColumnName<string>("COD_TELEOP").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Coment1)).IsRequired(true).HasColumnName<string>("COMENT1").HasMaxLength(70).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Coment2)).IsRequired(true).HasColumnName<string>("COMENT2").HasMaxLength(70).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Ctmy033, short>>)(e => e.CondicionPago)).HasColumnName<short>("CONDICION_PAGO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Contacto)).IsRequired(true).HasColumnName<string>("CONTACTO").HasMaxLength(30).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.DireccFiscal)).HasColumnName<string>("DIRECC_FISCAL").HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Direccion)).IsRequired(true).HasColumnName<string>("DIRECCION").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.DireccionEmb1)).IsRequired(true).HasColumnName<string>("DIRECCION_EMB1").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.DireccionEmb2)).IsRequired(true).HasColumnName<string>("DIRECCION_EMB2").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.DireccionEmb3)).IsRequired(true).HasColumnName<string>("DIRECCION_EMB3").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.DireccionFact1)).IsRequired(true).HasColumnName<string>("DIRECCION_FACT1").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.DireccionFact2)).IsRequired(true).HasColumnName<string>("DIRECCION_FACT2").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.DireccionFact3)).IsRequired(true).HasColumnName<string>("DIRECCION_FACT3").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.EstadoEntregar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.EstadoFacturar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.FacturaDolar)).IsRequired(true).HasColumnName<string>("FACTURA_DOLAR").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Fax)).IsRequired(true).HasColumnName<string>("FAX").HasMaxLength(8).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ctmy033, DateTime?>>)(e => e.FechaCambio)).HasColumnName<DateTime?>("FECHA_CAMBIO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ctmy033, DateTime?>>)(e => e.FechaCob)).HasColumnName<DateTime?>("FECHA_COB").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ctmy033, DateTime?>>)(e => e.FechaEntrega)).HasColumnName<DateTime?>("FECHA_ENTREGA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ctmy033, DateTime?>>)(e => e.FechaGrabacion)).HasColumnName<DateTime?>("FECHA_GRABACION").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ctmy033, DateTime?>>)(e => e.FechaPedido)).HasColumnName<DateTime?>("FECHA_PEDIDO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ctmy033, DateTime?>>)(e => e.FechaRc)).HasColumnName<DateTime?>("FECHA_RC").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ctmy033, DateTime?>>)(e => e.FechaReactiva)).HasColumnName<DateTime?>("FECHA_REACTIVA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ctmy033, DateTime?>>)(e => e.FechaTasa)).HasColumnName<DateTime?>("FECHA_TASA").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Fiscal)).IsRequired(true).HasColumnName<string>("FISCAL").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.FlagCombo)).HasColumnName<string>("FLAG_COMBO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Giro)).IsRequired(true).HasColumnName<string>("GIRO").HasMaxLength(20).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal?>>)(e => e.IdDirEntregar)).HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal?>>)(e => e.IdDirFacturar)).HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Impresa)).IsRequired(true).HasColumnName<string>("IMPRESA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Ctmy033, short>>)(e => e.LineaAnt)).HasColumnName<short>("LINEA_ANT");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.MultiplesEmb)).IsRequired(true).HasColumnName<string>("MULTIPLES_EMB").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.MunicipioEntregar)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.MunicipioFacturar)).HasMaxLength(2);
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Ctmy033, long>>)(e => e.NitEmb)).HasColumnName<long>("NIT_EMB");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Ctmy033, long>>)(e => e.NitFact)).HasColumnName<long>("NIT_FACT");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Nombre)).IsRequired(true).HasColumnName<string>("NOMBRE").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.NombreEmb)).IsRequired(true).HasColumnName<string>("NOMBRE_EMB").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.NombreFact)).IsRequired(true).HasColumnName<string>("NOMBRE_FACT").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ctmy033, DateTime?>>)(e => e.NuevaFechaEnt)).HasColumnName<DateTime?>("NUEVA_FECHA_ENT").HasColumnType<DateTime?>("datetime");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ctmy033, int>>)(e => e.NumeroPedido)).HasColumnName<int>("NUMERO_PEDIDO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Oficina)).IsRequired(true).HasColumnName<string>("OFICINA").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.OrdenCompra)).IsRequired(true).HasColumnName<string>("ORDEN_COMPRA").HasMaxLength(16).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.PasoSql)).IsRequired(true).HasColumnName<string>("PASO_SQL").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal>>)(e => e.PorcentConc)).HasColumnName<Decimal>("PORCENT_CONC").HasColumnType<Decimal>("decimal(6, 2)");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ctmy033, int>>)(e => e.Proveedor)).HasColumnName<int>("PROVEEDOR");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ctmy033, int>>)(e => e.ReciboCobro)).HasColumnName<int>("RECIBO_COBRO");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.RegTributario)).IsRequired(true).HasColumnName<string>("REG_TRIBUTARIO").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.RequiereNe)).HasColumnName<string>("REQUIERE_NE").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.RifEmb)).IsRequired(true).HasColumnName<string>("RIF_EMB").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.RifFact)).IsRequired(true).HasColumnName<string>("RIF_FACT").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal?>>)(e => e.Rtasa)).HasColumnName<Decimal?>("RTASA").HasColumnType<Decimal?>("decimal(12, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal?>>)(e => e.RtotalLista)).HasColumnName<Decimal?>("RTOTAL_LISTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal?>>)(e => e.RtotalVenta)).HasColumnName<Decimal?>("RTOTAL_VENTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.SiColetilla)).IsRequired(true).HasColumnName<string>("SI_COLETILLA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.SiDolares)).IsRequired(true).HasColumnName<string>("SI_DOLARES").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.SiIndexacion)).IsRequired(true).HasColumnName<string>("SI_INDEXACION").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.StatusOrden)).IsRequired(true).HasColumnName<string>("STATUS_ORDEN").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Supervisor)).IsRequired(true).HasColumnName<string>("SUPERVISOR").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.SupervisorConc)).IsRequired(true).HasColumnName<string>("SUPERVISOR_CONC").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal>>)(e => e.Tasa)).HasColumnName<Decimal>("TASA").HasColumnType<Decimal>("decimal(12, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Telefono)).IsRequired(true).HasColumnName<string>("TELEFONO").HasMaxLength(8).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal>>)(e => e.TotalLista)).HasColumnName<Decimal>("TOTAL_LISTA").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal>>)(e => e.TotalListaDol)).HasColumnName<Decimal>("TOTAL_LISTA_DOL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal>>)(e => e.TotalVenta)).HasColumnName<Decimal>("TOTAL_VENTA").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy033, Decimal>>)(e => e.TotalVentaDol)).HasColumnName<Decimal>("TOTAL_VENTA_DOL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Ctmy033, short>>)(e => e.UnidadFacturar)).HasColumnName<short>("UNIDAD_FACTURAR");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.UsrNuevaFecha)).HasColumnName<string>("USR_NUEVA_FECHA").HasMaxLength(20).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.VendGestion)).IsRequired(true).HasColumnName<string>("VEND_GESTION").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Vendedor)).IsRequired(true).HasColumnName<string>("VENDEDOR").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy033, string>>)(e => e.Web)).IsRequired(true).HasColumnName<string>("WEB").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.Ctmy034>((Action<EntityTypeBuilder<AppService.Core.Entities.Ctmy034>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.Ctmy034, object>>)(e => new
                {
                    Orden = e.Orden,
                    CodProducto = e.CodProducto
                })).HasName("CTMY034_INDEX01");
                entity.ToTable<AppService.Core.Entities.Ctmy034>("CTMY034");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Ctmy034, long>>)(e => e.Orden)).HasColumnName<long>("ORDEN");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.CodProducto)).HasColumnName<string>("COD_PRODUCTO").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.Altoempaque)).HasColumnName<Decimal>("ALTOEMPAQUE").HasColumnType<Decimal>("decimal(8, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.Anchoempaque)).HasColumnName<Decimal>("ANCHOEMPAQUE").HasColumnType<Decimal>("decimal(8, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.AnticipoJde)).HasColumnName<Decimal?>("ANTICIPO_JDE").HasColumnType<Decimal?>("decimal(10, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Anulado)).IsRequired(true).HasColumnName<string>("ANULADO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.BsMcFinan)).HasColumnName<Decimal?>("BS_MC_FINAN").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.BsMcFinansc)).HasColumnName<Decimal?>("BS_MC_FINANSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.BsMcPapel)).HasColumnName<Decimal?>("BS_MC_PAPEL").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.BsMcPapelsc)).HasColumnName<Decimal?>("BS_MC_PAPELSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.Bsmc)).HasColumnName<Decimal?>("BSMC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.CantFacturada)).HasColumnName<Decimal>("CANT_FACTURADA").HasColumnType<Decimal>("decimal(10, 2)");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ctmy034, int>>)(e => e.CantPedida)).HasColumnName<int>("CANT_PEDIDA");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ctmy034, int>>)(e => e.Cantidadcajasempaques)).HasColumnName<int>("CANTIDADCAJASEMPAQUES");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.CodAplicacion)).HasColumnName<Decimal?>("COD_APLICACION").HasColumnType<Decimal?>("decimal(4, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.CodResponsable)).HasColumnName<Decimal?>("COD_RESPONSABLE").HasColumnType<Decimal?>("decimal(10, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Codigocaja)).IsRequired(true).HasColumnName<string>("CODIGOCAJA").HasMaxLength(6).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Controldesde)).HasColumnName<string>("CONTROLDESDE").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Controlhasta)).HasColumnName<string>("CONTROLHASTA").HasMaxLength(10).IsUnicode(false);
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Ctmy034, long>>)(e => e.CtdDespOfic)).HasColumnName<long>("CTD_DESP_OFIC");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.CtdEntregada)).HasColumnName<Decimal>("CTD_ENTREGADA").HasColumnType<Decimal>("decimal(10, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.DescProducto)).IsRequired(true).HasColumnName<string>("DESC_PRODUCTO").HasMaxLength(50).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.DireccionEmb)).HasColumnName<string>("DIRECCION_EMB").HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.DireccionFact)).HasColumnName<string>("DIRECCION_FACT").HasColumnType<string>("text");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.EbitBs)).HasColumnName<Decimal?>("EBIT_BS").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.EbitPorc)).HasColumnName<Decimal?>("EBIT_PORC").HasColumnType<Decimal?>("decimal(8, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Equipoupdate)).IsRequired(true).HasColumnName<string>("EQUIPOUPDATE").HasMaxLength(50).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Excepcion)).HasColumnName<string>("EXCEPCION").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.FamiliaProduct)).IsRequired(true).HasColumnName<string>("FAMILIA_PRODUCT").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ctmy034, DateTime?>>)(e => e.FechaRemision)).HasColumnName<DateTime?>("FECHA_REMISION").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Ctmy034, DateTime?>>)(e => e.Fechaupdate)).HasColumnName<DateTime?>("FECHAUPDATE").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Fiscal)).HasColumnName<string>("FISCAL").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Formatodesde)).HasColumnName<string>("FORMATODESDE").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Formatohasta)).HasColumnName<string>("FORMATOHASTA").HasMaxLength(10).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.HorasMaquina)).HasColumnName<Decimal?>("HORAS_MAQUINA").HasColumnType<Decimal?>("decimal(4, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.IdSolicitud)).HasMaxLength(9).HasDefaultValueSql<string>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.IdSolicitud2)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.IvaJde)).HasColumnName<string>("IVA_JDE").HasMaxLength(20).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.Largoempaque)).HasColumnName<Decimal>("LARGOEMPAQUE").HasColumnType<Decimal>("decimal(8, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.LineaAntJde)).HasColumnName<Decimal?>("LINEA_ANT_JDE").HasColumnType<Decimal?>("decimal(2, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Ctmy034, short>>)(e => e.LineaIncoming)).HasColumnName<short>("LINEA_INCOMING");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.LineaProducto)).IsRequired(true).HasColumnName<string>("LINEA_PRODUCTO").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.ListaTotDol)).HasColumnName<Decimal>("LISTA_TOT_DOL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.Longitudmascara)).HasColumnName<Decimal?>("LONGITUDMASCARA").HasColumnType<Decimal?>("decimal(14, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.Maquina)).HasColumnName<Decimal?>("MAQUINA").HasColumnType<Decimal?>("decimal(4, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Medida)).IsRequired(true).HasColumnName<string>("MEDIDA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Nocalculamc)).HasColumnName<string>("NOCALCULAMC").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.NombreEmb)).HasColumnName<string>("NOMBRE_EMB").HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.NombreFact)).HasColumnName<string>("NOMBRE_FACT").HasColumnType<string>("text");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ctmy034, int>>)(e => e.NumeroPedido)).HasColumnName<int>("NUMERO_PEDIDO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.OrigenProducto)).IsRequired(true).HasColumnName<string>("ORIGEN_PRODUCTO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Papel)).HasColumnName<string>("PAPEL").HasMaxLength(8).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.PasoSql)).IsRequired(true).HasColumnName<string>("PASO_SQL").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.PorcCom)).HasColumnName<Decimal?>("PORC_COM").HasColumnType<Decimal?>("numeric(4, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.PorcIva)).HasColumnType<Decimal?>("numeric(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.PorcMcFinan)).HasColumnName<Decimal?>("PORC_MC_FINAN").HasColumnType<Decimal?>("decimal(6, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.PorcMcFinansc)).HasColumnName<Decimal?>("PORC_MC_FINANSC").HasColumnType<Decimal?>("decimal(6, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.PorcMcPapel)).HasColumnName<Decimal?>("PORC_MC_PAPEL").HasColumnType<Decimal?>("decimal(6, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.PorcMcPapelsc)).HasColumnName<Decimal?>("PORC_MC_PAPELSC").HasColumnType<Decimal?>("decimal(6, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.PorcentConces)).HasColumnName<Decimal>("PORCENT_CONCES").HasColumnType<Decimal>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.Pormc)).HasColumnName<Decimal?>("PORMC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.PrecioLista)).HasColumnName<Decimal>("PRECIO_LISTA").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.PrecioVenta)).HasColumnName<Decimal>("PRECIO_VENTA").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Presentacion)).IsRequired(true).HasColumnName<string>("PRESENTACION").HasMaxLength(10).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.RbsMcFinan)).HasColumnName<Decimal?>("RBS_MC_FINAN").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.RbsMcFinansc)).HasColumnName<Decimal?>("RBS_MC_FINANSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.RbsMcPapel)).HasColumnName<Decimal?>("RBS_MC_PAPEL").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.RbsMcPapelsc)).HasColumnName<Decimal?>("RBS_MC_PAPELSC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.Rbsmc)).HasColumnName<Decimal?>("RBSMC").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.RecalcularMargen)).HasMaxLength(1).HasDefaultValueSql<string>("('')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Ctmy034, int>>)(e => e.RemisionOfic)).HasColumnName<int>("REMISION_OFIC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.RifEmb)).IsRequired(true).HasColumnName<string>("RIF_EMB").HasMaxLength(14).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.RifFact)).IsRequired(true).HasColumnName<string>("RIF_FACT").HasMaxLength(14).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.RprecioLista)).HasColumnName<Decimal?>("RPRECIO_LISTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.RprecioVenta)).HasColumnName<Decimal?>("RPRECIO_VENTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.Rtasa)).HasColumnName<Decimal?>("RTASA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.RtotalLista)).HasColumnName<Decimal?>("RTOTAL_LISTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.RtotalVenta)).HasColumnName<Decimal?>("RTOTAL_VENTA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Sddcto)).HasColumnName<string>("SDDCTO").HasMaxLength(2).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal?>>)(e => e.Sddoco)).HasColumnName<Decimal?>("SDDOCO").HasColumnType<Decimal?>("decimal(14, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Sdkcoo)).HasColumnName<string>("SDKCOO").HasMaxLength(5).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Sdlnid)).HasColumnName<string>("SDLNID").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Seriecdesde)).HasColumnName<string>("SERIECDESDE").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Seriechasta)).HasColumnName<string>("SERIECHASTA").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Seriefdesde)).HasColumnName<string>("SERIEFDESDE").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Seriefhasta)).HasColumnName<string>("SERIEFHASTA").HasMaxLength(10).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.Tasa)).HasColumnName<Decimal>("TASA").HasColumnType<Decimal>("decimal(12, 2)");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Ctmy034, int?>>)(e => e.TipoIva)).HasColumnName<int?>("TIPO_IVA").HasDefaultValueSql<int?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.TipoProducto)).IsRequired(true).HasColumnName<string>("TIPO_PRODUCTO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Tipodocumento)).HasColumnName<string>("TIPODOCUMENTO").HasMaxLength(2).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.TotalLista)).HasColumnName<Decimal>("TOTAL_LISTA").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.TotalVenta)).HasColumnName<Decimal>("TOTAL_VENTA").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.UnitListaDol)).HasColumnName<Decimal>("UNIT_LISTA_DOL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.UnitVentaDol)).HasColumnName<Decimal>("UNIT_VENTA_DOL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Usuarioupdate)).IsRequired(true).HasColumnName<string>("USUARIOUPDATE").HasMaxLength(40).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.VendGestion)).IsRequired(true).HasColumnName<string>("VEND_GESTION").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Ctmy034, string>>)(e => e.Vendedor)).IsRequired(true).HasColumnName<string>("VENDEDOR").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Ctmy034, Decimal>>)(e => e.VentaTotDol)).HasColumnName<Decimal>("VENTA_TOT_DOL").HasColumnType<Decimal>("decimal(16, 2)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.DataInicial>((Action<EntityTypeBuilder<AppService.Core.Entities.DataInicial>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.DataInicial, object>>)(e => e.Archivo)).HasName<AppService.Core.Entities.DataInicial>("IX_DataInicial");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.DataInicial, object>>)(e => e.Data)).HasName<AppService.Core.Entities.DataInicial>("index_Data_DataInicial");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.DataInicial, object>>)(e => (object)e.Lote)).HasName<AppService.Core.Entities.DataInicial>("IX_DataInicial_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.DataInicial, object>>)(e => (object)e.OrdenArchivo)).HasName<AppService.Core.Entities.DataInicial>("index_DataInicial_OrdenArchivo");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.DataInicial, object>>)(e => new
                {
                    OrdenArchivo = e.OrdenArchivo,
                    Id = e.Id
                })).HasName<AppService.Core.Entities.DataInicial>("index_DataInicial_OrdenArchivoId");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.DataInicial, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.DataInicial, string>>)(e => e.Archivo)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.DataInicial, string>>)(e => e.Data)).HasMaxLength(250);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.DataInicial, Decimal?>>)(e => e.Lote)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.DataInicial, Decimal?>>)(e => e.OrdenArchivo)).HasColumnType<Decimal?>("numeric(18, 0)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.DeudorTipoRetencion>((Action<EntityTypeBuilder<AppService.Core.Entities.DeudorTipoRetencion>>)(entity =>
            {
                entity.HasNoKey();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.DeudorTipoRetencion, string>>)(e => e.Cliente)).HasMaxLength(10);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.DeudorTipoRetencion, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.DeudorTipoRetencion, string>>)(e => e.IndicadorRetencion)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.DeudorTipoRetencion, string>>)(e => e.Nombre)).HasMaxLength((int)byte.MaxValue);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.DeudorTipoRetencion, string>>)(e => e.TipoRetencion)).HasMaxLength(2);
            }));
            modelBuilder.Entity<AppService.Core.Entities.Deudores>((Action<EntityTypeBuilder<AppService.Core.Entities.Deudores>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.Deudores, object>>)(e => e.Cliente));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Deudores, string>>)(e => e.Cliente)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Deudores, string>>)(e => e.Clase)).HasMaxLength((int)byte.MaxValue);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Deudores, string>>)(e => e.Nombre)).HasMaxLength((int)byte.MaxValue);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Deudores, string>>)(e => e.Rif)).HasMaxLength((int)byte.MaxValue);
            }));
            modelBuilder.Entity<AppService.Core.Entities.EjeucionProceso>((Action<EntityTypeBuilder<AppService.Core.Entities.EjeucionProceso>>)(entity =>
            {
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.EjeucionProceso, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.EjeucionProceso, DateTime>>)(e => e.FechaEjecucion)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.EjeucionProceso, DateTime?>>)(e => e.Fin)).HasColumnType<DateTime?>("datetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.EjeucionProceso, Decimal>>)(e => e.IdEvaluacion)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.EjeucionProceso, Decimal>>)(e => e.IdObjetoProceso)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.EjeucionProceso, DateTime?>>)(e => e.Inicio)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.EjeucionProceso, string>>)(e => e.Mensaje)).IsRequired(true).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.EjeucionProceso, string>>)(e => e.Query)).IsRequired(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.EjeucionProceso, string>>)(e => e.Usuario)).IsRequired(true).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.EjeucionProcesoComisiones>((Action<EntityTypeBuilder<AppService.Core.Entities.EjeucionProcesoComisiones>>)(entity =>
            {
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.EjeucionProcesoComisiones, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.EjeucionProcesoComisiones, DateTime>>)(e => e.FechaEjecucion)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.EjeucionProcesoComisiones, DateTime?>>)(e => e.Fin)).HasColumnType<DateTime?>("datetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.EjeucionProcesoComisiones, Decimal>>)(e => e.IdEvaluacion)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.EjeucionProcesoComisiones, DateTime?>>)(e => e.Inicio)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.EjeucionProcesoComisiones, string>>)(e => e.Mensaje)).IsRequired(true).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.EjeucionProcesoComisiones, string>>)(e => e.Query)).IsRequired(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.EjeucionProcesoComisiones, string>>)(e => e.Usuario)).IsRequired(true).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.EscaneoTicket>((Action<EntityTypeBuilder<AppService.Core.Entities.EscaneoTicket>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.EscaneoTicket, object>>)(e => e.Data)).HasName<AppService.Core.Entities.EscaneoTicket>("IX_EscaneoTickect");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.EscaneoTicket, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.EscaneoTicket, string>>)(e => e.Data)).HasMaxLength(250);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.EscaneoTicket, DateTime?>>)(e => e.FechaEscaneo)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.EscaneoTicket, string>>)(e => e.UsuarioEscaneo)).HasMaxLength(128);
            }));
            modelBuilder.Entity<AppService.Core.Entities.F03b11>((Action<EntityTypeBuilder<AppService.Core.Entities.F03b11>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.F03b11>("F03B11");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.F03b11, DateTime?>>)(e => e.Actualizacion)).HasColumnName<DateTime?>("ACTUALIZACION").HasColumnType<DateTime?>("datetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Dias)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.F03b11, DateTime?>>)(e => e.FechaFoto)).HasColumnName<DateTime?>("Fecha_foto").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.F03b11, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Mensaje)).HasMaxLength((int)byte.MaxValue);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.PorcFoto)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpaap)).HasColumnName<double?>("RPAAP");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpacr)).HasColumnName<double?>("RPACR");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpadsa)).HasColumnName<double?>("RPADSA");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpadsc)).HasColumnName<double?>("RPADSC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpafc)).HasColumnName<string>("RPAFC").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpag)).HasColumnName<double?>("RPAG");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpaid)).HasColumnName<string>("RPAID").HasMaxLength(8).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpaid2)).HasColumnName<string>("RPAID2").HasMaxLength(8).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpajcl)).HasColumnName<Decimal?>("RPAJCL").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpalph)).HasColumnName<string>("RPALPH").HasMaxLength(40).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpalt6)).HasColumnName<string>("RPALT6").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpam)).HasColumnName<string>("RPAM").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpam2)).HasColumnName<string>("RPAM2").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpan8)).HasColumnName<double?>("RPAN8");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpan8j)).HasColumnName<double?>("RPAN8J");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpar01)).HasColumnName<string>("RPAR01").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpar02)).HasColumnName<string>("RPAR02").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpar03)).HasColumnName<string>("RPAR03").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpar04)).HasColumnName<string>("RPAR04").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpar05)).HasColumnName<string>("RPAR05").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpar06)).HasColumnName<string>("RPAR06").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpar07)).HasColumnName<string>("RPAR07").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpar08)).HasColumnName<string>("RPAR08").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpar09)).HasColumnName<string>("RPAR09").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpar10)).HasColumnName<string>("RPAR10").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpatad)).HasColumnName<double?>("RPATAD");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpatxa)).HasColumnName<double?>("RPATXA");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpatxn)).HasColumnName<double?>("RPATXN");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpbalj)).HasColumnName<string>("RPBALJ").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpbcrc)).HasColumnName<string>("RPBCRC").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpcds)).HasColumnName<double?>("RPCDS");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpcdsa)).HasColumnName<double?>("RPCDSA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpclmg)).HasColumnName<string>("RPCLMG").HasMaxLength(10).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpcmc1)).HasColumnName<double?>("RPCMC1");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpcmgr)).HasColumnName<string>("RPCMGR").HasMaxLength(10).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpco)).HasColumnName<string>("RPCO").HasMaxLength(5).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpcoll)).HasColumnName<string>("RPCOLL").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpcorc)).HasColumnName<string>("RPCORC").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpcrcd)).HasColumnName<string>("RPCRCD").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpcrr)).HasColumnName<double?>("RPCRR");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpcrrm)).HasColumnName<string>("RPCRRM").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpctad)).HasColumnName<double?>("RPCTAD");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpctam)).HasColumnName<double?>("RPCTAM");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpctl)).HasColumnName<string>("RPCTL").HasMaxLength(13).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpctry)).HasColumnName<double?>("RPCTRY");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpctxa)).HasColumnName<double?>("RPCTXA");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpctxn)).HasColumnName<double?>("RPCTXN");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpdct)).IsRequired(true).HasColumnName<string>("RPDCT").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpdcto)).HasColumnName<string>("RPDCTO").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpddex)).HasColumnName<string>("RPDDEX").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpddj)).HasColumnName<Decimal?>("RPDDJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpddnj)).HasColumnName<Decimal?>("RPDDNJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpdgj)).HasColumnName<Decimal?>("RPDGJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpdicj)).HasColumnName<Decimal?>("RPDICJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpdivj)).HasColumnName<Decimal?>("RPDIVJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpdmcd)).HasColumnName<string>("RPDMCD").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpdnlt)).HasColumnName<string>("RPDNLT").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<double>((Expression<Func<AppService.Core.Entities.F03b11, double>>)(e => e.Rpdoc)).HasColumnName<double>("RPDOC");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpdoco)).HasColumnName<double?>("RPDOCO");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpdrf)).HasColumnName<double?>("RPDRF");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpdsvj)).HasColumnName<Decimal?>("RPDSVJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpdtpb)).HasColumnName<Decimal?>("RPDTPB").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpdtxs)).HasColumnName<string>("RPDTXS").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rperdj)).HasColumnName<Decimal?>("RPERDJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpexr1)).HasColumnName<string>("RPEXR1").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpfap)).HasColumnName<double?>("RPFAP");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpfnlp)).HasColumnName<string>("RPFNLP").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpfnrt)).HasColumnName<double?>("RPFNRT");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpfy)).HasColumnName<double?>("RPFY");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpgfl1)).HasColumnName<string>("RPGFL1").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpgfl2)).HasColumnName<string>("RPGFL2").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpglba)).HasColumnName<string>("RPGLBA").HasMaxLength(8).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpglc)).HasColumnName<string>("RPGLC").HasMaxLength(4).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rphcrr)).HasColumnName<double?>("RPHCRR");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rphdgj)).HasColumnName<Decimal?>("RPHDGJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpicu)).HasColumnName<double?>("RPICU");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpicut)).HasColumnName<string>("RPICUT").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpistc)).HasColumnName<string>("RPISTC").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpistr)).HasColumnName<string>("RPISTR").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpitm)).HasColumnName<double?>("RPITM");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpjcl)).HasColumnName<Decimal?>("RPJCL").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpjobn)).HasColumnName<string>("RPJOBN").HasMaxLength(10).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpkco)).IsRequired(true).HasColumnName<string>("RPKCO").HasMaxLength(5).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpkcoo)).HasColumnName<string>("RPKCOO").HasMaxLength(5).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rplfcj)).HasColumnName<Decimal?>("RPLFCJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rplnid)).HasColumnName<double?>("RPLNID");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpmcu)).HasColumnName<string>("RPMCU").HasMaxLength(12).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpmcu2)).HasColumnName<string>("RPMCU2").HasMaxLength(12).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpnbrr)).HasColumnName<string>("RPNBRR").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpnetdoc)).HasColumnName<double?>("RPNETDOC");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpnetrc5)).HasColumnName<double?>("RPNETRC5");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpnetst)).HasColumnName<string>("RPNETST").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpnettcid)).HasColumnName<double?>("RPNETTCID");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpnrta)).HasColumnName<double?>("RPNRTA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpobj)).HasColumnName<string>("RPOBJ").HasMaxLength(6).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpodct)).HasColumnName<string>("RPODCT").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpodoc)).HasColumnName<double?>("RPODOC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpokco)).HasColumnName<string>("RPOKCO").HasMaxLength(5).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpomod)).HasColumnName<string>("RPOMOD").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rposfx)).HasColumnName<string>("RPOSFX").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rppa8)).HasColumnName<double?>("RPPA8");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rppdct)).HasColumnName<string>("RPPDCT").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rppid)).HasColumnName<string>("RPPID").HasMaxLength(10).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rppkco)).HasColumnName<string>("RPPKCO").HasMaxLength(5).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rppn)).HasColumnName<double?>("RPPN");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rppo)).HasColumnName<string>("RPPO").HasMaxLength(8).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rppost)).HasColumnName<string>("RPPOST").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpppdi)).HasColumnName<Decimal?>("RPPPDI").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpprgf)).HasColumnName<string>("RPPRGF").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rppst)).HasColumnName<string>("RPPST").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpptc)).HasColumnName<string>("RPPTC").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rppwpg)).HasColumnName<double?>("RPPWPG");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rppyid)).HasColumnName<double?>("RPPYID");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rppyr)).HasColumnName<double?>("RPPYR");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rprddj)).HasColumnName<Decimal?>("RPRDDJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rprdrl)).HasColumnName<string>("RPRDRL").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rprdsj)).HasColumnName<Decimal?>("RPRDSJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rprf)).HasColumnName<string>("RPRF").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rprmds)).HasColumnName<double?>("RPRMDS");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rprmk)).HasColumnName<string>("RPRMK").HasMaxLength(30).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rprnid)).HasColumnName<double?>("RPRNID");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rprp1)).HasColumnName<string>("RPRP1").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rprp2)).HasColumnName<string>("RPRP2").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rprp3)).HasColumnName<string>("RPRP3").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rprsco)).HasColumnName<string>("RPRSCO").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpryin)).HasColumnName<string>("RPRYIN").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpsbl)).HasColumnName<string>("RPSBL").HasMaxLength(8).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpsblt)).HasColumnName<string>("RPSBLT").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpsdct)).HasColumnName<string>("RPSDCT").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpsdoc)).HasColumnName<double?>("RPSDOC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpsfx)).IsRequired(true).HasColumnName<string>("RPSFX").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpsfxo)).HasColumnName<string>("RPSFXO").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpshpn)).HasColumnName<double?>("RPSHPN");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpskco)).HasColumnName<string>("RPSKCO").HasMaxLength(5).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpsmtj)).HasColumnName<Decimal?>("RPSMTJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpsotf)).HasColumnName<string>("RPSOTF").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpstam)).HasColumnName<double?>("RPSTAM");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpsub)).HasColumnName<string>("RPSUB").HasMaxLength(8).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rptorg)).HasColumnName<string>("RPTORG").HasMaxLength(10).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rptxa1)).HasColumnName<string>("RPTXA1").HasMaxLength(10).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpu)).HasColumnName<double?>("RPU");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpum)).HasColumnName<string>("RPUM").HasMaxLength(2).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpunit)).HasColumnName<string>("RPUNIT").HasMaxLength(8).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpupmj)).HasColumnName<Decimal?>("RPUPMJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpupmt)).HasColumnName<double?>("RPUPMT");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpurab)).HasColumnName<double?>("RPURAB");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.F03b11, double?>>)(e => e.Rpurat)).HasColumnName<double?>("RPURAT");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpurc1)).HasColumnName<string>("RPURC1").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpurdt)).HasColumnName<Decimal?>("RPURDT").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpurrf)).HasColumnName<string>("RPURRF").HasMaxLength(15).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpuser)).HasColumnName<string>("RPUSER").HasMaxLength(10).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpvdgj)).HasColumnName<Decimal?>("RPVDGJ").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpvinv)).HasColumnName<string>("RPVINV").HasMaxLength(25).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.Rpvldt)).HasColumnName<Decimal?>("RPVLDT").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpvod)).HasColumnName<string>("RPVOD").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Rpvr01)).HasColumnName<string>("RPVR01").HasMaxLength(25).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.F03b11, Decimal?>>)(e => e.SaldoFoto)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.F03b11, string>>)(e => e.Transferir)).HasMaxLength(1).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.F03b11, DateTime?>>)(e => e.VencimientoEntrega)).HasColumnType<DateTime?>("smalldatetime");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssAdjuntoTarea>((Action<EntityTypeBuilder<AppService.Core.Entities.GssAdjuntoTarea>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssAdjuntoTarea, object>>)(e => (object)e.IdAdjuntoTarea)).HasName("PK_AdjuntoTarea");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.GssAdjuntoTarea, object>>)(e => (object)e.IdTarea)).HasName<AppService.Core.Entities.GssAdjuntoTarea>("IX_IdTarea");
                entity.Property<byte[]>((Expression<Func<AppService.Core.Entities.GssAdjuntoTarea, byte[]>>)(e => e.Archivo)).IsRequired(true);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssAdjuntoTarea, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssAdjuntoTarea, string>>)(e => e.NombreArchivo)).IsRequired(true).HasMaxLength(100);
                entity.HasOne<AppService.Core.Entities.GssTarea>((Expression<Func<AppService.Core.Entities.GssAdjuntoTarea, AppService.Core.Entities.GssTarea>>)(d => d.IdTareaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssTarea, IEnumerable<AppService.Core.Entities.GssAdjuntoTarea>>>)(p => p.GssAdjuntoTarea)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssAdjuntoTarea, object>>)(d => (object)d.IdTarea)).HasConstraintName<AppService.Core.Entities.GssTarea, AppService.Core.Entities.GssAdjuntoTarea>("FK_GssAdjuntoTarea_GssTarea");
                entity.HasOne<AppService.Core.Entities.GssTipoDocumento>((Expression<Func<AppService.Core.Entities.GssAdjuntoTarea, AppService.Core.Entities.GssTipoDocumento>>)(d => d.IdTipoDocumentoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssTipoDocumento, IEnumerable<AppService.Core.Entities.GssAdjuntoTarea>>>)(p => p.GssAdjuntoTarea)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssAdjuntoTarea, object>>)(d => (object)d.IdTipoDocumento)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssTipoDocumento, AppService.Core.Entities.GssAdjuntoTarea>("FK_GssAdjuntoTarea_GssTipoDocumento");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssAdminApp>((Action<EntityTypeBuilder<AppService.Core.Entities.GssAdminApp>>)(entity => entity.HasKey((Expression<Func<AppService.Core.Entities.GssAdminApp, object>>)(e => new
            {
                IdUnidadServicio = e.IdUnidadServicio,
                IdUsuario = e.IdUsuario
            }))));
            modelBuilder.Entity<AppService.Core.Entities.GssAprobacionServicio>((Action<EntityTypeBuilder<AppService.Core.Entities.GssAprobacionServicio>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, object>>)(e => (object)e.IdAprobacionServicio));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, object>>)(e => new
                {
                    IdTarea = e.IdTarea,
                    Secuencia = e.Secuencia
                })).HasName<AppService.Core.Entities.GssAprobacionServicio>("IX_IdTarea_Secuencia").IsUnique(true);
                entity.HasIndex((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, object>>)(e => new
                {
                    IdEstatusTarea = e.IdEstatusTarea,
                    IdUsuario = e.IdUsuario,
                    IdTarea = e.IdTarea,
                    Secuencia = e.Secuencia
                })).HasName<AppService.Core.Entities.GssAprobacionServicio>("IX_EstatusUsuarioTareaSecuencia").IsUnique(true);
                entity.HasIndex((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, object>>)(e => new
                {
                    IdAprobacionServicio = e.IdAprobacionServicio,
                    IdTarea = e.IdTarea,
                    IdNivel = e.IdNivel,
                    IdGrupoTrabajo = e.IdGrupoTrabajo,
                    Secuencia = e.Secuencia,
                    FechaEntrada = e.FechaEntrada,
                    IdEstatusTarea = e.IdEstatusTarea
                })).HasName<AppService.Core.Entities.GssAprobacionServicio>("IX_Servicios_x_Ejecutar");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, DateTime>>)(e => e.FechaEntrada)).HasColumnType<DateTime>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, DateTime?>>)(e => e.FechaSalida)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, string>>)(e => e.Observacion)).IsRequired(true).HasDefaultValueSql<string>("('')");
                entity.HasOne<AppService.Core.Entities.GssEstatusTarea>((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, AppService.Core.Entities.GssEstatusTarea>>)(d => d.IdEstatusTareaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssEstatusTarea, IEnumerable<AppService.Core.Entities.GssAprobacionServicio>>>)(p => p.GssAprobacionServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, object>>)(d => (object)d.IdEstatusTarea)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssEstatusTarea, AppService.Core.Entities.GssAprobacionServicio>("FK_GssAprobacionServicio_GssEstatusTarea");
                entity.HasOne<AppService.Core.Entities.GssNivel>((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, AppService.Core.Entities.GssNivel>>)(d => d.IdNivelNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssNivel, IEnumerable<AppService.Core.Entities.GssAprobacionServicio>>>)(p => p.GssAprobacionServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, object>>)(d => (object)d.IdNivel)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssNivel, AppService.Core.Entities.GssAprobacionServicio>("FK_GssAprobacionServicio_GssNivel");
                entity.HasOne<AppService.Core.Entities.GssTarea>((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, AppService.Core.Entities.GssTarea>>)(d => d.IdTareaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssTarea, IEnumerable<AppService.Core.Entities.GssAprobacionServicio>>>)(p => p.GssAprobacionServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, object>>)(d => (object)d.IdTarea)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssTarea, AppService.Core.Entities.GssAprobacionServicio>("FK_GssAprobacionServicio_GssTarea");
                entity.HasOne<AppService.Core.Entities.SegUsuario>((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, AppService.Core.Entities.SegUsuario>>)(d => d.IdUsuarioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.SegUsuario, IEnumerable<AppService.Core.Entities.GssAprobacionServicio>>>)(p => p.GssAprobacionServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssAprobacionServicio, object>>)(d => (object)d.IdUsuario)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.SegUsuario, AppService.Core.Entities.GssAprobacionServicio>("FK_GssAprobacionServicio_SegUsuario");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssAreaServicio>((Action<EntityTypeBuilder<AppService.Core.Entities.GssAreaServicio>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssAreaServicio, object>>)(e => (object)e.IdAreaServicio));
                entity.HasComment<AppService.Core.Entities.GssAreaServicio>("Areas de Servicio por Unidad (Dpto.)");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssAreaServicio, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssAreaServicio, string>>)(e => e.NombreAreaServicio)).IsRequired(true).HasMaxLength(80);
                entity.HasOne<AppService.Core.Entities.GssUnidadServicio>((Expression<Func<AppService.Core.Entities.GssAreaServicio, AppService.Core.Entities.GssUnidadServicio>>)(d => d.IdUnidadServicioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssUnidadServicio, IEnumerable<AppService.Core.Entities.GssAreaServicio>>>)(p => p.GssAreaServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssAreaServicio, object>>)(d => (object)d.IdUnidadServicio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssUnidadServicio, AppService.Core.Entities.GssAreaServicio>("FK_GssAreaServicio_GssUnidadServicio");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssCompañia>((Action<EntityTypeBuilder<AppService.Core.Entities.GssCompañia>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssCompañia, object>>)(e => (object)e.IdCompañia));
                entity.HasComment<AppService.Core.Entities.GssCompañia>("Registro de Compañias");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.GssCompañia, short>>)(e => e.IdCompañia)).ValueGeneratedNever();
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssCompañia, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssCompañia, string>>)(e => e.IdJde)).IsRequired(true).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssCompañia, string>>)(e => e.NombreCompañia)).IsRequired(true).HasMaxLength(80);
                entity.HasOne<AppService.Core.Entities.GssPais>((Expression<Func<AppService.Core.Entities.GssCompañia, AppService.Core.Entities.GssPais>>)(d => d.IdPaisNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssPais, IEnumerable<AppService.Core.Entities.GssCompañia>>>)(p => p.GssCompañia)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssCompañia, object>>)(d => (object)d.IdPais)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssPais, AppService.Core.Entities.GssCompañia>("FK_GssCompañia_GssPais");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssEstatusSolicitud>((Action<EntityTypeBuilder<AppService.Core.Entities.GssEstatusSolicitud>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssEstatusSolicitud, object>>)(e => (object)e.IdEstatusSolicitud));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssEstatusSolicitud, string>>)(e => e.Abreviado)).IsRequired(true).HasMaxLength(3);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssEstatusSolicitud, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssEstatusSolicitud, string>>)(e => e.NombreEstatusSolicitud)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssEstatusTarea>((Action<EntityTypeBuilder<AppService.Core.Entities.GssEstatusTarea>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssEstatusTarea, object>>)(e => (object)e.IdEstatusTarea));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssEstatusTarea, string>>)(e => e.Abreviado)).IsRequired(true).HasMaxLength(3);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssEstatusTarea, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssEstatusTarea, string>>)(e => e.NombreEstatusTarea)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssGrupoTrabajo>((Action<EntityTypeBuilder<AppService.Core.Entities.GssGrupoTrabajo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssGrupoTrabajo, object>>)(e => (object)e.IdGrupoTabajo));
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssGrupoTrabajo, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.GssGrupoTrabajo, int?>>)(e => e.IdUnidadServicio)).HasDefaultValueSql<int?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssGrupoTrabajo, string>>)(e => e.NombreGrupoTrabajo)).IsRequired(true).HasMaxLength(80);
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssGrupoTrabajoUsuario>((Action<EntityTypeBuilder<AppService.Core.Entities.GssGrupoTrabajoUsuario>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssGrupoTrabajoUsuario, object>>)(e => (object)e.IdGrupoTrabajoUsuario));
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssGrupoTrabajoUsuario, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssMtrTipoDato>((Action<EntityTypeBuilder<AppService.Core.Entities.GssMtrTipoDato>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssMtrTipoDato, object>>)(e => e.IdTipoDato));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.GssMtrTipoDato, object>>)(e => (object)e.Orden)).HasName<AppService.Core.Entities.GssMtrTipoDato>("IX_GssMtrTipoDato").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssMtrTipoDato, string>>)(e => e.IdTipoDato)).HasMaxLength(30);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssMtrTipoDato, string>>)(e => e.MascaraUsuario)).IsRequired(true).HasMaxLength(30);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssMtrTipoDato, string>>)(e => e.MensajeUsuario)).IsRequired(true).HasMaxLength(200);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssMtrTipoDato, string>>)(e => e.TipoDatoDatatables)).IsRequired(true).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssNivel>((Action<EntityTypeBuilder<AppService.Core.Entities.GssNivel>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssNivel, object>>)(e => (object)e.IdNivel));
                entity.HasComment<AppService.Core.Entities.GssNivel>("Niveles por area de servicio");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssNivel, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssNivel, string>>)(e => e.NombreNivel)).IsRequired(true).HasMaxLength(80);
                entity.HasOne<AppService.Core.Entities.GssUnidadServicio>((Expression<Func<AppService.Core.Entities.GssNivel, AppService.Core.Entities.GssUnidadServicio>>)(d => d.IdUnidadServicioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssUnidadServicio, IEnumerable<AppService.Core.Entities.GssNivel>>>)(p => p.GssNivel)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssNivel, object>>)(d => (object)d.IdUnidadServicio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssUnidadServicio, AppService.Core.Entities.GssNivel>("FK_GssNivel_GssNivel");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssPais>((Action<EntityTypeBuilder<AppService.Core.Entities.GssPais>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssPais, object>>)(e => (object)e.IdPais));
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssPais, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssPais, string>>)(e => e.NombrePais)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssPasoSolicitud>((Action<EntityTypeBuilder<AppService.Core.Entities.GssPasoSolicitud>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssPasoSolicitud, object>>)(e => (object)e.IdPasoSolicitud));
                entity.HasOne<AppService.Core.Entities.GssSolicitud>((Expression<Func<AppService.Core.Entities.GssPasoSolicitud, AppService.Core.Entities.GssSolicitud>>)(d => d.IdSolicitudNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssSolicitud, IEnumerable<AppService.Core.Entities.GssPasoSolicitud>>>)(p => p.GssPasoSolicitud)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssPasoSolicitud, object>>)(d => (object)d.IdSolicitud)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssSolicitud, AppService.Core.Entities.GssPasoSolicitud>("FK_GssPasoSolicitud_GssSolicitud");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssPlantillaServicio>((Action<EntityTypeBuilder<AppService.Core.Entities.GssPlantillaServicio>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssPlantillaServicio, object>>)(e => (object)e.IdPlantillaServicio));
                entity.HasComment<AppService.Core.Entities.GssPlantillaServicio>("Plantilla de Servicio");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssPlantillaServicio, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssPlantillaServicio, string>>)(e => e.FuncionBusqueda)).HasMaxLength(80);
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.GssPlantillaServicio, bool?>>)(e => e.OcultaDuplicado)).IsRequired(true).HasDefaultValueSql<bool?>("((1))");
                entity.HasOne<AppService.Core.Entities.GssServicios>((Expression<Func<AppService.Core.Entities.GssPlantillaServicio, AppService.Core.Entities.GssServicios>>)(d => d.IdServicioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssServicios, IEnumerable<AppService.Core.Entities.GssPlantillaServicio>>>)(p => p.GssPlantillaServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssPlantillaServicio, object>>)(d => (object)d.IdServicio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssServicios, AppService.Core.Entities.GssPlantillaServicio>("FK_GssPlantillaServicio_GssServicios");
                entity.HasOne<AppService.Core.Entities.GssVariable>((Expression<Func<AppService.Core.Entities.GssPlantillaServicio, AppService.Core.Entities.GssVariable>>)(d => d.IdVariableNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssVariable, IEnumerable<AppService.Core.Entities.GssPlantillaServicio>>>)(p => p.GssPlantillaServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssPlantillaServicio, object>>)(d => (object)d.IdVariable)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssVariable, AppService.Core.Entities.GssPlantillaServicio>("FK_GssPlantillaServicio_GssVariablesPlantilla");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssServicioNivel>((Action<EntityTypeBuilder<AppService.Core.Entities.GssServicioNivel>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssServicioNivel, object>>)(e => (object)e.IdServicioNivel));
                entity.HasComment<AppService.Core.Entities.GssServicioNivel>("Niveles por servicios");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssServicioNivel, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.HasOne<AppService.Core.Entities.GssNivel>((Expression<Func<AppService.Core.Entities.GssServicioNivel, AppService.Core.Entities.GssNivel>>)(d => d.IdNivelNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssNivel, IEnumerable<AppService.Core.Entities.GssServicioNivel>>>)(p => p.GssServicioNivel)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssServicioNivel, object>>)(d => (object)d.IdNivel)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssNivel, AppService.Core.Entities.GssServicioNivel>("FK_GssServicioNivel_GssNivel");
                entity.HasOne<AppService.Core.Entities.GssServicios>((Expression<Func<AppService.Core.Entities.GssServicioNivel, AppService.Core.Entities.GssServicios>>)(d => d.IdServicioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssServicios, IEnumerable<AppService.Core.Entities.GssServicioNivel>>>)(p => p.GssServicioNivel)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssServicioNivel, object>>)(d => (object)d.IdServicio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssServicios, AppService.Core.Entities.GssServicioNivel>("FK_GssServicioNivel_GssServicios");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssServicioResponsable>((Action<EntityTypeBuilder<AppService.Core.Entities.GssServicioResponsable>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssServicioResponsable, object>>)(e => (object)e.IdServicioResponsable));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.GssServicioResponsable, object>>)(e => new
                {
                    IdServicio = e.IdServicio,
                    IdResponsable = e.IdResponsable
                })).HasName<AppService.Core.Entities.GssServicioResponsable>("IX_GssServicioResponsable_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.GssServicioResponsable, object>>)(e => new
                {
                    IdServicio = e.IdServicio,
                    IdTipoNomina = e.IdTipoNomina,
                    IdResponsable = e.IdResponsable,
                    Secuencia = e.Secuencia
                })).HasName<AppService.Core.Entities.GssServicioResponsable>("IX_GssServicioResponsable").IsUnique(true);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssServicioResponsable, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssServicioResponsable, string>>)(e => e.IdTipoNomina)).IsRequired(true).HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("('')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssServicios>((Action<EntityTypeBuilder<AppService.Core.Entities.GssServicios>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssServicios, object>>)(e => (object)e.IdServicio));
                entity.HasComment<AppService.Core.Entities.GssServicios>("Servicios Disponibles");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssServicios, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.GssServicios, bool?>>)(e => e.FlagControlNomina)).IsRequired(true).HasDefaultValueSql<bool?>("((1))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssServicios, string>>)(e => e.FormatoReporte)).IsRequired(true).HasMaxLength(50).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssServicios, string>>)(e => e.NombreServicio)).IsRequired(true).HasMaxLength(80);
                entity.HasOne<AppService.Core.Entities.GssTipoServicio>((Expression<Func<AppService.Core.Entities.GssServicios, AppService.Core.Entities.GssTipoServicio>>)(d => d.IdTipoServicioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssTipoServicio, IEnumerable<AppService.Core.Entities.GssServicios>>>)(p => p.GssServicios)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssServicios, object>>)(d => (object)d.IdTipoServicio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssTipoServicio, AppService.Core.Entities.GssServicios>("FK_GssServicios_GssTipoServicio");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssSolicitud>((Action<EntityTypeBuilder<AppService.Core.Entities.GssSolicitud>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssSolicitud, object>>)(e => (object)e.IdSolicitud)).HasName("PK_GssSolicitudServicio");
                entity.HasComment<AppService.Core.Entities.GssSolicitud>("Registro Solicitud de Servicio");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssSolicitud, string>>)(e => e.DescripcionSolicitud)).IsRequired(true);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssSolicitud, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssSolicitud, DateTime>>)(e => e.FechaSolicitud)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssSolicitud, string>>)(e => e.JustificacionSolicitud)).IsRequired(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssSolicitud, string>>)(e => e.TituloSolicitud)).IsRequired(true).HasMaxLength(80);
                entity.HasOne<AppService.Core.Entities.GssEstatusSolicitud>((Expression<Func<AppService.Core.Entities.GssSolicitud, AppService.Core.Entities.GssEstatusSolicitud>>)(d => d.IdEstatusSolicitudNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssEstatusSolicitud, IEnumerable<AppService.Core.Entities.GssSolicitud>>>)(p => p.GssSolicitud)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssSolicitud, object>>)(d => (object)d.IdEstatusSolicitud)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssEstatusSolicitud, AppService.Core.Entities.GssSolicitud>("FK_GssSolicitud_GssEstatusSolicitud");
                entity.HasOne<AppService.Core.Entities.GssUnidadServicio>((Expression<Func<AppService.Core.Entities.GssSolicitud, AppService.Core.Entities.GssUnidadServicio>>)(d => d.IdUnidadServicioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssUnidadServicio, IEnumerable<AppService.Core.Entities.GssSolicitud>>>)(p => p.GssSolicitud)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssSolicitud, object>>)(d => (object)d.IdUnidadServicio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssUnidadServicio, AppService.Core.Entities.GssSolicitud>("FK_GssSolicitud_GssUnidadServicio");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssSolicitudServicio>((Action<EntityTypeBuilder<AppService.Core.Entities.GssSolicitudServicio>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssSolicitudServicio, object>>)(e => (object)e.IdSolicitudServicio)).HasName("PK_GssSolicitudServicio_1");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssSolicitudServicio, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssTarea>((Action<EntityTypeBuilder<AppService.Core.Entities.GssTarea>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssTarea, object>>)(e => (object)e.IdTarea)).HasName("PK_GssTareas");
                entity.HasComment<AppService.Core.Entities.GssTarea>("Registro de Tareas por Solicitud");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.GssTarea, object>>)(e => (object)e.IdSolicitud)).HasName<AppService.Core.Entities.GssTarea>("IX_IdSolicitud");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssTarea, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.GssTarea, DateTime?>>)(e => e.FechaCierre)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.GssTarea, DateTime?>>)(e => e.FechaEntrega)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.GssTarea, DateTime?>>)(e => e.FechaProcesada)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssTarea, DateTime>>)(e => e.FechaTarea)).HasColumnType<DateTime>("datetime");
                entity.HasOne<AppService.Core.Entities.GssServicios>((Expression<Func<AppService.Core.Entities.GssTarea, AppService.Core.Entities.GssServicios>>)(d => d.IdServicioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssServicios, IEnumerable<AppService.Core.Entities.GssTarea>>>)(p => p.GssTarea)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssTarea, object>>)(d => (object)d.IdServicio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssServicios, AppService.Core.Entities.GssTarea>("FK_GssTareas_GssServicios");
                entity.HasOne<AppService.Core.Entities.GssSolicitud>((Expression<Func<AppService.Core.Entities.GssTarea, AppService.Core.Entities.GssSolicitud>>)(d => d.IdSolicitudNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssSolicitud, IEnumerable<AppService.Core.Entities.GssTarea>>>)(p => p.GssTarea)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssTarea, object>>)(d => (object)d.IdSolicitud)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssSolicitud, AppService.Core.Entities.GssTarea>("FK_GssTarea_GssSolicitud");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssTareaComentario>((Action<EntityTypeBuilder<AppService.Core.Entities.GssTareaComentario>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssTareaComentario, object>>)(e => (object)e.IdComentarioTarea)).IsClustered(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssTareaComentario, string>>)(e => e.ComentarioTarea)).IsRequired(true).HasDefaultValueSql<string>("('')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssTareaComentario, DateTime>>)(e => e.FechaComentario)).HasColumnType<DateTime>("datetime");
                entity.HasOne<AppService.Core.Entities.GssTarea>((Expression<Func<AppService.Core.Entities.GssTareaComentario, AppService.Core.Entities.GssTarea>>)(d => d.IdTareaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssTarea, IEnumerable<AppService.Core.Entities.GssTareaComentario>>>)(p => p.GssTareaComentario)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssTareaComentario, object>>)(d => (object)d.IdTarea)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssTarea, AppService.Core.Entities.GssTareaComentario>("FK_GssTareaComentario_GssTarea");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssTareaPlantillaServicio>((Action<EntityTypeBuilder<AppService.Core.Entities.GssTareaPlantillaServicio>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssTareaPlantillaServicio, object>>)(e => (object)e.IdTareaPlantillaServicio));
                entity.HasComment<AppService.Core.Entities.GssTareaPlantillaServicio>("Detalle de Tarea Plantilla de Srvicio");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.GssTareaPlantillaServicio, object>>)(e => new
                {
                    IdTarea = e.IdTarea,
                    IdVariable = e.IdVariable
                })).HasName<AppService.Core.Entities.GssTareaPlantillaServicio>("IX_IdTarea_IdVariable").IsUnique(true);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssTareaPlantillaServicio, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssTareaPlantillaServicio, string>>)(e => e.MensajeBusqueda)).HasMaxLength(100).HasDefaultValueSql<string>("('')");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.GssTareaPlantillaServicio, bool?>>)(e => e.Requerido)).IsRequired(true).HasDefaultValueSql<bool?>("((1))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssTareaPlantillaServicio, string>>)(e => e.ValorEntrada)).IsRequired(true).HasMaxLength(250);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssTareaPlantillaServicio, string>>)(e => e.ValorSalida)).IsRequired(true).HasMaxLength(250).HasDefaultValueSql<string>("('')");
                entity.HasOne<AppService.Core.Entities.GssPlantillaServicio>((Expression<Func<AppService.Core.Entities.GssTareaPlantillaServicio, AppService.Core.Entities.GssPlantillaServicio>>)(d => d.IdPlantillaServicioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssPlantillaServicio, IEnumerable<AppService.Core.Entities.GssTareaPlantillaServicio>>>)(p => p.GssTareaPlantillaServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssTareaPlantillaServicio, object>>)(d => (object)d.IdPlantillaServicio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssPlantillaServicio, AppService.Core.Entities.GssTareaPlantillaServicio>("FK_GssTareaPlantillaServicio_GssPlantillaServicio");
                entity.HasOne<AppService.Core.Entities.GssTarea>((Expression<Func<AppService.Core.Entities.GssTareaPlantillaServicio, AppService.Core.Entities.GssTarea>>)(d => d.IdTareaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssTarea, IEnumerable<AppService.Core.Entities.GssTareaPlantillaServicio>>>)(p => p.GssTareaPlantillaServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssTareaPlantillaServicio, object>>)(d => (object)d.IdTarea)).HasConstraintName<AppService.Core.Entities.GssTarea, AppService.Core.Entities.GssTareaPlantillaServicio>("FK_GssTareaPlantillaServicio_GssTarea");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssTipoDocumento>((Action<EntityTypeBuilder<AppService.Core.Entities.GssTipoDocumento>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssTipoDocumento, object>>)(e => (object)e.IdTipoDocumento));
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssTipoDocumento, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssTipoDocumento, DateTime>>)(e => e.FechaModificacion)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssTipoDocumento, string>>)(e => e.NombreDocumento)).IsRequired(true).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssTipoServicio>((Action<EntityTypeBuilder<AppService.Core.Entities.GssTipoServicio>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssTipoServicio, object>>)(e => (object)e.IdTipoServicio));
                entity.HasComment<AppService.Core.Entities.GssTipoServicio>("Tipo de Servicio por Area / Unudad");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssTipoServicio, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssTipoServicio, string>>)(e => e.NombreTipoServicio)).IsRequired(true).HasMaxLength(80);
                entity.HasOne<AppService.Core.Entities.GssAreaServicio>((Expression<Func<AppService.Core.Entities.GssTipoServicio, AppService.Core.Entities.GssAreaServicio>>)(d => d.IdAreaServicioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssAreaServicio, IEnumerable<AppService.Core.Entities.GssTipoServicio>>>)(p => p.GssTipoServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssTipoServicio, object>>)(d => (object)d.IdAreaServicio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssAreaServicio, AppService.Core.Entities.GssTipoServicio>("FK_GssTipoServicio_GssAreaServicio");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssUnidadServicio>((Action<EntityTypeBuilder<AppService.Core.Entities.GssUnidadServicio>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssUnidadServicio, object>>)(e => (object)e.IdUnidadServicio));
                entity.HasComment<AppService.Core.Entities.GssUnidadServicio>("Unidad de Servicio por Compañia   (Dpto.) ");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssUnidadServicio, string>>)(e => e.Abreviado)).IsRequired(true).HasMaxLength(15).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssUnidadServicio, string>>)(e => e.CuentaUnidadServicio)).HasMaxLength(40).HasDefaultValueSql<string>("('')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssUnidadServicio, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssUnidadServicio, string>>)(e => e.NombreUnidadServicio)).IsRequired(true).HasMaxLength(80);
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssUnidadServicioCompañia>((Action<EntityTypeBuilder<AppService.Core.Entities.GssUnidadServicioCompañia>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssUnidadServicioCompañia, object>>)(e => (object)e.IdUnidadServicioCompañia));
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssUnidadServicioCompañia, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.HasOne<AppService.Core.Entities.GssCompañia>((Expression<Func<AppService.Core.Entities.GssUnidadServicioCompañia, AppService.Core.Entities.GssCompañia>>)(d => d.IdCompañiaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssCompañia, IEnumerable<AppService.Core.Entities.GssUnidadServicioCompañia>>>)(p => p.GssUnidadServicioCompañia)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssUnidadServicioCompañia, object>>)(d => (object)d.IdCompañia)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssCompañia, AppService.Core.Entities.GssUnidadServicioCompañia>("FK_GssUnidadServicioCompañia_GssCompañia");
                entity.HasOne<AppService.Core.Entities.GssUnidadServicio>((Expression<Func<AppService.Core.Entities.GssUnidadServicioCompañia, AppService.Core.Entities.GssUnidadServicio>>)(d => d.IdUnidadServicioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssUnidadServicio, IEnumerable<AppService.Core.Entities.GssUnidadServicioCompañia>>>)(p => p.GssUnidadServicioCompañia)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssUnidadServicioCompañia, object>>)(d => (object)d.IdUnidadServicio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssUnidadServicio, AppService.Core.Entities.GssUnidadServicioCompañia>("FK_GssUnidadServicioCompañia_GssUnidadServicio");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssUsuarioCompañia>((Action<EntityTypeBuilder<AppService.Core.Entities.GssUsuarioCompañia>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssUsuarioCompañia, object>>)(e => (object)e.IdUsuarioCompañia));
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssUsuarioCompañia, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.HasOne<AppService.Core.Entities.GssCompañia>((Expression<Func<AppService.Core.Entities.GssUsuarioCompañia, AppService.Core.Entities.GssCompañia>>)(d => d.IdCompañiaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssCompañia, IEnumerable<AppService.Core.Entities.GssUsuarioCompañia>>>)(p => p.GssUsuarioCompañia)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssUsuarioCompañia, object>>)(d => (object)d.IdCompañia)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssCompañia, AppService.Core.Entities.GssUsuarioCompañia>("FK_GssUsuarioCompañia_GssCompañia");
                entity.HasOne<AppService.Core.Entities.SegUsuario>((Expression<Func<AppService.Core.Entities.GssUsuarioCompañia, AppService.Core.Entities.SegUsuario>>)(d => d.IdUsuarioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.SegUsuario, IEnumerable<AppService.Core.Entities.GssUsuarioCompañia>>>)(p => p.GssUsuarioCompañia)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssUsuarioCompañia, object>>)(d => (object)d.IdUsuario)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.SegUsuario, AppService.Core.Entities.GssUsuarioCompañia>("FK_GssUsuarioCompañia_SegUsuario");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssUsuarioNivel>((Action<EntityTypeBuilder<AppService.Core.Entities.GssUsuarioNivel>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssUsuarioNivel, object>>)(e => (object)e.IdUsuarioNivel));
                entity.HasComment<AppService.Core.Entities.GssUsuarioNivel>("Usuario por niveles de servicio");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssUsuarioNivel, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.HasOne<AppService.Core.Entities.GssNivel>((Expression<Func<AppService.Core.Entities.GssUsuarioNivel, AppService.Core.Entities.GssNivel>>)(d => d.IdNivelNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssNivel, IEnumerable<AppService.Core.Entities.GssUsuarioNivel>>>)(p => p.GssUsuarioNivel)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssUsuarioNivel, object>>)(d => (object)d.IdNivel)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssNivel, AppService.Core.Entities.GssUsuarioNivel>("FK_GssUsuarioNivel_GssNivel");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssUsuarioPlantillaServicio>((Action<EntityTypeBuilder<AppService.Core.Entities.GssUsuarioPlantillaServicio>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssUsuarioPlantillaServicio, object>>)(e => (object)e.IdUsuarioPlantillaServicio)).HasName("PK_GssUsuarioPlantillaServicio_1");
                entity.HasOne<AppService.Core.Entities.GssServicios>((Expression<Func<AppService.Core.Entities.GssUsuarioPlantillaServicio, AppService.Core.Entities.GssServicios>>)(d => d.IdServicioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssServicios, IEnumerable<AppService.Core.Entities.GssUsuarioPlantillaServicio>>>)(p => p.GssUsuarioPlantillaServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssUsuarioPlantillaServicio, object>>)(d => (object)d.IdServicio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssServicios, AppService.Core.Entities.GssUsuarioPlantillaServicio>("FK_GssUsuarioPlantillaServicio_GssServicios");
                entity.HasOne<AppService.Core.Entities.GssVariable>((Expression<Func<AppService.Core.Entities.GssUsuarioPlantillaServicio, AppService.Core.Entities.GssVariable>>)(d => d.IdVariableNavigation)).WithMany((Expression<Func<AppService.Core.Entities.GssVariable, IEnumerable<AppService.Core.Entities.GssUsuarioPlantillaServicio>>>)(p => p.GssUsuarioPlantillaServicio)).HasForeignKey((Expression<Func<AppService.Core.Entities.GssUsuarioPlantillaServicio, object>>)(d => (object)d.IdVariable)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.GssVariable, AppService.Core.Entities.GssUsuarioPlantillaServicio>("FK_GssUsuarioPlantillaServicio_GssVariable");
            }));
            modelBuilder.Entity<AppService.Core.Entities.GssVariable>((Action<EntityTypeBuilder<AppService.Core.Entities.GssVariable>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.GssVariable, object>>)(e => (object)e.IdVariable)).HasName("PK_GssVariablesPlantilla");
                entity.HasComment<AppService.Core.Entities.GssVariable>("Variables de entrada por plantilla de servicio");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.GssVariable, DateTime>>)(e => e.FechaCambio)).HasColumnType<DateTime>("datetime");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.GssVariable, bool?>>)(e => e.FlagGenerica)).IsRequired(true).HasDefaultValueSql<bool?>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssVariable, string>>)(e => e.FuncionBusqueda)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssVariable, string>>)(e => e.NombreVariable)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssVariable, string>>)(e => e.TipoDato)).IsRequired(true).HasMaxLength(30);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.GssVariable, string>>)(e => e.TituloVariable)).IsRequired(true).HasMaxLength(60);
            }));
            modelBuilder.Entity<AppService.Core.Entities.Marm>((Action<EntityTypeBuilder<AppService.Core.Entities.Marm>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.Marm>("MARM");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.Marm, object>>)(e => new
                {
                    Matnr = e.Matnr,
                    Meinh = e.Meinh
                })).HasName<AppService.Core.Entities.Marm>("IX_MARM").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Atinn)).IsRequired(true).HasColumnName<string>("ATINN").HasMaxLength(60);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.BflmeMarm)).IsRequired(true).HasColumnName<string>("BFLME_MARM").HasMaxLength(6);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Marm, Decimal>>)(e => e.Breit)).HasColumnName<Decimal>("BREIT").HasColumnType<Decimal>("decimal(13, 3)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Marm, Decimal>>)(e => e.Brgew)).HasColumnName<Decimal>("BRGEW").HasColumnType<Decimal>("decimal(13, 3)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Marm, Decimal>>)(e => e.Capause)).HasColumnName<Decimal>("CAPAUSE").HasColumnType<Decimal>("decimal(15, 3)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Ean11)).IsRequired(true).HasColumnName<string>("EAN11").HasMaxLength(108);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Eannr)).IsRequired(true).HasColumnName<string>("EANNR").HasMaxLength(78);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Gewei)).IsRequired(true).HasColumnName<string>("GEWEI").HasMaxLength(18);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.GtinVariant)).IsRequired(true).HasColumnName<string>("GTIN_VARIANT").HasMaxLength(12);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Marm, Decimal>>)(e => e.Hoehe)).HasColumnName<Decimal>("HOEHE").HasColumnType<Decimal>("decimal(13, 3)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Kzwso)).IsRequired(true).HasColumnName<string>("KZWSO").HasMaxLength(6);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Marm, Decimal>>)(e => e.Laeng)).HasColumnName<Decimal>("LAENG").HasColumnType<Decimal>("decimal(13, 3)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Mandt)).IsRequired(true).HasColumnName<string>("MANDT").HasMaxLength(18);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Matnr)).IsRequired(true).HasColumnName<string>("MATNR").HasMaxLength(12);
                entity.Property<byte>((Expression<Func<AppService.Core.Entities.Marm, byte>>)(e => e.MaxStack)).HasColumnName<byte>("MAX_STACK");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Meabm)).IsRequired(true).HasColumnName<string>("MEABM").HasMaxLength(18);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Meinh)).IsRequired(true).HasColumnName<string>("MEINH").HasMaxLength(18);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Mesrt)).IsRequired(true).HasColumnName<string>("MESRT").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Mesub)).IsRequired(true).HasColumnName<string>("MESUB").HasMaxLength(18);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Msehi)).IsRequired(true).HasColumnName<string>("MSEHI").HasMaxLength(18);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Marm, Decimal>>)(e => e.NestFtr)).HasColumnName<Decimal>("NEST_FTR").HasColumnType<Decimal>("decimal(3, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Numtp)).IsRequired(true).HasColumnName<string>("NUMTP").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Ty2tq)).IsRequired(true).HasColumnName<string>("TY2TQ").HasMaxLength(6);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Marm, Decimal>>)(e => e.Umren)).HasColumnName<Decimal>("UMREN").HasColumnType<Decimal>("decimal(5, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Marm, Decimal>>)(e => e.Umrez)).HasColumnName<Decimal>("UMREZ").HasColumnType<Decimal>("decimal(5, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Voleh)).IsRequired(true).HasColumnName<string>("VOLEH").HasMaxLength(18);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Marm, Decimal>>)(e => e.Volum)).HasColumnName<Decimal>("VOLUM").HasColumnType<Decimal>("decimal(13, 3)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Xbeww)).IsRequired(true).HasColumnName<string>("XBEWW").HasMaxLength(6);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Marm, string>>)(e => e.Xfhdw)).IsRequired(true).HasColumnName<string>("XFHDW").HasMaxLength(6);
                entity.HasOne<AppService.Core.Entities.MtrProducto>((Expression<Func<AppService.Core.Entities.Marm, AppService.Core.Entities.MtrProducto>>)(d => d.MatnrNavigation)).WithMany((string)null).HasForeignKey((Expression<Func<AppService.Core.Entities.Marm, object>>)(d => d.Matnr)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrProducto, AppService.Core.Entities.Marm>("FK_MARM_MtrProducto");
                entity.HasOne<AppService.Core.Entities.T006a>((Expression<Func<AppService.Core.Entities.Marm, AppService.Core.Entities.T006a>>)(d => d.MeinhNavigation)).WithMany((string)null).HasForeignKey((Expression<Func<AppService.Core.Entities.Marm, object>>)(d => d.Meinh)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.T006a, AppService.Core.Entities.Marm>("FK_MARM_T006A");
            }));
            modelBuilder.Entity<AppService.Core.Entities.MigrationHistory>((Action<EntityTypeBuilder<AppService.Core.Entities.MigrationHistory>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MigrationHistory, object>>)(e => new
                {
                    MigrationId = e.MigrationId,
                    ContextKey = e.ContextKey
                })).HasName("PK_dbo.__MigrationHistory");
                entity.ToTable<AppService.Core.Entities.MigrationHistory>("__MigrationHistory");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MigrationHistory, string>>)(e => e.MigrationId)).HasMaxLength(150);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MigrationHistory, string>>)(e => e.ContextKey)).HasMaxLength(300);
                entity.Property<byte[]>((Expression<Func<AppService.Core.Entities.MigrationHistory, byte[]>>)(e => e.Model)).IsRequired(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MigrationHistory, string>>)(e => e.ProductVersion)).IsRequired(true).HasMaxLength(32);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrBancos>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrBancos>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrBancos, object>>)(e => e.Codigo)).HasName("WARY075_INDEX01");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrBancos, string>>)(e => e.Codigo)).HasColumnName<string>("CODIGO").HasMaxLength(4).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrBancos, string>>)(e => e.AplicaImp)).IsRequired(true).HasColumnName<string>("APLICA_IMP").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrBancos, string>>)(e => e.CodContable)).IsRequired(true).HasColumnName<string>("COD_CONTABLE").HasMaxLength(11).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrBancos, string>>)(e => e.Nombre)).IsRequired(true).HasColumnName<string>("NOMBRE").HasMaxLength(40).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrBancos, string>>)(e => e.ProdGenerico)).HasColumnName<string>("PROD_GENERICO").HasMaxLength(20).IsFixedLength<string>();
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrBancos, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrBancos, string>>)(e => e.TraAsociada)).HasColumnName<string>("TRA_ASOCIADA").HasMaxLength(2).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrBancos, string>>)(e => e.TraJde)).HasColumnName<string>("TRA_JDE").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.HasOne<AppService.Core.Entities.MtrTipoCuentaDestino>((Expression<Func<AppService.Core.Entities.MtrBancos, AppService.Core.Entities.MtrTipoCuentaDestino>>)(d => d.IdTipoCuentaDestinoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrTipoCuentaDestino, IEnumerable<AppService.Core.Entities.MtrBancos>>>)(p => p.MtrBancos)).HasForeignKey((Expression<Func<AppService.Core.Entities.MtrBancos, object>>)(d => (object)d.IdTipoCuentaDestino)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrTipoCuentaDestino, AppService.Core.Entities.MtrBancos>("FK_MtrBancos_MtrTipoCuentaDestino");
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrCliente>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrCliente>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrCliente, object>>)(e => e.Codigo));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrCliente, object>>)(e => (object)e.CodJde)).HasName<AppService.Core.Entities.MtrCliente>("IX_MtrCliente_2");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrCliente, object>>)(e => e.Codigo)).HasName<AppService.Core.Entities.MtrCliente>("IX_MtrCliente");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrCliente, object>>)(e => e.FlagInactivo)).HasName<AppService.Core.Entities.MtrCliente>("IX_MtrCliente_5");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrCliente, object>>)(e => e.Nombre)).HasName<AppService.Core.Entities.MtrCliente>("IX_MtrCliente_4");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrCliente, object>>)(e => e.OficinaVenta)).HasName<AppService.Core.Entities.MtrCliente>("IX_MtrCliente_3");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrCliente, object>>)(e => e.Vendedor1)).HasName<AppService.Core.Entities.MtrCliente>("IX_MtrCliente_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrCliente, object>>)(e => new
                {
                    Codigo = e.Codigo,
                    NoRegTribut = e.NoRegTribut,
                    Nombre = e.Nombre
                })).HasName<AppService.Core.Entities.MtrCliente>("IX_MtrCliente_6");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Codigo)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.AreaCobranz)).HasColumnName<string>("Area_Cobranz").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Asignacion)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Canal)).HasColumnName<string>("CANAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrCliente, Decimal?>>)(e => e.CapitalSoc)).HasColumnName<Decimal?>("CAPITAL_SOC").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Categoria)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.CierreEjerc)).HasColumnName<DateTime?>("CIERRE_EJERC").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ClientContado)).HasColumnName<string>("Client_Contado").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ClienteNuevo)).HasColumnName<string>("Cliente_Nuevo").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Cobrador)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.MtrCliente, double?>>)(e => e.CodJde)).HasColumnName<double?>("cod_jde");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.MtrCliente, double?>>)(e => e.CodJdePadre)).HasColumnName<double?>("Cod_jdePadre");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.CodMcpo)).HasColumnName<string>("Cod_Mcpo").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.CodProveedor)).HasColumnName<string>("Cod_Proveedor").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.CodSubSegmento)).HasColumnName<string>("Cod_SubSegmento").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.CodigoCiudad)).HasColumnName<string>("Codigo_Ciudad").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.CodigoEstado)).HasColumnName<string>("Codigo_Estado").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.CodigoMcpo)).HasColumnName<string>("Codigo_Mcpo").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrCliente, Decimal?>>)(e => e.CodigoNumerico)).HasColumnName<Decimal?>("codigo_numerico").HasColumnType<Decimal?>("numeric(6, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.CodigoParroq)).HasColumnName<string>("Codigo_Parroq").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.CodigoPostal)).HasColumnName<string>("Codigo_Postal").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.CodigoRegion)).HasColumnName<string>("Codigo_Region").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrCliente, Decimal?>>)(e => e.CondPago)).HasColumnName<Decimal?>("COND_PAGO").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContCarg1)).HasColumnName<string>("Cont_Carg_1").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContCarg2)).HasColumnName<string>("Cont_Carg_2").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContCarg3)).HasColumnName<string>("Cont_Carg_3").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContEmail1)).HasColumnName<string>("Cont_Email_1").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContEmail2)).HasColumnName<string>("Cont_Email_2").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContEmail3)).HasColumnName<string>("Cont_Email_3").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContEspecial)).HasColumnName<string>("Cont_Especial").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.ContFechNacm1)).HasColumnName<DateTime?>("Cont_FechNacm_1").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.ContFechNacm2)).HasColumnName<DateTime?>("Cont_FechNacm_2").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.ContFechNacm3)).HasColumnName<DateTime?>("Cont_FechNacm_3").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContNomb1)).HasColumnName<string>("Cont_Nomb_1").HasMaxLength(30).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContNomb2)).HasColumnName<string>("Cont_Nomb_2").HasMaxLength(30).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContNomb3)).HasColumnName<string>("Cont_Nomb_3").HasMaxLength(30).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContTelf1)).HasColumnName<string>("Cont_Telf_1").HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContTelf2)).HasColumnName<string>("Cont_Telf_2").HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ContTelf3)).HasColumnName<string>("Cont_Telf_3").HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.DepuraCod)).HasColumnName<string>("DEPURA_COD").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Depurar)).HasColumnName<string>("depurar").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.DiaDeCobro)).HasColumnName<string>("Dia_de_Cobro").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Direccion)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Direccion1)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Direccion2)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.EMailClient)).HasColumnName<string>("E_mail_Client").HasMaxLength(120).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Estado)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.ExentoDeImpuesto)).HasColumnName<string>("Exento_de_Impuesto").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.FApertura)).HasColumnName<DateTime?>("F_Apertura").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.FModificacion)).HasColumnName<DateTime?>("F_Modificacion").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.FUltmCompra)).HasColumnName<DateTime?>("F_Ultm_Compra").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Fax)).HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.FechaAtendido)).HasColumnName<DateTime?>("Fecha_Atendido").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.FechaCerrado)).HasColumnName<DateTime?>("Fecha_Cerrado").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.FechaDesatendido)).HasColumnName<DateTime?>("Fecha_Desatendido").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.FechaInactivo)).HasColumnName<DateTime?>("Fecha_Inactivo").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.FechaLegal)).HasColumnName<DateTime?>("FECHA_LEGAL").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.FechaModificadoLimite)).HasColumnName<DateTime?>("Fecha_modificado_Limite").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.FechaReactivado)).HasColumnName<DateTime?>("Fecha_Reactivado").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrCliente, DateTime?>>)(e => e.FechaRiesgo)).HasColumnName<DateTime?>("FECHA_RIESGO").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.FlagAtendido)).HasColumnName<string>("Flag_Atendido").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.FlagCerrado)).HasColumnName<string>("Flag_Cerrado").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.FlagInactivo)).HasColumnName<string>("Flag_Inactivo").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.FlagMat)).HasColumnName<string>("Flag_Mat").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.FlagMod03)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.FlagModificado)).HasColumnName<string>("Flag_Modificado").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.FlagNuevo)).HasColumnName<string>("Flag_Nuevo").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.GiroNegocio)).HasColumnName<string>("Giro_Negocio").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Grupo)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrCliente, Decimal?>>)(e => e.GrupoCliente)).HasColumnName<Decimal?>("GRUPO_CLIENTE").HasColumnType<Decimal?>("numeric(5, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrCliente, Decimal?>>)(e => e.IdDireccion)).HasColumnName<Decimal?>("Id_direccion").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Klabc)).HasColumnName<string>("KLABC").HasMaxLength(2).HasDefaultValueSql<string>("(N'C')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrCliente, Decimal?>>)(e => e.LCredito)).HasColumnName<Decimal?>("L_Credito").HasColumnType<Decimal?>("money");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Legal)).HasColumnName<string>("LEGAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrCliente, Decimal?>>)(e => e.LimiteCredUt)).HasColumnName<Decimal?>("Limite_Cred_Ut").HasColumnType<Decimal?>("numeric(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Municipio)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Nit)).HasMaxLength(14).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.NoPasoJde)).HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.NoRegTribut)).HasColumnName<string>("No_Reg_Tribut").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Nombre)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Observaciones)).HasMaxLength(70).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.OficinaVenta)).HasColumnName<string>("Oficina_Venta").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.OrdenCompra)).HasColumnName<string>("Orden_Compra").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.PaginaWeb)).HasColumnName<string>("Pagina_Web").HasMaxLength(100).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.RepresLegal)).HasColumnName<string>("Repres_Legal").HasMaxLength(30).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Riesgo)).HasColumnName<string>("RIESGO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrCliente, Decimal?>>)(e => e.Rsaldo)).HasColumnName<Decimal?>("RSaldo").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.RutCartero)).HasColumnName<string>("Rut_Cartero").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrCliente, Decimal?>>)(e => e.Saldo)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Segmento)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.SiDolares)).HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Smacc)).HasColumnName<string>("smacc").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.SubSegmentoa)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.MtrCliente, int?>>)(e => e.TImpuesto)).HasColumnName<int?>("T_Impuesto");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Telefono)).HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Telefono1)).HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.TipoNegocio)).HasColumnName<string>("Tipo_Negocio").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.UsuarioMod)).HasColumnName<string>("USUARIO_MOD").HasMaxLength(30).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Vendedor1)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Zona)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Zzsn01)).HasColumnName<string>("ZZSN01").HasMaxLength(50).HasComment<string>("Página Web");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Zzsn02)).HasColumnName<string>("ZZSN02").HasMaxLength(50).HasComment<string>("Facebook");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Zzsn03)).HasColumnName<string>("ZZSN03").HasMaxLength(50).HasComment<string>("Google+");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Zzsn04)).HasColumnName<string>("ZZSN04").HasMaxLength(50).HasComment<string>("Instagram");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Zzsn05)).HasColumnName<string>("ZZSN05").HasMaxLength(50).HasComment<string>("Twitter");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCliente, string>>)(e => e.Zzsn06)).HasColumnName<string>("ZZSN06").HasMaxLength(8);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrClienteProspecto>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrClienteProspecto>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrClienteProspecto, object>>)(e => e.IdCliente));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrClienteProspecto, object>>)(e => e.Rif)).HasName<AppService.Core.Entities.MtrClienteProspecto>("IX_Rif").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteProspecto, string>>)(e => e.IdCliente)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteProspecto, string>>)(e => e.Direccion)).HasMaxLength(240);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.MtrClienteProspecto, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteProspecto, string>>)(e => e.IdVendedor)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteProspecto, string>>)(e => e.NombreCliente)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteProspecto, string>>)(e => e.Rif)).HasMaxLength(12);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrClienteTemp>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrClienteTemp>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrClienteTemp, object>>)(e => e.Codigo)).HasName("PK_MtrCliente_temp");
                entity.ToTable<AppService.Core.Entities.MtrClienteTemp>("MtrCliente_Temp");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Codigo)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.AreaCobranz)).HasColumnName<string>("Area_Cobranz").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Asignacion)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Canal)).HasColumnName<string>("CANAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, Decimal?>>)(e => e.CapitalSoc)).HasColumnName<Decimal?>("CAPITAL_SOC").HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Categoria)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.CierreEjerc)).HasColumnName<DateTime?>("CIERRE_EJERC").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ClientContado)).HasColumnName<string>("Client_Contado").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ClienteNuevo)).HasColumnName<string>("Cliente_Nuevo").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Cobrador)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, double?>>)(e => e.CodJde)).HasColumnName<double?>("cod_jde");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, double?>>)(e => e.CodJdePadre)).HasColumnName<double?>("Cod_jdePadre");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.CodMcpo)).HasColumnName<string>("Cod_Mcpo").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.CodProveedor)).HasColumnName<string>("Cod_Proveedor").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.CodSubSegmento)).HasColumnName<string>("Cod_SubSegmento").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.CodigoCiudad)).HasColumnName<string>("Codigo_Ciudad").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.CodigoEstado)).HasColumnName<string>("Codigo_Estado").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.CodigoMcpo)).HasColumnName<string>("Codigo_Mcpo").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, Decimal?>>)(e => e.CodigoNumerico)).HasColumnName<Decimal?>("codigo_numerico").HasColumnType<Decimal?>("numeric(6, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.CodigoParroq)).HasColumnName<string>("Codigo_Parroq").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.CodigoPostal)).HasColumnName<string>("Codigo_Postal").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.CodigoRegion)).HasColumnName<string>("Codigo_Region").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, Decimal?>>)(e => e.CondPago)).HasColumnName<Decimal?>("COND_PAGO").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContCarg1)).HasColumnName<string>("Cont_Carg_1").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContCarg2)).HasColumnName<string>("Cont_Carg_2").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContCarg3)).HasColumnName<string>("Cont_Carg_3").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContEmail1)).HasColumnName<string>("Cont_Email_1").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContEmail2)).HasColumnName<string>("Cont_Email_2").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContEmail3)).HasColumnName<string>("Cont_Email_3").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContEspecial)).HasColumnName<string>("Cont_Especial").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.ContFechNacm1)).HasColumnName<DateTime?>("Cont_FechNacm_1").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.ContFechNacm2)).HasColumnName<DateTime?>("Cont_FechNacm_2").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.ContFechNacm3)).HasColumnName<DateTime?>("Cont_FechNacm_3").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContNomb1)).HasColumnName<string>("Cont_Nomb_1").HasMaxLength(30).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContNomb2)).HasColumnName<string>("Cont_Nomb_2").HasMaxLength(30).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContNomb3)).HasColumnName<string>("Cont_Nomb_3").HasMaxLength(30).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContTelf1)).HasColumnName<string>("Cont_Telf_1").HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContTelf2)).HasColumnName<string>("Cont_Telf_2").HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ContTelf3)).HasColumnName<string>("Cont_Telf_3").HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.DepuraCod)).HasColumnName<string>("DEPURA_COD").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Depurar)).HasColumnName<string>("depurar").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.DiaDeCobro)).HasColumnName<string>("Dia_de_Cobro").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Direccion)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Direccion1)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Direccion2)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.EMailClient)).HasColumnName<string>("E_mail_Client").HasMaxLength(120).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Estado)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.ExentoDeImpuesto)).HasColumnName<string>("Exento_de_Impuesto").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.FApertura)).HasColumnName<DateTime?>("F_Apertura").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.FModificacion)).HasColumnName<DateTime?>("F_Modificacion").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.FUltmCompra)).HasColumnName<DateTime?>("F_Ultm_Compra").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Fax)).HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.FechaAtendido)).HasColumnName<DateTime?>("Fecha_Atendido").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.FechaCerrado)).HasColumnName<DateTime?>("Fecha_Cerrado").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.FechaDesatendido)).HasColumnName<DateTime?>("Fecha_Desatendido").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.FechaInactivo)).HasColumnName<DateTime?>("Fecha_Inactivo").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.FechaLegal)).HasColumnName<DateTime?>("FECHA_LEGAL").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.FechaModificadoLimite)).HasColumnName<DateTime?>("Fecha_modificado_Limite").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.FechaReactivado)).HasColumnName<DateTime?>("Fecha_Reactivado").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, DateTime?>>)(e => e.FechaRiesgo)).HasColumnName<DateTime?>("FECHA_RIESGO").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.FlagAtendido)).HasColumnName<string>("Flag_Atendido").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.FlagCerrado)).HasColumnName<string>("Flag_Cerrado").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.FlagInactivo)).HasColumnName<string>("Flag_Inactivo").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.FlagMat)).HasColumnName<string>("Flag_Mat").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.FlagMod03)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.FlagModificado)).HasColumnName<string>("Flag_Modificado").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.FlagNuevo)).HasColumnName<string>("Flag_Nuevo").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.GiroNegocio)).HasColumnName<string>("Giro_Negocio").HasMaxLength(60).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Grupo)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, Decimal?>>)(e => e.GrupoCliente)).HasColumnName<Decimal?>("GRUPO_CLIENTE").HasColumnType<Decimal?>("numeric(5, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, Decimal?>>)(e => e.IdDireccion)).HasColumnName<Decimal?>("Id_direccion").HasColumnType<Decimal?>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Klabc)).HasColumnName<string>("KLABC").HasMaxLength(2).HasDefaultValueSql<string>("(N'C')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, Decimal?>>)(e => e.LCredito)).HasColumnName<Decimal?>("L_Credito").HasColumnType<Decimal?>("money");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Legal)).HasColumnName<string>("LEGAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, Decimal?>>)(e => e.LimiteCredUt)).HasColumnName<Decimal?>("Limite_Cred_Ut").HasColumnType<Decimal?>("numeric(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Municipio)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Nit)).HasMaxLength(14).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.NoPasoJde)).HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.NoRegTribut)).HasColumnName<string>("No_Reg_Tribut").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Nombre)).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Observaciones)).HasMaxLength(70).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.OficinaVenta)).HasColumnName<string>("Oficina_Venta").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.OrdenCompra)).HasColumnName<string>("Orden_Compra").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.PaginaWeb)).HasColumnName<string>("Pagina_Web").HasMaxLength(100).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.RepresLegal)).HasColumnName<string>("Repres_Legal").HasMaxLength(30).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Riesgo)).HasColumnName<string>("RIESGO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.RutCartero)).HasColumnName<string>("Rut_Cartero").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, Decimal?>>)(e => e.Saldo)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Segmento)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.SiDolares)).HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Smacc)).HasColumnName<string>("smacc").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.SubSegmentoa)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, int?>>)(e => e.TImpuesto)).HasColumnName<int?>("T_Impuesto");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Telefono)).HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Telefono1)).HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.TipoNegocio)).HasColumnName<string>("Tipo_Negocio").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.UsuarioMod)).HasColumnName<string>("USUARIO_MOD").HasMaxLength(30).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Vendedor1)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Zona)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Zzsn01)).HasColumnName<string>("ZZSN01").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Zzsn02)).HasColumnName<string>("ZZSN02").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Zzsn03)).HasColumnName<string>("ZZSN03").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Zzsn04)).HasColumnName<string>("ZZSN04").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Zzsn05)).HasColumnName<string>("ZZSN05").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrClienteTemp, string>>)(e => e.Zzsn06)).HasColumnName<string>("ZZSN06").HasMaxLength(8);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrCondicionPago>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrCondicionPago>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrCondicionPago, object>>)(e => (object)e.Codigo));
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrCondicionPago, short>>)(e => e.Codigo)).HasColumnName<short>("CODIGO").ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCondicionPago, string>>)(e => e.AprobCredM)).HasColumnName<string>("APROB_CRED_M").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCondicionPago, string>>)(e => e.CodJde)).HasColumnName<string>("COD_JDE").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCondicionPago, string>>)(e => e.CondicionSap)).IsRequired(true).HasColumnName<string>("CondicionSAP").HasMaxLength(4).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCondicionPago, string>>)(e => e.Descripcion)).IsRequired(true).HasColumnName<string>("DESCRIPCION").HasMaxLength(50).IsUnicode(false);
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrCondicionPago, short>>)(e => e.DiasVcto)).HasColumnName<short>("DIAS_VCTO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCondicionPago, string>>)(e => e.Inactivo)).HasColumnName<string>("inactivo").HasMaxLength(1).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrCondicionPago, Decimal?>>)(e => e.PorcRequerido)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrCondicionPago, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrCondicionPago, string>>)(e => e.RequiereLimiteCredito)).HasMaxLength(1).IsFixedLength<string>();
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrContactos>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrContactos>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrContactos, object>>)(e => (object)e.IdContacto));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrContactos, object>>)(e => e.Email)).HasName<AppService.Core.Entities.MtrContactos>("IX_MtrContactos");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrContactos, object>>)(e => e.IdCliente)).HasName<AppService.Core.Entities.MtrContactos>("IX_MtrContactos_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrContactos, object>>)(e => new
                {
                    IdCliente = e.IdCliente,
                    Rif = e.Rif
                })).HasName<AppService.Core.Entities.MtrContactos>("IX_MtrContactos_2");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.MtrContactos, long>>)(e => e.IdContacto)).ValueGeneratedNever();
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.MtrContactos, bool?>>)(e => e.AceptaEmail)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.MtrContactos, bool?>>)(e => e.AceptaSms)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrContactos, string>>)(e => e.Area)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrContactos, string>>)(e => e.Cargo)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrContactos, string>>)(e => e.Celular)).HasMaxLength(50).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrContactos, string>>)(e => e.Email)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrContactos, string>>)(e => e.Fax)).HasMaxLength(50).HasDefaultValueSql<string>("('')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrContactos, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("smalldatetime").HasDefaultValueSql<DateTime?>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrContactos, string>>)(e => e.IdCliente)).IsRequired(true).HasMaxLength(10);
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.MtrContactos, bool?>>)(e => e.Inactivo)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrContactos, string>>)(e => e.Nombre)).IsRequired(true).HasMaxLength(50);
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.MtrContactos, bool?>>)(e => e.Prospecto)).HasDefaultValueSql<bool?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrContactos, string>>)(e => e.Rif)).IsRequired(true).HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrContactos, string>>)(e => e.Telefono1)).HasMaxLength(50).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrContactos, string>>)(e => e.Telefono2)).HasMaxLength(50).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrContactos, string>>)(e => e.Usuario)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrDirecciones>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrDirecciones>>)(entity =>
            {
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrDirecciones, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Codigo)).IsRequired(true).HasMaxLength(150);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Direccion)).HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Direccion1)).HasColumnName<string>("Direccion_1").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Direccion2)).HasColumnName<string>("Direccion_2").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Estado)).HasColumnName<string>("ESTADO").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.FechaAprobacionDireccion)).HasMaxLength(50);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrDirecciones, DateTime?>>)(e => e.FechaUpdate)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.FuncionInterlocutor)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Municipio)).HasColumnName<string>("MUNICIPIO").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Nuevo)).HasColumnName<string>("NUEVO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Origen)).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Ort02)).HasColumnName<string>("ORT02").HasMaxLength(35);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.PuntoReferencia)).HasMaxLength(80);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrDirecciones, Decimal>>)(e => e.Recnum)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Rif)).IsRequired(true).HasMaxLength(12).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.StmpAddr)).HasColumnName<string>("STMP_ADDR").HasMaxLength(240);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Telf1)).HasColumnName<string>("TELF1").HasMaxLength(30);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Telf2)).HasColumnName<string>("TELF2").HasMaxLength(30);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.UsuarioAprobacionDireccion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Zzsn01)).HasColumnName<string>("ZZSN01").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Zzsn02)).HasColumnName<string>("ZZSN02").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Zzsn03)).HasColumnName<string>("ZZSN03").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Zzsn04)).HasColumnName<string>("ZZSN04").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Zzsn05)).HasColumnName<string>("ZZSN05").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrDirecciones, string>>)(e => e.Zzsn06)).HasColumnName<string>("ZZSN06").HasMaxLength(8);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrEmpleado>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrEmpleado>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrEmpleado, object>>)(e => e.IdEmpleado));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.IdEmpleado)).HasMaxLength(10).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.Categoria1)).HasMaxLength(4).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.Categoria2)).HasMaxLength(4).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.Categoria3)).HasMaxLength(4).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.Cedula)).HasMaxLength(20).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.Cuenta)).HasMaxLength(20).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.Direccion1)).HasMaxLength(40).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.Direccion2)).HasMaxLength(40).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.Email)).HasColumnName<string>("email").HasMaxLength(80).HasDefaultValueSql<string>("('')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrEmpleado, DateTime?>>)(e => e.FechaIngreso)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrEmpleado, DateTime?>>)(e => e.FechaNacimiento)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrEmpleado, DateTime?>>)(e => e.FechaRetiro)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.IdCargo)).HasMaxLength(10).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.IdDepartamento)).HasMaxLength(10).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.IdGrupo)).HasMaxLength(2).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.IdSupervisor)).HasMaxLength(10).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.NombreEmpleado)).IsRequired(true).HasMaxLength(60).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.Rif)).HasMaxLength(15).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.SexoEmpleado)).HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.TelefonoCelular)).HasMaxLength(15).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.TelefonoHabitacion)).HasMaxLength(15).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrEmpleado, string>>)(e => e.TipoNomina)).IsRequired(true).HasMaxLength(4).HasDefaultValueSql<string>("('')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrFechaFeriada>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrFechaFeriada>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrFechaFeriada, object>>)(e => (object)e.FechaFeriada));
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.MtrFechaFeriada, DateTime>>)(e => e.FechaFeriada)).HasColumnName<DateTime>("FECHA_FERIADA").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrFechaFeriada, string>>)(e => e.MostrarBs)).IsRequired(true).HasColumnName<string>("MOSTRAR_BS").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrFechaFeriada, string>>)(e => e.Motivo)).IsRequired(true).HasColumnName<string>("MOTIVO").HasMaxLength(20).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrFechaFeriada, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)").ValueGeneratedOnAdd();
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrHorarioLaborable>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrHorarioLaborable>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrHorarioLaborable, object>>)(e => (object)e.IdHorario));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrHorarioLaborable, string>>)(e => e.Almuerzo)).IsRequired(true).HasMaxLength(1);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.MtrHorarioLaborable, DateTime>>)(e => e.Fin)).HasColumnName<DateTime>("fin").HasColumnType<DateTime>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.MtrHorarioLaborable, DateTime>>)(e => e.Inicio)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrHorarioLaborable, string>>)(e => e.Laborable)).IsRequired(true).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrHorarioLaborable, string>>)(e => e.PrimerBloque)).IsRequired(true).HasMaxLength(1);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrOficina>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrOficina>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrOficina, object>>)(e => (object)e.CodOficina));
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrOficina, short>>)(e => e.CodOficina)).HasColumnName<short>("COD_OFICINA").ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.Abreviado)).HasMaxLength(3);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.AdministradoraEmail)).HasColumnName<string>("Administradora_email").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.Analista2Email)).HasColumnName<string>("Analista2_email").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.AnalistaEmail)).HasColumnName<string>("Analista_email").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.Canal)).HasColumnName<string>("CANAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.CarpetaDiseno)).HasColumnName<string>("CARPETA_DISENO").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.ClienteNacionales)).HasColumnName<string>("CLIENTE_NACIONALES").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.CodOficina2)).IsRequired(true).HasColumnName<string>("COD_OFICINA2").HasMaxLength(2).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.CodigoJde)).HasColumnName<string>("CODIGO_JDE").HasMaxLength(3).IsUnicode(false);
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrOficina, short>>)(e => e.CodigoParroq)).HasColumnName<short>("CODIGO_PARROQ");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.DataManagerEmail)).HasColumnName<string>("DataManager_email").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.Direccion)).IsRequired(true).HasColumnName<string>("DIRECCION").HasMaxLength(40).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.Direccion2)).IsRequired(true).HasColumnName<string>("DIRECCION2").HasMaxLength(40).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.Estado)).IsRequired(true).HasColumnName<string>("ESTADO").HasMaxLength(2).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.Fax)).IsRequired(true).HasColumnName<string>("FAX").HasMaxLength(20).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.GerenteOficina)).IsRequired(true).HasColumnName<string>("GERENTE_OFICINA").HasMaxLength(4).IsUnicode(false);
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.MtrOficina, int?>>)(e => e.Idtitulo)).HasColumnName<int?>("IDTITULO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.Municipio)).IsRequired(true).HasColumnName<string>("MUNICIPIO").HasMaxLength(2).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.NomOficina)).IsRequired(true).HasColumnName<string>("NOM_OFICINA").HasMaxLength(25).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.OficinaActiva)).HasColumnName<string>("OFICINA_ACTIVA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrOficina, Decimal>>)(e => e.Override)).HasColumnName<Decimal>("OVERRIDE").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.PAusente)).HasColumnName<string>("P_AUSENTE").HasMaxLength(1).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrOficina, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.Region)).IsRequired(true).HasColumnName<string>("REGION").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.SinImpuesto)).HasColumnName<string>("SIN_IMPUESTO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.Telefono)).IsRequired(true).HasColumnName<string>("TELEFONO").HasMaxLength(25).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.UsuarioAdministradora)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrOficina, string>>)(e => e.UsuarioAnalista)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrPerfilCorreo>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrPerfilCorreo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrPerfilCorreo, object>>)(e => e.PerfilId));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrPerfilCorreo, string>>)(e => e.PerfilId)).HasMaxLength(50);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrPerfilCorreo, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrPerfilCorreo, string>>)(e => e.Perfil)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrProducto>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrProducto>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrProducto, object>>)(e => e.CodigoProduct)).HasName("MtrProducto_INDEX01");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrProducto, object>>)(e => (object)e.Recnum)).HasName<AppService.Core.Entities.MtrProducto>("IX_MtrProducto");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.CodigoProduct)).HasColumnName<string>("CODIGO_PRODUCT").HasMaxLength(12).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Almacensap)).HasColumnName<string>("ALMACENSAP").HasMaxLength(4);
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.MtrProducto, short?>>)(e => e.CantidadXAnch)).HasColumnName<short?>("CANTIDAD_X_ANCH");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.CategoriaDashBoard)).HasMaxLength(40).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.CodJde)).HasColumnName<string>("COD_JDE").HasMaxLength(25).IsUnicode(false);
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.MtrProducto, short?>>)(e => e.CodResponsable)).HasColumnName<short?>("COD_RESPONSABLE").HasDefaultValueSql<short?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Codcorp)).HasColumnName<string>("CODCORP").HasMaxLength(6).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.CodigoCaja)).IsRequired(true).HasMaxLength(6).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.CodprodRpg)).HasColumnName<string>("CODPROD_RPG").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrProducto, Decimal?>>)(e => e.Consecutivo)).HasColumnName<Decimal?>("consecutivo").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrProducto, Decimal?>>)(e => e.CostoReposicion)).HasColumnType<Decimal?>("decimal(18, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.DescripVta)).HasColumnName<string>("DESCRIP_VTA").IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.DescripcionVentas)).HasMaxLength(1000);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.FamiliaProduct)).HasColumnName<string>("FAMILIA_PRODUCT").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.FlagCorp)).HasColumnName<string>("FLAG_CORP").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.FlagCortoTiraje)).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.FlagDesact)).HasColumnName<string>("FLAG_DESACT").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.FlagPrdIntern)).HasColumnName<string>("FLAG_PRD_INTERN").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.FlagPrecioMinimo)).HasMaxLength(1).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.FlagRollo)).HasColumnName<string>("FLAG_ROLLO").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.IdUnidadCosteoSap)).HasColumnName<string>("IdUnidadCosteoSAP").HasMaxLength(18);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrProducto, Decimal>>)(e => e.Idsubcategoria)).HasColumnName<Decimal>("IDSUBCATEGORIA").HasColumnType<Decimal>("decimal(4, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.ImpPorConsumo)).HasColumnName<string>("IMP_POR_CONSUMO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.MtrProducto, short?>>)(e => e.LineaIncoming)).HasColumnName<short?>("LINEA_INCOMING");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.LineaProducto)).HasColumnName<string>("LINEA_PRODUCTO").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.ManejaInv)).HasColumnName<string>("MANEJA_INV").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Miscelaneo)).HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Nombre)).IsRequired(true).HasColumnName<string>("NOMBRE").HasMaxLength(65).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.MtrProducto, short?>>)(e => e.Numero)).HasColumnName<short?>("NUMERO");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrProducto, Decimal>>)(e => e.PesoKilos)).HasColumnType<Decimal>("decimal(7, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrProducto, Decimal?>>)(e => e.PiesCuadradoUnidad)).HasColumnType<Decimal?>("decimal(18, 2)");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.MtrProducto, int?>>)(e => e.PorcCosto)).HasColumnName<int?>("PORC_COSTO");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrProducto, Decimal?>>)(e => e.PorcMcAprob)).HasColumnName<Decimal?>("PORC_MC_APROB").HasColumnType<Decimal?>("decimal(10, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Prefijo)).HasColumnName<string>("PREFIJO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.PrintNoPrint)).HasColumnName<string>("Print_NoPrint").HasMaxLength(15).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrProducto, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Sufijo)).HasColumnName<string>("SUFIJO").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.SujetoALote)).HasColumnName<string>("SUJETO_A_LOTE").HasMaxLength(1);
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.MtrProducto, short?>>)(e => e.TipoProducto)).HasColumnName<short?>("TIPO_PRODUCTO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Titulo)).HasColumnName<string>("TITULO").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Titulo1)).HasColumnName<string>("TITULO1").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Titulo2)).HasColumnName<string>("TITULO2").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Titulo3)).HasColumnName<string>("TITULO3").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Titulo4)).HasColumnName<string>("TITULO4").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.MtrProducto, short?>>)(e => e.Titulo5)).HasColumnName<short?>("TITULO5").HasDefaultValueSql<short?>("('')");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.MtrProducto, short?>>)(e => e.Titulo6)).HasColumnName<short?>("TITULO6").HasDefaultValueSql<short?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.TituloPe)).HasColumnName<string>("TITULO_PE").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.TituloVentas)).HasColumnName<string>("TITULO_VENTAS").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.MtrProducto, short?>>)(e => e.UnidadCosteo)).HasColumnName<short?>("UNIDAD_COSTEO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Unidadsap)).HasColumnName<string>("UNIDADSAP").HasMaxLength(3);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.UnidadsapVenta)).HasColumnName<string>("UNIDADSAP_VENTA").HasMaxLength(3);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.UnidadsapVentainterna)).HasColumnName<string>("UNIDADSAP_VENTAINTERNA").HasMaxLength(3);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProducto, string>>)(e => e.Web)).HasColumnName<string>("WEB").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.HasOne<AppService.Core.Entities.T006a>((Expression<Func<AppService.Core.Entities.MtrProducto, AppService.Core.Entities.T006a>>)(d => d.IdUnidadCosteoSapNavigation)).WithMany((Expression<Func<AppService.Core.Entities.T006a, IEnumerable<AppService.Core.Entities.MtrProducto>>>)(p => p.MtrProducto)).HasForeignKey((Expression<Func<AppService.Core.Entities.MtrProducto, object>>)(d => d.IdUnidadCosteoSap)).HasConstraintName<AppService.Core.Entities.T006a, AppService.Core.Entities.MtrProducto>("FK_MtrProducto_T006A");
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrProductoBasica>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrProductoBasica>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrProductoBasica, object>>)(e => new
                {
                    Producto = e.Producto,
                    MedidaMascara = e.MedidaMascara
                })).HasName("PK_MtrProductoBasica_1");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProductoBasica, string>>)(e => e.Producto)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProductoBasica, string>>)(e => e.MedidaMascara)).HasMaxLength(6);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrProductoBasica, Decimal?>>)(e => e.Frecuencia)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrProductoBasica, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProductoBasica, string>>)(e => e.MedidaFraccion)).IsRequired(true).HasMaxLength(20);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrProductoOpuesta>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrProductoOpuesta>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrProductoOpuesta, object>>)(e => new
                {
                    Producto = e.Producto,
                    MedidaMascara = e.MedidaMascara
                })).HasName("PK_MtrProductoOpuesta_1");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProductoOpuesta, string>>)(e => e.Producto)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProductoOpuesta, string>>)(e => e.MedidaMascara)).HasMaxLength(6);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrProductoOpuesta, Decimal?>>)(e => e.Frecuencia)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrProductoOpuesta, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProductoOpuesta, string>>)(e => e.MedidaFraccion)).IsRequired(true).HasMaxLength(20);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrProductoPapeles>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrProductoPapeles>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrProductoPapeles, object>>)(e => new
                {
                    Producto = e.Producto,
                    Parte = e.Parte,
                    Papel = e.Papel
                }));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProductoPapeles, string>>)(e => e.Producto)).HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProductoPapeles, string>>)(e => e.Papel)).HasMaxLength(8);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrProductoPapeles, string>>)(e => e.Descripcion)).HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrProductoPapeles, Decimal?>>)(e => e.Frecuencia)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrProductoPapeles, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrRegiones>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrRegiones>>)(entity =>
            {
                entity.HasNoKey();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrRegiones, string>>)(e => e.CodigoJde)).HasColumnName<string>("CODIGO_JDE").HasMaxLength(3).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrRegiones, string>>)(e => e.CodigoRegion)).IsRequired(true).HasColumnName<string>("CODIGO_REGION").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrRegiones, string>>)(e => e.GerenteRegion)).IsRequired(true).HasColumnName<string>("GERENTE_REGION").HasMaxLength(4).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrRegiones, string>>)(e => e.NombreRegion)).IsRequired(true).HasColumnName<string>("NOMBRE_REGION").HasMaxLength(25).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrRegiones, Decimal>>)(e => e.OverrideRegion)).HasColumnName<Decimal>("OVERRIDE_REGION").HasColumnType<Decimal>("decimal(14, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrRegiones, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrTipoCuentaDestino>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrTipoCuentaDestino>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrTipoCuentaDestino, object>>)(e => (object)e.IdTipoCuentaDestino));
                entity.Property<int>((Expression<Func<AppService.Core.Entities.MtrTipoCuentaDestino, int>>)(e => e.IdTipoCuentaDestino)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoCuentaDestino, string>>)(e => e.NombreCuentaDestino)).IsRequired(true).HasMaxLength(150);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrTipoDocumentoFiscal>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrTipoDocumentoFiscal>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrTipoDocumentoFiscal, object>>)(e => e.TipoDocumento));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoDocumentoFiscal, string>>)(e => e.TipoDocumento)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoDocumentoFiscal, string>>)(e => e.Descripcion)).IsRequired(true).HasMaxLength(20);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrTipoMoneda>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrTipoMoneda>>)(entity => entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoMoneda, string>>)(e => e.Descripcion)).HasMaxLength(50)));
            modelBuilder.Entity<AppService.Core.Entities.MtrTipoNomina>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrTipoNomina>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrTipoNomina, object>>)(e => e.Tipnom)).HasName("PK_NMT003");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Tipnom)).HasColumnName<string>("TIPNOM").HasMaxLength(4).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Anocom)).HasColumnName<string>("ANOCOM").HasMaxLength(1).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Asifon)).HasColumnName<Decimal?>("ASIFON").HasColumnType<Decimal?>("numeric(4, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Canmin)).HasColumnName<Decimal?>("CANMIN").HasColumnType<Decimal?>("numeric(2, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.CiaCodcia)).HasColumnName<string>("CIA_CODCIA").HasMaxLength(2).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Clanom)).HasColumnName<string>("CLANOM").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Codcon)).HasColumnName<string>("CODCON").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Codpai)).HasColumnName<string>("CODPAI").HasMaxLength(4).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Dedfon)).HasColumnName<Decimal?>("DEDFON").HasColumnType<Decimal?>("numeric(4, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm01)).HasColumnName<string>("DESM01").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm02)).HasColumnName<string>("DESM02").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm03)).HasColumnName<string>("DESM03").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm04)).HasColumnName<string>("DESM04").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm05)).HasColumnName<string>("DESM05").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm06)).HasColumnName<string>("DESM06").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm07)).HasColumnName<string>("DESM07").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm08)).HasColumnName<string>("DESM08").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm09)).HasColumnName<string>("DESM09").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm10)).HasColumnName<string>("DESM10").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm11)).HasColumnName<string>("DESM11").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm12)).HasColumnName<string>("DESM12").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm13)).HasColumnName<string>("DESM13").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm14)).HasColumnName<string>("DESM14").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm15)).HasColumnName<string>("DESM15").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm16)).HasColumnName<string>("DESM16").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm17)).HasColumnName<string>("DESM17").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm18)).HasColumnName<string>("DESM18").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm19)).HasColumnName<string>("DESM19").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desm20)).HasColumnName<string>("DESM20").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Desnom)).HasColumnName<string>("DESNOM").HasMaxLength(40).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Facgua)).HasColumnName<Decimal?>("FACGUA").HasColumnType<Decimal?>("numeric(13, 10)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, DateTime?>>)(e => e.Fecabo)).HasColumnName<DateTime?>("FECABO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, DateTime?>>)(e => e.Fecact)).HasColumnName<DateTime?>("FECACT").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, DateTime?>>)(e => e.Feccre)).HasColumnName<DateTime?>("FECCRE").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, DateTime?>>)(e => e.Fecto1)).HasColumnName<DateTime?>("FECTO1").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, DateTime?>>)(e => e.Fecto2)).HasColumnName<DateTime?>("FECTO2").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, DateTime?>>)(e => e.Fecto3)).HasColumnName<DateTime?>("FECTO3").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, DateTime?>>)(e => e.Fecto4)).HasColumnName<DateTime?>("FECTO4").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, DateTime?>>)(e => e.Fecto5)).HasColumnName<DateTime?>("FECTO5").HasColumnType<DateTime?>("datetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Frenom)).HasColumnName<Decimal?>("FRENOM").HasColumnType<Decimal?>("numeric(2, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Fresue)).HasColumnName<string>("FRESUE").HasMaxLength(1).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Pgmrec)).HasColumnName<string>("PGMREC").HasMaxLength(10).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Reghab)).HasColumnName<string>("REGHAB").HasMaxLength(1).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Salmin)).HasColumnName<Decimal?>("SALMIN").HasColumnType<Decimal?>("numeric(12, 5)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Tasmon)).HasColumnName<Decimal?>("TASMON").HasColumnType<Decimal?>("numeric(13, 10)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Tipfec)).HasColumnName<Decimal?>("TIPFEC").HasColumnType<Decimal?>("numeric(1, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Tipmon)).HasColumnName<string>("TIPMON").HasMaxLength(10).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Topgua)).HasColumnName<Decimal?>("TOPGUA").HasColumnType<Decimal?>("numeric(12, 5)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim01)).HasColumnName<Decimal?>("UNIM01").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim02)).HasColumnName<Decimal?>("UNIM02").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim03)).HasColumnName<Decimal?>("UNIM03").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim04)).HasColumnName<Decimal?>("UNIM04").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim05)).HasColumnName<Decimal?>("UNIM05").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim06)).HasColumnName<Decimal?>("UNIM06").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim07)).HasColumnName<Decimal?>("UNIM07").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim08)).HasColumnName<Decimal?>("UNIM08").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim09)).HasColumnName<Decimal?>("UNIM09").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim10)).HasColumnName<Decimal?>("UNIM10").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim11)).HasColumnName<Decimal?>("UNIM11").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim12)).HasColumnName<Decimal?>("UNIM12").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim13)).HasColumnName<Decimal?>("UNIM13").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim14)).HasColumnName<Decimal?>("UNIM14").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim15)).HasColumnName<Decimal?>("UNIM15").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim16)).HasColumnName<Decimal?>("UNIM16").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim17)).HasColumnName<Decimal?>("UNIM17").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim18)).HasColumnName<Decimal?>("UNIM18").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim19)).HasColumnName<Decimal?>("UNIM19").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Unim20)).HasColumnName<Decimal?>("UNIM20").HasColumnType<Decimal?>("numeric(14, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Usract)).HasColumnName<string>("USRACT").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, string>>)(e => e.Usrcre)).HasColumnName<string>("USRCRE").HasMaxLength(30).IsUnicode(false);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Valfon)).HasColumnName<Decimal?>("VALFON").HasColumnType<Decimal?>("numeric(7, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.MtrTipoNomina, Decimal?>>)(e => e.Valred)).HasColumnName<Decimal?>("VALRED").HasColumnType<Decimal?>("numeric(7, 2)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrTipoOrden>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrTipoOrden>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrTipoOrden, object>>)(e => (object)e.IdTipoOrden));
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrTipoOrden, short>>)(e => e.IdTipoOrden)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoOrden, string>>)(e => e.TipoOrden)).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrTipoTransaccionCuentaDestino>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrTipoTransaccionCuentaDestino>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrTipoTransaccionCuentaDestino, object>>)(e => (object)e.IdTransaccionCuentaDestino));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrTipoTransaccionCuentaDestino, object>>)(e => new
                {
                    IdTipoTransaccion = e.IdTipoTransaccion,
                    IdTipoCuentaDestino = e.IdTipoCuentaDestino
                })).HasName<AppService.Core.Entities.MtrTipoTransaccionCuentaDestino>("IX_MtrTipoTransaccionCuentaDestino").IsUnique(true);
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrTipoTransaccionCuentaDestino, short>>)(e => e.IdTransaccionCuentaDestino)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoTransaccionCuentaDestino, string>>)(e => e.IdTipoTransaccion)).IsRequired(true).HasMaxLength(4);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrTipoValorRetencion>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrTipoValorRetencion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrTipoValorRetencion, object>>)(e => e.IdTipoValor));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoValorRetencion, string>>)(e => e.IdTipoValor)).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrTipoValorRetencion, string>>)(e => e.NombreTipoValor)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrUsuarioOficina>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrUsuarioOficina>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrUsuarioOficina, object>>)(e => new
                {
                    Usuario = e.Usuario,
                    Oficina = e.Oficina
                }));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrUsuarioOficina, object>>)(e => e.Usuario)).HasName<AppService.Core.Entities.MtrUsuarioOficina>("IX_MtrUsuarioOficina");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrUsuarioOficina, string>>)(e => e.Usuario)).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.MtrVendedor>((Action<EntityTypeBuilder<AppService.Core.Entities.MtrVendedor>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.MtrVendedor, object>>)(e => e.Codigo));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.MtrVendedor, object>>)(e => e.Supervisor)).HasName<AppService.Core.Entities.MtrVendedor>("IX_MtrVendedor");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.Codigo)).HasColumnName<string>("CODIGO").HasMaxLength(4).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.Activo)).IsRequired(true).HasColumnName<string>("ACTIVO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.MtrVendedor, double?>>)(e => e.An8)).HasColumnName<double?>("AN8");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.Asignacion)).IsRequired(true).HasColumnName<string>("ASIGNACION").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.Categoria)).IsRequired(true).HasColumnName<string>("CATEGORIA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.ClaseVendedor)).HasColumnName<short>("CLASE_VENDEDOR");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.Club300Asistid)).HasColumnName<short>("CLUB300_ASISTID");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.Cobrador)).IsRequired(true).HasColumnName<string>("COBRADOR").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.CodDivision)).HasColumnName<short>("COD_DIVISION");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.CodigoGrupo)).IsRequired(true).HasColumnName<string>("CODIGO_GRUPO").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.CodigoOverride)).HasColumnName<short>("CODIGO_OVERRIDE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.CodigoRegion)).IsRequired(true).HasColumnName<string>("CODIGO_REGION").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrVendedor, Decimal>>)(e => e.Comision)).HasColumnName<Decimal>("COMISION").HasColumnType<Decimal>("decimal(6, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrVendedor, Decimal>>)(e => e.ComisionComprd)).HasColumnName<Decimal>("COMISION_COMPRD").HasColumnType<Decimal>("decimal(4, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.ComisionFactur)).IsRequired(true).HasColumnName<string>("COMISION_FACTUR").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrVendedor, Decimal>>)(e => e.ComisionImpres)).HasColumnName<Decimal>("COMISION_IMPRES").HasColumnType<Decimal>("decimal(4, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.ComisionOrden)).IsRequired(true).HasColumnName<string>("COMISION_ORDEN").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrVendedor, Decimal>>)(e => e.ComisionServ)).HasColumnName<Decimal>("COMISION_SERV").HasColumnType<Decimal>("decimal(4, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrVendedor, Decimal>>)(e => e.ComisionStock)).HasColumnName<Decimal>("COMISION_STOCK").HasColumnType<Decimal>("decimal(4, 2)");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.CompanyBeeper)).HasColumnName<short>("COMPANY_BEEPER");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.Consecutivo)).HasColumnName<short>("CONSECUTIVO");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.MtrVendedor, int>>)(e => e.CotCorrelativo)).HasColumnName<int>("COT_CORRELATIVO");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.MtrVendedor, int>>)(e => e.IdUsuarioOdoo)).HasColumnName<int>("IdUsuarioOdoo");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.CotizadorPlus)).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.EMail)).IsRequired(true).HasColumnName<string>("E_MAIL").HasMaxLength(120).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.ExtTelefonica)).HasColumnName<short>("EXT_TELEFONICA");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrVendedor, DateTime?>>)(e => e.FechaIngreso)).HasColumnName<DateTime?>("FECHA_INGRESO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.MtrVendedor, DateTime?>>)(e => e.FechaRetiro)).HasColumnName<DateTime?>("FECHA_RETIRO").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.Ficha)).IsRequired(true).HasColumnName<string>("FICHA").HasMaxLength(6).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FlagAdmin)).HasColumnName<string>("FLAG_ADMIN").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("('X')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FlagCalculo)).HasColumnName<string>("FLAG_CALCULO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("('X')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FlagCambio)).IsRequired(true).HasColumnName<string>("FLAG_CAMBIO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FlagDeGerente)).IsRequired(true).HasColumnName<string>("FLAG_DE_GERENTE").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FlagForaneo)).HasColumnName<string>("FLAG_FORANEO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FlagGerenteOf)).IsRequired(true).HasColumnName<string>("FLAG_GERENTE_OF").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FlagIc)).HasColumnName<string>("FLAG_IC").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FlagReplicar)).IsRequired(true).HasColumnName<string>("FLAG_REPLICAR").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FlagRetirado)).IsRequired(true).HasColumnName<string>("FLAG_RETIRADO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FlagRevisar)).HasColumnName<string>("FLAG_REVISAR").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FlagSupervisor)).IsRequired(true).HasColumnName<string>("FLAG_SUPERVISOR").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.FreeLance)).IsRequired(true).HasColumnName<string>("FREE_LANCE").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.Garantia)).IsRequired(true).HasColumnName<string>("GARANTIA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.GerenteOficina)).IsRequired(true).HasColumnName<string>("GERENTE_OFICINA").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.GerenteRegion)).IsRequired(true).HasColumnName<string>("GERENTE_REGION").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.Grupo)).HasColumnName<short>("GRUPO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.GrupoVendedoresSap)).HasMaxLength(3).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.IdOficinaFisica)).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.IdOficinaMixProduct)).HasMaxLength(4).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.NombAbreviado)).IsRequired(true).HasColumnName<string>("NOMB_ABREVIADO").HasMaxLength(20).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.Nombre)).IsRequired(true).HasColumnName<string>("NOMBRE").HasMaxLength(30).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.NroDeClientes)).HasColumnName<short>("NRO_DE_CLIENTES");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.NroVendedor)).HasColumnName<short>("NRO_VENDEDOR");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.MtrVendedor, short?>>)(e => e.OfiRefer)).HasColumnName<short?>("OFI_REFER").HasDefaultValueSql<short?>("((0))");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.Oficina)).HasColumnName<short>("OFICINA");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.OrdenRep)).HasColumnName<short>("ORDEN_REP");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.Ordenado)).HasColumnName<short>("ORDENADO");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrVendedor, Decimal>>)(e => e.Override)).HasColumnName<Decimal>("OVERRIDE").HasColumnType<Decimal>("decimal(6, 2)");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.Pais)).HasColumnName<short>("PAIS");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.Password)).IsRequired(true).HasColumnName<string>("@PASSWORD").HasMaxLength(9).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.MtrVendedor, long>>)(e => e.Pedido)).HasColumnName<long>("PEDIDO");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.Posicion)).HasColumnName<short>("POSICION");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.ProduccionInterna)).HasMaxLength(1).HasDefaultValueSql<string>("('')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.MtrVendedor, short>>)(e => e.PuntosDelClub)).HasColumnName<short>("PUNTOS_DEL_CLUB");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.MtrVendedor, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.Supervisor)).IsRequired(true).HasColumnName<string>("SUPERVISOR").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.TlfCelular)).IsRequired(true).HasColumnName<string>("TLF_CELULAR").HasMaxLength(30).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.TlfCelularold)).HasColumnName<string>("TLF_CELULAROld").HasMaxLength(30).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.UnidadBeeper)).IsRequired(true).HasColumnName<string>("UNIDAD_BEEPER").HasMaxLength(8).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.MtrVendedor, string>>)(e => e.Usuario)).IsRequired(true).HasColumnName<string>("USUARIO").HasMaxLength(50).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.HasOne<AppService.Core.Entities.MtrOficina>((Expression<Func<AppService.Core.Entities.MtrVendedor, AppService.Core.Entities.MtrOficina>>)(d => d.OficinaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrOficina, IEnumerable<AppService.Core.Entities.MtrVendedor>>>)(p => p.MtrVendedor)).HasForeignKey((Expression<Func<AppService.Core.Entities.MtrVendedor, object>>)(d => (object)d.Oficina)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrOficina, AppService.Core.Entities.MtrVendedor>("FK_MtrVendedor_MtrOficina");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdAdjunto>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdAdjunto>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdAdjunto, object>>)(e => (object)e.IdAdjunto)).HasName("PK_MtrAdjunto");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdAdjunto, object>>)(e => (object)e.IdAdjuntoCotizadorPluss)).HasName<AppService.Core.Entities.OfdAdjunto>("IX_OfdAdjunto");
                entity.Property<byte[]>((Expression<Func<AppService.Core.Entities.OfdAdjunto, byte[]>>)(e => e.Archivo)).IsRequired(true);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdAdjunto, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.OfdAdjunto, long?>>)(e => e.IdAdjuntoCotizadorPluss)).HasDefaultValueSql<long?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdAdjunto, string>>)(e => e.IdUsuarioCreacion)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdAdjunto, string>>)(e => e.NombreArchivo)).IsRequired(true).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdAdjuntoCriterio>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdAdjuntoCriterio>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdAdjuntoCriterio, object>>)(e => (object)e.IdAdjuntoCriterio));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdAdjuntoCriterio, object>>)(e => (object)e.IdAdjunto)).HasName<AppService.Core.Entities.OfdAdjuntoCriterio>("IX_OfdAdjuntoCriterio");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdAdjuntoCriterio, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdAdjuntoCriterio, string>>)(e => e.IdUsuarioCreacion)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdAdjuntoCriterio, string>>)(e => e.Valor)).IsRequired(true).HasMaxLength(100);
                entity.HasOne<AppService.Core.Entities.OfdAdjunto>((Expression<Func<AppService.Core.Entities.OfdAdjuntoCriterio, AppService.Core.Entities.OfdAdjunto>>)(d => d.IdAdjuntoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdAdjunto, IEnumerable<AppService.Core.Entities.OfdAdjuntoCriterio>>>)(p => p.OfdAdjuntoCriterio)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdAdjuntoCriterio, object>>)(d => (object)d.IdAdjunto)).HasConstraintName<AppService.Core.Entities.OfdAdjunto, AppService.Core.Entities.OfdAdjuntoCriterio>("FK_OfdAdjuntoCriterio_OfdAdjunto");
                entity.HasOne<AppService.Core.Entities.OfdCriterioBusqueda>((Expression<Func<AppService.Core.Entities.OfdAdjuntoCriterio, AppService.Core.Entities.OfdCriterioBusqueda>>)(d => d.IdCriterioBusquedaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdCriterioBusqueda, IEnumerable<AppService.Core.Entities.OfdAdjuntoCriterio>>>)(p => p.OfdAdjuntoCriterio)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdAdjuntoCriterio, object>>)(d => (object)d.IdCriterioBusqueda)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdCriterioBusqueda, AppService.Core.Entities.OfdAdjuntoCriterio>("FK_OfdAdjuntoCriterio_OfdCriterioBusqueda");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdAdjuntosDiseno>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdAdjuntosDiseno>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdAdjuntosDiseno, object>>)(e => (object)e.IdAdjunto));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdAdjuntosDiseno, object>>)(e => new
                {
                    IdAdjunto = e.IdAdjunto,
                    IdTipoDocumento = e.IdTipoDocumento
                })).HasName<AppService.Core.Entities.OfdAdjuntosDiseno>("IX_OfdAdjuntosDiseno");
                entity.Property<byte[]>((Expression<Func<AppService.Core.Entities.OfdAdjuntosDiseno, byte[]>>)(e => e.Archivo)).IsRequired(true);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdAdjuntosDiseno, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdAdjuntosDiseno, string>>)(e => e.IdUsuarioCreacion)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdAdjuntosDiseno, string>>)(e => e.NombreArchivo)).IsRequired(true).HasMaxLength(100);
                entity.HasOne<AppService.Core.Entities.OfdSolicitudDiseno>((Expression<Func<AppService.Core.Entities.OfdAdjuntosDiseno, AppService.Core.Entities.OfdSolicitudDiseno>>)(d => d.IdSolicitudNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, IEnumerable<AppService.Core.Entities.OfdAdjuntosDiseno>>>)(p => p.OfdAdjuntosDiseno)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdAdjuntosDiseno, object>>)(d => (object)d.IdSolicitud)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdSolicitudDiseno, AppService.Core.Entities.OfdAdjuntosDiseno>("FK_OfdAdjuntosDiseno_OfdSolicitudDiseno");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdAprobacionDiseno>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdAprobacionDiseno>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, object>>)(e => (object)e.IdSolicitud));
                entity.Property<long>((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, long>>)(e => e.IdSolicitud)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, string>>)(e => e.Cargo)).HasMaxLength(500).HasDefaultValueSql<string>("('')");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, long?>>)(e => e.Cedula)).HasDefaultValueSql<long?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, string>>)(e => e.EmailCliente)).HasMaxLength(500);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, DateTime>>)(e => e.FechaAgrega)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, Decimal>>)(e => e.IdTicket)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, string>>)(e => e.ObsCliente)).HasMaxLength(500).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, string>>)(e => e.ObsConsultor)).HasMaxLength(500).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, string>>)(e => e.UsuarioAgrega)).IsRequired(true).HasMaxLength(40);
                entity.HasOne<AppService.Core.Entities.OfdSolicitudDiseno>((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, AppService.Core.Entities.OfdSolicitudDiseno>>)(d => d.IdSolicitudNavigation)).WithOne((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, AppService.Core.Entities.OfdAprobacionDiseno>>)(p => p.OfdAprobacionDiseno)).HasForeignKey<AppService.Core.Entities.OfdAprobacionDiseno>((Expression<Func<AppService.Core.Entities.OfdAprobacionDiseno, object>>)(d => (object)d.IdSolicitud)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdAprobacionDiseno, AppService.Core.Entities.OfdSolicitudDiseno>("FK_OfdAprobacionDiseno_OfdSolicitudDiseno");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdCambioDiseno>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdCambioDiseno>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdCambioDiseno, object>>)(e => (object)e.IdCambio));
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdCambioDiseno, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCambioDiseno, string>>)(e => e.IdTipoCambio)).IsRequired(true).HasMaxLength(4);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCambioDiseno, string>>)(e => e.NombreCambio)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCambioDiseno, string>>)(e => e.UsuarioRegistro)).IsRequired(true).HasMaxLength(40);
                entity.HasOne<AppService.Core.Entities.OfdTipoCambioDiseno>((Expression<Func<AppService.Core.Entities.OfdCambioDiseno, AppService.Core.Entities.OfdTipoCambioDiseno>>)(d => d.IdTipoCambioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdTipoCambioDiseno, IEnumerable<AppService.Core.Entities.OfdCambioDiseno>>>)(p => p.OfdCambioDiseno)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdCambioDiseno, object>>)(d => d.IdTipoCambio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdTipoCambioDiseno, AppService.Core.Entities.OfdCambioDiseno>("FK_OfdCambioDiseno_OfdTipoCambioDiseno");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdConstruccionCotizacion>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdConstruccionCotizacion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdConstruccionCotizacion, object>>)(e => new
                {
                    Cotizacion = e.Cotizacion,
                    Renglon = e.Renglon,
                    Propuesta = e.Propuesta,
                    IdVariable = e.IdVariable,
                    IdParte = e.IdParte,
                    Valor = e.Valor
                })).HasName("PK_WPRY251");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdConstruccionCotizacion, string>>)(e => e.Cotizacion)).HasMaxLength(13);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdConstruccionCotizacion, string>>)(e => e.IdVariable)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdConstruccionCotizacion, string>>)(e => e.Valor)).HasMaxLength(100).HasDefaultValueSql<string>("('')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdConstruccionCotizacion, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdConstruccionCotizacion, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdCotizacion>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdCotizacion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdCotizacion, object>>)(e => (object)e.IdCotizacion)).HasName("PK_OfdCotizacion_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdCotizacion, object>>)(e => e.Cotizacion)).HasName<AppService.Core.Entities.OfdCotizacion>("IX_OfdCotizacion").IsUnique(true);
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdCotizacion, object>>)(e => new
                {
                    IdVendedor = e.IdVendedor,
                    IdCliente = e.IdCliente,
                    IdCotizacion = e.IdCotizacion
                })).HasName<AppService.Core.Entities.OfdCotizacion>("IX_OfdCotizacionVendedorClienteCotizacion");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCotizacion, string>>)(e => e.Cotizacion)).IsRequired(true).HasMaxLength(13);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdCotizacion, DateTime>>)(e => e.Fecha)).HasColumnType<DateTime>("smalldatetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdCotizacion, DateTime>>)(e => e.FechaActualiza)).HasColumnType<DateTime>("smalldatetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.OfdCotizacion, DateTime?>>)(e => e.FechaCaducidad)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.OfdCotizacion, DateTime?>>)(e => e.FechaPostergada)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCotizacion, string>>)(e => e.IdCliente)).IsRequired(true).HasMaxLength(10).HasDefaultValueSql<string>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdCotizacion, Decimal>>)(e => e.IdDireccionEntregar)).HasColumnType<Decimal>("decimal(18, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdCotizacion, Decimal>>)(e => e.IdDireccionFacturar)).HasColumnType<Decimal>("decimal(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCotizacion, string>>)(e => e.IdProspecto)).IsRequired(true).HasMaxLength(10).HasDefaultValueSql<string>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCotizacion, string>>)(e => e.IdVendedor)).IsRequired(true).HasMaxLength(4);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCotizacion, string>>)(e => e.ObservacionPostergar)).IsRequired(true).HasMaxLength(500).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCotizacion, string>>)(e => e.ObsvCotizacion)).IsRequired(true).HasMaxLength(250).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCotizacion, string>>)(e => e.OrdenCompra)).IsRequired(true).HasMaxLength(16).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCotizacion, string>>)(e => e.UsuarioActualiza)).IsRequired(true).HasMaxLength(50);
                entity.HasOne<AppService.Core.Entities.MtrContactos>((Expression<Func<AppService.Core.Entities.OfdCotizacion, AppService.Core.Entities.MtrContactos>>)(d => d.IdContactoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrContactos, IEnumerable<AppService.Core.Entities.OfdCotizacion>>>)(p => p.OfdCotizacion)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdCotizacion, object>>)(d => (object)d.IdContacto)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrContactos, AppService.Core.Entities.OfdCotizacion>("FK_OfdCotizacion_MtrContactos");
                entity.HasOne<AppService.Core.Entities.MtrVendedor>((Expression<Func<AppService.Core.Entities.OfdCotizacion, AppService.Core.Entities.MtrVendedor>>)(d => d.IdVendedorNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrVendedor, IEnumerable<AppService.Core.Entities.OfdCotizacion>>>)(p => p.OfdCotizacion)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdCotizacion, object>>)(d => d.IdVendedor)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrVendedor, AppService.Core.Entities.OfdCotizacion>("FK_OfdCotizacion_MtrVendedor");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdCriterioBusqueda>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdCriterioBusqueda>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdCriterioBusqueda, object>>)(e => (object)e.IdCriterioBusqueda));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCriterioBusqueda, string>>)(e => e.CampoBusqueda)).IsRequired(true).HasMaxLength(50).IsUnicode(false);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdCriterioBusqueda, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdCriterioBusqueda, string>>)(e => e.IdUsuarioCreacion)).IsRequired(true).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdDetalleSolicitudDiseno>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdDetalleSolicitudDiseno>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdDetalleSolicitudDiseno, object>>)(e => (object)e.IdDetalleSolicitud));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdDetalleSolicitudDiseno, object>>)(e => (object)e.IdSolicitud)).HasName<AppService.Core.Entities.OfdDetalleSolicitudDiseno>("IX_OfdDetalleSolicitudDiseno");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdDetalleSolicitudDiseno, object>>)(e => new
                {
                    IdSolicitud = e.IdSolicitud,
                    NumeroAnotacion = e.NumeroAnotacion
                })).HasName<AppService.Core.Entities.OfdDetalleSolicitudDiseno>("IX_OfdDetalleSolicitudDiseno_2").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdDetalleSolicitudDiseno, string>>)(e => e.Anotacion)).IsRequired(true).HasMaxLength(1000);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdDetalleSolicitudDiseno, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdDetalleSolicitudDiseno, string>>)(e => e.IdUsuario)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdDetalleSolicitudDiseno, string>>)(e => e.NombreImagen)).HasMaxLength(500);
                entity.HasOne<AppService.Core.Entities.OfdSolicitudDiseno>((Expression<Func<AppService.Core.Entities.OfdDetalleSolicitudDiseno, AppService.Core.Entities.OfdSolicitudDiseno>>)(d => d.IdSolicitudNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, IEnumerable<AppService.Core.Entities.OfdDetalleSolicitudDiseno>>>)(p => p.OfdDetalleSolicitudDiseno)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdDetalleSolicitudDiseno, object>>)(d => (object)d.IdSolicitud)).HasConstraintName<AppService.Core.Entities.OfdSolicitudDiseno, AppService.Core.Entities.OfdDetalleSolicitudDiseno>("FK_OfdDetalleSolicitudDiseno_OfdSolicitudDiseno");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdEspecificacionCotizacion>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdEspecificacionCotizacion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, object>>)(e => (object)e.IdSolicitud)).HasName("PK_WPRY229");
                entity.HasComment<AppService.Core.Entities.OfdEspecificacionCotizacion>("Datos generales de las solicitudes");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, object>>)(e => (object)e.Orden)).HasName<AppService.Core.Entities.OfdEspecificacionCotizacion>("IX_WPRY229_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, object>>)(e => new
                {
                    Cotizacion = e.Cotizacion,
                    Renglon = e.Renglon,
                    Propuesta = e.Propuesta
                })).HasName<AppService.Core.Entities.OfdEspecificacionCotizacion>("IX_WPRY229").IsUnique(true);
                entity.Property<int>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, int>>)(e => e.IdSolicitud)).ValueGeneratedNever();
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, Decimal>>)(e => e.CantidadProducto)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.Cotizacion)).IsRequired(true).HasMaxLength(13);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.DescripcionSolicitud)).IsRequired(true).HasMaxLength(200);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, DateTime?>>)(e => e.FechaEntrega)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, DateTime>>)(e => e.FechaSolicitud)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.FlagFiscal)).HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.Instrucciones)).HasMaxLength(1000).HasDefaultValueSql<string>("('')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, Decimal?>>)(e => e.LongitudMascara)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.NumDesde)).HasMaxLength(8).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.NumHasta)).HasMaxLength(8).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.NumeroControlDesde)).HasMaxLength(8);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.NumeroControlHasta)).HasMaxLength(8);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.NumeroFormatoDesde)).HasMaxLength(8);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.NumeroFormatoHasta)).HasMaxLength(8);
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, long?>>)(e => e.NumeroSdf)).HasColumnName<long?>("NumeroSDF").HasDefaultValueSql<long?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.NumeroSerieControlDesde)).HasMaxLength(2).HasDefaultValueSql<string>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.NumeroSerieControlHasta)).HasMaxLength(2).HasDefaultValueSql<string>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.NumeroSerieFormatoDesde)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.NumeroSerieFormatoHasta)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.Observaciones)).IsRequired(true).HasMaxLength(1000);
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, long?>>)(e => e.OrdenAnterior)).HasDefaultValueSql<long?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, Decimal?>>)(e => e.RvalorLista)).HasColumnName<Decimal?>("RValorLista").HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, Decimal?>>)(e => e.RvalorVenta)).HasColumnName<Decimal?>("RValorVenta").HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, string>>)(e => e.TipoDocumento)).HasMaxLength(2);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, Decimal>>)(e => e.ValorLista)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdEspecificacionCotizacion, Decimal>>)(e => e.ValorVenta)).HasColumnType<Decimal>("numeric(18, 4)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdEstatusFlujo>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdEstatusFlujo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdEstatusFlujo, object>>)(e => e.IdEstatus));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEstatusFlujo, string>>)(e => e.IdEstatus)).HasMaxLength(10);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdEstatusFlujo, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEstatusFlujo, string>>)(e => e.FlagAprobado)).IsRequired(true).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEstatusFlujo, string>>)(e => e.FlagEnviado)).IsRequired(true).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEstatusFlujo, string>>)(e => e.FlagPendiente)).IsRequired(true).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEstatusFlujo, string>>)(e => e.FlagRechazado)).IsRequired(true).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEstatusFlujo, string>>)(e => e.NombreEstatus)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdEstatusFlujo, string>>)(e => e.UsuarioRegistro)).IsRequired(true).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdExcepcionFlujoProducto>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdExcepcionFlujoProducto>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdExcepcionFlujoProducto, object>>)(e => e.Producto)).HasName<AppService.Core.Entities.OfdExcepcionFlujoProducto>("IX_OfdExcepcionFlujoProducto").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdExcepcionFlujoProducto, string>>)(e => e.Producto)).HasMaxLength(12);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdFlujoEstacion>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdFlujoEstacion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdFlujoEstacion, object>>)(e => (object)e.IdFlujoEstacion));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdFlujoEstacion, object>>)(e => (object)e.IdEstacionActual)).HasName<AppService.Core.Entities.OfdFlujoEstacion>("IX_OfdFlujoEstacion").IsUnique(true);
                entity.Property<short>((Expression<Func<AppService.Core.Entities.OfdFlujoEstacion, short>>)(e => e.IdFlujoEstacion)).ValueGeneratedNever();
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdFlujoEstacion, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.HasOne<AppService.Core.Entities.OfdMaestroEstacion>((Expression<Func<AppService.Core.Entities.OfdFlujoEstacion, AppService.Core.Entities.OfdMaestroEstacion>>)(d => d.IdEstacionActualNavigation)).WithOne((Expression<Func<AppService.Core.Entities.OfdMaestroEstacion, AppService.Core.Entities.OfdFlujoEstacion>>)(p => p.OfdFlujoEstacion)).HasForeignKey<AppService.Core.Entities.OfdFlujoEstacion>((Expression<Func<AppService.Core.Entities.OfdFlujoEstacion, object>>)(d => (object)d.IdEstacionActual)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdFlujoEstacion, AppService.Core.Entities.OfdMaestroEstacion>("FK_OfdFlujoEstacion_OfdMaestroEstacion");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdGrupoCriterio>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdGrupoCriterio>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdGrupoCriterio, object>>)(e => (object)e.IdGrupoCriterio));
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdGrupoCriterio, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdGrupoCriterio, DateTime>>)(e => e.FechaModificacion)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdGrupoCriterio, string>>)(e => e.IdUsuarioCreacion)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdGrupoCriterio, string>>)(e => e.IdUsuarioModificacion)).IsRequired(true).HasMaxLength(40);
                entity.HasOne<AppService.Core.Entities.OfdCriterioBusqueda>((Expression<Func<AppService.Core.Entities.OfdGrupoCriterio, AppService.Core.Entities.OfdCriterioBusqueda>>)(d => d.IdCriterioBusquedaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdCriterioBusqueda, IEnumerable<AppService.Core.Entities.OfdGrupoCriterio>>>)(p => p.OfdGrupoCriterio)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdGrupoCriterio, object>>)(d => (object)d.IdCriterioBusqueda)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdCriterioBusqueda, AppService.Core.Entities.OfdGrupoCriterio>("FK_OfdGrupoCriterio_OfdCriterioBusqueda");
                entity.HasOne<AppService.Core.Entities.OfdGrupoTipoDocumento>((Expression<Func<AppService.Core.Entities.OfdGrupoCriterio, AppService.Core.Entities.OfdGrupoTipoDocumento>>)(d => d.IdGrupoTipoDocumentoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdGrupoTipoDocumento, IEnumerable<AppService.Core.Entities.OfdGrupoCriterio>>>)(p => p.OfdGrupoCriterio)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdGrupoCriterio, object>>)(d => (object)d.IdGrupoTipoDocumento)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdGrupoTipoDocumento, AppService.Core.Entities.OfdGrupoCriterio>("FK_OfdGrupoCriterio_OdfGrupoTipoDocumento");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdGrupoTipoDocumento>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdGrupoTipoDocumento>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdGrupoTipoDocumento, object>>)(e => (object)e.IdGrupoTipoDocumento)).HasName("PK_OdfGrupoTipoDocumento");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdGrupoTipoDocumento, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdGrupoTipoDocumento, DateTime>>)(e => e.FechaModificacion)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdGrupoTipoDocumento, string>>)(e => e.IdUsuarioCreacion)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdGrupoTipoDocumento, string>>)(e => e.IdUsuarioModificacion)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdGrupoTipoDocumento, string>>)(e => e.NombreGrupo)).IsRequired(true).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdMaestroEstacion>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdMaestroEstacion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdMaestroEstacion, object>>)(e => (object)e.IdEstacion)).HasName("PK_OfdEstacionesSED");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdMaestroEstacion, object>>)(e => e.AbreviadoEstacion)).HasName<AppService.Core.Entities.OfdMaestroEstacion>("IX_OfdEstacionesDiseno").IsUnique(true);
                entity.Property<short>((Expression<Func<AppService.Core.Entities.OfdMaestroEstacion, short>>)(e => e.IdEstacion)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdMaestroEstacion, string>>)(e => e.AbreviadoEstacion)).IsRequired(true).HasMaxLength(10);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdMaestroEstacion, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdMaestroEstacion, string>>)(e => e.NombreEstacion)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdMaestroEstacion, string>>)(e => e.UsuarioRegistro)).IsRequired(true).HasMaxLength(40);
                entity.HasOne<AppService.Core.Entities.OfdMaestroFlujo>((Expression<Func<AppService.Core.Entities.OfdMaestroEstacion, AppService.Core.Entities.OfdMaestroFlujo>>)(d => d.IdFlujoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdMaestroFlujo, IEnumerable<AppService.Core.Entities.OfdMaestroEstacion>>>)(p => p.OfdMaestroEstacion)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdMaestroEstacion, object>>)(d => (object)d.IdFlujo)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdMaestroFlujo, AppService.Core.Entities.OfdMaestroEstacion>("FK_OfdMaestroEstacion_OfdMaestroFlujo");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdMaestroFlujo>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdMaestroFlujo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdMaestroFlujo, object>>)(e => (object)e.IdFlujo)).HasName("PK_OfdMaestroFlujos");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.OfdMaestroFlujo, short>>)(e => e.IdFlujo)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdMaestroFlujo, string>>)(e => e.NombreFlujo)).IsRequired(true).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdMaestroPieImprenta>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdMaestroPieImprenta>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdMaestroPieImprenta, object>>)(e => e.IdPieImprenta));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdMaestroPieImprenta, string>>)(e => e.IdPieImprenta)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdMaestroPieImprenta, string>>)(e => e.DescripcionPie)).IsRequired(true).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdMaestroTipoRespaldo>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdMaestroTipoRespaldo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdMaestroTipoRespaldo, object>>)(e => (object)e.IdTipoRespaldo)).HasName("PK_OfdMaestroTipoMarginal");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.OfdMaestroTipoRespaldo, short>>)(e => e.IdTipoRespaldo)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdMaestroTipoRespaldo, string>>)(e => e.TipoRespaldo)).IsRequired(true).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdMaestroUbicacionMarginal>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdMaestroUbicacionMarginal>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdMaestroUbicacionMarginal, object>>)(e => (object)e.IdUbicacionMarginal));
                entity.Property<short>((Expression<Func<AppService.Core.Entities.OfdMaestroUbicacionMarginal, short>>)(e => e.IdUbicacionMarginal)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdMaestroUbicacionMarginal, string>>)(e => e.UbicacionMarginal)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdMaestroVoBo>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdMaestroVoBo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdMaestroVoBo, object>>)(e => (object)e.IdVoBo));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdMaestroVoBo, object>>)(e => (object)e.IdEstacion)).HasName<AppService.Core.Entities.OfdMaestroVoBo>("IX_OfdMaestroVoBo_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdMaestroVoBo, object>>)(e => new
                {
                    IdEstacion = e.IdEstacion,
                    Orden = e.Orden
                })).HasName<AppService.Core.Entities.OfdMaestroVoBo>("IX_OfdMaestroVoBo").IsUnique(true);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdMaestroVoBo, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdMaestroVoBo, string>>)(e => e.IdUsuario)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdMaestroVoBo, string>>)(e => e.Instruccion)).IsRequired(true).HasMaxLength(500);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdObservacionAdjunto>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdObservacionAdjunto>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdObservacionAdjunto, object>>)(e => (object)e.IdObservacionAdjunto)).HasName("PK_PrcObservacionAdjunto");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdObservacionAdjunto, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdObservacionAdjunto, string>>)(e => e.IdUsuarioCreacion)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdObservacionAdjunto, string>>)(e => e.Observaciones)).IsRequired(true);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdPartesCotizacion>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdPartesCotizacion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdPartesCotizacion, object>>)(e => new
                {
                    Cotizacion = e.Cotizacion,
                    Renglon = e.Renglon,
                    Propuesta = e.Propuesta,
                    IdParte = e.IdParte
                })).HasName("PK_OfdPartesCotizacion_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdPartesCotizacion, object>>)(e => (object)e.Recnum)).HasName<AppService.Core.Entities.OfdPartesCotizacion>("IX_OfdPartesCotizacion");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPartesCotizacion, string>>)(e => e.Cotizacion)).HasMaxLength(13);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPartesCotizacion, Decimal>>)(e => e.AnchoCm)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPartesCotizacion, Decimal>>)(e => e.Cantidad)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdPartesCotizacion, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPartesCotizacion, string>>)(e => e.FrasesMarginales)).HasMaxLength(200).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPartesCotizacion, string>>)(e => e.IdPapel)).IsRequired(true).HasMaxLength(8).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPartesCotizacion, Decimal>>)(e => e.LargoCm)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.OfdPartesCotizacion, int?>>)(e => e.MedidaBase)).HasColumnName<int?>("Medida_Base").HasDefaultValueSql<int?>("('')");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.OfdPartesCotizacion, int?>>)(e => e.MedidaOpuesta)).HasColumnName<int?>("Medida_Opuesta").HasDefaultValueSql<int?>("('')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdPlantillaPreset>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdPlantillaPreset>>)(entity =>
            {
                entity.HasNoKey();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.Basica)).HasColumnName<string>("BASICA").HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, Decimal?>>)(e => e.Cambioscomposicion)).HasColumnName<Decimal?>("CAMBIOSCOMPOSICION").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, Decimal?>>)(e => e.Cantfranjastransfertape)).HasColumnName<Decimal?>("CANTFRANJASTRANSFERTAPE").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, Decimal?>>)(e => e.Cantitintas)).HasColumnName<Decimal?>("CANTITINTAS").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.Carbon)).HasColumnName<string>("CARBON").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.CodProducto)).HasColumnName<string>("COD_PRODUCTO").HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.Grupopapel)).HasColumnName<string>("GRUPOPAPEL").HasMaxLength(100);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, Decimal?>>)(e => e.IdSolicitud)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.Medidaopuestacarbon)).HasColumnName<string>("MEDIDAOPUESTACARBON").HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, Decimal?>>)(e => e.Millares)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.Nombreproducto)).HasColumnName<string>("NOMBREPRODUCTO").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.Opuesta)).HasColumnName<string>("OPUESTA").HasMaxLength(50).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.Orden)).HasColumnName<string>("ORDEN").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.Ordenreferencia)).HasColumnName<string>("ORDENReferencia").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.Papel)).HasColumnName<string>("PAPEL").HasMaxLength(100);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, Decimal?>>)(e => e.Partes)).HasColumnName<Decimal?>("PARTES").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, Decimal?>>)(e => e.PrecioMaximoMillar)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.Talonextra)).HasColumnName<string>("TALONEXTRA").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPlantillaPreset, string>>)(e => e.Tienecarbonspot)).HasColumnName<string>("TIENECARBONSPOT").HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdPropuesta>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdPropuesta>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdPropuesta, object>>)(e => (object)e.IdPropuesta));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdPropuesta, object>>)(e => new
                {
                    Cotizacion = e.Cotizacion,
                    Renglon = e.Renglon,
                    Propuesta = e.Propuesta
                })).HasName<AppService.Core.Entities.OfdPropuesta>("IX_OfdPropuesta").IsUnique(true);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.Cajas)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.CantFormas)).HasColumnName<Decimal>("Cant_Formas").HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<float>((Expression<Func<AppService.Core.Entities.OfdPropuesta, float>>)(e => e.CantMill)).HasColumnName<float>("Cant_Mill");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.CantXCaja)).HasColumnName<Decimal>("Cant_x_Caja").HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.Cantidad)).HasColumnType<Decimal>("decimal(16, 3)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuesta, string>>)(e => e.Cotizacion)).IsRequired(true).HasMaxLength(13);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuesta, string>>)(e => e.CotizacionRenglonPropuesta)).IsRequired(true).HasMaxLength(20).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuesta, string>>)(e => e.EstatusPlanta)).IsRequired(true).HasMaxLength(4);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.FactorSdf)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdPropuesta, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuesta, string>>)(e => e.IdPresentacion)).IsRequired(true).HasMaxLength(5);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuesta, string>>)(e => e.IdSolicitud)).IsRequired(true).HasMaxLength(9).HasDefaultValueSql<string>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuesta, string>>)(e => e.ObsrPropuesta)).IsRequired(true).HasMaxLength(200).HasDefaultValueSql<string>("('')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.PorMcBruto)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.PorMcFinan)).HasColumnType<Decimal>("decimal(10, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.PorcComRegulada)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.PorcComision)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal?>>)(e => e.PorcIva)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.PorcMcMinimo)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.PorcRespSocial)).HasColumnType<Decimal>("numeric(5, 3)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.PorcTolerancia)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.Precio)).HasColumnType<Decimal>("decimal(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuesta, string>>)(e => e.RecalcularMargen)).IsRequired(true).HasMaxLength(1).HasDefaultValueSql<string>("('')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal?>>)(e => e.Rprecio)).HasColumnName<Decimal?>("RPrecio").HasColumnType<Decimal?>("decimal(18, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal?>>)(e => e.Rtotal)).HasColumnName<Decimal?>("RTotal").HasColumnType<Decimal?>("decimal(18, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuesta, Decimal>>)(e => e.Total)).HasColumnType<Decimal>("decimal(18, 4)");
                entity.HasOne<AppService.Core.Entities.OfdRenglon>((Expression<Func<AppService.Core.Entities.OfdPropuesta, AppService.Core.Entities.OfdRenglon>>)(d => d.IdRenglonNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdRenglon, IEnumerable<AppService.Core.Entities.OfdPropuesta>>>)(p => p.OfdPropuesta)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdPropuesta, object>>)(d => (object)d.IdRenglon)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdRenglon, AppService.Core.Entities.OfdPropuesta>("FK_OfdPropuesta_OfdRenglon");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdPropuestaResp>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdPropuestaResp>>)(entity =>
            {
                entity.HasNoKey();
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.Cajas)).HasColumnType<Decimal>("numeric(18, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.CantFormas)).HasColumnName<Decimal>("Cant_Formas").HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<float>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, float>>)(e => e.CantMill)).HasColumnName<float>("Cant_Mill");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.CantXCaja)).HasColumnName<Decimal>("Cant_x_Caja").HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.Cantidad)).HasColumnType<Decimal>("decimal(16, 3)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, string>>)(e => e.Cotizacion)).IsRequired(true).HasMaxLength(13);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, string>>)(e => e.CotizacionRenglonPropuesta)).IsRequired(true).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, string>>)(e => e.EstatusPlanta)).IsRequired(true).HasMaxLength(4);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.FactorSdf)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, string>>)(e => e.IdPresentacion)).IsRequired(true).HasMaxLength(5);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, string>>)(e => e.IdSolicitud)).IsRequired(true).HasMaxLength(9);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, string>>)(e => e.ObsrPropuesta)).IsRequired(true).HasMaxLength(200);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.PorMcBruto)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.PorMcFinan)).HasColumnType<Decimal>("decimal(10, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.PorcComRegulada)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.PorcComision)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal?>>)(e => e.PorcIva)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.PorcMcMinimo)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.PorcRespSocial)).HasColumnType<Decimal>("numeric(5, 3)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.PorcTolerancia)).HasColumnType<Decimal>("numeric(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.Precio)).HasColumnType<Decimal>("decimal(16, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, string>>)(e => e.RecalcularMargen)).IsRequired(true).HasMaxLength(1);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdPropuestaResp, Decimal>>)(e => e.Total)).HasColumnType<Decimal>("decimal(16, 4)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdRenglon>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdRenglon>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdRenglon, object>>)(e => (object)e.IdRenglon));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdRenglon, object>>)(e => (object)e.IdCotizacion)).HasName<AppService.Core.Entities.OfdRenglon>("IX_OfdRenglon_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdRenglon, object>>)(e => new
                {
                    Cotizacion = e.Cotizacion,
                    Renglon = e.Renglon
                })).HasName<AppService.Core.Entities.OfdRenglon>("IX_OfdRenglon").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdRenglon, string>>)(e => e.Cotizacion)).IsRequired(true).HasMaxLength(13);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdRenglon, string>>)(e => e.EstatusPlanta)).IsRequired(true).HasMaxLength(4).HasDefaultValueSql<string>("('')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdRenglon, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.OfdRenglon, DateTime?>>)(e => e.FechaReorden)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdRenglon, string>>)(e => e.IdProducto)).IsRequired(true).HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdRenglon, string>>)(e => e.NombreComercialProducto)).IsRequired(true).HasMaxLength(200).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdRenglon, string>>)(e => e.ObsrGanarPerder)).IsRequired(true).HasMaxLength(300).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdRenglon, string>>)(e => e.ObsvRenglon)).IsRequired(true).HasMaxLength(300).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.OfdRenglon, int>>)(e => e.RazonGanadaPerdida)).HasDefaultValueSql<int>("('')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdRenglon, Decimal?>>)(e => e.RtotalGanado)).HasColumnName<Decimal?>("RTotalGanado").HasColumnType<Decimal?>("numeric(20, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdRenglon, Decimal?>>)(e => e.RtotalRenglon)).HasColumnName<Decimal?>("RTotalRenglon").HasColumnType<Decimal?>("numeric(20, 4)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdRenglon, Decimal>>)(e => e.TotalGanado)).HasColumnType<Decimal>("numeric(20, 4)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.OfdRenglon, Decimal>>)(e => e.TotalRenglon)).HasColumnType<Decimal>("numeric(20, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdRenglon, string>>)(e => e.Unidad)).IsRequired(true).HasMaxLength(5).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.HasOne<AppService.Core.Entities.OfdCotizacion>((Expression<Func<AppService.Core.Entities.OfdRenglon, AppService.Core.Entities.OfdCotizacion>>)(d => d.IdCotizacionNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdCotizacion, IEnumerable<AppService.Core.Entities.OfdRenglon>>>)(p => p.OfdRenglon)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdRenglon, object>>)(d => (object)d.IdCotizacion)).HasConstraintName<AppService.Core.Entities.OfdCotizacion, AppService.Core.Entities.OfdRenglon>("FK_OfdRenglon_OfdCotizacion");
                entity.HasOne<AppService.Core.Entities.MtrProducto>((Expression<Func<AppService.Core.Entities.OfdRenglon, AppService.Core.Entities.MtrProducto>>)(d => d.IdProductoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrProducto, IEnumerable<AppService.Core.Entities.OfdRenglon>>>)(p => p.OfdRenglon)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdRenglon, object>>)(d => d.IdProducto)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrProducto, AppService.Core.Entities.OfdRenglon>("FK_OfdRenglon_MtrProducto");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdRolTipoDocumento>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdRolTipoDocumento>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdRolTipoDocumento, object>>)(e => (object)e.IdRolTipoDocumento));
                entity.HasOne<AppService.Core.Entities.SegRol>((Expression<Func<AppService.Core.Entities.OfdRolTipoDocumento, AppService.Core.Entities.SegRol>>)(d => d.IdRolNavigation)).WithMany((Expression<Func<AppService.Core.Entities.SegRol, IEnumerable<AppService.Core.Entities.OfdRolTipoDocumento>>>)(p => p.OfdRolTipoDocumento)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdRolTipoDocumento, object>>)(d => (object)d.IdRol)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.SegRol, AppService.Core.Entities.OfdRolTipoDocumento>("FK_OfdRolTipoDocumento_SegRol");
                entity.HasOne<AppService.Core.Entities.OfdTipoDocumento>((Expression<Func<AppService.Core.Entities.OfdRolTipoDocumento, AppService.Core.Entities.OfdTipoDocumento>>)(d => d.IdTipoDocumentoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, IEnumerable<AppService.Core.Entities.OfdRolTipoDocumento>>>)(p => p.OfdRolTipoDocumento)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdRolTipoDocumento, object>>)(d => (object)d.IdTipoDocumento)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdTipoDocumento, AppService.Core.Entities.OfdRolTipoDocumento>("FK_OfdRolTipoDocumento_OfdTipoDocumento");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdSeguimiento>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdSeguimiento>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdSeguimiento, object>>)(e => (object)e.IdSeguimiento));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdSeguimiento, object>>)(e => (object)e.FechaEntrada)).HasName<AppService.Core.Entities.OfdSeguimiento>("IX_OfdSeguimiento_4");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdSeguimiento, object>>)(e => (object)e.FechaSalida)).HasName<AppService.Core.Entities.OfdSeguimiento>("IX_OfdSeguimiento_2");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdSeguimiento, object>>)(e => (object)e.IdSolicitud)).HasName<AppService.Core.Entities.OfdSeguimiento>("IX_OfdSeguimiento");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdSeguimiento, object>>)(e => new
                {
                    IdSolicitud = e.IdSolicitud,
                    IdEstacion = e.IdEstacion
                })).HasName<AppService.Core.Entities.OfdSeguimiento>("IX_OfdSeguimiento_5");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSeguimiento, string>>)(e => e.Comentarios)).IsRequired(true).HasMaxLength(500);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdSeguimiento, DateTime>>)(e => e.FechaEntrada)).HasColumnType<DateTime>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.OfdSeguimiento, DateTime?>>)(e => e.FechaSalida)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSeguimiento, string>>)(e => e.IdEstatus)).IsRequired(true).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSeguimiento, string>>)(e => e.Usuario)).IsRequired(true).HasMaxLength(40);
                entity.HasOne<AppService.Core.Entities.OfdMaestroEstacion>((Expression<Func<AppService.Core.Entities.OfdSeguimiento, AppService.Core.Entities.OfdMaestroEstacion>>)(d => d.IdEstacionNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdMaestroEstacion, IEnumerable<AppService.Core.Entities.OfdSeguimiento>>>)(p => p.OfdSeguimiento)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdSeguimiento, object>>)(d => (object)d.IdEstacion)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdMaestroEstacion, AppService.Core.Entities.OfdSeguimiento>("FK_OfdSeguimiento_OfdMaestroEstacion");
                entity.HasOne<AppService.Core.Entities.OfdSolicitudDiseno>((Expression<Func<AppService.Core.Entities.OfdSeguimiento, AppService.Core.Entities.OfdSolicitudDiseno>>)(d => d.IdSolicitudNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, IEnumerable<AppService.Core.Entities.OfdSeguimiento>>>)(p => p.OfdSeguimiento)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdSeguimiento, object>>)(d => (object)d.IdSolicitud)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdSolicitudDiseno, AppService.Core.Entities.OfdSeguimiento>("FK_OfdSeguimiento_OfdSolicitudDiseno");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdSolicitudDiseno>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdSolicitudDiseno>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, object>>)(e => (object)e.IdSolicitud));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, object>>)(e => (object)e.IdPropuesta)).HasName<AppService.Core.Entities.OfdSolicitudDiseno>("IX_OfdSolicitudDiseno");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, string>>)(e => e.IdPieImprenta)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, string>>)(e => e.IdTipoCambio)).HasMaxLength(4).HasDefaultValueSql<string>("('ND')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, string>>)(e => e.IdUsuario)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, string>>)(e => e.ObsvSolicitud)).IsRequired(true).HasMaxLength(1000);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, string>>)(e => e.UsuarioActivo)).HasMaxLength(40).HasDefaultValueSql<string>("('')");
                entity.HasOne<AppService.Core.Entities.OfdMaestroPieImprenta>((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, AppService.Core.Entities.OfdMaestroPieImprenta>>)(d => d.IdPieImprentaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdMaestroPieImprenta, IEnumerable<AppService.Core.Entities.OfdSolicitudDiseno>>>)(p => p.OfdSolicitudDiseno)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, object>>)(d => d.IdPieImprenta)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdMaestroPieImprenta, AppService.Core.Entities.OfdSolicitudDiseno>("FK_OfdSolicitudDiseno_OfdMaestroPieImprenta");
                entity.HasOne<AppService.Core.Entities.OfdPropuesta>((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, AppService.Core.Entities.OfdPropuesta>>)(d => d.IdPropuestaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdPropuesta, IEnumerable<AppService.Core.Entities.OfdSolicitudDiseno>>>)(p => p.OfdSolicitudDiseno)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, object>>)(d => (object)d.IdPropuesta)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdPropuesta, AppService.Core.Entities.OfdSolicitudDiseno>("FK_OfdSolicitudDiseno_OfdPropuesta");
                entity.HasOne<AppService.Core.Entities.OfdTipoCambioDiseno>((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, AppService.Core.Entities.OfdTipoCambioDiseno>>)(d => d.IdTipoCambioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdTipoCambioDiseno, IEnumerable<AppService.Core.Entities.OfdSolicitudDiseno>>>)(p => p.OfdSolicitudDiseno)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, object>>)(d => d.IdTipoCambio)).HasConstraintName<AppService.Core.Entities.OfdTipoCambioDiseno, AppService.Core.Entities.OfdSolicitudDiseno>("FK_OfdSolicitudDiseno_OfdTipoCambioDiseno");
                entity.HasOne<AppService.Core.Entities.OfdMaestroTipoRespaldo>((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, AppService.Core.Entities.OfdMaestroTipoRespaldo>>)(d => d.IdTipoRespaldoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdMaestroTipoRespaldo, IEnumerable<AppService.Core.Entities.OfdSolicitudDiseno>>>)(p => p.OfdSolicitudDiseno)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, object>>)(d => (object)d.IdTipoRespaldo)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdMaestroTipoRespaldo, AppService.Core.Entities.OfdSolicitudDiseno>("FK_OfdSolicitudDiseno_OfdMaestroTipoRespaldo");
                entity.HasOne<AppService.Core.Entities.OfdMaestroUbicacionMarginal>((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, AppService.Core.Entities.OfdMaestroUbicacionMarginal>>)(d => d.UbicacionMarginalNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdMaestroUbicacionMarginal, IEnumerable<AppService.Core.Entities.OfdSolicitudDiseno>>>)(p => p.OfdSolicitudDiseno)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, object>>)(d => (object)d.UbicacionMarginal)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdMaestroUbicacionMarginal, AppService.Core.Entities.OfdSolicitudDiseno>("FK_OfdSolicitudDiseno_OfdMaestroUbicacionMarginal");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdSolicitudDisenoCambios>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdSolicitudDisenoCambios>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDisenoCambios, object>>)(e => (object)e.IdSolDisCam));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdSolicitudDisenoCambios, object>>)(e => new
                {
                    IdSolicitud = e.IdSolicitud,
                    IdCambio = e.IdCambio
                })).HasName<AppService.Core.Entities.OfdSolicitudDisenoCambios>("IX_OfdSolicitudDisenoCambios").IsUnique(true);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdSolicitudDisenoCambios, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.HasOne<AppService.Core.Entities.OfdCambioDiseno>((Expression<Func<AppService.Core.Entities.OfdSolicitudDisenoCambios, AppService.Core.Entities.OfdCambioDiseno>>)(d => d.IdCambioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdCambioDiseno, IEnumerable<AppService.Core.Entities.OfdSolicitudDisenoCambios>>>)(p => p.OfdSolicitudDisenoCambios)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDisenoCambios, object>>)(d => (object)d.IdCambio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdCambioDiseno, AppService.Core.Entities.OfdSolicitudDisenoCambios>("FK_OfdSolicitudDisenoCambios_OfdCambioDiseno");
                entity.HasOne<AppService.Core.Entities.OfdSolicitudDiseno>((Expression<Func<AppService.Core.Entities.OfdSolicitudDisenoCambios, AppService.Core.Entities.OfdSolicitudDiseno>>)(d => d.IdSolicitudNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, IEnumerable<AppService.Core.Entities.OfdSolicitudDisenoCambios>>>)(p => p.OfdSolicitudDisenoCambios)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDisenoCambios, object>>)(d => (object)d.IdSolicitud)).HasConstraintName<AppService.Core.Entities.OfdSolicitudDiseno, AppService.Core.Entities.OfdSolicitudDisenoCambios>("FK_OfdSolicitudDisenoCambios_OfdSolicitudDiseno");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdSolicitudDocFiscal>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdSolicitudDocFiscal>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, object>>)(e => (object)e.IdSdf));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, string>>)(e => e.Cargo)).IsRequired(true).HasMaxLength(500);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, string>>)(e => e.EmailCliente)).IsRequired(true).HasMaxLength(500);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, DateTime>>)(e => e.FechaAgrega)).HasColumnType<DateTime>("smalldatetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, string>>)(e => e.IdEstatus)).IsRequired(true).HasMaxLength(10);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, Decimal?>>)(e => e.IdTicket)).HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, string>>)(e => e.ObsvCliente)).IsRequired(true).HasMaxLength(500).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, string>>)(e => e.ObsvConsultor)).IsRequired(true).HasMaxLength(500).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, string>>)(e => e.UsuarioAgrega)).IsRequired(true).HasMaxLength(40).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.HasOne<AppService.Core.Entities.OfdEstatusFlujo>((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, AppService.Core.Entities.OfdEstatusFlujo>>)(d => d.IdEstatusNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdEstatusFlujo, IEnumerable<AppService.Core.Entities.OfdSolicitudDocFiscal>>>)(p => p.OfdSolicitudDocFiscal)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, object>>)(d => d.IdEstatus)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdEstatusFlujo, AppService.Core.Entities.OfdSolicitudDocFiscal>("FK_OfdSolicitudDocFiscal_OfdEstatusFlujo");
                entity.HasOne<AppService.Core.Entities.PrcNumeracionFiscal>((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, AppService.Core.Entities.PrcNumeracionFiscal>>)(d => d.IdNumeracionNavigation)).WithMany((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, IEnumerable<AppService.Core.Entities.OfdSolicitudDocFiscal>>>)(p => p.OfdSolicitudDocFiscal)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdSolicitudDocFiscal, object>>)(d => (object)d.IdNumeracion)).HasConstraintName<AppService.Core.Entities.PrcNumeracionFiscal, AppService.Core.Entities.OfdSolicitudDocFiscal>("FK_OfdSolicitudDocFiscal_PrcNumeracionFiscal");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdTintasCotizacion>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdTintasCotizacion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdTintasCotizacion, object>>)(e => new
                {
                    Cotizacion = e.Cotizacion,
                    Renglon = e.Renglon,
                    Propuesta = e.Propuesta,
                    IdParte = e.IdParte,
                    IdUbicacion = e.IdUbicacion,
                    IdTinta = e.IdTinta
                }));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdTintasCotizacion, string>>)(e => e.Cotizacion)).HasMaxLength(13);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdTintasCotizacion, string>>)(e => e.IdTinta)).HasMaxLength(10).IsUnicode(false);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdTintasCotizacion, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdTipoCambioDiseno>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdTipoCambioDiseno>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdTipoCambioDiseno, object>>)(e => e.IdTipoCambio));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.OfdTipoCambioDiseno, object>>)(e => (object)e.IdPonderacion)).HasName<AppService.Core.Entities.OfdTipoCambioDiseno>("IX_OfdTipoCambioDiseno").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdTipoCambioDiseno, string>>)(e => e.IdTipoCambio)).HasMaxLength(4);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdTipoCambioDiseno, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdTipoCambioDiseno, string>>)(e => e.NombreTipoCambio)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdTipoCambioDiseno, string>>)(e => e.UsuarioRegistro)).IsRequired(true).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdTipoDocumento>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdTipoDocumento>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, object>>)(e => (object)e.IdTipoDocumento)).HasName("PK_TipoDocumento");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, short>>)(e => e.IdTipoDocumento)).ValueGeneratedNever();
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, bool?>>)(e => e.AfectaExpediente)).IsRequired(true).HasDefaultValueSql<bool?>("('')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, DateTime>>)(e => e.FechaModificacion)).HasColumnType<DateTime>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, string>>)(e => e.IdUsuarioCreacion)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, string>>)(e => e.IdUsuarioModificacion)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, string>>)(e => e.NombreDocumento)).IsRequired(true).HasMaxLength(100);
                entity.Property<bool?>((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, bool?>>)(e => e.Obligatorio)).IsRequired(true).HasDefaultValueSql<bool?>("('')");
                entity.HasOne<AppService.Core.Entities.OfdGrupoTipoDocumento>((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, AppService.Core.Entities.OfdGrupoTipoDocumento>>)(d => d.IdGrupoTipoDocumentoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdGrupoTipoDocumento, IEnumerable<AppService.Core.Entities.OfdTipoDocumento>>>)(p => p.OfdTipoDocumento)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdTipoDocumento, object>>)(d => (object)d.IdGrupoTipoDocumento)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdGrupoTipoDocumento, AppService.Core.Entities.OfdTipoDocumento>("FK_OfdTipoDocumento_OdfGrupoTipoDocumento");
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdVariablesEspecificacion>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdVariablesEspecificacion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdVariablesEspecificacion, object>>)(e => e.IdVariable)).HasName("PK_WPRY248");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdVariablesEspecificacion, string>>)(e => e.IdVariable)).HasMaxLength(20).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdVariablesEspecificacion, string>>)(e => e.FlagGralParte)).IsRequired(true).HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdVariablesEspecificacion, string>>)(e => e.FlagInactiva)).IsRequired(true).HasMaxLength(1).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdVariablesEspecificacion, string>>)(e => e.FlagMultipleValor)).IsRequired(true).HasMaxLength(1).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdVariablesEspecificacion, string>>)(e => e.FlagObligatorio)).IsRequired(true).HasMaxLength(1).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdVariablesEspecificacion, string>>)(e => e.IdVariableMc)).IsRequired(true).HasColumnName<string>("IdVariableMC").HasMaxLength(20).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdVariablesEspecificacion, string>>)(e => e.NombreVariable)).IsRequired(true).HasMaxLength(100).IsUnicode(false);
            }));
            modelBuilder.Entity<AppService.Core.Entities.OfdVoBoDiseno>((Action<EntityTypeBuilder<AppService.Core.Entities.OfdVoBoDiseno>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.OfdVoBoDiseno, object>>)(e => (object)e.IdVoBoSolicitud));
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.OfdVoBoDiseno, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.OfdVoBoDiseno, string>>)(e => e.IdUsuario)).IsRequired(true).HasMaxLength(40);
                entity.HasOne<AppService.Core.Entities.OfdSolicitudDiseno>((Expression<Func<AppService.Core.Entities.OfdVoBoDiseno, AppService.Core.Entities.OfdSolicitudDiseno>>)(d => d.IdSolicitudNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdSolicitudDiseno, IEnumerable<AppService.Core.Entities.OfdVoBoDiseno>>>)(p => p.OfdVoBoDiseno)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdVoBoDiseno, object>>)(d => (object)d.IdSolicitud)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdSolicitudDiseno, AppService.Core.Entities.OfdVoBoDiseno>("FK_OfdVoBoDiseno_OfdSolicitudDiseno");
                entity.HasOne<AppService.Core.Entities.OfdMaestroVoBo>((Expression<Func<AppService.Core.Entities.OfdVoBoDiseno, AppService.Core.Entities.OfdMaestroVoBo>>)(d => d.IdVoBoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdMaestroVoBo, IEnumerable<AppService.Core.Entities.OfdVoBoDiseno>>>)(p => p.OfdVoBoDiseno)).HasForeignKey((Expression<Func<AppService.Core.Entities.OfdVoBoDiseno, object>>)(d => (object)d.IdVoBo)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdMaestroVoBo, AppService.Core.Entities.OfdVoBoDiseno>("FK_OfdVoBoDiseno_OfdMaestroVoBo");
            }));
            modelBuilder.Entity<AppService.Core.Entities.PageMenu>((Action<EntityTypeBuilder<AppService.Core.Entities.PageMenu>>)(entity =>
            {
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PageMenu, string>>)(e => e.Icon)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PageMenu, string>>)(e => e.Title)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PageMenu, string>>)(e => e.Url)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.Personas>((Action<EntityTypeBuilder<AppService.Core.Entities.Personas>>)(entity =>
            {
                entity.HasNoKey();
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Personas, int>>)(e => e.Id)).HasColumnName<int>("ID").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Personas, string>>)(e => e.Primernombre)).IsRequired(true).HasColumnName<string>("PRIMERNOMBRE").HasMaxLength(50).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Personas, string>>)(e => e.Segundonombre)).IsRequired(true).HasColumnName<string>("SEGUNDONOMBRE").HasMaxLength(50).IsUnicode(false);
            }));
            modelBuilder.Entity<AppService.Core.Entities.PrcNumeracionFiscal>((Action<EntityTypeBuilder<AppService.Core.Entities.PrcNumeracionFiscal>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, object>>)(e => (object)e.IdNumeracion));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, object>>)(e => (object)e.IdPropuesta)).HasName<AppService.Core.Entities.PrcNumeracionFiscal>("IX_PrcNumeracionFiscal");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, object>>)(e => new
                {
                    Rif = e.Rif,
                    NumeroSerieControlDesde = e.NumeroSerieControlDesde,
                    NumeroControlDesde = e.NumeroControlDesde
                })).HasName<AppService.Core.Entities.PrcNumeracionFiscal>("IX_SerieControl");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, DateTime?>>)(e => e.FechaAgrega)).HasColumnType<DateTime?>("smalldatetime").HasDefaultValueSql<DateTime?>("(getdate())");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, int?>>)(e => e.LongitudMascaraFormato)).HasDefaultValueSql<int?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, string>>)(e => e.NumeroControlDesde)).IsRequired(true).HasMaxLength(8);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, string>>)(e => e.NumeroControlHasta)).IsRequired(true).HasMaxLength(8);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, string>>)(e => e.NumeroFormatoDesde)).HasMaxLength(10).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, string>>)(e => e.NumeroFormatoHasta)).HasMaxLength(10).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, string>>)(e => e.NumeroSerieControlDesde)).IsRequired(true).HasMaxLength(2).HasDefaultValueSql<string>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, string>>)(e => e.NumeroSerieControlHasta)).IsRequired(true).HasMaxLength(2).HasDefaultValueSql<string>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, string>>)(e => e.NumeroSerieFormatoDesde)).HasMaxLength(10).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, string>>)(e => e.NumeroSerieFormatoHasta)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, string>>)(e => e.Rif)).IsRequired(true).HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, string>>)(e => e.TipoDocumento)).IsRequired(true).HasMaxLength(2);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, string>>)(e => e.UsuarioAgrega)).HasMaxLength(40).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.HasOne<AppService.Core.Entities.OfdPropuesta>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, AppService.Core.Entities.OfdPropuesta>>)(d => d.IdPropuestaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.OfdPropuesta, IEnumerable<AppService.Core.Entities.PrcNumeracionFiscal>>>)(p => p.PrcNumeracionFiscal)).HasForeignKey((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, object>>)(d => (object)d.IdPropuesta)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.OfdPropuesta, AppService.Core.Entities.PrcNumeracionFiscal>("FK_PrcNumeracionFiscal_OfdPropuesta");
                entity.HasOne<AppService.Core.Entities.MtrTipoDocumentoFiscal>((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, AppService.Core.Entities.MtrTipoDocumentoFiscal>>)(d => d.TipoDocumentoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.MtrTipoDocumentoFiscal, IEnumerable<AppService.Core.Entities.PrcNumeracionFiscal>>>)(p => p.PrcNumeracionFiscal)).HasForeignKey((Expression<Func<AppService.Core.Entities.PrcNumeracionFiscal, object>>)(d => d.TipoDocumento)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.MtrTipoDocumentoFiscal, AppService.Core.Entities.PrcNumeracionFiscal>("FK_PrcNumeracionFiscal_MtrTipoDocumentoFiscal");
            }));
            modelBuilder.Entity<AppService.Core.Entities.PrcObjetosProcesos>((Action<EntityTypeBuilder<AppService.Core.Entities.PrcObjetosProcesos>>)(entity =>
            {
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.PrcObjetosProcesos, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcObjetosProcesos, string>>)(e => e.BaseDatos)).IsRequired(true).HasMaxLength(100);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.PrcObjetosProcesos, Decimal>>)(e => e.ColaDeTrabajo)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcObjetosProcesos, string>>)(e => e.Descripcion)).IsRequired(true).HasMaxLength(100);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.PrcObjetosProcesos, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcObjetosProcesos, string>>)(e => e.Objeto)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcObjetosProcesos, string>>)(e => e.Servidor)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcObjetosProcesos, string>>)(e => e.UsuarioRegistro)).IsRequired(true).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.PrcOrdenIdPropuesta>((Action<EntityTypeBuilder<AppService.Core.Entities.PrcOrdenIdPropuesta>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.PrcOrdenIdPropuesta, object>>)(e => (object)e.IdPropuesta)).HasName<AppService.Core.Entities.PrcOrdenIdPropuesta>("IX_PrcOrdenIdPropuesta");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.PrcOrdenIdPropuesta, object>>)(e => (object)e.Orden)).HasName<AppService.Core.Entities.PrcOrdenIdPropuesta>("IX_PrcOrdenIdPropuesta_1");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.PrcOrdenIdPropuesta, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
            }));
            modelBuilder.Entity<AppService.Core.Entities.PrcPlantillaNumeraciones>((Action<EntityTypeBuilder<AppService.Core.Entities.PrcPlantillaNumeraciones>>)(entity =>
            {
                entity.HasNoKey();
                entity.HasIndex((Expression<Func<AppService.Core.Entities.PrcPlantillaNumeraciones, object>>)(e => (object)e.Mascara)).HasName<AppService.Core.Entities.PrcPlantillaNumeraciones>("IX_PrcNumeraciones");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.PrcPlantillaNumeraciones, Decimal?>>)(e => e.Hasta)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.PrcPlantillaNumeraciones, long>>)(e => e.Id)).ValueGeneratedOnAdd();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.PrcPlantillaNumeraciones, Decimal?>>)(e => e.MaximoNumero)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcPlantillaNumeraciones, string>>)(e => e.PrefijoChar)).HasMaxLength(2);
            }));
            modelBuilder.Entity<AppService.Core.Entities.PrcUsuarioProcesos>((Action<EntityTypeBuilder<AppService.Core.Entities.PrcUsuarioProcesos>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.PrcUsuarioProcesos, object>>)(e => new
                {
                    IdProceso = e.IdProceso,
                    Usuario = e.Usuario
                })).HasName<AppService.Core.Entities.PrcUsuarioProcesos>("IX_PrcUsuarioProcesos").IsUnique(true);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.PrcUsuarioProcesos, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.PrcUsuarioProcesos, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.PrcUsuarioProcesos, Decimal>>)(e => e.IdProceso)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.PrcUsuarioProcesos, string>>)(e => e.Usuario)).IsRequired(true).HasMaxLength(40);
                entity.HasOne<AppService.Core.Entities.PrcObjetosProcesos>((Expression<Func<AppService.Core.Entities.PrcUsuarioProcesos, AppService.Core.Entities.PrcObjetosProcesos>>)(d => d.IdProcesoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.PrcObjetosProcesos, IEnumerable<AppService.Core.Entities.PrcUsuarioProcesos>>>)(p => p.PrcUsuarioProcesos)).HasForeignKey((Expression<Func<AppService.Core.Entities.PrcUsuarioProcesos, object>>)(d => (object)d.IdProceso)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.PrcObjetosProcesos, AppService.Core.Entities.PrcUsuarioProcesos>("FK_PrcUsuarioProcesos_PrcObjetosProcesos");
            }));
            modelBuilder.Entity<AppService.Core.Entities.Producto>((Action<EntityTypeBuilder<AppService.Core.Entities.Producto>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.Producto>("PRODUCTO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Producto, string>>)(e => e.Codigo)).HasColumnName<string>("CODIGO").HasMaxLength((int)byte.MaxValue);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Producto, string>>)(e => e.Descripcion)).HasColumnName<string>("DESCRIPCION").HasMaxLength((int)byte.MaxValue);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Producto, Decimal?>>)(e => e.Precio)).HasColumnName<Decimal?>("PRECIO").HasColumnType<Decimal?>("decimal(18, 2)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.ReqAreaRequerimiento>((Action<EntityTypeBuilder<AppService.Core.Entities.ReqAreaRequerimiento>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.ReqAreaRequerimiento, object>>)(e => (object)e.IdAreaRequerimiento));
                entity.Property<int>((Expression<Func<AppService.Core.Entities.ReqAreaRequerimiento, int>>)(e => e.IdAreaRequerimiento)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqAreaRequerimiento, string>>)(e => e.DescripcionAreaRequerimiento)).IsRequired(true).HasMaxLength(60);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.ReqAreaRequerimiento, DateTime?>>)(e => e.FechaCambio)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqAreaRequerimiento, string>>)(e => e.UsuarioCambio)).HasMaxLength(30);
                entity.HasOne<AppService.Core.Entities.ReqOrigenRequerimiento>((Expression<Func<AppService.Core.Entities.ReqAreaRequerimiento, AppService.Core.Entities.ReqOrigenRequerimiento>>)(d => d.IdOrigenRequerimientoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.ReqOrigenRequerimiento, IEnumerable<AppService.Core.Entities.ReqAreaRequerimiento>>>)(p => p.ReqAreaRequerimiento)).HasForeignKey((Expression<Func<AppService.Core.Entities.ReqAreaRequerimiento, object>>)(d => (object)d.IdOrigenRequerimiento)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.ReqOrigenRequerimiento, AppService.Core.Entities.ReqAreaRequerimiento>("FK_ReqAreaRequerimiento_ReqOrigenRequerimiento");
            }));
            modelBuilder.Entity<AppService.Core.Entities.ReqCompañia>((Action<EntityTypeBuilder<AppService.Core.Entities.ReqCompañia>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.ReqCompañia, object>>)(e => e.IdCompañia));
                entity.HasComment<AppService.Core.Entities.ReqCompañia>("Lista de Compañias");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqCompañia, string>>)(e => e.IdCompañia)).HasMaxLength(10);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.ReqCompañia, DateTime?>>)(e => e.FechaCambio)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqCompañia, string>>)(e => e.NombreCompañia)).IsRequired(true).HasMaxLength(80);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqCompañia, string>>)(e => e.UsuarioCambio)).HasMaxLength(30);
            }));
            modelBuilder.Entity<AppService.Core.Entities.ReqOrigenRequerimiento>((Action<EntityTypeBuilder<AppService.Core.Entities.ReqOrigenRequerimiento>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.ReqOrigenRequerimiento, object>>)(e => (object)e.IdOrigenRequerimiento));
                entity.HasComment<AppService.Core.Entities.ReqOrigenRequerimiento>("Origenes de Requerimientos de Servicios");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.ReqOrigenRequerimiento, int>>)(e => e.IdOrigenRequerimiento)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqOrigenRequerimiento, string>>)(e => e.DescripcionOrigenRequerimiento)).IsRequired(true).HasMaxLength(50);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.ReqOrigenRequerimiento, DateTime?>>)(e => e.FechaCambio)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqOrigenRequerimiento, string>>)(e => e.IdCompañia)).HasMaxLength(10);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqOrigenRequerimiento, string>>)(e => e.UsuarioCambio)).HasMaxLength(30);
                entity.HasOne<AppService.Core.Entities.ReqCompañia>((Expression<Func<AppService.Core.Entities.ReqOrigenRequerimiento, AppService.Core.Entities.ReqCompañia>>)(d => d.IdCompañiaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.ReqCompañia, IEnumerable<AppService.Core.Entities.ReqOrigenRequerimiento>>>)(p => p.ReqOrigenRequerimiento)).HasForeignKey((Expression<Func<AppService.Core.Entities.ReqOrigenRequerimiento, object>>)(d => d.IdCompañia)).HasConstraintName<AppService.Core.Entities.ReqCompañia, AppService.Core.Entities.ReqOrigenRequerimiento>("FK_ReqOrigenRequerimiento_ReqCompañia");
            }));
            modelBuilder.Entity<AppService.Core.Entities.ReqTarea>((Action<EntityTypeBuilder<AppService.Core.Entities.ReqTarea>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.ReqTarea, object>>)(e => (object)e.IdTarea));
                entity.Property<int>((Expression<Func<AppService.Core.Entities.ReqTarea, int>>)(e => e.IdTarea)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqTarea, string>>)(e => e.DescripcionTarea)).IsRequired(true).HasMaxLength(250);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.ReqTarea, DateTime?>>)(e => e.FechaCambio)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqTarea, string>>)(e => e.UsuarioCambio)).HasMaxLength(30);
                entity.HasOne<AppService.Core.Entities.ReqTipoTarea>((Expression<Func<AppService.Core.Entities.ReqTarea, AppService.Core.Entities.ReqTipoTarea>>)(d => d.IdTipoTareaNavigation)).WithMany((Expression<Func<AppService.Core.Entities.ReqTipoTarea, IEnumerable<AppService.Core.Entities.ReqTarea>>>)(p => p.ReqTarea)).HasForeignKey((Expression<Func<AppService.Core.Entities.ReqTarea, object>>)(d => (object)d.IdTipoTarea)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.ReqTipoTarea, AppService.Core.Entities.ReqTarea>("FK_ReqTarea_ReqTipoTarea");
            }));
            modelBuilder.Entity<AppService.Core.Entities.ReqTipoTarea>((Action<EntityTypeBuilder<AppService.Core.Entities.ReqTipoTarea>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.ReqTipoTarea, object>>)(e => (object)e.IdTipoTarea)).HasName("PK_ReqTipoRequerimiento");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.ReqTipoTarea, int>>)(e => e.IdTipoTarea)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqTipoTarea, string>>)(e => e.DescripcionTipoTarea)).IsRequired(true).HasMaxLength(60);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.ReqTipoTarea, DateTime?>>)(e => e.FechaCambio)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqTipoTarea, string>>)(e => e.UsuarioCambio)).IsRequired(true).HasMaxLength(30);
                entity.HasOne<AppService.Core.Entities.ReqAreaRequerimiento>((Expression<Func<AppService.Core.Entities.ReqTipoTarea, AppService.Core.Entities.ReqAreaRequerimiento>>)(d => d.IdAreaRequerimientoNavigation)).WithMany((Expression<Func<AppService.Core.Entities.ReqAreaRequerimiento, IEnumerable<AppService.Core.Entities.ReqTipoTarea>>>)(p => p.ReqTipoTarea)).HasForeignKey((Expression<Func<AppService.Core.Entities.ReqTipoTarea, object>>)(d => (object)d.IdAreaRequerimiento)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.ReqAreaRequerimiento, AppService.Core.Entities.ReqTipoTarea>("FK_ReqTipoRequerimiento_ReqAreaRequerimiento");
            }));
            modelBuilder.Entity<AppService.Core.Entities.ReqVariables>((Action<EntityTypeBuilder<AppService.Core.Entities.ReqVariables>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.ReqVariables, object>>)(e => (object)e.IdVariable));
                entity.HasComment<AppService.Core.Entities.ReqVariables>("Variables para Plantillas por Tarea");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.ReqVariables, int>>)(e => e.IdVariable)).ValueGeneratedNever();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.ReqVariables, DateTime?>>)(e => e.FechaCambio)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqVariables, string>>)(e => e.FuncionValidacion)).HasMaxLength(1500);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqVariables, string>>)(e => e.NombreVariable)).IsRequired(true).HasMaxLength(60);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqVariables, string>>)(e => e.TipoDato)).IsRequired(true).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ReqVariables, string>>)(e => e.UsuarioCambio)).IsRequired(true).HasMaxLength(30);
            }));
            modelBuilder.Entity<AppService.Core.Entities.RetencionesCorregir>((Action<EntityTypeBuilder<AppService.Core.Entities.RetencionesCorregir>>)(entity =>
            {
                entity.HasNoKey();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.RetencionesCorregir, string>>)(e => e.CertificadoRetencion)).HasMaxLength(50).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.RetencionesCorregir, string>>)(e => e.Documento)).HasMaxLength(50).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.RetencionesCorregir, string>>)(e => e.Ejercicio)).HasMaxLength(50).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.RetencionesCorregir, string>>)(e => e.FechaCertificadoRetencion)).HasMaxLength(50).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.RetencionesCorregir, string>>)(e => e.IndicadorRetenciN)).HasColumnName<string>("IndicadorRetenci¢n").HasMaxLength(50).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.RetencionesCorregir, string>>)(e => e.Posicion)).HasMaxLength(50).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.RetencionesCorregir, string>>)(e => e.Sociedad)).HasMaxLength(50).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.RetencionesCorregir, string>>)(e => e.TipoRetenciones)).HasMaxLength(50).IsUnicode(false);
            }));
            modelBuilder.Entity<AppService.Core.Entities.RrdejecutarSql>((Action<EntityTypeBuilder<AppService.Core.Entities.RrdejecutarSql>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.RrdejecutarSql>("RRDEjecutarSql");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.RrdejecutarSql, string>>)(e => e.Ejecutar)).HasMaxLength(1);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.RrdejecutarSql, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.RrdejecutarSql, string>>)(e => e.Proceso)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.SapFrecuenciaVisitaCliente>((Action<EntityTypeBuilder<AppService.Core.Entities.SapFrecuenciaVisitaCliente>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.SapFrecuenciaVisitaCliente, object>>)(e => e.IdCliente));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SapFrecuenciaVisitaCliente, string>>)(e => e.IdCliente)).HasMaxLength(10);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.SapFrecuenciaVisitaCliente, DateTime>>)(e => e.FechaActualiza)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.SapFrecuenciaVisitaCliente, DateTime>>)(e => e.FechaCreacion)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SapFrecuenciaVisitaCliente, string>>)(e => e.UsuarioActualiza)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SapFrecuenciaVisitaCliente, string>>)(e => e.UsuarioCreacion)).IsRequired(true).HasMaxLength(40);
            }));
            modelBuilder.Entity<AppService.Core.Entities.SapRetenciones>((Action<EntityTypeBuilder<AppService.Core.Entities.SapRetenciones>>)(entity =>
            {
                entity.HasNoKey();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SapRetenciones, string>>)(e => e.Denominacion)).HasMaxLength((int)byte.MaxValue);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.SapRetenciones, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SapRetenciones, string>>)(e => e.IndicadordeRetencion)).HasMaxLength((int)byte.MaxValue);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SapRetenciones, string>>)(e => e.TipodeRetencion)).HasMaxLength((int)byte.MaxValue);
            }));
            modelBuilder.Entity<AppService.Core.Entities.SegModulo>((Action<EntityTypeBuilder<AppService.Core.Entities.SegModulo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.SegModulo, object>>)(e => (object)e.IdModulo));
                entity.Property<int>((Expression<Func<AppService.Core.Entities.SegModulo, int>>)(e => e.IdModulo)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegModulo, string>>)(e => e.Descripcion)).HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegModulo, string>>)(e => e.FlagPortafolioReportes)).IsRequired(true).HasMaxLength(1).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegModulo, string>>)(e => e.Icono)).HasMaxLength(100).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegModulo, string>>)(e => e.IconoMenu)).IsRequired(true).HasMaxLength(50).HasDefaultValueSql<string>("('')");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.SegModulo, short?>>)(e => e.IdTipoReporte)).HasDefaultValueSql<short?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegModulo, string>>)(e => e.LinkModulo)).HasMaxLength(200).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegModulo, string>>)(e => e.NombreModulo)).HasMaxLength(200).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegModulo, string>>)(e => e.NombreReporte)).HasMaxLength(100).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegModulo, string>>)(e => e.RutaReporte)).HasMaxLength(500).HasDefaultValueSql<string>("('')");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.SegModulo, short?>>)(e => e.ServidorReporte)).HasDefaultValueSql<short?>("((0))");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.SegModulo, short?>>)(e => e.TipoLlamada)).HasColumnName<short?>("TipoLLamada").HasDefaultValueSql<short?>("((0))");
            }));
            modelBuilder.Entity<AppService.Core.Entities.SegPrograma>((Action<EntityTypeBuilder<AppService.Core.Entities.SegPrograma>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.SegPrograma, object>>)(e => (object)e.IdPrograma));
                entity.Property<int>((Expression<Func<AppService.Core.Entities.SegPrograma, int>>)(e => e.IdPrograma)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegPrograma, string>>)(e => e.Descripcion)).HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegPrograma, string>>)(e => e.FlagRequerimiento)).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegPrograma, string>>)(e => e.Link)).HasColumnName<string>("link").HasMaxLength(200);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegPrograma, string>>)(e => e.NombrePrograma)).IsRequired(true).HasMaxLength(100).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegPrograma, string>>)(e => e.TipoPrograma)).HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("('')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.SegRol>((Action<EntityTypeBuilder<AppService.Core.Entities.SegRol>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.SegRol, object>>)(e => (object)e.IdRol));
                entity.Property<int>((Expression<Func<AppService.Core.Entities.SegRol, int>>)(e => e.IdRol)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegRol, string>>)(e => e.AbreviadoRol)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegRol, string>>)(e => e.DescripcionRol)).IsRequired(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegRol, string>>)(e => e.NombreRol)).IsRequired(true).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.SegRolEstacion>((Action<EntityTypeBuilder<AppService.Core.Entities.SegRolEstacion>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.SegRolEstacion, object>>)(e => (object)e.IdRolEstacion));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.SegRolEstacion, object>>)(e => (object)e.IdRol)).HasName<AppService.Core.Entities.SegRolEstacion>("IX_SegRolEstacion_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.SegRolEstacion, object>>)(e => new
                {
                    IdEstacion = e.IdEstacion,
                    IdRol = e.IdRol
                })).HasName<AppService.Core.Entities.SegRolEstacion>("IX_SegRolEstacion").IsUnique(true);
            }));
            modelBuilder.Entity<AppService.Core.Entities.SegRolModulo>((Action<EntityTypeBuilder<AppService.Core.Entities.SegRolModulo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.SegRolModulo, object>>)(e => (object)e.IdRolModulo));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.SegRolModulo, object>>)(e => new
                {
                    IdRol = e.IdRol,
                    IdModulo = e.IdModulo
                })).HasName<AppService.Core.Entities.SegRolModulo>("IX_SegRolModulo").IsUnique(true);
                entity.Property<int>((Expression<Func<AppService.Core.Entities.SegRolModulo, int>>)(e => e.IdRolModulo)).ValueGeneratedNever();
            }));
            modelBuilder.Entity<AppService.Core.Entities.SegTicket>((Action<EntityTypeBuilder<AppService.Core.Entities.SegTicket>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.SegTicket, object>>)(e => e.TicketSha1));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegTicket, string>>)(e => e.TicketSha1)).HasMaxLength(100);
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.SegTicket, DateTime>>)(e => e.FechaHoraCreacion)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.SegTicket, DateTime?>>)(e => e.FechaHoraGetIp)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.SegTicket, DateTime?>>)(e => e.FechaHoraUso)).HasColumnType<DateTime?>("datetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.SegTicket, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegTicket, string>>)(e => e.IdUsuario)).IsRequired(true).HasMaxLength(40);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegTicket, string>>)(e => e.IpUsuario)).HasMaxLength(50).HasDefaultValueSql<string>("('')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.SegUsuario>((Action<EntityTypeBuilder<AppService.Core.Entities.SegUsuario>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.SegUsuario, object>>)(e => (object)e.IdUsuario)).HasName("PK_Usuario");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.SegUsuario, object>>)(e => e.Email)).HasName<AppService.Core.Entities.SegUsuario>("IX_Email");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.SegUsuario, object>>)(e => e.Usuario)).HasName<AppService.Core.Entities.SegUsuario>("IX_SegUsuario_1").IsUnique(true);
                entity.Property<int>((Expression<Func<AppService.Core.Entities.SegUsuario, int>>)(e => e.IdUsuario)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.ClasificacionUsuario)).IsRequired(true).HasMaxLength(4).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.Clave)).IsRequired(true).HasMaxLength(40).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.Email)).IsRequired(true).HasMaxLength(200);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.EquipoImei1)).HasMaxLength(100).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.EquipoImei2)).HasMaxLength(100).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.EquipoImei3)).HasMaxLength(100).IsUnicode(false);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.SegUsuario, DateTime?>>)(e => e.FechaCambio)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.Ficha)).IsRequired(true).HasMaxLength(6).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.FlagDisenador)).HasColumnName<string>("Flag_Disenador").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.Imei1)).HasMaxLength(1000).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.Imei2)).HasMaxLength(1000).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.Imei3)).HasMaxLength(1000).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.NombreUsuario)).IsRequired(true).HasMaxLength(100).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.SegUsuario, string>>)(e => e.Usuario)).IsRequired(true).HasMaxLength(40).IsUnicode(false);
            }));
            modelBuilder.Entity<AppService.Core.Entities.SegUsuarioRol>((Action<EntityTypeBuilder<AppService.Core.Entities.SegUsuarioRol>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.SegUsuarioRol, object>>)(e => (object)e.IdUsuarioRol));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.SegUsuarioRol, object>>)(e => new
                {
                    IdUsuario = e.IdUsuario,
                    IdRol = e.IdRol
                })).HasName<AppService.Core.Entities.SegUsuarioRol>("IX_SegUsuarioRol").IsUnique(true);
                entity.Property<int>((Expression<Func<AppService.Core.Entities.SegUsuarioRol, int>>)(e => e.IdUsuarioRol)).ValueGeneratedNever();
                entity.HasOne<AppService.Core.Entities.SegRol>((Expression<Func<AppService.Core.Entities.SegUsuarioRol, AppService.Core.Entities.SegRol>>)(d => d.IdRolNavigation)).WithMany((Expression<Func<AppService.Core.Entities.SegRol, IEnumerable<AppService.Core.Entities.SegUsuarioRol>>>)(p => p.SegUsuarioRol)).HasForeignKey((Expression<Func<AppService.Core.Entities.SegUsuarioRol, object>>)(d => (object)d.IdRol)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.SegRol, AppService.Core.Entities.SegUsuarioRol>("FK_SegUsuarioRol_SegRol");
                entity.HasOne<AppService.Core.Entities.SegUsuario>((Expression<Func<AppService.Core.Entities.SegUsuarioRol, AppService.Core.Entities.SegUsuario>>)(d => d.IdUsuarioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.SegUsuario, IEnumerable<AppService.Core.Entities.SegUsuarioRol>>>)(p => p.SegUsuarioRol)).HasForeignKey((Expression<Func<AppService.Core.Entities.SegUsuarioRol, object>>)(d => (object)d.IdUsuario)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.SegUsuario, AppService.Core.Entities.SegUsuarioRol>("FK_SegUsuarioRol_SegUsuario1");
            }));
            modelBuilder.Entity<AppService.Core.Entities.Sysfile>((Action<EntityTypeBuilder<AppService.Core.Entities.Sysfile>>)(entity =>
            {
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Sysfile, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Sysfile, string>>)(e => e.DirVirtualOd)).HasColumnName<string>("DirVirtualOD").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Sysfile, string>>)(e => e.LinkServer)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Sysfile, string>>)(e => e.LinkServerProduccion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Sysfile, string>>)(e => e.MailserverName)).HasColumnName<string>("mailserver_name").HasMaxLength(100);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Sysfile, Decimal?>>)(e => e.MailserverPort)).HasColumnName<Decimal?>("mailserver_Port").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Sysfile, string>>)(e => e.MailserverType)).HasColumnName<string>("mailserver_type").HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Sysfile, string>>)(e => e.Servidor)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Sysfile, string>>)(e => e.WebServer)).HasMaxLength(100).HasDefaultValueSql<string>("('')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.T006a>((Action<EntityTypeBuilder<AppService.Core.Entities.T006a>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.T006a, object>>)(e => e.Msehi));
                entity.ToTable<AppService.Core.Entities.T006a>("T006A");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.T006a, string>>)(e => e.Msehi)).HasColumnName<string>("MSEHI").HasMaxLength(18);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.T006a, string>>)(e => e.Mandt)).IsRequired(true).HasColumnName<string>("MANDT").HasMaxLength(18);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.T006a, string>>)(e => e.Mseh3)).IsRequired(true).HasColumnName<string>("MSEH3").HasMaxLength(18);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.T006a, string>>)(e => e.Mseh6)).IsRequired(true).HasColumnName<string>("MSEH6").HasMaxLength(36);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.T006a, string>>)(e => e.Msehl)).IsRequired(true).HasColumnName<string>("MSEHL").HasMaxLength(180);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.T006a, string>>)(e => e.Mseht)).IsRequired(true).HasColumnName<string>("MSEHT").HasMaxLength(60);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.T006a, string>>)(e => e.Spras)).IsRequired(true).HasColumnName<string>("SPRAS").HasMaxLength(6);
            }));
            modelBuilder.Entity<AppService.Core.Entities.TEnControlCalculo>((Action<EntityTypeBuilder<AppService.Core.Entities.TEnControlCalculo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TEnControlCalculo, object>>)(e => (object)e.IdSolicitud));
                entity.ToTable<AppService.Core.Entities.TEnControlCalculo>("T_En_ControlCalculo");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TEnControlCalculo, Decimal>>)(e => e.IdSolicitud)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TEnControlCalculo, string>>)(e => e.Documento)).HasMaxLength(20);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TEnControlCalculo, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("smalldatetime").HasDefaultValueSql<DateTime?>("(getdate())");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TEnControlCalculo, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
            }));
            modelBuilder.Entity<AppService.Core.Entities.TEnEntradas>((Action<EntityTypeBuilder<AppService.Core.Entities.TEnEntradas>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TEnEntradas, object>>)(e => new
                {
                    IdSolicitud = e.IdSolicitud,
                    LineaNegocio = e.LineaNegocio,
                    IdVariables = e.IdVariables,
                    Item = e.Item
                }));
                entity.ToTable<AppService.Core.Entities.TEnEntradas>("T_En_Entradas");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TEnEntradas, Decimal>>)(e => e.IdSolicitud)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TEnEntradas, string>>)(e => e.IdVariables)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TEnEntradas, string>>)(e => e.FuncionDeBusqueda)).HasMaxLength(500);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TEnEntradas, string>>)(e => e.FuncionDeBusquedaValor)).HasMaxLength(500);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TEnEntradas, string>>)(e => e.FuncionDeValidacion)).HasMaxLength(500).HasDefaultValueSql<string>("('')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TEnEntradas, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TEnEntradas, string>>)(e => e.MensajeValidacion)).HasMaxLength(500).HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TEnEntradas, string>>)(e => e.Orden)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TEnEntradas, string>>)(e => e.Producto)).HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TEnEntradas, string>>)(e => e.Valor)).HasMaxLength(50);
                entity.HasOne<AppService.Core.Entities.TPaVariables>((Expression<Func<AppService.Core.Entities.TEnEntradas, AppService.Core.Entities.TPaVariables>>)(d => d.IdVariablesNavigation)).WithMany((Expression<Func<AppService.Core.Entities.TPaVariables, IEnumerable<AppService.Core.Entities.TEnEntradas>>>)(p => p.TEnEntradas)).HasForeignKey((Expression<Func<AppService.Core.Entities.TEnEntradas, object>>)(d => d.IdVariables)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.TPaVariables, AppService.Core.Entities.TEnEntradas>("FK_T_En_Entradas_T_Pa_Variables");
            }));
            modelBuilder.Entity<AppService.Core.Entities.TPaFormulas>((Action<EntityTypeBuilder<AppService.Core.Entities.TPaFormulas>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TPaFormulas, object>>)(e => new
                {
                    IdVariables = e.IdVariables,
                    LineaNegocio = e.LineaNegocio
                }));
                entity.ToTable<AppService.Core.Entities.TPaFormulas>("T_Pa_Formulas");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaFormulas, string>>)(e => e.IdVariables)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaFormulas, string>>)(e => e.DescripcionFormula)).HasMaxLength(4000).HasDefaultValueSql<string>("('')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaFormulas, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaFormulas, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaFormulas, string>>)(e => e.Formula)).HasMaxLength(4000);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TPaFormulas, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TPaFormulas, Decimal?>>)(e => e.OrdenCalculo)).HasColumnType<Decimal?>("numeric(18, 1)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaFormulas, string>>)(e => e.UsuarioCreacion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaFormulas, string>>)(e => e.UsuarioModifico)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.TPaModeloCalculo>((Action<EntityTypeBuilder<AppService.Core.Entities.TPaModeloCalculo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TPaModeloCalculo, object>>)(e => (object)e.CodigoModelo)).HasName("PK_T_Pr_TiposDeCalculo");
                entity.ToTable<AppService.Core.Entities.TPaModeloCalculo>("T_Pa_ModeloCalculo");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.TPaModeloCalculo, int>>)(e => e.CodigoModelo)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaModeloCalculo, string>>)(e => e.DescripcionModelo)).HasMaxLength(256);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaModeloCalculo, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaModeloCalculo, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TPaModeloCalculo, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaModeloCalculo, string>>)(e => e.UsuarioCreacion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaModeloCalculo, string>>)(e => e.UsuarioModifico)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.TPaPlantillaEntradas>((Action<EntityTypeBuilder<AppService.Core.Entities.TPaPlantillaEntradas>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, object>>)(e => new
                {
                    LineaNegocio = e.LineaNegocio,
                    IdVariables = e.IdVariables,
                    Item = e.Item
                }));
                entity.ToTable<AppService.Core.Entities.TPaPlantillaEntradas>("T_PA_PlantillaEntradas");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, string>>)(e => e.IdVariables)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, string>>)(e => e.DescripcionVariable)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, string>>)(e => e.FuncionDeBusqueda)).HasMaxLength(500);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, string>>)(e => e.FuncionDeValidacion)).HasMaxLength(500);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, string>>)(e => e.Observaciones)).HasMaxLength(500);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, string>>)(e => e.Valor)).HasMaxLength(50);
                entity.HasOne<AppService.Core.Entities.TPaVariables>((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, AppService.Core.Entities.TPaVariables>>)(d => d.IdVariablesNavigation)).WithMany((Expression<Func<AppService.Core.Entities.TPaVariables, IEnumerable<AppService.Core.Entities.TPaPlantillaEntradas>>>)(p => p.TPaPlantillaEntradas)).HasForeignKey((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, object>>)(d => d.IdVariables)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.TPaVariables, AppService.Core.Entities.TPaPlantillaEntradas>("FK_T_PA_PlantillaEntradas_T_Pa_Variables");
                entity.HasOne<AppService.Core.Entities.TPaModeloCalculo>((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, AppService.Core.Entities.TPaModeloCalculo>>)(d => d.LineaNegocioNavigation)).WithMany((Expression<Func<AppService.Core.Entities.TPaModeloCalculo, IEnumerable<AppService.Core.Entities.TPaPlantillaEntradas>>>)(p => p.TPaPlantillaEntradas)).HasForeignKey((Expression<Func<AppService.Core.Entities.TPaPlantillaEntradas, object>>)(d => (object)d.LineaNegocio)).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName<AppService.Core.Entities.TPaModeloCalculo, AppService.Core.Entities.TPaPlantillaEntradas>("FK_T_PA_PlantillaEntradas_T_Pa_ModeloCalculo");
            }));
            modelBuilder.Entity<AppService.Core.Entities.TPaSysfile>((Action<EntityTypeBuilder<AppService.Core.Entities.TPaSysfile>>)(entity =>
            {
                entity.ToTable<AppService.Core.Entities.TPaSysfile>("T_Pa_Sysfile");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TPaSysfile, Decimal?>>)(e => e.ConsecutivoOrdenPlantilla)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaSysfile, string>>)(e => e.CopiaFuncional)).HasMaxLength(256);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaSysfile, string>>)(e => e.CopiaTecnico)).HasMaxLength(256);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaSysfile, string>>)(e => e.DestinatarioFuncional)).HasMaxLength(256);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaSysfile, string>>)(e => e.DestinatarioTecnico)).HasMaxLength(256);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaSysfile, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaSysfile, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaSysfile, string>>)(e => e.SegundaCopiaFuncional)).HasMaxLength(256);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaSysfile, string>>)(e => e.UsuarioCreacion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaSysfile, string>>)(e => e.UsuarioModifico)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.TPaTasaBancoCentral>((Action<EntityTypeBuilder<AppService.Core.Entities.TPaTasaBancoCentral>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.TPaTasaBancoCentral>("T_Pa_Tasa_BancoCentral");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaTasaBancoCentral, DateTime?>>)(e => e.Fecha)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTasaBancoCentral, string>>)(e => e.FechaTasa)).HasColumnName<string>("Fecha_Tasa").HasMaxLength(18).IsFixedLength<string>();
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TPaTasaBancoCentral, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TPaTasaBancoCentral, Decimal?>>)(e => e.Rtasa)).HasColumnName<Decimal?>("RTasa").HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TPaTasaBancoCentral, Decimal?>>)(e => e.Tasa)).HasColumnType<Decimal?>("numeric(18, 4)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.TPaTasaReferencial>((Action<EntityTypeBuilder<AppService.Core.Entities.TPaTasaReferencial>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.TPaTasaReferencial>("T_Pa_Tasa_Referencial");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaTasaReferencial, DateTime?>>)(e => e.Fecha)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTasaReferencial, string>>)(e => e.FechaTasa)).HasColumnName<string>("Fecha_Tasa").HasMaxLength(18).IsFixedLength<string>();
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TPaTasaReferencial, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TPaTasaReferencial, Decimal?>>)(e => e.Rtasa)).HasColumnName<Decimal?>("RTasa").HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TPaTasaReferencial, Decimal?>>)(e => e.Tasa)).HasColumnType<Decimal?>("numeric(18, 4)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.TPaTipoCalculo>((Action<EntityTypeBuilder<AppService.Core.Entities.TPaTipoCalculo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TPaTipoCalculo, object>>)(e => (object)e.TipoCalculo));
                entity.ToTable<AppService.Core.Entities.TPaTipoCalculo>("T_Pa_TipoCalculo");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.TPaTipoCalculo, int>>)(e => e.TipoCalculo)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTipoCalculo, string>>)(e => e.Descripcion)).HasMaxLength(50);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaTipoCalculo, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaTipoCalculo, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TPaTipoCalculo, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTipoCalculo, string>>)(e => e.Promedio)).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTipoCalculo, string>>)(e => e.Reposicion)).HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTipoCalculo, string>>)(e => e.UsuarioCreacion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTipoCalculo, string>>)(e => e.UsuarioModifico)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.TPaTiposDeVariables>((Action<EntityTypeBuilder<AppService.Core.Entities.TPaTiposDeVariables>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, object>>)(e => (object)e.IdTipoVariable));
                entity.ToTable<AppService.Core.Entities.TPaTiposDeVariables>("T_Pa_TiposDeVariables");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, int>>)(e => e.IdTipoVariable)).ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, string>>)(e => e.Acumulador)).HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, string>>)(e => e.AcumuladorGeneral)).HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, string>>)(e => e.Busqueda)).HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, string>>)(e => e.Calculo)).HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, string>>)(e => e.Constante)).HasMaxLength(1).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, string>>)(e => e.Descripcion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, string>>)(e => e.Entrada)).HasMaxLength(1).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, string>>)(e => e.UsuarioCreacion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, string>>)(e => e.UsuarioModifico)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.TPaVariables>((Action<EntityTypeBuilder<AppService.Core.Entities.TPaVariables>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TPaVariables, object>>)(e => e.IdVariables));
                entity.ToTable<AppService.Core.Entities.TPaVariables>("T_Pa_Variables");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaVariables, string>>)(e => e.IdVariables)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaVariables, string>>)(e => e.AfectaCostoPororden)).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaVariables, string>>)(e => e.AfectaMc)).HasColumnName<string>("AfectaMC").HasMaxLength(1);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaVariables, DateTime?>>)(e => e.FechaCreacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TPaVariables, DateTime?>>)(e => e.FechaModificacion)).HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaVariables, string>>)(e => e.General)).HasMaxLength(1).IsFixedLength<string>();
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TPaVariables, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaVariables, string>>)(e => e.IgualEnCombinacion)).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaVariables, string>>)(e => e.NombreVariable)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaVariables, string>>)(e => e.TipoDato)).HasMaxLength(25);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaVariables, string>>)(e => e.UsuarioCreacion)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPaVariables, string>>)(e => e.UsuarioModifico)).HasMaxLength(50);
                entity.HasOne<AppService.Core.Entities.TPaTiposDeVariables>((Expression<Func<AppService.Core.Entities.TPaVariables, AppService.Core.Entities.TPaTiposDeVariables>>)(d => d.IdTipoVariableNavigation)).WithMany((Expression<Func<AppService.Core.Entities.TPaTiposDeVariables, IEnumerable<AppService.Core.Entities.TPaVariables>>>)(p => p.TPaVariables)).HasForeignKey((Expression<Func<AppService.Core.Entities.TPaVariables, object>>)(d => (object)d.IdTipoVariable)).HasConstraintName<AppService.Core.Entities.TPaTiposDeVariables, AppService.Core.Entities.TPaVariables>("FK_T_Pa_Variables_T_Pa_TiposDeVariables");
            }));
            modelBuilder.Entity<AppService.Core.Entities.TPrCalculo>((Action<EntityTypeBuilder<AppService.Core.Entities.TPrCalculo>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TPrCalculo, object>>)(e => new
                {
                    IdSolicitud = e.IdSolicitud,
                    LineaNegocio = e.LineaNegocio,
                    IdVariables = e.IdVariables,
                    Item = e.Item
                }));
                entity.ToTable<AppService.Core.Entities.TPrCalculo>("T_Pr_Calculo");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TPrCalculo, Decimal>>)(e => e.IdSolicitud)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPrCalculo, string>>)(e => e.IdVariables)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPrCalculo, string>>)(e => e.Calculo)).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPrCalculo, string>>)(e => e.DescripcionFormula)).HasMaxLength(4000);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPrCalculo, string>>)(e => e.Formula)).HasMaxLength(4000);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TPrCalculo, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPrCalculo, string>>)(e => e.Orden)).HasMaxLength(20);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TPrCalculo, Decimal?>>)(e => e.OrdenCalculo)).HasColumnType<Decimal?>("numeric(18, 1)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPrCalculo, string>>)(e => e.Producto)).HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TPrCalculo, string>>)(e => e.Qry)).HasMaxLength(4000);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TPrCalculo, Decimal?>>)(e => e.TiempoEjecucion)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TPrCalculo, Decimal?>>)(e => e.Valor)).HasColumnType<Decimal?>("numeric(18, 4)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.TSaCalculoHistorico>((Action<EntityTypeBuilder<AppService.Core.Entities.TSaCalculoHistorico>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, object>>)(e => new
                {
                    IdSolicitud = e.IdSolicitud,
                    LineaNegocio = e.LineaNegocio,
                    IdVariables = e.IdVariables,
                    Item = e.Item
                }));
                entity.ToTable<AppService.Core.Entities.TSaCalculoHistorico>("T_Sa_CalculoHistorico");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, Decimal>>)(e => e.IdSolicitud)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, string>>)(e => e.IdVariables)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, string>>)(e => e.DescripcionFormula)).HasMaxLength(4000);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, DateTime?>>)(e => e.FechaCalculo)).HasColumnType<DateTime?>("smalldatetime").HasDefaultValueSql<DateTime?>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, string>>)(e => e.Formula)).HasMaxLength(4000);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, string>>)(e => e.Orden)).HasMaxLength(20);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, Decimal?>>)(e => e.OrdenCalculo)).HasColumnType<Decimal?>("numeric(18, 1)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, string>>)(e => e.Producto)).HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, string>>)(e => e.Qry)).HasMaxLength(4000);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, Decimal?>>)(e => e.TiempoEjecucion)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TSaCalculoHistorico, Decimal?>>)(e => e.Valor)).HasColumnType<Decimal?>("numeric(18, 4)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.TSaEntradasHistorico>((Action<EntityTypeBuilder<AppService.Core.Entities.TSaEntradasHistorico>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TSaEntradasHistorico, object>>)(e => new
                {
                    IdSolicitud = e.IdSolicitud,
                    LineaNegocio = e.LineaNegocio,
                    IdVariables = e.IdVariables,
                    Item = e.Item
                }));
                entity.ToTable<AppService.Core.Entities.TSaEntradasHistorico>("T_Sa_EntradasHistorico");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TSaEntradasHistorico, Decimal>>)(e => e.IdSolicitud)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaEntradasHistorico, string>>)(e => e.IdVariables)).HasMaxLength(20);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TSaEntradasHistorico, DateTime?>>)(e => e.FechaCalculo)).HasColumnType<DateTime?>("smalldatetime").HasDefaultValueSql<DateTime?>("(getdate())");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaEntradasHistorico, string>>)(e => e.FuncionDeBusqueda)).HasMaxLength(500);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TSaEntradasHistorico, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaEntradasHistorico, string>>)(e => e.Orden)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaEntradasHistorico, string>>)(e => e.Producto)).HasMaxLength(12);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaEntradasHistorico, string>>)(e => e.Valor)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.TSaPlantillaReporteAnalisisCredito>((Action<EntityTypeBuilder<AppService.Core.Entities.TSaPlantillaReporteAnalisisCredito>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.TSaPlantillaReporteAnalisisCredito>("T_Sa_PlantillaReporteAnalisisCredito");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TSaPlantillaReporteAnalisisCredito, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaPlantillaReporteAnalisisCredito, string>>)(e => e.IdVariablePadre)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaPlantillaReporteAnalisisCredito, string>>)(e => e.Idvariables)).HasMaxLength(20);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TSaPlantillaReporteAnalisisCredito, Decimal?>>)(e => e.LineaReporte)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaPlantillaReporteAnalisisCredito, string>>)(e => e.NombreVariable)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaPlantillaReporteAnalisisCredito, string>>)(e => e.Titulo)).HasMaxLength(1);
            }));
            modelBuilder.Entity<AppService.Core.Entities.TSaReporteAnalisisCredito>((Action<EntityTypeBuilder<AppService.Core.Entities.TSaReporteAnalisisCredito>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.TSaReporteAnalisisCredito>("T_Sa_ReporteAnalisisCredito");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, object>>)(e => (object)e.IdSolicitud)).HasName<AppService.Core.Entities.TSaReporteAnalisisCredito>("IX_T_Sa_ReporteAnalisisCredito");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, object>>)(e => new
                {
                    IdSolicitud = e.IdSolicitud,
                    LineaReporte = e.LineaReporte
                })).HasName<AppService.Core.Entities.TSaReporteAnalisisCredito>("IX_T_Sa_ReporteAnalisisCredito_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, object>>)(e => new
                {
                    IdSolicitud = e.IdSolicitud,
                    IdvariablePadre = e.IdvariablePadre,
                    Idvariables = e.Idvariables
                })).HasName<AppService.Core.Entities.TSaReporteAnalisisCredito>("IX_T_Sa_ReporteAnalisisCredito_2");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, string>>)(e => e.Cotizacion)).HasMaxLength(13);
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, DateTime?>>)(e => e.FechaRegistro)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, Decimal>>)(e => e.Id)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, Decimal?>>)(e => e.IdSolicitud)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, string>>)(e => e.IdvariablePadre)).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, string>>)(e => e.Idvariables)).HasMaxLength(20);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, Decimal?>>)(e => e.LineaReporte)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, string>>)(e => e.NombreVariable)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, string>>)(e => e.Titulo)).HasMaxLength(1);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.TSaReporteAnalisisCredito, string>>)(e => e.Valor)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.TempRbfactura>((Action<EntityTypeBuilder<AppService.Core.Entities.TempRbfactura>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TempRbfactura, object>>)(e => (object)e.Recnum));
                entity.ToTable<AppService.Core.Entities.TempRbfactura>("TempRBFactura");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.TempRbfactura, object>>)(e => new
                {
                    DocRb = e.DocRb,
                    Factura = e.Factura
                })).HasName<AppService.Core.Entities.TempRbfactura>("IX_TempRBFactura").IsUnique(true);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TempRbfactura, Decimal>>)(e => e.Recnum)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
                entity.Property<long>((Expression<Func<AppService.Core.Entities.TempRbfactura, long>>)(e => e.DocRb)).HasColumnName<long>("DocRB");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.TempRbfactura, DateTime>>)(e => e.Fecha)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
            }));
            modelBuilder.Entity<AppService.Core.Entities.TempReciboCobro>((Action<EntityTypeBuilder<AppService.Core.Entities.TempReciboCobro>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.TempReciboCobro, object>>)(e => (object)e.Documento));
                entity.HasIndex((Expression<Func<AppService.Core.Entities.TempReciboCobro, object>>)(e => (object)e.Recnum)).HasName<AppService.Core.Entities.TempReciboCobro>("IX_TempReciboCobro").IsUnique(true);
                entity.Property<long>((Expression<Func<AppService.Core.Entities.TempReciboCobro, long>>)(e => e.Documento)).ValueGeneratedNever();
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.TempReciboCobro, DateTime>>)(e => e.FechaRegistro)).HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("(getdate())");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.TempReciboCobro, Decimal>>)(e => e.Recnum)).HasColumnType<Decimal>("numeric(18, 0)").ValueGeneratedOnAdd();
            }));
            modelBuilder.Entity<AppService.Core.Entities.Thumbnail>((Action<EntityTypeBuilder<AppService.Core.Entities.Thumbnail>>)(entity => entity.Property<string>((Expression<Func<AppService.Core.Entities.Thumbnail, string>>)(e => e.Fname)).HasColumnName<string>("fname").HasMaxLength((int)byte.MaxValue)));
            modelBuilder.Entity<AppService.Core.Entities.User>((Action<EntityTypeBuilder<AppService.Core.Entities.User>>)(entity =>
            {
                entity.HasIndex((Expression<Func<AppService.Core.Entities.User, object>>)(e => (object)e.CompanyId)).HasName<AppService.Core.Entities.User>("IX_CompanyId");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.User, object>>)(e => e.UserName)).HasName<AppService.Core.Entities.User>("User_UserName_Index").IsUnique(true);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.User, string>>)(e => e.Address)).IsRequired(true).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.User, string>>)(e => e.FirstName)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.User, string>>)(e => e.LastName)).IsRequired(true).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.User, string>>)(e => e.Message)).HasMaxLength(100);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.User, string>>)(e => e.Phone)).IsRequired(true).HasMaxLength(20);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.User, string>>)(e => e.UserName)).IsRequired(true).HasMaxLength(256);
                entity.HasOne<AppService.Core.Entities.Company>((Expression<Func<AppService.Core.Entities.User, AppService.Core.Entities.Company>>)(d => d.Company)).WithMany((Expression<Func<AppService.Core.Entities.Company, IEnumerable<AppService.Core.Entities.User>>>)(p => p.User)).HasForeignKey((Expression<Func<AppService.Core.Entities.User, object>>)(d => (object)d.CompanyId)).HasConstraintName<AppService.Core.Entities.Company, AppService.Core.Entities.User>("FK_dbo.User_dbo.Company_CompanyId");
            }));
            modelBuilder.Entity<AppService.Core.Entities.VRetencionesCobradas>((Action<EntityTypeBuilder<AppService.Core.Entities.VRetencionesCobradas>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToView<AppService.Core.Entities.VRetencionesCobradas>("V_RetencionesCobradas");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, Decimal?>>)(e => e.BsEmision)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, Decimal?>>)(e => e.Diferencia)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, string>>)(e => e.DocumentoSap)).HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, Decimal?>>)(e => e.DolaresComprobante)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, Decimal?>>)(e => e.DolaresContabilizacion)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, Decimal?>>)(e => e.DolaresFechaFactura)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, DateTime?>>)(e => e.FechaComprobante)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, DateTime?>>)(e => e.FechaContabilizacion)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, DateTime?>>)(e => e.FechaFactura)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, string>>)(e => e.NombreCliente)).HasMaxLength(200);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, string>>)(e => e.NroComprobante)).HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, string>>)(e => e.Oficina)).HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, Decimal?>>)(e => e.Porcentaje)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, string>>)(e => e.Region)).HasMaxLength(50);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, Decimal?>>)(e => e.TasaComprobante)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, Decimal?>>)(e => e.TasaContabilizacion)).HasColumnType<Decimal?>("numeric(18, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.VRetencionesCobradas, string>>)(e => e.Vendedor)).HasMaxLength(100);
            }));
            modelBuilder.Entity<AppService.Core.Entities.ValevenDataResumen>((Action<EntityTypeBuilder<AppService.Core.Entities.ValevenDataResumen>>)(entity =>
            {
                entity.HasNoKey();
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.ValevenDataResumen, DateTime>>)(e => e.FechaActualizacion)).HasColumnType<DateTime>("datetime");
            }));
            modelBuilder.Entity<AppService.Core.Entities.ValevenImpresiones>((Action<EntityTypeBuilder<AppService.Core.Entities.ValevenImpresiones>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.ValevenImpresiones, object>>)(e => e.Archivo));
                entity.Property<string>((Expression<Func<AppService.Core.Entities.ValevenImpresiones, string>>)(e => e.Archivo)).HasMaxLength(50);
            }));
            modelBuilder.Entity<AppService.Core.Entities.Wary074>((Action<EntityTypeBuilder<AppService.Core.Entities.Wary074>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.Wary074, object>>)(e => new
                {
                    TipoCompania = e.TipoCompania,
                    PlantaOficina = e.PlantaOficina,
                    Transaccion = e.Transaccion,
                    Documento = e.Documento,
                    Linea = e.Linea
                })).HasName("WARY074_INDEX01");
                entity.ToTable<AppService.Core.Entities.Wary074>("WARY074");
                entity.HasComment<AppService.Core.Entities.Wary074>("TRANSACCIONES PERMANENTE  CXC");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.Wary074, object>>)(e => (object)e.Batch)).HasName<AppService.Core.Entities.Wary074>("IX_WARY074_1");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.Wary074, object>>)(e => (object)e.Recnum)).HasName<AppService.Core.Entities.Wary074>("IX_WARY074_3").IsUnique(true);
                entity.HasIndex((Expression<Func<AppService.Core.Entities.Wary074, object>>)(e => new
                {
                    Batch = e.Batch,
                    DocCanc = e.DocCanc
                })).HasName<AppService.Core.Entities.Wary074>("IX_WARY074_2");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.Wary074, object>>)(e => new
                {
                    Cliente = e.Cliente,
                    Documento = e.Documento
                })).HasName<AppService.Core.Entities.Wary074>("IX_WARY074");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.TipoCompania)).HasColumnName<string>("TIPO_COMPANIA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Wary074, short>>)(e => e.PlantaOficina)).HasColumnName<short>("PLANTA_OFICINA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Transaccion)).HasColumnName<string>("TRANSACCION").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Wary074, int>>)(e => e.Documento)).HasColumnName<int>("DOCUMENTO");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Wary074, short>>)(e => e.Linea)).HasColumnName<short>("LINEA");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074, short?>>)(e => e.AO)).HasColumnName<short?>("A#O");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Afectanota)).HasColumnName<string>("AFECTANOTA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074, int?>>)(e => e.Anticipo)).HasColumnName<int?>("ANTICIPO");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074, short?>>)(e => e.AsigActual)).HasColumnName<short?>("ASIG_ACTUAL");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Banco)).HasColumnName<string>("BANCO").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.Wary074, double?>>)(e => e.Batch)).HasColumnName<double?>("batch");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.Cambio)).HasColumnName<Decimal?>("CAMBIO").HasColumnType<Decimal?>("decimal(12, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Ciudad)).IsRequired(true).HasColumnName<string>("CIUDAD").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Wary074, int>>)(e => e.Cliente)).HasColumnName<int>("CLIENTE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Cobrador)).IsRequired(true).HasColumnName<string>("COBRADOR").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.CodContrapart)).HasColumnName<string>("COD_CONTRAPART").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.ComisionPag)).HasColumnName<string>("COMISION_PAG").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Comisionpagada)).HasColumnName<string>("COMISIONPAGADA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074, short?>>)(e => e.CompLinea)).HasColumnName<short?>("COMP_LINEA");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074, short?>>)(e => e.Comprobante)).HasColumnName<short?>("COMPROBANTE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Concepto)).HasColumnName<string>("CONCEPTO").HasMaxLength(40).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074, short?>>)(e => e.CondPago)).HasColumnName<short?>("COND_PAGO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Contabilizado)).HasColumnName<string>("CONTABILIZADO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Cotizacion)).HasColumnName<string>("COTIZACION").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.CuentaEfecto)).HasColumnName<string>("CUENTA_EFECTO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Depura)).HasColumnName<string>("DEPURA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074, int?>>)(e => e.Dias)).HasColumnName<int?>("DIAS");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074, int?>>)(e => e.DiasEntrega)).HasColumnName<int?>("DIAS_ENTREGA");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Wary074, long?>>)(e => e.Diastransc)).HasColumnName<long?>("DIASTRANSC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Diferencial)).HasColumnName<string>("DIFERENCIAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Wary074, int>>)(e => e.DocCanc)).HasColumnName<int>("DOC_CANC");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.DocJde)).HasColumnName<Decimal?>("doc_jde").HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Efectivo)).HasColumnName<string>("EFECTIVO").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Eliminar)).HasColumnName<string>("ELIMINAR").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074, short?>>)(e => e.Estacion)).HasColumnName<short?>("ESTACION").HasDefaultValueSql<short?>("((1))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Estado)).IsRequired(true).HasColumnName<string>("ESTADO").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074, DateTime?>>)(e => e.FechaCobro)).HasColumnName<DateTime?>("FECHA_COBRO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074, DateTime?>>)(e => e.FechaCreacion)).HasColumnName<DateTime?>("FECHA_CREACION").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Wary074, DateTime>>)(e => e.FechaEmision)).HasColumnName<DateTime>("FECHA_EMISION").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Wary074, DateTime>>)(e => e.FechaEntrega)).HasColumnName<DateTime>("FECHA_ENTREGA").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Wary074, DateTime>>)(e => e.FechaIngreso)).HasColumnName<DateTime>("FECHA_INGRESO").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074, DateTime?>>)(e => e.FechaPlanilla)).HasColumnName<DateTime?>("FECHA_PLANILLA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074, DateTime?>>)(e => e.FechaUsuario)).HasColumnName<DateTime?>("FECHA_USUARIO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074, DateTime?>>)(e => e.FechaVcto)).HasColumnName<DateTime?>("FECHA_VCTO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074, DateTime?>>)(e => e.Fechadoccanc)).HasColumnName<DateTime?>("FECHADOCCANC").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074, DateTime?>>)(e => e.FecrecibPl)).HasColumnName<DateTime?>("FECRECIB_PL").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Grupo)).HasColumnName<string>("GRUPO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.GrupoActual)).HasColumnName<string>("GRUPO_ACTUAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.HoraCreacion)).HasColumnName<string>("HORA_CREACION").HasMaxLength(20).IsUnicode(false);
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074, short?>>)(e => e.HoraUsario)).HasColumnName<short?>("HORA_USARIO");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074, int?>>)(e => e.InformeQueja)).HasColumnName<int?>("INFORME_QUEJA");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074, short?>>)(e => e.LinCanc)).HasColumnName<short?>("LIN_CANC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Lote)).HasColumnName<string>("LOTE").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Matriz)).HasColumnName<string>("MATRIZ").HasMaxLength(8).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074, short?>>)(e => e.Mes)).HasColumnName<short?>("MES");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074, short?>>)(e => e.MinutosUsuario)).HasColumnName<short?>("MINUTOS_USUARIO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Moneda)).HasColumnName<string>("MONEDA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.Monto)).HasColumnName<Decimal?>("MONTO").HasColumnType<Decimal?>("decimal(12, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.MontoDolar)).HasColumnName<Decimal?>("MONTO_DOLAR").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.MontoMoneda)).HasColumnName<Decimal?>("MONTO_MONEDA").HasColumnType<Decimal?>("decimal(10, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.NoTieneDebe)).HasColumnName<string>("NO_TIENE_DEBE").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Nombre)).HasColumnName<string>("NOMBRE").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.NroPlanilla)).HasColumnName<string>("NRO_PLANILLA").HasMaxLength(25).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Nrocheque)).HasColumnName<string>("NROCHEQUE").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Wary074, long?>>)(e => e.NumeroPl)).HasColumnName<long?>("NUMERO_PL").HasDefaultValueSql<long?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Observacion1)).HasColumnName<string>("OBSERVACION1").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Observacion2)).HasColumnName<string>("OBSERVACION2").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Wary074, long?>>)(e => e.Orden)).HasColumnName<long?>("ORDEN");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.PasoJde)).HasColumnName<string>("paso_jde").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.PasoSql)).IsRequired(true).HasColumnName<string>("PASO_SQL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.PorIva)).HasColumnName<Decimal?>("POR_IVA").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.Porcret)).HasColumnName<Decimal?>("PORCRET").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Recalcular)).HasColumnName<string>("RECALCULAR").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.RecibidaPl)).HasColumnName<string>("RECIBIDA_PL").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary074, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074, int?>>)(e => e.Referencia)).HasColumnName<int?>("REFERENCIA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Region)).HasColumnName<string>("REGION").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.RegionActual)).IsRequired(true).HasColumnName<string>("REGION_ACTUAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074, int?>>)(e => e.RelacionCobro)).HasColumnName<int?>("RELACION_COBRO");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074, int?>>)(e => e.Remisionma)).HasColumnName<int?>("REMISIONMA");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074, int?>>)(e => e.Remisionsi)).HasColumnName<int?>("REMISIONSI");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.Rmonto)).HasColumnName<Decimal?>("RMONTO").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.Rsaldo)).HasColumnName<Decimal?>("RSALDO").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Rzvre)).HasColumnName<string>("RZVRE").HasMaxLength(10);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.Saldo)).HasColumnName<Decimal?>("SALDO").HasColumnType<Decimal?>("decimal(12, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.SaldoDolar)).HasColumnName<Decimal?>("SALDO_DOLAR").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Status)).HasColumnName<string>("STATUS").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Supervisor)).HasColumnName<string>("SUPERVISOR").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074, Decimal?>>)(e => e.TasaCambio)).HasColumnName<Decimal?>("TASA_CAMBIO").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Tipo)).IsRequired(true).HasColumnName<string>("TIPO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.TipoCanc)).IsRequired(true).HasColumnName<string>("TIPO_CANC").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.TipoCiudad)).HasColumnName<string>("TIPO_CIUDAD").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Transferencia)).HasColumnName<string>("TRANSFERENCIA").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074, DateTime?>>)(e => e.UltimoPago)).HasColumnName<DateTime?>("ULTIMO_PAGO").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Usuario)).HasColumnName<string>("USUARIO").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074, short?>>)(e => e.VecesCobro)).HasColumnName<short?>("VECES_COBRO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Vendedor)).HasColumnName<string>("VENDEDOR").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074, string>>)(e => e.Zona)).HasColumnName<string>("ZONA").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
            }));
            modelBuilder.Entity<AppService.Core.Entities.Wary074temp>((Action<EntityTypeBuilder<AppService.Core.Entities.Wary074temp>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.Wary074temp>("WARY074Temp");
                entity.HasComment<AppService.Core.Entities.Wary074temp>("TRANSACCIONES PERMANENTE  CXC");
                entity.HasIndex((Expression<Func<AppService.Core.Entities.Wary074temp, object>>)(e => (object)e.Recnum)).HasName<AppService.Core.Entities.Wary074temp>("IX_WARY074Temp_3").IsUnique(true);
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074temp, short?>>)(e => e.AO)).HasColumnName<short?>("A#O");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Afectanota)).HasColumnName<string>("AFECTANOTA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074temp, int?>>)(e => e.Anticipo)).HasColumnName<int?>("ANTICIPO");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074temp, short?>>)(e => e.AsigActual)).HasColumnName<short?>("ASIG_ACTUAL");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Banco)).HasColumnName<string>("BANCO").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.Wary074temp, double?>>)(e => e.Batch)).HasColumnName<double?>("batch");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.Cambio)).HasColumnName<Decimal?>("CAMBIO").HasColumnType<Decimal?>("decimal(12, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Ciudad)).IsRequired(true).HasColumnName<string>("CIUDAD").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Wary074temp, int>>)(e => e.Cliente)).HasColumnName<int>("CLIENTE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Cobrador)).IsRequired(true).HasColumnName<string>("COBRADOR").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.CodContrapart)).HasColumnName<string>("COD_CONTRAPART").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.ComisionPag)).HasColumnName<string>("COMISION_PAG").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Comisionpagada)).HasColumnName<string>("COMISIONPAGADA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074temp, short?>>)(e => e.CompLinea)).HasColumnName<short?>("COMP_LINEA");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074temp, short?>>)(e => e.Comprobante)).HasColumnName<short?>("COMPROBANTE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Concepto)).HasColumnName<string>("CONCEPTO").HasMaxLength(40).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074temp, short?>>)(e => e.CondPago)).HasColumnName<short?>("COND_PAGO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Contabilizado)).HasColumnName<string>("CONTABILIZADO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Cotizacion)).HasColumnName<string>("COTIZACION").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.CuentaEfecto)).HasColumnName<string>("CUENTA_EFECTO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Depura)).HasColumnName<string>("DEPURA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074temp, int?>>)(e => e.Dias)).HasColumnName<int?>("DIAS");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074temp, int?>>)(e => e.DiasEntrega)).HasColumnName<int?>("DIAS_ENTREGA");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Wary074temp, long?>>)(e => e.Diastransc)).HasColumnName<long?>("DIASTRANSC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Diferencial)).HasColumnName<string>("DIFERENCIAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Wary074temp, int>>)(e => e.DocCanc)).HasColumnName<int>("DOC_CANC");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.DocJde)).HasColumnName<Decimal?>("doc_jde").HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Wary074temp, int>>)(e => e.Documento)).HasColumnName<int>("DOCUMENTO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Efectivo)).HasColumnName<string>("EFECTIVO").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Eliminar)).HasColumnName<string>("ELIMINAR").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074temp, short?>>)(e => e.Estacion)).HasColumnName<short?>("ESTACION").HasDefaultValueSql<short?>("((1))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Estado)).IsRequired(true).HasColumnName<string>("ESTADO").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074temp, DateTime?>>)(e => e.FechaCobro)).HasColumnName<DateTime?>("FECHA_COBRO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074temp, DateTime?>>)(e => e.FechaCreacion)).HasColumnName<DateTime?>("FECHA_CREACION").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Wary074temp, DateTime>>)(e => e.FechaEmision)).HasColumnName<DateTime>("FECHA_EMISION").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Wary074temp, DateTime>>)(e => e.FechaEntrega)).HasColumnName<DateTime>("FECHA_ENTREGA").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Wary074temp, DateTime>>)(e => e.FechaIngreso)).HasColumnName<DateTime>("FECHA_INGRESO").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074temp, DateTime?>>)(e => e.FechaPlanilla)).HasColumnName<DateTime?>("FECHA_PLANILLA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074temp, DateTime?>>)(e => e.FechaUsuario)).HasColumnName<DateTime?>("FECHA_USUARIO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074temp, DateTime?>>)(e => e.FechaVcto)).HasColumnName<DateTime?>("FECHA_VCTO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074temp, DateTime?>>)(e => e.Fechadoccanc)).HasColumnName<DateTime?>("FECHADOCCANC").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074temp, DateTime?>>)(e => e.FecrecibPl)).HasColumnName<DateTime?>("FECRECIB_PL").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Grupo)).HasColumnName<string>("GRUPO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.GrupoActual)).HasColumnName<string>("GRUPO_ACTUAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.HoraCreacion)).HasColumnName<string>("HORA_CREACION").HasMaxLength(20).IsUnicode(false);
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074temp, short?>>)(e => e.HoraUsario)).HasColumnName<short?>("HORA_USARIO");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074temp, int?>>)(e => e.InformeQueja)).HasColumnName<int?>("INFORME_QUEJA");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074temp, short?>>)(e => e.LinCanc)).HasColumnName<short?>("LIN_CANC");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Wary074temp, short>>)(e => e.Linea)).HasColumnName<short>("LINEA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Lote)).HasColumnName<string>("LOTE").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Matriz)).HasColumnName<string>("MATRIZ").HasMaxLength(8).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074temp, short?>>)(e => e.Mes)).HasColumnName<short?>("MES");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074temp, short?>>)(e => e.MinutosUsuario)).HasColumnName<short?>("MINUTOS_USUARIO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Moneda)).HasColumnName<string>("MONEDA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.Monto)).HasColumnName<Decimal?>("MONTO").HasColumnType<Decimal?>("decimal(12, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.MontoDolar)).HasColumnName<Decimal?>("MONTO_DOLAR").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.MontoMoneda)).HasColumnName<Decimal?>("MONTO_MONEDA").HasColumnType<Decimal?>("decimal(10, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.NoTieneDebe)).HasColumnName<string>("NO_TIENE_DEBE").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Nombre)).HasColumnName<string>("NOMBRE").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.NroPlanilla)).HasColumnName<string>("NRO_PLANILLA").HasMaxLength(25).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Nrocheque)).HasColumnName<string>("NROCHEQUE").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Wary074temp, long?>>)(e => e.NumeroPl)).HasColumnName<long?>("NUMERO_PL").HasDefaultValueSql<long?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Observacion1)).HasColumnName<string>("OBSERVACION1").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Observacion2)).HasColumnName<string>("OBSERVACION2").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Wary074temp, long?>>)(e => e.Orden)).HasColumnName<long?>("ORDEN");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.PasoJde)).HasColumnName<string>("paso_jde").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.PasoSql)).IsRequired(true).HasColumnName<string>("PASO_SQL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Wary074temp, short>>)(e => e.PlantaOficina)).HasColumnName<short>("PLANTA_OFICINA");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.PorIva)).HasColumnName<Decimal?>("POR_IVA").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.Porcret)).HasColumnName<Decimal?>("PORCRET").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Recalcular)).HasColumnName<string>("RECALCULAR").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.RecibidaPl)).HasColumnName<string>("RECIBIDA_PL").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("('')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)").ValueGeneratedOnAdd();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074temp, int?>>)(e => e.Referencia)).HasColumnName<int?>("REFERENCIA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Region)).HasColumnName<string>("REGION").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.RegionActual)).IsRequired(true).HasColumnName<string>("REGION_ACTUAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074temp, int?>>)(e => e.RelacionCobro)).HasColumnName<int?>("RELACION_COBRO");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074temp, int?>>)(e => e.Remisionma)).HasColumnName<int?>("REMISIONMA");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074temp, int?>>)(e => e.Remisionsi)).HasColumnName<int?>("REMISIONSI");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.Rmonto)).HasColumnName<Decimal?>("RMONTO").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.Rsaldo)).HasColumnName<Decimal?>("RSALDO").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Rzvre)).HasColumnName<string>("RZVRE").HasMaxLength(10);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.Saldo)).HasColumnName<Decimal?>("SALDO").HasColumnType<Decimal?>("decimal(12, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.SaldoDolar)).HasColumnName<Decimal?>("SALDO_DOLAR").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Status)).HasColumnName<string>("STATUS").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Supervisor)).HasColumnName<string>("SUPERVISOR").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074temp, Decimal?>>)(e => e.TasaCambio)).HasColumnName<Decimal?>("TASA_CAMBIO").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Tipo)).IsRequired(true).HasColumnName<string>("TIPO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.TipoCanc)).IsRequired(true).HasColumnName<string>("TIPO_CANC").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.TipoCiudad)).HasColumnName<string>("TIPO_CIUDAD").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.TipoCompania)).IsRequired(true).HasColumnName<string>("TIPO_COMPANIA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Transaccion)).IsRequired(true).HasColumnName<string>("TRANSACCION").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>().HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Transferencia)).HasColumnName<string>("TRANSFERENCIA").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074temp, DateTime?>>)(e => e.UltimoPago)).HasColumnName<DateTime?>("ULTIMO_PAGO").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Usuario)).HasColumnName<string>("USUARIO").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074temp, short?>>)(e => e.VecesCobro)).HasColumnName<short?>("VECES_COBRO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Vendedor)).HasColumnName<string>("VENDEDOR").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074temp, string>>)(e => e.Zona)).HasColumnName<string>("ZONA").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
            }));
            modelBuilder.Entity<AppService.Core.Entities.Wary074tempReconstruir>((Action<EntityTypeBuilder<AppService.Core.Entities.Wary074tempReconstruir>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.Wary074tempReconstruir>("WARY074TempReconstruir");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short?>>)(e => e.AO)).HasColumnName<short?>("A#O");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Afectanota)).HasColumnName<string>("AFECTANOTA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, int?>>)(e => e.Anticipo)).HasColumnName<int?>("ANTICIPO");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short?>>)(e => e.AsigActual)).HasColumnName<short?>("ASIG_ACTUAL");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Banco)).HasColumnName<string>("BANCO").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<double?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, double?>>)(e => e.Batch)).HasColumnName<double?>("batch");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.Cambio)).HasColumnName<Decimal?>("CAMBIO").HasColumnType<Decimal?>("decimal(12, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Ciudad)).IsRequired(true).HasColumnName<string>("CIUDAD").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, int>>)(e => e.Cliente)).HasColumnName<int>("CLIENTE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Cobrador)).IsRequired(true).HasColumnName<string>("COBRADOR").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.CodContrapart)).HasColumnName<string>("COD_CONTRAPART").HasMaxLength(50);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.ComisionPag)).HasColumnName<string>("COMISION_PAG").HasMaxLength(1).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Comisionpagada)).HasColumnName<string>("COMISIONPAGADA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short?>>)(e => e.CompLinea)).HasColumnName<short?>("COMP_LINEA");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short?>>)(e => e.Comprobante)).HasColumnName<short?>("COMPROBANTE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Concepto)).HasColumnName<string>("CONCEPTO").HasMaxLength(40).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short?>>)(e => e.CondPago)).HasColumnName<short?>("COND_PAGO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Contabilizado)).HasColumnName<string>("CONTABILIZADO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Cotizacion)).HasColumnName<string>("COTIZACION").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.CuentaEfecto)).HasColumnName<string>("CUENTA_EFECTO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Depura)).HasColumnName<string>("DEPURA").HasMaxLength(1).IsUnicode(false);
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, int?>>)(e => e.Dias)).HasColumnName<int?>("DIAS");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, int?>>)(e => e.DiasEntrega)).HasColumnName<int?>("DIAS_ENTREGA");
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, long?>>)(e => e.Diastransc)).HasColumnName<long?>("DIASTRANSC");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Diferencial)).HasColumnName<string>("DIFERENCIAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, int>>)(e => e.DocCanc)).HasColumnName<int>("DOC_CANC");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.DocJde)).HasColumnName<Decimal?>("doc_jde").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, int>>)(e => e.Documento)).HasColumnName<int>("DOCUMENTO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Efectivo)).HasColumnName<string>("EFECTIVO").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Eliminar)).HasColumnName<string>("ELIMINAR").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short?>>)(e => e.Estacion)).HasColumnName<short?>("ESTACION");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Estado)).IsRequired(true).HasColumnName<string>("ESTADO").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, DateTime?>>)(e => e.FechaCobro)).HasColumnName<DateTime?>("FECHA_COBRO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, DateTime?>>)(e => e.FechaCreacion)).HasColumnName<DateTime?>("FECHA_CREACION").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, DateTime>>)(e => e.FechaEmision)).HasColumnName<DateTime>("FECHA_EMISION").HasColumnType<DateTime>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, DateTime>>)(e => e.FechaEntrega)).HasColumnName<DateTime>("FECHA_ENTREGA").HasColumnType<DateTime>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, DateTime>>)(e => e.FechaIngreso)).HasColumnName<DateTime>("FECHA_INGRESO").HasColumnType<DateTime>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, DateTime?>>)(e => e.FechaPlanilla)).HasColumnName<DateTime?>("FECHA_PLANILLA").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, DateTime?>>)(e => e.FechaUsuario)).HasColumnName<DateTime?>("FECHA_USUARIO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, DateTime?>>)(e => e.FechaVcto)).HasColumnName<DateTime?>("FECHA_VCTO").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, DateTime?>>)(e => e.Fechadoccanc)).HasColumnName<DateTime?>("FECHADOCCANC").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, DateTime?>>)(e => e.FecrecibPl)).HasColumnName<DateTime?>("FECRECIB_PL").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Grupo)).HasColumnName<string>("GRUPO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.GrupoActual)).HasColumnName<string>("GRUPO_ACTUAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.HoraCreacion)).HasColumnName<string>("HORA_CREACION").HasMaxLength(20).IsUnicode(false);
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short?>>)(e => e.HoraUsario)).HasColumnName<short?>("HORA_USARIO");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, int?>>)(e => e.InformeQueja)).HasColumnName<int?>("INFORME_QUEJA");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short?>>)(e => e.LinCanc)).HasColumnName<short?>("LIN_CANC");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short>>)(e => e.Linea)).HasColumnName<short>("LINEA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Lote)).HasColumnName<string>("LOTE").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Matriz)).HasColumnName<string>("MATRIZ").HasMaxLength(8).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short?>>)(e => e.Mes)).HasColumnName<short?>("MES");
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short?>>)(e => e.MinutosUsuario)).HasColumnName<short?>("MINUTOS_USUARIO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Moneda)).HasColumnName<string>("MONEDA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.Monto)).HasColumnName<Decimal?>("MONTO").HasColumnType<Decimal?>("decimal(12, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.MontoDolar)).HasColumnName<Decimal?>("MONTO_DOLAR").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.MontoMoneda)).HasColumnName<Decimal?>("MONTO_MONEDA").HasColumnType<Decimal?>("decimal(10, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.NoTieneDebe)).HasColumnName<string>("NO_TIENE_DEBE").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Nombre)).HasColumnName<string>("NOMBRE").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.NroPlanilla)).HasColumnName<string>("NRO_PLANILLA").HasMaxLength(25).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Nrocheque)).HasColumnName<string>("NROCHEQUE").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, long?>>)(e => e.NumeroPl)).HasColumnName<long?>("NUMERO_PL");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Observacion1)).HasColumnName<string>("OBSERVACION1").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Observacion2)).HasColumnName<string>("OBSERVACION2").HasMaxLength(80).IsUnicode(false).IsFixedLength<string>();
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, long?>>)(e => e.Orden)).HasColumnName<long?>("ORDEN");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.PasoJde)).HasColumnName<string>("paso_jde").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.PasoSql)).IsRequired(true).HasColumnName<string>("PASO_SQL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short>>)(e => e.PlantaOficina)).HasColumnName<short>("PLANTA_OFICINA");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.PorIva)).HasColumnName<Decimal?>("POR_IVA").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.Porcret)).HasColumnName<Decimal?>("PORCRET").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Recalcular)).HasColumnName<string>("RECALCULAR").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.RecibidaPl)).HasColumnName<string>("RECIBIDA_PL").HasMaxLength(1).IsUnicode(false);
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, int?>>)(e => e.Referencia)).HasColumnName<int?>("REFERENCIA");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Region)).HasColumnName<string>("REGION").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.RegionActual)).IsRequired(true).HasColumnName<string>("REGION_ACTUAL").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, int?>>)(e => e.RelacionCobro)).HasColumnName<int?>("RELACION_COBRO");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, int?>>)(e => e.Remisionma)).HasColumnName<int?>("REMISIONMA");
                entity.Property<int?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, int?>>)(e => e.Remisionsi)).HasColumnName<int?>("REMISIONSI");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.Rmonto)).HasColumnName<Decimal?>("RMONTO").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.Rsaldo)).HasColumnName<Decimal?>("RSALDO").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Rzvre)).HasColumnName<string>("RZVRE").HasMaxLength(10);
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.Saldo)).HasColumnName<Decimal?>("SALDO").HasColumnType<Decimal?>("decimal(12, 2)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.SaldoDolar)).HasColumnName<Decimal?>("SALDO_DOLAR").HasColumnType<Decimal?>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Status)).HasColumnName<string>("STATUS").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Supervisor)).HasColumnName<string>("SUPERVISOR").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, Decimal?>>)(e => e.TasaCambio)).HasColumnName<Decimal?>("TASA_CAMBIO").HasColumnType<Decimal?>("decimal(6, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Tipo)).IsRequired(true).HasColumnName<string>("TIPO").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.TipoCanc)).IsRequired(true).HasColumnName<string>("TIPO_CANC").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.TipoCiudad)).HasColumnName<string>("TIPO_CIUDAD").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.TipoCompania)).IsRequired(true).HasColumnName<string>("TIPO_COMPANIA").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Transaccion)).IsRequired(true).HasColumnName<string>("TRANSACCION").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Transferencia)).HasColumnName<string>("TRANSFERENCIA").HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, DateTime?>>)(e => e.UltimoPago)).HasColumnName<DateTime?>("ULTIMO_PAGO").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Usuario)).HasColumnName<string>("USUARIO").HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<short?>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, short?>>)(e => e.VecesCobro)).HasColumnName<short?>("VECES_COBRO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Vendedor)).HasColumnName<string>("VENDEDOR").HasMaxLength(4).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary074tempReconstruir, string>>)(e => e.Zona)).HasColumnName<string>("ZONA").HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
            }));
            modelBuilder.Entity<AppService.Core.Entities.Wary182>((Action<EntityTypeBuilder<AppService.Core.Entities.Wary182>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.Wary182, object>>)(e => (object)e.Nota)).HasName("WARY182_INDEX01");
                entity.ToTable<AppService.Core.Entities.Wary182>("WARY182");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Wary182, int>>)(e => e.Nota)).HasColumnName<int>("NOTA").ValueGeneratedNever();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.Anulada)).IsRequired(true).HasColumnName<string>("ANULADA").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.Banco)).IsRequired(true).HasColumnName<string>("BANCO").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary182, Decimal?>>)(e => e.Batch)).HasColumnName<Decimal?>("BATCH").HasColumnType<Decimal?>("numeric(18, 0)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary182, Decimal>>)(e => e.Cambio)).HasColumnName<Decimal>("CAMBIO").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary182, Decimal>>)(e => e.Cantidad)).HasColumnName<Decimal>("CANTIDAD").HasColumnType<Decimal>("decimal(12, 2)");
                entity.Property<int>((Expression<Func<AppService.Core.Entities.Wary182, int>>)(e => e.Cliente)).HasColumnName<int>("CLIENTE");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.Cobrador)).IsRequired(true).HasColumnName<string>("COBRADOR").HasMaxLength(4).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary182, Decimal?>>)(e => e.CodJdepadre)).HasColumnName<Decimal?>("COD_JDEPADRE").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.Contrapartida)).IsRequired(true).HasColumnName<string>("CONTRAPARTIDA").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.DatosCliente)).HasColumnName<string>("DATOS_CLIENTE").HasColumnType<string>("text");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.DireccionFact1)).IsRequired(true).HasColumnName<string>("DIRECCION_FACT1").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.DireccionFact2)).IsRequired(true).HasColumnName<string>("DIRECCION_FACT2").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.DireccionFact3)).IsRequired(true).HasColumnName<string>("DIRECCION_FACT3").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary182, DateTime?>>)(e => e.FechaEmision)).HasColumnName<DateTime?>("FECHA_EMISION").HasColumnType<DateTime?>("datetime");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Wary182, DateTime>>)(e => e.FechaIngreso)).HasColumnName<DateTime>("FECHA_INGRESO").HasColumnType<DateTime>("datetime").HasDefaultValueSql<DateTime>("('01/01/1753')");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary182, DateTime?>>)(e => e.FechaVenc)).HasColumnName<DateTime?>("FECHA_VENC").HasColumnType<DateTime?>("datetime");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.FlagImpreso)).IsRequired(true).HasColumnName<string>("FLAG_IMPRESO").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary182, Decimal>>)(e => e.Iva)).HasColumnName<Decimal>("IVA").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary182, Decimal>>)(e => e.Ivad)).HasColumnName<Decimal>("IVAD").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary182, Decimal>>)(e => e.Ivaporc)).HasColumnName<Decimal>("IVAPORC").HasColumnType<Decimal>("decimal(6, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.NitFact)).IsRequired(true).HasColumnName<string>("NIT_FACT").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.NombreFact)).IsRequired(true).HasColumnName<string>("NOMBRE_FACT").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Wary182, long>>)(e => e.NroControl)).HasColumnName<long>("NRO_CONTROL");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.Observacion1)).IsRequired(true).HasColumnName<string>("OBSERVACION1").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.Observacion2)).IsRequired(true).HasColumnName<string>("OBSERVACION2").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.Observacion3)).IsRequired(true).HasColumnName<string>("OBSERVACION3").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.Observacion4)).IsRequired(true).HasColumnName<string>("OBSERVACION4").HasMaxLength(80).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<long>((Expression<Func<AppService.Core.Entities.Wary182, long>>)(e => e.Orden)).HasColumnName<long>("ORDEN");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary182, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.Region)).IsRequired(true).HasColumnName<string>("REGION").HasMaxLength(1).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.RifFact)).IsRequired(true).HasColumnName<string>("RIF_FACT").HasMaxLength(12).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary182, Decimal?>>)(e => e.Riva)).HasColumnName<Decimal?>("RIVA").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary182, Decimal?>>)(e => e.Rsubtotal)).HasColumnName<Decimal?>("RSUBTOTAL").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary182, Decimal?>>)(e => e.Rtotal)).HasColumnName<Decimal?>("RTOTAL").HasColumnType<Decimal?>("decimal(16, 2)").HasDefaultValueSql<Decimal?>("((0))");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary182, Decimal>>)(e => e.Subtotal)).HasColumnName<Decimal>("SUBTOTAL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary182, Decimal>>)(e => e.Subtotald)).HasColumnName<Decimal>("SUBTOTALD").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary182, Decimal>>)(e => e.Total)).HasColumnName<Decimal>("TOTAL").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary182, Decimal>>)(e => e.Totald)).HasColumnName<Decimal>("TOTALD").HasColumnType<Decimal>("decimal(16, 2)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wary182, string>>)(e => e.Transaccion)).IsRequired(true).HasColumnName<string>("TRANSACCION").HasMaxLength(2).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
            }));
            modelBuilder.Entity<AppService.Core.Entities.Wary241>((Action<EntityTypeBuilder<AppService.Core.Entities.Wary241>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.Wary241>("WARY241");
                entity.Property<DateTime>((Expression<Func<AppService.Core.Entities.Wary241, DateTime>>)(e => e.Fecha)).HasColumnName<DateTime>("FECHA").HasColumnType<DateTime>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wary241, DateTime?>>)(e => e.FechaUpdate)).HasColumnName<DateTime?>("FECHA_UPDATE").HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wary241, Decimal?>>)(e => e.RutBs)).HasColumnName<Decimal?>("RUT_BS").HasColumnType<Decimal?>("decimal(18, 3)");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wary241, Decimal>>)(e => e.UtBs)).HasColumnName<Decimal>("UT_BS").HasColumnType<Decimal>("decimal(18, 3)");
            }));
            modelBuilder.Entity<AppService.Core.Entities.Wivy003>((Action<EntityTypeBuilder<AppService.Core.Entities.Wivy003>>)(entity =>
            {
                entity.HasKey((Expression<Func<AppService.Core.Entities.Wivy003, object>>)(e => (object)e.Recnum));
                entity.ToTable<AppService.Core.Entities.Wivy003>("WIVY003");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wivy003, Decimal>>)(e => e.Recnum)).HasColumnName<Decimal>("RECNUM").HasColumnType<Decimal>("decimal(28, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wivy003, string>>)(e => e.AprobCredM)).HasColumnName<string>("APROB_CRED_M").HasMaxLength(1).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wivy003, string>>)(e => e.CodJde)).HasColumnName<string>("COD_JDE").HasMaxLength(3).IsFixedLength<string>();
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Wivy003, short>>)(e => e.Codigo)).HasColumnName<short>("CODIGO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wivy003, string>>)(e => e.Descripcion)).IsRequired(true).HasColumnName<string>("DESCRIPCION").HasMaxLength(50).IsUnicode(false).HasDefaultValueSql<string>("(' ')");
                entity.Property<short>((Expression<Func<AppService.Core.Entities.Wivy003, short>>)(e => e.DiasVcto)).HasColumnName<short>("DIAS_VCTO");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wivy003, string>>)(e => e.Inactivo)).HasColumnName<string>("inactivo").HasMaxLength(1).IsFixedLength<string>().HasDefaultValueSql<string>("('')");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wivy003, Decimal?>>)(e => e.PorcRequerido)).HasColumnType<Decimal?>("numeric(18, 4)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wivy003, string>>)(e => e.RequiereLimiteCredito)).HasMaxLength(1).IsFixedLength<string>();
            }));
            modelBuilder.Entity<AppService.Core.Entities.Wsmy469>((Action<EntityTypeBuilder<AppService.Core.Entities.Wsmy469>>)(entity =>
            {
                entity.HasNoKey();
                entity.ToTable<AppService.Core.Entities.Wsmy469>("WSMY469");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.Cotizacion)).HasMaxLength(20).IsUnicode(false).IsFixedLength<string>();
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wsmy469, DateTime?>>)(e => e.Fecha)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wsmy469, DateTime?>>)(e => e.FechaHoraAgrega)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<DateTime?>((Expression<Func<AppService.Core.Entities.Wsmy469, DateTime?>>)(e => e.FechaHoraModifica)).HasColumnType<DateTime?>("smalldatetime");
                entity.Property<Decimal>((Expression<Func<AppService.Core.Entities.Wsmy469, Decimal>>)(e => e.Id)).HasColumnName<Decimal>("ID").HasColumnType<Decimal>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wsmy469, Decimal?>>)(e => e.IdDireccionEntregar)).HasColumnName<Decimal?>("Id_direccionEntregar").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wsmy469, Decimal?>>)(e => e.IdDireccionFacturar)).HasColumnName<Decimal?>("Id_direccionFacturar").HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<Decimal?>((Expression<Func<AppService.Core.Entities.Wsmy469, Decimal?>>)(e => e.LongitudMascara)).HasColumnType<Decimal?>("numeric(18, 0)");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.NumeroControlDesde)).IsRequired(true).HasMaxLength(8).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.NumeroControlHasta)).IsRequired(true).HasMaxLength(8).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.NumeroFormatoDesde)).HasMaxLength(8).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.NumeroFormatoHasta)).HasMaxLength(8).IsUnicode(false).IsFixedLength<string>();
                entity.Property<long?>((Expression<Func<AppService.Core.Entities.Wsmy469, long?>>)(e => e.NumeroSdf)).HasColumnName<long?>("NumeroSDF");
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.NumeroSerieControlDesde)).HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.NumeroSerieControlHasta)).HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.NumeroSerieFormatoDesde)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.NumeroSerieFormatoHasta)).HasMaxLength(10).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.Producto)).HasMaxLength(50).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.Rif)).HasMaxLength(12).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.TipoDocumento)).HasMaxLength(2).IsUnicode(false).IsFixedLength<string>();
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.UsuarioAgrega)).HasMaxLength(40).IsUnicode(false);
                entity.Property<string>((Expression<Func<AppService.Core.Entities.Wsmy469, string>>)(e => e.UsuarioModifica)).HasMaxLength(40).IsUnicode(false);
            }));
        }
    }
}
