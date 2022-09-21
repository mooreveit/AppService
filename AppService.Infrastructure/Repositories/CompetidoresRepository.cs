using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class CompetidoresRepository: ICompetidoresRepository
    {


        private readonly MooreveContext _context;

        public CompetidoresRepository(MooreveContext context)
        {
            _context = context;
        }

        public async Task<List<Wsmy383>> GetAll()
        {

            return await _context.Wsmy383.ToListAsync();

        }


        public async Task<List<Wsmy383>> GetAllByFilter(CompetidoresQueryFilter filter)
        {
            List<Wsmy383> result = new List<Wsmy383>();


            if (filter.CodCompetidor>0)
            {
                result = await _context.Wsmy383.Where(x => x.CodCompetidor == filter.CodCompetidor).ToListAsync();
            }


            if(filter.SearchText =="")
            {
                result = await _context.Wsmy383.ToListAsync();
            }
            if (filter.SearchText != "")
            {
                result = await _context.Wsmy383.Where(x => x.Nombre.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())).ToListAsync();
            }

            return result;

        }

        public async Task<Wsmy383> GetById(int id)
        {
            return await _context.Wsmy383.FindAsync(id);
        }

        public async Task Add(Wsmy383 entity)
        {
            await _context.Wsmy383.AddAsync(entity);


        }



        public void Update(Wsmy383 entity)
        {
            _context.Wsmy383.Update(entity);

        }

        public async Task Delete(int id)
        {
            Wsmy383 entity = await GetById(id);
            _context.Wsmy383.Remove(entity);

        }


    }
}
