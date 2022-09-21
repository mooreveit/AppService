using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VEmbarquesOnLine
    {
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public decimal? TotalVenta { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public decimal? BsMc { get; set; }
        public string Transaccion { get; set; }
    }
}
