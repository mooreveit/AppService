using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CrmVisitaFrecuencium
    {
        public CrmVisitaFrecuencium()
        {
            CrmVisitaSemanas = new HashSet<CrmVisitaSemana>();
        }

        public short IdFrecuencia { get; set; }
        public string NombreFrecuencia { get; set; }

        public virtual ICollection<CrmVisitaSemana> CrmVisitaSemanas { get; set; }
    }
}
