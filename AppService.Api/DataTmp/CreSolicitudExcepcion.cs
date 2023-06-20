using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CreSolicitudExcepcion
    {
        public decimal SolicitudDeCredito { get; set; }
        public string ObservacionesCredito { get; set; }
        public string ObservacionesAprobador { get; set; }
        public byte[] Imagen { get; set; }
        public string NombreImagen { get; set; }
        public bool? Aprobado { get; set; }
        public bool? Rechazado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioAprobador { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string UsuarioRechazo { get; set; }
        public DateTime? FechaRechazo { get; set; }
        public bool? SolicitudExcepcionPorPago { get; set; }
        public decimal? MontoPagado { get; set; }
        public bool? SolicitudCerrada { get; set; }
        public DateTime? FechaCompromiso { get; set; }
        public string Cotizacion { get; set; }
    }
}
