using AppService.Core.Entities;
using AppService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class MtrTipoTransaccionCuentaDestinoService: IMtrTipoTransaccionCuentaDestinoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MtrTipoTransaccionCuentaDestinoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }
        public IEnumerable<MtrTipoTransaccionCuentaDestino> GetAll()
        {

            var result = _unitOfWork.MtrTipoTransaccionCuentaDestinoRepository.GetAll();

            return result;
        }


        public async Task<MtrTipoTransaccionCuentaDestino> GetById(short id)
        {
            return await _unitOfWork.MtrTipoTransaccionCuentaDestinoRepository.GetById(id);
        }


        public List<MtrTipoTransaccionCuentaDestino> GetByCuentaDestino(int id)
        {
            var all=  _unitOfWork.MtrTipoTransaccionCuentaDestinoRepository.GetAll();

            List<MtrTipoTransaccionCuentaDestino> result = new List<MtrTipoTransaccionCuentaDestino>();
            result = all.Where(x => x.IdTipoCuentaDestino == id).ToList();


            return result;
        }


    }
}
