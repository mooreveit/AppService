using AppService.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrCondicionPagoService
    {
        Task<List<CondicionPagoDto>> GetAll();

        Task<CondicionPagoDto> GetById(short idCondicionPago);


    }
}
