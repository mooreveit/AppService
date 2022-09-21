using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy524
    {
        public string Compañia { get; set; }
        public string TipoLibro { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public byte Forecast { get; set; }
        public string CuentaHfm { get; set; }
        public string NombreCuenta { get; set; }
        public decimal? Monto { get; set; }

        public virtual Wsmy527 ForecastNavigation { get; set; }
        public virtual Wsmy535 MesNavigation { get; set; }
        public virtual Wsmy528 TipoLibroNavigation { get; set; }
    }
}
