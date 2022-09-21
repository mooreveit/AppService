using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class CobranzasCcsAprobacionCredito
    {
        public decimal NumCot { get; set; }
        public string Oficina { get; set; }
        public double? VentaTot { get; set; }
        public string Estado { get; set; }
        public string CodigoClient { get; set; }
        public string NomCliente { get; set; }
        public DateTime? FecGrab { get; set; }
        public string CodVend { get; set; }
        public string ClienteNuevo { get; set; }
    }
}
