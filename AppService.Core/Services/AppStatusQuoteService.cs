using AppService.Core.Entities;
using AppService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppStatusQuoteService: IAppStatusQuoteService
    {

        private readonly IUnitOfWork _unitOfWork;
        public AppStatusQuoteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<AppStatusQuote>> GetAll()
        {

            var appStatusQuote = await _unitOfWork.AppStatusQuoteRepository.GetAll();

            return appStatusQuote;
        }

        public async Task<AppStatusQuote> GetById(int id)
        {
            return await _unitOfWork.AppStatusQuoteRepository.GetById(id);
        }

        public async Task<AppStatusQuote> Insert(AppStatusQuote appStatusQuote)
        {


            await _unitOfWork.AppStatusQuoteRepository.Add(appStatusQuote);
            await _unitOfWork.SaveChangesAsync();
            return appStatusQuote;


        }


        public async Task<AppStatusQuote> Update(AppStatusQuote appStatusQuote)
        {
            
            var appStatusQuoteFind = await GetById(appStatusQuote.Id);
            if (appStatusQuoteFind == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.AppStatusQuoteRepository.Update(appStatusQuote);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(appStatusQuote.Id);


        }

        public async Task<bool> Delete(short id)
        {
            await _unitOfWork.AppStatusQuoteRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }


        public async Task<AppStatusQuote> GetStatusPerdida()
        {
            return await _unitOfWork.AppStatusQuoteRepository.GetStatusPerdida();
        }

        public async Task<AppStatusQuote> GetStatusGanada()
        {
            return await _unitOfWork.AppStatusQuoteRepository.GetStatusGanada();
        }


    }
}
