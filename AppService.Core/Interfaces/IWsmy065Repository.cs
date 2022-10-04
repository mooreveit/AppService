using AppService.Core.EntitiesClientes;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWsmy065Repository
    {

        Task<Wsmy065> GetByRamo(decimal codigo);
        Task<Wsmy064> GetSectorBySector(decimal codigo);
        Task<decimal> GetNextRamo();
        Task<decimal> GetNextSector();
        Task AddSector(Wsmy064 wsmy064);
        Task AddRamo(Wsmy065 wsmy065);
        Csmy003 UpdateCsmy003(Csmy003 csmy003);
        Task<Csmy003> GetClienteCsmy003(string codigo);

    }
}
