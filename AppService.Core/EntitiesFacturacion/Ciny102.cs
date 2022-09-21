using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Ciny102
    {
        public decimal Recnum { get; set; }
        public string Clave { get; set; }
        public long VentaBs { get; set; }
        public long ListaBs { get; set; }
        public long PresupuestoBs { get; set; }
        public long VentaDol { get; set; }
        public long ListaDol { get; set; }
        public long PresupuestoDol { get; set; }
        public DateTime? Fecha { get; set; }
        public string ActionItems { get; set; }
        public string Responsable { get; set; }
        public long PresupBsHoy { get; set; }
        public long PresupDolHoy { get; set; }
        public string Orden { get; set; }
        public decimal Tasa { get; set; }
    }
}
