using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class EstadisticasAprobacionCobranzas
    {
        public decimal NumCot { get; set; }
        public string NomCliente { get; set; }
        public DateTime? FecGrab { get; set; }
        public DateTime? FechaAprobAdm { get; set; }
        public DateTime? FecAproCob { get; set; }
        public string Oficina { get; set; }
        public int? Dias { get; set; }
    }
}
