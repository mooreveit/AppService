using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public class MtrOficinaQueryFilter
    {

        public string Usuario { get; set; }

        //Paginacion
        public int PageSize { get; set; }

        public int PageNumber { get; set; }
    }
}
