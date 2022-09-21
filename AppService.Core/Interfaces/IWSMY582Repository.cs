using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
   public  interface IWSMY582Repository
    {

        Task<List<Wsmy582>> GetAll();

        Task<Wsmy582> GetById(int id);

        Task<Wsmy582> GetByProductoMedidaMascara(string producto, string medidaMascara);

        Task Add(Wsmy582 entity);

        void Update(Wsmy582 entity);

        Task Delete(int id);



    }
}
