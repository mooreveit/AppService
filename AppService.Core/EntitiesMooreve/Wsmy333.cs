using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy333
    {
        public decimal? CodEventoDesde { get; set; }
        public decimal IdEvento { get; set; }
        public decimal? CodEventoHasta { get; set; }
        public string Descripcion { get; set; }
        public string Formato { get; set; }
        public decimal? CantidadDesde { get; set; }
        public decimal? CantidadHasta { get; set; }
        public string Validacion { get; set; }
        public string RestRegistros { get; set; }
    }
}
