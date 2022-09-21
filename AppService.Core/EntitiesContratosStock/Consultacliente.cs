using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class Consultacliente
    {
        public decimal NumCot { get; set; }
        public decimal? Orden { get; set; }
        public string FecGrab { get; set; }
        public string FecOrd { get; set; }
        public string Dolares { get; set; }
        public string SiIndexacion { get; set; }
        public string SiColetilla { get; set; }
        public float? Tasa { get; set; }
        public DateTime? FecDol { get; set; }
        public string AprobP { get; set; }
        public DateTime? FecAproP { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Unidad { get; set; }
        public string AprobCob { get; set; }
        public string ObservCliente { get; set; }
        public string FecCob { get; set; }
        public string RboCob { get; set; }
        public string TipoPago { get; set; }
        public string OrdCompra { get; set; }
        public string Estado { get; set; }
        public string FecAproCob { get; set; }
        public string RifEnt { get; set; }
        public string DirecEnt { get; set; }
        public string NomEnt { get; set; }
        public string DirecFact { get; set; }
        public string NombFact { get; set; }
        public string RifFact { get; set; }
        public string NomCliente { get; set; }
        public string CodigoClient { get; set; }
        public string Oficina { get; set; }
        public string CodVend { get; set; }
    }
}
