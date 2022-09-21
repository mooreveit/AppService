using AppService.Core.DTOs;
using AppService.Core.DTOs.Odoo.Cotizaciones.Recibir;
using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AutoMapper;

namespace AppService.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {


        public AutomapperProfile()
        {
            CreateMap<CobGeneralCobranza, CobGeneralCobranzaDto>()
                 .ForMember(dest => dest.NombreCliente, opt => opt.MapFrom(src => src.IdClienteNavigation.Nombre.Trim()));

            CreateMap<CobGeneralCobranzaDto, CobGeneralCobranza>();

            CreateMap<CobGrabacionCobranzaDto, CobGrabacionCobranzas>();
            CreateMap<CobGrabacionCobranzas, CobGrabacionCobranzaDto>();

            CreateMap<CobPagosRetencionesDto, CobPagosRetenciones>();
            CreateMap<CobPagosRetenciones, CobPagosRetencionesDto>();


            CreateMap<MtrClienteDto, MtrCliente>();
            CreateMap<MtrCliente, MtrClienteDto>()
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Codigo.Trim() + "-" + src.Nombre.Trim() + " RIF: " + src.NoRegTribut.ToString()))
                 .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.Codigo.Trim()))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre.Trim()))
            .ForMember(dest => dest.Vendedor1, opt => opt.MapFrom(src => src.Vendedor1.Trim()));

            CreateMap<CobTipoTransaccionDto, CobTipoTransaccion>();
            CreateMap<CobTipoTransaccion, CobTipoTransaccionDto>();

            CreateMap<CobAdjuntosCobranzaDto, CobAdjuntosCobranza>();
            CreateMap<CobAdjuntosCobranza, CobAdjuntosCobranzaDto>();

            CreateMap<OfdTipoDocumentoDto, OfdTipoDocumento>();
            CreateMap<OfdTipoDocumento, OfdTipoDocumentoDto>();

            CreateMap<MtrOficinaDto, MtrOficina>();
            CreateMap<MtrOficina, MtrOficinaDto>()
                 .ForMember(dest => dest.NomOficina, opt => opt.MapFrom(src => src.NomOficina.Trim()));


            CreateMap<MtrVendedorDto, MtrVendedor>()
                 .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.Codigo.Trim()))
             .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre.Trim()));
            CreateMap<MtrVendedor, MtrVendedorDto>();

            CreateMap<MtrBancosDto, MtrBancos>();
            CreateMap<MtrBancos, MtrBancosDto>();

            CreateMap<MtrTipoMonedaDto, MtrTipoMoneda>();
            CreateMap<MtrTipoMoneda, MtrTipoMonedaDto>();

            CreateMap<CobTransaccionesDto, CobTransacciones>();
            CreateMap<CobTransacciones, CobTransaccionesDto>();

            CreateMap<CobEstadoDeCuenta, CobEstadoCuentaDto>();
            CreateMap<CobEstadoCuentaDto, CobEstadoDeCuenta>();


            CreateMap<OfdCotizacion, OfdCotizacionDto>();
            CreateMap<OfdCotizacionDto, OfdCotizacion>();

            CreateMap<AppGeneralQuotes, AppGeneralQuotesGetDto>();
            CreateMap<AppGeneralQuotesGetDto, AppGeneralQuotes>();

            CreateMap<AppGeneralQuotes, AppGeneralQuotesCreateDto>();
            CreateMap<AppGeneralQuotesCreateDto, AppGeneralQuotes>();


            CreateMap<AppGeneralQuotes, AppGeneralQuotesUpdateDto>();
            CreateMap<AppGeneralQuotesUpdateDto, AppGeneralQuotes>();
            CreateMap<AppGeneralQuotes, AppGeneralQuotes>();

            CreateMap<AppGeneralQuotesUpdateDto, GeneralUpdateDto>();
            CreateMap<GeneralUpdateDto, AppGeneralQuotesUpdateDto>();


            CreateMap<AppGeneralQuotesCreateDto, GeneralUpdateDto>();
            CreateMap<GeneralUpdateDto, AppGeneralQuotesCreateDto>();



            CreateMap<MtrContactos, MtrContactosDto>().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email.Trim()));
            CreateMap<MtrContactosDto, MtrContactos>();

            CreateMap<MtrDirecciones, MtrDireccionesDto>();
            CreateMap<MtrDireccionesDto, MtrDirecciones>();

            CreateMap<MtrCondicionPago, CondicionPagoDto>();
            CreateMap<CondicionPagoDto, MtrCondicionPago>();


            CreateMap<AppDetailQuotes, AppDetailQuotesGetDto>();
            CreateMap<AppDetailQuotesGetDto, AppDetailQuotes>();
            CreateMap<AppDetailQuotes, AppDetailQuotes>();

            CreateMap<AppDetailQuotes, AppDetailQuotesCreateDto>();
            CreateMap<AppDetailQuotesCreateDto, AppDetailQuotes>();


            CreateMap<AppDetailQuotes, AppDetailQuotesUpdateDto>();
            CreateMap<AppDetailQuotesUpdateDto, AppDetailQuotes>();

            CreateMap<AppProducts, AppProductsGetDto>();
            CreateMap<AppProductsGetDto, AppProducts>();

            CreateMap<AppProducts, AppProductsCreateDto>();
            CreateMap<AppProductsCreateDto, AppProducts>();

            CreateMap<AppProducts, AppProductsUpdateDto>();
            CreateMap<AppProductsUpdateDto, AppProducts>();

            CreateMap<AppUnits, AppUnitsGetDto>();
            CreateMap<AppUnitsGetDto, AppUnits>();


            CreateMap<AppStatusQuote, AppStatusQuoteGetDto>();
            CreateMap<AppStatusQuoteGetDto, AppStatusQuote>();


            CreateMap<AppRecipes, AppRecipesGetDto>();
            CreateMap<AppRecipesGetDto, AppRecipes>();

            CreateMap<AppRecipes, AppRecipesCreateDto>();
            CreateMap<AppRecipesCreateDto, AppRecipes>();

            CreateMap<AppRecipes, AppRecipesUpdateDto>();
            CreateMap<AppRecipesUpdateDto, AppRecipes>();

            CreateMap<AppVariableSearch, AppVariableSearchGetDto>();
            CreateMap<AppVariableSearchGetDto, AppVariableSearch>();

            CreateMap<AppTemplateConversionUnit, AppTemplateConversionUnitGetDto>();
            CreateMap<AppTemplateConversionUnitGetDto, AppTemplateConversionUnit>();

            CreateMap<AppDetailQuotesConversionUnit, AppTemplateConversionUnitGetDto>();
            CreateMap<AppTemplateConversionUnitGetDto, AppDetailQuotesConversionUnit>();
            CreateMap<AppDetailQuotesConversionUnit, AppDetailQuotesConversionUnit>();

            CreateMap<Core.EntitiesMC.TPaTasaReferencial, TPaTasaReferencialGetDto>();
            CreateMap<TPaTasaReferencialGetDto, Core.EntitiesMC.TPaTasaReferencial>();

            CreateMap<AppVariables, AppVariablesGetDto>();
            CreateMap<AppVariablesGetDto, AppVariables>();

            CreateMap<AppVariables, AppVariablesCreateDto>();
            CreateMap<AppVariablesCreateDto, AppVariables>();

            CreateMap<AppSubCategory, AppSubCategoryGetDto>();
            CreateMap<AppSubCategoryGetDto, AppSubCategory>();

            CreateMap<AppIngredients, AppIngredientsGetDto>();
            CreateMap<AppIngredientsGetDto, AppIngredients>();

            CreateMap<AppIngredients, AppIngredientsCreateDto>();
            CreateMap<AppIngredientsCreateDto, AppIngredients>();

            CreateMap<AppConfigApp, AppConfigAppGetDto>();
            CreateMap<AppConfigAppGetDto, AppConfigApp>();

            CreateMap<AppConfigApp, AppConfigAppCreateDto>();
            CreateMap<AppConfigAppCreateDto, AppConfigApp>();


            CreateMap<AppConfigApp, AppConfigAppUpdateDto>();
            CreateMap<AppConfigAppUpdateDto, AppConfigApp>();

            CreateMap<AppService.Core.EntitiesMooreve.Wsmy281, MotivoGanarPerderGetDto>();
            CreateMap<MotivoGanarPerderGetDto, AppService.Core.EntitiesMooreve.Wsmy281>();

            CreateMap<Wsmy383, CompetidoresGetDto>();
            CreateMap<CompetidoresGetDto, Wsmy383>();


            CreateMap<AppTemplateConversionUnit, AppTemplateConversionUnitGenericGetDto>();
            CreateMap<AppTemplateConversionUnitGenericGetDto, AppTemplateConversionUnit>();


            CreateMap<AppTemplateConversionUnitGetDto, AppTemplateConversionGenericUnitGetDto>();
            CreateMap<AppTemplateConversionGenericUnitGetDto, AppTemplateConversionUnitGetDto>();


            CreateMap<AppTemplateConversionUnit, AppTemplateConversionUnitUpdateDto>();
            CreateMap<AppTemplateConversionUnitUpdateDto, AppTemplateConversionUnit>();


            CreateMap<MunicipioGetDto, AppService.Core.EntitiesFacturacion.Winy243>();
            CreateMap<AppService.Core.EntitiesFacturacion.Winy243, MunicipioGetDto>();

            this.CreateMap<AppPrice, AppPriceUpdateDto>();
            this.CreateMap<AppPriceUpdateDto, AppPrice>();
            this.CreateMap<AppPrice, AppPriceCreateDto>();
            this.CreateMap<AppPriceCreateDto, AppPrice>();
            this.CreateMap<AppPrice, AppPriceGetDto>();
            this.CreateMap<AppPriceGetDto, AppPrice>();
            this.CreateMap<AppPrice, AppPriceDto>();


        }




    }
}
