using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class Anulaciones
    {
        public decimal? NumCot { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaHora { get; set; }
        public string Estatus { get; set; }
        public string Observaciones { get; set; }
        public decimal? Orden { get; set; }
        public short? OrigenAnulacion { get; set; }
        public short? TipoAnulacion { get; set; }
    }
}
