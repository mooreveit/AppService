using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Rcl010
    {
        public Rcl010()
        {
            Rcl004 = new HashSet<Rcl004>();
            Rcl008 = new HashSet<Rcl008>();
        }

        public string IdProceso { get; set; }
        public string NombreProceso { get; set; }
        public string IdTipoProceso { get; set; }
        public string IdModulo { get; set; }
        public string ExigeAdjunto { get; set; }
        public DateTime FechaCrea { get; set; }
        public string IdUsuarioCrea { get; set; }
        public string IdUsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string FlagEliminado { get; set; }

        public virtual Rcl007 IdModuloNavigation { get; set; }
        public virtual Rcl001 IdTipoProcesoNavigation { get; set; }
        public virtual ICollection<Rcl004> Rcl004 { get; set; }
        public virtual ICollection<Rcl008> Rcl008 { get; set; }
    }
}
