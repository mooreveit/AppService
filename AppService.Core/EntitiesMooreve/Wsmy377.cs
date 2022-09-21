using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy377
    {
        public string NroCotizacion { get; set; }
        public int NumPropuesta { get; set; }
        public int NumCalculo { get; set; }
        public decimal Orden { get; set; }
        public decimal Id { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public decimal? CantMillar { get; set; }
        public decimal? NumJob { get; set; }
        public string Observ { get; set; }
        public string NumCot { get; set; }
        public string FlagEspecial { get; set; }
        public int? Idcalendario { get; set; }
        public short? Idtitulo { get; set; }
    }
}
