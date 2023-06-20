using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class TPaFormula
    {
        public decimal Id { get; set; }
        public string IdVariables { get; set; }
        public int LineaNegocio { get; set; }
        public string Formula { get; set; }
        public decimal? OrdenCalculo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string DescripcionFormula { get; set; }
    }
}
