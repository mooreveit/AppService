using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VKardex
    {
        public decimal Recnum { get; set; }
        public short Bodega { get; set; }
        public string Producto { get; set; }
        public int Comprobante { get; set; }
        public short CodTransaccion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaComprb { get; set; }
        public int? Entrada { get; set; }
        public int? Salida { get; set; }
        public int? Saldo { get; set; }
        public string InventarioInicial { get; set; }
        public short? CodResponsable { get; set; }
    }
}
