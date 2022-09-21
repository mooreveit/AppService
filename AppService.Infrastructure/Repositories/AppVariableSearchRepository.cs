// Decompiled with JetBrains decompiler
// Type: AppService.Infrastructure.Repositories.AppVariableSearchRepository
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
  public class AppVariableSearchRepository : IAppVariableSearchRepository
  {
    private readonly RRDContext _context;

    public AppVariableSearchRepository(RRDContext context) => this._context = context;

    public async Task<List<AppVariableSearch>> GetAll() => await this._context.AppVariableSearch.ToListAsync<AppVariableSearch>();

    public async Task<List<AppVariableSearch>> GetAllBySubCategory(
      int appSubCategoryId)
    {
      return await this._context.AppVariableSearch.Where<AppVariableSearch>((Expression<Func<AppVariableSearch, bool>>) (x => x.AppSubCategoryId == (int?) appSubCategoryId)).ToListAsync<AppVariableSearch>();
    }

    public async Task<AppVariableSearch> GetById(int id) => await this._context.AppVariableSearch.FindAsync((object) id);

    public async Task Add(AppVariableSearch entity)
    {
      EntityEntry<AppVariableSearch> entityEntry = await this._context.AppVariableSearch.AddAsync(entity);
    }

    public void Update(AppVariableSearch entity) => this._context.AppVariableSearch.Update(entity);

    public async Task Delete(int id) => this._context.AppVariableSearch.Remove(await this.GetById(id));

    public async Task DeleteBySubCategory(int subCategoryId) => this._context.AppVariableSearch.RemoveRange((IEnumerable<AppVariableSearch>) await this._context.AppVariableSearch.Where<AppVariableSearch>((Expression<Func<AppVariableSearch, bool>>) (x => x.AppSubCategoryId == (int?) subCategoryId)).ToListAsync<AppVariableSearch>());

    public async Task<AppVariableSearch> GetVariableSearchTextBySubcategoryVariableSearchTex(
      int appSubCategoryId,
      int appVariableId,
      string searchText)
    {
      return await this._context.AppVariableSearch.Where<AppVariableSearch>((Expression<Func<AppVariableSearch, bool>>) (x => x.AppSubCategoryId == (int?) appSubCategoryId && x.AppVariableId == (int?) appVariableId && x.SearchText == searchText)).FirstOrDefaultAsync<AppVariableSearch>();
    }
  }
}
