using AppService.Core.EntitiesMateriales;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWimy001Repository
    {
        Task<List<Wimy001>> GetListByTipoPapelGramaje(string tipoPapel, string gramaje);
        Task<Wimy001> GettByCode(string codigo);
        Task<Wimy002> GettByCodeTipo(string tipo);
    }
}
