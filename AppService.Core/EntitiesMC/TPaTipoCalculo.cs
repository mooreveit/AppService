using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaTipoCalculo
    {
        public decimal Id { get; set; }
        public int TipoCalculo { get; set; }
        public string Descripcion { get; set; }
        public string Promedio { get; set; }
        public string Reposicion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
