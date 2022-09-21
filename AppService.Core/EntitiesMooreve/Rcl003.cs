using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Rcl003
    {
        public Rcl003()
        {
            Rcl002 = new HashSet<Rcl002>();
            Rcl006 = new HashSet<Rcl006>();
            Rcl009 = new HashSet<Rcl009>();
        }

        public int IdPais { get; set; }
        public string NombrePais { get; set; }
        public string AbreviadoPais { get; set; }
        public string FlagEliminado { get; set; }

        public virtual ICollection<Rcl002> Rcl002 { get; set; }
        public virtual ICollection<Rcl006> Rcl006 { get; set; }
        public virtual ICollection<Rcl009> Rcl009 { get; set; }
    }
}
