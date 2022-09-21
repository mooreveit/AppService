using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy486
    {
        public int IdPronostico { get; set; }
        public long Orden { get; set; }
        public long Job { get; set; }
        public short IdMaquina { get; set; }
        public decimal? Dias { get; set; }
        public long? Formas { get; set; }
        public decimal? Pies { get; set; }
        public string FlagListo { get; set; }
        public string FlagFuera { get; set; }
        public short? IdPrensa { get; set; }
        public decimal? PiesPrensa { get; set; }
        public DateTime? FechaPronostico { get; set; }
    }
}
