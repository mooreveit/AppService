using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Winy250
    {
        public decimal Id { get; set; }
        public string Estacion { get; set; }
        public string DescripcionEstacion { get; set; }
        public string AfectaAjusteFiscal { get; set; }
        public string Abreviado { get; set; }
        public string NombreColumna { get; set; }
    }
}
