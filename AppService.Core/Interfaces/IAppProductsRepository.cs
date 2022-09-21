using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppProductsRepository
    {
        Task<List<AppProducts>> GetAll();

        Task<AppProducts> GetById(int id);

        Task Add(AppProducts entity);

        void Update(AppProducts entity);

        Task Delete(int id);

        Task<List<AppProducts>> GetAllFilter(AppProdutsQueryFilter filter);

        Task<AppProducts> GetByCode(string code);

        Task<List<AppProducts>> GetAllByVarible(
          List<AppVariableSearchCompareQueryFilter> filter,
          int subCategoryId);

        Task<AppProducts> GetFirstByExternalCode(string code);
    }
}
