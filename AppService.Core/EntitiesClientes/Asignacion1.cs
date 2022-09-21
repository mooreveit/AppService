using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Asignacion1
    {
        public double? AsignacionActual { get; set; }
        public double? AsignacionNueva { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Oficina { get; set; }
    }
}
