using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PcporcCantidadCategoriasCubiertas
    {
        public int Id { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? PorcentajeGerente { get; set; }
    }
}
