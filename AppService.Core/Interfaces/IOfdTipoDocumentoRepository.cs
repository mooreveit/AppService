using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
   public  interface IOfdTipoDocumentoRepository
    {
        IEnumerable<OfdTipoDocumento> GetAll();

        Task<OfdTipoDocumento> GetById(short id);
        Task Add(OfdTipoDocumento entity);
        void Update(OfdTipoDocumento entity);

        Task Delete(short id);
        //Task<OfdTipoDocumento> GetByFileNAme(string fileName);


    }
}
