using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWpry241Repository
    {


        Task<List<Wpry241>> GetAll();

        Task<List<Wpry241>> GetByCotizacionRenglonPropuestaParteTinta(string cotizacion, int renglon, int propuesta, int parte, string idTinta);

        Task Add(Wpry241 entity);

        void Update(Wpry241 entity);

        Task Delete(int id);

        Task<List<Wpry241>> GetByCotizacion(string cotizacion);

    }
}
