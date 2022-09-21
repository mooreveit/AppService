using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Rcl001
    {
        public Rcl001()
        {
            Rcl010 = new HashSet<Rcl010>();
        }

        public string IdTipoProceso { get; set; }
        public string NombreTipoProceso { get; set; }
        public string AbreviadoTipoProceso { get; set; }
        public string FlagEliminado { get; set; }

        public virtual ICollection<Rcl010> Rcl010 { get; set; }
    }
}
