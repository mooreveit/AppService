using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWpry240Repository
    {


        Task<List<Wpry240>> GetAll();

        Task<Wpry240> GetByCotizacionRenglonPropuestaParte(string cotizacion, int renglon, int propuesta, int parte);


        Task Add(Wpry240 entity);

        void Update(Wpry240 entity);

        Task Delete(string cotizacion, int renglon, int propuesta, int parte);

        Task<List<Wpry240>> GetByCotizacion(string cotizacion);

        Task<List<Wpry240>> GetByCotizacionRenglon(string cotizacion, int renglon);

    }
}
