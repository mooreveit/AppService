using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Estacion
    {
        public decimal Id { get; set; }
        public string Estacion1 { get; set; }
        public decimal? Prioridad { get; set; }
        public string Obligatoria { get; set; }
        public string Automatica { get; set; }
        public string Replanificar { get; set; }
        public string Simultaneidad { get; set; }
        public string FlagFacturacion { get; set; }
    }
}
