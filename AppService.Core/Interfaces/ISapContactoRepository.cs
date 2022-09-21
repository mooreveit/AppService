using AppService.Core.EntitiesSap;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISapContactoRepository
    {
        Task<SapContactos> GetById(decimal id);
        Task Add(SapContactos entity);
        void Update(SapContactos entity);
        Task Delete(decimal id);
        Task<decimal> NextId();
        Task<SapContactos> GetByIdContacto(decimal id);


    }
}
