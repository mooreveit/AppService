using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy666
    {
        public long IdRegistro { get; set; }
        public long IdSolicitudPrecio { get; set; }
        public string CodigoProducto { get; set; }
        public decimal PrecioMinimo { get; set; }
        public decimal Cantidad { get; set; }
        public string Grabacion { get; set; }
        public string PendienteAprobacion { get; set; }
        public string Aprobada { get; set; }
        public string UsuarioAprobo { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string Publicacion { get; set; }
        public string UsuarioPublico { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal IdSolicitud { get; set; }
        public decimal PorcMcBruto { get; set; }
        public string RecalcularMargen { get; set; }
        public int IdSubcategoria { get; set; }
        public string DescSubcategoria { get; set; }
        public decimal? CantXcaja { get; set; }
        public decimal? PrecioXcaja { get; set; }
        public decimal? BsMcBruto { get; set; }
        public decimal? PorcMcFinanciero { get; set; }
        public decimal? BsMcFinanciero { get; set; }
        public decimal? PorcComision { get; set; }
        public decimal? Sdf { get; set; }
        public string Mensaje { get; set; }
        public string Vendedor { get; set; }
        public string Cliente { get; set; }
        public string Email { get; set; }
        public decimal? PorcComisionEspecial { get; set; }
        public decimal? RprecioXcaja { get; set; }
        public decimal? RbsMcBruto { get; set; }
        public decimal? RbsMcFinanciero { get; set; }
    }
}
