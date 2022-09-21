using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class ConsultaOrdenesEtiqPrecioVolumen
    {
        public DateTime? FecGrab { get; set; }
        public decimal NumCot { get; set; }
        public string CodVend { get; set; }
        public string Codigo { get; set; }
        public float? CantMill { get; set; }
        public float? ValorLista { get; set; }
        public float? VentaUnit { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public decimal? PrecLista { get; set; }
        public decimal? Cant { get; set; }
        public decimal? PrecLista1 { get; set; }
        public decimal? Cant1 { get; set; }
        public decimal? PrecLista2 { get; set; }
        public decimal? Cant2 { get; set; }
        public decimal? PrecLista3 { get; set; }
        public decimal? Cant3 { get; set; }
        public decimal? PrecLista4 { get; set; }
        public decimal? Cant4 { get; set; }
        public int? Año { get; set; }
    }
}
