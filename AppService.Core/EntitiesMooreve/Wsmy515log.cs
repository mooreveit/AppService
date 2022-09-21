using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy515log
    {
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? TotalPropuesta { get; set; }
        public decimal? PorMc { get; set; }
        public decimal? BsMc { get; set; }
        public int? Estatus { get; set; }
        public string ImpresionTiro { get; set; }
        public string ImpresionRetiro { get; set; }
        public int? Medidas { get; set; }
        public string Papel { get; set; }
        public int? Partes { get; set; }
        public string Respaldo { get; set; }
        public string MedidaTexto { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string Observaciones { get; set; }
        public decimal? LoteAct { get; set; }
        public decimal? CantXCaja { get; set; }
        public float? CantMill { get; set; }
        public decimal? Cajas { get; set; }
        public decimal? CantFormas { get; set; }
        public string IdSolicitud { get; set; }
        public string RecalcularMargen { get; set; }
        public string CotizacionRenglonPropuesta { get; set; }
        public decimal Id { get; set; }
        public short? UnidadCosteo { get; set; }
        public string IdPresentacion { get; set; }
        public string EstatusPlanta { get; set; }
        public decimal? PorcRespSocial { get; set; }
        public decimal? PorcComRegulada { get; set; }
        public decimal? PorcTolerancia { get; set; }
        public string MensajeError { get; set; }
        public bool? FlagAprobado { get; set; }
        public short? CambComposicion { get; set; }
        public decimal? PorMcFinan { get; set; }
        public decimal? PorcMcMinimo { get; set; }
        public bool? FlagVolumen { get; set; }
        public DateTime? FechaEliminado { get; set; }
        public string UsuarioElimino { get; set; }
        public decimal? PorMcBruto { get; set; }
        public decimal? PorcComision { get; set; }
        public decimal? FactorSdf { get; set; }
    }
}
