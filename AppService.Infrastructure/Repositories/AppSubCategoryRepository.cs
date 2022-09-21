using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppSubCategoryRepository: IAppSubCategoryRepository
    {

        private readonly RRDContext _context;

        public AppSubCategoryRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppSubCategory>> GetAll()
        {

            return await _context.AppSubCategory.ToListAsync();

        }
        public async Task<List<AppSubCategory>> GetAllFilter(AppSubCategoryQueryFilter filter)
        {
            List<AppSubCategory> result = new List<AppSubCategory>();


            if (filter.Id>0)
            {
                result = await _context.AppSubCategory.Where(x=>x.Id==filter.Id).ToListAsync();
            }
            else if (filter.Description!= null && filter.Description!= "")
            {
                result = await _context.AppSubCategory.Where(x => x.Description == filter.Description).ToListAsync();
            }else
            {
                result = await _context.AppSubCategory.ToListAsync();
            }
            

            return result;

        }

        public async Task<AppSubCategory> GetById(int id)
        {
            return await _context.AppSubCategory.FindAsync(id);
        }

        public async Task Add(AppSubCategory entity)
        {
            await _context.AppSubCategory.AddAsync(entity);


        }



        public void Update(AppSubCategory entity)
        {
            _context.AppSubCategory.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppSubCategory entity = await GetById(id);
            _context.AppSubCategory.Remove(entity);

        }
    }
}
