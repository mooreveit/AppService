using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy001
    {
        public decimal Recnum { get; set; }
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
        public long PuntoReorden { get; set; }
        public long Minimo { get; set; }
        public long Maximo { get; set; }
        public DateTime? FUltCompra { get; set; }
        public DateTime? FUltSalida { get; set; }
        public DateTime? FUltEntrada { get; set; }
        public long CtdActual { get; set; }
        public long CtdCompro { get; set; }
        public int UltProveedor { get; set; }
        public string Observacion { get; set; }
        public string Eliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioCreo { get; set; }
        public string UsuarioModif { get; set; }
        public short TiempoEntrega { get; set; }
        public decimal CostoValorado { get; set; }
        public decimal UltimoCosto { get; set; }
        public string EquiListPrec { get; set; }
        public int? Idcategoria { get; set; }
        public string Pplana { get; set; }
        public bool? Critico { get; set; }
        public string GrupoArticulo { get; set; }
        public string CategoriaValoracion { get; set; }
        public string Zonaalmcensap { get; set; }
        public decimal? Calibre { get; set; }
    }
}
