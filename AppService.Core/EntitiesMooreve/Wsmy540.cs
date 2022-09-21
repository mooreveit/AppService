using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy540
    {
        public Wsmy540()
        {
            Wsmy539 = new HashSet<Wsmy539>();
            Wsmy546 = new HashSet<Wsmy546>();
        }

        public int IdPrograma { get; set; }
        public int IdRuta { get; set; }
        public string NobreRuta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IdUsuarioActualiza { get; set; }

        public virtual ICollection<Wsmy539> Wsmy539 { get; set; }
        public virtual ICollection<Wsmy546> Wsmy546 { get; set; }
    }
}
