using System;
using AppService.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using AppService.Core.Interfaces;

namespace AppService.Infrastructure.Repositories
{
	public class AppPorcentajeAdicionalM2Repository: IAppPorcentajeAdicionalM2Repository
    {


        private readonly RRDContext _context;

        public AppPorcentajeAdicionalM2Repository(RRDContext context) => this._context = context;

        public async Task<AppPorcentajeAdicionalM2> GetDesdeHasta(decimal cantidad)
        {

            var result = await this._context.AppPorcentajeAdicionalM2.Where(p => cantidad >=p.M2Desde  && cantidad <=p.M2Hasta ).FirstOrDefaultAsync();
            
            return result;
        }


        public async Task<bool> AplicarValorBase(decimal cantidadM2)
        {
            bool result = false;

            try
            {
                //var porcentajes = await this._context.AppPorcentajeAdicionalM2.OrderByDescending(x => x.M2Hasta).FirstOrDefaultAsync();

                var porcentajes = await this._context.AppPorcentajeAdicionalM2.ToListAsync();
                if(porcentajes.Count > 0)
                {
                    var ultimo = porcentajes.OrderByDescending(x => x.M2Hasta).FirstOrDefault();
                    if (cantidadM2 <= ultimo.M2Hasta) result = true;
                }

                
            }
            catch (Exception ex)
            {
                var a = ex.InnerException.Message;
            }

           


            return result;
        }



    }
}

