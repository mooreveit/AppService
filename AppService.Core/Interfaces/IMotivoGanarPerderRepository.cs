using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMotivoGanarPerderRepository
    {

        Task<List<Wsmy281>> GetAll();

        Task<List<Wsmy281>> GetAllByCondicion(int codCondicion);

        Task<Wsmy281> GetById(int id);

        Task Add(Wsmy281 entity);

        void Update(Wsmy281 entity);

        Task Delete(int id);



    }
}
