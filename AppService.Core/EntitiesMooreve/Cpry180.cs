using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Cpry180
    {
        public short IdHorario { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public string Laborable { get; set; }
        public string PrimerBloque { get; set; }
        public string Almuerzo { get; set; }
    }
}
