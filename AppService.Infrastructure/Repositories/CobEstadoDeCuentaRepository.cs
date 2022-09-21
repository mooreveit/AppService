using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using AppService.Infrastructure.DataMooreve;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class CobEstadoDeCuentaRepository : ICobEstadoDeCuentaRepository
    {

        private readonly RRDContext _context;
      

        public CobEstadoDeCuentaRepository(RRDContext context)
        {
            _context = context;
        

        }

          




        public IEnumerable<CobEstadoDeCuenta> GetAll()
        {

            return _context.CobEstadoDeCuenta.AsEnumerable();

        }
        public async Task<List<IGrouping<string,CobEstadoDeCuenta>>> GetClientesConSaldo()
        {
           
            var estadoCuenta = await _context.CobEstadoDeCuenta.Where(X =>  X.Rpaap != 0).OrderBy(x => x.Id).ToListAsync();
            var groupCliente = estadoCuenta.GroupBy(u => u.IdCliente).ToList();
           
            return groupCliente;

        }
        public async Task<List<CobEstadoDeCuenta>> GetAllDocumentoMadre(string idCliente)
        {
            List<CobEstadoDeCuenta> result = new List<CobEstadoDeCuenta>();

            //var result3 = await(from u in _context.CobEstadoDeCuenta
            //               join ur in _context.CobTransacciones on u.Rpdct equals ur.Transaccion

            //               where u.IdCliente== idCliente && ur.DocumentoMadre == true  
            //               select u).ToListAsync();

            var estadoCuenta = await _context.CobEstadoDeCuenta.Where(X => X.IdCliente.Trim() == idCliente.Trim() && X.Rpaap != 0).OrderBy(x => x.Id).ToListAsync();
            //var estadoCuenta = await _context.CobEstadoDeCuenta.Where(X => X.IdCliente.Trim() == idCliente.Trim() ).OrderBy(x => x.Id).ToListAsync();

            var transacciones = await _context.CobTransacciones.ToListAsync();

            if (estadoCuenta != null)
            {
                foreach (var item in estadoCuenta)
                {
                     CobEstadoDeCuenta estadoCuentaItem = new CobEstadoDeCuenta();
                    var transaccion= transacciones.Where(x => x.Transaccion == item.Rpdct).FirstOrDefault();
                    if (transaccion != null)
                    {
                        if (transaccion.DocumentoMadre)
                        {
                            result.Add(item);
                        }
                    }
                   

                }
            }
            

            return result;

        }

        public async Task<CobEstadoDeCuenta> GetById(decimal id)
        {
            return await _context.CobEstadoDeCuenta.FindAsync(id);
        }

        public async Task<CobEstadoDeCuenta> GetByDocumentoSap(string id)
        {
            return await _context.CobEstadoDeCuenta.Where(x => x.DocumentoSap == id).FirstOrDefaultAsync(); ;
        }

        public async Task Add(CobEstadoDeCuenta entity)
        {
            await _context.CobEstadoDeCuenta.AddAsync(entity);


        }

        public void Update(CobEstadoDeCuenta entity)
        {
            _context.CobEstadoDeCuenta.Update(entity);

        }
     

    }
}
