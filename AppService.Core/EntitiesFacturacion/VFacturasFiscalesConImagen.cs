using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class VFacturasFiscalesConImagen
    {
        public int Factura { get; set; }
        public long Orden { get; set; }
        public int? Cliente { get; set; }
        public string RifFact { get; set; }
        public string NombreEmb { get; set; }
        public byte[] Blob { get; set; }
        public DateTime FechaFactura { get; set; }
        public string RifImagen { get; set; }
        public string Vendedor { get; set; }
        public string Oficina { get; set; }
        public string NombreOficina { get; set; }
    }
}
