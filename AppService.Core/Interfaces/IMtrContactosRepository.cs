using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrContactosRepository
    {

        IEnumerable<MtrContactos> GetAll();
        Task<MtrContactos> GetById(long id);
        Task Add(MtrContactos entity);
        void Update(MtrContactos entity);
        Task Delete(long id);

        Task<List<MtrContactos>> GetByEmailContactosCliente(MtrClienteQueryFilter filter);
        Task<List<MtrContactos>> GetByIdCliente(string idCliente);
    }
}
