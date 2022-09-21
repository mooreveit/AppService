using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWsmy649Repository
    {

        Task<Wsmy649> BuscarRuta(short idSubCategoria, short idOficina);
        Task<int> BuscarAprobador(short idSubCategoria, short idOficina, short idRuta);
    }
}
