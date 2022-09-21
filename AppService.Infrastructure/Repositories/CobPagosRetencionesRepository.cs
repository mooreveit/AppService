using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class CobPagosRetencionesRepository: ICobPagosRetencionesRepository
    {

        private readonly RRDContext _context;

        public CobPagosRetencionesRepository(RRDContext context)
        {
            _context = context;
        }

        public IEnumerable<CobPagosRetenciones> GetAll()
        {

            return _context.CobPagosRetenciones.AsEnumerable();

        }

        public async Task<CobPagosRetenciones> GetById(long id)
        {
            return await _context.CobPagosRetenciones.FindAsync(id);
        }

        public async Task Add(CobPagosRetenciones entity)
        {
            await _context.CobPagosRetenciones.AddAsync(entity);


        }



        public void Update(CobPagosRetenciones entity)
        {
            _context.CobPagosRetenciones.Update(entity);

        }

        public async Task Delete(long id)
        {
            CobPagosRetenciones entity = await GetById(id);
            _context.CobPagosRetenciones.Remove(entity);

        }

        public List<CobPagosRetenciones> GetByIdCobranzas(long id)
        {
            return _context.CobPagosRetenciones.Where(x => x.IdCobranza == id).ToList();
        }

        public async Task<CobPagosRetenciones> GetByDocumentoSap(string documentoSap)
        {
            return await _context.CobPagosRetenciones.Where(x=> x.DocumentoSap== documentoSap).FirstOrDefaultAsync();
        }

        public decimal GetTotalRetencionesByIdCobranzas(long id)
        {
            return _context.CobPagosRetenciones.Where(x => x.IdCobranza == id).Sum(x=>x.Monto);
          
        }


        public async Task<CobPagosRetenciones> GetByIdCobranzasTransaccion(long idCobranzas,int idTransaccion)
        {

            var qryPago = await _context.CobPagosRetenciones.Where(x => x.IdCobranza == idCobranzas && x.IdTransaccion == idTransaccion).FirstOrDefaultAsync();

            return qryPago;
        }

     
    }
}
