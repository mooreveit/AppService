using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Vendjde
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cobrador { get; set; }
        public string Activo { get; set; }
        public double? Oficina { get; set; }
        public string NomOficina { get; set; }
        public double? CodJde { get; set; }
    }
}
