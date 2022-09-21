using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wity017
    {
        public Wity017()
        {
            Wity018 = new HashSet<Wity018>();
        }

        public string IdPais { get; set; }
        public string NombrePais { get; set; }
        public string FlagEliminado { get; set; }

        public virtual ICollection<Wity018> Wity018 { get; set; }
    }
}
