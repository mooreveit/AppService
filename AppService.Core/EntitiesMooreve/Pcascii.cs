using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Pcascii
    {
        public int Id { get; set; }
        public string Ficha { get; set; }
        public string Clave { get; set; }
        public string Codigo { get; set; }
        public decimal? NetoPagado { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public string Nombre { get; set; }
    }
}
