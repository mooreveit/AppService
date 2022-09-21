using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWpry229Repository
    {

        Task<List<Wpry229>> GetAll();


        Task<Wpry229> GetById(int id);


        Task Add(Wpry229 entity);


        void Update(Wpry229 entity);

        Task Delete(int id);

        Task<Wpry229> GetByCotizacionRenglonPropuesta(string cotizacion, int renglon, int propuesta);

        Task<List<Wpry229>> GetByCotizacion(string cotizacion);
    }
}
