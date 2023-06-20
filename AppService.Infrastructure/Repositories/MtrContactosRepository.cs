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
    public class MtrContactosRepository : IMtrContactosRepository
    {

        private readonly RRDContext _context;

        public MtrContactosRepository(RRDContext context)
        {
            _context = context;
        }

        public IEnumerable<MtrContactos> GetAll()
        {

            return _context.MtrContactos.AsEnumerable();

        }

        public async Task<MtrContactos> GetById(long id)
        {
            return await _context.MtrContactos.Where(x => x.IdContacto == id).FirstOrDefaultAsync();
        }
        public async Task<List<MtrContactos>> GetByIdCliente(string idCliente)
        {
            return await _context.MtrContactos.Where(x => x.IdCliente == idCliente && x.Inactivo == false).ToListAsync();
        }

        public async Task Add(MtrContactos entity)
        {
            await _context.MtrContactos.AddAsync(entity);


        }



        public void Update(MtrContactos entity)
        {
            _context.MtrContactos.Update(entity);

        }

        public async Task Delete(long id)
        {
            MtrContactos entity = await GetById(id);
            _context.MtrContactos.Remove(entity);

        }

        public async Task<List<MtrContactos>> GetByEmailContactosCliente(MtrClienteQueryFilter filter)
        {
            if (filter.PageSize == 0)
            {
                filter.PageSize = 20;
            }
            if (filter.PageNumber == 0)
            {
                filter.PageNumber = 1;
            }

            string idCliente = filter.Codigo;

            if (idCliente == "000000")
            {
                idCliente = "0";
            }
            else
            {
                var cliente = await _context.MtrCliente.Where(x => x.Codigo == idCliente).FirstOrDefaultAsync();
                filter.Rif = cliente.NoRegTribut;
            }
            List<MtrContactos> contactos = new List<MtrContactos>();


            if (filter.SearchText.Length > 0)
            {
                contactos = await _context.MtrContactos.Where(x => (x.IdCliente == idCliente || x.IdCliente == filter.Codigo)).OrderByDescending(x => x.FechaCreacion).ToListAsync();
                //contactos = contactos.Where(x => x.Rif == filter.Rif).OrderByDescending(x => x.FechaCreacion).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToList();
                contactos = contactos.Where(x => (x.Cargo.ToLower().Contains(filter.SearchText.Trim().ToLower()) || x.Nombre.ToLower().Contains(filter.SearchText.Trim().ToLower()) || x.Email.ToLower().Contains(filter.SearchText.Trim().ToLower()))).OrderByDescending(x => x.FechaCreacion).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToList();

            }
            else
            {
                contactos = await _context.MtrContactos.Where(x => (x.IdCliente == idCliente || x.IdCliente == filter.Codigo) && (x.Rif == filter.Rif) && (x.Email.Trim().Length > 0)).OrderByDescending(x => x.FechaCreacion).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

            }


            var result = contactos.Where(x => x.Inactivo == false && x.IdContactoOdoo>0 && x.IdClienteOdoo>0).ToList();
            //List<MtrContactos> result = new List<MtrContactos>();


            //MtrContactos resultItem = new MtrContactos();

            //foreach (var item in contactos)
            //{
            //    var resultBusqueda = result.Where(x => x.Email.Trim() == item.Email.Trim()).FirstOrDefault();
            //    if (resultBusqueda == null)
            //    {
            //        result.Add(item);

            //    }

            //}

            return result;
        }



    }
}
