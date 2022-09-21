using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy494
    {
        public int Id { get; set; }
        public string Aplicacion { get; set; }
        public string Evento { get; set; }
        public string RespuestaUsuario { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaHora { get; set; }
        public decimal? Orden { get; set; }
        public string Cotizacion { get; set; }
    }
}
