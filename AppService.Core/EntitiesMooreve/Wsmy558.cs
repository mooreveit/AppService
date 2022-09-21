using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy558
    {
        public long Id { get; set; }
        public string Lote { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public string Medida { get; set; }
        public string TipoOrden { get; set; }
        public decimal? InventarioTotal { get; set; }
        public decimal? InventarioNacional { get; set; }
        public decimal? InventarioInternacional { get; set; }
        public decimal? InventarioDesconocido { get; set; }
        public string Usuario { get; set; }
        public DateTime? UltimaFecha { get; set; }
    }
}
