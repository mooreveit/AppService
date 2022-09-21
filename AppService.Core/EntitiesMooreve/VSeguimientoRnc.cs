using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VSeguimientoRnc
    {
        public DateTime? FechaIngreso { get; set; }
        public decimal Orden { get; set; }
        public decimal Rnc { get; set; }
        public string SubLinea { get; set; }
        public string Cliente { get; set; }
        public string DescripcionRnc { get; set; }
        public string AspiracionCliente { get; set; }
        public string Estatus { get; set; }
        public string Responsable { get; set; }
        public string Oficina { get; set; }
        public string Vendedor { get; set; }
        public decimal? CostoEstimado { get; set; }
        public string Estacion { get; set; }
        public string AreaResponsable { get; set; }
        public string Causa { get; set; }
    }
}
