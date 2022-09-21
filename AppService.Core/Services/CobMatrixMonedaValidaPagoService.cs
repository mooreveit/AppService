using AppService.Core.Entities;
using AppService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class CobMatrixMonedaValidaPagoService: ICobMatrixMonedaValidaPagoService
    {


        private readonly IUnitOfWork _unitOfWork;
        public CobMatrixMonedaValidaPagoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<CobMatrixMonedaValidaPago> GetAll()
        {

            var cobMatrixMonedaValidaPago = _unitOfWork.CobMatrixMonedaValidaPagoRepository.GetAll();

            return cobMatrixMonedaValidaPago;
        }

        public async Task<CobMatrixMonedaValidaPago> GetById(int id)
        {
            return await _unitOfWork.CobMatrixMonedaValidaPagoRepository.GetById(id);
        }

        public async Task<CobMatrixMonedaValidaPago> Insert(CobMatrixMonedaValidaPago cobMatrixMonedaValidaPago)
        {


            await _unitOfWork.CobMatrixMonedaValidaPagoRepository.Add(cobMatrixMonedaValidaPago);
            await _unitOfWork.SaveChangesAsync();
            return cobMatrixMonedaValidaPago;
        }




        public async Task<CobMatrixMonedaValidaPago> Update(CobMatrixMonedaValidaPago cobMatrixMonedaValidaPago)
        {

            var monedas = await GetById(cobMatrixMonedaValidaPago.Id);
            if (monedas == null)
            {
                throw new Exception("No existe");
            }

            _unitOfWork.CobMatrixMonedaValidaPagoRepository.Update(cobMatrixMonedaValidaPago);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(cobMatrixMonedaValidaPago.Id);

        }

        public async Task<bool> Delete(int id)
        {
            await _unitOfWork.CobMatrixMonedaValidaPagoRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }



        public async Task<bool> ExisteMonedaDocumentoMonedaPago(string monedaDocumento, string monedaPago)
        {
      
                     

            return await _unitOfWork.CobMatrixMonedaValidaPagoRepository.ExisteMonedaDocumentoMonedaPago(monedaDocumento, monedaPago);

        }

    }
}

