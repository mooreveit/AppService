using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapTmpEsMercanciaProducida
    {
        public decimal Id { get; set; }
        public string Indicador { get; set; }
        public string Cep { get; set; }
        public string Material { get; set; }
        public long Orden { get; set; }
        public decimal? Lote { get; set; }
        public decimal Cantidad { get; set; }
        public bool Confirmado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
