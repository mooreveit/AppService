using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class BarridoAsig
    {
        public string Codigo { get; set; }
        public string CodigoActual { get; set; }
        public string Nombre { get; set; }
        public string Asignacion { get; set; }
        public string AsignacionActual { get; set; }
        public string Cobrador { get; set; }
        public string CobradorActual { get; set; }
        public string Vendedor1 { get; set; }
        public string VendedorActual { get; set; }
        public decimal? Monto { get; set; }
        public decimal? Saldo { get; set; }
        public int Diferente { get; set; }
    }
}
