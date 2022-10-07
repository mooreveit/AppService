using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppOrdenProductoRepeticionRepository : IAppOrdenProductoRepeticionRepository
    {

        private readonly RRDContext _context;

        public AppOrdenProductoRepeticionRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppOrdenProductoRepeticion>> GetAll()
        {

            return await _context.AppOrdenProductoRepeticion.ToListAsync();

        }

        public async Task<List<AppOrdenProductoRepeticion>> GetByCliente(string idCliente)
        {
            try
            {
                var repeticiones = await _context.AppOrdenProductoRepeticion.Where(x => x.IdCliente == idCliente).ToListAsync();

                return repeticiones;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }
        public async Task<List<AppRepeticionClienteProducto>> GetAppRepeticionClienteProductoByCliente(string idCliente)
        {
            try
            {
                var result = await _context.AppRepeticionClienteProducto.Where(x => x.IdCliente == idCliente).ToListAsync();

                return result;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }
        public async Task<List<AppRepeticionClienteNombreForma>> GetAppRepeticionClienteNombreFormaByCliente(string idCliente)
        {
            try
            {
                var result = await _context.AppRepeticionClienteNombreForma.Where(x => x.IdCliente == idCliente).ToListAsync();

                return result;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }

        public async Task<List<AppRepeticionClienteBasica>> GetAppRepeticionClienteBasicaByCliente(string idCliente)
        {
            try
            {
                var result = await _context.AppRepeticionClienteBasica.Where(x => x.IdCliente == idCliente).ToListAsync();

                return result;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }

        public async Task<List<AppRepeticionClienteOpuesta>> GetAppRepeticionClienteOpuestaByCliente(string idCliente)
        {
            try
            {
                var result = await _context.AppRepeticionClienteOpuesta.Where(x => x.IdCliente == idCliente).ToListAsync();

                return result;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }

        public async Task<List<AppRepeticionClientePartes>> GetAppRepeticionClientePartesByCliente(string idCliente)
        {
            try
            {
                var result = await _context.AppRepeticionClientePartes.Where(x => x.IdCliente == idCliente).ToListAsync();

                return result;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }
        public async Task<List<AppRepeticionClienteTintas>> GetAppRepeticionClienteTintasByCliente(string idCliente)
        {
            try
            {
                var result = await _context.AppRepeticionClienteTintas.Where(x => x.IdCliente == idCliente).ToListAsync();

                return result;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }

        public async Task<List<AppRepeticionClientePapelPrimeraParte>> GetAppRepeticionClientePapelPrimeraParteByCliente(string idCliente)
        {
            try
            {
                var result = await _context.AppRepeticionClientePapelPrimeraParte.Where(x => x.IdCliente == idCliente).ToListAsync();

                return result;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }
        public async Task<List<AppRepeticionClientePapelSegundaParte>> GetAppRepeticionClientePapelSegundaParteByCliente(string idCliente)
        {
            try
            {
                var result = await _context.AppRepeticionClientePapelSegundaParte.Where(x => x.IdCliente == idCliente).ToListAsync();

                return result;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }

        public async Task<List<AppRepeticionClientePapelTerceraParte>> GetAppRepeticionClientePapelTerceraParteByCliente(string idCliente)
        {
            try
            {
                var result = await _context.AppRepeticionClientePapelTerceraParte.Where(x => x.IdCliente == idCliente).ToListAsync();

                return result;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }

        public async Task<List<AppRepeticionClientePapelCuartaParte>> GetAppRepeticionClientePapelCuartaParteByCliente(string idCliente)
        {
            try
            {
                var result = await _context.AppRepeticionClientePapelCuartaParte.Where(x => x.IdCliente == idCliente).ToListAsync();

                return result;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }

        public async Task<List<AppRepeticionClientePapelQuintaParte>> GetAppRepeticionClientePapelQuintaParteByCliente(string idCliente)
        {
            try
            {
                var result = await _context.AppRepeticionClientePapelQuintaParte.Where(x => x.IdCliente == idCliente).ToListAsync();

                return result;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }



    }
}
