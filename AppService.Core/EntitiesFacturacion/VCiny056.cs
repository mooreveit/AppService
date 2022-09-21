using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class VCiny056
    {
        public int Factura { get; set; }
        public string Nombre { get; set; }
        public decimal ValorLista { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal OtroGasto1 { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal? Remision { get; set; }
        public string Miscelaneo { get; set; }
        public string CondicionPago { get; set; }
    }
}
