using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PcrangoCumplimientoCuotaGeneralAñoMesVendedor
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string Vendedor { get; set; }
        public decimal? Desde { get; set; }
        public decimal? Hasta { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? Cobertura { get; set; }
        public bool? EstasAqui { get; set; }
    }
}
