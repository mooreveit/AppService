using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy585
    {
        public decimal Id { get; set; }
        public decimal IdTipoDocumento { get; set; }
        public string NombreDocumento { get; set; }
        public string Obligatorio { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? IdAplicacion { get; set; }
        public string AfectaExpediente { get; set; }
    }
}
