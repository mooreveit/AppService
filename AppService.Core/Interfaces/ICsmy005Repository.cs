using AppService.Core.EntitiesMaestros;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICsmy005Repository
    {
        Task<Csmy005> GetVendedorByCode(string codigo);
        Task<Csmy005> GetVendedor(string codigo);
    }
}
