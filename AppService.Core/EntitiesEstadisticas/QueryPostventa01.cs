using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class QueryPostventa01
    {
        public decimal? CodOficina { get; set; }
        public string NomOficina { get; set; }
        public decimal? Cliente { get; set; }
        public DateTime? FechaCliente { get; set; }
        public string Tipo { get; set; }
    }
}
