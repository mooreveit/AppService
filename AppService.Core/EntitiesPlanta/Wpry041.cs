using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry041
    {
        public decimal Recnum { get; set; }
        public string Estacion { get; set; }
        public string Operador { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Posicion { get; set; }
        public decimal DiasHabiles { get; set; }
        public decimal CtdDias { get; set; }
        public decimal DiasProcTotal { get; set; }
        public decimal CtdProcTotal { get; set; }
    }
}
