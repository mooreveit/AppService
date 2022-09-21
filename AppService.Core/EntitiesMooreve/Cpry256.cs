using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Cpry256
    {
        public long Orden { get; set; }
        public long Job { get; set; }
        public short IdMaquina { get; set; }
        public string IdProducto { get; set; }
        public long Cantidad { get; set; }
        public decimal DiasTrabajo { get; set; }
        public int CantidadJobs { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
