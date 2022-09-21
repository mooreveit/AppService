using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaMedidasOpuestasYanchosCashRoll
    {
        public int Id { get; set; }
        public decimal CantPartes { get; set; }
        public string MedidaOpuesta { get; set; }
        public decimal? AnchosAproducir { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
