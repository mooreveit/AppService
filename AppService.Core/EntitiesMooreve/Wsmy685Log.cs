using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy685Log
    {
        public long Recnum { get; set; }
        public long IdPago { get; set; }
        public string Transaccion { get; set; }
        public long Orden { get; set; }
        public string Producto { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoGte { get; set; }
        public decimal MontoGteProducto { get; set; }
        public long FichaGteProducto { get; set; }
        public string Observaciones { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime FechaActualiza { get; set; }
        public bool FlagPagado { get; set; }
        public DateTime? FechaPagado { get; set; }
        public string Accion { get; set; }
    }
}
