using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy381
    {
        public decimal Id { get; set; }
        public decimal? Correlativo { get; set; }
        public string FechaComentario { get; set; }
        public string Comentario { get; set; }
        public string Rol { get; set; }
        public string ComentarioSistema { get; set; }
        public DateTime? FecComentario { get; set; }
        public string Recaudos { get; set; }
    }
}
