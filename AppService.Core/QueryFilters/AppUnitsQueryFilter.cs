using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.QueryFilters
{
    public class AppUnitsQueryFilter
    {


        //Paginacion
        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        //Filtros
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Searchtext { get; set; }
        public int producto { get; set; }




    }
}
