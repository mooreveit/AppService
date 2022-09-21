using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppUnitsRepository
    {

        Task<List<AppUnits>> GetAll();
        Task<List<AppUnits>> GetAllFilter(AppUnitsQueryFilter filter);

        Task<AppUnits> GetById(int id);

        Task Add(AppUnits entity);


        void Update(AppUnits entity);

        Task Delete(int id);

        Task<List<AppUnits>> GetAppUnitsWithConversion(AppUnitsQueryFilter filter);

    }
}
