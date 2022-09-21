using AppService.Core.Entities;
using AppService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class CobTransaccionesService: ICobTransaccionesService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CobTransaccionesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<CobTransacciones> GetAll()
        {
            return _unitOfWork.CobTransaccionesRepository.GetAllEfectivo();
        }

        public async Task<CobTransacciones> GetById(int id)
        {
            return await _unitOfWork.CobTransaccionesRepository.GetById(id);
        }
        public List<CobTransacciones> GetAllImpuesto()
        {
            return _unitOfWork.CobTransaccionesRepository.GetAllImpuesto();
        }
        
    }
}
