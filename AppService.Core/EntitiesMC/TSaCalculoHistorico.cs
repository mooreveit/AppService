using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TSaCalculoHistorico
    {
        public decimal Id { get; set; }
        public decimal IdSolicitud { get; set; }
        public int LineaNegocio { get; set; }
        public string IdVariables { get; set; }
        public int Item { get; set; }
        public string Formula { get; set; }
        public decimal? OrdenCalculo { get; set; }
        public decimal? Valor { get; set; }
        public string DescripcionFormula { get; set; }
        public DateTime? FechaCalculo { get; set; }
        public string Orden { get; set; }
        public string Producto { get; set; }
        public string Qry { get; set; }
        public decimal? TiempoEjecucion { get; set; }
        public string TextoError { get; set; }
    }
}
