using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class TotalXOrden
    {
        public string CodVend { get; set; }
        public DateTime? FecGrab { get; set; }
        public decimal NumCot { get; set; }
        public string CodigoClient { get; set; }
        public string NomCliente { get; set; }
        public double? TotalMillares { get; set; }
        public decimal? TotalLista { get; set; }
        public decimal? TotalVenta { get; set; }
        public decimal? TotalListaDol { get; set; }
        public decimal? TotalVentaDol { get; set; }
        public string Estado { get; set; }
        public DateTime? FecAproCob { get; set; }
        public DateTime? FecAproP { get; set; }
    }
}
