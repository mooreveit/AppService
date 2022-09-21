using AppService.Core.Entities;
using AppService.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class CobTipoTransaccionService : ICobTipoTransaccionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CobTipoTransaccionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<CobTipoTransaccion> GetAll()
        {
            return _unitOfWork.CobTipoTransaccionRepository.GetAll().OrderBy(x=> x.NombreTipoTransaccion).ToList();
        }
        public async Task<CobTipoTransaccion> GetById(string id)
        {
            return await _unitOfWork.CobTipoTransaccionRepository.GetById(id);
        }
    }
}
