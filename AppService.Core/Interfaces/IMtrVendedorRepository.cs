using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrVendedorRepository
    {

        IEnumerable<MtrVendedor> GetAll(string usuario);

        Task<MtrVendedor> GetByIdAsync(string id);
        MtrVendedor GetById(string id);

        Task<IEnumerable<MtrVendedor>> ListvendedoresPorUsuario(MtrVendedorQueryFilter filter);
    }
}
