using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Encuesta01bk
    {
        public decimal? CodOficina { get; set; }
        public string Oficina { get; set; }
        public string CodVendedor { get; set; }
        public string Vendedor { get; set; }
        public decimal? CodCliente { get; set; }
        public string Cliente { get; set; }
        public string Rif { get; set; }
        public decimal? Orden { get; set; }
        public string Tipo { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Cp1 { get; set; }
        public string Cp2 { get; set; }
        public string Cp3 { get; set; }
        public string Cp4 { get; set; }
        public string ObservacionesCp { get; set; }
        public string Te1 { get; set; }
        public string Te2 { get; set; }
        public string Te3 { get; set; }
        public string Te4 { get; set; }
        public string ObservacionesTe { get; set; }
        public string Sv1 { get; set; }
        public string Sv2 { get; set; }
        public string Sv3 { get; set; }
        public string Sv4 { get; set; }
        public string ObservacionesSv { get; set; }
        public string St1 { get; set; }
        public string St2 { get; set; }
        public string St3 { get; set; }
        public string St4 { get; set; }
        public string ObservacionesSt { get; set; }
        public string ObservacionesGnrl { get; set; }
        public DateTime? FechaEncuesta { get; set; }
        public string Efectiva { get; set; }
        public string EncuestaCliente { get; set; }
        public long? Rnc { get; set; }
        public DateTime? FechaReg { get; set; }
    }
}
