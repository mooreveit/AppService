using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdRenglon
    {
        public OfdRenglon()
        {
            OfdPropuesta = new HashSet<OfdPropuestum>();
        }

        public long IdRenglon { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public long IdCotizacion { get; set; }
        public string IdProducto { get; set; }
        public string NombreComercialProducto { get; set; }
        public int IdEstatus { get; set; }
        public int RazonGanadaPerdida { get; set; }
        public int Competidor { get; set; }
        public string Unidad { get; set; }
        public string ObsvRenglon { get; set; }
        public int Probabilidad { get; set; }
        public int DiasEntrega { get; set; }
        public string ObsrGanarPerder { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal TotalRenglon { get; set; }
        public decimal TotalGanado { get; set; }
        public DateTime? FechaReorden { get; set; }
        public short IdTituloCalendario { get; set; }
        public string EstatusPlanta { get; set; }
        public long Orden { get; set; }
        public long OrdenAnterior { get; set; }
        public bool FlagEstimada { get; set; }
        public bool FlagPortadiseno { get; set; }
        public bool FlagCombinada { get; set; }
        public bool FlagFiscal { get; set; }
        public long IdCombinada { get; set; }
        public decimal? RtotalRenglon { get; set; }
        public decimal? RtotalGanado { get; set; }

        public virtual OfdCotizacion IdCotizacionNavigation { get; set; }
        public virtual MtrProducto IdProductoNavigation { get; set; }
        public virtual ICollection<OfdPropuestum> OfdPropuesta { get; set; }
    }
}
