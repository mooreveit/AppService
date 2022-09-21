using AppService.Core.DataContratosStock;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using AppService.Infrastructure.DataContratosStock;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class DatosClienteRepository : IDatosClienteRepository
    {

        private readonly ContratosStockContext _context;
        private readonly MooreveContext _mooreveContext;
        private readonly RRDContext _rrdContext;

        public DatosClienteRepository(ContratosStockContext context, MooreveContext mooreveContext, RRDContext rrdContext)
        {
            _context = context;
            _mooreveContext = mooreveContext;
            _rrdContext = rrdContext;
        }

        public async Task<DatosCliente> GetByCotizacion(string cotizacion)
        {
            return await _context.DatosCliente.Where(x => x.CotizacionGeneral == cotizacion).FirstOrDefaultAsync();
        }

        public async Task Add(DatosCliente entity)
        {
            await _context.DatosCliente.AddAsync(entity);


        }



        public void Update(DatosCliente entity)
        {
            _context.DatosCliente.Update(entity);

        }

        public async Task Delete(string cotizacion)
        {
            DatosCliente entity = await GetByCotizacion(cotizacion);
            _context.DatosCliente.Remove(entity);

        }

        public decimal NextNumCot(string codVendedor)
        {
            decimal result = 0;
            try
            {

                var vendedor = _rrdContext.MtrVendedor.Where(x => x.Codigo == codVendedor).FirstOrDefault();
                if (vendedor != null)
                {
                    var ultimaCotizacion = _context.DatosCliente.Where(x => x.CodVend == codVendedor).OrderByDescending(x => x.NumCot).FirstOrDefault();
                    if (ultimaCotizacion != null)
                    {
                        result = ultimaCotizacion.NumCot + 1;
                    }
                    else
                    {
                        result = 1;
                    }

                }
                else
                {
                    var proxima = vendedor.NroVendedor.ToString() + "0001";
                    result = decimal.Parse(proxima);
                }
                //var query = $"select mooreve.dbo.FnCorrelativoStock('{ codVendedor.Trim()}')";
                //var data = _context.DatosCliente.FromSqlRaw("select mooreve.dbo.FnCorrelativoStock({0})", codVendedor.Trim()).Single();
                //var result = _context.DatosCliente.FromSqlRaw(query).Select(b => new {
                //    NumCot = b.NumCot
                //}).Single();

                return result; //result.NumCot;
            }
            catch (Exception ex)
            {
                var a = ex.InnerException.Message;
                return 0;
            }



        }

    }
}
