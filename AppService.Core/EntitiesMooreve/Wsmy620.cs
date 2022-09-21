using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy620
    {
        public int IdRegistro { get; set; }
        public string Compañia { get; set; }
        public string TipoLibro { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public byte Forecast { get; set; }
        public string Responsable { get; set; }
        public string Observaciones { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
