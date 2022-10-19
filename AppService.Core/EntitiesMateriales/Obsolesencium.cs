using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Obsolesencium
    {
        public string Codigo { get; set; }
        public int? Rollo { get; set; }
        public DateTime? Mesano { get; set; }
        public double? Cantidad { get; set; }
        public DateTime? Fecha { get; set; }
        public int? RolloOld { get; set; }
    }
}
