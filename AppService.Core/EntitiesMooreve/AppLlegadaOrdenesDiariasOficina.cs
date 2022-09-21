using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class AppLlegadaOrdenesDiariasOficina
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string Oficina { get; set; }
        public int? CantOrdenes { get; set; }
        public decimal? BsOrdenes { get; set; }
    }
}
