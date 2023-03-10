using AppService.Core.EntitiesFacturacion;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.DataFacturacion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Winy243Repository : IWiny243Repository
    {

        private readonly FacturacionContext _context;

        public Winy243Repository(FacturacionContext context)
        {
            _context = context;
        }

        public async Task<Winy243> GetById(decimal id)
        {
            return await _context.Winy243.Where(x => x.Recnum == id).FirstOrDefaultAsync();
        }

        public async Task<Winy243> GetByEstadoMunicipio(string estado, string municipio)
        {
            return await _context.Winy243.Where(x => x.CodigoEstado == estado && x.CodigoMcpo == municipio).FirstOrDefaultAsync();
        }

        public async Task<Winy243> GetByCodigoMunicipio(string municipio)
        {
            return await _context.Winy243.Where(x => x.CodigoMcpo == municipio).FirstOrDefaultAsync();
        }


        public async Task<List<Winy243>> GetAllFilter(MunicipioQueryFilter filter)
        {

            List<Winy243> result = new List<Winy243>();
            var pageSize = 1000;

            if (filter.SearchText.Trim().Length == 0)
            {

                result = await _context.Winy243.Take(pageSize).ToListAsync();
            }
            else
            {
                result = await _context.Winy243.Where(x => x.NombreEstado.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()) || x.DescMunicipio.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()) || x.CapitalMcpo.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())).Take(pageSize).ToListAsync();
            }




            return result;

        }

        public async Task<Decimal> GetFleteByIdMunicipo(Decimal id)
        {
            decimal result = 0;

            Winy243 municipio = await GetById(id);
            if (municipio != null)
            {
                result = (decimal)municipio.PorcFlete;
            }


            return result;
        }

    }
}
