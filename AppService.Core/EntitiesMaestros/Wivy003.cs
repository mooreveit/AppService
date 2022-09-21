using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy003
    {
        public decimal Recnum { get; set; }
        public short Codigo { get; set; }
        public string Descripcion { get; set; }
        public short DiasVcto { get; set; }
        public string AprobCredM { get; set; }
        public string CodJde { get; set; }
        public string Inactivo { get; set; }
        public string RequiereLimiteCredito { get; set; }
        public decimal? PorcRequerido { get; set; }
    }
}
