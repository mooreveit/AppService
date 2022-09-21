using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy457
    {
        public int Recnum { get; set; }
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public decimal? VolumenVenta { get; set; }
        public decimal? VolumenVentaDol { get; set; }
        public int? RecOficina { get; set; }
        public decimal? BsMc { get; set; }
        public decimal? TotalVentas { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public decimal? RvolumenVenta { get; set; }
        public decimal? RbsMc { get; set; }
        public decimal? RtotalVentas { get; set; }

        public virtual Wsmy453 RecOficinaNavigation { get; set; }
    }
}
