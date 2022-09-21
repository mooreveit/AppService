using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public class CobPagosRetencionesQueryFilter
    {

        //Paginacion
        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        //Filtros
        public long IdCobranza { get; set; }
      
    }
}
