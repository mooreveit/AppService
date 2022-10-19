using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class VConsumoPapelxLinea
    {
        public DateTime FechaTransac { get; set; }
        public string Transaccion { get; set; }
        public string Ubicacion { get; set; }
        public long Cantidad { get; set; }
        public string Linea { get; set; }
        public string TipoOrden { get; set; }
        public string TipoProducto { get; set; }
    }
}
