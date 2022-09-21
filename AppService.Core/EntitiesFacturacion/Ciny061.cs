using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Ciny061
    {
        public decimal Recnum { get; set; }
        public short Impuesto { get; set; }
        public string Descripcion { get; set; }
        public string Resumen { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal CuentaContab { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public string CodJde { get; set; }
        public string CodSap { get; set; }
    }
}
