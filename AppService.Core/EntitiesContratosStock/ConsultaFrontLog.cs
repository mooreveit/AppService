using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class ConsultaFrontLog
    {
        public decimal NumCot { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cajas { get; set; }
        public float? CantMill { get; set; }
        public decimal? CantFormas { get; set; }
        public string AfectaBacklog { get; set; }
        public string Estatus { get; set; }
        public string Oficina { get; set; }
        public float? ListaTot { get; set; }
        public float? VentaTot { get; set; }
    }
}
