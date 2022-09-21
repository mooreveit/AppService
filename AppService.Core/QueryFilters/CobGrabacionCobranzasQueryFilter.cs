using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public class CobGrabacionCobranzasQueryFilter
    {
        //Paginacion
        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        //Filtros
        public long Documento { get; set; }
    }
}
