using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CreSolicitudDeCreditoHistorico
    {
        public decimal Id { get; set; }
        public decimal SolicitudDeCredito { get; set; }
        public string Cotizacion { get; set; }
        public decimal? MontoSolicitado { get; set; }
        public decimal? UltimoIdSolicitudAnalisis { get; set; }
        public decimal? IdSolicitudAnalisisAprobacion { get; set; }
        public bool? Aprobada { get; set; }
        public string UsuarioAprobo { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public bool? Rechazado { get; set; }
        public string UsuarioRechazo { get; set; }
        public DateTime? FechaRechazo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public decimal? NroExcepcion { get; set; }
        public string UsuarioAprobador { get; set; }
        public string ObservacionesCredito { get; set; }
        public byte[] ReporteAnalisiCredito { get; set; }
        public string CodCliente { get; set; }
        public bool? EvaluadaAdministradora { get; set; }
        public decimal? RmontoSolicitado { get; set; }
    }
}
