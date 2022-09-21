using AppService.Core.CustomEntities;
using AppService.Core.DTOs.SapEstadoCuentaResult;
using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobEstadoCuentaService
    {
        Task<PagedList<CobEstadoDeCuenta>> GetEstadoCuenta(CobEstadoCuentaQueryFilter filters);
        Task<PagedList<CobEstadoCuentaMultiMoneda>> GetEstadoCuentaMultimoneda(CobEstadoCuentaQueryFilter filters);
        Task<CobEstadoDeCuenta> GetEstadoCuentaById(decimal id);
        Task GenerateEstadoCuentaMultimoneda();
    }
}
