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
    public class AppVariablesRepository: IAppVariablesRepository
    {
        private readonly RRDContext _context;

        public AppVariablesRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppVariables>> GetAll()
        {

            return await _context.AppVariables.ToListAsync();

        }
        public async Task<List<AppVariables>> GetAllFilter(AppVariablesQueryFilter filter)
        {



            List<AppVariables> result = new List<AppVariables>();


            try
            {


                if (filter.Code != null && filter.Code.Length > 0)
                {
                    result = await _context.AppVariables.Where(x => x.Code.Trim().ToLower() == filter.Code.Trim().ToLower()).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();
                    return result;
                }
                else if (filter.SearchText != null && filter.SearchText.Length > 0)
                {
                    result = await _context.AppVariables.Where(x => x.Description.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()) || x.Code.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();
                    return result;
                }
                else if (filter.Description != null && filter.Description.Length > 0)
                {
                    result = await _context.AppVariables.Where(x => x.Description.Trim().ToLower().Contains(filter.Description.Trim().ToLower())).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();
                    return result;
                }
                else
                {
                    result = await _context.AppVariables.Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();
                    return result;
                }
                

                

            }
            catch (Exception e)
            {
                var a = e.InnerException.Message;
                return result;
            }


        }
        public async Task<AppVariables> GetById(int id)
        {
            return await _context.AppVariables.FindAsync(id);
        }
        public async Task<AppVariables> GetByCode(string code)
        {
            return await _context.AppVariables.Where(x => x.Code == code).FirstOrDefaultAsync();
        }

        public async Task Add(AppVariables entity)
        {
            await _context.AppVariables.AddAsync(entity);


        }



        public void Update(AppVariables entity)
        {
            _context.AppVariables.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppVariables entity = await GetById(id);
            _context.AppVariables.Remove(entity);

        }

    }
}
