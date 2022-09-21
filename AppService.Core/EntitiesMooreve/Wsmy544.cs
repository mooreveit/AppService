using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy544
    {
        public Wsmy544()
        {
            Wsmy546 = new HashSet<Wsmy546>();
        }

        public int IdPrograma { get; set; }
        public string IdEstatus { get; set; }
        public string NombreEstatus { get; set; }
        public string FlagPrimero { get; set; }

        public virtual ICollection<Wsmy546> Wsmy546 { get; set; }
    }
}
