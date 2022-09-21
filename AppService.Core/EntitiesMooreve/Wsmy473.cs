using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy473
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal? VolumenVenta { get; set; }
        public decimal? VolumenVentaDol { get; set; }
        public decimal? BsMc { get; set; }
        public string IdCliente { get; set; }
        public string TituloOficina { get; set; }
        public decimal? TotalVenta { get; set; }
        public decimal? TotalMc { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public decimal? TotalVentaDol { get; set; }
    }
}
