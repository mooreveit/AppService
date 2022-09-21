using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Ciny105
    {
        public decimal Recnum { get; set; }
        public short Mes { get; set; }
        public decimal TasaDolar { get; set; }
        public long Orden { get; set; }
        public long PresupOrden { get; set; }
        public string ActionItems { get; set; }
        public string Responsable { get; set; }
    }
}
