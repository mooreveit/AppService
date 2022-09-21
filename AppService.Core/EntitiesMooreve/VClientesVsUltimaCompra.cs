using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VClientesVsUltimaCompra
    {
        public string Codigo { get; set; }
        public double? CodJde { get; set; }
        public string Nombre { get; set; }
        public double? CodJdePadre { get; set; }
        public string Vendedor1 { get; set; }
        public double Saldo { get; set; }
        public DateTime? Ultimacompra { get; set; }
        public int Meses { get; set; }
        public string Flaginactivopadre { get; set; }
        public double Saldopadre { get; set; }
        public string Flag { get; set; }
    }
}
