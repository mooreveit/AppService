using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobTransaccionesRepository
    {
        IEnumerable<CobTransacciones> GetAll();
        List<CobTransacciones> GetAllEfectivo();
        Task<CobTransacciones> GetById(int id);
        List<CobTransacciones> GetAllImpuesto();
    }
}
