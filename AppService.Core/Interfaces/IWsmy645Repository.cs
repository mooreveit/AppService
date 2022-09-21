using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWsmy645Repository
    {

        Task<List<Wsmy645>> GetAll();

        Task<Wsmy645> GetById(decimal id);

        Task Add(Wsmy645 entity);

        void Update(Wsmy645 entity);

        Task Delete(decimal id);

        Task<Wsmy645> EstatusPendiente();

        Task<Wsmy645> EstatusAprobado();




    }
}
