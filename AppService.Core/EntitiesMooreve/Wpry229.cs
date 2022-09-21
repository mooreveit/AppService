using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry229
    {
        public Wpry229()
        {
            Wpry231 = new HashSet<Wpry231>();
        }

        public int IdSolicitud { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public long? Orden { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public short IdTipoProducto { get; set; }
        public decimal CantidadProducto { get; set; }
        public byte IdTipoCantidad { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorLista { get; set; }
        public string Observaciones { get; set; }
        public short IdMaquina { get; set; }
        public short? TipoOrden { get; set; }
        public string FlagFiscal { get; set; }
        public long? OrdenAnterior { get; set; }
        public string NumDesde { get; set; }
        public string NumHasta { get; set; }
        public string Instrucciones { get; set; }
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
        public long? NumeroSdf { get; set; }
        public int? TalonExtra { get; set; }
        public bool? FlagNoTieneDiseno { get; set; }
        public decimal? RvalorVenta { get; set; }
        public decimal? RvalorLista { get; set; }
        public decimal? ValorVentaUsd { get; set; }

        public virtual Wsmy501 CotizacionNavigation { get; set; }
        public virtual ICollection<Wpry231> Wpry231 { get; set; }
    }
}
