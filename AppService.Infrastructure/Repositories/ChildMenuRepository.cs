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
    public class ChildMenuRepository: IChildMenuRepository
    {

        private readonly RRDContext _context;

        public ChildMenuRepository(RRDContext context)
        {
            _context = context;
        }


        public async Task<List<ChildMenu>> GetChildMenuByParent(int idMenu)
        {
            return await _context.ChildMenu.Where(x => x.PageMenuId== idMenu).ToListAsync();
        }
    }
}
