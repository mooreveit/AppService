using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppStatusQuoteRepository
    {


        Task<List<AppStatusQuote>> GetAll();

        Task<AppStatusQuote> GetById(int id);

        Task Add(AppStatusQuote entity);

        void Update(AppStatusQuote entity);

        Task Delete(int id);

        Task<AppStatusQuote> GetStatusGanada();

        Task<AppStatusQuote> GetStatusPerdida();

    }
}
