using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry229
    {
        public decimal Recnum { get; set; }
        public int Numero { get; set; }
        public long CantidadRodada { get; set; }
        public string Maq { get; set; }
        public DateTime Fecha { get; set; }
        public short Mescon { get; set; }
        public short Parte { get; set; }
        public string Doblado { get; set; }
        public string Contabilizado { get; set; }
        public decimal? Costo { get; set; }
        public string TipoMaquina { get; set; }
        public int PiesRodados { get; set; }
        public string Automatico { get; set; }
        public decimal? Rcosto { get; set; }
    }
}
