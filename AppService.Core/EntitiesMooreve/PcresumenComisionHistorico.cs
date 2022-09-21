using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PcresumenComisionHistorico
    {
        public int Id { get; set; }
        public string Periodo { get; set; }
        public int? CodigoOficina { get; set; }
        public string NombreOficina { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string Ficha { get; set; }
        public decimal? Monto { get; set; }
        public string MontoString { get; set; }
        public int? IdPeriodo { get; set; }
        public decimal? Rmonto { get; set; }
    }
}
