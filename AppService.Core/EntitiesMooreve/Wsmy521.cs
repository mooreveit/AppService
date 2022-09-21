using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy521
    {
        public long Año { get; set; }
        public long Mes { get; set; }
        public long Oficina { get; set; }
        public long AñoEmbarque { get; set; }
        public long MesEmbarque { get; set; }
        public decimal? SaldoInicialCxC { get; set; }
        public decimal? SaldoCxC { get; set; }
        public decimal? Embarques { get; set; }
        public decimal? DiasAcumulados { get; set; }
        public decimal? DiasDelMes { get; set; }
        public decimal? RsaldoInicialCxC { get; set; }
        public decimal? RsaldoCxC { get; set; }
        public decimal? Rembarques { get; set; }
    }
}
