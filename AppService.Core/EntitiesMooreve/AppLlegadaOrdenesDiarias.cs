using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class AppLlegadaOrdenesDiarias
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public DateTime? Dia { get; set; }
        public string DiaChar { get; set; }
        public int? CantOrdenes { get; set; }
        public decimal? BsOrdenes { get; set; }
    }
}
