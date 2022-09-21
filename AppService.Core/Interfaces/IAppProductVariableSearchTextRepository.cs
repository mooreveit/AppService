using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppProductVariableSearchTextRepository
    {
        Task<List<AppProductVariableSearchText>> GetListByProduct(
          int appProductId);
        Task<List<AppProductVariableSearchText>> GetAll();

        Task<List<AppProductVariableSearchText>> GetAllByListVariable(List<AppVariableSearchCompareQueryFilter> filter);

        Task<AppProductVariableSearchText> GetById(int id);

        Task Add(AppProductVariableSearchText entity);
        Task AddRange(List<AppProductVariableSearchText> entity);
        void Update(AppProductVariableSearchText entity);

        Task Delete(int id);
        Task DeleteByRange(List<AppProductVariableSearchText> appProductVariableSearchText);
    }
}
