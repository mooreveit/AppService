using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppDetailQuotesConversionUnitRepository
    {


        Task<List<AppDetailQuotesConversionUnit>> GetAll();

        Task<AppDetailQuotesConversionUnit> GetById(int id);

        Task Add(AppDetailQuotesConversionUnit entity);

        void Update(AppDetailQuotesConversionUnit entity);

        Task Delete(int id);
        Task<List<AppDetailQuotesConversionUnit>> GetByAppDetailQuotesId(int appDetailQuotesId);

        Task<AppDetailQuotesConversionUnit> GetByAppDetailQuotesIdCode(int appDetailQuotesId, string code);

        decimal TotalValue(int appDetailQuotesId);

        decimal GetCantidadPorUnidadProduccion(int appDetailQuotesId);
        Task<List<AppDetailQuotesConversionUnit>> GetDetailQuotesConversionInputById(int appDetailQuotesId);
    }
}
