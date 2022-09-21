using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppVariablesRepository
    {
        Task<List<AppVariables>> GetAll();

        Task<AppVariables> GetById(int id);
        Task<AppVariables> GetByCode(string code);
        Task Add(AppVariables entity);
        void Update(AppVariables entity);
        Task Delete(int id);
        Task<List<AppVariables>> GetAllFilter(AppVariablesQueryFilter filter);
    }
}
