using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy453
    {
        public Wsmy453()
        {
            Wsmy452 = new HashSet<Wsmy452>();
            Wsmy454 = new HashSet<Wsmy454>();
            Wsmy457 = new HashSet<Wsmy457>();
        }

        public int Recnum { get; set; }
        public int? IdTitulo { get; set; }
        public string TituloOficina { get; set; }
        public decimal? PorAfecta { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }

        public virtual ICollection<Wsmy452> Wsmy452 { get; set; }
        public virtual ICollection<Wsmy454> Wsmy454 { get; set; }
        public virtual ICollection<Wsmy457> Wsmy457 { get; set; }
    }
}
