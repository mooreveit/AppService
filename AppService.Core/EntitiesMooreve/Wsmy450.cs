using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy450
    {
        public int Recnum { get; set; }
        public string CodVendedor { get; set; }
        public string Vendedor { get; set; }
        public string TeamLeader { get; set; }
        public string Gerente { get; set; }
        public string Oficina { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? ClientesAsignados { get; set; }
        public int? DiasCalleActual { get; set; }
        public decimal? CoberturaClienteTrimestre { get; set; }
        public decimal? CoberturaClienteMes { get; set; }
        public string Clase { get; set; }
        public decimal? RcoberturaClienteTrimestre { get; set; }
        public decimal? RcoberturaClienteMes { get; set; }
        public string Activo { get; set; }
        public int? Meses { get; set; }
    }
}
