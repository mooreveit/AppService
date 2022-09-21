using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobSysfileRepository
    {

        IEnumerable<CobSysfile> GetAll();

        Task<CobSysfile> GetById(short id);

        Task Add(CobSysfile entity);

        void Update(CobSysfile entity);

        Task Delete(short id);



    }
}
