using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class Consultaproducto
    {
        public decimal? NumCot { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? CantXCaja { get; set; }
        public float? CantMill { get; set; }
        public decimal? Cajas { get; set; }
        public decimal? CantFormas { get; set; }
        public float? ValListaDol { get; set; }
        public float? TotVentDol { get; set; }
        public float? TotListDol { get; set; }
        public float? PrecDol { get; set; }
        public float? ValorLista { get; set; }
        public float? ListaTot { get; set; }
        public float? VentaUnit { get; set; }
        public float? VentaTot { get; set; }
        public string Instrucciones { get; set; }
        public string CantDesp { get; set; }
        public string Remision { get; set; }
        public string Estado { get; set; }
    }
}
