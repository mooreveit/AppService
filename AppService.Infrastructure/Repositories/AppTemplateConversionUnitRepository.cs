using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppTemplateConversionUnitRepository: IAppTemplateConversionUnitRepository
    {

        private readonly RRDContext _context;

        public AppTemplateConversionUnitRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppTemplateConversionUnit>> GetAll()
        {

            return await _context.AppTemplateConversionUnit.ToListAsync();

        }

        public async Task<List<AppTemplateConversionUnit>> GetTemplateByUnits(int appUnitIdSince, int appUnitIdUntil)
        {
           
            return await _context.AppTemplateConversionUnit.Where(x=>x.AppUnitIdSince== appUnitIdSince && x.AppUnitIdUntil== appUnitIdUntil).ToListAsync();

        }

        public async Task<List<AppTemplateConversionUnit>> GetTemplateByUnitsInput(int appUnitIdSince, int appUnitIdUntil)
        {
            List<AppTemplateConversionUnit> result = new List<AppTemplateConversionUnit>();
            if (appUnitIdSince>0)
            {
                result =await _context.AppTemplateConversionUnit.Where(x => x.AppUnitIdSince == appUnitIdSince && x.AppUnitIdUntil == appUnitIdUntil && (x.Formula == null || x.Formula == "")).ToListAsync();


            }
            else
            {
                result = await _context.AppTemplateConversionUnit.Where(x =>  (x.Formula == null || x.Formula == "")).ToListAsync();

            }

            return result;
        }

        public async Task<List<AppTemplateConversionUnit>> GetAllTemplateByUnitsInput(int appUnitIdSince, int appUnitIdUntil)
        {
            List<AppTemplateConversionUnit> result = new List<AppTemplateConversionUnit>();
            if (appUnitIdSince > 0)
            {
                result = await _context.AppTemplateConversionUnit.Where(x => x.AppUnitIdSince == appUnitIdSince && x.AppUnitIdUntil == appUnitIdUntil ).ToListAsync();


            }
            else
            {
                result = await _context.AppTemplateConversionUnit.ToListAsync();

            }

            return result;
        }


        public async Task<AppTemplateConversionUnit> GetById(int id)
        {
            return await _context.AppTemplateConversionUnit.FindAsync(id);
        }

        public async Task Add(AppTemplateConversionUnit entity)
        {
            await _context.AppTemplateConversionUnit.AddAsync(entity);


        }



        public void Update(AppTemplateConversionUnit entity)
        {
            _context.AppTemplateConversionUnit.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppTemplateConversionUnit entity = await GetById(id);
            _context.AppTemplateConversionUnit.Remove(entity);

        }

    }
}
