using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy335
    {
        public string NroCotizacion { get; set; }
        public int NumPropuesta { get; set; }
        public int NumCalculo { get; set; }
        public decimal Orden { get; set; }
        public int? TipoLlenado { get; set; }
        public int? TipoMaquina { get; set; }
        public string MarcaMaquina { get; set; }
        public string ModeloMaquina { get; set; }
        public string MarcaDetacher { get; set; }
        public string ModeloDetacher { get; set; }
        public string MarcaDecollator { get; set; }
        public string ModeloDecollator { get; set; }
        public string ObservCe { get; set; }
        public string NumCot { get; set; }
        public decimal? Idmarcaimp { get; set; }
        public decimal? Idmodelimp { get; set; }
        public decimal? Idmarcadtch { get; set; }
        public decimal? Idmodeldtch { get; set; }
        public decimal? Idmarcadecol { get; set; }
        public decimal? Idemodeldecol { get; set; }
    }
}
