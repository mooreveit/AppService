using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy502
    {
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public string CodProducto { get; set; }
        public string Descripcion { get; set; }
        public int? Estatus { get; set; }
        public int? RazonGanadaPerdida { get; set; }
        public int? Competidor { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string UnidadCotizacion { get; set; }
        public string Observaciones { get; set; }
        public string CotizacionDestino { get; set; }
        public int? SubCategoria { get; set; }
        public int? Probabilidad { get; set; }
        public int? TiempoEntrega { get; set; }
        public string ObservacionesGanarPerder { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public decimal? TotalRenglon { get; set; }
        public decimal? TotalGanado { get; set; }
        public decimal? LoteAct { get; set; }
        public decimal Id { get; set; }
        public DateTime? FechaReorden { get; set; }
        public string Combinada { get; set; }
        public short? IdReferenciaProducto { get; set; }
        public short? IdTituloCalendario { get; set; }
        public string EstatusPlanta { get; set; }
        public string FlagActualizado { get; set; }
        public string FlagImpContrato { get; set; }
        public string AlertaCalidad { get; set; }
        public bool? FlagEstimada { get; set; }
        public bool? FlagPortadiseno { get; set; }
        public bool FlagCombinada { get; set; }
        public long IdCombinada { get; set; }
        public long Orden { get; set; }
        public decimal? RtotalRenglon { get; set; }
        public decimal? RtotalGanado { get; set; }
        public decimal? TotalRenglonUsd { get; set; }
        public decimal? TotalGanadoUsd { get; set; }

        public virtual Wsmy501 CotizacionNavigation { get; set; }
    }
}
