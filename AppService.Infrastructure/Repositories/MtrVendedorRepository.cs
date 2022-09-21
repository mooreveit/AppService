using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class MtrVendedorRepository : IMtrVendedorRepository
    {

        private readonly RRDContext _context;

        public MtrVendedorRepository(RRDContext context)
        {
            _context = context;
        }

        public IEnumerable<MtrVendedor> GetAll(string usuario)
        {

            return _context.MtrVendedor.AsEnumerable();

        }


        public async Task<MtrVendedor> GetByIdAsync(string id)
        {
            try
            {
                var vendedor = await _context.MtrVendedor.Where(x => x.Codigo == id.Trim()).FirstOrDefaultAsync();
                return vendedor;
            }
            catch (System.Exception e)
            {
                var msg = e.InnerException.Message;
                return null;

            }

        }

        public MtrVendedor GetById(string id)
        {
            var vendedor = _context.MtrVendedor.Where(x => x.Codigo == id).FirstOrDefault();
            return vendedor;

        }

        public async Task<IEnumerable<MtrVendedor>> ListvendedoresPorUsuario(MtrVendedorQueryFilter filter)
        {
            List<MtrVendedor> result = new List<MtrVendedor>();
            string usuario = filter.Usuario;

            var vendedor = await _context.MtrVendedor.Where(x => x.Codigo == usuario && x.Activo == "X").FirstOrDefaultAsync();
            if (vendedor != null)
            {
                result = await _context.MtrVendedor.Where(x => x.Codigo == usuario && x.Activo == "X" && x.CotizadorPlus == "X").ToListAsync();
            }

            var supervisor = await _context.MtrVendedor.Where(x => x.Supervisor == usuario).FirstOrDefaultAsync();
            if (supervisor != null)
            {

                result = await _context.MtrVendedor.Where(x => x.Supervisor == usuario && x.Activo == "X" && x.CotizadorPlus == "X").ToListAsync();

            }

            var cobRolCobranza = await _context.CobRolCobranza.Where(x => x.IdUsuario == usuario).ToListAsync();
            if (cobRolCobranza.Count > 0)
            {

                foreach (var item in cobRolCobranza)
                {
                    var vend = await _context.MtrVendedor.Where(x => x.Oficina == item.IdOficina && x.Activo == "X" && x.CotizadorPlus == "X").ToListAsync();
                    foreach (var itemvend in vend)
                    {
                        result.Add(itemvend);
                    }

                }
            }

            var usuarioOficina = await _context.MtrUsuarioOficina.Where(x => x.Usuario == usuario).ToListAsync();
            if (usuarioOficina.Count > 0)
            {

                foreach (var item in usuarioOficina)
                {
                    var vend = await _context.MtrVendedor.Where(x => x.Oficina == item.Oficina && x.Activo == "X" && x.CotizadorPlus == "X").ToListAsync();
                    foreach (var itemvend in vend)
                    {
                        result.Add(itemvend);
                    }

                }
            }

            if (filter.Oficina > 0)
            {
                result = await _context.MtrVendedor.Where(x => x.Oficina == filter.Oficina && x.Activo == "X" && x.CotizadorPlus == "X").ToListAsync();
            }

            return result;

        }


    }
}
