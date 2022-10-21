﻿using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wpry251Repository : IWpry251Repository
    {


        private readonly MooreveContext _context;

        public Wpry251Repository(MooreveContext context)
        {
            _context = context;
        }


        public async Task<List<Wpry251>> GetByCotizacionRenglonPropuesta(string cotizacion, int renglon, int propuesta)
        {

            var wpry251 = await _context.Wpry251.Where(x => x.Cotizacion == cotizacion && x.Renglon == renglon && x.Propuesta == propuesta).ToListAsync();
            return wpry251;

        }

        public async Task<Wpry251> GetByCotizacionRenglonPropuestaVariableParte(string cotizacion, int renglon, int propuesta, string idVariable, int idParte)
        {

            var wpry251 = await _context.Wpry251.Where(x => x.Cotizacion == cotizacion && x.Renglon == renglon && x.Propuesta == propuesta && x.IdVariable.Trim() == idVariable.Trim() && x.IdParte == idParte).FirstOrDefaultAsync();
            return wpry251;

        }

        public async Task<List<Wpry251>> GetByCotizacion(string cotizacion)
        {

            var wpry251 = await _context.Wpry251.Where(x => x.Cotizacion == cotizacion).ToListAsync();
            return wpry251;

        }



        public async Task Add(Wpry251 entity)
        {


            try
            {
                await _context.Wpry251.AddAsync(entity);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException.Message;
                throw;
            }
        }



        public void Update(Wpry251 entity)
        {
            _context.Wpry251.Update(entity);

        }


        public void Delete(Wpry251 entity)
        {
            _context.Wpry251.Remove(entity);

        }
    }
}
