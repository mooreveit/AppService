using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrClienteRepository
    {
        IEnumerable<MtrCliente> GetAll(string usuario);
        Task<IEnumerable<MtrCliente>> ListClientesPorUsuario(MtrClienteQueryFilter filter);

        MtrCliente GetById(string id);
        Task<MtrCliente> GetByIdAsync(string id);
        Task<List<MtrCliente>> GetAllActive(string region);

        Task AddMtrClienteEnvioOdooLog(MtrClienteEnvioOdooLog entity);
        Task<List<MtrCliente>> ListCliente(MtrClienteQueryFilter filter);
        Task<List<MtrCliente>> GetAllByRegion(string region);

        MtrCliente Update(MtrCliente mtrCliente);
        Task<List<MtrCliente>> GetAllDAyUpdate(int days);
    }
}
