using AppService.Core.DTOs;
using AppService.Core.DTOs.Odoo.Contactos;
using AppService.Core.Entities;
using AppService.Core.EntitiesSap;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrContactosService
    {
        IEnumerable<MtrContactos> GetAll();
        Task<MtrContactos> GetById(long id);
        Task<MtrContactos> Insert(MtrContactos mtrContactos);
        Task<MtrContactos> Update(MtrContactos mtrContactos);
        Task<bool> Delete(long id);

        Task<List<MtrContactos>> GetByIdCliente(MtrClienteQueryFilter filter);
        Task<List<SapTratamientoContacto>> GetAllSapTratamientoContacto();
        Task<List<SapCargoContacto>> GetAllSapCargoContacto();
        Task<List<SapDepartamentoContacto>> GetAllSapDepartamentoContacto();
        Task<List<SapPoderContacto>> GetAllSapPoderContacto();
        Task<ApiResponse<bool>> CreateContactoAlTables(ContactoCreateDto dto);
        Task<ApiResponse<bool>> UpdateContactoAllTables(ContactoUpdateDto dto);
        Task<ApiResponse<ContactoGetDto>> GetContactoById(ContactoQueryFilter filter);


        Task<ApiResponse<OdooContactoGetDto>> OdooCreateContactoAlTables(OdooContactoCreateDto dto);
        Task<ApiResponse<OdooContactoGetDto>> OdooUpdateContactoAllTables(OdooContactoUpdateDto dto);
        Task EniarClientesAOdoo(string region);
        Task UpdateContactosToOdoo(List<MtrCliente> mtrClientes);
        Task UpdateClientesToOdoo(List<MtrCliente> mtrClientes);
        Task UpdateContactosToOdooByListMtrContacto(List<MtrContactos> mtrContactos);
    }
}
