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
    public class CobMatrixMonedaValidaPagoRepository:ICobMatrixMonedaValidaPagoRepository
    {


        private readonly RRDContext _context;

        public CobMatrixMonedaValidaPagoRepository(RRDContext context)
        {
            _context = context;
        }

        public IEnumerable<CobMatrixMonedaValidaPago> GetAll()
        {

            return _context.CobMatrixMonedaValidaPago.AsEnumerable();

        }

        public async Task<CobMatrixMonedaValidaPago> GetById(int id)
        {
            return await _context.CobMatrixMonedaValidaPago.FindAsync(id);
        }

        public async Task Add(CobMatrixMonedaValidaPago entity)
        {
            await _context.CobMatrixMonedaValidaPago.AddAsync(entity);


        }



        public void Update(CobMatrixMonedaValidaPago entity)
        {
            _context.CobMatrixMonedaValidaPago.Update(entity);

        }

        public async Task Delete(int id)
        {
            CobMatrixMonedaValidaPago entity = await GetById(id);
            _context.CobMatrixMonedaValidaPago.Remove(entity);

        }


        public async Task<bool> ExisteMonedaDocumentoMonedaPago(string monedaDocumento,string monedaPago)
        {
            bool result = false;
            var matrix = await _context.CobMatrixMonedaValidaPago.Where(x=>x.MonedaDocumento== monedaDocumento && x.MonedaPago== monedaPago).FirstOrDefaultAsync();

            if (matrix==null)
            {
                result = false;
            }
            else
            {
                result = true;

            }

            return result;

        }



    }
}
