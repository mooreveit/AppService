using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatAuditoriaCalculo
    {
        public long CatAuditoriaCalculoId { get; set; }
        public string EntradaCalculo { get; set; }
        public decimal IdCalculo { get; set; }
        public decimal Item { get; set; }
        public string IdVariables { get; set; }
        public string NombreVariable { get; set; }
        public string Formula { get; set; }
        public string Valor { get; set; }
        public decimal OrdenCalculo { get; set; }
        public string Query { get; set; }
        public string Codigo { get; set; }
        public string DescripcionFormula { get; set; }
    }
}
