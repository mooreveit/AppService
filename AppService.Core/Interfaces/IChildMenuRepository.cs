using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IChildMenuRepository
    {

        Task<List<ChildMenu>> GetChildMenuByParent(int idMenu);

    }
}
