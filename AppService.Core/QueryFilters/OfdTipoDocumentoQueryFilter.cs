using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public  class OfdTipoDocumentoQueryFilter
    {

        public short? IdTipoDocumento { get; set; }
        public short? IdGrupoTipoDocumento { get; set; }
        public string NombreDocumento { get; set; }


    }
}
