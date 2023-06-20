using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class QueryPostventa02
    {
        public decimal? CodOficina { get; set; }
        public string NomOficina { get; set; }
        public DateTime? FechaCliente { get; set; }
        public int? Despacho { get; set; }
        public int? Contactos { get; set; }
        public string Tipo { get; set; }
    }
}
