using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppRecipesByAppDetailQuotesRepository
    {
        Task<List<AppRecipesByAppDetailQuotes>> GetAll();

        Task<List<AppRecipesByAppDetailQuotes>> GetAllByCalculoId(
          int calculoId);

        Task<AppRecipesByAppDetailQuotes> GetById(int id);

        Task Add(AppRecipesByAppDetailQuotes entity);

        void Update(AppRecipesByAppDetailQuotes entity);

        Task Delete(int id);

        Decimal TotalCost(int calculoId);

        Task<int> NextId();

        Task<List<AppRecipesByAppDetailQuotes>> GetListRecipesByProductCodeVariableCode(
          int calculoId,
          string codeProduct,
          string code);

        Task AddRange(List<AppRecipesByAppDetailQuotes> entity);

        void DeleteRange(List<AppRecipesByAppDetailQuotes> entity);

        Task AddRangeHistory(List<AppRecipesByAppDetailQuotesHistory> entity);
        Task<List<AppRecipesByAppDetailQuotesHistory>> GetListRecipesByProductCodeVariableCodeHistorico(int calculoId, string codeProduct, string code);
    }
}
