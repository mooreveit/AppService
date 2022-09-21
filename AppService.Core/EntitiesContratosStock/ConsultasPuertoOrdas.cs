using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class ConsultasPuertoOrdas
    {
        public decimal NumCot { get; set; }
        public decimal? Orden { get; set; }
        public DateTime? FecGrab { get; set; }
        public string FecOrd { get; set; }
        public string CodVend { get; set; }
        public string Oficina { get; set; }
        public string CodigoClient { get; set; }
        public string NomCliente { get; set; }
        public string RifFact { get; set; }
        public string NombFact { get; set; }
        public string DirecFact { get; set; }
        public string RifEnt { get; set; }
        public string NomEnt { get; set; }
        public string DirecEnt { get; set; }
        public string OrdCompra { get; set; }
        public string TipoPago { get; set; }
        public string RboCob { get; set; }
        public string FecCob { get; set; }
        public string ObservCliente { get; set; }
        public string Estado { get; set; }
        public DateTime? FecAproCob { get; set; }
        public string AprobCob { get; set; }
        public string Unidad { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FecAproP { get; set; }
        public string AprobP { get; set; }
        public DateTime? FecDol { get; set; }
        public float? Tasa { get; set; }
        public string SiColetilla { get; set; }
        public string SiIndexacion { get; set; }
        public string Dolares { get; set; }
        public string SinRif { get; set; }
        public string PtoReferencia { get; set; }
        public string ClienteNuevo { get; set; }
        public string AprobCont { get; set; }
        public DateTime? FechaAprobCont { get; set; }
        public string NoAsignacion { get; set; }
        public string AprobAdmin { get; set; }
        public DateTime? FechaAprobAdm { get; set; }
        public string Expr1 { get; set; }
    }
}
