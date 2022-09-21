using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrTipoTransaccionCuentaDestinoService
    {
        IEnumerable<MtrTipoTransaccionCuentaDestino> GetAll();

        Task<MtrTipoTransaccionCuentaDestino> GetById(short id);

        List<MtrTipoTransaccionCuentaDestino> GetByCuentaDestino(int id);

    }
}
