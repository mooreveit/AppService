using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Depofacil
    {
        public string NumeroTabla { get; set; }
        public long Consecutivo { get; set; }
        public string TipoAccion { get; set; }
        public string TipoRif { get; set; }
        public string NumeroRif { get; set; }
        public string RangoValidaCliente { get; set; }
        public string RangoValidaRif { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string FlagTxt { get; set; }
        public double IdCliente { get; set; }
    }
}
