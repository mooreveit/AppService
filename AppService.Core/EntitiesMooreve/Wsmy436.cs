using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy436
    {
        public Wsmy436()
        {
            Auxiliarcuota = new HashSet<Auxiliarcuota>();
            Wsmy437 = new HashSet<Wsmy437>();
        }

        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public int? IdPrint { get; set; }

        public virtual ICollection<Auxiliarcuota> Auxiliarcuota { get; set; }
        public virtual ICollection<Wsmy437> Wsmy437 { get; set; }
    }
}
