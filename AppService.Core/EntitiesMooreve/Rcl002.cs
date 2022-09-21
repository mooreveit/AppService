using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Rcl002
    {
        public Rcl002()
        {
            Rcl004 = new HashSet<Rcl004>();
            Rcl008 = new HashSet<Rcl008>();
        }

        public string IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string AbreviadoEmpresa { get; set; }
        public int IdPais { get; set; }
        public string FlagEliminado { get; set; }

        public virtual Rcl003 IdPaisNavigation { get; set; }
        public virtual ICollection<Rcl004> Rcl004 { get; set; }
        public virtual ICollection<Rcl008> Rcl008 { get; set; }
    }
}
