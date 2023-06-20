using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobValoresRetencionIva
    {
        public int IdRetIva { get; set; }
        public decimal? PorcRetIva { get; set; }
        public bool Inactivo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
