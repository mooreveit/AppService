using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy594
    {
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public string CodProducto { get; set; }
        public decimal PorMcVentasSc { get; set; }
        public string FlagEnviado { get; set; }
        public string FlagPendiente { get; set; }
        public string Aprobado { get; set; }
        public string UsuarioAprueba { get; set; }
        public DateTime? FechaAprueba { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal? PrecioMinimo { get; set; }
    }
}
