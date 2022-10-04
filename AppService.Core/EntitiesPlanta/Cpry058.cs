using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry058
    {
        public decimal Recnum { get; set; }
        public long JobId { get; set; }
        public long Orden { get; set; }
        public int Factura { get; set; }
        public short TipoDoc { get; set; }
        public DateTime? FechaFactura { get; set; }
        public int NoEntrega { get; set; }
        public string LineaProduccio { get; set; }
        public short Pais { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaRecCte { get; set; }
        public DateTime? FechaDespacho { get; set; }
    }
}
