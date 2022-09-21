using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class ComparativoClientesMaracay
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
        public string Zona { get; set; }
    }
}
