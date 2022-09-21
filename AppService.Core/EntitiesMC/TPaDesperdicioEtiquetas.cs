using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaDesperdicioEtiquetas
    {
        public int Id { get; set; }
        public decimal Tintas { get; set; }
        public decimal? MtsLineales { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
