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
    public class AppUnitsRepository:IAppUnitsRepository
    {


        private readonly RRDContext _context;

        public AppUnitsRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppUnits>> GetAll()
        {

            return await _context.AppUnits.ToListAsync();

        }

        public async Task<List<AppUnits>> GetAllFilter(AppUnitsQueryFilter filter)
        {

            

            List<AppUnits> result = new List<AppUnits>();


            try
            {
                if (filter.producto>0 )
                {
                    var producto = await _context.AppProducts.Where(x => x.Id == filter.producto).FirstOrDefaultAsync();
                    if(producto != null)
                    {
                        result = await _context.AppUnits.Where(x=>x.Id==producto.AppUnitsId).ToListAsync();
                    }
                }
                else
                {
                    if (filter.Searchtext != null && filter.Searchtext.Length > 0)
                    {
                        result = await _context.AppUnits.Where(x => x.Code.Trim().ToLower().Contains(filter.Searchtext.Trim().ToLower()) ||
                                                                    x.Description1.Trim().ToLower().Contains(filter.Searchtext.Trim().ToLower()) ||
                                                                    x.Description2.Trim().ToLower().Contains(filter.Searchtext.Trim().ToLower()) ||
                                                                    x.Description3.Trim().ToLower().Contains(filter.Searchtext.Trim().ToLower()) ||
                                                                    x.Description4.Trim().ToLower().Contains(filter.Searchtext.Trim().ToLower()))
                                                        .Skip((filter.PageNumber - 1) * filter.PageSize)
                                                        .Take(filter.PageSize).ToListAsync();
                        return result;
                    }



                    if (filter.Code != null && filter.Code.Length > 0)
                    {
                        result = await _context.AppUnits.Where(x => x.Code.Trim().ToLower().Contains(filter.Code.Trim().ToLower())).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                    else if (filter.Description1 != null && filter.Description1.Length > 0)
                    {
                        result = await _context.AppUnits.Where(x => x.Description1.Trim().ToLower().Contains(filter.Description1.Trim().ToLower())).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                    else if (filter.Description2 != null && filter.Description2.Length > 0)
                    {
                        result = await _context.AppUnits.Where(x => x.Description2.Trim().ToLower().Contains(filter.Description2.Trim().ToLower())).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                    else if (filter.Description3 != null && filter.Description3.Length > 0)
                    {
                        result = await _context.AppUnits.Where(x => x.Description3.Trim().ToLower().Contains(filter.Description3.Trim().ToLower())).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                    else if (filter.Description4 != null && filter.Description4.Length > 0)
                    {
                        result = await _context.AppUnits.Where(x => x.Description4.Trim().ToLower().Contains(filter.Description4.Trim().ToLower())).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                    else if (filter.Id > 0)
                    {
                        result = await _context.AppUnits.Where(x => x.Id == filter.Id).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                    else
                    {
                        result = await _context.AppUnits.Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                }
                



             


                return result;

            }
            catch (Exception e)
            {
                var a = e.InnerException.Message;
                return result;
            }


        }

        public async Task<List<AppUnits>> GetAppUnitsWithConversion(AppUnitsQueryFilter filter)
        {



            List<AppUnits> result = new List<AppUnits>();


            try
            {
                if (filter.Searchtext != null && filter.Searchtext.Length > 0)
                {

                    result = await _context.AppUnits.Include(x => x.AppTemplateConversionUnitAppUnitIdSinceNavigation).Where(x=>x.AppTemplateConversionUnitAppUnitIdSinceNavigation.Count>0).ToListAsync();

                    result = result.Where(x =>  x.Code.Trim().ToLower().Contains(filter.Searchtext.Trim().ToLower()) ||
                                                                x.Description1.Trim().ToLower().Contains(filter.Searchtext.Trim().ToLower()) ||
                                                                x.Description2.Trim().ToLower().Contains(filter.Searchtext.Trim().ToLower()) ||
                                                                x.Description3.Trim().ToLower().Contains(filter.Searchtext.Trim().ToLower()) ||
                                                                x.Description4.Trim().ToLower().Contains(filter.Searchtext.Trim().ToLower()) )
                                                    .Skip((filter.PageNumber - 1) * filter.PageSize)
                                                    .Take(filter.PageSize).ToList();

                    return result;
                } else
                {

                    result = await _context.AppUnits.Include(x => x.AppTemplateConversionUnitAppUnitIdSinceNavigation).Where(x => x.AppTemplateConversionUnitAppUnitIdSinceNavigation.Count > 0).ToListAsync();


                    result = result.Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToList();

                }


                return result;

            }
            catch (Exception e)
            {
                var a = e.InnerException.Message;
                return result;
            }


        }

        

        public async Task<AppUnits> GetById(int id)
        {
            return await _context.AppUnits.FindAsync(id);
        }

        public async Task Add(AppUnits entity)
        {
            await _context.AppUnits.AddAsync(entity);


        }



        public void Update(AppUnits entity)
        {
            _context.AppUnits.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppUnits entity = await GetById(id);
            _context.AppUnits.Remove(entity);

        }


    }
}
