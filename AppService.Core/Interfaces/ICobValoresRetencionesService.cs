using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobValoresRetencionesService
    {
        IEnumerable<CobValoresRetenciones> GetAll();
        Task<CobValoresRetenciones> GetById(long id);
        Task<CobValoresRetenciones> Insert(CobValoresRetenciones cobValoresRetenciones);
        Task<CobValoresRetenciones> Update(CobValoresRetenciones cobValoresRetenciones);
        Task<bool> Delete(long id);


    }
}
