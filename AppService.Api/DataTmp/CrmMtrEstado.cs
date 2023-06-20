using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CrmMtrEstado
    {
        public CrmMtrEstado()
        {
            CrmSeguimientos = new HashSet<CrmSeguimiento>();
        }

        public short IdEstado { get; set; }
        public string NombreEstado { get; set; }
        public bool FlagPendiente { get; set; }
        public bool FlagCerrada { get; set; }

        public virtual ICollection<CrmSeguimiento> CrmSeguimientos { get; set; }
    }
}
