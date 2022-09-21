using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy525
    {
        public string Compañia { get; set; }
        public string TipoLibro { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public byte Forecast { get; set; }
        public string CuentaHfm { get; set; }
        public string CuentaCorta { get; set; }
        public string CentroCosto { get; set; }
        public string CuentaObjeto { get; set; }
        public string Subcuenta { get; set; }
        public string CuentaContable { get; set; }
        public string NombreCuenta { get; set; }
        public decimal? Monto { get; set; }

        public virtual Wsmy527 ForecastNavigation { get; set; }
        public virtual Wsmy535 MesNavigation { get; set; }
        public virtual Wsmy528 TipoLibroNavigation { get; set; }
    }
}
