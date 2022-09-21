using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppProductVariableSearchTextService
    {

        Task<List<AppProductVariableSearchText>> AddRange(
             List<AppProductVariableSearchText> appProductVariableSearchText);

        Task<bool> DeleteByRange(
          List<AppProductVariableSearchText> appProductVariableSearchText);

        Task<List<AppProductVariableSearchText>> GetAll();

        Task<List<AppProductVariableSearchText>> GetAllByListVariable(
          List<AppVariableSearchCompareQueryFilter> filter);

        Task<AppProductVariableSearchText> GetById(int id);

        Task<AppProductVariableSearchText> Insert(
          AppProductVariableSearchText appProductVariableSearchText);

        Task<AppProductVariableSearchText> Update(
          AppProductVariableSearchText appProductVariableSearchText);

        Task<bool> Delete(int id);

    }
}
