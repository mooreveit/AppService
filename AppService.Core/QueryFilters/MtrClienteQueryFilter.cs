using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public class MtrClienteQueryFilter
    {
        public string Usuario { get; set; }
        public string Oficina { get; set; }
        public string Vendedor { get; set; }
        public string Codigo { get; set; }
        public string SearchText { get; set; }
        public string Rif { get; set; }
        //Paginacion
        public int PageSize { get; set; }

        public int PageNumber { get; set; }
       

    }
}
