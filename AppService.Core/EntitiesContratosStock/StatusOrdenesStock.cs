using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class StatusOrdenesStock
    {
        public decimal NumCot { get; set; }
        public string NomCliente { get; set; }
        public DateTime? FecGrab { get; set; }
        public DateTime? FechaAprobAdm { get; set; }
        public DateTime? FecAproCob { get; set; }
        public DateTime? FecAproP { get; set; }
        public string FechaFactura { get; set; }
        public string FechaDespacho { get; set; }
        public string FechaRecibCliente { get; set; }
        public string CodVend { get; set; }
        public string Oficina { get; set; }
    }
}
