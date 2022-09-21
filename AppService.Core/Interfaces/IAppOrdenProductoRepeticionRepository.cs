using AppService.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppOrdenProductoRepeticionRepository
    {
        Task<List<AppOrdenProductoRepeticion>> GetAll();
        Task<List<AppOrdenProductoRepeticion>> GetByCliente(string idCliente);

    }
}
