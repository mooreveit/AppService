﻿using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class TPrCalculo
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
        public string Calculo { get; set; }
        public string Qry { get; set; }
        public string Orden { get; set; }
        public string Producto { get; set; }
        public decimal? TiempoEjecucion { get; set; }
    }
}
