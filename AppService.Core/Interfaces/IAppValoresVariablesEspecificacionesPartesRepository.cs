using AppService.Core.EntitiesMooreve;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppValoresVariablesEspecificacionesPartesRepository
    {
        Task<List<AppValoresVariablesEspecificacionesPartes>> GetListByIdVariable(string idVariable);

    }
}
