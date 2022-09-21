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
    public class AppConfigAppRepository: IAppConfigAppRepository
    {
        private readonly RRDContext _context;

        public AppConfigAppRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppConfigApp>> GetAll()
        {

            return await _context.AppConfigApp.ToListAsync();

        }
        public async Task<List<AppConfigApp>> GetAllFilter(AppConfigAppQueryFilter filter)
        {



            List<AppConfigApp> result = new List<AppConfigApp>();


            try
            {


                if (filter.Clave != null && filter.Clave.Length > 0)
                {
                    result = await _context.AppConfigApp.Where(x => x.Clave.Trim().ToLower() == filter.Clave.Trim().ToLower()).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                }
             

                else if (filter.SearchText != null && filter.SearchText.Length > 0)
                {
                    result = await _context.AppConfigApp.Where(x => x.Clave.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()) ).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                }

                else
                {
                    result = await _context.AppConfigApp.Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                }


                return result;

            }
            catch (Exception e)
            {
                var a = e.InnerException.Message;
                return result;
            }


        }

        public async Task<List<AppConfigApp>> GetAll(AppConfigAppQueryFilter filter)
        {

            return await _context.AppConfigApp.ToListAsync();

        }

        public async Task<AppConfigApp> GetById(int id)
        {
            return await _context.AppConfigApp.FindAsync(id);
        }
        public async Task<AppConfigApp> GetByKey(string key)
        {
            return await _context.AppConfigApp.Where(x=> x.Clave == key).FirstOrDefaultAsync();
        }
        
        public async Task Add(AppConfigApp entity)
        {
            await _context.AppConfigApp.AddAsync(entity);


        }



        public void Update(AppConfigApp entity)
        {
            _context.AppConfigApp.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppConfigApp entity = await GetById(id);
            _context.AppConfigApp.Remove(entity);

        }

    }
}
