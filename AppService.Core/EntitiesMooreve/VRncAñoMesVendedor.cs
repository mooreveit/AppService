using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VRncAñoMesVendedor
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string CodVendedor { get; set; }
        public decimal? Costos { get; set; }
        public int? Cantidad { get; set; }
        public decimal? ValorLista { get; set; }
    }
}
