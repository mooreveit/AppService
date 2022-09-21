using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VCalendarioEntregaVigente
    {
        public int IdCalendario { get; set; }
        public string Nombretitulo { get; set; }
        public DateTime FechaVigencia { get; set; }
        public string NomOficina { get; set; }
        public short? DiasVentas { get; set; }
        public short? DiasCobranza { get; set; }
        public short? DiasProduccion { get; set; }
        public short? DiasMoore { get; set; }
        public int IdTitulo { get; set; }
        public short CodOficina { get; set; }
    }
}
