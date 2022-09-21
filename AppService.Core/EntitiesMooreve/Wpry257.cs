using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry257
    {
        public int IdTablaCpj { get; set; }
        public int IdSubCategoria { get; set; }
        public decimal PorcCpjdesde { get; set; }
        public decimal PorcCpjhasta { get; set; }
        public DateTime FechaVigencia { get; set; }
        public bool FlagValidaHasta { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal? PorcCypjgob { get; set; }
        public decimal? PorcCypjgobMinimo { get; set; }
    }
}
