using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req023
    {
        public int Id { get; set; }
        public int IdDelegacion { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string IdResponsable { get; set; }
        public string IdNuevoResponsable { get; set; }
    }
}
