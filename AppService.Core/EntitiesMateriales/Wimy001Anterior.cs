using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy001Anterior
    {
        public int? RecordNumber { get; set; }
        public string Codigo { get; set; }
        public string TipoPapel { get; set; }
        public string Gramaje { get; set; }
        public string Color { get; set; }
        public string Genero { get; set; }
        public string DescMaterial1 { get; set; }
        public string DescMaterial2 { get; set; }
        public string DescCompras1 { get; set; }
        public string DescCompras2 { get; set; }
        public string DescCompras3 { get; set; }
        public string DescVentas1 { get; set; }
        public string DescVentas2 { get; set; }
        public string Unidad { get; set; }
        public string Ctainv { get; set; }
        public string Ctacon { get; set; }
        public decimal? PuntoReorden { get; set; }
        public decimal? Minimo { get; set; }
        public decimal? Maximo { get; set; }
        public DateTime? FUltCompra { get; set; }
        public DateTime? FUltSalida { get; set; }
        public DateTime? FUltEntrada { get; set; }
        public decimal? CtdActual { get; set; }
        public decimal? CtdCompro { get; set; }
        public decimal? UltProveedor { get; set; }
        public string Observacion { get; set; }
        public string Eliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioCreo { get; set; }
        public string UsuarioModif { get; set; }
        public decimal? TiempoEntrega { get; set; }
    }
}
