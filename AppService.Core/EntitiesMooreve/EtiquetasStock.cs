using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class EtiquetasStock
    {
        public long IdRegistro { get; set; }
        public decimal RecNumDocumento { get; set; }
        public int Documento { get; set; }
        public long Orden { get; set; }
        public string CodigoProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal ValorIva { get; set; }
        public decimal TotalBolivares { get; set; }
        public DateTime FechaCalculo { get; set; }
        public decimal CantidadUsuario { get; set; }
        public decimal PrecioUnidadUsuario { get; set; }
        public decimal PorcentajeIvaUsuario { get; set; }
        public decimal ValorIvaUsuario { get; set; }
        public decimal TotalBolivaresUsuario { get; set; }
        public DateTime? FechaCalculoUsuario { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal? RprecioUnidad { get; set; }
        public decimal? RvalorIva { get; set; }
        public decimal? RtotalBolivares { get; set; }
        public decimal? RprecioUnidadUsuario { get; set; }
        public decimal? RvalorIvaUsuario { get; set; }
        public decimal? RtotalBolivaresUsuario { get; set; }
    }
}
