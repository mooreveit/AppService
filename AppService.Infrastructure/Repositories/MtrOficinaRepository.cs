using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class MtrOficinaRepository: IMtrOficinaRepository
    {
        private readonly RRDContext _context;

        public MtrOficinaRepository(RRDContext context)
        {
            _context = context;
        }

        public IEnumerable<MtrOficina> GetAll(string usuario)
        {

            return _context.MtrOficina.AsEnumerable();

        }

        public async Task<IEnumerable<MtrOficina>> ListOficinasPorUsuario(MtrOficinaQueryFilter filter)
        {
            List<MtrOficina> result = new List<MtrOficina>();
            string usuario = filter.Usuario;

            var vendedor = await _context.MtrVendedor.Where(x => x.Codigo == usuario).FirstOrDefaultAsync();
            if (vendedor != null)
            {
                result = await _context.MtrOficina.Where(x => x.CodOficina == vendedor.Oficina ).ToListAsync();
            }

            var supervisor = await _context.MtrVendedor.Where(x => x.Supervisor == usuario).FirstOrDefaultAsync();
            if (supervisor != null)
            {

                result = await _context.MtrOficina.Where(x => x.CodOficina == supervisor.Oficina).ToListAsync();

            }

            var cobRolCobranza = await _context.CobRolCobranza.Where(x => x.IdUsuario == usuario).ToListAsync();
            if (cobRolCobranza.Count > 0)
            {

                foreach (var item in cobRolCobranza)
                {
                    var ofi = await _context.MtrOficina.Where(x => x.CodOficina == item.IdOficina ).ToListAsync();
                    foreach (var itemofi in ofi)
                    {
                        result.Add(itemofi);
                    }

                }
            }

            var usuarioOficina = await _context.MtrUsuarioOficina.Where(x => x.Usuario == usuario).ToListAsync();
            if (usuarioOficina.Count > 0)
            {

                foreach (var item in usuarioOficina)
                {
                    var ofi = await _context.MtrOficina.Where(x => x.CodOficina == item.Oficina).ToListAsync();
                    foreach (var itemofi in ofi)
                    {
                        result.Add(itemofi);
                    }

                }
            }

         

            return result;

        }

        public async Task<MtrOficina> GetById(short id)
        {
            return await _context.MtrOficina.Where(x => x.CodOficina == id).FirstOrDefaultAsync();
        }

    }
}
