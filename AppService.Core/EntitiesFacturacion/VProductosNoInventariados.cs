using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class VProductosNoInventariados
    {
        public DateTime FechaFactura { get; set; }
        public string GeneraDespacho { get; set; }
        public string ManejaInv { get; set; }
        public int Factura { get; set; }
        public string Articulo { get; set; }
        public decimal Cantidad { get; set; }
        public int? Comprobante { get; set; }
        public int? Remision { get; set; }
        public int? Comprobante2 { get; set; }
    }
}
