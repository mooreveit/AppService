using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy598
    {
        public int IdRegistro { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal PorcentajeMinimoPeso { get; set; }
        public decimal PorcentajeMaximoPeso { get; set; }
        public decimal PorcentajeMinimoVolumen { get; set; }
        public decimal PorcentajeMaximoVolumen { get; set; }
        public string EquipoUpdate { get; set; }
        public string UsuarioUpdate { get; set; }
        public DateTime FechaUpdate { get; set; }
    }
}
