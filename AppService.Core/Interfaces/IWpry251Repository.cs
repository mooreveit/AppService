using AppService.Core.EntitiesMooreve;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWpry251Repository
    {

        Task<List<Wpry251>> GetByCotizacionRenglonPropuesta(string cotizacion, int renglon, int propuesta);
        Task Add(Wpry251 entity);
        void Update(Wpry251 entity);
        Task<List<Wpry251>> GetByCotizacion(string cotizacion);
        void Delete(Wpry251 entity);
        Task<Wpry251> GetByCotizacionRenglonPropuestaVariableParte(string cotizacion, int renglon, int propuesta, string idVariable, int idParte);
        Task<List<Wpry251>> GetListByCotizacionRenglonPropuestaVariableParte(string cotizacion, int renglon, int propuesta, string idVariable, int idParte);
        void DeleteRange(List<Wpry251> entities);


    }
}
