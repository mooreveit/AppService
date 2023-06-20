using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdCriterioBusquedum
    {
        public OfdCriterioBusquedum()
        {
            OfdAdjuntoCriterios = new HashSet<OfdAdjuntoCriterio>();
            OfdGrupoCriterios = new HashSet<OfdGrupoCriterio>();
        }

        public short IdCriterioBusqueda { get; set; }
        public string CampoBusqueda { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual ICollection<OfdAdjuntoCriterio> OfdAdjuntoCriterios { get; set; }
        public virtual ICollection<OfdGrupoCriterio> OfdGrupoCriterios { get; set; }
    }
}
