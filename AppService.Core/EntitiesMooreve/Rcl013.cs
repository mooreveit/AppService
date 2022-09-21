using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Rcl013
    {
        public int Id { get; set; }
        public string IdUsuarioActual { get; set; }
        public string IdUsuarioNuevo { get; set; }
        public string IdUsuarioCrea { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public DateTime FechaCrea { get; set; }
    }
}
