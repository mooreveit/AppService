using AppService.Core.EntitiesMooreve;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWpry241Repository
    {


        Task<List<Wpry241>> GetAll();

        Task<List<Wpry241>> GetByCotizacionRenglonPropuestaParteTinta(string cotizacion, int renglon, int propuesta, int parte, string idTinta);
        Task<List<Wpry241>> GetByCotizacionRenglonPropuestaParte(string cotizacion, int renglon, int propuesta, int parte);
        Task Add(Wpry241 entity);

        void Update(Wpry241 entity);

        Task Delete(int id);

        Task<List<Wpry241>> GetByCotizacion(string cotizacion);

    }
}
