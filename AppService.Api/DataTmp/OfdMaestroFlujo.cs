using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdMaestroFlujo
    {
        public OfdMaestroFlujo()
        {
            OfdMaestroEstacions = new HashSet<OfdMaestroEstacion>();
        }

        public short IdFlujo { get; set; }
        public string NombreFlujo { get; set; }

        public virtual ICollection<OfdMaestroEstacion> OfdMaestroEstacions { get; set; }
    }
}
