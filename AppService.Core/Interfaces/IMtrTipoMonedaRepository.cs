using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrTipoMonedaRepository
    {

        IEnumerable<MtrTipoMoneda> GetAll();

        Task<MtrTipoMoneda> GetById(long id);


        Task Add(MtrTipoMoneda entity);

        void Update(MtrTipoMoneda entity);

        Task Delete(long id);

    }
}
