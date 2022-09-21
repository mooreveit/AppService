using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    //nueva
    public class AdjuntosCobranzaFilter
    {        

        //Paginacion
        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        //Filtros
        public long?  Documento { get; set; }
    }
}
