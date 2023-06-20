using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class PrcUsuarioProceso
    {
        public decimal Id { get; set; }
        public decimal IdProceso { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual PrcObjetosProceso IdProcesoNavigation { get; set; }
    }
}
