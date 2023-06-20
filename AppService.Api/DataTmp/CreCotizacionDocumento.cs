using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CreCotizacionDocumento
    {
        public decimal Id { get; set; }
        public string Cotizacion { get; set; }
        public decimal? Documento { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
