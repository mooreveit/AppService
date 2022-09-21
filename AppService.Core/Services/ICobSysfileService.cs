using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
   public  interface ICobSysfileService
    {
        IEnumerable<CobSysfile> GetAll();
        Task<CobSysfile> GetById(short id);
        Task<CobSysfile> Insert(CobSysfile cobSysfile);
        Task<CobSysfile> Update(CobSysfile cobSysfile);
        Task<bool> Delete(short id);
    }
}
