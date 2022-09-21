using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IOfdTipoDocumentoService
    {
        IEnumerable<OfdTipoDocumento> GetAll(OfdTipoDocumentoQueryFilter filters);

        Task<OfdTipoDocumento> GetById(short id);

        Task<OfdTipoDocumento> Insert(OfdTipoDocumento ofdTipoDocumento);

        Task<OfdTipoDocumento> Update(OfdTipoDocumento ofdTipoDocumento);

        Task<bool> Delete(short id);


    }
}
