using AppService.Core.EntitiesFacturacion;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWiny243Repository
    {

        Task<Winy243> GetByEstadoMunicipio(string estado, string municipio);

        Task<List<Winy243>> GetAllFilter(MunicipioQueryFilter filter);

        Task<Winy243> GetById(decimal id);

        Task<Decimal> GetFleteByIdMunicipo(Decimal id);

        Task<Winy243> GetByCodigoMunicipio(string municipio);
    }
}
