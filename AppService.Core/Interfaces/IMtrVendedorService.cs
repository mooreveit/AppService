using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrVendedorService
    {


        Task<IEnumerable<MtrVendedor>> ListVendedoresPorUsuario(MtrVendedorQueryFilter filter);

        MtrVendedor GetById(string id);
        Task<MtrVendedor> GetByIdAsync(string id);
    }
}
