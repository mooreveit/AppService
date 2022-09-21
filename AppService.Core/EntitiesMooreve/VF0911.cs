using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VF0911
    {
        public string Cia { get; set; }
        public string TipoComp { get; set; }
        public string Comprobante { get; set; }
        public string Cta { get; set; }
        public string DescCta { get; set; }
        public string Batch { get; set; }
        public string Monto { get; set; }
        public DateTime? FechaAsentado { get; set; }
        public DateTime? FechaComp { get; set; }
        public DateTime? FechaSistema { get; set; }
        public string Usuario { get; set; }
    }
}
