using AppService.Core.Entities;
using AppService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class CobValoresRetencionesService: ICobValoresRetencionesService
    {

        private readonly IUnitOfWork _unitOfWork;
        public CobValoresRetencionesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<CobValoresRetenciones> GetAll()
        {

            var cobValoresRetenciones = _unitOfWork.CobValoresRetencionesRepository.GetAll();


            return cobValoresRetenciones;
        }

        public async Task<CobValoresRetenciones> GetById(long id)
        {
            return await _unitOfWork.CobValoresRetencionesRepository.GetById(id);
        }

      


        public async Task<CobValoresRetenciones> Insert(CobValoresRetenciones cobValoresRetenciones)
        {


            await _unitOfWork.CobValoresRetencionesRepository.Add(cobValoresRetenciones);
            await _unitOfWork.SaveChangesAsync();
            return cobValoresRetenciones;
        }




        public async Task<CobValoresRetenciones> Update(CobValoresRetenciones cobValoresRetenciones)
        {

            var retencion = await GetById(cobValoresRetenciones.IdTransaccion);
            if (retencion == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.CobValoresRetencionesRepository.Update(retencion);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(cobValoresRetenciones.IdTransaccion);

        }

        public async Task<bool> Delete(long id)
        {
            await _unitOfWork.CobValoresRetencionesRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

    }
}
