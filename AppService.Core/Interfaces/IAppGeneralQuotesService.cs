using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.DTOs.Odoo.Cotizaciones.Recibir;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppGeneralQuotesService
    {
        Task<AppGeneralQuotes> GetById(int id);

        Task<AppGeneralQuotesGetDto> GetAppGeneralQuotes(AppGeneralQuotesQueryFilter filters);

        Task<PagedList<AppGeneralQuotesGetDto>> GetAllAppGeneralQuotes(AppGeneralQuotesQueryFilter filters);

        Task<AppGeneralQuotesGetDto> GetOneAppGeneralQuotes(AppGeneralQuotesQueryFilter filters);

        Task<PagedList<AppGeneralQuotesGetDto>> GetAllSimpleAppGeneralQuotes(AppGeneralQuotesQueryFilter filters);

        Task<AppGeneralQuotes> Insert(AppGeneralQuotes appGeneralQuotes);

        Task<ApiResponse<AppGeneralQuotesGetDto>> InsertGeneralQuotes(AppGeneralQuotesCreateDto appGeneralQuotesCreateDto);

        Task<ApiResponse<AppGeneralQuotesGetDto>> CopiarGeneralQuotes(AppGeneralQuotesCopyDto dto);

        Task<ApiResponse<AppGeneralQuotesGetDto>> UpdateGeneralQuotes(AppGeneralQuotesUpdateDto appGeneralQuotesUpdateDto);

        Task<ApiResponse<bool>> DeleteGeneralQuotes(AppGeneralQuotesDeleteDto appGeneralQuotesDeleteDto);

        Task<AppGeneralQuotes> Update(AppGeneralQuotes appGeneralQuotes);

        Task Delete(int id);

        string ProximaCotizacion(string Cod_Vendedor);

        Task<ApiResponse<AppGeneralQuotesGetDto>> EnviarAlCliente(AppGeneralQuotesChangeStatusDto dto);


        Task<AppGeneralQuotesActionSheetDto> GetAppGeneralQuotesActionSheetDto(int AppGeneralQuotesId, AppStatusQuote appStatusQuote, string cotizacion);
        Task<AppGeneralQuotes> ClonarAppGeneralQuotes(AppGeneralQuotes appGeneralQuotes);

        Task<AppDetailQuotes> ClonarAppDetailQuotes(AppDetailQuotes appDetailQuotes);

        Task<AppDetailQuotesConversionUnit> ClonarAppDetailQuotesConvesion(AppDetailQuotesConversionUnit appDetailQuotesConversionUnit);

        Task<decimal> GetFleteByIdDireccionEntrega(decimal id);

        Task<ApiResponse<AppGeneralQuotesGetDto>> RegresarAGrabacionCotizacion(
          AppGeneralQuotesCopyDto dto);


        //####################### O D O O ############################################
        Task<ApiResponse<GeneralGetDto>> OdooGeneralUpdate(GeneralUpdateDto dto);
        Task<List<string>> GetListCotizaciones();

    }
}
