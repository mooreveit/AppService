using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy676
    {
        public decimal RecNum { get; set; }
        public DateTime PeriodoDesde { get; set; }
        public DateTime PeriodoHasta { get; set; }
        public int TotalRegPaCxc011 { get; set; }
        public int TotalRegPaCxc012 { get; set; }
        public int RegistrosProcesados { get; set; }
        public bool FlagCorriendo { get; set; }
        public bool FlagHistorico { get; set; }
        public DateTime? FechaHistorico { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
