using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Winy025
    {
        public decimal Recnum { get; set; }
        public string Mes { get; set; }
        public string TipoProducto { get; set; }
        public int Anuladas { get; set; }
        public int Nc { get; set; }
        public int Normales { get; set; }
        public short MesNumero { get; set; }
    }
}
