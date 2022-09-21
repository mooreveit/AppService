using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobEstadoDeCuentaMultimonedaRepository
    {

        Task Add(CobEstadoCuentaMultiMoneda entity);
        Task AddList(List<CobEstadoCuentaMultiMoneda> entity);
        void Update(CobEstadoCuentaMultiMoneda entity);

        Task DeleteByCliente(string cliente);

        Task<List<CobEstadoCuentaMultiMoneda>> GetByCliente(string cliente);

        Task<CobEstadoCuentaMultiMoneda> GetByDocumentoSap(string id);

        void UpdateEstadoCuentaMultimoneda();
        void DeleteEstadoCuentaMultimoneda();
    }
}
