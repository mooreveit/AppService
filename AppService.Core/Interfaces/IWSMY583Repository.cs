using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
   public  interface IWSMY583Repository
    {

        Task<List<Wsmy583>> GetAll();

        Task<Wsmy583> GetById(int id);

        Task<Wsmy583> GetByProductoMedidaMascara(string producto, string medidaMascara);

        Task Add(Wsmy583 entity);

        void Update(Wsmy583 entity);

        Task Delete(int id);



    }
}
