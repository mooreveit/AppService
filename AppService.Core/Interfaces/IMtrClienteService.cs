using AppService.Core.DTOs;
using AppService.Core.DTOs.Odoo.Clientes;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrClienteService
    {
        Task<IEnumerable<MtrCliente>> ListClientesPorUsuario(MtrClienteQueryFilter filter);
        MtrCliente GetById(string id);
        Task<MtrCliente> GetByIdAsync(string id);
        Task<List<MtrDireccionesDto>> GetDireccionestDtoByCodigo(string codigo);
        Task<MtrDireccionesDto> GetDireccionestDtoById(decimal id);
        Task<ApiResponse<OdooClienteTipoSectorRamo>> UpdateTipoSectorRamoPorCliente(OdooClienteTipoSectorRamo dto);
        Task OdooActualizarClientes();
    }

}
