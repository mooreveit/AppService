using AppService.Core.EntitiesMooreve;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWsmy515BorradosRepository
    {

        Task<List<Wsmy515Borrados>> GetAll();
        Task<Wsmy515Borrados> GetById(decimal id);
        Task Add(Wsmy515Borrados entity);
        void Update(Wsmy515Borrados entity);
        Task Delete(decimal id);

    }
}
