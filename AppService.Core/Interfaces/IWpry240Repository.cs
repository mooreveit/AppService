using AppService.Core.EntitiesMooreve;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWpry240Repository
    {

        Task<List<Csmy011>> GetListTintasActivas();
        Task<List<Wpry240>> GetAll();

        Task<Wpry240> GetByCotizacionRenglonPropuestaParte(string cotizacion, int renglon, int propuesta, int parte);


        Task Add(Wpry240 entity);

        void Update(Wpry240 entity);

        Task Delete(string cotizacion, int renglon, int propuesta, int parte);

        Task<List<Wpry240>> GetByCotizacion(string cotizacion);

        Task<List<Wpry240>> GetByCotizacionRenglon(string cotizacion, int renglon);
        Task<string> GetPapeles(string cotizacion);
        Task<int> GetCantPartes(string cotizacion);
        Task<string> GetPapelesTipo(string cotizacion);

    }
}
