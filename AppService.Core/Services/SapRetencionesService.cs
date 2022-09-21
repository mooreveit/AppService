using AppService.Core.Entities;
using AppService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class SapRetencionesService: ISapRetencionesService
    {


        private readonly IUnitOfWork _unitOfWork;
        public SapRetencionesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<SapRetenciones> GetAll()
        {

            var sapRetenciones = _unitOfWork.SapRetencionesRepository.GetAll();   


            return sapRetenciones;
        }

        public async Task<SapRetenciones> GetById(decimal id)
        {
            return await _unitOfWork.SapRetencionesRepository.GetById(id);
        }

        public SapRetenciones GetByTranzaccionPorcentaje(double transaccionLegacy,double porcentaje)
        {
            var sapRetenciones = _unitOfWork.SapRetencionesRepository.GetByTranzaccionPorcentaje(transaccionLegacy, porcentaje);
            return sapRetenciones;
            //return _unitOfWork.SapRetencionesRepository.GetAll().Where(x => x.TransaccionLegacy == transaccionLegacy && x.Porcentaje == porcentaje).FirstOrDefault(); 
        }


        public async Task<SapRetenciones> Insert(SapRetenciones sapRetenciones)
        {


            await _unitOfWork.SapRetencionesRepository.Add(sapRetenciones);
            await _unitOfWork.SaveChangesAsync();
            return sapRetenciones;
        }




        public async Task<SapRetenciones> Update(SapRetenciones sapRetenciones)
        {

            var retencion = await GetById(sapRetenciones.Id);
            if (retencion == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.SapRetencionesRepository.Update(retencion);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(sapRetenciones.Id);

        }

        public async Task<bool> Delete(decimal id)
        {
            await _unitOfWork.SapRetencionesRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }




    }
}
