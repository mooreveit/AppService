using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class PromedioDelDolarPorMes
    {
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public float? Promedio { get; set; }
        public Guid Rowguid { get; set; }
    }
}
