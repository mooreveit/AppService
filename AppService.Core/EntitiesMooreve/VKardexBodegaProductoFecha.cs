using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VKardexBodegaProductoFecha
    {
        public short Bodega { get; set; }
        public string Producto { get; set; }
        public DateTime FechaComprb { get; set; }
        public int? Entrada { get; set; }
        public int? Salida { get; set; }
        public int? Saldo { get; set; }
        public short? CodResponsable { get; set; }
    }
}
