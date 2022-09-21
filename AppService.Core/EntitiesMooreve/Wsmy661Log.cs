using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy661Log
    {
        public long RecNum { get; set; }
        public int IdCombinada { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public string IdProducto { get; set; }
        public long Orden { get; set; }
        public double IdJdePadre { get; set; }
        public string IdCliente { get; set; }
        public long IdSolicitud { get; set; }
        public decimal IdCalculoMc { get; set; }
        public bool FlagValidadoAdmon { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime FechaActualiza { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
