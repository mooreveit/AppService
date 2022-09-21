using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWary074Repository
    {

        IEnumerable<Wary074> GetAll();

        Task<Wary074> GetById(short id);

        Task Add(Wary074 entity);

        void Update(Wary074 entity);

        Task Delete(short id);


    }
}
