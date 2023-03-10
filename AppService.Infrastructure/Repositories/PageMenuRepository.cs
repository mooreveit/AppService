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
    public class PageMenuRepository : IPageMenuRepository
    {

        private readonly RRDContext _context;

        public PageMenuRepository(RRDContext context)
        {
            _context = context;
        }


        public async Task<List<PageMenu>> GetMenuByRole(int role)
        {
            return await _context.PageMenu.Where(x => x.Role == role).ToListAsync();
        }
    }
}
