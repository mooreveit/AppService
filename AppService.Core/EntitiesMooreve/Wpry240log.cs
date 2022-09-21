using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry240log
    {
        public int Recnum { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public int IdParte { get; set; }
        public string IdPapel { get; set; }
        public int IdConstruccion { get; set; }
        public decimal LargoCm { get; set; }
        public decimal AnchoCm { get; set; }
        public decimal Cantidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? MedidaBase { get; set; }
        public int? MedidaOpuesta { get; set; }
        public long? Orden { get; set; }
        public string FrasesMarginales { get; set; }
        public DateTime? FechaEliminado { get; set; }
        public string UsuarioElimino { get; set; }
    }
}
