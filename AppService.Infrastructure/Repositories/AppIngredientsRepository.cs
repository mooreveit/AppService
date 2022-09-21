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
    public class AppIngredientsRepository: IAppIngredientsRepository
    {
        private readonly RRDContext _context;

        public AppIngredientsRepository(RRDContext context)
        {
            _context = context;
        }

        public async  Task<List<AppIngredients>> GetAll()
        {

            return await _context.AppIngredients.ToListAsync();

        }
        public async Task<List<AppIngredients>> GetAllFilter(AppIngredientsQueryFilter filter)
        {



            List<AppIngredients> result = new List<AppIngredients>();


            try
            {


                if (filter.Code != null && filter.Code.Length > 0)
                {
                    result = await _context.AppIngredients.Where(x => x.Code.Trim().ToLower() == filter.Code.Trim().ToLower()).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                }
                else if (filter.Description != null && filter.Description.Length > 0)
                {
                    result = await _context.AppIngredients.Where(x => x.Description.Trim().ToLower().Contains(filter.Description.Trim().ToLower())).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                }
              
                else if (filter.SearchText != null && filter.SearchText.Length > 0)
                {
                    result = await _context.AppIngredients.Where(x => x.Description.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()) || x.Code.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()) || x.Code.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                }

                else
                {
                    result = await _context.AppIngredients.Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                }


                return result;

            }
            catch (Exception e)
            {
                var a = e.InnerException.Message;
                return result;
            }


        }
        public async Task<AppIngredients> GetById(int id)
        {
            return await _context.AppIngredients.FindAsync(id);
        }

        public async Task Add(AppIngredients entity)
        {
            await _context.AppIngredients.AddAsync(entity);


        }



        public void Update(AppIngredients entity)
        {
            _context.AppIngredients.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppIngredients entity = await GetById(id);
            _context.AppIngredients.Remove(entity);

        }

    }
}
