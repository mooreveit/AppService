using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy390
    {
        public string NroCotizacion { get; set; }
        public int NroPropuesta { get; set; }
        public int CorrelativoCal { get; set; }
        public int IdCalculo { get; set; }
        public decimal? CantMillares { get; set; }
        public decimal? CantFormas { get; set; }
        public decimal? CantImpresiones { get; set; }
        public decimal? ListaUnitario { get; set; }
        public string ListaTotal { get; set; }
        public decimal? RlistaUnitario { get; set; }
    }
}
