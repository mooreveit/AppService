using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class ConsultaEtiquetas
    {
        public decimal NumCot { get; set; }
        public DateTime? FecGrab { get; set; }
        public string CodVend { get; set; }
        public string Codigo { get; set; }
        public float? CantMill { get; set; }
        public float? ValorLista { get; set; }
        public float? VentaUnit { get; set; }
    }
}
