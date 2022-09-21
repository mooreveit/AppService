using AppService.Core.EntitiesSap;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISapDepartamentoContactoRepository
    {

        Task<List<SapDepartamentoContacto>> GetAll();
        Task<SapDepartamentoContacto> GetById(string id);
        Task<SapDepartamentoContacto> GetByIdDecimal(decimal id);
        Task<SapDepartamentoContacto> GetByDescripcion(string descripcion);
    }
}
