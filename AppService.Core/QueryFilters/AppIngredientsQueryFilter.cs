using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public class AppIngredientsQueryFilter
    {
        //Paginacion
        public int PageSize { get; set; }

        public int PageNumber { get; set; }


        //Filtros
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string SearchText { get; set; }
        
    }
}
