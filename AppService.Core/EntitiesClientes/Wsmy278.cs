using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Wsmy278
    {
        public long Numero { get; set; }
        public short? IdCarta { get; set; }
        public string EmailCliente { get; set; }
        public string NombreCliente { get; set; }
        public string NombreContacto { get; set; }
        public decimal? Orden { get; set; }
        public decimal? Documento { get; set; }
        public int? Bultos { get; set; }
        public decimal? NroGuia { get; set; }
        public string Transporte { get; set; }
        public string EmailVendedor { get; set; }
        public string NombreProducto { get; set; }
        public string Flag { get; set; }
        public string NombreVendedor { get; set; }
        public decimal? CantFormas { get; set; }
        public decimal? UnidadCosteo { get; set; }
        public int Id { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
