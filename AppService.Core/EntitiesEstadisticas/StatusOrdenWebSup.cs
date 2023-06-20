using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class StatusOrdenWebSup
    {
        public string CodigoSuperv { get; set; }
        public string NombreVendedor { get; set; }
        public string NombreCliente { get; set; }
        public string Cotizacion { get; set; }
        public string Orden { get; set; }
        public string StatusOrden { get; set; }
        public string FechaPrometida { get; set; }
        public decimal? DiasHabiles { get; set; }
        public string Estacion1 { get; set; }
    }
}
