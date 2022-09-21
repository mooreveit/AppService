using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VDiasCriticoPorEstacion
    {
        public short IdTitulo { get; set; }
        public short IdOficina { get; set; }
        public short Prioridad { get; set; }
        public string Estacion { get; set; }
    }
}
