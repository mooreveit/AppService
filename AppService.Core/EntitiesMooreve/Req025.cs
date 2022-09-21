using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req025
    {
        public long Id { get; set; }
        public long IdSubDetalleTarea { get; set; }
        public long IdDetalleTarea { get; set; }
        public long IdTarea { get; set; }
        public string IdResponsable { get; set; }
        public byte IdEstacion { get; set; }
        public string IdEstatus { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
