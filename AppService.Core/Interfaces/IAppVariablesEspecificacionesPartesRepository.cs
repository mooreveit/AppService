using AppService.Core.EntitiesMooreve;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppVariablesEspecificacionesPartesRepository
    {
        Task<List<AppVariablesEspecificacionesPartes>> GetByCodAplicacion(int codAplicacion);
        Task<List<AppVariablesEspecificacionesPartes>> GetByCodAplicacionGeneral(int codAplicacion);
    }
}
