using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy702
    {
        public long RecNum { get; set; }
        public long Id { get; set; }
        public string IdUsuario { get; set; }
        public string IdProducto { get; set; }
        public string NombreForma { get; set; }
        public decimal Millares { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public bool? FlagAprobado { get; set; }
        public DateTime? FechaAprobado { get; set; }
        public bool? FlagRechazado { get; set; }
        public DateTime? FechaRechazado { get; set; }
        public string Observaciones { get; set; }
        public string MailPlanificacion { get; set; }
        public string MailConsultor { get; set; }
    }
}
