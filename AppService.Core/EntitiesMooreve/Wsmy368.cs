using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy368
    {
        public decimal Id { get; set; }
        public string NroCotizacion { get; set; }
        public string NroCalculo { get; set; }
        public int CorrelativoCal { get; set; }
        public int? NroPropuesta { get; set; }
        public int? NroParte { get; set; }
        public int? NroTinta { get; set; }
        public int? NroImpresion { get; set; }
        public string EventoMatriz { get; set; }
        public string CodigoTinta { get; set; }
        public string Descripcion { get; set; }
        public string TipoTinta { get; set; }
        public string Posicion { get; set; }
        public string CalcRevisado { get; set; }
        public decimal? Orden { get; set; }
        public string NumCot { get; set; }
    }
}
