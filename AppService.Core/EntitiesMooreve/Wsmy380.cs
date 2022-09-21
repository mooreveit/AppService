using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy380
    {
        public int Id { get; set; }
        public string NroCotizacion { get; set; }
        public int NroPropuesta { get; set; }
        public int NroCalculo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? OrigenObserv { get; set; }
        public int? TipoObservacion { get; set; }
        public string CodigoEstatus { get; set; }
        public string Observacion { get; set; }
        public string Usuario { get; set; }
        public string Complemento { get; set; }
        public string NumCot { get; set; }
        public int? TipoRechazo { get; set; }
    }
}
