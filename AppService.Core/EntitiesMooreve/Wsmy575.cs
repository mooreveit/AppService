using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy575
    {
        public long Id { get; set; }
        public string Usuario { get; set; }
        public string Maquina { get; set; }
        public int? IdRol { get; set; }
        public int? IdModulo { get; set; }
        public long? IdRegistro { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
