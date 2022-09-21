using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppIngredientsRepository
    {
        Task<List<AppIngredients>> GetAll();
        Task<AppIngredients> GetById(int id);
        Task Add(AppIngredients entity);
        void Update(AppIngredients entity);
        Task Delete(int id);
        Task<List<AppIngredients>> GetAllFilter(AppIngredientsQueryFilter filter);

    }
}
