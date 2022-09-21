using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwControlPronostico
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Activo { get; set; }
        public string Modificar { get; set; }
        public double? AñoAnalisis { get; set; }
        public double? MesAnalisis { get; set; }
        public decimal Id { get; set; }
    }
}
