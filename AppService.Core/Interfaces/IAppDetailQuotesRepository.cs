using AppService.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppDetailQuotesRepository
    {


        Task<List<AppDetailQuotes>> GetAll();

        Task<List<AppDetailQuotes>> GetByAppGeneralQuotesId(int appGeneralQuotesId);

        Task<AppDetailQuotes> GetById(int id);

        Task Add(AppDetailQuotes entity);

        void Update(AppDetailQuotes entity);
        Task Delete(int id);
        Task<AppDetailQuotes> GetByQuetesProduct(string cotizacion, int idProduct);


        Task<bool> ExisteEnEspera(int appGeneralQuotesId);


        Task<bool> ProductExistInQuotesDetail(int idProduct);

        Task<List<AppDetailQuotes>> GeSimpletByAppGeneralQuotesId(int appGeneralQuotesId);
        Task<List<AppDetailQuotes>> GetByQuotesCotizacion(string cotizacion)
;
    }
}
