using AppService.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppOrdenProductoRepeticionRepository
    {
        Task<List<AppOrdenProductoRepeticion>> GetAll();
        Task<List<AppOrdenProductoRepeticion>> GetByCliente(string idCliente);
        Task<List<AppRepeticionClienteProducto>> GetAppRepeticionClienteProductoByCliente(string idCliente);
        Task<List<AppRepeticionClienteNombreForma>> GetAppRepeticionClienteNombreFormaByCliente(string idCliente);

        Task<List<AppRepeticionClienteBasica>> GetAppRepeticionClienteBasicaByCliente(string idCliente);
        Task<List<AppRepeticionClienteOpuesta>> GetAppRepeticionClienteOpuestaByCliente(string idCliente);
        Task<List<AppRepeticionClientePartes>> GetAppRepeticionClientePartesByCliente(string idCliente);
        Task<List<AppRepeticionClienteTintas>> GetAppRepeticionClienteTintasByCliente(string idCliente);
        Task<List<AppRepeticionClientePapelPrimeraParte>> GetAppRepeticionClientePapelPrimeraParteByCliente(string idCliente);
        Task<List<AppRepeticionClientePapelSegundaParte>> GetAppRepeticionClientePapelSegundaParteByCliente(string idCliente);
        Task<List<AppRepeticionClientePapelTerceraParte>> GetAppRepeticionClientePapelTerceraParteByCliente(string idCliente);
        Task<List<AppRepeticionClientePapelCuartaParte>> GetAppRepeticionClientePapelCuartaParteByCliente(string idCliente);
        Task<List<AppRepeticionClientePapelQuintaParte>> GetAppRepeticionClientePapelQuintaParteByCliente(string idCliente);
    }
}
