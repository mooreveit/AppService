using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy004
    {
        public decimal Recnum { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Es { get; set; }
        public string AfectaConsumo { get; set; }
        public string AfectaFifo { get; set; }
        public string GeneraHijo { get; set; }
        public string TransGenera { get; set; }
        public string GeneraNuevoPa { get; set; }
        public string Eliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModif { get; set; }
        public short SignoFifo { get; set; }
    }
}
