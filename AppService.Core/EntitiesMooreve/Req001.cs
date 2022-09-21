using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req001
    {
        public long Id { get; set; }
        public long IdRequerimiento { get; set; }
        public string IdUsuario { get; set; }
        public string IdDepartamento { get; set; }
        public byte IdAreaNegocio { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Justificacion { get; set; }
        public byte IdPrioridad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
    }
}
