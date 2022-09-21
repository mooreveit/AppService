using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpey222
    {
        public int Id { get; set; }
        public long? Orden { get; set; }
        public long? Formas { get; set; }
        public long? Pies { get; set; }
        public decimal? Kilos { get; set; }
        public string CodigoPapel { get; set; }
        public string NombrePapel { get; set; }
        public int? CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime? FechaConsumo { get; set; }
        public string Usuario { get; set; }
    }
}
