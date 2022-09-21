using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy692
    {
        public decimal Recnum { get; set; }
        public int IdSubCategoria { get; set; }
        public decimal BsDesde { get; set; }
        public decimal BsHasta { get; set; }
        public decimal Porcentaje { get; set; }
        public DateTime FechaActualiza { get; set; }
        public string UsuarioActualiza { get; set; }
        public decimal? RbsDesde { get; set; }
        public decimal? RbsHasta { get; set; }

        public virtual Wsmy437 IdSubCategoriaNavigation { get; set; }
    }
}
