using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class BacklogFiscalNoFiscal
    {
        public string Fiscal { get; set; }
        public long JobId { get; set; }
        public long Orden { get; set; }
        public string NombreCliente { get; set; }
        public string DescProducto { get; set; }
        public long? CantOrdenada { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? TotalVenta { get; set; }
        public decimal? PorcMcFinansc { get; set; }
        public int? Numeracion { get; set; }
        public DateTime? FechaOrdenAnterior { get; set; }
        public string FlagPlaneac { get; set; }
        public string FlagDiseno { get; set; }
        public string FlagFoto { get; set; }
        public string FlagPrensas { get; set; }
        public string FlagColectora { get; set; }
        public string FlagAcabado { get; set; }
        public string FlagEmbarque { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FecRegVentas { get; set; }
        public string Anulada { get; set; }
        public string ClaseOrden { get; set; }
        public long OrdenAnterior { get; set; }
        public DateTime? FechaUltimaFactura { get; set; }
        public string FlagRetenido { get; set; }
        public string UsuarioRetiene { get; set; }
        public DateTime? FechaRet { get; set; }
    }
}
