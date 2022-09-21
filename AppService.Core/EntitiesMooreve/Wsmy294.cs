using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy294
    {
        public decimal Id { get; set; }
        public string NroDocumento { get; set; }
        public string Tipo { get; set; }
        public decimal? NroRnc { get; set; }
        public decimal? Monto { get; set; }
        public decimal? PorcRespVtas { get; set; }
        public decimal? CostoVtas { get; set; }
        public decimal? Rmonto { get; set; }
        public decimal? RcostoVtas { get; set; }
    }
}
