using AppService.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrTipoTransaccionCuentaDestinoRepository
    {

        IEnumerable<MtrTipoTransaccionCuentaDestino> GetAll();

        Task<MtrTipoTransaccionCuentaDestino> GetById(short id);

        Task Add(MtrTipoTransaccionCuentaDestino entity);

        void Update(MtrTipoTransaccionCuentaDestino entity);

        Task Delete(short id);
    }
}
