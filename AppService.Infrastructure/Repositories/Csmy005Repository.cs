using AppService.Core.EntitiesMaestros;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMaestros;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Csmy005Repository : ICsmy005Repository
    {
        private readonly IMaestrosContext _context;

        public Csmy005Repository(IMaestrosContext context)
        {
            _context = context;
        }


        public async Task<Csmy005> GetVendedorByCode(string codigo)
        {
            Csmy005 result = new Csmy005();
            try
            {
                result = await _context.Csmy005.Where(x => x.Codigo == codigo).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                return null;
            }



        }

        public async Task<Csmy005> GetVendedor(string codigo)
        {
            Csmy005 result = new Csmy005();
            try
            {
                result = await _context.Csmy005.Where(x => x.Codigo == codigo).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                return null;
            }



        }

        //public Csmy005 GetVendedor(string codigo)
        //{
        //    Csmy005 result = new Csmy005();
        //    try
        //    {
        //        result = _context.Csmy005.Where(x => x.Codigo == codigo.Trim()).FirstOrDefault();
        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        var msg = e.InnerException.Message;
        //        return null;
        //    }



        //}



    }
}
