using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy012
    {
        public decimal Recnum { get; set; }
        public int NroReporte { get; set; }
        public DateTime? Fecha { get; set; }
        public string Transaccion { get; set; }
        public short Turno { get; set; }
        public long Operador { get; set; }
        public string Usuario { get; set; }
        public short UltimoItem { get; set; }
        public string Actualizar { get; set; }
    }
}
