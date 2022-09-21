using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Rcl007
    {
        public Rcl007()
        {
            Rcl010 = new HashSet<Rcl010>();
        }

        public string IdModulo { get; set; }
        public string NombreModulo { get; set; }
        public string AbreviadoModulo { get; set; }
        public string FlagEliminado { get; set; }

        public virtual ICollection<Rcl010> Rcl010 { get; set; }
    }
}
