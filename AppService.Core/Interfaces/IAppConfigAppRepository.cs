using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppConfigAppRepository
    {
        Task<List<AppConfigApp>> GetAll();
        Task<List<AppConfigApp>> GetAllFilter(AppConfigAppQueryFilter filter);
        Task<AppConfigApp> GetById(int id);

        Task<AppConfigApp> GetByKey(string key);

        Task Add(AppConfigApp entity);

        void Update(AppConfigApp entity);

        Task Delete(int id);

    }
}
