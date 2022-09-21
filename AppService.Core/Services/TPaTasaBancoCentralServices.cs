
using AppService.Core.EntitiesMC;
using AppService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class TPaTasaBancoCentralServices: ITPaTasaBancoCentralServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public TPaTasaBancoCentralServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<TPaTasaBancoCentral> GetAll()
        {

            var tasa = _unitOfWork.TPaTasaBancoCentralRepository.GetAll();



            return tasa;
        }

        public async Task<TPaTasaBancoCentral> GetById(decimal id)
        {
            return await _unitOfWork.TPaTasaBancoCentralRepository.GetById(id);
        }
        public async Task<TPaTasaBancoCentral> GetTasaByFecha(DateTime fecha)
        {
            return await _unitOfWork.TPaTasaBancoCentralRepository.GetTasaByFecha(fecha);
        }

      

        public async Task<TPaTasaBancoCentral> Insert(TPaTasaBancoCentral tPaTasaBancoCentral)
        {


            await _unitOfWork.TPaTasaBancoCentralRepository.Add(tPaTasaBancoCentral);
            await _unitOfWork.SaveChangesAsync();
            return tPaTasaBancoCentral;
        }




        public async Task<TPaTasaBancoCentral> Update(TPaTasaBancoCentral tPaTasaBancoCentral)
        {

            var tasa = await GetById(tPaTasaBancoCentral.Id);
            if (tasa == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.TPaTasaBancoCentralRepository.Update(tasa);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(tPaTasaBancoCentral.Id);

        }

        public async Task<bool> Delete(decimal id)
        {
            await _unitOfWork.TPaTasaBancoCentralRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

    }
}
