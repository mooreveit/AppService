using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy371
    {
        public string NroCotizacion { get; set; }
        public int NroPropuesta { get; set; }
        public int CorrelativoCal { get; set; }
        public string NroCalculo { get; set; }
        public int? NroPartePapel { get; set; }
        public string CodPapel { get; set; }
        public string CodCarbon { get; set; }
        public string Gramaje { get; set; }
        public decimal? Medida { get; set; }
        public decimal? TintaFrente { get; set; }
        public decimal? TintaRespaldo { get; set; }
        public string CarbonSpot { get; set; }
        public int Id { get; set; }
    }
}
