using AppService.Core.EntitiesSap;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISapCargoContactoRepository
    {

        Task<List<SapCargoContacto>> GetAll();
        Task<SapCargoContacto> GetById(string id);
        Task<SapCargoContacto> GetByIdDecimal(decimal id);
    }
}
