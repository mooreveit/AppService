using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Wpry090
    {
        public int? RecordNumber { get; set; }
        public decimal? Orden { get; set; }
        public DateTime? FechaRenegocia { get; set; }
        public DateTime? FechaOrden { get; set; }
        public decimal? ListaUniActua { get; set; }
        public decimal? VentaUniActua { get; set; }
        public decimal? ListaDolActua { get; set; }
        public decimal? VentaDolActua { get; set; }
        public decimal? TasaActual { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? TasaRenegocia { get; set; }
        public decimal? ListaDolaresR { get; set; }
        public decimal? VentaDolaresR { get; set; }
        public decimal? ListaUniReneg { get; set; }
        public decimal? VentaUniReneg { get; set; }
        public string Oficina { get; set; }
        public DateTime? FechaAjustada { get; set; }
        public string Usuario { get; set; }
    }
}
