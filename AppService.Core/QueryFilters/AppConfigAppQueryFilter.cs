using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public class AppConfigAppQueryFilter
    {



        //Paginacion
        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        //Filtros
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Valor { get; set; }
        public string SearchText { get; set; }

    }
}
