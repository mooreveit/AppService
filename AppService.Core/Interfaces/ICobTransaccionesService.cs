using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobTransaccionesService
    {
        List<CobTransacciones> GetAll();
        Task<CobTransacciones> GetById(int id);
        List<CobTransacciones> GetAllImpuesto();

    }
}
