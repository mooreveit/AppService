using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Rangotitulo
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string Titulo { get; set; }
        public decimal? Lista { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Conc { get; set; }
        public decimal? Bsmc { get; set; }
        public decimal? Mc { get; set; }
        public decimal? Ton { get; set; }
        public string Rango { get; set; }
        public int? CantOrdenes { get; set; }
        public decimal? Promedio { get; set; }
    }
}
