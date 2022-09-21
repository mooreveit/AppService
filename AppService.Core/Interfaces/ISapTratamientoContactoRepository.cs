using AppService.Core.EntitiesSap;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISapTratamientoContactoRepository
    {

        Task<List<SapTratamientoContacto>> GetAll();
        Task<SapTratamientoContacto> GetById(short id);

    }
}
