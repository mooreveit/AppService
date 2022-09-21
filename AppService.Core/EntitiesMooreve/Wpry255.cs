using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry255
    {
        public int Id { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Estatus { get; set; }
    }
}
