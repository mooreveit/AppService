using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VKilosRodados
    {
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public string DescMaquina { get; set; }
        public string CodPapel { get; set; }
        public string CodCarbon { get; set; }
        public short GramajePap { get; set; }
        public short GramajeCarbon { get; set; }
        public long FormasRodada { get; set; }
        public decimal BasicaDec { get; set; }
        public decimal OpuestaDec { get; set; }
        public short Expr1 { get; set; }
        public short Expr2 { get; set; }
        public decimal KilosConsumido { get; set; }
        public decimal? Kilos1 { get; set; }
        public string IdPapel { get; set; }
        public decimal? KilosFacturados { get; set; }
        public short TipoMaquina { get; set; }
    }
}
