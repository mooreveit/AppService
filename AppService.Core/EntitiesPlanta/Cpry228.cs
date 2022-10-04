using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry228
    {
        public decimal Recnum { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public long Orden { get; set; }
        public int NroIq { get; set; }
        public DateTime FechaEmision { get; set; }
        public int CtdAReoperar { get; set; }
        public short PteAReoperar { get; set; }
        public string AfectaPrensa { get; set; }
        public string AfectaColect { get; set; }
        public string NoCostear { get; set; }
        public string Comentarios { get; set; }
        public short Porcentajes { get; set; }
        public short CausaError { get; set; }
        public string OrigenReporte { get; set; }
        public string OrigenCausa { get; set; }
        public string AccionesPreven { get; set; }
        public short MesConcurso { get; set; }
        public DateTime? FechaCreado { get; set; }
        public DateTime? FechaActua { get; set; }
        public long? CantProgramada { get; set; }
    }
}
