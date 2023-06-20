using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Wsmy021
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public short NoPartePapel { get; set; }
        public string CodPapel { get; set; }
        public short PesoPapel { get; set; }
        public decimal CostoPapel { get; set; }
        public string CodCarbon { get; set; }
        public decimal CostoCarbon { get; set; }
        public decimal KgPapel { get; set; }
        public decimal KgCarbon { get; set; }
        public decimal BsPapel { get; set; }
        public decimal BsCarbon { get; set; }
        public int MedidaPapel { get; set; }
        public short MedEnt { get; set; }
        public short MedDec { get; set; }
        public short MedNum { get; set; }
        public short Parte { get; set; }
        public decimal KgSpot { get; set; }
        public decimal BsSpot { get; set; }
        public decimal CostoSpot { get; set; }
        public decimal? RcostoPapel { get; set; }
        public decimal? RcostoCarbon { get; set; }
        public decimal? RbsPapel { get; set; }
        public decimal? RbsCarbon { get; set; }
        public decimal? RbsSpot { get; set; }
        public decimal? RcostoSpot { get; set; }
    }
}
