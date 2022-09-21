using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class ConsultaCob
    {
        public decimal NumCot { get; set; }
        public decimal? Orden { get; set; }
        public DateTime? FecGrab { get; set; }
        public string CodigoClient { get; set; }
        public string NomCliente { get; set; }
        public DateTime? FecAproCob { get; set; }
        public string AprobCob { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? CantXCaja { get; set; }
        public float? VentaUnit { get; set; }
        public float? VentaTot { get; set; }
    }
}
