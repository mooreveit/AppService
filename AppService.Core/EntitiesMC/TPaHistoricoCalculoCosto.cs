using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaHistoricoCalculoCosto
    {
        public decimal Id { get; set; }
        public decimal? IdSolicitud { get; set; }
        public decimal? Documento { get; set; }
        public decimal? OrdenProduccion { get; set; }
        public string Variable { get; set; }
        public string Nombre { get; set; }
        public decimal? Orden { get; set; }
        public decimal? Monto { get; set; }
        public string VariablePadre { get; set; }
    }
}
