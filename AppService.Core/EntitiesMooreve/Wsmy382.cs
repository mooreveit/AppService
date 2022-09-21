using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy382
    {
        public string NroCotizacion { get; set; }
        public int NroPropuesta { get; set; }
        public int CorrelativoCal { get; set; }
        public int IdPropuesta { get; set; }
        public int IdCalculo { get; set; }
        public DateTime? FechaGrabacion { get; set; }
        public DateTime? FechaPerdGan { get; set; }
        public DateTime? FechaRecotiz { get; set; }
        public int? TipoMotivo { get; set; }
        public int? CodigoMotivo { get; set; }
        public int? CodCompetencia { get; set; }
        public string Observaciones { get; set; }
        public string NumCot { get; set; }
    }
}
