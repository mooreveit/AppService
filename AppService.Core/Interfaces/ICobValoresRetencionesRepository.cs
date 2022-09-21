using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobValoresRetencionesRepository
    {

        IEnumerable<CobValoresRetenciones> GetAll();

        Task<CobValoresRetenciones> GetById(long id);
        Task Add(CobValoresRetenciones entity);
        void Update(CobValoresRetenciones entity);
        Task Delete(long id);

    }
}
