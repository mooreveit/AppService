using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry217
    {
        public decimal Recnum { get; set; }
        public string Origen { get; set; }
        public short Grupo { get; set; }
        public string Tipo { get; set; }
        public int Numero { get; set; }
        public short Mes { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal Costo { get; set; }
        public long Ficha { get; set; }
        public string Dpto { get; set; }
        public short Porcentaje { get; set; }
        public long Orden { get; set; }
        public int NroIq { get; set; }
        public short CausaError { get; set; }
        public decimal? Rcosto { get; set; }
    }
}
