using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Rcl004
    {
        public string IdProceso { get; set; }
        public string IdEmpresa { get; set; }
        public short? IdDia { get; set; }
        public short? PreCierreHabil { get; set; }
        public short? PosCierreHabil { get; set; }
        public DateTime FechaCrea { get; set; }
        public string IdUsuarioCrea { get; set; }
        public string IdUsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string FlagEliminado { get; set; }
        public short? IdFecha { get; set; }

        public virtual Rcl002 IdEmpresaNavigation { get; set; }
        public virtual Rcl010 IdProcesoNavigation { get; set; }
    }
}
