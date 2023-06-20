using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CreResponsableAprobarExcepcion
    {
        public decimal Id { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? UsuarioModificacion { get; set; }
    }
}
