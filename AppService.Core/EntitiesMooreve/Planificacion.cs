using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Planificacion
    {
        public decimal Id { get; set; }
        public decimal IdEstacion { get; set; }
        public DateTime? FechaInicioEstimada { get; set; }
        public DateTime? FechaFinalEstimada { get; set; }
        public long Orden { get; set; }
        public string Producto { get; set; }
        public byte? Secuencia { get; set; }
        public decimal? IdEstacionPase { get; set; }
        public short? IdMaquina { get; set; }
    }
}
