using AppService.Core.EntitiesPlanta;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICsmy021Repository
    {
        Task<List<Csmy021>> GetByOrdenAsync(long orden);

    }
}
