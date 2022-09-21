using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req007
    {
        public int Id { get; set; }
        public int IdPlantilla { get; set; }
        public string IdCargo { get; set; }
        public short IdSubcategoria { get; set; }
        public int IdPrograma { get; set; }
        public int IdRol { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
