using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class SubCategoriaEmbarquesVentas
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? IdCategoria { get; set; }
        public string Categoria { get; set; }
        public int? IdSubCategoria { get; set; }
        public string SubCategoria { get; set; }
        public decimal? VentasPie2 { get; set; }
        public decimal? VentaKilos { get; set; }
        public decimal? VentaBolivares { get; set; }
        public decimal? EmbarquesPie2 { get; set; }
        public decimal? EmbarquesKilos { get; set; }
        public decimal? EmbarquesBolivares { get; set; }
        public decimal? EmbarquesDol { get; set; }
        public decimal? VentaDol { get; set; }
        public decimal? RembarquesBolivares { get; set; }
    }
}
