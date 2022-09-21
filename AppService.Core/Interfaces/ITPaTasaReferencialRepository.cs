using AppService.Core.EntitiesMC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ITPaTasaReferencialRepository
    {

        Task<List<TPaTasaReferencial>> GetAll();

        Task<TPaTasaReferencial> GetById(decimal id);

        Task Add(TPaTasaReferencial entity);

        void Update(TPaTasaReferencial entity);

        Task Delete(decimal id);

        Task<TPaTasaReferencial> GetTasaByFecha(DateTime fecha);




    }
}
