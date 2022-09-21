using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public class CobEstadoCuentaQueryFilter
    {
        //Paginacion
        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        //Filtros
        public string IdCliente { get; set; }
       
        public double Documento { get; set; }

    }
}
