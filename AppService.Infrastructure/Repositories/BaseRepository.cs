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
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly RRDContext _context;
        protected readonly DbSet<T> _entities;

        public BaseRepository(RRDContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }


        public IEnumerable<T> GetAll()
        {
            return  _entities.AsEnumerable();
        }

        public async Task<T> GetById(long id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task Add(T entity)
        {
           await  _entities.AddAsync(entity);
         
 
        }
        


        public void Update(T entity)
        {
            _entities.Update(entity);
         
        }

        public async Task Delete(long id)
        {
            T entity = await GetById(id);
            _entities.Remove(entity);
        
        }

      
    }
}
