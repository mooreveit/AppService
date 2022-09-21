using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy322
    {
        public decimal RecordNumber { get; set; }
        public string CodLista { get; set; }
        public string CodEvento { get; set; }
        public string CodSubEvento { get; set; }
        public string NroFormula { get; set; }
        public float? NroFormato1 { get; set; }
        public float? NroFormato2 { get; set; }
        public float? NroFormato3 { get; set; }
        public float? NroFormato4 { get; set; }
        public float? NroFormato5 { get; set; }
        public float? NroFormato6 { get; set; }
        public string CodSeccLista { get; set; }
        public decimal? ValorEvento { get; set; }
        public DateTime? FecValidIni { get; set; }
        public DateTime? FecValidFin { get; set; }
        public string FijoVariable { get; set; }
        public string DescFiVa { get; set; }
        public DateTime? FechaRevision { get; set; }
        public decimal? RvalorEvento { get; set; }
    }
}
