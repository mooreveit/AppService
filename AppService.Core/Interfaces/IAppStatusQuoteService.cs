using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public  interface IAppStatusQuoteService
    {
        Task<List<AppStatusQuote>> GetAll();

        Task<AppStatusQuote> GetById(int id);

        Task<AppStatusQuote> Insert(AppStatusQuote appStatusQuote);

        Task<AppStatusQuote> Update(AppStatusQuote appStatusQuote);

        Task<bool> Delete(short id);

        Task<AppStatusQuote> GetStatusPerdida();

        Task<AppStatusQuote> GetStatusGanada();

    }
}
