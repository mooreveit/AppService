using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdMaestroPieImprentum
    {
        public OfdMaestroPieImprentum()
        {
            OfdSolicitudDisenos = new HashSet<OfdSolicitudDiseno>();
        }

        public string IdPieImprenta { get; set; }
        public string DescripcionPie { get; set; }

        public virtual ICollection<OfdSolicitudDiseno> OfdSolicitudDisenos { get; set; }
    }
}
