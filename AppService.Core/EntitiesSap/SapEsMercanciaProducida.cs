using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapEsMercanciaProducida
    {
        public decimal Id { get; set; }
        public string Indicador { get; set; }
        public string Cep { get; set; }
        public string Material { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Costo { get; set; }
        public string Centro { get; set; }
        public string Almacen { get; set; }
        public string Lote { get; set; }
        public string Cliente { get; set; }
        public string Procesado { get; set; }
        public string FechaRegistro { get; set; }
        public string HoraRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
