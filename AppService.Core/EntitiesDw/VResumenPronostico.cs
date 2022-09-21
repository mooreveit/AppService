using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class VResumenPronostico
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public short? Oficina { get; set; }
        public string NombOfic { get; set; }
        public string Supervisor { get; set; }
        public string Vendedor { get; set; }
        public string NombreVendedor { get; set; }
        public double? Saldo { get; set; }
        public double? Pronosticado { get; set; }
        public double? Ajustar { get; set; }
    }
}
