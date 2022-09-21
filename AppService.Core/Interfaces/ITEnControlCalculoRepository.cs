
using AppService.Core.EntitiesMC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ITEnControlCalculoRepository
    {

        Task<List<TEnControlCalculo>> GetAll();


        Task<TEnControlCalculo> GetFirst();

        Task<TEnControlCalculo> GetById(int id);

        Task<decimal> GetNextId();

        Task Add(TEnControlCalculo entity);

        void Update(TEnControlCalculo entity);

        Task Delete(int id);




    }
}
