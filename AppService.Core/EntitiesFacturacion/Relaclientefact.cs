using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Relaclientefact
    {
        public int Factura { get; set; }
        public int Cliente { get; set; }
        public DateTime FechaFactura { get; set; }
        public string Anulada { get; set; }
        public short MesFactura { get; set; }
        public short AnoFactura { get; set; }
    }
}
