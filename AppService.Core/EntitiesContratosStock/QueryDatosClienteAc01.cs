using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class QueryDatosClienteAc01
    {
        public decimal NumCot { get; set; }
        public string FecOrd { get; set; }
        public DateTime? FecGrab { get; set; }
        public string CodVend { get; set; }
        public string Nombre { get; set; }
        public string Oficina { get; set; }
        public string NomOficina { get; set; }
        public string CodigoClient { get; set; }
        public string NomCliente { get; set; }
        public string RifFact { get; set; }
        public string DirecFact { get; set; }
        public string RifEnt { get; set; }
        public string DirecEnt { get; set; }
        public string ObserSaca { get; set; }
        public string Estado { get; set; }
        public string NombFact { get; set; }
        public string NomEnt { get; set; }
        public string ObservCliente { get; set; }
        public string TipoPago { get; set; }
        public decimal? DescTipoPago { get; set; }
    }
}
