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
    public class AppPriceRepository : IAppPriceRepository
    {
        private readonly RRDContext _context;

        public AppPriceRepository(RRDContext context) => this._context = context;

        public async Task<List<AppPrice>> GetAllByAppProduct(int appProductId) => await this._context.AppPrice.Where<AppPrice>((Expression<Func<AppPrice, bool>>)(p => p.AppproductsId == appProductId)).OrderBy<AppPrice, Decimal>((Expression<Func<AppPrice, Decimal>>)(x => x.Desde)).ToListAsync<AppPrice>();

        public async Task<bool> ProductExist(int appProductId)
        {
            bool result = false;
            List<AppPrice> listAsync = await this._context.AppPrice.Where<AppPrice>((Expression<Func<AppPrice, bool>>)(p => p.AppproductsId == appProductId)).OrderBy<AppPrice, Decimal>((Expression<Func<AppPrice, Decimal>>)(x => x.Desde)).ToListAsync<AppPrice>();
            if (listAsync != null && listAsync.Count > 0)
                result = true;
            return result;
        }

        public async Task<AppPrice> GetById(int id) => await this._context.AppPrice.Where<AppPrice>((Expression<Func<AppPrice, bool>>)(x => x.Id == id)).FirstOrDefaultAsync<AppPrice>();

        public async Task<AppPrice> GetByProductoDesdeHastaId(
          int apprpoductId,
          Decimal desde,
          Decimal hasta)
        {
            return await this._context.AppPrice.Where<AppPrice>((Expression<Func<AppPrice, bool>>)(x => x.AppproductsId == apprpoductId && x.Desde == desde && x.Hasta == hasta)).FirstOrDefaultAsync<AppPrice>();
        }

        public async Task Add(AppPrice entity)
        {
            EntityEntry<AppPrice> entityEntry = await this._context.AppPrice.AddAsync(entity);
        }

        public void Update(AppPrice entity)
        {
            try
            {
                this._context.AppPrice.Update(entity);
            }
            catch (Exception ex)
            {
                string message = ex.InnerException.Message;
                throw;
            }
        }

        public async Task Delete(int id) => this._context.AppPrice.Remove(await this.GetById(id));

        public async Task<AppPrice> GetByProductoCantidad(
          int apprpoductId,
          Decimal cantidad)
        {

            AppPrice appPrice = new AppPrice();
            appPrice = await this._context.AppPrice.Where<AppPrice>((Expression<Func<AppPrice, bool>>)(x => x.AppproductsId == apprpoductId && x.Desde <= cantidad && x.Hasta >= cantidad)).FirstOrDefaultAsync<AppPrice>();
            if (appPrice == null)
            {
                appPrice = await this._context.AppPrice.Where<AppPrice>((Expression<Func<AppPrice, bool>>)(x => x.AppproductsId == apprpoductId)).OrderBy(x => x.Desde).FirstOrDefaultAsync<AppPrice>();
            }

            return appPrice;
        }

        public async Task<AppPrice> GetFirstPriceByProduct(int apprpoductId)
        {
            AppPrice appPrice = new AppPrice();
            return await this._context.AppPrice.Where<AppPrice>((Expression<Func<AppPrice, bool>>)(x => x.AppproductsId == apprpoductId)).OrderBy<AppPrice, Decimal>((Expression<Func<AppPrice, Decimal>>)(x => x.Desde)).FirstOrDefaultAsync<AppPrice>();
        }
    }
}
