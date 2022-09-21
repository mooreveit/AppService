using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy531
    {
        public string Compañia { get; set; }
        public string TipoLibro { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public byte Forecast { get; set; }
        public string Responsable { get; set; }
        public string Estatus { get; set; }
        public string ResponsableEstacion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Observaciones { get; set; }
        public long? Id { get; set; }
        public string Cerrada { get; set; }

        public virtual Wsmy530 EstatusNavigation { get; set; }
        public virtual Wsmy527 ForecastNavigation { get; set; }
        public virtual Wsmy535 MesNavigation { get; set; }
        public virtual Wsmy528 TipoLibroNavigation { get; set; }
    }
}
