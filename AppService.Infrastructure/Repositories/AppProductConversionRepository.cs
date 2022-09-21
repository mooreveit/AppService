using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppProductConversionRepository : IAppProductConversionRepository
    {
        private readonly RRDContext _context;

        public AppProductConversionRepository(RRDContext context) => this._context = context;

        public IQueryable<AppProductConversion> GetAll() => this._context.AppProductConversion.Include<AppProductConversion, AppUnits>((Expression<Func<AppProductConversion, AppUnits>>)(ub => ub.AppUnitsIdBaseNavigation)).Include<AppProductConversion, AppUnits>((Expression<Func<AppProductConversion, AppUnits>>)(ua => ua.AppUnitsIdAlternativaNavigation)).AsQueryable<AppProductConversion>();

        public async Task<List<AppProductConversion>> GetAllByProduct(
          int appProductId)
        {
            //await this._context.AppProductConversion.Where<AppProductConversion>((Expression<Func<AppProductConversion, bool>>)(x => x.AppProductsId == (int?)appProductId)).Include<AppProductConversion, AppProducts>((Expression<Func<AppProductConversion, AppProducts>>)(p => p.AppProducts)).Include<AppProductConversion, int?>((Expression<Func<AppProductConversion, int?>>)(ub => ub.AppUnitsIdBase)).Include<AppProductConversion, int?>((Expression<Func<AppProductConversion, int?>>)(ua => ua.AppUnitsIdAlternativa)).ToListAsync<AppProductConversion>();
            var conversion = await this._context.AppProductConversion.Where(x => x.AppProductsId == appProductId).ToListAsync();
            return conversion;
        }

        public async Task<AppProductConversion> GetByProductBaseUnitAlternativeUnit(
          int appProductId,
          int appUnitBase,
          int appUnitAlternative)
        {
            return await this._context.AppProductConversion.Where<AppProductConversion>((Expression<Func<AppProductConversion, bool>>)(x => x.AppProductsId == (int?)appProductId && x.AppUnitsIdBase == (int?)appUnitBase && x.AppUnitsIdAlternativa == (int?)appUnitAlternative)).Include<AppProductConversion, AppUnits>((Expression<Func<AppProductConversion, AppUnits>>)(x => x.AppUnitsIdAlternativaNavigation)).Include<AppProductConversion, AppUnits>((Expression<Func<AppProductConversion, AppUnits>>)(y => y.AppUnitsIdBaseNavigation)).FirstOrDefaultAsync<AppProductConversion>();
        }

        public async Task<AppProductConversion> GetById(int id) => await this._context.AppProductConversion.FindAsync((object)id);

        public async Task Add(AppProductConversion entity)
        {
            EntityEntry<AppProductConversion> entityEntry = await this._context.AppProductConversion.AddAsync(entity);
        }

        public void Update(AppProductConversion entity) => this._context.AppProductConversion.Update(entity);

        public async Task Delete(int id) => this._context.AppProductConversion.Remove(await this.GetById(id));
    }
}
