
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
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
    public class AppProductVariableSearchTextRepository : IAppProductVariableSearchTextRepository
    {
        private readonly RRDContext _context;

        public AppProductVariableSearchTextRepository(RRDContext context) => this._context = context;

        public async Task<List<AppProductVariableSearchText>> GetAll() => await this._context.AppProductVariableSearchText.ToListAsync<AppProductVariableSearchText>();

        public async Task<List<AppProductVariableSearchText>> GetListByProduct(
          int appProductId)
        {
            return await this._context.AppProductVariableSearchText.Where<AppProductVariableSearchText>((Expression<Func<AppProductVariableSearchText, bool>>)(x => x.AppProductId == (int?)appProductId)).ToListAsync<AppProductVariableSearchText>();
        }

        public async Task<List<AppProductVariableSearchText>> GetAllByListVariable(
          List<AppVariableSearchCompareQueryFilter> filter)
        {
            try
            {
                return (await this._context.AppProductVariableSearchText.ToListAsync<AppProductVariableSearchText>()).Where<AppProductVariableSearchText>((Func<AppProductVariableSearchText, bool>)(x => filter.ToList<AppVariableSearchCompareQueryFilter>().Exists((Predicate<AppVariableSearchCompareQueryFilter>)(y =>
                {
                    int? appVariableId1 = y.AppVariableId;
                    int? appVariableId2 = x.AppVariableId;
                    return appVariableId1.GetValueOrDefault() == appVariableId2.GetValueOrDefault() & appVariableId1.HasValue == appVariableId2.HasValue && y.SearchText == x.SearchText;
                })))).ToList<AppProductVariableSearchText>();
            }
            catch (Exception ex)
            {
                string message = ex.InnerException.Message;
                return (List<AppProductVariableSearchText>)null;
            }
        }

        public async Task<AppProductVariableSearchText> GetById(int id) => await this._context.AppProductVariableSearchText.FindAsync((object)id);

        public async Task Add(AppProductVariableSearchText entity)
        {
            EntityEntry<AppProductVariableSearchText> entityEntry = await this._context.AppProductVariableSearchText.AddAsync(entity);
        }

        public async Task AddRange(List<AppProductVariableSearchText> entity) => await this._context.AppProductVariableSearchText.AddRangeAsync((IEnumerable<AppProductVariableSearchText>)entity);

        public void Update(AppProductVariableSearchText entity) => this._context.AppProductVariableSearchText.Update(entity);

        public async Task Delete(int id) => this._context.AppProductVariableSearchText.Remove(await this.GetById(id));

        public async Task DeleteByRange(
          List<AppProductVariableSearchText> appProductVariableSearchText)
        {
            this._context.AppProductVariableSearchText.RemoveRange((IEnumerable<AppProductVariableSearchText>)appProductVariableSearchText);
        }
    }
}
