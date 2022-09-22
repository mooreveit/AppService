using AppService.Core.EntitiesMooreve;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWSMY583Repository
    {

        Task<List<Wsmy583>> GetAll();

        Task<Wsmy583> GetById(int id);

        Task<Wsmy583> GetByProductoMedidaMascara(string producto, string medidaMascara);
        Task<Wsmy583> GetByProductoMedidaFraccion(string producto, string medidaFraccion);

        Task Add(Wsmy583 entity);

        void Update(Wsmy583 entity);

        Task Delete(int id);



    }
}
