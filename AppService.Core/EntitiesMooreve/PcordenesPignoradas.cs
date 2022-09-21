using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PcordenesPignoradas
    {
        public int Id { get; set; }
        public string Orden { get; set; }
        public string Cotizacion { get; set; }
        public string IdVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal? Valor { get; set; }
        public bool? EsValorAbsoluto { get; set; }
    }
}
