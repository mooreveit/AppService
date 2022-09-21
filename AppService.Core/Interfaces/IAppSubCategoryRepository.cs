using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppSubCategoryRepository
    {


        Task<List<AppSubCategory>> GetAll();


        Task<AppSubCategory> GetById(int id);

        Task Add(AppSubCategory entity);

        void Update(AppSubCategory entity);

        Task Delete(int id);

        Task<List<AppSubCategory>> GetAllFilter(AppSubCategoryQueryFilter filter);



    }
}
