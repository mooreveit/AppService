using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class MtrTipoTransaccionCuentaDestinoRepository: IMtrTipoTransaccionCuentaDestinoRepository
    {
        private readonly RRDContext _context;

        public MtrTipoTransaccionCuentaDestinoRepository(RRDContext context)
        {
            _context = context;
        }

        public IEnumerable<MtrTipoTransaccionCuentaDestino> GetAll()
        {

            return _context.MtrTipoTransaccionCuentaDestino.AsEnumerable();

        }

        public async Task<MtrTipoTransaccionCuentaDestino> GetById(short id)
        {
            return await _context.MtrTipoTransaccionCuentaDestino.FindAsync(id);
        }

        public async Task Add(MtrTipoTransaccionCuentaDestino entity)
        {
            await _context.MtrTipoTransaccionCuentaDestino.AddAsync(entity);


        }



        public void Update(MtrTipoTransaccionCuentaDestino entity)
        {
            _context.MtrTipoTransaccionCuentaDestino.Update(entity);

        }

        public async Task Delete(short id)
        {
            MtrTipoTransaccionCuentaDestino entity = await GetById(id);
            _context.MtrTipoTransaccionCuentaDestino.Remove(entity);

        }

    }
}
