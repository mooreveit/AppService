using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Cambioasigptolacruz
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double? AsignacionActual { get; set; }
        public double? AsignacionNueva { get; set; }
        public double? Oficina { get; set; }
    }
}
