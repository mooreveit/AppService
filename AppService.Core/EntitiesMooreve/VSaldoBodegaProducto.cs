using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VSaldoBodegaProducto
    {
        public short Bodega { get; set; }
        public string Producto { get; set; }
        public int? InvInicial { get; set; }
        public int? Entrada { get; set; }
        public int? Salida { get; set; }
        public int? Saldo { get; set; }
    }
}
