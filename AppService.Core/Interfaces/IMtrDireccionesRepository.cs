using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrDireccionesRepository
    {

        Task<List<MtrDirecciones>> GetByIdCliente(string idCliente);

        Task<MtrDirecciones> GetById(decimal id);
    }
}
