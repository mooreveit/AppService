using AppService.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IOfdCotizacionRepository
    {
        IEnumerable<OfdCotizacion> GetAll();
        Task<OfdCotizacion> GetById(long id);
        Task<OfdCotizacion> GetByCotizacion(string id);
        Task Add(OfdCotizacion entity);
        void Update(OfdCotizacion entity);
        Task Delete(string id);

    }
}
