using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy489
    {
        public string Producto { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public int AñoPronostico { get; set; }
        public int MesPronostico { get; set; }
        public decimal? VentasPro { get; set; }
        public decimal? VentasReales { get; set; }
        public int? InvIniPro { get; set; }
        public int? InvReal { get; set; }
        public int? TransitoPro { get; set; }
        public int? TransitoReal { get; set; }
    }
}
