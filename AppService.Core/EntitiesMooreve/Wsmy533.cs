using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy533
    {
        public decimal Id { get; set; }
        public string CuentaHfm { get; set; }
        public string DescripcionHfm { get; set; }
        public string CuentaCorta { get; set; }
        public string CuentaContable { get; set; }
        public string DescripcionCuenta { get; set; }
        public string Responsable { get; set; }
        public DateTime FechaResponsable { get; set; }
    }
}
