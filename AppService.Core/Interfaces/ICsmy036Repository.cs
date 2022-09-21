using AppService.Core.EntitiesMaestros;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICsmy036Repository
    {


        Task<Csmy036> GetByCode(string codigo);

        Task<Civy004> GetCivy004ByCode(string codigo);


    }
}
