using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWsmy406Repository
    {

        Task<List<Wsmy406>> GetAll();

        Task<Wsmy406> GetById(short id);

        Task<Wsmy406> GetByProduct(string producto);

        Task Add(Wsmy406 entity);

        void Update(Wsmy406 entity);

        Task Delete(short id);
        Task<Wsmy406> GetByCodAplicacion(int codAplicacion);


    }
}
