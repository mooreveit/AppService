using AppService.Core.DataContratosStock;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IDatosProductosRepository
    {

        Task<DatosProductos> GetByNumCotProducto(decimal numCot, string producto);

        Task Add(DatosProductos entity);

        void Update(DatosProductos entity);

        Task Delete(decimal numCot, string producto);
        Task DeleteByCotizacion(string cotizacion);


    }
}
