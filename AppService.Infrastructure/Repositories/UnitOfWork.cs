using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using AppService.Infrastructure.DataClientes;
using AppService.Infrastructure.DataContratosStock;
using AppService.Infrastructure.DataDW;
using AppService.Infrastructure.DataFacturacion;
using AppService.Infrastructure.DataMaestros;
using AppService.Infrastructure.DataMateriales;
using AppService.Infrastructure.DataMc;

using AppService.Infrastructure.DataMooreve;
using AppService.Infrastructure.DataNomina;
using AppService.Infrastructure.DataPlanta;
using AppService.Infrastructure.DataSap;
using AppService.Infrastructure.DataSpi;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RRDContext _context;
        private readonly MooreveContext _mooreveContext;
        private readonly MCContext _mcContext;
        private readonly IMaestrosContext _maestrosContext;
        private readonly SapContext _sapContext;
        private readonly ClientesContext _clientesContext;
        private readonly FacturacionContext _facturacionContext;
        private readonly PlantaContext _plantaContext;
        private readonly ContratosStockContext _contratosStockContext;
        private readonly DWContext _dWContext;
        private readonly NominaContext _nominaContext;
        private readonly SpiContext _spiContext;
        private readonly MaterialesContext _materialesContext;



        //new


        private readonly IAppOrdenProductoRepeticionRepository _appOrdenProductoRepeticionRepository;

        private readonly ICobAdjuntosCobranzaRepository _cobAdjuntosCobranzaRepository;

        private readonly ICobGeneralCobranzaRepository _cobGeneralCobranzaRepository;

        public readonly ISegUsuarioRepository _segUsuarioRepository;

        public readonly IMtrClienteRepository _mtrClienteRepository;

        public readonly ICobTipoTransaccionRepository _cobTipoTransaccionRepository;

        public readonly IOfdTipoDocumentoRepository _ofdTipoDocumentoRepository;

        public readonly IMtrOficinaRepository _mtrOficinaRepository;


        public readonly IMtrVendedorRepository _mtrVendedorRepository;

        public readonly IMtrBancosRepository _mtrBancosRepository;

        public readonly IMtrTipoMonedaRepository _mtrTipoMonedaRepository;

        public readonly ICobGrabacionCobranzasRepository _cobGrabacionCobranzasRepository;

        public readonly IMtrTipoTransaccionCuentaDestinoRepository _mtrTipoTransaccionCuentaDestinoRepository;

        public readonly ICobTransaccionesRepository _cobTransaccionesRepository;

        public readonly ICobEstadoDeCuentaRepository _cobEstadoDeCuentaRepository;

        public readonly IOfdCotizacionRepository _ofdCotizacionRepository;

        public readonly ICobPagosRetencionesRepository _cobPagosRetencionesRepository;

        public readonly ICobSysfileRepository _cobSysfileRepository;

        public readonly ISapRetencionesRepository _sapRetencionesRepository;

        public readonly ICobValoresRetencionesRepository _cobValoresRetencionesRepository;

        public readonly IMtrContactosRepository _mtrContactosRepository;

        public readonly ITPaTasaBancoCentralRepository _tPaTasaBancoCentralRepository;

        public readonly ICobMatrixMonedaValidaPagoRepository _cobMatrixMonedaValidaPagoRepository;

        public readonly IPageMenuRepository _pageMenuRepository;

        public readonly IChildMenuRepository _childMenuRepository;

        public readonly IAppGeneralQuotesRepository _appGeneralQuotesRepository;

        public readonly IMtrDireccionesRepository _mtrDireccionesRepository;

        public readonly IMtrCondicionPagoRepository _mtrCondicionPagoRepository;

        public readonly IAppStatusQuoteRepository _appStatusQuoteRepository;

        public readonly IAppUnitsRepository _appUnitsRepository;

        public readonly IAppProductConversionRepository _appProductConversionRepository;

        public readonly IAppSubCategoryRepository _appSubCategoryRepository;

        public readonly IAppProductsRepository _appProductsRepository;

        public readonly IAppDetailQuotesRepository _appDetailQuotesRepository;

        public readonly IAppVariablesRepository _appVariablesRepository;

        public readonly IAppIngredientsRepository _appIngredientsRepository;

        public readonly IAppRecipesRepository _appRecipesRepository;

        public readonly IAppConfigAppRepository _appConfigAppRepository;

        public readonly IAppVariableSearchRepository _appVariableSearchRepository;

        public readonly IAppProductVariableSearchTextRepository _appProductVariableSearchTextRepository;

        public readonly IAppTemplateConversionUnitRepository _appTemplateConversionUnitRepository;

        public readonly IAppDetailQuotesConversionUnitRepository _appDetailQuotesConversionUnitRepository;

        public readonly ITPaTasaReferencialRepository _tPaTasaReferencialRepository;

        public readonly IMotivoGanarPerderRepository _motivoGanarPerderRepository;

        public readonly ICompetidoresRepository _competidoresRepository;

        public readonly ICotizacionRepository _cotizacionRepository;

        public readonly IRenglonRepository _renglonRepository;

        public readonly IPropuestaRepository _propuestaRepository;


        public readonly IAprobacionesRepository _aprobacionesRepository;

        public readonly ITEnControlCalculoRepository _tEnControlCalculoRepository;

        public readonly ICsmy036Repository _csmy036Repository;

        public readonly IWsmy649Repository _wsmy649Repository;

        public readonly IWsmy647Repository _wsmy647Repository;

        public readonly IWsmy655Repository _wsmy655Repository;

        public readonly IWsmy645Repository _wsmy645Repository;

        public readonly IWpry229Repository _wpry229Repository;

        public readonly IWsmy406Repository _wsmy406Repository;

        public readonly IWpry240Repository _wpry240Repository;

        public readonly IWpry241Repository _wpry241Repository;

        public readonly IWSMY582Repository _wSMY582Repository;
        public readonly IWSMY583Repository _wSMY583Repository;

        private readonly ISapTratamientoContactoRepository _sapTratamientoContactoRepository;
        private readonly ISapCargoContactoRepository _sapCargoContactoRepository;
        private readonly ISapDepartamentoContactoRepository _sapDepartamentoContactoRepository;
        private readonly ISapPoderContactoRepository _sapPoderContactoRepository;
        private readonly ISapContactoRepository _sapContactoRepository;

        private readonly IWsmy265Repository _wsmy265Repository;

        private readonly IWiny243Repository _winy243Repository;

        private readonly IDatosClienteRepository _datosClienteRepository;

        private readonly IDatosProductosRepository _datosProductosRepository;

        private readonly ICobEstadoDeCuentaMultimonedaRepository _cobEstadoDeCuentaMultimonedaRepository;


        private readonly ICiny057Repository _ciny057Repository;


        private readonly IDwConsolidadoAnalisisDeVencimientoRepository _dwConsolidadoAnalisisDeVencimientoRepository;

        public readonly IAppPriceRepository _appPriceRepository;
        public readonly IAppRecipesByAppDetailQuotesRepository _appRecipesByAppDetailQuotesRepository;

        public readonly INmm024Repository _nmm024Repository;
        public readonly INmt033Repository _nmt033Repository;

        public readonly ISpiNmm024Repository _spiNmm024Repository;
        public readonly ISpiNmt033Repository _spiNmt033Repository;


        public readonly ICsmy005Repository _csmy005Repository;

        public readonly IWsmy065Repository _wsmy065Repository;


        public readonly IWsmy501EnviarOdooRepository _wsmy501EnviarOdooRepository;
        public readonly IWsmy501BorradosRepository _wsmy501BorradosRepository;


        public readonly ICpry012Repository _cpry012Repository;
        public readonly ICsmy021Repository _csmy021Repository;

        public readonly IWsmy369Repository _wsmy369Repository;
        public readonly IWpry243Repository _wpry243Repository;
        public readonly IWpry249Repository _wpry249Repository;
        public readonly IWpry251Repository _wpry251Repository;

        public readonly IWimy001Repository _wimy001Repository;


        public readonly IAppVariablesEspecificacionesPartesRepository _appVariablesEspecificacionesPartesRepository;
        public readonly IAppValoresVariablesEspecificacionesPartesRepository _appValoresVariablesEspecificacionesPartesRepository;

        public readonly IAppPorcentajeAdicionalM2Repository _appPorcentajeAdicionalM2Repository;
        

        public UnitOfWork(RRDContext context, MooreveContext mooreveContext, MCContext mcContext, IMaestrosContext maestrosContext, SapContext sapContext, ClientesContext clientesContext, FacturacionContext facturacionContext, ContratosStockContext contratosStockContext, DWContext dWContext, NominaContext nominaContext, SpiContext spiContext, PlantaContext plantaContext, MaterialesContext materialesContext)
        {
            _context = context;
            _mooreveContext = mooreveContext;
            _mcContext = mcContext;
            _maestrosContext = maestrosContext;
            _sapContext = sapContext;
            _clientesContext = clientesContext;
            _facturacionContext = facturacionContext;
            _contratosStockContext = contratosStockContext;
            _dWContext = dWContext;
            _nominaContext = nominaContext;
            _spiContext = spiContext;
            _plantaContext = plantaContext;
            _materialesContext = materialesContext;
        }


        //new

        public IAppOrdenProductoRepeticionRepository AppOrdenProductoRepeticionRepository => _appOrdenProductoRepeticionRepository ?? new AppOrdenProductoRepeticionRepository(_context);

        public ICobAdjuntosCobranzaRepository CobAdjuntosCobranzaRepository => _cobAdjuntosCobranzaRepository ?? new CobAdjuntosCobranzaRepository(_context);

        public ICobGeneralCobranzaRepository GeneralCobranzaRepository => _cobGeneralCobranzaRepository ?? new GeneralCobranzaRepository(_context);

        public ISegUsuarioRepository SegUsuarioRepository => _segUsuarioRepository ?? new SegUsuarioRepository(_context);

        public IMtrClienteRepository MtrClienteRepository => _mtrClienteRepository ?? new MtrClienteRepository(_context);

        public ICobTipoTransaccionRepository CobTipoTransaccionRepository => _cobTipoTransaccionRepository ?? new CobTipoTransaccionRepository(_context);

        public IOfdTipoDocumentoRepository OfdTipoDocumentoRepository => _ofdTipoDocumentoRepository ?? new OfdTipoDocumentoRepository(_context);


        public IMtrOficinaRepository MtrOficinaRepository => _mtrOficinaRepository ?? new MtrOficinaRepository(_context);

        public IMtrVendedorRepository MtrVendedorRepository => _mtrVendedorRepository ?? new MtrVendedorRepository(_context);

        public IMtrBancosRepository MtrBancosRepository => _mtrBancosRepository ?? new MtrBancosRepository(_context);

        public IMtrTipoMonedaRepository MtrTipoMonedaRepository => _mtrTipoMonedaRepository ?? new MtrTipoMonedaRepository(_context);

        public ICobGrabacionCobranzasRepository CobGrabacionCobranzasRepository => _cobGrabacionCobranzasRepository ?? new CobGrabacionCobranzasRepository(_context);

        public IMtrTipoTransaccionCuentaDestinoRepository MtrTipoTransaccionCuentaDestinoRepository => _mtrTipoTransaccionCuentaDestinoRepository ?? new MtrTipoTransaccionCuentaDestinoRepository(_context);

        public ICobTransaccionesRepository CobTransaccionesRepository => _cobTransaccionesRepository ?? new CobTransaccionesRepository(_context);

        public ICobEstadoDeCuentaRepository CobEstadoDeCuentaRepository => _cobEstadoDeCuentaRepository ?? new CobEstadoDeCuentaRepository(_context);

        public IOfdCotizacionRepository OfdCotizacionRepository => _ofdCotizacionRepository ?? new OfdCotizacionRepository(_context);

        public ICobPagosRetencionesRepository CobPagosRetencionesRepository => _cobPagosRetencionesRepository ?? new CobPagosRetencionesRepository(_context);

        public ICobSysfileRepository CobSysfileRepository => _cobSysfileRepository ?? new CobSysfileRepository(_context);

        public ISapRetencionesRepository SapRetencionesRepository => _sapRetencionesRepository ?? new SapRetencionesRepository(_context);


        public ICobValoresRetencionesRepository CobValoresRetencionesRepository => _cobValoresRetencionesRepository ?? new CobValoresRetencionesRepository(_context);


        public IMtrContactosRepository MtrContactosRepository => _mtrContactosRepository ?? new MtrContactosRepository(_context);

        public ICobMatrixMonedaValidaPagoRepository CobMatrixMonedaValidaPagoRepository => _cobMatrixMonedaValidaPagoRepository ?? new CobMatrixMonedaValidaPagoRepository(_context);

        public IPageMenuRepository PageMenuRepository => _pageMenuRepository ?? new PageMenuRepository(_context);

        public IChildMenuRepository ChildMenuRepository => _childMenuRepository ?? new ChildMenuRepository(_context);

        public IAppGeneralQuotesRepository AppGeneralQuotesRepository => _appGeneralQuotesRepository ?? new AppGeneralQuotesRepository(_context, _mooreveContext);

        public IMtrDireccionesRepository MtrDireccionesRepository => _mtrDireccionesRepository ?? new MtrDireccionesRepository(_context);

        public IMtrCondicionPagoRepository MtrCondicionPagoRepository => _mtrCondicionPagoRepository ?? new MtrCondicionPagoRepository(_context);

        public IAppStatusQuoteRepository AppStatusQuoteRepository => _appStatusQuoteRepository ?? new AppStatusQuoteRepository(_context);

        public IAppUnitsRepository AppUnitsRepository => _appUnitsRepository ?? new AppUnitsRepository(_context);



        public IAppProductConversionRepository AppProductConversionRepository => this._appProductConversionRepository ?? (IAppProductConversionRepository)new AppService.Infrastructure.Repositories.AppProductConversionRepository(this._context);


        public IAppSubCategoryRepository AppSubCategoryRepository => _appSubCategoryRepository ?? new AppSubCategoryRepository(_context);

        public IAppProductsRepository AppProductsRepository => _appProductsRepository ?? new AppProductsRepository(_context);


        public IAppDetailQuotesRepository AppDetailQuotesRepository => _appDetailQuotesRepository ?? new AppDetailQuotesRepository(_context);

        public IAppVariablesRepository AppVariablesRepository => _appVariablesRepository ?? new AppVariablesRepository(_context);

        public IAppIngredientsRepository AppIngredientsRepository => _appIngredientsRepository ?? new AppIngredientsRepository(_context);

        public IAppRecipesRepository AppRecipesRepository => _appRecipesRepository ?? new AppRecipesRepository(_context);
        public IAppRecipesByAppDetailQuotesRepository AppRecipesByAppDetailQuotesRepository => this._appRecipesByAppDetailQuotesRepository ?? (IAppRecipesByAppDetailQuotesRepository)new AppService.Infrastructure.Repositories.AppRecipesByAppDetailQuotesRepository(this._context);
        public IAppConfigAppRepository AppConfigAppRepository => _appConfigAppRepository ?? new AppConfigAppRepository(_context);

        public IAppVariableSearchRepository AppVariableSearchRepository => _appVariableSearchRepository ?? new AppVariableSearchRepository(_context);

        public IAppProductVariableSearchTextRepository AppProductVariableSearchTextRepository => _appProductVariableSearchTextRepository ?? new AppProductVariableSearchTextRepository(_context);

        public IAppTemplateConversionUnitRepository AppTemplateConversionUnitRepository => _appTemplateConversionUnitRepository ?? new AppTemplateConversionUnitRepository(_context);

        public IAppDetailQuotesConversionUnitRepository AppDetailQuotesConversionUnitRepository => _appDetailQuotesConversionUnitRepository ?? new AppDetailQuotesConversionUnitRepository(_context);

        public IAppPriceRepository AppPriceRepository => this._appPriceRepository ?? (IAppPriceRepository)new AppService.Infrastructure.Repositories.AppPriceRepository(this._context);
        public IAppPorcentajeAdicionalM2Repository AppPorcentajeAdicionalM2Repository => this._appPorcentajeAdicionalM2Repository ?? (IAppPorcentajeAdicionalM2Repository)new AppService.Infrastructure.Repositories.AppPorcentajeAdicionalM2Repository(this._context);

        

        //MC
        public ITPaTasaBancoCentralRepository TPaTasaBancoCentralRepository => _tPaTasaBancoCentralRepository ?? new TPaTasaBancoCentralRepository(_mcContext);
        public ITPaTasaReferencialRepository TPaTasaReferencialRepository => _tPaTasaReferencialRepository ?? new TPaTasaReferencialRepository(_mcContext);
        public ITEnControlCalculoRepository TEnControlCalculoRepository => _tEnControlCalculoRepository ?? new TEnControlCalculoRepository(_mcContext);



        //Mooreve
        public IMotivoGanarPerderRepository MotivoGanarPerderRepository => _motivoGanarPerderRepository ?? new MotivoGanarPerderRepository(_mooreveContext);

        public ICompetidoresRepository CompetidoresRepository => _competidoresRepository ?? new CompetidoresRepository(_mooreveContext);

        public ICotizacionRepository CotizacionRepository => _cotizacionRepository ?? new CotizacionRepository(_mooreveContext);

        public IRenglonRepository RenglonRepository => _renglonRepository ?? new RenglonRepository(_mooreveContext);

        public IPropuestaRepository PropuestaRepository => _propuestaRepository ?? new PropuestaRepository(_mooreveContext);

        public IAprobacionesRepository AprobacionesRepository => _aprobacionesRepository ?? new AprobacionesRepository(_mooreveContext);

        public IWsmy649Repository Wsmy649Repository => _wsmy649Repository ?? new Wsmy649Repository(_mooreveContext);


        public IWsmy647Repository Wsmy647Repository => _wsmy647Repository ?? new Wsmy647Repository(_mooreveContext);

        public IWsmy655Repository Wsmy655Repository => _wsmy655Repository ?? new Wsmy655Repository(_mooreveContext);

        public IWsmy645Repository Wsmy645Repository => _wsmy645Repository ?? new Wsmy645Repository(_mooreveContext);

        public IWpry229Repository Wpry229Repository => _wpry229Repository ?? new Wpry229Repository(_mooreveContext);

        public IWsmy406Repository Wsmy406Repository => _wsmy406Repository ?? new Wsmy406Repository(_mooreveContext);

        public IWpry240Repository Wpry240Repository => _wpry240Repository ?? new Wpry240Repository(_mooreveContext, _materialesContext);

        public IWpry241Repository Wpry241Repository => _wpry241Repository ?? new Wpry241Repository(_mooreveContext);

        public IWSMY582Repository WSMY582Repository => _wSMY582Repository ?? new WSMY582Repository(_mooreveContext);

        public IWSMY583Repository WSMY583Repository => _wSMY583Repository ?? new WSMY583Repository(_mooreveContext);

        public IWsmy501EnviarOdooRepository Wsmy501EnviarOdooRepository => _wsmy501EnviarOdooRepository ?? new Wsmy501EnviarOdooRepository(_mooreveContext);
        public IWsmy501BorradosRepository Wsmy501BorradosRepository => _wsmy501BorradosRepository ?? new Wsmy501BorradosRepository(_mooreveContext);
        public IWsmy369Repository Wsmy369Repository => _wsmy369Repository ?? new Wsmy369Repository(_mooreveContext);
        public IWpry243Repository Wpry243Repository => _wpry243Repository ?? new Wpry243Repository(_mooreveContext);
        public IWpry249Repository Wpry249Repository => _wpry249Repository ?? new Wpry249Repository(_mooreveContext);
        public IWpry251Repository Wpry251Repository => _wpry251Repository ?? new Wpry251Repository(_mooreveContext);

        public IAppVariablesEspecificacionesPartesRepository AppVariablesEspecificacionesPartesRepository => _appVariablesEspecificacionesPartesRepository ?? new AppVariablesEspecificacionesPartesRepository(_mooreveContext);
        public IAppValoresVariablesEspecificacionesPartesRepository AppValoresVariablesEspecificacionesPartesRepository => _appValoresVariablesEspecificacionesPartesRepository ?? new AppValoresVariablesEspecificacionesPartesRepository(_mooreveContext);


        public ICobEstadoDeCuentaMultimonedaRepository CobEstadoDeCuentaMultimonedaRepository => _cobEstadoDeCuentaMultimonedaRepository ?? new CobEstadoDeCuentaMultimonedaRepository(_mooreveContext);


        //Maestros
        public ICsmy036Repository Csmy036Repository => _csmy036Repository ?? new Csmy036Repository(_maestrosContext);

        //Nomina
        public INmm024Repository Nmm024Repository => _nmm024Repository ?? new Nmm024Repository(_nominaContext);
        public INmt033Repository Nmt033Repository => _nmt033Repository ?? new Nmt033Repository(_nominaContext);




        //Sap
        public ISapTratamientoContactoRepository SapTratamientoContactoRepository => _sapTratamientoContactoRepository ?? new SapTratamientoContactoRepository(_sapContext);
        public ISapCargoContactoRepository SapCargoContactoRepository => _sapCargoContactoRepository ?? new SapCargoContactoRepository(_sapContext);
        public ISapDepartamentoContactoRepository SapDepartamentoContactoRepository => _sapDepartamentoContactoRepository ?? new SapDepartamentoContactoRepository(_sapContext);
        public ISapPoderContactoRepository SapPoderContactoRepository => _sapPoderContactoRepository ?? new SapPoderContactoRepository(_sapContext);
        public ISapContactoRepository SapContactoRepository => _sapContactoRepository ?? new SapContactoRepository(_sapContext);


        //Clientes
        public IWsmy265Repository Wsmy265Repository => _wsmy265Repository ?? new Wsmy265Repository(_clientesContext);
        public IWsmy065Repository Wsmy065Repository => _wsmy065Repository ?? new Wsmy065Repository(_clientesContext);



        //Facturacion
        public IWiny243Repository Winy243Repository => _winy243Repository ?? new Winy243Repository(_facturacionContext);
        public ICiny057Repository Ciny057Repository => _ciny057Repository ?? new Ciny057Repository(_facturacionContext);


        //Contratos Stock
        public IDatosClienteRepository DatosClienteRepository => _datosClienteRepository ?? new DatosClienteRepository(_contratosStockContext, _mooreveContext, _context);

        public IDatosProductosRepository DatosProductosRepository => _datosProductosRepository ?? new DatosProductosRepository(_contratosStockContext);

        public IDwConsolidadoAnalisisDeVencimientoRepository DwConsolidadoAnalisisDeVencimientoRepository => _dwConsolidadoAnalisisDeVencimientoRepository ?? new DwConsolidadoAnalisisDeVencimientoRepository(_dWContext);


        public ISpiNmm024Repository SpiNmm024Repository => _spiNmm024Repository ?? new SpiNmm024Repository(_spiContext);

        public ISpiNmt033Repository SpiNmt033Repository => _spiNmt033Repository ?? new SpiNmt033Repository(_spiContext);


        //MAestros

        public ICsmy005Repository Csmy005Repository => _csmy005Repository ?? new Csmy005Repository(_maestrosContext);


        //Planta
        public ICpry012Repository Cpry012Repository => _cpry012Repository ?? new Cpry012Repository(_plantaContext);
        public ICsmy021Repository Csmy021Repository => _csmy021Repository ?? new Csmy021Repository(_plantaContext);



        public IWimy001Repository Wimy001Repository => _wimy001Repository ?? new Wimy001Repository(_materialesContext);




        public void Dispose()
        {
            if (_context == null)
            {
                _context.Dispose();
            }
            if (_mcContext == null)
            {
                _mcContext.Dispose();
            }
            if (_maestrosContext == null)
            {
                _maestrosContext.Dispose();
            }
            if (_clientesContext == null)
            {
                _clientesContext.Dispose();
            }
            if (_facturacionContext == null)
            {
                _facturacionContext.Dispose();
            }
            if (_contratosStockContext == null)
            {
                _contratosStockContext.Dispose();
            }
            if (_mooreveContext == null)
            {
                _mooreveContext.Dispose();
            }
            if (_dWContext == null)
            {
                _dWContext.Dispose();
            }
            if (_nominaContext == null)
            {
                _nominaContext.Dispose();
            }
            if (_spiContext == null)
            {
                _spiContext.Dispose();
            }
            if (_plantaContext == null)
            {
                _plantaContext.Dispose();
            }
            if (_materialesContext == null)
            {
                _materialesContext.Dispose();
            }


        }

        public bool SaveChanges()
        {

            try
            {
                _context.SaveChanges();
                _mcContext.SaveChanges();
                _maestrosContext.SaveChanges();
                _mooreveContext.SaveChanges();
                _sapContext.SaveChanges();
                _clientesContext.SaveChanges();
                _facturacionContext.SaveChanges();
                _contratosStockContext.SaveChanges();
                _dWContext.SaveChanges();
                _nominaContext.SaveChanges();
                _plantaContext.SaveChanges();
                _materialesContext.SaveChanges();
                return true;
            }
            catch (System.Exception e)
            {

                var msg = e.InnerException.Message;
                return false;
            }


        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                await _mcContext.SaveChangesAsync();
                await _maestrosContext.SaveChangesAsync();
                await _mooreveContext.SaveChangesAsync();
                await _sapContext.SaveChangesAsync();
                await _clientesContext.SaveChangesAsync();
                await _facturacionContext.SaveChangesAsync();
                await _contratosStockContext.SaveChangesAsync();
                await _dWContext.SaveChangesAsync();
                await _nominaContext.SaveChangesAsync();
                await _plantaContext.SaveChangesAsync();
                await _materialesContext.SaveChangesAsync();
                return true;
            }
            catch (System.Exception e)
            {

                // var msg = e.InnerException.Message;
                return false;

            }
        }
    }
}
