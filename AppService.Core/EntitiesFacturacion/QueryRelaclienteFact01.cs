using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class QueryRelaclienteFact01
    {
        public int Factura { get; set; }
        public int Cliente { get; set; }
        public DateTime FechaFactura { get; set; }
        public string Anulada { get; set; }
        public short MesFactura { get; set; }
        public short AnoFactura { get; set; }
        public DateTime? FApertura { get; set; }
        public int ClienteNuevo { get; set; }
    }
}
