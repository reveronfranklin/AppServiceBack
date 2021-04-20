﻿using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using AppService.Infrastructure.DataClientes;
using AppService.Infrastructure.DataFacturacion;
using AppService.Infrastructure.DataMaestros;
using AppService.Infrastructure.DataMc;

using AppService.Infrastructure.DataMooreve;
using AppService.Infrastructure.DataSap;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RRDContext _context;
        private readonly MooreveContext _mooreveContext;
        private readonly MCContext _mcContext;
        private readonly MaestrosContext _maestrosContext;
        private readonly SapContext _sapContext;
        private readonly ClientesContext _clientesContext;
        private readonly FacturacionContext _facturacionContext;

        


        //new
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

        



        public UnitOfWork(RRDContext context, MooreveContext mooreveContext, MCContext mcContext,MaestrosContext maestrosContext, SapContext sapContext,ClientesContext clientesContext,FacturacionContext facturacionContext)
        {
            _context = context;
            _mooreveContext = mooreveContext;
            _mcContext = mcContext;
            _maestrosContext = maestrosContext;
            _sapContext = sapContext;
            _clientesContext = clientesContext;
            _facturacionContext = facturacionContext;
        }


        //new
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

        public IAppGeneralQuotesRepository AppGeneralQuotesRepository => _appGeneralQuotesRepository ?? new AppGeneralQuotesRepository(_context,_mooreveContext);

        public IMtrDireccionesRepository MtrDireccionesRepository => _mtrDireccionesRepository ?? new MtrDireccionesRepository(_context);

        public IMtrCondicionPagoRepository MtrCondicionPagoRepository => _mtrCondicionPagoRepository ?? new MtrCondicionPagoRepository(_context);

        public IAppStatusQuoteRepository AppStatusQuoteRepository => _appStatusQuoteRepository ?? new AppStatusQuoteRepository(_context);

        public IAppUnitsRepository AppUnitsRepository => _appUnitsRepository ?? new AppUnitsRepository(_context);

        public IAppSubCategoryRepository AppSubCategoryRepository => _appSubCategoryRepository ?? new AppSubCategoryRepository(_context);

        public IAppProductsRepository AppProductsRepository => _appProductsRepository ?? new AppProductsRepository(_context);


        public IAppDetailQuotesRepository AppDetailQuotesRepository => _appDetailQuotesRepository ?? new AppDetailQuotesRepository(_context);

        public IAppVariablesRepository AppVariablesRepository => _appVariablesRepository ?? new AppVariablesRepository(_context);

        public IAppIngredientsRepository AppIngredientsRepository => _appIngredientsRepository ?? new AppIngredientsRepository(_context);

        public IAppRecipesRepository AppRecipesRepository => _appRecipesRepository ?? new AppRecipesRepository(_context);

        public IAppConfigAppRepository AppConfigAppRepository => _appConfigAppRepository ?? new AppConfigAppRepository(_context);

        public IAppVariableSearchRepository AppVariableSearchRepository => _appVariableSearchRepository ?? new AppVariableSearchRepository(_context);

        public IAppProductVariableSearchTextRepository AppProductVariableSearchTextRepository => _appProductVariableSearchTextRepository ?? new AppProductVariableSearchTextRepository(_context);

        public IAppTemplateConversionUnitRepository AppTemplateConversionUnitRepository => _appTemplateConversionUnitRepository ?? new AppTemplateConversionUnitRepository(_context);

        public IAppDetailQuotesConversionUnitRepository AppDetailQuotesConversionUnitRepository => _appDetailQuotesConversionUnitRepository ?? new AppDetailQuotesConversionUnitRepository(_context);

        

        //MC
        public ITPaTasaBancoCentralRepository TPaTasaBancoCentralRepository => _tPaTasaBancoCentralRepository ?? new TPaTasaBancoCentralRepository(_mcContext);
        public ITPaTasaReferencialRepository TPaTasaReferencialRepository => _tPaTasaReferencialRepository ?? new TPaTasaReferencialRepository(_mcContext);
        public ITEnControlCalculoRepository TEnControlCalculoRepository => _tEnControlCalculoRepository ?? new TEnControlCalculoRepository(_mcContext);



        //Mooreve
        public IMotivoGanarPerderRepository MotivoGanarPerderRepository => _motivoGanarPerderRepository ?? new MotivoGanarPerderRepository(_mooreveContext);

        public ICompetidoresRepository CompetidoresRepository => _competidoresRepository ?? new CompetidoresRepository(_mooreveContext);
        
        public ICotizacionRepository CotizacionRepository => _cotizacionRepository  ?? new CotizacionRepository(_mooreveContext);

        public IRenglonRepository RenglonRepository => _renglonRepository ?? new RenglonRepository(_mooreveContext);

        public IPropuestaRepository PropuestaRepository => _propuestaRepository ?? new PropuestaRepository(_mooreveContext);

        public IAprobacionesRepository AprobacionesRepository => _aprobacionesRepository ?? new AprobacionesRepository(_mooreveContext);

        public IWsmy649Repository Wsmy649Repository => _wsmy649Repository ?? new Wsmy649Repository(_mooreveContext);


        public IWsmy647Repository Wsmy647Repository => _wsmy647Repository ?? new Wsmy647Repository(_mooreveContext);
        
        public IWsmy655Repository Wsmy655Repository => _wsmy655Repository ?? new Wsmy655Repository(_mooreveContext);

        public IWsmy645Repository Wsmy645Repository => _wsmy645Repository ?? new Wsmy645Repository(_mooreveContext);
        
        public IWpry229Repository Wpry229Repository => _wpry229Repository ?? new Wpry229Repository(_mooreveContext);

        public IWsmy406Repository Wsmy406Repository => _wsmy406Repository ?? new Wsmy406Repository(_mooreveContext);

        public IWpry240Repository Wpry240Repository => _wpry240Repository ?? new Wpry240Repository(_mooreveContext);

        public IWpry241Repository Wpry241Repository => _wpry241Repository ?? new Wpry241Repository(_mooreveContext);

        public IWSMY582Repository WSMY582Repository => _wSMY582Repository ?? new WSMY582Repository(_mooreveContext);

        public IWSMY583Repository WSMY583Repository => _wSMY583Repository ?? new WSMY583Repository(_mooreveContext);

        //Maestros
        public ICsmy036Repository Csmy036Repository => _csmy036Repository ?? new Csmy036Repository(_maestrosContext);



        //Sap
        public ISapTratamientoContactoRepository SapTratamientoContactoRepository => _sapTratamientoContactoRepository ?? new SapTratamientoContactoRepository(_sapContext);
        public ISapCargoContactoRepository SapCargoContactoRepository => _sapCargoContactoRepository ?? new SapCargoContactoRepository(_sapContext);
        public ISapDepartamentoContactoRepository SapDepartamentoContactoRepository => _sapDepartamentoContactoRepository ?? new SapDepartamentoContactoRepository(_sapContext);
        public ISapPoderContactoRepository SapPoderContactoRepository => _sapPoderContactoRepository ?? new SapPoderContactoRepository(_sapContext);
        public ISapContactoRepository SapContactoRepository => _sapContactoRepository ?? new SapContactoRepository(_sapContext);


        //Clientes
        public IWsmy265Repository Wsmy265Repository => _wsmy265Repository ?? new Wsmy265Repository(_clientesContext);



        //Facturacion
        public IWiny243Repository Winy243Repository => _winy243Repository ?? new Winy243Repository(_facturacionContext);
        

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

        }

        public void SaveChanges()
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
            }
            catch (System.Exception e)
            {

                var msg = e.InnerException.Message;

            }


        }

        public async Task SaveChangesAsync()
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

            }
            catch (System.Exception e)
            {

               var msg = e.InnerException.Message;

            }
        }
    }
}
