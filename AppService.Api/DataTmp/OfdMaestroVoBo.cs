using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdMaestroVoBo
    {
        public OfdMaestroVoBo()
        {
            OfdVoBoDisenos = new HashSet<OfdVoBoDiseno>();
        }

        public short IdVoBo { get; set; }
        public short IdEstacion { get; set; }
        public short Orden { get; set; }
        public string Instruccion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual ICollection<OfdVoBoDiseno> OfdVoBoDisenos { get; set; }
    }
}
