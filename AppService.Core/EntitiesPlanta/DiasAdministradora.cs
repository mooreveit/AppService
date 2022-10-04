using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class DiasAdministradora
    {
        public string Oficina { get; set; }
        public string NombreVendedor { get; set; }
        public decimal? Orden { get; set; }
        public string Cliente { get; set; }
        public DateTime? Tomada { get; set; }
        public DateTime? Grabada { get; set; }
        public DateTime? FechaAprobAdm { get; set; }
        public decimal? DiasAdministradora1 { get; set; }
        public decimal? DiasVentas { get; set; }
        public string Web { get; set; }
    }
}
