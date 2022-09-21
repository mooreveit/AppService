using AppService.Core.EntitiesMC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ITPaTasaReferencialServices
    {


        Task<List<TPaTasaReferencial>> GetAll();

        Task<TPaTasaReferencial> GetById(decimal id);

        Task<TPaTasaReferencial> GetTasaByFecha(DateTime fecha);


        Task<TPaTasaReferencial> Insert(TPaTasaReferencial tPaTasaReferencial);


        Task<TPaTasaReferencial> Update(TPaTasaReferencial tPaTasaReferencial);

        Task<bool> Delete(decimal id);





    }
}
