using AppService.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppVariableSearchRepository
    {

        Task<List<AppVariableSearch>> GetAll();

        Task<List<AppVariableSearch>> GetAllBySubCategory(int appSubCategoryId);

        Task<AppVariableSearch> GetById(int id);

        Task Add(AppVariableSearch entity);

        void Update(AppVariableSearch entity);

        Task Delete(int id);

        Task<AppVariableSearch> GetVariableSearchTextBySubcategoryVariableSearchTex(int appSubCategoryId, int appVariableId, string searchText);
        Task DeleteBySubCategory(int subCategoryId);
    }
}
