using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class OrdenesEnElDia
    {
        public decimal Cotizacion { get; set; }
        public DateTime? FecGrab { get; set; }
        public string FecOrd { get; set; }
        public DateTime? FechaPasada { get; set; }
        public DateTime? FecAproCob { get; set; }
        public string AprobCob { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FecAproP { get; set; }
        public string AprobCont { get; set; }
        public DateTime? FechaAprobCont { get; set; }
        public string AprobAdmin { get; set; }
        public DateTime? FechaAprobAdm { get; set; }
        public string FechaFactura { get; set; }
        public string FechaDespacho { get; set; }
        public string Estado { get; set; }
        public string CodVend { get; set; }
    }
}
