using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy422
    {
        public decimal Id { get; set; }
        public string Codigo { get; set; }
        public string Troquel { get; set; }
        public decimal? MedBasica { get; set; }
        public string MascBasica { get; set; }
        public decimal? MedOpuesta { get; set; }
        public string MascOpuesta { get; set; }
        public decimal? MedOpuesta1 { get; set; }
        public string MascOpuesta1 { get; set; }
        public decimal? CantMinima { get; set; }
        public decimal? CantMaxima { get; set; }
        public decimal? SubEvento { get; set; }
        public decimal? FormulaFijo { get; set; }
        public decimal? RangoVariable { get; set; }
        public string FlagLaser { get; set; }
        public string FlagSintroquel { get; set; }
        public string CodEvento { get; set; }
        public decimal? FormasPaquete { get; set; }
    }
}
