using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VCantidadOrdene
    {
        public long Orden { get; set; }
        public int CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaArchivo { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string Oficina { get; set; }
        public string NombreOficina { get; set; }
    }
}
