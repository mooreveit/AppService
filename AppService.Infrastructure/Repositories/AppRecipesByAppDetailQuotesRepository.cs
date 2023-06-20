// Decompiled with JetBrains decompiler
// Type: AppService.Infrastructure.Repositories.AppRecipesByAppDetailQuotesRepository
// Assembly: AppService.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7451968D-D8DC-4F56-8DC2-58865A324B70
// Assembly location: D:\Moore\Publish\AppService.Infrastructure.dll

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
  public class AppRecipesByAppDetailQuotesRepository : IAppRecipesByAppDetailQuotesRepository
  {
    private readonly RRDContext _context;

    public AppRecipesByAppDetailQuotesRepository(RRDContext context) => this._context = context;

    public async Task<List<AppRecipesByAppDetailQuotes>> GetAll() => await this._context.AppRecipesByAppDetailQuotes.ToListAsync<AppRecipesByAppDetailQuotes>();

    public async Task<List<AppRecipesByAppDetailQuotes>> GetAllByCalculoId(
      int calculoId)
    {
      return await this._context.AppRecipesByAppDetailQuotes.Where<AppRecipesByAppDetailQuotes>((Expression<Func<AppRecipesByAppDetailQuotes, bool>>) (x => x.CalculoId == calculoId)).ToListAsync<AppRecipesByAppDetailQuotes>();
    }

    public async Task<AppRecipesByAppDetailQuotes> GetById(int id) => await this._context.AppRecipesByAppDetailQuotes.FindAsync((object) id);

    public async Task Add(AppRecipesByAppDetailQuotes entity)
    {
      EntityEntry<AppRecipesByAppDetailQuotes> entityEntry = await this._context.AppRecipesByAppDetailQuotes.AddAsync(entity);
    }

    public async Task AddRangeHistory(List<AppRecipesByAppDetailQuotesHistory> entity) => await this._context.AppRecipesByAppDetailQuotesHistory.AddRangeAsync((IEnumerable<AppRecipesByAppDetailQuotesHistory>) entity);

    public async Task AddRange(List<AppRecipesByAppDetailQuotes> entity) => await this._context.AppRecipesByAppDetailQuotes.AddRangeAsync((IEnumerable<AppRecipesByAppDetailQuotes>) entity);

    public void Update(AppRecipesByAppDetailQuotes entity) => this._context.AppRecipesByAppDetailQuotes.Update(entity);

    public async Task Delete(int id) => this._context.AppRecipesByAppDetailQuotes.Remove(await this.GetById(id));

    public void DeleteRange(List<AppRecipesByAppDetailQuotes> entity) => this._context.AppRecipesByAppDetailQuotes.RemoveRange((IEnumerable<AppRecipesByAppDetailQuotes>) entity);

    public Decimal TotalCost(int calculoId) => Queryable.Sum(this._context.AppRecipesByAppDetailQuotes.Where<AppRecipesByAppDetailQuotes>((Expression<Func<AppRecipesByAppDetailQuotes, bool>>) (c => c.CalculoId == calculoId && c.SumValue == (bool?) true)).Select<AppRecipesByAppDetailQuotes, Decimal?>((Expression<Func<AppRecipesByAppDetailQuotes, Decimal?>>) (c => c.TotalCost))).Value;

    public async Task<int> NextId()
    {
      AppRecipesByAppDetailQuotes byAppDetailQuotes = await this._context.AppRecipesByAppDetailQuotes.OrderByDescending<AppRecipesByAppDetailQuotes, int>((Expression<Func<AppRecipesByAppDetailQuotes, int>>) (x => x.CalculoId)).FirstOrDefaultAsync<AppRecipesByAppDetailQuotes>();
      return byAppDetailQuotes != null ? byAppDetailQuotes.CalculoId + 1 : 1;
    }

    public async Task<List<AppRecipesByAppDetailQuotes>> GetListRecipesByProductCodeVariableCode(int calculoId,string codeProduct,string code)
    {
            var result=  await this._context.AppRecipesByAppDetailQuotes.Where<AppRecipesByAppDetailQuotes>((Expression<Func<AppRecipesByAppDetailQuotes, bool>>) (x => x.CalculoId == calculoId && x.Code.Trim() == code.Trim())).ToListAsync<AppRecipesByAppDetailQuotes>();
            return result;
     }

    public async Task<List<AppRecipesByAppDetailQuotesHistory>> GetListRecipesByProductCodeVariableCodeHistorico(int calculoId, string codeProduct, string code)
    {
            try
            {
                var result = await this._context.AppRecipesByAppDetailQuotesHistory.Where(x => x.CalculoId == calculoId && x.Code.Trim() == code.Trim()).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return null;
            }
    
    }
    }
}
