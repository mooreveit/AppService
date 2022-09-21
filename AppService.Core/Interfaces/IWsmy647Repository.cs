using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWsmy647Repository
    {
        Task<List<Wsmy647>> GetAll();
        Task<Wsmy647> Get(long idCalculo, int idRuta, int idEstacion);
        Task Add(Wsmy647 entity);
        void Update(Wsmy647 entity);



    }
}
