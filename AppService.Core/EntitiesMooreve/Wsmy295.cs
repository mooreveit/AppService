using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy295
    {
        public decimal Id { get; set; }
        public string Responsable { get; set; }
        public string NombreResponsable { get; set; }
        public string TipoResponsable { get; set; }
        public int? PorcResponsabilidad { get; set; }
        public decimal? NroRnc { get; set; }
        public long? Ficha { get; set; }
        public decimal? Costo { get; set; }
        public int? NroReporte { get; set; }
        public decimal? Rcosto { get; set; }
    }
}
