using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
   public interface IWsmy655Repository
    {


        Task<List<Wsmy655>> GetAll();
        Task<Wsmy655> GetById(decimal id);
        Task Add(Wsmy655 entity);
        void Update(Wsmy655 entity);

        Task Delete(decimal id);



    }
}
