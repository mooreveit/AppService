using AppService.Core.EntitiesMooreve;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWsmy501BorradosRepository
    {
        Task<List<Wsmy501Borrados>> GetAll();

        Task<Wsmy501Borrados> GetById(decimal id);
        Task Add(Wsmy501Borrados entity);
        void Update(Wsmy501Borrados entity);
        Task Delete(decimal id);

    }
}
