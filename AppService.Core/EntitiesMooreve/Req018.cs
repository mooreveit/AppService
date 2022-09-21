using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req018
    {
        public long Id { get; set; }
        public long IdTarea { get; set; }
        public long IdRequerimiento { get; set; }
        public short IdSubCategoria { get; set; }
        public int IdPrograma { get; set; }
        public int IdRol { get; set; }
        public int IdPlantilla { get; set; }
        public string IdCargo { get; set; }
        public string IdResponsable { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Script { get; set; }
        public string Hpsm { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
