using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Cpry253
    {
        public int IdCalendario { get; set; }
        public int IdTitulo { get; set; }
        public DateTime FechaVigencia { get; set; }
        public short CodOficina { get; set; }
        public short? DiasVentas { get; set; }
        public short? DiasCobranza { get; set; }
        public short? DiasProduccion { get; set; }
    }
}
