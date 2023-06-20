using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class PrcPlantillaNumeracione
    {
        public long Id { get; set; }
        public int? Mascara { get; set; }
        public int? Prefijo { get; set; }
        public string PrefijoChar { get; set; }
        public decimal? MaximoNumero { get; set; }
        public decimal? Hasta { get; set; }
    }
}
