using AppService.Core.DTOs;
using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrBancosRepository
    {

        Task<List<MtrBancos>> GetAll();
        Task<MtrBancos> GetById(short id);
        Task<MtrBancos> GetByCodigo(string id);
        Task Add(MtrBancos entity);
        void Update(MtrBancos entity);
        Task Delete(string id);
        Task<List<MtrBancosDto>> GetBancos(string Id);

    }
}
