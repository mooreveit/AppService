using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CrmVisitaSemana
    {
        public short IdSemana { get; set; }
        public string NombreSemana { get; set; }
        public string AbreviadoSemana { get; set; }
        public short IdFrecuencia { get; set; }

        public virtual CrmVisitaFrecuencium IdFrecuenciaNavigation { get; set; }
    }
}
