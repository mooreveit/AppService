using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaPorcDesperdicio
    {
        public decimal Id { get; set; }
        public decimal MillaresDesde { get; set; }
        public decimal MillaresHasta { get; set; }
        public int CantTintas { get; set; }
        public decimal? PorcDersperdicio { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
