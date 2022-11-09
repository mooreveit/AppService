using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppDetailQuotesService
    {
        Task UpdateDataReport(string cotizacion);
        Task<string> DescripcionProductosCotizadosAppGeneralQuotesId(int appGeneralQuotesId);
        Task<List<AppDetailQuotes>> GetAll();

        Task<AppDetailQuotes> GetById(int id);

        Task<AppDetailQuotes> Insert(AppDetailQuotes appDetailQuotes);


        Task<AppDetailQuotes> Update(AppDetailQuotes appDetailQuotes);


        Task<bool> Delete(int id);


        Task<ApiResponse<AppDetailQuotesGetDto>> InsertAppDetailQuotes(AppDetailQuotesCreateDto appDetailQuotesDto);

        Task<ApiResponse<AppDetailQuotesGetDto>> UpdateAppDetailQuotes(AppDetailQuotesUpdateDto appDetailQuotesUpdateDto);

        Task<ApiResponse<bool>> DeleteDetailQuotes(AppDetailQuotesDeleteDto appDetailQuotesDeleteDto);

        Task<ApiResponse<List<AppDetailQuotesGetDto>>> GetListAppDetailQuoteByAppGeneralQuotesId(int appGeneralQuotesId);

        Task<ApiResponse<bool>> GanarPerder(AppGanarPerderDto appGanarPerderDto);

        Task<bool> RequiereAprobacionAppGeneralQuotesId(int appGeneralQuotesId);

    }
}
