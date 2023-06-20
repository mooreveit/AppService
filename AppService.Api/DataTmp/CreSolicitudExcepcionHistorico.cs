using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CreSolicitudExcepcionHistorico
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
        public bool SolicitudCerrada { get; set; }
        public DateTime? FechaCompromiso { get; set; }
        public decimal? UsdCotizado { get; set; }
        public string Cotizacion { get; set; }
        public decimal? Orden { get; set; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string IdVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string IdOficina { get; set; }
        public string NombreOficina { get; set; }
        public string IdRegion { get; set; }
        public string NombreRegion { get; set; }
        public decimal Id { get; set; }
    }
}
