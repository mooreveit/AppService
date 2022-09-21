using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaFormulas
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
