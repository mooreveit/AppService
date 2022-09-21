using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PcflatComisionGerente
    {
        public int Id { get; set; }
        public int? IdFlatComision { get; set; }
        public string Gerente { get; set; }
        public string DescripcionCategoria { get; set; }
        public decimal? Porcentaje { get; set; }
        public string NombreGerente { get; set; }
    }
}
