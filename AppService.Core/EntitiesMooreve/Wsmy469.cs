using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy469
    {
        public decimal Id { get; set; }
        public string Rif { get; set; }
        public DateTime? Fecha { get; set; }
        public long? Orden { get; set; }
        public string Cotizacion { get; set; }
        public short? Copy { get; set; }
        public string Producto { get; set; }
        public string NumeroSerieControlDesde { get; set; }
        public string NumeroControlDesde { get; set; }
        public string NumeroSerieControlHasta { get; set; }
        public string NumeroControlHasta { get; set; }
        public string NumeroSerieFormatoDesde { get; set; }
        public string NumeroFormatoDesde { get; set; }
        public string NumeroSerieFormatoHasta { get; set; }
        public string NumeroFormatoHasta { get; set; }
        public string TipoDocumento { get; set; }
        public decimal? LongitudMascara { get; set; }
        public string UsuarioAgrega { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaHoraAgrega { get; set; }
        public DateTime? FechaHoraModifica { get; set; }
        public long? NumeroSdf { get; set; }
        public decimal? IdDireccionFacturar { get; set; }
        public decimal? IdDireccionEntregar { get; set; }
    }
}
