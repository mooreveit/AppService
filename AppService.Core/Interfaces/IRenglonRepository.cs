using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IRenglonRepository
    {

        Task<List<Wsmy502>> GetAll();

        Task<Wsmy502> GetById(int id);

        Task<List<Wsmy502>> GetByCotizacion(string cotizacion);

        Task<Wsmy502> GetByCotizacionRenglon(string cotizacion, int renglon);

        Task Add(Wsmy502 entity);

        Task Update(Wsmy502 entity);

        Task Delete(string cotizacion, int renglon);

        Task<Wsmy502> GetByCotizacionProducto(string cotizacion, string producto);

    }
}
