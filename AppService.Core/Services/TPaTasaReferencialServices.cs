using AppService.Core.EntitiesMC;
using AppService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class TPaTasaReferencialServices: ITPaTasaReferencialServices
    {

        private readonly IUnitOfWork _unitOfWork;
        public TPaTasaReferencialServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<TPaTasaReferencial>> GetAll()
        {

            var tasa = await  _unitOfWork.TPaTasaReferencialRepository.GetAll();
                       
            return tasa;
        }

        public async Task<TPaTasaReferencial> GetById(decimal id)
        {
            return await _unitOfWork.TPaTasaReferencialRepository.GetById(id);
        }
        public async Task<TPaTasaReferencial> GetTasaByFecha(DateTime fecha)
        {
            return await _unitOfWork.TPaTasaReferencialRepository.GetTasaByFecha(fecha);
        }



        public async Task<TPaTasaReferencial> Insert(TPaTasaReferencial tPaTasaReferencial)
        {


            await _unitOfWork.TPaTasaReferencialRepository.Add(tPaTasaReferencial);
            await _unitOfWork.SaveChangesAsync();
            return tPaTasaReferencial;
        }




        public async Task<TPaTasaReferencial> Update(TPaTasaReferencial tPaTasaReferencial)
        {

            var tasa = await GetById(tPaTasaReferencial.Id);
            if (tasa == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.TPaTasaReferencialRepository.Update(tasa);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(tPaTasaReferencial.Id);

        }

        public async Task<bool> Delete(decimal id)
        {
            await _unitOfWork.TPaTasaReferencialRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }



    }
}
