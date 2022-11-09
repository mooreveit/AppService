using System;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy002
    {
        public decimal Recnum { get; set; }
        public string Tipo { get; set; }
        public string Genero { get; set; }
        public string Descripcion { get; set; }
        public string Eliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModifica { get; set; }
        public int? IdPosicion { get; set; }
        public short? IdCategoriaMc { get; set; }
        public string DESCRIPCION_VENTAS { get; set; }

    }
}
