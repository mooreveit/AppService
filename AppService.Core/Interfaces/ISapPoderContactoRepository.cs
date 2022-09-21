using AppService.Core.EntitiesSap;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISapPoderContactoRepository
    {


        Task<List<SapPoderContacto>> GetAll();
        Task<SapPoderContacto> GetById(string id);
        Task<SapPoderContacto> GetByIdDecimal(decimal id);

    }
}
