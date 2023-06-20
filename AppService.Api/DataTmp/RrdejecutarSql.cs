using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class RrdejecutarSql
    {
        public decimal Id { get; set; }
        public string Proceso { get; set; }
        public string QuerySql { get; set; }
        public string Ejecutar { get; set; }
    }
}
