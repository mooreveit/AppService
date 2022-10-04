using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class FechasErrada
    {
        public decimal? Orden { get; set; }
        public DateTime? Tomada { get; set; }
        public DateTime? Grabada { get; set; }
        public string NombreVendedor { get; set; }
        public decimal? DiasVentas { get; set; }
        public string Oficina { get; set; }
        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public DateTime? FechaAprobAdm { get; set; }
        public decimal? DiasAdministradora { get; set; }
    }
}
