using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Result
    {
        public int? RecordNumber { get; set; }
        public decimal? Orden { get; set; }
        public decimal? NoPartePapel { get; set; }
        public string CodPapel { get; set; }
        public decimal? PesoPapel { get; set; }
        public decimal? CostoPapel { get; set; }
        public string CodCarbon { get; set; }
        public decimal? CostoCarbon { get; set; }
        public decimal? KgPapel { get; set; }
        public decimal? KgCarbon { get; set; }
        public decimal? BsPapel { get; set; }
        public decimal? BsCarbon { get; set; }
        public decimal? MedidaPapel { get; set; }
        public decimal? MedEnt { get; set; }
        public decimal? MedDec { get; set; }
        public decimal? MedNum { get; set; }
        public decimal? Parte { get; set; }
        public decimal? KgSpot { get; set; }
        public decimal? BsSpot { get; set; }
        public decimal? CostoSpot { get; set; }
    }
}
